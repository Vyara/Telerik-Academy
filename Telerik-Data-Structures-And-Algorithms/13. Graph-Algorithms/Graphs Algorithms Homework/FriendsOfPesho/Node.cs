namespace FriendsOfPesho
{
    using System;

    public class Node : IComparable<Node>
    {
            public Node(string id, bool isHospital)
            {
                this.ID = id;
                this.IsHospital = isHospital;
            }

            public string ID { get; private set; }

            public int DijkstraDistance { get; set; }

            public bool IsHospital { get; set; }

            public int CompareTo(Node other)
            {
                return this.DijkstraDistance.CompareTo(other.DijkstraDistance);
            }

            public override bool Equals(object obj)
            {
                return this.ID == (obj as Node).ID;
            }

            public override int GetHashCode()
            {
                return this.ID.GetHashCode();
            }       
    }
}
