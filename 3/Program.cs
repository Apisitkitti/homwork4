using System;
using System.Collections.Generic;

class Program {
    static bool HasPath(Dictionary<int, List<int>> edges, int source, int destination, HashSet<int> nodes) 
    {
        // ถ้าโหนดต้นทางหรือปลายทางไม่ได้อยู่ในกราฟ ไม่มีเส้นทาง
        if (!nodes.Contains(source) || !nodes.Contains(destination)) 
        {
            return false;
        }

        else
        {
            return true;
        }
    }
    static void Main(string[] args) {
        
        Console.Write("Enter the number of nodes in the graph: ");
        int n = int.Parse(Console.ReadLine());

        // สร้างเซตเพื่อเก็บโหนดในกราฟ
        HashSet<int> nodes = new HashSet<int>();
        for (int i = 1; i <= n; i++) {
            nodes.Add(i);
        }

        
        Dictionary<int, List<int>> edges = new Dictionary<int, List<int>>();

      
        Console.WriteLine("Enter pairs of nodes that are connected in the graph (enter a negative number to stop):");
        while (true) {
            int source = int.Parse(Console.ReadLine());
            if (source < 0 || source >= n) {
                break;
            }
            int destination = int.Parse(Console.ReadLine());
            if (destination < 0 || destination >= n) {
                break;
            }
            if (edges.ContainsKey(source)) {
                edges[source].Add(destination);
            } else {
                edges.Add(source, new List<int> { destination });
            }
        }

        // ตรวจสอบว่ามีเส้นทางจากโหนดต้นทางไปยังโหนดปลายทางหรือไม่
        Console.WriteLine("Enter pairs of nodes to check reachability (enter a negative number to stop):");
        while (true) {
            int source = int.Parse(Console.ReadLine());
            if (source < 0 || source >= n) {
                break;
            }
            int destination = int.Parse(Console.ReadLine());
            if (destination < 0 || destination >= n) {
                break;
            }
            if (HasPath(edges, source, destination, nodes)) {
                Console.WriteLine("Reachable");
                break;
            } else {
                Console.WriteLine("Unreachable");
                break;
            }
        }
    }

    
}