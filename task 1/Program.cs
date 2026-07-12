namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number of the small carpet");
            int small_carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the number of the large carpet");
            int large_carpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the charge per small carpet is $25");
            Console.WriteLine("the charge per large carpet is $35");
            int subtotal = (small_carpet*25)+(large_carpet*35);
            Console.WriteLine($"cost: { subtotal}");
            Console.WriteLine("tax $6.6%");
            double tax = subtotal * 0.066;
            double total = tax + subtotal;
            Console.WriteLine($"total cost: { total}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
