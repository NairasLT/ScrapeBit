using System;
using System.Collections.Generic;
using System.Linq;
public static class ScrapeBit
{
    public static string FirstString(string SourceText, string ToFindText, string ReadUntilString)
    {
        int dIndex = SourceText.IndexOf(ToFindText); // Get Index in string of the find Text.

        if (dIndex == -1) return null; // If Find Text is not found return.

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

    public static string[] AllString(string SourceText, string ToFindText, string ReadUntilString)
    {
        IList<int> indexes = SourceText.AllIndexesOf(ToFindText);
        IList<string> Results = new List<string>();
        foreach(var index in indexes)
        {
            Results.Add(StringFromIndex(SourceText, ToFindText, ReadUntilString, index));
        }

        return Results.ToArray();
    }


    private static string StringFromIndex(string SourceText, string ToFindText, string ReadUntilString, int CustomStartIndex)
    {
        int dIndex = CustomStartIndex; // Get Index in string of the find Text.

        if (dIndex == -1) return null;

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

    private static List<int> AllIndexesOf(this string str, string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException("the string to find may not be empty", "value");
        List<int> indexes = new List<int>();
        for (int index = 0; ; index += value.Length)
        {
            index = str.IndexOf(value, index);
            if (index == -1)
                return indexes;
            indexes.Add(index);
        }
    }
}