using System;
using System.Collections.Generic;

namespace KoreanFlashCards
{
    public class Deck
    {
        public static List<Flashcard> Flashcards;

        public Deck()
        {

        }

        public void AddToDeck(Flashcard flashcard)
        {
            if (Flashcards == null) Flashcards = new List<Flashcard>();
            Flashcards.Add(flashcard);
        }
    }
}
