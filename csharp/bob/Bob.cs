using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        switch (statement.Trim())
        {
            case var s when IsShouting(s) && IsQuestion(s):
                return "Calm down, I know what I'm doing!";
            case var s when IsShouting(s):
                return "Whoa, chill out!";
            case var s when IsQuestion(s):
                return "Sure.";
            case var s when IsSilent(s):
                return "Fine. Be that way!";
            default:
                return "Whatever.";
        }
    }

    private static bool IsShouting(string s)
    {
        var ca = s.ToCharArray();
        return ca.Any(char.IsUpper) && ca.All(c => !char.IsLower(c));
    }

    private static bool IsQuestion(string s) => s.EndsWith("?");

    private static bool IsSilent(string s) => string.IsNullOrEmpty(s);
}