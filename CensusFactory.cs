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
            if (fileInstanceMap.ContainsKey(type))
                return fileInstanceMap[type];
            if (type == FileType.INDIAN_STATE_CENSUS)
                return new IndianStateCensusDAO();
            return null;
        }
    }
}
