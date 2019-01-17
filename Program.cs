using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aim
{
    class Program
    {
		static int newint=100;
		public enum TimeOfDay
		{
		Morning = 0,
		Afternoon = 1,
		Evening = 2
		}
        public static void Main(string[] args)
        {
            Console.WriteLine("\n integer types");
            sbyte sb = 10;
            short s = 33;
            int i = 10;
            long l = 33L;
            byte b = 22;
            ushort us = 33;
            uint ul = 33u;
            ulong ulo = 33ul;
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", sb, s, i, l, b, us, ul, ulo);
            float f = 1.122345656767f;
            double d = 12.1234455657878797;
            Console.Write("\nFloat and Double:\n");
            Console.WriteLine("{0} and \n{1}", f, d);
			decimal dec=111.666666666666666666666M;
			Console.WriteLine("decimal:\n{0} ",dec);
			Console.WriteLine("\nBoolean:");
			bool boolean =true;
			Console.WriteLine("Status: " + boolean);
          //  Console.ReadLine();
			char character ='d';
			Console.WriteLine(character);	
			character = '\0';
			Console.WriteLine("Now null: " + character);
			object o1 = "Hi, I am divya";
			object o2 = 15.3454365;
			string strObj = o1 as string;
			Console.WriteLine(strObj);
			Console.WriteLine(o1.GetHashCode() + " " + o1.GetType());
			Console.WriteLine(o2.GetHashCode() + " " + o2.GetType());
			Console.WriteLine(o1.Equals(o2));
			string s1, s2;
			s1 = "this is string";
			s2 = s1;
			Console.WriteLine("S1 is: {0} and s2 is {1}", s1, s2);
			s2 = "other string";
			Console.WriteLine("S1 is: {0} and s2 is {1}", s1, s2);
			s1 = "c:C:\\Users\\Dell\\source\\repos\\aim";
			Console.WriteLine(s1);
			s1 = @"c:C:\Users\Dell\source\repos\aim\aim";
			Console.WriteLine(s1);
			s1 = @"We can also write
			like this";
			Console.WriteLine(s1);
			bool isZero;
			Console.WriteLine("\nFlow Control: (if)\ni is " + i);
			if (i == 10)
			{
			isZero = true;
			Console.WriteLine("i is Zero {0}",isZero);
			}
			else
			{
			isZero = false;
			Console.WriteLine("i is Non - zero");
			}
			int integerA = 1;
			Console.WriteLine("\nSwitch:");
			switch (integerA)
			{
			case 1:
			Console.WriteLine("integerA = 1");
			break;
			case 2:
			Console.WriteLine("integerA = 2");
			//goto case 3;
			break;
			case 3:
			Console.WriteLine("integerA = 3");
			break;
			default:
			Console.WriteLine("integerA is not 1, 2, or 3");
			break;}
			WriteGreeting(TimeOfDay.Morning);
			Console.WriteLine("Argument is: {0}",args[1]);
			
			 void WriteGreeting(TimeOfDay timeOfDay)
			{
			switch (timeOfDay)
			{
			case TimeOfDay.Morning:
			Console.WriteLine("Good morning!");
			break;
			case TimeOfDay.Afternoon:
			Console.WriteLine("Good afternoon!");
			break;
			case TimeOfDay.Evening:
			Console.WriteLine("Good evening!");
			break;
			default:
			Console.WriteLine("Hello!");
			break;
			
			
			}}
			Console.WriteLine("Scope of Variables.\n1:");
            int newint=0;
			int j;
            for (/*int*/ j = 0; j < 2; j++) //removing comment from for loop will raise error
            {
                //int j;
                //uncomment above line to error "A local variable named 'j' cannot be declared in this
                //scope because it would give a different meaning to 'j', which is already
                //used in a 'parent or current' scope to denote something else"
                Console.Write("{0} {1}\n", newint, Program.newint);
            }
			Console.WriteLine("2:");
            for (int k = 0; k < 3; k++)
            {
                Console.Write("{0} ", k);
            }//Scope of k ends here
            Console.Write("\n");
            //Console.Write(k);
            //uncomment above line to see error "The name 'k' does not exist in the current context"
            for (int k = 3; k > 0; k--)
            {
                Console.Write("{0} ", k);
            }//scope of k ends here again

            Console.WriteLine("Constants");
			 const int valConst = 100; // This value cannot be changed.
            Console.WriteLine("{0} is constant value", valConst);
            //valConst = 45;
            //uncomment above line to see error "The left-hand side of an assignment must be a variable, property or indexer"

            //const only allow constant variables into the expression
            const int valConst2 = valConst + 9 /* + j*/;
            //remove comments from the above line to see error "The expression being assigned to 'valConst2' must be constant"
            Console.WriteLine("Another Constant: {0}", valConst2);

            Console.WriteLine("\nPredefined Data Types\n\nValue Types and Reference Types");
            //Value Types
            int vali = 2, valj = vali;
            Console.WriteLine("vali is: {0} and valj is: {1}", vali, valj);
            valj = 90;
            Console.WriteLine("vali is: {0} and valj is: {1}", vali, valj);
            //Referece Types
            Vector x, y;
            x = new Vector();
            x.value = 3;
			
            y = x;
			
            Console.WriteLine("x is: {0} and y is:{1}", x.value, y.value);
            y.value = 234;
            Console.WriteLine("x is: {0} and y is:{1}", x.value, y.value);
            //If a variable is a reference, it is possible to indicate that it does not refer to any object by setting its value to null:
            y = null;
            //Console.Write("Value for y is: " + y.value);
            //uncomment above line to see runtime exception "System.NullReferenceException: Object reference not set to an instance of an object."
            //CTS
			
			}
			
			public class Vector
			{
			public int value;
			}
			
			
			
        
    }
}
