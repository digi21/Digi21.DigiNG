﻿using Digi21.DigiNG.Entities;
using System;

namespace Digi21.DigiNG.DigiTab
{
    public class DatabaseAttributeException : Exception
    {
        public DatabaseAttributeException(string message, Code code, string field) { throw null; }
        public DatabaseAttributeException(string message, Code code, string field, Exception innerException) { throw null; }
        public DatabaseAttributeException(string message, Code code, string field, Tuple<string, string>[] contextualMenuOptions) { throw null; }
        public DatabaseAttributeException(string message, Code code, string field, Exception innerException, Tuple<string, string>[] contextualMenuOptions) { throw null; }
        public Tuple<string, string>[] ContextualMenuOptions { get; set; }
        public string Field { get; set; }
        public Code Code { get; set; }
    }
}