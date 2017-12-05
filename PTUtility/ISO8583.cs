using PTUtility.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTUtility
{
    public static class ISO8583
    {

        public static string[] Message = new string[65];
        //65bit
        //public static int[] FieldLength = new int[65]{ 0, 
        //                                        0, 2, 6, 12, 12, 12, 10, 8, 8, 8, 6, 6, 4, 4, 4, 4, 
        //                                        4, 4, 3, 3, 3, 4, 3, 4, 2, 2, 1, 8, 8, 8, 8, 2,
        //                                        2, 2, 2, 3, 24, 6, 4, 3, 16, 30, 40, 2, 2, 3, 3, 3,
        //                                        3, 3, 3, 16, 32, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 16};
        public static int[] FieldLength = new int[65]{ 0, 
                                                0, 2, 6, 12, 12, 12, 10, 8, 8, 8, 6, 6, 4, 4, 4, 4, 
                                                4, 4, 4, 4, 4, 4, 4, 4, 2, 2, 1, 8, 8, 8, 8, 2,
                                                2, 2, 2, 4, 24, 6, 4, 4, 16, 30, 40, 2, 2, 4, 4, 4,
                                                4, 4, 4, 16, 32, 4, 4, 4, 4, 4, 4, 1, 4, 4, 4, 16};

        public static string CreateBitmap(string[] Message)
        {
            string binary = "";

            for (int i = 1; i <= 64; i++)
            {
                if (Message[i] == null)
                    binary = string.Format("{0}{1}", binary, "0");
                else
                    binary = string.Format("{0}{1}", binary, "1");
            }
            Console.WriteLine("LENGHT:" + binary.Length); 
            return Convertion.BinaryToHex(binary);
        }

        public static string CreateMessage(string[] Message)
        {
            string message = string.Format("{0}{1}", Message[0], CreateBitmap(Message));
            for (int i = 1; i <= 64; i++)
            {
                if (Message[i] != null)
                    message = string.Format("{0}{1}", message, Message[i]);
            }
            return message;
        }

        public static string[] ParseMessage(string Message)
        {
            string origMessage = Message; //For the record (debugging)

            //Get Index of TPDU
            int getIndexOfTPDU = Message.IndexOf('`');

            //Get Message Length (Before TPDU)
            //int getMessageLength = Message.Substring(0, getIndexOfTPDU);

            //Switch Message
            Message = Message.Substring((getIndexOfTPDU + 1) + 4, Message.Length - (getIndexOfTPDU + 6));

            //string bitmap = Message.Substring(4, 16);
            string bitmap = Message.Substring(0, 16);

            string binaryBitmap = Convertion.HexToBinary(bitmap);
            string[] parsedMessage = new string[65];

            //int messagePosition = 20;
            int messagePosition = 16;

            int bitmapPosition = 0;
            int fieldLength = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 64; i++)
            {
                bitmapPosition = i + 1;
                fieldLength = FieldLength[bitmapPosition];
                if (binaryBitmap.Substring(i, 1) == "1")
                {
                    switch (bitmapPosition)
                    {
                        //Not Constant Length
                        case 2:
                        case 35:
                            fieldLength = Convert.ToInt16(Message.Substring(messagePosition, 2));
                            messagePosition += 2;
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                        case 43:
                            fieldLength = Convert.ToInt16(Message.Substring(messagePosition, 2));
                            messagePosition += 2;
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                        case 54:
                            fieldLength = Convert.ToInt16(Message.Substring(messagePosition, 4));
                            messagePosition += 4;
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                        case 55:
                            //fieldLength = Convert.ToInt16(Message.Substring(messagePosition, 4));
                            var testLength = Message.Substring(messagePosition, 4);
                            messagePosition += 4;
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                        //Hex value need convert to Ascii
                        case 37:
                        case 39:
                        case 41:
                        case 42:
                            //parsedMessage[bitmapPosition] = Convertion.HexToAscii(Message.Substring(messagePosition, fieldLength));
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                        //Constant Length
                        default:
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                    }
                    messagePosition += fieldLength;
                    sb.Append(string.Format("{0}:{1} {2}", (i + 1), parsedMessage[bitmapPosition], Environment.NewLine));
                }
            }
            Console.WriteLine(sb.ToString());
            return parsedMessage;
        }

        public static string[] ParseMessageEMVUpdate(string Message)
        {
            string origMessage = Message; //For the record (debugging)

            //Get Index of TPDU
            int getIndexOfTPDU = Message.IndexOf('`');

            //Get Message Length (Before TPDU)
            //int getMessageLength = Message.Substring(0, getIndexOfTPDU);

            //Switch Message
            
            //Message = Message.Substring((getIndexOfTPDU + 1) + 4, Message.Length - (getIndexOfTPDU + 6));

            string bitmap = Message.Substring(4, 16);
            string binaryBitmap = Convertion.HexToBinary(bitmap);
            string[] parsedMessage = new string[65];
            int messagePosition = 20;
            int bitmapPosition = 0;
            int fieldLength = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 64; i++)
            {
                bitmapPosition = i + 1;
                fieldLength = FieldLength[bitmapPosition];
                if (binaryBitmap.Substring(i, 1) == "1")
                {
                    switch (bitmapPosition)
                    {
                        //Not Constant Length
                        case 2:
                        case 35:
                            fieldLength = Convert.ToInt16(Message.Substring(messagePosition, 2));
                            messagePosition += 2;
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                        case 43: 
                        case 54: 
                        case 55: 
                        case 61:
                            fieldLength = Convert.ToInt16(Message.Substring(messagePosition, 4)) * 2;
                            messagePosition += 4;
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                        //Hex value need convert to Ascii
                        //case 37:
                        //case 39:
                        //case 41:
                        //case 42:
                        //    parsedMessage[bitmapPosition] = Convertion.HexToAscii(Message.Substring(messagePosition, fieldLength));
                        //    break;
                        //Constant Length
                        default:
                            parsedMessage[bitmapPosition] = Message.Substring(messagePosition, fieldLength);
                            break;
                    }
                    messagePosition += fieldLength;
                    sb.Append(string.Format("{0}:{1} {2}", (i + 1), parsedMessage[bitmapPosition], Environment.NewLine));
                }
            }
            Console.WriteLine(sb.ToString());
            return parsedMessage;
        }

        public static string MessageLengthToAscii(int intMLength)
        {
            string strM = "";

            if (intMLength < 256)
            {
                char x = Encoding.Default.GetChars(new byte[]{ (byte)intMLength })[0];
                strM = string.Format("{0}", Convert.ToChar(0).ToString() + x.ToString());
                //strM = string.Format("{0}", Convert.ToChar(0).ToString() + Convert.ToChar(intMLength).ToString());
            }
            else if (intMLength < 512)
            {
                strM = string.Format("{0}", Convert.ToChar(1).ToString() + Convert.ToChar(intMLength - 256).ToString());
            }
            else if (intMLength < 768)
            {
                strM = string.Format("{0}", Convert.ToChar(1).ToString() + Convert.ToChar(0).ToString() + Convert.ToChar(intMLength - 512).ToString());
            }
            else if (intMLength < 1024)
            {
                strM = string.Format("{0}", Convert.ToChar(1).ToString() + Convert.ToChar(1).ToString() + Convert.ToChar(intMLength - 768).ToString());
            }
            else
            {
                strM = string.Format("{0}", Convert.ToChar(1).ToString() + Convert.ToChar(1).ToString() + Convert.ToChar(255).ToString());
            }

            return strM;
        }

        public static int MessageLengthToHex(string ascii)
        {
            int leftDigit1 = (int)Convert.ToChar(ascii.Substring(0, 1));
            int rightDigit1 = (int)Convert.ToChar(ascii.Substring(ascii.Length - 1, 1));
            byte[] x = Encoding.Default.GetBytes(ascii.Substring(0, 1) + ascii.Substring(ascii.Length - 1, 1));
            int leftDigit = Convert.ToInt32(x[0].ToString());
            int rightDigit = Convert.ToInt32(x[1].ToString());
            return (leftDigit * 256) + rightDigit;
        }
    }
}
