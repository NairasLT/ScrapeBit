module.exports = { FirstString, AllString };
function FirstString(SourceText, ToFindText, ReadUntilString) {

    const dIndex = SourceText.indexOf(ToFindText); // Get Index in string of the find Text.

    if (dIndex === -1) return null // If Find Text is not found return.

    SourceText = SourceText.substring(dIndex + ToFindText.length);

    let FoundTerminators = 0; // ? 0 index based
    let ReadTextChars = []; //Where to store the good chars.

    SourceText = [...SourceText]; // To Char Array
    const TerminatorChars = [...ReadUntilString]; //To Char Array

    for (let i = 0; i < SourceText.length; i++) {

        if (FoundTerminators === TerminatorChars.length) break;

        if (SourceText[i] === TerminatorChars[FoundTerminators]) {
            FoundTerminators++;
            continue;
        }

        FoundTerminators = 0;
        ReadTextChars.push(SourceText[i]); // Add the good char
    }

    if (ReadTextChars.length <= 0) return null;
    else return ReadTextChars.join("");
}

function AllString(Source, Find, ReadUntil) {
    var Indexes = getIndicesOf(Find, Source, false);
    var Results = [];

    for (let index of Indexes) {
        Results.push(FromIndex(Source, Find, ReadUntil, index))
    }
    return Results;
}

function FromIndex(SourceText, ToFindText, ReadUntilString, CustomIndex) {

    const dIndex = CustomIndex; // Get Index in string of the find Text.

    if (dIndex === -1) return null // If Find Text is not found return.

    SourceText = SourceText.substring(dIndex + ToFindText.length);

    let FoundTerminators = 0; // ? 0 index based
    let ReadTextChars = []; //Where to store the good chars.

    SourceText = [...SourceText]; // To Char Array
    const TerminatorChars = [...ReadUntilString]; //To Char Array

    for (let i = 0; i < SourceText.length; i++) {

        if (FoundTerminators === TerminatorChars.length) break;

        if (SourceText[i] === TerminatorChars[FoundTerminators]) {
            FoundTerminators++;
            continue;
        }

        FoundTerminators = 0;
        ReadTextChars.push(SourceText[i]); // Add the good char
    }

    if (ReadTextChars.length <= 0) return null;
    else return ReadTextChars.join("");
}

function getIndicesOf(searchStr, str, caseSensitive) {
    var searchStrLen = searchStr.length;
    if (searchStrLen == 0) {
        return [];
    }

    var startIndex = 0, index, indices = [];
    if (!caseSensitive) {
        str = str.toLowerCase();
        searchStr = searchStr.toLowerCase();
    }

    while ((index = str.indexOf(searchStr, startIndex)) > -1) {
        indices.push(index);
        startIndex = index + searchStrLen;
    }
    return indices;
}