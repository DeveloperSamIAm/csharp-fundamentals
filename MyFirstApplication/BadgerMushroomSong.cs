namespace MyFirstApplication;

// This class uses loops to sing Badger, Badger, Badger by Weebl
internal class BadgerMushroomSong
{
    private string _badger = "Badger, badger, badger\nBadger, badger, badger" +
        "\nBadger, badger, badger\nBadger, badger, badger";
    private string _mushroom = "Mushroom, mushroom";
    private string _snake = "A Snake, a snake \nSnaaake! A Snaaaake \nOooh, it\'s a snake";
    private int _count = 5;

    

    public void BadgerSong()
    {
        while(_count > 0)
        {
            if (_count > 0)
            {
                string lyrics = $"{_badger} \n\n{_mushroom} \n\n{_badger} \n\n{_mushroom} \n\n{_badger} \n\n{_snake}";
                Console.WriteLine(lyrics);
            }

            _count--;

            if(_count == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Last Time!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Play it again!");
            }
        }
    }
}
