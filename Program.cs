// namespace DotnetTrngDay1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//     Int128 a = 0;
//     Int128 b = 1;
//     Int128 i = 2;
//     Int128 d = 0;

//     while (i <= 100)
//     {
//         Int128 c = a + b;
//         if (a % 2 == 0)
//         {
//             Console.WriteLine(a);
//         }
//         else
//         {
//             d = d + a;
//         }
//         a = b;
//         b = c;
//         i++;
//     }
//     Console.WriteLine(d);


// int[] nameArray = new int[5];
// Console.WriteLine("Enter elements in array");
// for (int i = 0; i < nameArray.Length; i++)
// {
//     nameArray[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Elements in array are:");
// foreach (int x in nameArray)
// {
//     Console.WriteLine(x);
// }

// int[,] multiArray = new int[2, 3];
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 3; j++)
//     {
//         multiArray[i, j] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// Console.WriteLine("Elements in array are:");
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         Console.WriteLine(multiArray[i, j]);
//     }
// }

//             Dictionary<int,string> myDict=new Dictionary<int, string>();
//             for(int i=0;i<3;i++){
//                 myDict.Add(Convert.ToInt32(Console.ReadLine()),Console.ReadLine());
//             }
//             System.Console.WriteLine("************************************************");
//             for(int i=0;i<myDict.Count;i++)
//             {
//                 Console.WriteLine(myDict.Keys);
//             }
//         }
//     }
// }


// namespace DotnetTrngDay2
// {
//     public class Classesobject
//     {
//         static void Main(string[] args)
//         {
//             Student studObj = new Student();//Create an object in C#

//             //Initialize values to properties
//             studObj.studentName = "Jithu";
//             studObj.dob = Convert.ToDateTime("27/06/2002");

//             //Invoke methods
//             studObj.PrintStudentDetails();
//         }



//     }
//     public class Student
//     {
//         public string studentName;
//         public DateTime dob;
//         public string grade;
//         public string parentName;

//         public void PrintStudentDetails()
//         {
//             Console.WriteLine("Name of the student is: " + studentName);
//             Console.WriteLine("Age of the student is: " + CalculateAge());
//         }

//         public int CalculateAge()
//         {
//             return (DateTime.Today.Subtract(dob)).Days / 365;
//         }
//     }
// }

// namespace DotnetTrngDay1
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {

//         }



//     }
//     public class CalculateArea
//     {
//         public void Area(int side)//Signature of a method
//         {
//             Console.WriteLine("Area of Square: {0}",side*side);
//         }
//         public void Area(double length,double breadth)
//         {
//             Console.WriteLine("Area of Rectangle: {0}",length*breadth);
//         }
//         public void Area(double radius)
//         {
//             Console.WriteLine("Area of Cirlce: {0}",3.14 * radius * radius);
//         }
//         public void Area(int a,double b){

//         }
//         public void Area(double a,int b){

//         }

//     }
// }

// namespace DotnetTrngDay1
// {
//     public class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee emp = new Employee();
//             emp.EmployeeName = "Jithu";
//             emp.EmployeeId = "1234";
//             emp.DOB = Convert.ToDateTime("27-06-2002");
//             emp.EmployeeSalary = 69;
//             emp.PrintEmployeeDetails();
//         }
//     }
//     public class Employee
//     {
//         public string EmployeeName { get; set; }
//         public string EmployeeId { get; set; }
//         public DateTime DOB { get; set; }
//         public double EmployeeSalary { get; set; }

//         public void PrintEmployeeDetails()
//         {
//             Console.WriteLine("Name is :" + EmployeeName);
//             Console.WriteLine("Id is :" + EmployeeId);
//             Console.WriteLine("DOB is :" + DOB);
//             Console.WriteLine("Salary is :" + EmployeeSalary);
//         }

//     }
// }

// 

// 

// namespace dotnetTraining
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Enter the number to convert from Kilometer to meter: ");
//             int input = Convert.ToInt32(Console.ReadLine());
//             int conversion = input * 1000;
//             Console.WriteLine("{0}m", conversion);

//             Console.WriteLine("Enter the String: ");
//             string inputString = Console.ReadLine();
//             string changedSring = inputString.Replace("$", "");
//             Console.WriteLine("{0}", changedSring);

//         }
//     }
// }

using System.Security.Cryptography.X509Certificates;

// namespace dotnotTrainingDay4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             object[] daysOfWeeks = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
//             PrintDays(daysOfWeeks);
//         }
//         static void PrintDays(object[] array)
//         {

//             for (int i = 0; i < array.Length; i++)
//             {
//                 if (i == 0 || i == 6)
//                 {
//                     Console.WriteLine("Happy Weekend");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Happy Weekdays");
//                 }
//             }
//         }
//     }
// }
// class A
// {
//     public A()
//     {
//         Console.WriteLine("hi from a");
//     }
//     // public A(int a)
//     // {
//     //     Console.WriteLine("hello from a");
//     // }
// }

// class B : A
// {
//     public B():base()
//     {
//         Console.WriteLine("hi from b");
//     }
//     public B(int a) 
//     {
//         Console.WriteLine("hello from b");
//     }
// }
// }

namespace DotnetTrngDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeeks={"Wednesday","Sunday","Saturday","Tuesday"};
            PrintMessage(daysOfWeeks);
 
            TestStruct obj=new TestStruct();
            obj.PrintA();
 
            // Parent objParent=new Parent();
        }
        static void PrintMessage(string[] days){
           
            foreach (string item in days)
            {
                if(item==Convert.ToString(DaysOfWeeks.Sunday) ||
                item==Convert.ToString(DaysOfWeeks.Saturday)){
                    System.Console.WriteLine("Happy Weekend");
                }
                else{
                    System.Console.WriteLine("Happy Weekday");
                }
            }
           
        }
    }    
    enum DaysOfWeeks{Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday}
    class Parent{
        Parent(){//Constructor is private
            System.Console.WriteLine("Hello private const.");
        }
        public string MyName { get; set; }
 
    }
    struct TestStruct:ITest{
        public int a;
 
        public TestStruct(){
            System.Console.WriteLine("Test struct");
        }
        public void PrintA(){
 
        }
    }
   interface ITest{
 
   }
}