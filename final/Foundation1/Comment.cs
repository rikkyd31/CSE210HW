public class Comment
{
    // Attributes
    private string _commentAuthor;
    private string _commentText;

    // Constructor
    public Comment()
    {
        
    }

    // Getters
    public string GetCommentAuthor()
    {
        return _commentAuthor;
    }

    public string GetCommentText()
    {
        return _commentText;
    }

    // Setters
    public void SetCommentAuthor(string commentAuthor)
    {
        _commentAuthor = commentAuthor;
    }

    public void SetCommentText(string commentText)
    {
        _commentText = commentText;
    }
}