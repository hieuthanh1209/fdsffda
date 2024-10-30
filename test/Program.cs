namespace test
{
    internal class Program
    {
        static void TestInput()
        {
            IntLinkedList list = new IntLinkedList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
        }

        static void Main(string[] args)
        {
            TestInput();
        }
    }
}
