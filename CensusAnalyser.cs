﻿// --------------------------------------------------------------------------------------------------------------------
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
        INDIAN_STATE_CENSUS
    }

    public class CensusAnalyser 
    {
        public Dictionary<string, CensusDTO> LoadCsvFile(FileType type, string filePath, string dataheaders)
        {
           return new CSVCensusAdaptor().LoadCsv(type, filePath, dataheaders);
        }
    }
}
