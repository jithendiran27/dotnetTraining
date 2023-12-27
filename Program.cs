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

using System.Runtime.Intrinsics.Arm;
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

// 

// using System.Collections;
// using System.Diagnostics.Contracts;
// using System.Formats.Asn1;
// using DotnetTrngDay1;
// using Microsoft.VisualBasic;

// namespace DotnetTrngDay1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Enter the detais of the Parent");

//             System.Console.Write("Enter Name: ");
//             string name= Console.ReadLine();
//             System.Console.Write("Enter DOB: ");
//             DateTime dob= Convert.ToDateTime(Console.ReadLine());
//             System.Console.WriteLine("Enter Phone No: ");
//             string phoneNo=Console.ReadLine();
//             System.Console.WriteLine("**************************************");
//             Child objParent=new Child(name,dob,phoneNo);
//             objParent.PrintDetailsOfParent();
//             System.Console.WriteLine("**************************************");

//             System.Console.WriteLine("Enter the detais of the Child");

//             System.Console.Write("Enter Name: ");
//             name= Console.ReadLine();
//             System.Console.Write("Enter DOB: ");
//             dob= Convert.ToDateTime(Console.ReadLine());
//             System.Console.WriteLine("Enter Phone No: ");
//             phoneNo=Console.ReadLine();
//             System.Console.WriteLine("**************************************");
//             Child objChild=new Child(name,dob,phoneNo);
//             objChild.PrintDetailsOfChild();
//             System.Console.WriteLine("**************************************");




//         }
//     }    
//     class Parent{
//         protected string Name { get; set; }
//         protected DateTime DOB { get; set; }
//         protected string PhoneNo { get; set; }
//         public Parent(string name,DateTime dob,string phoneNo)
//         {
//             Name=name;
//             DOB=dob;
//             PhoneNo=phoneNo;
//         }
//         public void PrintDetailsOfParent(){
//             System.Console.WriteLine("Name of Parent: "+Name);
//             System.Console.WriteLine("DOB of Parent: "+DOB);
//             System.Console.WriteLine("Phone No. of Parent: "+PhoneNo);
//         }
//     }
//     class  Child:Parent{

//         public Child(string name,DateTime dob,string phoneNo):base(name,dob,phoneNo)
//         {
//             Name=name;
//             DOB=dob;
//             PhoneNo=phoneNo;
//         }
//         public void PrintDetailsOfChild(){
//             System.Console.WriteLine("Name of Child: "+Name);
//             System.Console.WriteLine("DOB of Child: "+DOB);
//             System.Console.WriteLine("Phone No. of Child: "+PhoneNo);
//         }
//     }
// }

// 
// namespace DotnetTrngDay5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Child obj=new Child("Shiekhar",Convert.ToDateTime("25/12/1995"));

//             obj.CalculateAge();
//         }
//     }    
//     abstract class Parent{

//         protected string MyName { get; set; }
//         protected DateTime DOB { get; set; }

//         public Parent(string name,DateTime dob){//Parameterised constructor
//             MyName=name;
//             DOB=dob;
//         }


//         protected int CalculateAge(){
//             System.Console.WriteLine("Parent method");
//             return Convert.ToInt32(DateTime.Today.Subtract(DOB).Days/365);
//         }

//         public abstract void PrintDetails();
//         public abstract void PrintDOB();
//     }
//     class Child:Parent{

//         public int Age { get; set; }
//         public Child(string name,DateTime dob):base(name,dob)
//         {

//         }
//         public void PrintMyName(){
//             System.Console.WriteLine("My Name is: "+MyName);
//         }
//         public int CalculateAge(){
//             base.CalculateAge();
//             System.Console.WriteLine("Child Method");
//             return Age;
//         }
//         public override void PrintDetails(){

//             System.Console.WriteLine("My name is {0} and my age is {1}",MyName,CalculateAge());
//         }

//         public override void PrintDOB()
//         {
//             System.Console.WriteLine("My DOB is: "+DOB);
//         }
//     }
// }

// namespace DotnetTrngDay5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             /*            A objA=new A();//Reference of Parent and Object of Parent
//                        objA.CalculateAge();

//                        B objB=new B();//Reference of Child and Object of Child
//                        objB.CalculateAge();

//                        C objC=new C();//Reference of Child and Object of Child
//                        objC.CalculateAge(); */

//             A obj = new B();//Reference of Parent and Object of Child
//             obj.CalculateAge();



//             B obj1 = new C();
//             obj1.CalculateAge();



//         }
//     }
//     class A
//     {

//         public string MyName { get; set; }
//         public DateTime DOB { get; set; }

//         public virtual void CalculateAge()
//         {
//             System.Console.WriteLine("A Class");
//         }
//     }
//     class B : A
//     {
//         public override void CalculateAge()
//         {
//             base.CalculateAge();
//             System.Console.WriteLine("B Class");
//         }
//     }
//     class C : B
//     {
//         public override void CalculateAge()
//         {
//             base.CalculateAge();
//             System.Console.WriteLine("C Class");
//         }
//     }
// }

// namespace DotnetTrngDay6
// {
//     class Program
//     {
//         static void main(string[] args)
//         {
// Predicate<Array> oddOrEven=(a)=>{
//     foreach(int i in a){
//         if(i%2==0){
//             return true;
//         }
//         else
//         return false;

//     }


// };

//             Action<Array> OddOrEve=(b)=>{

//                 for (int i = 0; i < b.Length; i++)
//                 {
//                     if(i%2==0){
//                         Console.WriteLine("Even");
//                     }
//                     else{
//                         Console.WriteLine("Odd");
//                     }
//                 }
//             };


//             Public Array a ={12,34,5};

//             OddOrEve(a);
//         }
//     }
// }

namespace DotnetTask
{
    class Program
    {
        static void Main(string[] args)
        {
            VotingSystem votingSystem = new VotingSystem();

            votingSystem.AddNewVoter("Jithu", "Document");

            votingSystem.SendLink(votingSystem.registeredVoters[0]);
        }
    }
    class Voter
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public bool IsVerified { get; set; }
        public string Link { get; set; }
    }

    class VotingSystem
    {
        public List<Voter> registeredVoters;

        public VotingSystem()
        {
            registeredVoters = new List<Voter>();
        }

        public void AddNewVoter(string name, string Document)
        {
            Voter newVoter = new Voter { Name = name, Document = Document, IsVerified = false, Link = GenerateLink() };
            registeredVoters.Add(newVoter);
            VerifyDocument(newVoter);
        }

        public void VerifyDocument(Voter voter)
        {
            voter.IsVerified = true;
        }

        public string GenerateLink()
        {
            return ("This is your link");
        }

        public void SendLink(Voter voter)
        {
            if (voter.IsVerified)
            {
                Console.WriteLine("Hello {0}, here's your link to vote: {1}", voter.Name, voter.Link);
            }
            else
            {
                Console.WriteLine("Voter not verified.");
            }
        }
    }
}