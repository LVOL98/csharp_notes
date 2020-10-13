using System;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        // It's not allowed to do an extension method like this
        // public static void AddPercent(this string text)
        // {
        //     text + "%";
        // }

        public static string AddPercent(this string text)
        {
            return text + "%";
        }        
    }
}