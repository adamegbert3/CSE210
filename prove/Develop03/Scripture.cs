public class Scripture {

    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] scriptureToWords = text.Split(' ');
        foreach (string wordText in scriptureToWords)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

        


    public string DisplayWords()
        {
            string wordsToDisplay = "";
            foreach (Word word in _words)
        {
            wordsToDisplay += word.GetWord() + " ";

            
        }
        return wordsToDisplay;
        }

    public void HideRandomWords()
        {
            List<Word> toHide = new List<Word>();

            foreach (Word word in _words)
        {
            if (word.CheckIsVisible() == true)
            {
                toHide.Add(word);
                
            }
        }

        Random random = new Random();

        for (int counter = 0; counter < 3 && toHide.Count > 0; counter++)
        {
            

            int randomWord = random.Next(toHide.Count);

            toHide[randomWord].HideWord();

            toHide.RemoveAt(randomWord);
        }
        }

    public bool CheckIsHidden()
        {
            foreach (Word word in _words)
        {
            if (word.CheckIsVisible() == true)
            return false;
            
        }
        return true;

        }

}