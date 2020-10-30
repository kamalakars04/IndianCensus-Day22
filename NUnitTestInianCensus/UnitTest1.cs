using System.Collections.Generic;
using CensusDemo;
using CensusDemo.DTO;
using NUnit.Framework;

namespace NUnitTestInianCensus
{
    public class Tests
    {
        // Static variables
        public static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        public static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        public static string indianStateCensusFilePath = @"C:\Users\kamalakar\Desktop\bridge labs\IndianCensus\CSVFiles\IndiaStateCensusData.csv";
        public static string indianStateCodeFilePath = @"C:\Users\kamalakar\Desktop\bridge labs\IndianCensus\CSVFiles\IndiaStateCode.csv";
        public static string wrongHeaderIndianCensusFile = @"C:\Users\kamalakar\Desktop\bridge labs\IndianCensus\CSVFiles\WrongIndiaStateCensusData.csv";
        public static string wrongHeaderIndianStateCode = @"C:\Users\kamalakar\Desktop\bridge labs\IndianCensus\CSVFiles\WrongIndiaStateCode.csv";
        public static string wrongIndianStateCensusFilePath = @"C:\Users\HP\source\repos\IndiaCensusDataDemo\CSVFiles1\WrongIndiaStateCensusData.csv";
        public static string wrongIndianStateCensusFileType = @"C:\Users\kamalakar\Desktop\bridge labs\IndianCensus\IndianStateCensus.txt";
        public static string wrongIndianStateCodeFilePath = @"C:\Users\HP\source\repos\IndiaCensusDataDemo\CSVFiles1\WrongIndiaStateCode.csv";
        public static string wrongIndianStateCodeFiletype = @"C:\Users\kamalakar\Desktop\bridge labs\IndianCensus\CSVFiles\IndiaStateCode.txt";
        public static string delimeterIndianStateCodeFilePath = @"C:\Users\kamalakar\Desktop\bridge labs\IndianCensus\CSVFiles\DelimiterIndiaStateCode.csv";
        public static string delimeterIndianCensusCodeFilePath = @"C:\Users\kamalakar\Desktop\bridge labs\IndianCensus\CSVFiles\DelimiterIndiaStateCensusData.csv";

        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        /// <summary>
        /// Setups this instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        /// <summary>
        /// TC1.1 Given the States Census CSV file, Check to ensure the Number of Record matches
        /// </summary>
        [Test]
        public void GivenIndianCensusDataFile()
        {
            totalRecord = censusAnalyser.LoadCsvFile(CensusDemo.FileType.INDIAN_STATE_CENSUS , indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }

        /// <summary>
        /// TC 1.2 Given the State Census CSV File if incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void GivenWrongIndian()
        {
            var indianCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCsvFile(CensusDemo.FileType.INDIAN_STATE_CENSUS,wrongIndianStateCensusFilePath, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, indianCensusResult.type);
        }

        /// <summary>
        /// TC 1.3 Given the State Census CSV File when correct but type incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void GivenWrongIndianCensusDataFileType()
        {
            var indianCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCsvFile(CensusDemo.FileType.INDIAN_STATE_CENSUS,wrongIndianStateCensusFileType, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.EXTENSION_NOT_FOUND, indianCensusResult.type);
        }

        /// <summary>
        /// TC 1.4 Given the State Census CSV File when correct but delimiter incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void GivenWrongIndianCensusDataFileTypeDelimeter()
        {
            var indianCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCsvFile(CensusDemo.FileType.INDIAN_STATE_CENSUS, delimeterIndianCensusCodeFilePath,indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCOREECT_DELIMITER, indianCensusResult.type);
        }

        /// <summary>
        /// TC 1.5 Given the State Census CSV File when correct but csv header incorrect Returns a custom Exception
        /// </summary>
        [Test]
        public void GivenWrongIndianCensusDataHeadersCustomExcep()
        {
            var indianCensusResult = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCsvFile(CensusDemo.FileType.INDIAN_STATE_CENSUS, wrongHeaderIndianCensusFile, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.HEADERS_MISMATCH, indianCensusResult.type);
        }
    }
}