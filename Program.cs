using System;
using System.Collections.Generic;
using ProjektOOP.Models;

namespace ProjektOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Baza fiszek - pierwszy realny obiekt, na którym są zaimplementowane Fiszki
            FlashcardCollection flashcardCollection1 = new FlashcardCollection();

            // Dodane startowo fiszki - nie jestem pewien jak zrobić aby znaki japońskie były wyświetlane poprawnie, więc w konsoli wyświetlają się jako znaki zapytania.
            flashcardCollection1.AddFlashcard("あ", "a");
            flashcardCollection1.AddFlashcard("い", "i");
            flashcardCollection1.AddFlashcard("う", "u");
            flashcardCollection1.AddFlashcard("え", "e");
            flashcardCollection1.AddFlashcard("お", "o");

            // Create
            flashcardCollection1.AddFlashcard("przykład1", "crud i read");

            // Read - wszystkie rekordy
            Console.WriteLine("Wszystkie fiszki:");
            flashcardCollection1.DisplayAllFlashcards();

            // Update
            flashcardCollection1.EditFlashcard(6, "przykład2", "update i read");

            // Wyświetlanie fiszek po edycji
            Console.WriteLine("\nWszystkie fiszki po edycji:");
            flashcardCollection1.DisplayAllFlashcards();

            // Usuwanie fiszki
            flashcardCollection1.DeleteFlashcard(6);

            // Wyświetlanie fiszek po usunięciu
            Console.WriteLine("\nWszystkie fiszki po usunięciu tej o id 6: (delete i read)");
            flashcardCollection1.DisplayAllFlashcards();

            Console.WriteLine("Realizacja wymogu Read, w drugi sposób, który pozwala na czytanie pojedynczej fiszki po id (id 3)");
            flashcardCollection1.ReadFlashcard(3);

            //Console.WriteLine("Realizacja pozostałych obiektów aby istniały 3 różne: ");

            FlashcardCollection flashcardCollection2 = new FlashcardCollection(); //dodanie drugiej grupy fiszek
            flashcardCollection2.AddFlashcard("か", "ka");
            flashcardCollection2.AddFlashcard("き", "ki");
            flashcardCollection2.AddFlashcard("く", "ku");
            flashcardCollection2.AddFlashcard("け", "ke");
            flashcardCollection2.AddFlashcard("こ", "ko");

            FlashcardCollection flashcardCollection3 = new FlashcardCollection(); //tak samo trzecia grupa fiszek

            flashcardCollection3.AddFlashcard("さ", "sa");
            flashcardCollection3.AddFlashcard("し", "shi");
            flashcardCollection3.AddFlashcard("す", "su");
            flashcardCollection3.AddFlashcard("せ", "se");
            flashcardCollection3.AddFlashcard("そ", "so");
            flashcardCollection3.AddFlashcard("た", "ta");
            flashcardCollection3.AddFlashcard("ち", "chi");
        }
    }
}