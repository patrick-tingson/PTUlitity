using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTUtility.EMV
{
    public class EMVTagsDictionary : TNLV
    {
        public string Template { get; set; }

        public readonly List<TagsDictionary> tagsDictionary = new List<TagsDictionary>();

        public EMVTagsDictionary()
        {
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "90",
                Name = "Issuer Public Key Certificate"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "BF0C",
                Tags = "42",
                Name = "Issuer Identification Number (IIN)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "73",
                Tags = "42",
                Name = "Issuer Identification Number (IIN)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "61",
                Tags = "4F",
                Name = "Application Identifier (AID)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "61",
                Tags = "50",
                Name = "Application Label"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "A5",
                Tags = "50",
                Name = "Application Label"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "57",
                Name = "Track 2 Equivalent Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "57",
                Name = "Track 2 Equivalent Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "5A",
                Name = "Application Primary Account Number (PAN)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "5A",
                Name = "Application Primary Account Number (PAN)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "5F20",
                Name = "Cardholder Name"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "5F20",
                Name = "Cardholder Name"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "5F24",
                Name = "Application Expiration Date",
                Length = "03"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "5F24",
                Name = "Application Expiration Date",
                Length = "03"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "5F25",
                Name = "Application Effective Date",
                Length = "03"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "5F25",
                Name = "Application Effective Date",
                Length = "03"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "5F28",
                Name = "Issuer Country Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "5F28",
                Name = "Issuer Country Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "5F2A",
                Name = "Transaction Currency Code",
                Length = "02"
            }); 
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "A5",
                Tags = "5F2D",
                Name = "Language Preference"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "5F30",
                Name = "Service Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "5F30",
                Name = "Service Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "5F34",
                Name = "Application Primary Account Number (PAN)Sequence Number",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "5F34",
                Name = "Application Primary Account Number (PAN)Sequence Number",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "5F36",
                Name = "Transaction Currency Exponent",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "BF0C",
                Tags = "5F50",
                Name = "Issuer URL"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "73",
                Tags = "5F50",
                Name = "Issuer URL"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "BF0C",
                Tags = "5F53",
                Name = "International Bank Account Number (IBAN)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "73",
                Tags = "5F53",
                Name = "International Bank Account Number (IBAN)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "BF0C",
                Tags = "5F54",
                Name = "Bank Identifier Code (BIC)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "73",
                Tags = "5F54",
                Name = "Bank Identifier Code (BIC)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "BF0C",
                Tags = "5F55",
                Name = "Issuer Country Code (alpha2 format)",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "73",
                Tags = "5F55",
                Name = "Issuer Country Code (alpha2 format)",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "61",
                Name = "Application Template"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "61",
                Name = "Application Template"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "6F",
                Name = "File Control Information (FCI) Template"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "6F",
                Name = "File Control Information (FCI) Template"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "71",
                Name = "Issuer Script Template 1"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "72",
                Name = "Issuer Script Template 2"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "61",
                Tags = "73",
                Name = "Directory Discretionary Template"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "77",
                Name = "Response Message Template Format 2"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "80",
                Name = "Response Message Template Format 1"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "70",
                Name = "Read Record Response Message"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "81",
                Name = "Amount, Authorised (Binary)",
                Length = "04"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "82",
                Name = "Application Interchange Profile",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "80",
                Tags = "82",
                Name = "Application Interchange Profile",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "83",
                Name = "Command Template"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "6F",
                Tags = "84",
                Name = "Dedicated File (DF) Name"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "71",
                Tags = "86",
                Name = "Issuer Script Command"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "72",
                Tags = "86",
                Name = "Issuer Script Command"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "61",
                Tags = "87",
                Name = "Application Priority Indicator",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "A5",
                Tags = "87",
                Name = "Application Priority Indicator",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "A5",
                Tags = "88",
                Name = "Short File Identifier (SFI)",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "89",
                Name = "Authorisation Code",
                Length = "06"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "8A",
                Name = "Authorisation Response Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "8C",
                Name = "Card Risk Management Data Object List 1 (CDOL1)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "8C",
                Name = "Card Risk Management Data Object List 1 (CDOL1)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "8D",
                Name = "Card Risk Management Data Object List 2 (CDOL2)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "8D",
                Name = "Card Risk Management Data Object List 2 (CDOL2)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "8E",
                Name = "Cardholder Verification Method (CVM) List"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "8E",
                Name = "Cardholder Verification Method (CVM) List"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "8F",
                Name = "Certification Authority Public Key Index",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "8F",
                Name = "Certification Authority Public Key Index",
                Length = "01"
            });
            //tagsDictionary.Add(new TagsDictionary
            //{
            //    Template = "70",
            //    Tags = "90",
            //    Name = "Issuer Public Key Certificate"
            //});
            //tagsDictionary.Add(new TagsDictionary
            //{
            //    Template = "77",
            //    Tags = "90",
            //    Name = "Issuer Public Key Certificate"
            //});
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "91",
                Name = "Issuer Authentication Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "92",
                Name = "Issuer Public Key Remainder"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "92",
                Name = "Issuer Public Key Remainder"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "93",
                Name = "Signed Static Application Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "93",
                Name = "Signed Static Application Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "94",
                Name = "Application File Locator (AFL)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "80",
                Tags = "94",
                Name = "Application File Locator (AFL)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "95",
                Name = "Terminal Verification Results",
                Length = "05"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "97",
                Name = "Transaction Certificate Data Object List (TDOL)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "97",
                Name = "Transaction Certificate Data Object List (TDOL)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "98",
                Name = "Transaction Certificate (TC) Hash Value",
                Length = "14"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "99",
                Name = "Transaction Personal Identification Number (PIN)Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9A",
                Name = "Transaction Date",
                Length = "03"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9B",
                Name = "Transaction Status Information",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9C",
                Name = "Transaction Type",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "61",
                Tags = "9D",
                Name = "Directory Definition File (DDF) Name"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F01",
                Name = "Acquirer Identifier",
                Length = "06"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F02",
                Name = "Amount, Authorised (Numeric)",
                Length = "06"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F03",
                Name = "Amount, Other (Numeric)",
                Length = "06"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F04",
                Name = "Amount, Other (Binary)",
                Length = "04"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F05",
                Name = "Application Discretionary Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F05",
                Name = "Application Discretionary Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F06",
                Name = "Application Identifier (AID) - terminal"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F07",
                Name = "Application Usage Control",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F07",
                Name = "Application Usage Control",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F08",
                Name = "Application Version Number",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F08",
                Name = "Application Version Number",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F09",
                Name = "Application Version Number",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F0B",
                Name = "Cardholder Name Extended"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F0B",
                Name = "Cardholder Name Extended"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F0D",
                Name = "Issuer Action Code - Default",
                Length = "05"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F0D",
                Name = "Issuer Action Code - Default",
                Length = "05"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F0E",
                Name = "Issuer Action Code - Denial",
                Length = "05"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F0E",
                Name = "Issuer Action Code - Denial",
                Length = "05"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F0F",
                Name = "Issuer Action Code - Online",
                Length = "05"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F0F",
                Name = "Issuer Action Code - Online",
                Length = "05"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F10",
                Name = "Issuer Application Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "80",
                Tags = "9F10",
                Name = "Issuer Application Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "A5",
                Tags = "9F11",
                Name = "Issuer Code Table Index",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "61",
                Tags = "9F12",
                Name = "Application Preferred Name"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "A5",
                Tags = "9F12",
                Name = "Application Preferred Name"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F13",
                Name = "Last Online Application Transaction Counter (ATC) Register",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F14",
                Name = "Lower Consecutive Offline Limit",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F14",
                Name = "Lower Consecutive Offline Limit",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F15",
                Name = "Merchant Category Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F16",
                Name = "Merchant Identifier",
                Length = "15"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F17",
                Name = "Personal Identification Number (PIN) Try Counter",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "71",
                Tags = "9F18",
                Name = "Issuer Script Identifier",
                Length = "04"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "72",
                Tags = "9F18",
                Name = "Issuer Script Identifier",
                Length = "04"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F1A",
                Name = "Terminal Country Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F1B",
                Name = "Terminal Floor Limit",
                Length = "04"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F1C",
                Name = "Terminal Identification",
                Length = "08"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F1D",
                Name = "Terminal Risk Management Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F1E",
                Name = "Interface Device (IFD) Serial Number"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F1F",
                Name = "Track 1 Discretionary Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F1F",
                Name = "Track 1 Discretionary Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F20",
                Name = "Track 2 Discretionary Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F20",
                Name = "Track 2 Discretionary Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F21",
                Name = "Transaction Time",
                Length = "03"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F22",
                Name = "Certification Authority Public Key Index",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F23",
                Name = "Upper Consecutive Offline Limit",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F23",
                Name = "Upper Consecutive Offline Limit",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F26",
                Name = "Application Cryptogram",
                Length = "08"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "80",
                Tags = "9F26",
                Name = "Application Cryptogram",
                Length = "08"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F27",
                Name = "Cryptogram Information Data",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "80",
                Tags = "9F27",
                Name = "Cryptogram Information Data",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F2D",
                Name = "ICC PIN Encipherment Public Key Certificate"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F2D",
                Name = "ICC PIN Encipherment Public Key Certificate"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F2E",
                Name = "ICC PIN Encipherment Public Key Exponent"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F2E",
                Name = "ICC PIN Encipherment Public Key Exponent"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F2F",
                Name = "ICC PIN Encipherment Public Key Remainder"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F2F",
                Name = "ICC PIN Encipherment Public Key Remainder"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F32",
                Name = "Issuer Public Key Exponent"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F32",
                Name = "Issuer Public Key Exponent"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F33",
                Name = "Terminal Capabilities",
                Length = "03"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F34",
                Name = "Cardholder Verification Method (CVM) Results",
                Length = "03"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F35",
                Name = "Terminal Type",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F36",
                Name = "Application Transaction Counter (ATC)",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "80",
                Tags = "9F36",
                Name = "Application Transaction Counter (ATC)",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F37",
                Name = "Unpredictable Number",
                Length = "04"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "A5",
                Tags = "9F38",
                Name = "Processing Options Data Object List (PDOL)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F39",
                Name = "Point-of-Service (POS) Entry Mode",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F3A",
                Name = "Amount, Reference Currency",
                Length = "04"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F3B",
                Name = "Application Reference Currency"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F3B",
                Name = "Application Reference Currency"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F3C",
                Name = "Transaction Reference Currency Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F3D",
                Name = "Transaction Reference Currency Exponent",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F40",
                Name = "Additional Terminal Capabilities",
                Length = "40"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F41",
                Name = "Transaction Sequence Counter"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F42",
                Name = "Application Currency Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F42",
                Name = "Application Currency Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F43",
                Name = "Application Reference Currency Exponent"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F43",
                Name = "Application Reference Currency Exponent"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F44",
                Name = "Application Currency Exponent",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F44",
                Name = "Application Currency Exponent",
                Length = "01"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F45",
                Name = "Data Authentication Code",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F46",
                Name = "ICC Public Key Certificate"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F46",
                Name = "ICC Public Key Certificate"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F47",
                Name = "ICC Public Key Exponent"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F47",
                Name = "ICC Public Key Exponent"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F48",
                Name = "ICC Public Key Remainder"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F48",
                Name = "ICC Public Key Remainder"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F49",
                Name = "Dynamic Data Authentication Data Object List(DDOL)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F49",
                Name = "Dynamic Data Authentication Data Object List(DDOL)"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "70",
                Tags = "9F4A",
                Name = "Static Data Authentication Tag List"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "77",
                Tags = "9F4A",
                Name = "Static Data Authentication Tag List"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F4B",
                Name = "Signed Dynamic Application Data"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F4C",
                Name = "ICC Dynamic Number"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "BF0C",
                Tags = "9F4D",
                Name = "Log Entry",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "73",
                Tags = "9F4D",
                Name = "Log Entry",
                Length = "02"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F4E",
                Name = "Merchant Name and Location"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "",
                Tags = "9F4F",
                Name = "Log Format"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "6F",
                Tags = "A5",
                Name = "File Control Information (FCI) Proprietary Template"
            });
            tagsDictionary.Add(new TagsDictionary
            {
                Template = "A5",
                Tags = "BF0C",
                Name = "File Control Information (FCI) Issuer Discretionary Data"
            });
        }

        public IEnumerable<TagsDictionary> List()
        {
            return tagsDictionary;
        }
    }
}
