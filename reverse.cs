using System;
using System.Linq;

static class Program {
    static int Main()
    {
        string input = Console.ReadLine();
        string output = new string(input.Reverse().ToArray());
        Console.WriteLine(output);
        return 0;
    }
}
