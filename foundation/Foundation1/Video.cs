public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int CountComment(){
        return _comments.Count();
    }

    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }


    //test program
    // public string GetTitle(){
    //     return _title;
    // }

    // public string GetAuthor(){
    //     return _author;
    // }

    // public int GetLength(){
    //     return _length;
    // }

    // public IEnumerable<Comment> GetComments()
    // {
    //     return _comments.AsReadOnly();
    // }

}