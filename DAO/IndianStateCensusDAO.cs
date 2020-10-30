// --------------------------------------------------------------------------------------------------------------------
// <copyright file="fileName.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Your name"/>
// --------------------------------------------------------------------------------------------------------------------
namespace CensusDemo.DAO
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using CensusDemo.DTO;
    class IndianStateCensusDAO : CensusDTO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndianStateCensusDAO"/> class.
        /// </summary>
        public IndianStateCensusDAO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndianStateCensusDAO"/> class.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <param name="population">The population.</param>
        /// <param name="area">The area.</param>
        /// <param name="density">The density.</param>
        public IndianStateCensusDAO(string state, string population, string area, string density)
        {
            this.state = state;
            this.population = Convert.ToUInt32(population);
            this.area = Convert.ToUInt32(area);
            this.density = Convert.ToUInt32(density);
        }

        /// <summary>
        /// Loads the CSV.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        /// <exception cref="CensusAnalyserException">File Containers Wrong Delimiter</exception>
        public override Dictionary<string, CensusDTO> LoadCsv(string path)
        {
            // Read the file and add each instance to dictionary
            foreach(string line in File.ReadLines(path).Skip(1))
            {
                if (!line.Contains(","))
                {
                    throw new CensusAnalyserException("File Containers Wrong Delimiter", CensusAnalyserException.ExceptionType.INCOREECT_DELIMITER);
                }
                string[] column = line.Split(",");
                census = new IndianStateCensusDAO(column[0], column[1], column[2], column[3]);
                dataMap.Add(column[0], census);
            }
            return dataMap;
        }
    }
}
