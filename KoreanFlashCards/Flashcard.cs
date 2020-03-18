using System;
namespace KoreanFlashCards
{
    public class Flashcard
    {
        public string Term { get; set; }
        public string Definition { get; set; }
        public string Key { get; set; }

        public Flashcard()
        {
            Term = "";
            Definition = "";
            Key = "";
        }

        public Flashcard(string term, string definition)
        {
            Term = term;
            Definition = definition;
            Key = term + definition;
        }
    }
}
