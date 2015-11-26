namespace FriendsOfPesho
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    // Note: To test this in BGCoder, please put the Node and the Edge classes here
    public class Startup
    {
       private static Dictionary<Node, List<Edge>> map;

        public static void Main()
        {
            var n = Console.ReadLine().Split(' ');
            var m = int.Parse(n[0]);
            var h = int.Parse(n[1]);

            map = new Dictionary<Node, List<Edge>>(m);

            var hospitalsStrings = Console.ReadLine().Split(' ');

            var nodes = new Dictionary<string, Node>(m);
            var hospitals = new HashSet<string>();
            foreach (var hospitalString in hospitalsStrings)
            {
                hospitals.Add(hospitalString);
                nodes.Add(hospitalString, new Node(hospitalString, true));
                map.Add(nodes[hospitalString], new List<Edge>());
            }

            for (int i = 1; i <= m; i++)
            {
                var pointString = i.ToString();

                if (!hospitals.Contains(pointString))
                {
                    nodes.Add(pointString, new Node(pointString, false));
                    map.Add(nodes[pointString], new List<Edge>());
                }
            }

            for (int i = 0; i < h; i++)
            {
                var streetInfo = Console.ReadLine().Split(' ');
                var distance = int.Parse(streetInfo[2]);
                map[nodes[streetInfo[0]]].Add(new Edge(nodes[streetInfo[1]], distance));
                map[nodes[streetInfo[1]]].Add(new Edge(nodes[streetInfo[0]], distance));
            }

            var minDistance = int.MaxValue;
            var currentDistance = 0;
            foreach (var hospital in hospitals)
            {
                currentDistance = GetDistanceToHouses(nodes[hospital]);
                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                }
            }

            Console.WriteLine(minDistance);
        }

        private static int GetDistanceToHouses(Node hospital)
        {
            foreach (var node in map)
            {
                node.Key.DijkstraDistance = int.MaxValue;
            }

            hospital.DijkstraDistance = 0;

            var nodes = new OrderedBag<Node>();
            nodes.Add(hospital);

            while (nodes.Count > 0)
            {
                var currentNode = nodes.RemoveFirst();
                if (currentNode.DijkstraDistance == int.MaxValue)
                {
                    break;
                }

                foreach (var edge in map[currentNode])
                {
                    int potentialDistance = currentNode.DijkstraDistance + edge.Distance;
                    if (potentialDistance < edge.Destination.DijkstraDistance)
                    {
                        edge.Destination.DijkstraDistance = potentialDistance;
                        nodes.Add(edge.Destination);
                    }
                }
            }

            int distanceToHomes = 0;
            foreach (var point in map)
            {
                if (!point.Key.IsHospital && point.Key.DijkstraDistance != int.MaxValue)
                {
                    distanceToHomes += point.Key.DijkstraDistance;
                }
            }

            return distanceToHomes;
        }
    }
}