namespace Reversenum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            static void Reversenum()
            {
                ReverseNum obj = new ReverseNum();
                obj.ReadData();
                obj.Reverse();
                obj.Display();
            }
                Reversenum();
        }
    }
}
