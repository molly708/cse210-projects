using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
  private Reference _reference;
  private List<Word> _words;
  
  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = text.Split(' ').Select(w => new Word(w)).ToList();
  }

  public override string ToString()
  {
    string referenceText = _reference.ToString();
    string scriptureText = string.Join(" ", _words);
    return $"{referenceText} {scriptureText}";
  }

  public void hideWords()
  {
    Random random = new Random();
    int wordsToHide = 2;

    for (int i = 0; i < wordsToHide; i++)
    {
      int index = random.Next(_words.Count);
      if (!_words[index].isHidden()) 
      {
        _words[index].Hide();
      }
    }
  }

  public bool isCompletelyHidden()
  {
    return _words.All(w => w.isHidden());
  }
}
