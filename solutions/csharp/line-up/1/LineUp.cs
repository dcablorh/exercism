public static class LineUp
{
    public static string Format(string name, int number)
    {
        var word = number.ToString();
        if (word == "11" || word == "12" || word == "13" || (word.Length > 2 && (word.EndsWith("11") || word.EndsWith("12") || word.EndsWith("13"))))
        {
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
        else if (word.EndsWith("1"))
        {
            return $"{name}, you are the {number}st customer we serve today. Thank you!";
        }
        else if (word.EndsWith("2"))
        {
            return $"{name}, you are the {number}nd customer we serve today. Thank you!";
        }
        else if (word.EndsWith("3"))
        {
            return $"{name}, you are the {number}rd customer we serve today. Thank you!";
        }
        else
        {
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
    }
}