using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp8;




//Class Employee
class Employee
    {
    public int e;
        public Employee() 
        {
            e = 0;
        }
        public Employee(int id)
        {
            e = id;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    

    //Overloading the equals operator as you have to overload them in pairs.
     public static bool operator == (Employee id,
        Employee other)
    {
    if (id.e == other.e)
        return true;
    else
        return false;
    }
    //Overloading not equals operator as you have to overload them in pairs.
    public static bool operator != (Employee id, Employee other)
    {
    if (id.e != other.e)
        return true;
    else
        return false;
    }
    //The two override statements are needed or will throw errors when overloading the equals operator.
    public override bool Equals(object o)
    {
    if (!(o is Employee))
        return false;
    return this == (Employee)o;
    }
    
    public override int GetHashCode()
    {
    return 0;
    }
}