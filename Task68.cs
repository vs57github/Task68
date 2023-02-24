using System;

namespace AkkermanFunction
{
    class Program
    {
        static int Akkerman(int m, int n) 
        { 
            if (m == 0) 
                return n + 1; 

            else if (n == 0) 
                return Akkerman(m - 1, 1); 

            else 
                return Akkerman(m - 1, Akkerman(m, n - 1)); 
        }

        static void Main(string[] args) 
        { 
            int m = 3; // Неотрицательное число m.  
            int n = 2; // Неотрицательное число n.  

            Console.WriteLine("Функция Аккермана: " + Akkerman(m, n));  

        }  

    }  
}
