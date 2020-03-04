using System;

namespace SmartsheetUtils
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    sealed class SmartsheetValue : Attribute
    {
        public SmartsheetValue(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
