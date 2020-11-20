using System.Collections.Generic;
using System.Linq;

namespace ScrapeBit
{
    class ScrapeBit
    {
        public static string String(string SourceText, string ToFindText, string ReadUntilString, int CharsLimitFromFindText)
        {
            int dIndex = SourceText.IndexOf(ToFindText); // Get Index in string of the find Text.

            if (dIndex == -1) return null; // If Find Text is not found return.

            if (dIndex + CharsLimitFromFindText < SourceText.Length)
                SourceText = SourceText.Substring(dIndex + ToFindText.Length, dIndex + ToFindText.Length + CharsLimitFromFindText);
            else
                SourceText = SourceText.Substring(dIndex + ToFindText.Length);

            int FoundTerminators = 0;
            List<char> ReadTextChars = new List<char>(); //Where to store the good chars.

            char[] SourceTextChar = SourceText.ToArray(); // To Char Array

            char[] TerminatorChars = ReadUntilString.ToArray(); //To Char Array

            for (int i = 0; i < SourceTextChar.Length; i++)
            {
                if (FoundTerminators == TerminatorChars.Length) break;

                if (SourceText[i] == TerminatorChars[FoundTerminators])
                {
                    FoundTerminators++;
                    continue;
                }

                FoundTerminators = 0;
                ReadTextChars.Add(SourceText[i]); // Add the good char
            }
            if (ReadTextChars.Count <= 0) return null;
            else return new string(ReadTextChars.ToArray());
        }
    }
}
