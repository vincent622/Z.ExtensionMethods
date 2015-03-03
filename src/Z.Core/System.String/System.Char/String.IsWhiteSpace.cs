using System;

public static partial class Extensions
    {
        /// <summary>
        ///     Indicates whether the character at the specified position in a specified string is categorized as white space.
        /// </summary>
        /// <param name="s">A string.</param>
        /// <param name="index">The position of the character to evaluate in .</param>
        /// <returns>true if the character at position  in  is white space; otherwise, false.</returns>
        public static Boolean IsWhiteSpace(this String s, Int32 index)
        {
            return Char.IsWhiteSpace(s, index);
        }
    }
