//arithmetic operations

using System.IO;
using System;

class Program
{
    static void Main()
    {
        int a=5, b=5;
        Console.WriteLine(a+b);
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine(a/b);
        
    }
}

//string fuctions 

using System.IO;
using System;

class Program
{
    static void Main()
    {
        string name="preetha";
        int age=22;
        char gender='F';
        float percentage= 75.55F;
        
        Console.WriteLine("name:{0}",name);
        Console.WriteLine("gender:{0}",gender);
        Console.WriteLine("percentage:{0}",percentage);
    
        
    }
}

//USER INPUT

using System.IO;
using System;

class Program
{
    static void Main()
    {
        int firstNumber,secondNumber , result;
        Console.Write("Enter firstNumber:");
        firstNumber=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n Enter secondNumber:");
        secondNumber=Convert.ToInt32(Console.ReadLine());
        result= firstNumber+secondNumber;
        Console.WriteLine("sum of two numbers is :"+result);
        Console.ReadLine();
        
    }
}

// loops (if...else)

using System.IO;
using System;

class Program
{
    static void Main()
    {
        int age;
        Console.Write("age :");
        age=Convert.ToInt32(Console.ReadLine());
        if(age>=18)
        {
            Console.WriteLine("\n eligible for voting");
        }
        else 
        {
            Console.WriteLine("\n not eligible for voting");
            Console.ReadLine();
        }
    }
}

//loops(else if)

using System.IO;
using System;

class Program
{
    static void Main()
    {
        int age;
        Console.Write("age :");
        age=Convert.ToInt32(Console.ReadLine());
        if(age> 60 )
        {
            Console.WriteLine("\n senior citizen");
            Console.WriteLine("\n  eligible for voting");
        }
        else if (age>18 && age <=60)
        {
            Console.WriteLine("\n eligible for voting");
        }
        else
        {
            Console.WriteLine("\n not eligible for voting");
        }
    }
}

// switch statements

using System.IO;
using System;

class Program
{
    static void Main()
    {
        int choice;
        Console.Write("choice:");
        choice=Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("\n add");
                break;
            case 2:
                Console.WriteLine("\n sub");
                break;
            default:
                Console.WriteLine("\n invalid");
                break;
        }      
    }
}

// matrix - transpose 

using System.IO;
using System;

class Program
{
    static void Main()
    {
        int [,] arr = new int[2,2];
        Console.WriteLine("enter numbers :");
        for(int row=0; row<arr.GetLength(0);row++)
        {
            for(int col=0; col<arr.GetLength(1);col++)
            {
               arr[row,col]=Convert.ToInt32(Console.ReadLine()); 
            }
        
        }
         for(int col=0; col<arr.GetLength(0);col++)
        {
            for(int row=0; row<arr.GetLength(1);row++)
            {
               Console.Write(arr[row,col]+"\t");
            }
               Console.Write("\n");
        }
        Console.ReadLine();
        
    }
}
