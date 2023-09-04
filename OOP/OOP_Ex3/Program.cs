using OOP_Ex3;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            string[] songData = Console.ReadLine().Split('_');
            string typeList = songData[0];
            string name = songData[1];
            string time = songData[2];

            Song song = new Song
            {
                TypeList = typeList,
                Name = name,
                Time = time
            };

            songs.Add(song);
        }

        string filter = Console.ReadLine();

        foreach (var song in songs)
        {
            if (filter == "all" || song.TypeList == filter)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}