﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserCustomException : ApplicationException
    {
        public enum TypeOfException
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }
        public TypeOfException type;
        public MoodAnalyserCustomException(TypeOfException type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
