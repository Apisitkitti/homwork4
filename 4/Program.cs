using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        List<List<int>> nodes = new List<List<int>>();
        while (true)
        {
            int node1 = int.Parse(Console.ReadLine());
            if(node1 >= x || node1 < 0)
            {
                break;
            }
            int node2 = int.Parse(Console.ReadLine());
            if(node2 >= x || node2 < 0)
            {
                break;
            }
            if(node1 == node2)
            {
                break;
            }
            else
            {
                nodes.Add(new List<int>{node1, node2});
            }
        }

        HashSet<int> usedSymbols = new HashSet<int>();
        foreach (List<int> node in nodes) 
        {
            usedSymbols.Add(node[0] % x);
            usedSymbols.Add(node[1] % x);
        }
        int Symbols = usedSymbols.Count - 2;
        Console.WriteLine("Ans: {0}", Symbols);
    }
}
