using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjPat
{
    class School
    { 
        List<string> Students = new List<string>();

        public event Action Beginreading;
        public event Action Endreading=()=>{};

        public void ShowInfo()

        {
            if (Beginreading != null)
            { 
                this.Beginreading();
            
            }


            foreach (string Student in this.Students)
            {
                Console.WriteLine(Student);
            }
            this.Endreading();
        }


        public void AddStudent(string Student)
        {
            this.Students.Add(Student);
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            School room = new School();
            room.AddStudent("Стасик");
            room.AddStudent("Гриша");
            room.ShowInfo();
            Console.ReadLine();
        }
    }
}
