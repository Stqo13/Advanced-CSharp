namespace ImplementingLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniDoublyLinkedList doublyLinkedList = new SoftUniDoublyLinkedList();
            ListNode listNode = new ListNode(1);
            ///////////////////////////////////////////////////////
            listNode.AddFirst(1);
            listNode.AddFirst(2);
            listNode.AddFirst(3);
            listNode.AddFirst(4);
            ///////////////////////////////////////////////////////
            listNode.AddLast(5);
            listNode.AddLast(6);
            listNode.AddLast(7);
            listNode.AddLast(8);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"The first removed int => {listNode.RemoveFirst()}");
            Console.WriteLine($"The first removed int => {listNode.RemoveFirst()}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"The last removed int =>{listNode.RemoveLast()}");
            Console.WriteLine($"The last removed int =>{listNode.RemoveLast()}");
            Console.WriteLine("-----------------------------------");
            listNode.ForEach(element=>Console.WriteLine($"element => {element}"));
            //3, 4, 5, 6
            Console.WriteLine("-----------------------------------");
            int[]array = listNode.ToArray();
            foreach (var item in array)
            {
                Console.WriteLine($"Item from node to array => {item}");
            }
        }
    }
}