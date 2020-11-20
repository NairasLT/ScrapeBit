## ScrapeBit

### Example C#
    string Value = "lloookofdko,,,text:awesometext]]-fds]e]";
    string Result = ScrapeBit.String(Value, "text:", "]]", 30);
    Console.WriteLine(Result);
  
### Example Javascript
    const ScrapeBitString = require("./ScrapeBit");
    const Value = "lloookofdko,,,text:awesometext]]-fds]e]";
    const Result = ScrapeBitString(Value, "text:", "]]", 30);
    console.log(Result);
