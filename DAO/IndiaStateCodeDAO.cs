using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CensusDemo;
using CensusDemo.DTO;

namespace CensusDemo.DAO
{
    public class IndiaStateCodeDAO : CensusDTO
    {             
        public IndiaStateCodeDAO()
        {
        }
        
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="stateName"></param>
        /// <param name="tin"></param>
        /// <param name="stateCode"></param>
        public IndiaStateCodeDAO(string serialNumber, string stateName, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }

        /// <summary>
        /// LoadCsv method
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public override Dictionary<string, CensusDTO> LoadCsv(string path)
        {
            // Read the file and add each instance to dictionary
            foreach (string line in File.ReadLines(path).Skip(1))
            {
                if (!line.Contains(","))
                {
                    throw new CensusAnalyserException("File Containers Wrong Delimiter", CensusAnalyserException.ExceptionType.INCOREECT_DELIMITER);
                }
                string[] column = line.Split(",");
                census = new IndiaStateCodeDAO(column[0], column[1], column[2], column[3]);
                dataMap.Add(column[0], census);
            }
            return dataMap;
        }
    }
}
