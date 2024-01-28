using System;
using System.Collections.Generic;

class JapaneseAlphabet
{
    public char Symbol { get; set; }
    public string Romaji { get; set; }
}

partial class Program
{
    static List<JapaneseAlphabet> symbols = new List<JapaneseAlphabet>();

    static void Main()
    {
        // Dodanie symboli 
        InitializeSymbols();

        // Przykłady operacji CRUD
        CreateSymbol('あ', "a");
        UpdateSymbol('あ', "ah");
        DeleteSymbol('い');
        ReadAllSymbols();
    }

    static void InitializeSymbols()
    {
        symbols.Add(new JapaneseAlphabet { Symbol = 'あ', Romaji = "a" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'い', Romaji = "i" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'う', Romaji = "u" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'え', Romaji = "e" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'お', Romaji = "o" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'か', Romaji = "ka" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'き', Romaji = "ki" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'く', Romaji = "ku" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'け', Romaji = "ke" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'こ', Romaji = "ko" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'さ', Romaji = "sa" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'し', Romaji = "shi" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'す', Romaji = "su" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'せ', Romaji = "se" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'そ', Romaji = "so" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'た', Romaji = "ta" });
        symbols.Add(new JapaneseAlphabet { Symbol = 'ち', Romaji = "chi" });
        
    }


    static void CreateSymbol(char symbol, string romaji)
    {
        symbols.Add(new JapaneseAlphabet { Symbol = symbol, Romaji = romaji });
        Console.WriteLine($"Added {symbol} - {romaji}");
    }

    static void ReadAllSymbols()
    {
        foreach (var symbol in symbols)
        {
            Console.WriteLine($"{symbol.Symbol} - {symbol.Romaji}");
        }
    }

    static void UpdateSymbol(char symbol, string newRomaji)
    {
        var symbolToUpdate = symbols.Find(s => s.Symbol == symbol);
        if (symbolToUpdate != null)
        {
            symbolToUpdate.Romaji = newRomaji;
            Console.WriteLine($"Updated {symbol} - {newRomaji}");
        }
        else
        {
            Console.WriteLine($"Symbol {symbol} not found.");
        }
    }

    static void DeleteSymbol(char symbol)
    {
        var symbolToDelete = symbols.Find(s => s.Symbol == symbol);
        if (symbolToDelete != null)
        {
            symbols.Remove(symbolToDelete);
            Console.WriteLine($"Deleted {symbol}");
        }
        else
        {
            Console.WriteLine($"Symbol {symbol} not found.");
        }
    }
}
