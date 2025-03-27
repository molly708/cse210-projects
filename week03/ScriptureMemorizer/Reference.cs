using System;

class Reference
{
  private string Book;
  private int Chapter;
  private int startVerse;
  private int endVerse;

  public Reference(string book, int chapter, int start)
  {
    Book = book;
    Chapter = chapter;
    startVerse = start;
    endVerse = -1;
  }

  public Reference(string book, int chapter, int StartVerse, int EndVerse)
  {
    Book = book;
    Chapter = chapter;
    startVerse = StartVerse;
    endVerse = EndVerse;
  }

  public override string ToString()
  {
    return endVerse == -1 ? $"{Book} {Chapter}:{startVerse}" : $"{Book} {Chapter}:{startVerse}-{endVerse}";
  }
}
