﻿using System;
using System.Runtime.Serialization;

namespace CensusDemo
{
    [Serializable]
    public class CensusAnalyserException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,
            EXTENSION_NOT_FOUND,
            HEADERS_MISMATCH,
            INCOREECT_DELIMITER
        }

        public ExceptionType type;
        public CensusAnalyserException()
        {
        }

        public CensusAnalyserException(string message, ExceptionType type) : base(message)
        {
            this.type = type;
        }

        public CensusAnalyserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CensusAnalyserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}