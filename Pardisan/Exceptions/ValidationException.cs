﻿using System;
using System.Collections.Generic;

namespace Pardisan.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidationException(List<string> errors)
        {
            Errors = errors;
        }
        public ValidationException(string error)
        {
            Errors.Add(error);
        }
    }
}
