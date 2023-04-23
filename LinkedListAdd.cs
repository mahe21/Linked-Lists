namespace LinkedList
{
    internal class LinkedListAdd
    {
        static void Main(string[] args)
        {
            LinkedListAdd linkedList = new LinkedListAdd();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.PrintList();
        }
       
    }
    public class LinkedList
    {
        private Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }
        public void PrintList()
        {
            Node currentNode = this.head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }
    }
     
}