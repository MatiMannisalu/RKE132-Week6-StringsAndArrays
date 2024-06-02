//T6 Y9

string[] colors = { "red", "green", "blue", "pink", "yellow" };

Random rnd = new Random ();

string randomColor = colors[rnd.Next(0, colors.Length)];

Console.WriteLine($"You should wear {colors[Random]} today.");