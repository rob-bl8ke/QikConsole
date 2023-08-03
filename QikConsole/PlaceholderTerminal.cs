using System.Collections.Generic;
using System.Linq;

namespace CygSoft.Qik.QikConsole
{
    //
    // Handles the conversion of the symbols to placeholder to allow replacement
    // to occur in templates.
    public class PlaceholderTerminal
    {
        private readonly ISymbolTerminal symbolTerminal;

        public string[] Placeholders { get => placeholderDictionary.Keys.ToArray(); }
        public string[] InputSymbols { get => symbolTerminal.InputSymbols; }

        private Dictionary<string, string> placeholderDictionary =  new Dictionary<string, string>();

        public PlaceholderTerminal(ISymbolTerminal symbolTerminal, string placeholderPrefix, string placeholderPostfix)
        {
            this.symbolTerminal = symbolTerminal;
            
            foreach (var symbol in symbolTerminal.Symbols)
            {
                placeholderDictionary.Add(placeholderPrefix + symbol.Replace("@", "") + placeholderPostfix, symbol);
            }
        }

        public string GetPlaceholderValue(string placeHolderSymbol)
        {
            var symbol = placeholderDictionary[placeHolderSymbol];
            return symbolTerminal.GetValue(symbol);
        }

        public void SetSymbolValue(string inputSymbol, string value)
        {
            symbolTerminal.SetValue(inputSymbol, value);
        }
    }
}
