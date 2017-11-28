using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace PTUtility.Utility
{
    public static class Convertion
    {
        public static string BinaryToHex(string stringBinary)
        {
            StringBuilder result = new StringBuilder(stringBinary.Length / 8 + 1);
            int mod4Len = stringBinary.Length % 8;
            if (mod4Len != 0)
            { 
                stringBinary = stringBinary.PadLeft(((stringBinary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < stringBinary.Length; i += 8)
            {
                string eightBits = stringBinary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            } 
            return result.ToString();
        }

        public static string HexToBinary(string p0)
        {
            //byte[] p0ByteArray = Encoding.ASCII.GetBytes(p0);
            return String.Join(String.Empty, p0.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        }

        public static byte[] StringToByteArrayBase16(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static byte[] StringToByteArrayBase8(string hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 8);
            return bytes;
        }

        public static byte[] StringToByteArray(string str)
        {
            //int NumberChars = hex.Length;
            //byte[] bytes = new byte[NumberChars / 2];
            //for (int i = 0; i < NumberChars; i += 2)
            //    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 8);
            //return bytes; 
            Dictionary<string, byte> hexindex = new Dictionary<string, byte>();
            for (int i = 0; i <= 255; i++)
                hexindex.Add(i.ToString("X2"), (byte)i);

            List<byte> hexres = new List<byte>();
            for (int i = 0; i < str.Length; i += 2)
                hexres.Add(hexindex[str.Substring(i, 2)]);

            return hexres.ToArray();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

        public static string ByteArrayToString(byte[] ba, int p1)
        {
            string hex = BitConverter.ToString(ba, p1);
            return hex.Replace("-", "");
        }

        public static string ByteArrayToString(byte[] ba, int p1, int p2)
        {
            string hex = BitConverter.ToString(ba, p1, p2);
            return hex.Replace("-", "");
        }

        public static string HexToAscii(string hexString)
        {
            //string test = "";
            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < hexString.Length; i += 2)
            {
                //string hs = hexString.Substring(i, 2);
                ////test = string.Format("{0}{1}", test, (char)HexToDecimal(hexString.Substring(i, 2)));
                //test = string.Format("{0}{1}", test, Encoding.ASCII.GetChars(new byte[] { (byte)HexToDecimal(hexString.Substring(i, 2)) })[0]);
                //Console.WriteLine(sb.ToString()); 
                sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber))));
            } 
            return sb.ToString();
        }

        public static int HexToDecimal(string hex)
        {
            int returnVal = 0;
            int intCtr = 0;
            bool bolTrue = false;

            if(hex.Substring(0,1) == "0")
            {
                if(hex.Length == 2)
                {
                    hex = hex.Substring(1, 1);
                }
                else
                {
                    hex = hex.Substring(0, 1);
                }
            } 

            while(!bolTrue)
            {
                //val = Convert.ToInt32(hex);
                //x = val.ToString("X");
                if (hex == intCtr.ToString("X"))
                {
                    returnVal = intCtr;
                    bolTrue = true;
                }
                intCtr++;
            }

            return returnVal;
        }

        //Public Function ConvertHexToDecimal(strHex As String) As Integer

        //Dim intCtr As Integer
        //Dim bolTrue  As Boolean

        // bolTrue = False
        // intCtr = 0

        //If Left(strHex, 1) = "0" Then strHex = Right(strHex, 1)

        // While bolTrue = False

        //    If strHex = Hex(intCtr) Then
        //        ConvertHexToDecimal = intCtr
        //        bolTrue = True
        //    End If
    
        //    intCtr = intCtr + 1
    
        // Wend
 
        //End Function

        public static string AsciiToHex(string ascii)
        { 
            return ByteArrayToString(Encoding.ASCII.GetBytes(ascii));  
        }

        //public string ConvertToASCII(string strHex)
        //{

        //    int intCtr = 0;
        //    int intPOS = 0;
        //    string strASCII = "";
        //    string strASCIIMsg = "";
        //    int intASCCI = 0;


        //    intCtr = Strings.Len(strHex);


        //    for (intPOS = 1; intPOS <= intCtr; intPOS++)
        //    {
        //        intASCCI = Strings.Asc(Strings.Mid(strHex, intPOS, 1));

        //        strASCII = Conversion.Hex(Convert.ToInt32(intASCCI));

        //        if (Strings.Len(strASCII) == 1)
        //        {
        //            strASCII = "0" + strASCII;
        //        }

        //        strASCIIMsg = strASCIIMsg + strASCII;

        //    }

        //    return strASCIIMsg;

        //}


        private static byte[] FromBase64Url(string base64Url)
        {
            string padded = base64Url.Length % 4 == 0
                ? base64Url : base64Url + "====".Substring(base64Url.Length % 4);
            string base64 = padded.Replace("_", "/")
                                    .Replace("-", "+");
            return Convert.FromBase64String(base64);
        }

        // from JWT spec
        public static byte[] Base64UrlDecode(string input)
        {
            var output = input;
            output = output.Replace('-', '+'); // 62nd char of encoding  
            output = output.Replace('_', '/'); // 63rd char of encoding  
            switch (output.Length % 4) // Pad with trailing '='s  
            {
                case 0: break; // No pad chars in this case  
                case 2: output += "=="; break; // Two pad chars  
                case 3: output += "="; break; // One pad char  
                default: throw new System.Exception("Invalid Base64URL String");
            }
            var converted = Convert.FromBase64String(output); // Standard base64 decoder  
            return converted;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        } 
    } 
}
