using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value">The string to test.</param>
        /// <returns>true if the  parameter is null or , or if  consists exclusively of white-space characters.</returns>
        public static Boolean IsNullOrWhiteSpace(this String value)
        {
            return String.IsNullOrWhiteSpace(value);
        }
    }


}