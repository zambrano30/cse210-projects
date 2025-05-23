using System;
using System.Runtime.InteropServices;

class Word
{
    private string _text;
    private bool _hidden;
    // constructor
    public Word(string Text)
    {
        _text = Text;
        _hidden = false;
    }
    public bool IsHidden()
    {
        return _hidden;
    }
    public void Hide()
    {
        _hidden = true;
    }
    public string GetDisplayText()
    {
        return _hidden ? new string('_', _text.Length) : _text;
    }
}