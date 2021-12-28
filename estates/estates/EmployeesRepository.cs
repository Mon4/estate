﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estates
{
    class EmployeesRepository:IComparer<Employee>
    {
        string _name;
        List<Employee> _employelist;

        public EmployeesRepository()
        {
            _employelist = new List<Employee>();
        }
        public EmployeesRepository(string n):this()
        {
            _name = n;
        }
        public void AddEmployee(Employee e)
        {
            _employelist.Add(e);
        }
        public void RemoveEmployee(Employee e)
        {
            _employelist.Remove(e);
        }
        public void EmploySort()
        {
            _employelist.Sort();
        }

        public int Compare(Employee x, Employee y)
        {
            if (x.Surname == y.Surname)
                return x.Name.CompareTo(y.Name);
            else
                return x.Surname.CompareTo(y.Surname);
        }

        public void FindEmployeebyName(string name)
        {
            foreach(Employee e in _employelist)
            {
                if(e.Name==name)
                {
                    Console.WriteLine(e);
                }    
            }
        }

        public void FindEmployeebyNumber(string number)
        {
            foreach (Employee e in _employelist)
            {
                if (e.PhoneNumber1 == number)
                {
                    Console.WriteLine(e);
                }
            }
        }





    }
}
