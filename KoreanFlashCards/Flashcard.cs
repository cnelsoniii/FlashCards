using System;
namespace KoreanFlashCards
{
    public class Flashcard
    {
        public string EnglishText { get; set; }
        public string KoreanText { get; set; }

        public Flashcard()
        {
            EnglishText = "";
            KoreanText = "";
        }

        public Flashcard(string englishText, string koreanText)
        {
            EnglishText = englishText;
            KoreanText = koreanText;
        }
    }
}
