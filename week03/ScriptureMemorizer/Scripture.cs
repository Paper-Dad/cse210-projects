using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] scripture = text.Split(' ');
        foreach (string w in scripture)
        {
            Word word = new Word(w);

            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> newWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                newWords.Add(w);
            }
        }
        Random randomGenerator = new Random();
        if (numberToHide > newWords.Count)
        {
            numberToHide = newWords.Count;
        }
        int hasHidden = 0;
        while (hasHidden != numberToHide)
        {
            int nextWord = randomGenerator.Next(newWords.Count);
            newWords[nextWord].Hide();
            newWords.RemoveAt(nextWord);

            hasHidden += 1;
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word w in _words)
        {
            displayText += w.GetDisplayText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}