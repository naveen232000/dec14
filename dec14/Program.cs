using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dec14
{
    internal class Program
    {// instance scope or class level
        int stuId, Marks;
        string stuName, stuAddress;
        string contact;
        public void AcceptValues()
        {  //int chioce=10;// local or within method scope
            Console.WriteLine("enter your id");
            stuId = int.Parse(Console.ReadLine());//
            Console.WriteLine("enter name");
            stuName = Console.ReadLine();//returns string , is used to read from console
            Console.WriteLine("enter address");
            stuAddress = Console.ReadLine();// string value to be saved in another sting variable
            Console.WriteLine("enter marks");
            Marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("eneter contact");
            contact = Console.ReadLine();
        }
        public string DisplayValues(string name)//parameters to methods
        {
            Console.WriteLine(" stuid is " + stuId);// single variable value only
            Console.WriteLine("with string . format method");
            string allInfo = string.Format("The id is :{0}\t name :{1}\t address of {2}\t   marks {3}\t  conatct  {4}  ", stuId, stuName, stuAddress, Marks, contact);
            Console.WriteLine(" with string interpolation");
           // Console.WriteLine("The id is :{0}\t name :{1}\t address of {2}\t   marks {3}\t  conatct  {4}  ", stuId, stuName, stuAddress, Marks, contact);
           // Console.WriteLine(allInfo);
            Console.WriteLine($"The id is :{stuId}\t name :{stuName}\t address of {stuAddress}\t   marks {Marks}\t  conatct  {contact}");
            return allInfo;//last statement           
        }
        static void Main(string[] args)
        {// create class object
            Program p1;  //p1.AcceptValues(); not allowed 
            //memory allocation
            p1 = new Program();// we can not use p1 unless current line
            Program p = new Program();
            //call methods
            p1.AcceptValues();// no parameters
            p1.DisplayValues("hello");//string argument 
            Console.ReadLine();
        }
    }
}
