using System;
using System.Collections.Generic;

class JapaneseAlphabet
{
    public char Symbol { get; set; }
    public string Romaji { get; set; }
}
partial class Program
{
    static List<JapaneseAlphabet> vowels = new List<JapaneseAlphabet>();

    static void Main()
    {
        // Dodanie podstawowych symboli 
        InitializeVowels();

        // Przykłady operacji CRUD
        CreateVowel('あ', "a");
        ReadAllVowels();
        UpdateVowel('あ', "ah");
        DeleteVowel('い');
        ReadAllVowels();
    }

    static void InitializeVowels()
    {
        vowels.Add(new JapaneseAlphabet { Symbol = 'あ', Romaji = "a" });
        vowels.Add(new JapaneseAlphabet { Symbol = 'い', Romaji = "i" });
        vowels.Add(new JapaneseAlphabet { Symbol = 'う', Romaji = "u" });
        vowels.Add(new JapaneseAlphabet { Symbol = 'え', Romaji = "e" });
        vowels.Add(new JapaneseAlphabet { Symbol = 'お', Romaji = "o" });
    }

    static void CreateVowel(char symbol, string romaji)
    {
        vowels.Add(new JapaneseAlphabet { Symbol = symbol, Romaji = romaji });
        Console.WriteLine($"Added {symbol} - {romaji}");
    }

    static void ReadAllVowels()
    {
        foreach (var vowel in vowels)
        {
            Console.WriteLine($"{vowel.Symbol} - {vowel.Romaji}");
        }
    }

    static void UpdateVowel(char symbol, string newRomaji)
    {
        var vowel = vowels.Find(v => v.Symbol == symbol);
        if (vowel != null)
        {
            vowel.Romaji = newRomaji;
            Console.WriteLine($"Updated {symbol} - {newRomaji}");
        }
        else
        {
            Console.WriteLine($"Vowel {symbol} not found.");
        }
    }

    static void DeleteVowel(char symbol)
    {
        var vowel = vowels.Find(v => v.Symbol == symbol);
        if (vowel != null)
        {
            vowels.Remove(vowel);
            Console.WriteLine($"Deleted {symbol}");
        }
        else
        {
            Console.WriteLine($"Vowel {symbol} not found.");
        }
    }
}
