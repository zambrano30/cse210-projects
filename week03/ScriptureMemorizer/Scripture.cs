using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();
    // constructor
    public Scripture(Reference reference, string text)
    {
        reference = _reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));

        }

    }
    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }
    public void HideRandomWords(int count)
    {
        var notHidden = new List<Word>();
        foreach (var word in _words)
        {
            if (!word.IsHidden())

                notHidden.Add(word);

        }
        int toHide = Math.Min(count, notHidden.Count);
        for (int i = 0; i < toHide; i++)
        {
            int index = _random.Next(notHidden.Count);
            notHidden[index].Hide();
            notHidden.RemoveAt(index);
        }
    }
    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


}