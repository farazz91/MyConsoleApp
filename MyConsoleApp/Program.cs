using System;

namespace MyConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			//Console.WriteLine("Please Enter First Name.");
			//string FirstName = Console.ReadLine();
			//Console.WriteLine("Please Enter Last Name.");
			//string LastName = Console.ReadLine();
			//Console.WriteLine("Hello " + FirstName + " " + LastName);	//Concatination
			//Console.WriteLine("Hello {0} {1}", FirstName, LastName);	//Place Holder Syntax

			//string name = "\\" + "Testing";
			//Console.WriteLine(name);
			//string path = "c:\\test\\test.txt";
			//Console.WriteLine(path);
			//string path1 = @"c:\test\test.txt";	//verbatim literal
			//Console.WriteLine(path1);

			//int number = 11;
			//bool isnumber10 = number == 10 ? true : false;	//turnery operator
			//Console.WriteLine(isnumber10);

			/*int? num = null;    *///nullable
									//Console.WriteLine(num);

			//int? ticketsOnSale = 200;
			////int ticketesAvailable;
			////ticketesAvailable = (int) ticketsOnSale;
			////ticketesAvailable = ticketsOnSale.Value;

			//int availableTicketes = ticketsOnSale ?? 0;	//Null colance operator
			//Console.WriteLine("Tickets available for sale = {0}", availableTicketes);

			//int i = 10;
			//float f = i;	//implict conversion
			//Console.WriteLine(f);

			//float f1 = 122.555F;
			//int i1 = (int) f1;   //explict conversion
			//Console.WriteLine(i1);

			//string chars = "100";
			//int numb1 = int.Parse(chars);
			//Console.WriteLine(numb1);

			//string chars1 = "200"; int Result = 0;
			//int.TryParse(chars1,out Result);
			//Console.WriteLine(Result);

			//int [] evenNum = new int[3];
			//evenNum[0] = 0;
			//evenNum[1] = 2;
			//evenNum[2] = 4;

			////Array []oddnum = new Array[3];
			////oddnum[0] = 1;

			//foreach (var item in evenNum)
			//{
			//	Console.WriteLine(item);
			//}
			//int userNumber = 0;
			//Console.WriteLine("Please enter a number.");
			//int.TryParse(Console.ReadLine(),out userNumber);
			//if (userNumber==10)
			//{
			//	Console.WriteLine("Number is 10.");
			//}
			//else if (userNumber==20)
			//{
			//	Console.WriteLine("Number is 20.");
			//}
			//else
			//{
			//	Console.WriteLine("Number is not 10 nor 20.");
			//}

			//int userNumber = 0;
			//Console.WriteLine("Please enter a number.");
			//int.TryParse(Console.ReadLine(), out userNumber);

			//switch (userNumber)
			//{
			//	//case 10:
			//	//	Console.WriteLine("Number is 10.");
			//	//	break;
			//	//case 20:
			//	//	Console.WriteLine("Number is 20.");
			//	//	break;
			//	case 10:
			//	case 20:
			//		Console.WriteLine("Number is {0}.", userNumber);
			//		break;
			//	default:
			//		Console.WriteLine("Number is not 10 nor 20.");
			//		break;
			//}

			//int TargetNumber = 0,start=0;
			//Console.WriteLine("Please enter a number.");
			//int.TryParse(Console.ReadLine(), out TargetNumber);

			//while (start<TargetNumber)
			//{
			//	Console.WriteLine(start);
			//	start = start + 2;
			//}

			//string userChoice = "";
			//	do
			//	{
			//		Console.WriteLine("Please enter a your choice yes/no.");
			//		userChoice = Console.ReadLine();
			//		if (userChoice.ToLower() == "yes")
			//		{
			//			Console.WriteLine("hi you have choosen yes");
			//		}
			//		else if (userChoice.ToLower() == "no")
			//		{
			//			Console.WriteLine("hi you have choosen yes");
			//		}
			//		else
			//		{
			//			Console.WriteLine("Invalid choice selected.");
			//		}
			//	} while (userChoice.ToLower() != "no" && userChoice.ToLower() != "yes");
			//}

			//int userNumber = 0;
			//Console.WriteLine("Please enter a number.");
			//int.TryParse(Console.ReadLine(), out userNumber);

			//for (int i = 0; i < userNumber; i++)
			//{
			//	Console.WriteLine(i);
			//}

			//int sum = 0, product = 0;
			//Program.Calculate(10, 20,out sum,out product);
			//Console.WriteLine("Sum: {0} Product: {1}",sum,product);

			int[] num = new int[3];
			num = new int[]{ 11, 12, 13 };
			Program.ParamMethods();
			Program.ParamMethods(num);
			Program.ParamMethods(1, 2, 3, 4, 5, 6, 7, 8, 9);			
		}
		//public static void Calculate(int Fn, int Sn, out int sum, out int product)
		//{
		//	sum = Fn + Sn;
		//	product = Fn * Sn;
		//}
		public static void ParamMethods(params int[] Numbers)
		{
			Console.WriteLine("There are {0} elemts in array.",Numbers.Length);
			foreach (var item in Numbers)
			{
				Console.WriteLine(item);
			}
		}
	}
}
