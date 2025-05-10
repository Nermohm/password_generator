namespace ConsoleApp13
{
    internal class Program
    {

        static int Num()
        {
//======================================================================Welcome To Password Generator====================================================================//
         //Creates a passwords that contains 4 digits//  
                Random n = new Random();
                int u = n.Next(1000, 9999);

                Console.Write(u);
                
            
            return u;
        }
        //Creates a passwords that contains 16 letters or symbols//  
        static void chart()
        {
            string lol = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+";
            for (int i = 1;i < 16; i++)
            {
                Random n = new Random();
                int u = n.Next(0, 65);
                Console.Write(lol[u]);

            }
            
        }
        static void Main(string[] args)
        {
            int x = int Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Num();
                    break;
                case 2:
                    chart();
                    break;
            }
            
            
            Console.WriteLine();
            
        }
    }
}
