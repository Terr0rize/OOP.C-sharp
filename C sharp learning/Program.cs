using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{

    class Student 
    {

        public string name = "";
        public int course;
        public string budget = "";
        public string money;
        

        public Student()
        {

        }

        public void Output()
        {
            Console.WriteLine("The name of student: " + name);
            Console.WriteLine("The course of student: " + course);
            Console.WriteLine("The budget of student: " + budget);
            Console.WriteLine("The money of student: " + money);
        }

        public void budj()
        {
            if (budget == "Yes")
                money = "Yes";
            else if (budget == "No")
                money = "No";
            else
                money = "I don't know";

        }

        public void Print()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter course of student: ");
            course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Budget or No: ");
            budget = Console.ReadLine();
        }
    }



    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            int key;
            key = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < key; i++)
            {
                Student Vasya = new Student();
               
                Vasya.Print();
                Vasya.budj();
                Vasya.Output();
            }
        }
    }


}