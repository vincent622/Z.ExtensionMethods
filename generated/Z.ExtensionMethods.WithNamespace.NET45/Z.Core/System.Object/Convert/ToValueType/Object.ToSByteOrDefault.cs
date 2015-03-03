using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.CoreExtensions
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     An object extension method that converts this object to the s byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a sbyte.</returns>
        public static sbyte ToSByteOrDefault(this object @this)
        {
            try
            {
                return Convert.ToSByte(@this);
            }
            catch (Exception)
            {
                return default(sbyte);
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to the s byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>The given data converted to a sbyte.</returns>
        public static sbyte ToSByteOrDefault(this object @this, sbyte defaultValue)
        {
            try
            {
                return Convert.ToSByte(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     An object extension method that converts this object to the s byte or default.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValueFactory">The default value factory.</param>
        /// <returns>The given data converted to a sbyte.</returns>
        public static sbyte ToSByteOrDefault(this object @this, Func<sbyte> defaultValueFactory)
        {
            try
            {
                return Convert.ToSByte(@this);
            }
            catch (Exception)
            {
                return defaultValueFactory();
            }
        }
    }


}