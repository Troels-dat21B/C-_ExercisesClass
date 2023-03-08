class Simpsons{

public (int season , int episode, string title, int lenght)[] SimpsonsEpisodes(){
    
    
    var episodes = new (int season, int episode, string title, int lenght)[]{
    (3, 1, "Simpsons Roasting on an Open Fire", 22),

    (2, 2, "Bart the Genius", 22),

    (1, 3, "Homer's Odyssey", 22),

    (3, 4, "There's No Disgrace Like Home", 23),

    (1, 5, "Bart the General", 22),

    (3, 6, "Moaning Lisa", 22),

    (1, 7, "The Call of the Simpsons", 22),

    (4, 8, "The Telltale Head", 22),

    (1, 9, "Life on the Fast Lane", 22),

    (2, 10, "Homer's Night Out", 22),
    };

    return episodes;
}

    


}