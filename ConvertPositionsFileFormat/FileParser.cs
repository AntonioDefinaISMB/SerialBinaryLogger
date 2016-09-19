using DLLCommonTypes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ConvertPositionsFileFormat
{
    public enum PositionFieldOutput
    {
        LATITUDE,
        LONGITUDE,
        HEIGHT,
        DIRECTION,
        SPEED,
        FIXINDICATOR,
        NUMBEROFSAT,
        HDOP,
        TOW,
        WN,
        MAXFIELD
    }

    public enum PositionFieldExtracted
    {
        LABEL,
        LONGITUDE,
        LATITUDE,
        MAXFIELD
    }

    public static class FileParser
    {
        const string SeparatorFields2Extract    = "|";
        const string SeparatorFieldOutput       = ";";

        static NumberFormatInfo numberFormat = new NumberFormatInfo();

        static FileParser()
        {
            numberFormat.NumberGroupSeparator = "'";
            // Set the decimal seperator
            numberFormat.NumberDecimalSeparator = ".";
        }

        static List<String> listPositionContainer = new List<string>()
        {
            { "POS" },
            { "REF" }
        };

        public static bool IsLinePosition(string line)
        {
            foreach(string item in listPositionContainer)
            {
                if (line.StartsWith(item))
                    return true;
            }
            return false;
        }

        public static bool ExtractPositionFromString(string line,ref Position pos)
        {
            if(line.Contains(SeparatorFields2Extract)==false)
            {
                return false;
            }

            String[] Parameters = line.Split(SeparatorFields2Extract.ToCharArray());

            for(int field=0;field<(int)PositionFieldExtracted.MAXFIELD; field++)
            {
                switch((PositionFieldExtracted)field)
                {
                    case PositionFieldExtracted.LATITUDE:
                        pos.Latitude = double.Parse(Parameters[field], numberFormat);
                    break;

                    case PositionFieldExtracted.LONGITUDE:
                        pos.Longitude = double.Parse(Parameters[field], numberFormat);
                        break;

                    default:

                    break;
                }
            }

            return true;
        }

        public static String ConvertPos2String(Position position)
        {
            StringBuilder   bufferString = new StringBuilder();
            String          returnString = "";

            String          singleFieldString;

            for(int indexField=0;indexField<(int)PositionFieldOutput.MAXFIELD;indexField++)
            {
                singleFieldString = "";
                switch ((PositionFieldOutput)indexField)
                {
                    case PositionFieldOutput.LATITUDE:
                        singleFieldString = position.Latitude.ToString("G", CultureInfo.InvariantCulture);
                        break;
                    case PositionFieldOutput.LONGITUDE:
                        singleFieldString = position.Longitude.ToString("G", CultureInfo.InvariantCulture);
                        break;
                    case PositionFieldOutput.HEIGHT:
                        singleFieldString = position.Height.ToString("G", CultureInfo.InvariantCulture);
                        break;
                    case PositionFieldOutput.SPEED:
                        singleFieldString = position.Speed.ToString();
                        break;
                    case PositionFieldOutput.NUMBEROFSAT:
                        singleFieldString = position.NumberOfSat.ToString();
                        break;
                    case PositionFieldOutput.DIRECTION:
                        singleFieldString = position.Direction.ToString("F2", CultureInfo.InvariantCulture);
                        break;
                    case PositionFieldOutput.HDOP:
                        singleFieldString = position.HDOP.ToString();
                        break;
                    case PositionFieldOutput.WN:
                        singleFieldString = position.WeekNumber.ToString();
                        break;
                    case PositionFieldOutput.TOW:
                        singleFieldString = position.TimeOfWeek.ToString("G", CultureInfo.InvariantCulture);
                        break;
                    case PositionFieldOutput.FIXINDICATOR:
                        singleFieldString = position.FixIndicator.ToString();
                        break;
                    default:
                        break;
                }

                if (singleFieldString.Length > 0)
                {
                    bufferString.Append(singleFieldString);

                    if (indexField < (int)PositionFieldOutput.MAXFIELD - 1)
                    {
                        bufferString.Append(SeparatorFieldOutput);
                    }
                }
            }

            returnString = bufferString.ToString();
            returnString += "\r\n";

            return returnString;
        }

        public static bool ConvertTNTFile2ASSISTPos(String PathInput,String PathOutput,int WeekNumber,double timeofWeekStart,double deltaTime, ref String MessageError)
        {
            String lineFile         = "";
            String lineFileOutput   = "";
            try
            {
                MessageError = "";

                StreamReader sr = new StreamReader(PathInput);
                StreamWriter sw = new StreamWriter(PathOutput);
                Position extractedPos       = new Position();
                Position previousPosition   = null;
                double timeOfWeek = timeofWeekStart;

                while (sr.EndOfStream == false)
                {
                    lineFile = sr.ReadLine();

                    if (lineFile.Length > 0 && IsLinePosition(lineFile))
                    {
                        lineFile = lineFile.Replace('\n', (char)0);
                        lineFile = lineFile.Replace('\r', (char)0);

                        if (ExtractPositionFromString(lineFile, ref extractedPos) == true)
                        {
                            extractedPos.TimeOfWeek = timeOfWeek;
                            extractedPos.WeekNumber = WeekNumber;

                            timeOfWeek += deltaTime;

                            if (previousPosition != null)
                            {
                                previousPosition.Direction = DLLConversionGeographicData.ConversionGPS.GetHeading(previousPosition, extractedPos);

                                lineFileOutput = ConvertPos2String(previousPosition);

                                if (lineFileOutput != null && lineFileOutput.Length > 0)
                                {
                                    sw.Write(lineFileOutput);
                                    sw.Flush();
                                }
                            }
                            
                            if(previousPosition==null)
                            {
                                previousPosition = new Position();
                            }
                            previousPosition.Copy(extractedPos);
                        }
                    }
                }
                sr.Close();
                sw.Close();

                return true;
            }
            catch(Exception exc)
            {
                MessageError = exc.Message;
                return false;
            }
        }

    }
}
