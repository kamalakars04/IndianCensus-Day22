// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------
namespace CensusDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CensusDemo.DTO;

    /// <summary>
    /// Different types of files
    /// </summary>
    public enum FileType
    {
        INDIAN_STATE_CENSUS, INDIAN_STATE_CODE
    }

    public class CensusAnalyser 
    {
        /// <summary>
        /// Load file through factory and adapter
        /// </summary>
        /// <param name="type"></param>
        /// <param name="filePath"></param>
        /// <param name="dataheaders"></param>
        /// <returns></returns>
        public Dictionary<string, CensusDTO> LoadCsvFile(FileType type, string filePath, string dataheaders)
        {
           return new CSVCensusAdaptor().LoadCsv(type, filePath, dataheaders);
        }
    }
}
