using PTUtility.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTUtility.EMV
{
    public static class Tags
    {
        public const string AcquirerIdentifier  = "9F01";
        public const string AdditionalTerminalCapabilities  = "9F40";
        public const string AmountAuthorised  = "9F02";
        public const string AmountOther  = "9F03";
        public const string AmountReferenceCurrency  = "9F3A";
        public const string ApplicationCryptogram  = "9F26";
        public const string ApplicationCurrencyCode  = "9F42";
        public const string ApplicationCurrencyExponent  = "9F44";
        public const string ApplicationDiscretionaryData  = "9F05";
        public const string ApplicationEffectiveDate  = "5F25";
        public const string ApplicationExpirationDate  = "5F24";
        public const string ApplicationFileLocator  = "94";
        public const string ApplicationIdentifierCard  = "4F";
        public const string ApplicationIdentifierTerminal  = "9F06";
        public const string ApplicationInterchangeProfile  = "82";
        public const string ApplicationLabel  = "50";
        public const string ApplicationPreferredName  = "9F12";
        public const string PrimaryAccountNumber  = "5A";
        public const string PrimaryAccountSequenceNumber  = "5F34";
        public const string ApplicationPriorityIndicator  = "87";
        public const string ApplicationReferenceCurrency  = "9F3B";
        public const string ApplicationReferenceCurrencyExponent  = "9F43";
        public const string ApplicationTemplate  = "61";
        public const string ApplicationTransactionCounter  = "9F36";
        public const string ApplicationUsageControl  = "9F07";
        public const string ApplicationVersionNumber1  = "9F08";
        public const string ApplicationVersionNumber2  = "9F09";
        public const string AuthorisationCode  = "89";
        public const string AuthorisationResponseCode  = "8A";
        public const string BankIdentifierCode  = "5F54";
        public const string CardRiskManagementDataObjectList1  = "8C";
        public const string CardRiskManagementDataObjectList2  = "8D";
        public const string CardholderName  = "5F20";
        public const string CardholderNameExtended  = "9F0B";
        public const string CardholderVerificationMethodList  = "8E";
        public const string CardholderVerificationMethodResults  = "9F34";
        public const string CertificationAuthorityPublicKeyIndex1  = "8F";
        public const string CertificationAuthorityPublicKeyIndex2  = "9F22";
        public const string CommandTemplate  = "83";
        public const string CryptogramInformationData  = "9F27";
        public const string DataAuthenticationCode  = "9F45";
        public const string DedicatedFileName  = "84";
        public const string DirectoryDefinitionFileName  = "9D";
        public const string DirectoryDiscretionaryTemplate  = "73";
        public const string DynamicDataAuthenticationDataObjectList  = "9F49";
        public const string EMVProprietaryTemplate  = "70";
        public const string FCIIssuerDiscretionaryData  = "BF0C";
        public const string FCIProprietaryTemplate  = "A5";
        public const string FCITemplate  = "6F";
        public const string ICCDynamicNumber  = "9F4C";
        public const string ICCPINEnciphermentPublicKeyCertificate  = "9F2D";
        public const string ICCPINEnciphermentPublicKeyExponent  = "9F2E";
        public const string ICCPINEnciphermentPublicKeyRemainder  = "9F2F";
        public const string ICCPublicKeyCertificate  = "9F46";
        public const string ICCPublicKeyExponent  = "9F47";
        public const string ICCPublicKeyRemainder  = "9F48";
        public const string IFDSerialNumber  = "9F1E";
        public const string InternationalBankAccountNumber  = "5F53";
        public const string IssuerActionCodeDefault  = "9F0D";
        public const string IssuerActionCodeDenial  = "9F0E";
        public const string IssuerActionCodeOnline  = "9F0F";
        public const string IssuerApplicationData  = "9F10";
        public const string IssuerAuthenticationData  = "91";
        public const string IssuerCodeTableIndex  = "9F11";
        public const string IssuerCountryCode  = "5F28";
        public const string IssuerCountryCode2  = "5F55";
        public const string IssuerCountryCode3  = "5F56";
        public const string IssuerIdentificationNumber  = "42";
        public const string IssuerPublicKeyCertificate  = "90";
        public const string IssuerPublicKeyExponent  = "9F32";
        public const string IssuerPublicKeyRemainder  = "92";
        public const string IssuerScriptCommand  = "86";
        public const string IssuerScriptIdentifier  = "9F18";
        public const string IssuerScriptTemplate1  = "71";
        public const string IssuerScriptTemplate2  = "72";
        public const string IssuerURL  = "5F50";
        public const string LanguagePreference  = "5F2D";
        public const string LastOnlineApplicationTransactionCounterRegister  = "9F13";
        public const string LogEntry  = "9F4D";
        public const string LogFormat  = "9F4F";
        public const string LowerConsecutiveOfflineLimit  = "9F14";
        public const string MerchantCategoryCode  = "9F15";
        public const string MerchantIdentifier  = "9F16";
        public const string MerchantNameLocation  = "9F4E";
        public const string PINTryCounter  = "9F17";
        public const string POSEntryMode  = "9F39";
        public const string ProcessingOptionsDataObjectList  = "9F38"; 
        public const string ResponseMessageTemplateFormat1  = "80";
        public const string ResponseMessageTemplateFormat2  = "77";
        public const string ServiceCode  = "5F30";
        public const string ShortFileIdentifier  = "88";
        public const string SignedDynamicApplicationData  = "9F4B";
        public const string SignedStaticApplicationData  = "93";
        public const string StaticDataAuthenticationTagList = "9F4A";
        public const string Track2Data = "57";
        public const string Track1Data = "9F1F";
        public const string TerminalCapabilities  = "9F33";
        public const string TerminalCountryCode  = "9F1A";
        public const string TerminalFloorLimit  = "9F1B";
        public const string TerminalIdentification  = "9F1C";
        public const string TerminalRiskManagementData  = "9F1D";
        public const string TerminalType  = "9F35";
        public const string TerminalVerificationResults  = "95";  
    }
    
    public class TNLV
    {
        public string Tags { get; set; }
        public string Name { get; set; }
        public string Length { get; set; }
        public string Value { get; set; }

    }

    public class TagsDictionary : TNLV
    {
        public string Template { get; set; }
    }

    public class ApplicationFileLocator
    {
        public string ShortFileIdentifier { get; set; }
        public string StartRecord { get; set; }
        public string EndRecord { get; set; }
        public string NumberOfRecords { get; set; }
    }

    public class TagsSelector
    {
        private IEnumerable<TNLV> tnlv;
        public TagsSelector(IEnumerable<TNLV> _tnlv)
        {
            if (_tnlv == null)
                throw new ArgumentNullException("Invalid TNLV");

            this.tnlv = _tnlv;
        }

        public string Value(string tags)
        {
            var result = tnlv.SingleOrDefault(w => w.Tags == tags);
            return result != null ? result.Value : null;
        }

        public TNLV AllData(string tags)
        {
            var result = tnlv.SingleOrDefault(w => w.Tags == tags);
            return result;
        }
    }


    namespace DataParser
    {

        public class TLV
        {
            private IEnumerable<TagsDictionary> tagsDictionary = new EMVTagsDictionary().List();
            private List<string> rawDataList = new List<string>();
            private List<TNLV> tnlvList = new List<TNLV>();
            private string rawData = "";

            public TLV(string _data)
            {
                if (_data.Length == 0)
                    throw new ArgumentException("Invalid data"); 

                this.rawData = _data.Replace(" ", ""); 
            }

            public TLV(List<string> _data)
            {
                if (_data.Count == 0)
                    throw new ArgumentException("Invalid data");

                this.rawDataList = _data; 
            }

            public IEnumerable<TNLV> Parse()
            { 
                bool procedure = (rawData.Length == 0) ? true : false;

                if (procedure)
                {
                    foreach (var rawDataInList in rawDataList)
                    {
                        Execute(rawDataInList);
                    }
                }
                else
                    ExecuteUpdate(rawData);

                return tnlvList;
            }

            void Execute(string _rawData)
            {
                var rawList = new List<TNLV>();
                var data = _rawData;
                var index = 0;
                var len = 0;
                var startIndexToRead = 0;
                var val = "";
                //foreach (var templateTags in tagsDictionary.GroupBy(g => g.Template).Select(s => s.First()).OrderBy(o => o.Template))
                foreach (var templateTags in tagsDictionary.Where(w => w.Tags == data.Substring(0, 2)))
                {
                    len = Convertion.HexToDecimal(data.Substring(2, 2)) * 2;
                    Console.WriteLine(templateTags.Tags + " " + len + " " + templateTags.Name);

                    //Remove response template data & length
                    data = data.Remove(0, 4);

                    //Check Parent Tags
                    foreach (var parentTags in tagsDictionary.Where(w => w.Template == templateTags.Tags))
                    {
                        if (data.Contains(parentTags.Tags + parentTags.Length))
                        {
                            index = data.IndexOf(parentTags.Tags + parentTags.Length);
                            len = Convertion.HexToDecimal(parentTags.Length == null ? data.Substring(index + parentTags.Tags.Length, 2) : parentTags.Length) * 2;
                            //Index + Tags Length + 2 (the length of the tags)
                            startIndexToRead = (index + parentTags.Tags.Length) + 2;
                            switch (parentTags.Tags)
                            {
                                //Checking tags that will convert to ASCII
                                case "5F20":
                                case "50":
                                case "5F2D":
                                case "9F1F":
                                    val = Convertion.HexToAscii(data.Substring(startIndexToRead, len));
                                    break;
                                default:
                                    val = data.Substring(startIndexToRead, len);
                                    break;
                            }
                            data = data.Remove(index, len + parentTags.Tags.Length + 2);

                            //Check Child Tags
                            var checkChild = tagsDictionary.Where(w => w.Template == parentTags.Tags);
                            if (checkChild.Count() == 0)
                            {
                                rawList.Add(new TNLV
                                {
                                    Length = len.ToString(),
                                    Name = parentTags.Name,
                                    Tags = parentTags.Tags,
                                    Value = val
                                });
                            }
                            else
                            {
                                rawList.Add(new TNLV
                                {
                                    Length = len.ToString(),
                                    Name = parentTags.Name,
                                    Tags = parentTags.Tags,
                                    Value = ""
                                });
                                var dataForChildTag = val;
                                foreach (var childTags in checkChild)
                                {
                                    if (dataForChildTag.Contains(childTags.Tags + childTags.Length))
                                    {
                                        index = dataForChildTag.IndexOf(childTags.Tags + childTags.Length);
                                        len = Convertion.HexToDecimal(childTags.Length == null ? dataForChildTag.Substring(index + childTags.Tags.Length, 2) : childTags.Length) * 2;
                                        startIndexToRead = (index + childTags.Tags.Length) + 2;
                                        switch (childTags.Tags)
                                        {
                                            case "5F20":
                                            case "50":
                                            case "5F2D":
                                            case "9F1F":
                                                val = Convertion.HexToAscii(dataForChildTag.Substring(startIndexToRead, len));
                                                break;
                                            default:
                                                val = dataForChildTag.Substring(startIndexToRead, len);
                                                break;
                                        }
                                        rawList.Add(new TNLV
                                        {
                                            Length = len.ToString(),
                                            Name = childTags.Name,
                                            Tags = childTags.Tags,
                                            Value = val
                                        });
                                        dataForChildTag = dataForChildTag.Remove(index, len + childTags.Tags.Length + 2);
                                    }
                                }
                            }
                        }
                    }

                    if (rawList.Count == 0)
                        Console.WriteLine("^^^^^^^^^" + data.Substring(0, data.Length - 1));
                    else
                    {
                        foreach (var _tnlv in rawList)
                        {
                            if (_tnlv.Value.Length > 0)
                            {
                                Console.WriteLine("------" + _tnlv.Tags + " " + _tnlv.Name);
                                Console.WriteLine("^^^^^^^^^" + _tnlv.Value);
                            }
                            else
                                Console.WriteLine("---" + _tnlv.Tags + " " + _tnlv.Name);
                        }
                    }
                    Console.WriteLine();
                }

                tnlvList.AddRange(rawList);
            } 

            void ExecuteUpdate(string _rawData)
            {
                try
                {
                    var rawList = new List<TNLV>();

                    rawList.AddRange(EMVParent(_rawData, ""));

                    //var data = _rawData;
                    //var index = 0;
                    //var len = 0;
                    //var lenLength = "";
                    //var startIndexToRead = 0;
                    //var val = "";
                    //TNLV _tnlv; 

                    //for (int i = 0; i < _rawData.Length; i++)
                    //{
                    //    //Check the 1st 2 Chars
                    //    for (int ii = 1; ii <= 4; ii++)
                    //    {
                    //        var toCheckData = data.Substring(startIndexToRead, ii);
                    //        _tnlv = tagsDictionary.FirstOrDefault(w => w.Tags == toCheckData);
                    //        if (_tnlv != null)
                    //        {
                    //            lenLength = _tnlv.Length == null ? data.Substring(i + ii, 2) : _tnlv.Length;
                    //            len = Convertion.HexToDecimal(lenLength) * 2;
                    //            val = TagsConvertedValue(_tnlv.Tags, data.Substring(i + ii + lenLength.Length, len));
                    //            startIndexToRead = i + ii + lenLength.Length + len;
                    //            i = startIndexToRead - 1;
                    //            rawList.Add(new TNLV
                    //            {
                    //                Length = len.ToString(),
                    //                Name = _tnlv.Name,
                    //                Tags = _tnlv.Tags,
                    //                Value = val
                    //            });

                    //            //Check if the Tags is also a Template
                    //            var checkIfTagIsTemplate = tagsDictionary.FirstOrDefault(w => w.Template == _tnlv.Tags);

                    //            if (checkIfTagIsTemplate != null)
                    //                rawList.AddRange(EMVParent(val, _tnlv.Tags));

                    //            break;
                    //        }

                    //        if(ii == 4)
                    //        {
                    //            //Move to next Tags. Maybe encouter some "9000" value that is not included in the Tags Dictionary
                    //            startIndexToRead += 4;
                    //            //Always -1 because the 1st For Loop will automatically add +1
                    //            i += 3;
                    //        }
                    //    }
                    //}

                    foreach (var tnlv in rawList)
                    {
                        if (tnlv.Value.Length > 0)
                        {
                            Console.WriteLine("------" + tnlv.Tags + " " + tnlv.Name);
                            Console.WriteLine("^^^^^^^^^" + tnlv.Value);
                        }
                        else
                            Console.WriteLine("---" + tnlv.Tags + " " + tnlv.Name);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("EMV Parser Error:" + ex.ToString());
                }
            }


            IEnumerable<TNLV> EMVParent(string _rawData, string template)
            {
                var rawList = new List<TNLV>();
                var data = _rawData;
                var index = 0;
                var len = 0;
                var lenLength = "";
                var startIndexToRead = 0;
                var val = "";
                TNLV _tnlv;

                try
                {
                    for (int i = 0; i < _rawData.Length; i++)
                    {
                        //Check the 1st 2 Chars
                        for (int ii = 1; ii <= 4; ii++)
                        {
                            var toCheckData = data.Substring(startIndexToRead, ii);
                            _tnlv = tagsDictionary.FirstOrDefault(w => w.Tags == toCheckData && w.Template == template);
                            if (_tnlv != null)
                            {
                                lenLength = _tnlv.Length == null ? data.Substring(i + ii, 2) : _tnlv.Length;
                                len = Convertion.HexToDecimal(lenLength) * 2;
                                val = TagsConvertedValue(_tnlv.Tags, data.Substring(i + ii + lenLength.Length, len));
                                startIndexToRead = i + ii + lenLength.Length + len;
                                i = startIndexToRead - 1;
                                rawList.Add(new TNLV
                                {
                                    Length = len.ToString(),
                                    Name = _tnlv.Name,
                                    Tags = _tnlv.Tags,
                                    Value = val
                                }); 

                                //Check if the Tags is also a Template
                                var checkIfTagIsTemplate = tagsDictionary.FirstOrDefault(w => w.Template == _tnlv.Tags);

                                if (checkIfTagIsTemplate != null)
                                    rawList.AddRange(EMVParent(val, _tnlv.Tags));

                                break; 
                            }

                            if (ii == 4)
                            {
                                ////Move to next Tags. Maybe encouter some "9000" value that is not included in the Tags Dictionary
                                //startIndexToRead += 4;
                                ////Always -1 because the 1st For Loop will automatically add +1
                                //i += 3;

                                throw new ArgumentException("Invalid TLV Data");
                            }
                        }
                    }
                }
                catch(Exception ex) 
                {
                    throw ex;
                }

                return rawList;
            }

            string TagsConvertedValue(string tag, string value)
            {
                var val = value;

                try
                {
                    switch (tag)
                    {
                        case "5F20":
                        case "50":
                        case "5F2D":
                        case "9F1F":
                            val = Convertion.HexToAscii(value);
                            break;
                    }
                }
                catch{}

                return val;
            }


        }



        public class GetProcessingOption
        {
            public int ResponseMessageTemplateFormat { get; set; }
            public string SW1 { get; set; }
            public string SW2 { get; set; }
            public string ApplicationInterchangeProfile { get; set; }
            public List<ApplicationFileLocator> ApplicationFileLocatorList { get; set; }
            private string data = "";
            public GetProcessingOption(string data)
            { 
                if(data.Length > 0)
                {
                    this.data = data;
                    this.SW1 = data.Substring(data.Length - 4, 2);
                    this.SW2 = data.Substring(data.Length - 2, 2);
                    if ((SW1 == "90") && (SW2 == "00"))
                    {
                        ResponseMessageTemplateFormat = (data.Substring(0, 2) == Tags.ResponseMessageTemplateFormat1) ? 1 : 2;
                        this.data = data.Substring(4, data.Length - 8); //REMOVE RMTF, Length, SW1, SW2
                        ApplicationInterchangeProfile = ParseAIP();
                        ApplicationFileLocatorList = ParseAFL();
                    }
                }
            }

            List<ApplicationFileLocator> ParseAFL()
            {
                string parseData = "";
                List<ApplicationFileLocator> response = new List<ApplicationFileLocator>();
                ApplicationFileLocator afl;
                switch(ResponseMessageTemplateFormat)
                {
                    case 1:
                        parseData = data.Substring(4, data.Length - 4);
                        break;
                    case 2: 
                        int l = Convertion.HexToDecimal(data.Substring(data.IndexOf(Tags.ApplicationFileLocator) + 2, 2)) * 2;
                        parseData = data.Substring(data.IndexOf(Tags.ApplicationFileLocator) + 4, l);
                        break;
                }
                for (int i = 0; i <= parseData.Length - 1; i += 8)
                {
                    afl = new ApplicationFileLocator();
                    afl.ShortFileIdentifier = parseData.Substring(i, 2);
                    afl.StartRecord = parseData.Substring(i + 2, 2);
                    afl.EndRecord = parseData.Substring(i + 4, 2);
                    afl.NumberOfRecords = parseData.Substring(i + 6, 2);
                    response.Add(afl);
                }
                return response;
            }

            string ParseAIP()
            {
                string response = ""; 
                switch (ResponseMessageTemplateFormat)
                {
                    case 1:
                        response = data.Substring(0, 4);
                        break;
                    case 2:
                        response = data.Substring(4, Convertion.HexToDecimal(data.Substring(2, 2)) * 2);
                        break;
                }
                return response;
            }
        }
    }
}
