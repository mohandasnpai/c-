namespace sum
{
    public class Program
    {
        public static void Main(string[]args)
        {
            static void sum()
            {
                sum obj = new sum();
                obj.ReadNumber();
                obj.CalculateSum();
                obj.Display();
            }
            sum();
        }
    }
}
