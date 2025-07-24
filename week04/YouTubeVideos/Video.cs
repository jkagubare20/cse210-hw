using System;
using System.ComponentModel.DataAnnotations;

public class Video
{
    public string _title;
    public string _author;
    public int _duration; // in seconds
    public List<Comment> _comments = new List<Comment>();
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}