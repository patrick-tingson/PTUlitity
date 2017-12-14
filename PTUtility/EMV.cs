using PTUtility.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace PTUtility.EMV
{
    public class DE55Tags
    {
        public string _5F2A { get; set; }
        public string _5F34 { get; set; }
        public string _82 { get; set; }
        public string _84 { get; set; }
        public string _95 { get; set; }
        public string _9A { get; set; }
        public string _9C { get; set; }
        public string _9F02 { get; set; }
        public string _9F03 { get; set; }
        public string _9F09 { get; set; }
        public string _9F10 { get; set; }
        public string _9F1A { get; set; }
        public string _9F1E { get; set; }
        public string _9F26 { get; set; }
        public string _9F27 { get; set; }
        public string _9F33 { get; set; }
        public string _9F34 { get; set; }
        public string _9F35 { get; set; }
        public string _9F36 { get; set; }
        public string _9F37 { get; set; }
        public string _9F41 { get; set; }

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

    public class DE55
    {
        IEnumerable<TagsDictionary> tagsDictionary = new EMVTagsDictionary().List();
        DE55Tags de55tags;
        List<TNLV> tnlvListForDE55 = new List<TNLV>();

        public DE55(DE55Tags _de55tags)
        {
            //Check if Null
            if (_de55tags == null)
                throw new ArgumentException("Invalid DE55 Tags");

            this.de55tags = _de55tags;

            //Validate tags value
            if (de55tags._5F2A == null)
                throw new ArgumentException("Invalid DE55 Tags 5F2A");
            if (de55tags._5F34 == null)
                throw new ArgumentException("Invalid DE55 Tags 5F34");
            if (de55tags._82 == null)
                throw new ArgumentException("Invalid DE55 Tags 82");
            if (de55tags._84 == null)
                throw new ArgumentException("Invalid DE55 Tags 84");
            if (de55tags._95 == null)
                throw new ArgumentException("Invalid DE55 Tags 95");
            if (de55tags._9A == null)
                throw new ArgumentException("Invalid DE55 Tags 9A");
            if (de55tags._9C == null)
                throw new ArgumentException("Invalid DE55 Tags 9C");
            if (de55tags._9F02 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F02");
            if (de55tags._9F03 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F03");
            if (de55tags._9F09 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F09");
            if (de55tags._9F10 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F10");
            if (de55tags._9F1A == null)
                throw new ArgumentException("Invalid DE55 Tags 9F1A");
            //if (de55tags._9F1E == null)
            //    throw new ArgumentException("Invalid DE55 Tags 9F1E");
            if (de55tags._9F26 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F26");
            if (de55tags._9F27 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F27");
            if (de55tags._9F33 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F33");
            if (de55tags._9F34 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F34");
            if (de55tags._9F35 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F35");
            if (de55tags._9F36 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F36");
            if (de55tags._9F37 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F37");
            if (de55tags._9F41 == null)
                throw new ArgumentException("Invalid DE55 Tags 9F41");
        }

        public IEnumerable<TNLV> Create(ref string messageFormat)
        {
            AddTNLV(Tags.TransactionCurrencyCode, de55tags._5F2A);
            AddTNLV(Tags.ApplicationInterchangeProfile, de55tags._82);
            AddTNLV(Tags.DedicatedFileName, de55tags._84);
            AddTNLV(Tags.TerminalVerificationResults, de55tags._95);
            AddTNLV(Tags.TransactionDate, de55tags._9A);
            AddTNLV(Tags.TransactionType, de55tags._9C);
            AddTNLV(Tags.AmountAuthorised, de55tags._9F02);
            AddTNLV(Tags.ApplicationVersionNumber2, de55tags._9F09);
            AddTNLV(Tags.IssuerApplicationData, de55tags._9F10);
            AddTNLV(Tags.TerminalCountryCode, de55tags._9F1A);
            //AddTNLV(Tags.IFDSerialNumber, de55tags._9F1E);
            AddTNLV(Tags.ApplicationCryptogram, de55tags._9F26);
            AddTNLV(Tags.CryptogramInformationData, de55tags._9F27);
            AddTNLV(Tags.TerminalCapabilities, de55tags._9F33);
            AddTNLV(Tags.CardholderVerificationMethodResults, de55tags._9F34);
            AddTNLV(Tags.TerminalType, de55tags._9F35);
            AddTNLV(Tags.ApplicationTransactionCounter, de55tags._9F36);
            AddTNLV(Tags.UnpredictableNumber, de55tags._9F37);
            AddTNLV(Tags.TransactionSequenceCounter, de55tags._9F41);
            AddTNLV(Tags.PrimaryAccountSequenceNumber, de55tags._5F34);
            AddTNLV(Tags.AmountOther, de55tags._9F03);

            foreach(var tnlv in tnlvListForDE55)
            {
                messageFormat = string.Format("{0}{1}{2}{3}",
                    messageFormat,
                    tnlv.Tags,
                    tnlv.Length,
                    tnlv.Value
                    );
            }

            return tnlvListForDE55;
        } 

        void AddTNLV(string tags, string value)
        { 
            try
            {
                var _tnlv = tagsDictionary.FirstOrDefault(w => w.Tags == tags);
                tnlvListForDE55.Add(new TNLV
                {
                    Length = Convertion.DecimalToHex(value.Length / 2),
                    Name = _tnlv.Name,
                    Tags = _tnlv.Tags,
                    Value = value
                });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }

    public class CDOL1
    {
        IEnumerable<TagsDictionary> tagsDictionary = new EMVTagsDictionary().List();
        IEnumerable<TNLV> DE55_TNLV = new List<TNLV>();
        List<TNLV> cdolTagList = new List<TNLV>();
        string TAG_8C = "";


        public CDOL1(string _TAG_8C)
        {
            if (_TAG_8C.Length == 0)
                throw new ArgumentException("Invalid TAG_8C");

            this.TAG_8C = _TAG_8C;
        }

        public CDOL1(IEnumerable<TNLV> _DE55_TNLV, string _TAG_8C)
        {
            if (_DE55_TNLV == null)
                throw new ArgumentException("Invalid DE55_TNLV");

            if (_TAG_8C.Length == 0)
                throw new ArgumentException("Invalid TAG_8C");

            this.TAG_8C = _TAG_8C;
            this.DE55_TNLV = _DE55_TNLV;
        }

        public string Create()
        {
            if (DE55_TNLV == null)
                throw new ArgumentException("Invalid DE55_TNLV");

            var result = "";
            try
            { 
                var tagSelector = new TagsSelector(DE55_TNLV);

                foreach (var cdol1 in Parse())
                {
                    result = string.Format("{0}{1}",
                        result,
                        tagSelector.Value(cdol1.Tags));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            
            return result;
        }

        public IEnumerable<TNLV> Parse()
        { 
            var data = TAG_8C;
            var index = 0;
            var len = 0;
            var lenLength = "";
            var startIndexToRead = 0;
            var val = "";
            TNLV _tnlv;

            try
            {
                for (int i = 0; i < TAG_8C.Length; i++)
                {
                    //Check the 1st 2 Chars
                    for (int ii = 1; ii <= 4; ii++)
                    {
                        var toCheckData = data.Substring(startIndexToRead, ii);

                        _tnlv = tagsDictionary.FirstOrDefault(w => w.Tags == toCheckData); 

                        if (_tnlv != null)
                        {
                            lenLength = _tnlv.Length == null ? data.Substring(i + ii, 2) : _tnlv.Length;
                            //len = Convertion.HexToDecimal(lenLength) * 2; 
                            startIndexToRead = i + ii + lenLength.Length;
                            i = startIndexToRead - 1;
                            cdolTagList.Add(new TNLV
                            {
                                Length = lenLength,
                                Name = _tnlv.Name,
                                Tags = _tnlv.Tags, 
                            }); 

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
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (var tnlv in cdolTagList)
            {
                Console.WriteLine(tnlv.Tags + " " + tnlv.Length + " " + tnlv.Name);
            }

            return cdolTagList;
        }
    }

    namespace DataParser
    {

        public class TLV
        {
            IEnumerable<TagsDictionary> tagsDictionary = new EMVTagsDictionary().List();
            List<string> rawDataList = new List<string>();
            List<TNLV> tnlvList = new List<TNLV>();
            string rawData = "";

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
                        ExecuteUpdate(rawDataInList);
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

                    tnlvList.AddRange(rawList);

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

                            if(template.Length == 0)
                                _tnlv = tagsDictionary.FirstOrDefault(w => w.Tags == toCheckData);
                            else
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
                                return rawList;
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

            string data = "";

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
