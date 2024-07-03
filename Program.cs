

// // Задание 1

// void Counter(int m, int n)
// {
//     if (m > n)
//     {
//         return;
//     }
//     System.Console.Write($"{m} ");
//     Counter(m + 1, n);
// }


// Console.Write("Введите натуральное число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// m += 1; //Если нужно вывести не включая M и N
// n -= 1; //Если нужно вывести не включая M и N 

// Counter(m, n);




///// Задание 2


// int Akkerman(int x, int y)
// {
//     if (x == 0)
//     {
//         return y + 1;
//     }

//     else if ( x > 0 && y == 0)
//     {
//         return Akkerman(x - 1, 1);
//     }

//     else if (x > 0 && y > 0)
//     {
//         return Akkerman(x - 1, Akkerman(x, y - 1));
//     }

//     else 
//     {
//         return 0;
//     }
// }
// System.Console.WriteLine("input number 1: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("input number 2: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int function = Akkerman(m, n);

// System.Console.WriteLine(function);


///// Задание 3


void ReArray(int[] array, int x)
{
   
    if (x < 0)
    {
      return;
    }
    System.Console.Write($"{array[x]} ");
    
    ReArray(array, x - 1);  
}


int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int i = array.Length - 1;
ReArray(array, i);



