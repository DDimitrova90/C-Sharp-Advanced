﻿namespace _08_Extract_Quotations
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractQuotations
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"("".+?"")|('.+?')";  // ('|")(.+?)\1
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                if (match.ToString().StartsWith("\""))
                {
                    Console.WriteLine(match.ToString().Trim('"'));
                }
                else if (match.ToString().StartsWith("'"))
                {
                    Console.WriteLine(match.ToString().Trim('\''));
                }
            }
        }
    }
}
