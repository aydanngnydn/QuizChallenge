using Quiz;

namespace DefaultNamespace;

public class QuizC
{
    private string name;
    private int quesNum;
    private List<Question> questions;

    public int score;
    public QuizC(string _name, int _quesNum, List<Question> questions)
    {
        this.name = _name;
        this.quesNum = _quesNum;
        this.questions = questions;
       
    }
    
    public void introPrint()
    {
        Console.WriteLine($"Welcome to quiz {this.name}. This quiz has {this.quesNum} questions.");
    }

 
    public void printQuestion(int index, Question question)
    {
        Console.WriteLine((index) + "." + question.description + "(Question with" + QuestionType.GetType(question.questionType) + ")" );

        for (var i = 0; i < question.answers.Count; i++) 
            Console.WriteLine($"{(char)('a' + i)}. {question.answers[i].description}");
    }
    public void isAnswerCorrect(string correctAnswers, string userAnswer)
    {
        if(correctAnswers.Equals(userAnswer))
        {
            score++;
        }
    } 
}