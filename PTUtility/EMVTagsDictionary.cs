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

    public static class Tags
    {
        public const string TransactionSequenceCounter = "9F41";
        public const string UnpredictableNumber = "9F37";
        public const string TransactionDate = "9A";
        public const string TransactionType = "9C";
        public const string TransactionCurrencyCode = "5F2A";
        public const string AcquirerIdentifier = "9F01";
        public const string AdditionalTerminalCapabilities = "9F40";
        public const string AmountAuthorised = "9F02";
        public const string AmountOther = "9F03";
        public const string AmountReferenceCurrency = "9F3A";
        public const string ApplicationCryptogram = "9F26";
        public const string ApplicationCurrencyCode = "9F42";
        public const string ApplicationCurrencyExponent = "9F44";
        public const string ApplicationDiscretionaryData = "9F05";
        public const string ApplicationEffectiveDate = "5F25";
        public const string ApplicationExpirationDate = "5F24";
        public const string ApplicationFileLocator = "94";
        public const string ApplicationIdentifierCard = "4F";
        public const string ApplicationIdentifierTerminal = "9F06";
        public const string ApplicationInterchangeProfile = "82";
        public const string ApplicationLabel = "50";
        public const string ApplicationPreferredName = "9F12";
        public const string PrimaryAccountNumber = "5A";
        public const string PrimaryAccountSequenceNumber = "5F34";
        public const string ApplicationPriorityIndicator = "87";
        public const string ApplicationReferenceCurrency = "9F3B";
        public const string ApplicationReferenceCurrencyExponent = "9F43";
        public const string ApplicationTemplate = "61";
        public const string ApplicationTransactionCounter = "9F36";
        public const string ApplicationUsageControl = "9F07";
        public const string ApplicationVersionNumber1 = "9F08";
        public const string ApplicationVersionNumber2 = "9F09";
        public const string AuthorisationCode = "89";
        public const string AuthorisationResponseCode = "8A";
        public const string BankIdentifierCode = "5F54";
        public const string CardRiskManagementDataObjectList1 = "8C";
        public const string CardRiskManagementDataObjectList2 = "8D";
        public const string CardholderName = "5F20";
        public const string CardholderNameExtended = "9F0B";
        public const string CardholderVerificationMethodList = "8E";
        public const string CardholderVerificationMethodResults = "9F34";
        public const string CertificationAuthorityPublicKeyIndex1 = "8F";
        public const string CertificationAuthorityPublicKeyIndex2 = "9F22";
        public const string CommandTemplate = "83";
        public const string CryptogramInformationData = "9F27";
        public const string DataAuthenticationCode = "9F45";
        public const string DedicatedFileName = "84";
        public const string DirectoryDefinitionFileName = "9D";
        public const string DirectoryDiscretionaryTemplate = "73";
        public const string DynamicDataAuthenticationDataObjectList = "9F49";
        public const string EMVProprietaryTemplate = "70";
        public const string FCIIssuerDiscretionaryData = "BF0C";
        public const string FCIProprietaryTemplate = "A5";
        public const string FCITemplate = "6F";
        public const string ICCDynamicNumber = "9F4C";
        public const string ICCPINEnciphermentPublicKeyCertificate = "9F2D";
        public const string ICCPINEnciphermentPublicKeyExponent = "9F2E";
        public const string ICCPINEnciphermentPublicKeyRemainder = "9F2F";
        public const string ICCPublicKeyCertificate = "9F46";
        public const string ICCPublicKeyExponent = "9F47";
        public const string ICCPublicKeyRemainder = "9F48";
        public const string IFDSerialNumber = "9F1E";
        public const string InternationalBankAccountNumber = "5F53";
        public const string IssuerActionCodeDefault = "9F0D";
        public const string IssuerActionCodeDenial = "9F0E";
        public const string IssuerActionCodeOnline = "9F0F";
        public const string IssuerApplicationData = "9F10";
        public const string IssuerAuthenticationData = "91";
        public const string IssuerCodeTableIndex = "9F11";
        public const string IssuerCountryCode = "5F28";
        public const string IssuerCountryCode2 = "5F55";
        public const string IssuerCountryCode3 = "5F56";
        public const string IssuerIdentificationNumber = "42";
        public const string IssuerPublicKeyCertificate = "90";
        public const string IssuerPublicKeyExponent = "9F32";
        public const string IssuerPublicKeyRemainder = "92";
        public const string IssuerScriptCommand = "86";
        public const string IssuerScriptIdentifier = "9F18";
        public const string IssuerScriptTemplate1 = "71";
        public const string IssuerScriptTemplate2 = "72";
        public const string IssuerURL = "5F50";
        public const string LanguagePreference = "5F2D";
        public const string LastOnlineApplicationTransactionCounterRegister = "9F13";
        public const string LogEntry = "9F4D";
        public const string LogFormat = "9F4F";
        public const string LowerConsecutiveOfflineLimit = "9F14";
        public const string MerchantCategoryCode = "9F15";
        public const string MerchantIdentifier = "9F16";
        public const string MerchantNameLocation = "9F4E";
        public const string PINTryCounter = "9F17";
        public const string POSEntryMode = "9F39";
        public const string ProcessingOptionsDataObjectList = "9F38";
        public const string ResponseMessageTemplateFormat1 = "80";
        public const string ResponseMessageTemplateFormat2 = "77";
        public const string ServiceCode = "5F30";
        public const string ShortFileIdentifier = "88";
        public const string SignedDynamicApplicationData = "9F4B";
        public const string SignedStaticApplicationData = "93";
        public const string StaticDataAuthenticationTagList = "9F4A";
        public const string Track2Data = "57";
        public const string Track1Data = "9F1F";
        public const string TerminalCapabilities = "9F33";
        public const string TerminalCountryCode = "9F1A";
        public const string TerminalFloorLimit = "9F1B";
        public const string TerminalIdentification = "9F1C";
        public const string TerminalRiskManagementData = "9F1D";
        public const string TerminalType = "9F35";
        public const string TerminalVerificationResults = "95";
    }

}
