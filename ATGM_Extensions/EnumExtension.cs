using System;
using System.ComponentModel;
using System.Reflection;

namespace ATGM_Extensions
{
    /// <summary>
    /// Various generic functions to help work with enums.
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Generic function to get the description field of an enum
        /// </summary>
        /// <param name="value">Enum that has a description (will return null otherwise</param>
        /// <returns>Description of an Enum</returns>
        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null) return null;
            var attribute = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));

            return attribute.Description;
        }
    }
}
