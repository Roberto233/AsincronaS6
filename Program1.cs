class whereSample
{
    static void Main()
    {
        int[] scores = {97, 92, 81, 60 };

        var queryLowNums =
            from score in scores
            where score  > 80
            select score;

        foreach ( var s in queryLowNums )
        { 
            Console.WriteLine(s.ToString() + " ");
        }

    }
}