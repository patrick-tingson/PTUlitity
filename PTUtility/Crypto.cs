using PTUtility.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PTUtility.Crypto
{ 
    public static class Hashing
    {
        public static string MD5(string stringToHash)
        {
            // create hash object
            using (MD5 hasher = new MD5CryptoServiceProvider())
            {
                hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(stringToHash));
                byte[] dbytes = hasher.Hash;
                StringBuilder sBuilder = new StringBuilder();

                for (int n = 0; n <= dbytes.Length - 1; n++)
                {
                    sBuilder.Append(dbytes[n].ToString("X2"));
                }
                return sBuilder.ToString();
            }
        }

        public static string SHA1(string stringToHash)
        {
            System.Security.Cryptography.SHA1Managed sha1Obj = new System.Security.Cryptography.SHA1Managed();
            byte[] bytesToHash = System.Text.Encoding.UTF8.GetBytes(stringToHash);
            bytesToHash = sha1Obj.ComputeHash(bytesToHash);
            return BitConverter.ToString(bytesToHash).Replace("-", "").ToUpper();
        }

    }

    public static class Encrypt
    {
        public static string AesCrypto32(string plainText32, string masterKey32, string iVector16)
        {
            string response = "";
            try
            {
                if (plainText32.Length == 0 || masterKey32.Length == 0 || iVector16.Length == 0)
                {
                    response = "";
                }
                else if (plainText32.Length != 32 || masterKey32.Length != 32 || iVector16.Length != 16)
                {
                    response = "";
                }
                else
                {
                    byte[] bytesEncryptedKey;

                    using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
                    {
                        byte[] key = System.Text.Encoding.UTF8.GetBytes(masterKey32);
                        byte[] iv = System.Text.Encoding.UTF8.GetBytes(iVector16);
                        aesAlg.Key = key;
                        aesAlg.IV = iv;
                        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                        using (MemoryStream msEncrypt = new MemoryStream())
                        {
                            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                            {
                                using (StreamWriter srEncrypt = new StreamWriter(csEncrypt))
                                {
                                    srEncrypt.Write(plainText32);
                                }
                                bytesEncryptedKey = msEncrypt.ToArray();
                                response = BitConverter.ToString(bytesEncryptedKey).Replace("-", "");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public static string TripleDES16(string plainText16, string masterKey16, string iVector8)
        {
            string response = "";
            try
            {
                if (plainText16.Length == 0 || masterKey16.Length == 0 || iVector8.Length == 0)
                {
                    response = "";
                }
                else if (plainText16.Length != 16 || masterKey16.Length != 16 || iVector8.Length != 8)
                {
                    response = "";
                }
                else
                {
                    byte[] bytesEncryptedKey;

                    using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
                    {
                        byte[] key = System.Text.Encoding.UTF8.GetBytes(masterKey16);
                        byte[] iv = System.Text.Encoding.UTF8.GetBytes(iVector8);
                        tdsAlg.Key = key;
                        tdsAlg.IV = iv;

                        ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);

                        using (MemoryStream msEncrypt = new MemoryStream())
                        {
                            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                            {
                                using (StreamWriter srEncrypt = new StreamWriter(csEncrypt))
                                {
                                    srEncrypt.Write(plainText16);
                                }
                                bytesEncryptedKey = msEncrypt.ToArray();
                                response = BitConverter.ToString(bytesEncryptedKey).Replace("-", "");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public static string TripleDES(string plainText, string masterKey16, string iVector8)
        {
            string response = "";
            try
            {
                byte[] bytesEncryptedKey;
                using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
                {
                    byte[] key = System.Text.Encoding.UTF8.GetBytes(masterKey16);
                    byte[] iv = System.Text.Encoding.UTF8.GetBytes(iVector8);
                    tdsAlg.Key = key;
                    tdsAlg.IV = iv;

                    ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter srEncrypt = new StreamWriter(csEncrypt))
                            {
                                srEncrypt.Write(plainText);
                            }
                            bytesEncryptedKey = msEncrypt.ToArray();
                            response = BitConverter.ToString(bytesEncryptedKey).Replace("-", "");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public static string RSA(string plainText, string publicKeyPEM)
        {
            if (plainText.Length == 0)
                throw new InvalidDataException("Invalid Plain Text.");
            if (publicKeyPEM.Length == 0)
                throw new InvalidDataException("Invalid Public Key PEM.");

            var bytesData = Encoding.UTF8.GetBytes(plainText);
            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    //Must be BancNet Public Key
                    rsa.LoadPublicKeyPEM(publicKeyPEM);
                    var encryptedData = rsa.Encrypt(bytesData, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            } 
        }

    }

    public static class Decrypt
    {
        public static string AesCrypto32(string encryptedKey96, string masterKey32, string iVector16)
        {
            string response = "";
            try
            {
                if (encryptedKey96.Length == 0 || masterKey32.Length == 0 || iVector16.Length == 0)
                {
                    response = "";
                }
                else if (encryptedKey96.Length != 96 || masterKey32.Length != 32 || iVector16.Length != 16)
                {
                    response = "";
                }
                else
                {
                    byte[] bytesEncryptedKey = new byte[48];
                    using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
                    {
                        byte[] key = System.Text.Encoding.UTF8.GetBytes(masterKey32);
                        byte[] iv = System.Text.Encoding.UTF8.GetBytes(iVector16);
                        aesAlg.Key = key;
                        aesAlg.IV = iv;

                        bytesEncryptedKey = Convertion.StringToByteArrayBase16(encryptedKey96);

                        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                        using (MemoryStream msDecrypt = new MemoryStream(bytesEncryptedKey))
                        {
                            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                            {
                                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                                {
                                    response = srDecrypt.ReadToEnd();
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public static string TripleDES(string encryptedText48, string masterKey16, string iVector8)
        {
            string response = "";
            try
            {
                byte[] bytesEncryptedKey = new byte[24];
                using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
                {
                    byte[] key = System.Text.Encoding.UTF8.GetBytes(masterKey16);
                    byte[] iv = System.Text.Encoding.UTF8.GetBytes(iVector8);
                    tdsAlg.Key = key;
                    tdsAlg.IV = iv;

                    bytesEncryptedKey = Convertion.StringToByteArrayBase16(encryptedText48);

                    ICryptoTransform decryptor = tdsAlg.CreateDecryptor(tdsAlg.Key, tdsAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(bytesEncryptedKey))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                response = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public static string TripleDES16(string encryptedText48, string masterKey16, string iVector8)
        {
            string response = "";
            try
            {
                if (encryptedText48.Length == 0 || masterKey16.Length == 0 || iVector8.Length == 0)
                {
                    response = "";
                }
                else if (encryptedText48.Length != 48 || masterKey16.Length != 16 || iVector8.Length != 8)
                {
                    response = "";
                }
                else
                {
                    byte[] bytesEncryptedKey = new byte[24];
                    using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
                    {
                        byte[] key = System.Text.Encoding.UTF8.GetBytes(masterKey16);
                        byte[] iv = System.Text.Encoding.UTF8.GetBytes(iVector8);
                        tdsAlg.Key = key;
                        tdsAlg.IV = iv;

                        bytesEncryptedKey = Convertion.StringToByteArrayBase16(encryptedText48);

                        ICryptoTransform decryptor = tdsAlg.CreateDecryptor(tdsAlg.Key, tdsAlg.IV);

                        using (MemoryStream msDecrypt = new MemoryStream(bytesEncryptedKey))
                        {
                            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                            {
                                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                                {
                                    response = srDecrypt.ReadToEnd();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public static string RSA(string plainText, string privateKeyPEM)
        {
            if (plainText.Length == 0)
                throw new InvalidDataException("Invalid Plain Text.");
            if (privateKeyPEM.Length == 0)
                throw new InvalidDataException("Invalid Private Key PEM.");

            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    //Must be BancNet Public Key
                    rsa.LoadPrivateKeyPEM(privateKeyPEM);
                    var resultBytes = Convert.FromBase64String(plainText);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        } 
    }

    public static class GenerateKeys
    {
        public static class RSA
        { 
            public static string ExportPrivatePEMKey(RSACryptoServiceProvider csp)
            {
                if (csp == null) throw new ArgumentException("Invalid CSP", "csp");
                if (csp.PublicOnly) throw new ArgumentException("CSP does not contain a private key", "csp");
                var parameters = csp.ExportParameters(true);
                using (var stream = new MemoryStream())
                {
                    var writer = new BinaryWriter(stream);
                    writer.Write((byte)0x30); // SEQUENCE
                    using (var innerStream = new MemoryStream())
                    {
                        var innerWriter = new BinaryWriter(innerStream);
                        EncodeIntegerBigEndian(innerWriter, new byte[] { 0x00 }); // Version
                        EncodeIntegerBigEndian(innerWriter, parameters.Modulus);
                        EncodeIntegerBigEndian(innerWriter, parameters.Exponent);
                        EncodeIntegerBigEndian(innerWriter, parameters.D);
                        EncodeIntegerBigEndian(innerWriter, parameters.P);
                        EncodeIntegerBigEndian(innerWriter, parameters.Q);
                        EncodeIntegerBigEndian(innerWriter, parameters.DP);
                        EncodeIntegerBigEndian(innerWriter, parameters.DQ);
                        EncodeIntegerBigEndian(innerWriter, parameters.InverseQ);
                        var length = (int)innerStream.Length;
                        EncodeLength(writer, length);
                        writer.Write(innerStream.GetBuffer(), 0, length);
                    }

                    var base64 = Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length).ToCharArray();
                    var sb = new StringBuilder();
                    sb.Append("-----BEGIN RSA PRIVATE KEY-----");
                    // Output as Base64 with lines chopped at 64 characters
                    for (var i = 0; i < base64.Length; i += 64)
                    {
                        sb.Append(base64, i, Math.Min(64, base64.Length - i));
                    }
                    sb.Append("-----END RSA PRIVATE KEY-----");

                    return sb.ToString();
                }
            } 
            public static string ExportPublicPEMKey(RSACryptoServiceProvider csp)
            {
                if (csp == null) throw new ArgumentException("Invalid CSP", "csp");
                var parameters = csp.ExportParameters(false);
                using (var stream = new MemoryStream())
                {
                    var writer = new BinaryWriter(stream);
                    writer.Write((byte)0x30); // SEQUENCE
                    using (var innerStream = new MemoryStream())
                    {
                        var innerWriter = new BinaryWriter(innerStream);
                        innerWriter.Write((byte)0x30); // SEQUENCE
                        EncodeLength(innerWriter, 13);
                        innerWriter.Write((byte)0x06); // OBJECT IDENTIFIER
                        var rsaEncryptionOid = new byte[] { 0x2a, 0x86, 0x48, 0x86, 0xf7, 0x0d, 0x01, 0x01, 0x01 };
                        EncodeLength(innerWriter, rsaEncryptionOid.Length);
                        innerWriter.Write(rsaEncryptionOid);
                        innerWriter.Write((byte)0x05); // NULL
                        EncodeLength(innerWriter, 0);
                        innerWriter.Write((byte)0x03); // BIT STRING
                        using (var bitStringStream = new MemoryStream())
                        {
                            var bitStringWriter = new BinaryWriter(bitStringStream);
                            bitStringWriter.Write((byte)0x00); // # of unused bits
                            bitStringWriter.Write((byte)0x30); // SEQUENCE
                            using (var paramsStream = new MemoryStream())
                            {
                                var paramsWriter = new BinaryWriter(paramsStream);
                                EncodeIntegerBigEndian(paramsWriter, parameters.Modulus); // Modulus
                                EncodeIntegerBigEndian(paramsWriter, parameters.Exponent); // Exponent
                                var paramsLength = (int)paramsStream.Length;
                                EncodeLength(bitStringWriter, paramsLength);
                                bitStringWriter.Write(paramsStream.GetBuffer(), 0, paramsLength);
                            }
                            var bitStringLength = (int)bitStringStream.Length;
                            EncodeLength(innerWriter, bitStringLength);
                            innerWriter.Write(bitStringStream.GetBuffer(), 0, bitStringLength);
                        }
                        var length = (int)innerStream.Length;
                        EncodeLength(writer, length);
                        writer.Write(innerStream.GetBuffer(), 0, length);
                    }

                    var base64 = Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length).ToCharArray();
                    var sb = new StringBuilder();
                    sb.Append("-----BEGIN PUBLIC KEY-----");
                    for (var i = 0; i < base64.Length; i += 64)
                    {
                        sb.Append(base64, i, Math.Min(64, base64.Length - i));
                    }
                    sb.Append("-----END PUBLIC KEY-----");

                    return sb.ToString();
                }
            } 
            private static void EncodeLength(BinaryWriter stream, int length)
            {
                if (length < 0) throw new ArgumentOutOfRangeException("length", "Length must be non-negative");
                if (length < 0x80)
                {
                    // Short form
                    stream.Write((byte)length);
                }
                else
                {
                    // Long form
                    var temp = length;
                    var bytesRequired = 0;
                    while (temp > 0)
                    {
                        temp >>= 8;
                        bytesRequired++;
                    }
                    stream.Write((byte)(bytesRequired | 0x80));
                    for (var i = bytesRequired - 1; i >= 0; i--)
                    {
                        stream.Write((byte)(length >> (8 * i) & 0xff));
                    }
                }
            } 
            private static void EncodeIntegerBigEndian(BinaryWriter stream, byte[] value, bool forceUnsigned = true)
            {
                stream.Write((byte)0x02); // INTEGER
                var prefixZeros = 0;
                for (var i = 0; i < value.Length; i++)
                {
                    if (value[i] != 0) break;
                    prefixZeros++;
                }
                if (value.Length - prefixZeros == 0)
                {
                    EncodeLength(stream, 1);
                    stream.Write((byte)0);
                }
                else
                {
                    if (forceUnsigned && value[prefixZeros] > 0x7f)
                    {
                        // Add a prefix zero to force unsigned if the MSB is 1
                        EncodeLength(stream, value.Length - prefixZeros + 1);
                        stream.Write((byte)0);
                    }
                    else
                    {
                        EncodeLength(stream, value.Length - prefixZeros);
                    }
                    for (var i = prefixZeros; i < value.Length; i++)
                    {
                        stream.Write(value[i]);
                    }
                }
            }
        }
    }
}
