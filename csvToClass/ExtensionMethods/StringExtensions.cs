using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace WespBasReportingDesktop.ExtensionMethods;

public static class StringExtensions
{
    public static string ToTitleCase(this string str)
    {
        System.Text.StringBuilder resultBuilder = new System.Text.StringBuilder();
        foreach (char c in str)
        {
            if (!Char.IsLetterOrDigit(c))
            {
                resultBuilder.Append(" ");
            }
            else
            {
                resultBuilder.Append(c);
            }
        }

        string result = resultBuilder.ToString();
        result = result.ToLower();
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
        return myTI.ToTitleCase(result).Replace(" ", String.Empty);
    }

    public static string ToCamelCase(this string str)
    {
        return str.ToTitleCase().LowercaseFirst();
    }
    
    private static string LowercaseFirst(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }
        char[] charList = str.ToCharArray();
        charList[0] = char.ToLower(charList[0]);
        return new string(charList);
    }
}