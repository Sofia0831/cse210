public class MathAssignment : Assignment {
    private string _textbookSection;
    private string _problems;

    public string GetTextBook()
    {
        return _textbookSection;
    }

    public void SetTextBook(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblem()
    {
        return _problems;
    }
    public void SetProblem(string problems)
    {
        _problems = problems;
    }

    public string GetHomework()
    {
        return $"{_textbookSection} Problems {_problems}";
    }
    
    
    
    
    
}