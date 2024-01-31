using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP.Models
{
    public class FlashcardCollection
    {
        private List<Flashcard> flashcards = new List<Flashcard>();
        private int nextId = 1;

        //Create
        public void AddFlashcard(string front, string back)
        {
            Flashcard flashcard = new Flashcard
            {
                Id = nextId++,
                Front = front,
                Back = back
            };
            flashcards.Add(flashcard);
        }

        //Read - 1 (wszystkie fiszki)
        public void DisplayAllFlashcards()
        {
            foreach (var flashcard in flashcards)
            {
                Console.WriteLine($"ID: {flashcard.Id}, Front: {flashcard.Front}, Back: {flashcard.Back}");
            }
        }

        //Read - 2 (pojedyncza fiszka)
        public void ReadFlashcard(int id)
        {
            var flashcard = flashcards.Find(f => f.Id == id);
            if (flashcard != null)
            {
                Console.WriteLine($"ID: {flashcard.Id}, Front: {flashcard.Front}, Back: {flashcard.Back}");
            }
            else
            {
                Console.WriteLine($"Fiszka o ID: {id} nie została znaleziona.");
            }
        }

        //Update
        public void EditFlashcard(int id, string newFront, string newBack)
        {
            Flashcard flashcard = flashcards.Find(f => f.Id == id);
            if (flashcard != null)
            {
                flashcard.Front = newFront;
                flashcard.Back = newBack;
            }
        }
        //Delete
        public void DeleteFlashcard(int id)
        {
            Flashcard flashcard = flashcards.Find(f => f.Id == id);
            if (flashcard != null)
            {
                flashcards.Remove(flashcard);
            }
        }
    }
}
