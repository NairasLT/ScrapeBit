using System.Collections.Generic;
using System.Linq;

class ScrapeBit
{
    public static string String(string SourceText, string ToFindText, string ReadUntilString, int CharsLimitFromFindText)
    {
        int dIndex = SourceText.IndexOf(ToFindText); // Get Index in string of the find Text.

        if (dIndex == -1) return null; // If Find Text is not found return.

        int End = CharsLimitFromFindText;
        int Start = dIndex + ToFindText.Length;

        if (dIndex + ToFindText.Length + End < SourceText.Length)
            SourceText = SourceText.Substring(Start, End);
        else
            SourceText = SourceText.Substring(dIndex + ToFindText.Length);

        int FoundTerminators = 0;
        IList<char> ReadTextChars = new List<char>(); //Where to store the good chars.
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
