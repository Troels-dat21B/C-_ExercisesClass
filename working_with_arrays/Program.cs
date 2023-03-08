class main
{
    static void Main(string[] args)
    {
        var episodes = new Simpsons().SimpsonsEpisodes();
        var average = GetAverageEpisodeLenght(episodes.Select(e => e.lenght).ToArray());
        
        Console.WriteLine("Episodes in season order:");
        PrintEpisodesInSeasonOrder(new Simpsons());
        Console.WriteLine($"Average lenght of Simpsons episodes is {average} minutes");
        Console.WriteLine("Top 3 longest episodes are:");
        Top3LongestSeason(episodes.Select(e => e.title).ToArray());





    }


    public static int GetAverageEpisodeLenght(int[] lenghts)
    {
        int sum = 0;
        foreach (var lenght in lenghts)
        {

            sum += lenght;
        }

        return sum / lenghts.Length;
    }

    public static void Top3LongestSeason(String[] seasons){
        
        var query = seasons.OrderByDescending(s => s.Length).Take(3);

        foreach (var s in query)
        {
            Console.WriteLine(s);
        }
    }

    public static void PrintEpisodesInSeasonOrder(Simpsons simpsons){
        
        var episodes = simpsons.SimpsonsEpisodes();


        var query = episodes.OrderBy(e => e.season);
        foreach (var e in query)
        {
            Console.WriteLine(e);
        }
    }


}


