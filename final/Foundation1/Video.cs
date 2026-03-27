public class Video
{
    // Attributes
    private string _title;
    private string _author;
    private int _length;
    private int _numComments;
    private List<Comment> _listComments = new List<Comment>();

    // Constructor
    public Video()
    {
        _numComments = 0;
    }

    // Getters
    public string GetAuthor()
    {
        return _author; 
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetLength()
    {
        return _length;
    }

    public int GetNumberComments()
    {
        
        foreach(Comment comment in _listComments)
        {
            _numComments = _numComments + 1;
        }
        return _numComments;
    }

    // Setters
    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    // Create Comment
    public void CreateComment(string commentAuthor, string commentText)
    {
        Comment myComment = new Comment();
        myComment.SetCommentAuthor(commentAuthor);
        myComment.SetCommentText(commentText);
        _listComments.Add(myComment);
    }
    
    public List<Comment> GetCommentList()
    {
        return _listComments;
    }

}