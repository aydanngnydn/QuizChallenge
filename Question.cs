namespace Quiz;

public class Question
{
    public string description;
    public List<Answer> answers;
    public Types questionType;
    public string correctAnswers;
    
    public Question(string _description, List<Answer> _answers, Types _questionType, string _correctAnswers)
    {
        description = _description;
        answers = _answers;
        questionType = _questionType;
        correctAnswers = _correctAnswers;
    }
}

