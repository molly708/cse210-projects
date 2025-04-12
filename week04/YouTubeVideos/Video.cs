using System;

class Video
{
  public string _title;
  public string _author;
  public int _length;
  public List<Comment> Comments; 


  public Video (string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
    Comments = new List<Comment>();
  }

  public int GetCommentCount()
  {
    return Comments.Count;
  }

  public void AddComment(Comment comment)
  {
    Comments.Add(comment);
  }
}