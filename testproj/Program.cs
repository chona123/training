using System;
using System.Collections.Generic;
using system.Linq;

namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {

            Listsample obj = new Listsample();


            obj.print();
            obj.add("Radhi");

            obj.add("Saran");
            obj.add("maha");
            obj.add("zara");

            obj.print();
            obj.delete("Saran");
            obj.print();

            obj.insert(1, "lavan");
            obj.print();




            employeedemo objemp = new employeedemo();
            employeedemo emp_obj = new employeedemo();
            emp_obj.emp_id = 1;
            emp_obj.emp_name = "ram";
            emp_obj.emp_salary = 20000;

            objemp.addemployee(emp_obj);
            objemp.printemployee();

            employeedemo emp_obj1 = new employeedemo();
            emp_obj1.emp_id = 2;
            emp_obj1.emp_name = "sam";
            emp_obj1.emp_salary = 30000;

            objemp.insertemp(1, emp_obj1);
            objemp.printemployee();

            objemp.removeemployee(emp_obj);
            objemp.printemployee();

        }
    }
    class Listsample
    {


        List<string> authors = new List<string>(10);


        public void print()
        {

            Console.WriteLine("printinglist size " + authors.Count);
            foreach (var listitem in authors)
            {
                Console.WriteLine("stringlist : " + listitem);
            }

        }
        public void add(string strinput)
        {
            authors.Add(strinput);
        }
        public void delete(string removeitem)
        {
            authors.Remove(removeitem);

        }
        public void insert(int ind, string item)
        {
            authors.Insert(ind, item);

        }






    }

    class employeedemo
    {

        List<employeedemo> employeelist = new List<employeedemo>(5);

        public int emp_id;
        public string emp_name;
        public int emp_salary;

        public void printemployee()
        {
            Console.WriteLine("printinglist size " + employeelist.Count);


            foreach (var empitem in employeelist)
            {
                Console.WriteLine("emp_id : " + empitem.emp_id);
                Console.WriteLine("emp_name : " + empitem.emp_name);
                Console.WriteLine("emp_salary : " + empitem.emp_salary);

            }
            Console.WriteLine("");
        }


        public void addemployee(employeedemo inputemployee)
        {
            employeelist.Add(inputemployee);
        }
        public void insertemp(int ind, employeedemo inputemployee)
        {
            employeelist.Insert(ind, inputemployee);
        }
        public void removeemployee(employeedemo inputemployee)
        {
            employeelist.Remove(inputemployee);
        }



    }




}
