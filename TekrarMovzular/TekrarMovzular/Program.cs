using System.Threading.Channels;
using TekrarMovzular;

//int a=Convert.ToInt32(Console.ReadLine());
//int b=Convert.ToInt32(Console.ReadLine());
//int c=Convert.ToInt32(Console.ReadLine());
//if (a >= b && a>=c )
//{
//    Console.WriteLine($"{a} en boyukdur ");
//}
//else if (b >=a && b >=c)
//{
//    Console.WriteLine($"{b} en boyukdur");
//}
//else if(c>=a && c>=b)
//{
//    Console.WriteLine($"{c} en boyukdur");
//}

//int a=Convert.ToInt32(Console.ReadLine());
//if (a % 2 == 0 && a!=0)
//{
//    Console.WriteLine("Cut ededdir");
//}
//else if (a % 2 == 1)
//{
//    Console.WriteLine("Tek ededdir");
//}
//else
//{
//    Console.WriteLine("0-ne tek nede cut ededdir");
//}


//int a = 5;

//switch (a)
//{
//    case 1:
//        Console.WriteLine("Eded 1-dir");
//        break;
//    case 2:
//        Console.WriteLine("Eded 2-dir");
//        break;
//    case 5:
//        Console.WriteLine("Binqo qalib geldiz");
//        break;
//}


//bool isActive = true;
//string parol = Console.ReadLine();
//if(parol != "1234")
//{
//    for(int i = 1; i <= 3; i++)
//    {
//        switch (i)
//        {
//            case 1:
//                Console.WriteLine("1-ci cehd yanlis");
//                break;
//            case 2:
//                Console.WriteLine("2-ci cehd yanlis");
//                break;
//            case 3:
//                Console.WriteLine("3-cu cehd yanlis kart bloka dusdu");
//                break;
//        }
//    }
//}

//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}

//int i = 1;
//while (i <= 100)
//{
//    Console.WriteLine(i);
//    i++;
//}

//for(int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"Cut eded-{i}");
//    }
//    else if (i % 2 == 1)
//    {
//        Console.WriteLine($"Tek eded-{i}");
//    }
//}

//1+1=2
//1+2=3
//2+3=5
//3+5=8
//5+8=11


//double Average(double a,double b,double c)
//{
//    return (a + b + c) / 3;
//}
//Console.WriteLine(Average(6,8,9));

//int Max(int[] nums)//1 5 3 6 9 1>5 2>5 3
//{
//    int max = nums[0];
//    for (int i = 0; i < nums.Length; i++)
//    {

//        if (nums[i] > max)
//        {
//            max = nums[i];
//        }
//    }
//    return max;
//}
//Console.WriteLine(Max(1,2,5,6));

//Student student = new Student("Ali","Ahmedov",25);
//student.GetFullInfor();

//Class1 class1 = new Class1("Toyota","Green");
//class1.IncreaseSpeed(50);
//class1.IncreaseSpeed(50);

//Console.WriteLine($"Brend-{class1.Brand};Color-{class1.Color};Speed-{class1.Speed}");

//Rectangle rectangle=new Rectangle();
//rectangle.Width = 5;
//rectangle.Height = 6;
//Console.WriteLine(rectangle.GetArea());
//Console.WriteLine(rectangle.GetPerimetr());

//Employees employees = new Employees();
//employees.Age = 5;
//Console.WriteLine(employees.Age);

//StudentTest student=new StudentTest();
//student.Name = "Ali";
//student.Age = -15;
//student.ShowInfo();

BankAccount bnk = new BankAccount(12568);
bnk.Deposit(150);
bnk.Deposit(100);
bnk.ShowInfo();

