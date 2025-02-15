using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace CodeBehind
{
    public static class ExtensionMethodsClass
    {
        public static string GetTextAfterValue(this string Text, string Value)
        {
            if (Text.Length < Value.Length)
                return Text;

            if (!Text.Contains(Value))
                return Text;

            return Text.Substring(Text.IndexOf(Value) + Value.Length);
        }

        // Overload
        public static string GetTextAfterValue(this string Text, char Value)
        {
            return Text.GetTextAfterValue(Value);
        }

        public static string GetTextAfterLastValue(this string Text, string Value)
        {
            if (Text.Length < Value.Length)
                return Text;

            if (!Text.Contains(Value))
                return Text;

            return Text.Substring(Text.LastIndexOf(Value) + Value.Length);
        }

        // Overload
        public static string GetTextAfterLastValue(this string Text, char Value)
        {
            return Text.GetTextAfterLastValue(Value);
        }

        public static string GetTextBeforeValue(this string Text, string Value)
        {
            if (Text.Length < Value.Length)
                return Text;

            if (!Text.Contains(Value))
                return Text;

            return Text.Substring(0, Text.IndexOf(Value));
        }

        // Overload
        public static string GetTextBeforeValue(this string Text, char Value)
        {
            return Text.GetTextBeforeValue(Value);
        }

        public static string GetTextBeforeLastValue(this string Text, string Value)
        {
            if (Text.Length < Value.Length)
                return Text;

            if (!Text.Contains(Value))
                return Text;

            return Text.Substring(0, Text.LastIndexOf(Value));
        }

        // Overload
        public static string GetTextBeforeLastValue(this string Text, char Value)
        {
            return Text.GetTextBeforeLastValue(Value);
        }

        public static int ToNumber(this string Text)
        {
            if (string.IsNullOrEmpty(Text))
                return 0;

            int i;

            int.TryParse(Text, out i);

            return i;
        }

        public static int ToNumber(this object Text)
        {
            return ToNumber(Text.ToString());
        }

        public static bool Has(this string Text)
        {
            if (!string.IsNullOrEmpty(Text))
                return true;

            return false;
        }

        public static bool Has(this object Text)
        {
            return Has(Text.ToString());
        }

        public static bool HasEmbedded(this IFormCollection Form, string Key)
        {
            foreach (string name in Form.Keys)
                if (name.StartsWith(Key))
                    return true;

            return false;
        }

        // Overload
        public static bool HasEmbedded(this IFormCollection Form, string Key, out string Value)
        {
            foreach (string name in Form.Keys)
                if (name.StartsWith(Key))
                {
                    Value = name.GetTextAfterValue(Key);
                    return true;
                }

            Value = "";
            return false;
        }

        // Overload
        public static bool HasEmbedded(this IQueryCollection Query, string Key)
        {
            foreach (string name in Query.Keys)
                if (name.StartsWith(Key))
                    return true;

            return false;
        }

        // Overload
        public static bool HasEmbedded(this IQueryCollection Query, string Key, out string Value)
        {
            foreach (string name in Query.Keys)
                if (name.StartsWith(Key))
                {
                    Value = name.GetTextAfterValue(Key);
                    return true;
                }

            Value = "";
            return false;
        }

        public static string GetEmbedded(this IFormCollection Form, string Key)
        {
            foreach (string name in Form.Keys)
                if (name.StartsWith(Key))
                    return name.GetTextAfterValue(Key);

            return "";
        }

        // Overload
        public static string GetEmbedded(this IQueryCollection Query, string Key)
        {
            foreach (string name in Query.Keys)
                if (name.StartsWith(Key))
                    return name.GetTextAfterValue(Key);

            return "";
        }

        public static bool IsNumber(this string Text)
        {
            for (int i = 0; i < Text.Length; i++)
                if (!char.IsNumber(Text[i]))
                    return false;

            return true;
        }

        public static bool IsNumber(this object Text)
        {
            return IsNumber(Text.ToString());
        }

        public static string ToMethodNameClean(this string Text)
        {
            Regex regex = new Regex("[^a-zA-Z0-9_]");
            return regex.Replace(Text, "_");
        }

        public static bool ClassPathIsFine(this string Text)
        {
            Regex regex = new Regex("[^a-zA-Z0-9_.]");
            return !regex.IsMatch(Text);
        }

        public static int GetNumberOfCharacter(this string Text, char Character)
        {
            if (Text.Length < 1)
                return 0;

            int count = 0;

            for (int i = 0; i < Text.Length; i++)
                if (Text[i] == Character)
                    count++;

            return count;
        }

        /// <param name="MatchingType">start_with, end_with, exist, full_match, regex</param>
        public static bool HasMatching(this string Text, string MatchingType, string Matching)
        {
            switch (MatchingType)
            {
                case "start": return Text.StartsWith(Matching);
                case "end": return Text.EndsWith(Matching);
                case "exist": return Text.Contains(Matching);
                case "full_match": return (Text == Matching);
                case "regex":
                    {
                        Regex re = new Regex(Matching, RegexOptions.IgnoreCase);
                        return re.IsMatch(Text);
                    }
            }

            return false;
        }

        /// <param name="MatchingType">start_with, end_with, exist, full_match, regex</param>
        public static bool HasMatching(this object Text, string MatchingType, string Matching)
        {
            return HasMatching(Text.ToString(), MatchingType, Matching);
        }

        public static List<string> AddList(this List<string> CurrentList, List<string> NewList)
        {
            foreach (string s in NewList)
                CurrentList.Add(s);

            return CurrentList;
        }

        public static bool IsNullOrTrue(this bool? Value)
        {
            if (Value == null)
                return true;

            if (Value == true)
                return true;

            return false;
        }

        public static bool IsNullOrFalse(this bool? Value)
        {
            if (Value == null)
                return true;

            if (Value == false)
                return true;

            return false;
        }
    }
}
