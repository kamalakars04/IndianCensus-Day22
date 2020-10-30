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
    using CensusDemo.DAO;
    using CensusDemo.DTO;

    class CensusFactory
    {
        // Declarations
        public Dictionary<FileType, CensusDTO> fileInstanceMap = new Dictionary<FileType, CensusDTO>();

        /// <summary>
        /// Gets the object.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        internal CensusDTO GetObject(FileType type)
        {
            // If the instance already exists then return the same
            if (fileInstanceMap.ContainsKey(type))
                return fileInstanceMap[type];

            // If the instance doesnt exist then create a new one according to file type
            if (type == FileType.INDIAN_STATE_CENSUS)
            {
                fileInstanceMap.Add(type, new IndianStateCensusDAO());
                return fileInstanceMap[type];
            }
                 
            if (type == FileType.INDIAN_STATE_CODE)
            {
                fileInstanceMap.Add(type, new IndiaStateCodeDAO());
                return fileInstanceMap[type];
            }
            return null;
        }
    }
}
