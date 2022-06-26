using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefaultNamespace;

namespace Quiz;

public class Program
{
    static void Main()
    {
        List<Question> question = new List<Question>();
        QuizC quiz1 = new QuizC("Math Quiz", 3, question);
        List<Answer> answer1 = new List<Answer>() { new Answer("5"), new Answer("4") };
        List<Answer> answer2 = new List<Answer>() { new Answer("4"), new Answer("7") };
        List<Answer> answer3 = new List<Answer>()
            { new Answer("2^2"), new Answer("-2^2"), new Answer("1 + 3"), new Answer("4 ^ 1") };

        Question question1 = new Question("2 + 2 ?", answer1, Types.singleAnswer, "b");
        Question question2 = new Question("What is 2 + 5?", answer2, Types.singleAnswer, "b");
        Question question3 = new Question(" 4 = ?", answer3, Types.multipleAnswer, "abcd");

        quiz1.introPrint();
        quiz1.printQuestion(1, question1);
        string input = Console.ReadLine();
        quiz1.isAnswerCorrect(input,question1.correctAnswers);
        
        quiz1.printQuestion(2, question2);
        string input2 = Console.ReadLine();
        quiz1.isAnswerCorrect(input2,question2.correctAnswers);
        
        quiz1.printQuestion(3, question3);
        string input3 = Console.ReadLine();
        quiz1.isAnswerCorrect(input3,question3.correctAnswers);

        
        Console.WriteLine($"You had {quiz1.score}/3 answers correct");
    }
}