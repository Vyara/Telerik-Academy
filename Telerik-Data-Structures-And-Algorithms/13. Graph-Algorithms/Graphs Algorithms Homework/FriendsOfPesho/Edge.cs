namespace FriendsOfPesho
{
    public class Edge
    {
        public Edge(Node destination, int distance)
        {
            this.Destination = destination;
            this.Distance = distance;
        }

        public Node Destination { get; private set; }

        public int Distance { get; private set; }
    }
}
