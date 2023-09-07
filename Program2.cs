class whereSample
{
    static void Main()
    {
        int[] scores = { 90, 71, 82, 93, 75, 82};

        var queryLowNums =
            from score in scores
            where score > 80
            orderby score descending
            select score;


      
        foreach (var s in queryLowNums)
        {
            Console.WriteLine(s.ToString() + " ");
        }

    }
}