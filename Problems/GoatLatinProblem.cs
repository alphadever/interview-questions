using System;
using System.Collections.Generic;
using System.Text;

namespace Problems
{
    public class GoatLatinProblem
    {
        public string ToGoatLatin(string S)
        {
            string output = string.Empty;
            var splittedString = S.Split(' ');

            for (int i = 0; i < splittedString.Length; i++)
            {
                string word = splittedString[i];
                if (word.ToLower()[0].Equals('a') || word.ToLower()[0].Equals('e') ||
                   word.ToLower()[0].Equals('i') || word.ToLower()[0].Equals('o') ||
                   word.ToLower()[0].Equals('u'))
                    output += word + "ma" + new string('a', i + 1) + " ";
                else
                {
                    output += (word + word[0] + "ma" + new string('a', i + 1) + " ").Remove(0, 1);
                }

            }
            return output.Trim();
        }
    }
}
