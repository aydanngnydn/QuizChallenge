namespace Quiz;
public enum Types
    {
        singleAnswer, multipleAnswer
    }

public static class QuestionType
{
    public static string GetType(Types name)
    {
        switch (name)
        {
            case Types.singleAnswer:
                return "single answer";
            case Types.multipleAnswer:
                return "multiple answers";
            default: return "wrong type";
        }
    }
}
