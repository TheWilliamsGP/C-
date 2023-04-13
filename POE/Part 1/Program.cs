using POE;

internal class Program
{
    private static void Main(string[] args)
    {
        int ch = 4;
        Recipe obj = new Recipe();

        obj.Display();

        do
        {
            Console.WriteLine("\nPress \n1 to Scale the recipe:\n 2 to reset the recipe,\n 3 to clearthe recipe,\n 4 to exit");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:

                    obj.Scalling();
                    break;

                case 2:

                    obj.Reset();
                    break;

                case 3:

                    obj.Clear();
                    break;

                case 4:

                    Console.WriteLine("Thank You");
                    break;
            }

        } while (ch != 4);
    }
}