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























    /*
    private string description;
    private QuestionType questionType;
    private List<Answer> answers;

    private Question(QuestionBuilder questionBuilder)
    {
        this.description = questionBuilder.description;
        this.questionType = determineQuestionType();
        this.answers = questionBuilder.answers;
    }

    string getDescription()
    {
        return description;
    }
    
    QuestionType getQuestionType()
    {
        return questionType;
    }
    List<Answer> getAnswers() {
        return answers;
    }
    private QuestionType determineQuestionType()
    {
        int correctAnswerCount = 
    }

    static class QuestionBuilder()
    {
        private string description;
        private List<Answer> answers = new List<Answers>();

        QuestionBuilder(string _description)
        {
            this.description = _description;
        }

        QuestionBuilder addAnswer(Answers _answers)
        {
            this.answers.Add(_answers);
            return this;
        }

        Question build()
        {
            return new Question(this);
        }
    }
    */
}

