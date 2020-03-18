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

        public void AddToDeck(string term, string definition)
        {
            if (Flashcards == null) Flashcards = new List<Flashcard>();

            Flashcards.Add(new Flashcard(term, definition));
        }
    }
}
