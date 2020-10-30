// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------
namespace CensusDemo.DTO
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class CensusDTO : ILoadCsv
    {
        // All the variables related to all file types
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public double totalArea;
        public double waterArea;
        public double landArea;

        // Variable declarations
        internal CensusDTO census;
        public Dictionary<string, CensusDTO> dataMap = new Dictionary<string, CensusDTO>();

        /// <summary>
        /// Loads the CSV.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public abstract Dictionary<string, CensusDTO> LoadCsv(string filePath);
    }
}
