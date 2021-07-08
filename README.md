## ScrapeBit
### Regex lookback/lookahead alternative.
### Example C#

    // First Occurrance
    string Value = "<script> var info = { name:\"Dovydas\",Year:2020 } </script> <h1>...</h1>";
    string Result = ScrapeBit.FirstString(Value, "name:\"", "\",");
    // Result = Dovydas
    
    // All Occurrances
    string Value = "<script> var info = { name:\"Dovydas\", Brother: { name:\"Lukas\" } } </script> <h1>...</h1>";
    string[] Results = ScrapeBit.AllString(Value, "name:\"", "\"");
    // Results = [ "Dovydas", "Lukas" ];
    
### Example Javascript

    // First Occurrance
    const ScrapeBit = require("./ScrapeBit");
    const Value = "<script> var info = { name:\"Dovydas\",Year:2020 } </script> <h1>...</h1>";
    const Result = ScrapeBit.FirstString(Value, "name:\"", "\"");
    // Result = Dovydas
    
    // All Occurrances
    const ScrapeBit = require("./ScrapeBit");
    const Value = "<script> var info = { name:\"Dovydas\", Brother: { name:\"Lukas\" } } </script> <h1>...</h1>";
    const Results = ScrapeBit.AllString(Value, "name:\"", "\"");
    // Results = [ "Dovydas", "Lukas" ];
