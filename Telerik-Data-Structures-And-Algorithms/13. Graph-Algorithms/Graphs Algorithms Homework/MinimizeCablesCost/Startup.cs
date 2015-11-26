namespace MinimizeCablesCost
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Minimal cost for cables:");
            Console.WriteLine(new string('-', Console.WindowWidth));

            var neighbourhood = GetNeighbourhood();

            var minSpanningTree = GetMinimumSpanningTree(neighbourhood);

            long minCost = 0;
            Console.WriteLine("All paths:");
            Console.WriteLine(new string('-', Console.WindowWidth));

            foreach (var path in minSpanningTree)
            {
                Console.WriteLine(path);
                minCost += path.Distance;
            }

            Console.WriteLine("Minimal cost: {0}", minCost);
        }

       private static ICollection<Path> GetMinimumSpanningTree(ICollection<Path> neighbourhood)
        {
            var minimumSpanningTree = new OrderedBag<Path>();
            var vertexSets = GetSetsWithOneVertex(neighbourhood);
            foreach (var path in neighbourhood)
            {
                var startHousesGroup = GetVertexSet(path.StartHouse, vertexSets);
                var endHousesGroup = GetVertexSet(path.EndHouse, vertexSets);
                if (startHousesGroup == null)
                {
                    minimumSpanningTree.Add(path);
                    if (endHousesGroup == null)
                    {
                        var newVertexSet = new HashSet<House>();
                        newVertexSet.Add(path.StartHouse);
                        newVertexSet.Add(path.EndHouse);
                        vertexSets.Add(newVertexSet);
                    }
                    else
                    {
                        endHousesGroup.Add(path.StartHouse);
                    }
                }
                else
                {
                    if (endHousesGroup == null)
                    {
                        startHousesGroup.Add(path.EndHouse);
                        minimumSpanningTree.Add(path);
                    }
                    else if (startHousesGroup != endHousesGroup)
                    {
                        startHousesGroup.UnionWith(endHousesGroup);
                        vertexSets.Remove(endHousesGroup);
                        minimumSpanningTree.Add(path);
                    }
                }
            }

            return minimumSpanningTree;
        }

       private static List<HashSet<House>> GetSetsWithOneVertex(ICollection<Path> neighbourhood)
        {
            var allSetsWithOneVertex = new List<HashSet<House>>();
            foreach (var path in neighbourhood)
            {
                bool startHouseToBeAdded = true;
                bool endHouseToBeAdded = true;
                foreach (var set in allSetsWithOneVertex)
                {
                    if (startHouseToBeAdded && set.Contains(path.StartHouse))
                    {
                        startHouseToBeAdded = false;
                    }

                    if (endHouseToBeAdded && set.Contains(path.EndHouse))
                    {
                        endHouseToBeAdded = false;
                    }

                    if (!startHouseToBeAdded && !endHouseToBeAdded)
                    {
                        break;
                    }
                }

                if (startHouseToBeAdded)
                {
                    var newSet = new HashSet<House>();
                    newSet.Add(path.StartHouse);
                    allSetsWithOneVertex.Add(newSet);
                }

                if (endHouseToBeAdded)
                {
                    var newSet = new HashSet<House>();
                    newSet.Add(path.EndHouse);
                    allSetsWithOneVertex.Add(newSet);
                }
            }

            return allSetsWithOneVertex;
        }

       private static ICollection<Path> GetNeighbourhood()
        {
            var neighbourhood = new OrderedBag<Path>();

            neighbourhood.Add(new Path(new House("1"), new House("2"), 2));
            neighbourhood.Add(new Path(new House("1"), new House("3"), 22));
            neighbourhood.Add(new Path(new House("1"), new House("10"), 7));
            neighbourhood.Add(new Path(new House("2"), new House("10"), 12));
            neighbourhood.Add(new Path(new House("2"), new House("9"), 4));
            neighbourhood.Add(new Path(new House("2"), new House("3"), 1));
            neighbourhood.Add(new Path(new House("3"), new House("5"), 7));
            neighbourhood.Add(new Path(new House("4"), new House("3"), 9));
            neighbourhood.Add(new Path(new House("10"), new House("8"), 12));
            neighbourhood.Add(new Path(new House("8"), new House("6"), 17));
            neighbourhood.Add(new Path(new House("8"), new House("7"), 8));
            neighbourhood.Add(new Path(new House("5"), new House("7"), 9));
            neighbourhood.Add(new Path(new House("6"), new House("5"), 18));
            neighbourhood.Add(new Path(new House("4"), new House("5"), 7));
            neighbourhood.Add(new Path(new House("4"), new House("6"), 13));
            neighbourhood.Add(new Path(new House("4"), new House("9"), 4));
            neighbourhood.Add(new Path(new House("8"), new House("9"), 5));
            neighbourhood.Add(new Path(new House("4"), new House("8"), 6));

            return neighbourhood;
        }

        private static HashSet<House> GetVertexSet(House vertex, List<HashSet<House>> vertexSets)
        {
            foreach (var vertexSet in vertexSets)
            {
                if (vertexSet.Contains(vertex))
                {
                    return vertexSet;
                }
            }

            return null;
        }
    }
}
