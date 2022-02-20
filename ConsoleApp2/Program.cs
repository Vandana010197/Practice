using System;
namespace program
{
    /* class calculator
     {
             int num1;
             int num2;
             int result;
         void add()
         {
             result = num1 + num2;
             display();
             //Console.WriteLine(result);
             //Console.ReadLine();
         }
         void subtract()
         {
             result = num1 - num2;
              display();

         }
         void multiply()
         {
                 result = num1 * num2;
                 display();
         }
         void display()
         {
             Console.WriteLine(result);
             Console.ReadLine();
         }
         public static void Main(string[] args)
         {
             calculator p=new calculator();
             p.num1 = 40;
             p.num2 = 5;
             p.add();
             p.multiply();
         } 
     }*/
    /*   class program
        {
            public int FindMax(int num1,int num2)
            {
                int result;
                if (num1 > num2)
                {
                    result = num1;
                }
                else
                {
                    result = num2;
                }
                return result;
            }
            static void Main(string[] args)
            {
                program find=new program();

                Console.WriteLine(find.FindMax(40, 20));
                Console.ReadLine();
            }
        }
    }
    class program
    {
        
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter three numbers");
          int[] arr  = { 5,8,9, 10, 11,};
            int[] arr2 = arr.Length;
                for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > arr.[i+1])
                {

                }
            }*/


    /*class Calculator
    {


        static void  Main(string[] args)
        {
            Console.Write("Enter first name:");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name:");
            string lastName = Console.ReadLine();
            //Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("Hello,Mr.{0} {1}",firstName,lastName);
            Console.ReadLine();

        }
    }*/

    /*class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= num; i++)
            {

                if (i % 2 != 0) { 
                    Console.WriteLine("Odd number is:"+i);
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }*/
    /*
     class pattern 
    {
        static void Main(string[] args)
        {
            int ctr;
            int ptr;
            for (ctr = 0; ctr <= 3; ctr++)
            {
                ptr = 0;
                for(ptr = 0; ptr<=ctr; ptr++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }*/

    /* class Program
      {
          static void Main(string[] args)
          {
              int square; 
              int sum = 0;
              Console.Write("Enter any natural number:");
              int num =int.Parse(Console.ReadLine());
              for(int i = 1; i <= num; i++)
              {
                  square = i * i;
                  Console.WriteLine(square);
                  sum = sum + square;

              }
              Console.WriteLine("sum is "+sum);
              Console.ReadLine();
          }
      }*/
    /*class Program
      {
          static void Main(string[] args)
          {
             // Console.Write("Enter elements of array:");
             // int[] arr = new int[3];
              int[] arr = {8,9,8};
              int[] arr1 = { 8, 9, 8 };
              int store = 0;
              int j;
              int i;
              for (j=0; j < 3; j++)
              {
                  store = 0;
                  for(i=0; i<3 ; i++)
                  {
                      if (arr[j] == arr1[i]) 
                          store++;
                  }
                  Console.WriteLine("Element of"+arr[j]+":"+store+"times");
                  //Console.WriteLine(store);

              }
              Console.ReadLine();
          }
      }*/

    class program
    {
        static void Main(string[] args) {
            /* int num;
             int reverse;
             for(num = 12221; num > 0; num=num+0)
                 {
                     reverse = num%10;
                     reverse = reverse/10;
                 }*/

            string arr = "real";
            char[] arr1=new char[arr.Length];

            for(int i=arr.Length; i<=arr.Length;i--)
            {
                for(int j=0; j<arr1.Length; j++)
                {
                    arr1[j] = arr[i];
                }
            }
            Console.WriteLine(arr1);
            Console.ReadLine(); 

          /*  for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];

                Console.Write(arr1[i]);
            }
            Console.ReadLine();

            char[] arr2=new char[arr.Length];
            arr
           // for(int i = arr.Length; i <= arr.Length; i--)
            {

            }*/
          
       }
    }
    }
