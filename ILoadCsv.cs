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
    /// Interface to be implemented by DAO of all file classes
    /// </summary>
    internal interface ILoadCsv
    {
        Dictionary<string,CensusDTO> LoadCsv(string filePath);
    }
}
