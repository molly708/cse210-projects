using System;

class Word
{
  private string Text;
  private bool hidden;

  public Word(string text)
  {
    Text = text; // Fixed constructor assignment
    hidden = false;
  }

  public void Hide()
  {
    hidden = true;
  }

  public bool isHidden()
  {
    return hidden;
  }

  public override string ToString()
  {
    return hidden ? new string('_', Text.Length) : Text;
  }
}
