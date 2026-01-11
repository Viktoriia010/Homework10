using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10;

internal class Inhabitant
{
    public string? Name { get; set; }

    private int age;
    public int Age {
        get
        {
            return age;
        }
        set
        {
            if(value > 0)
            {
                age = value;
            }
            else
            {
                throw new Exception("Вік не може бути мінусовим");
            }
        }
    }

    public Inhabitant(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Inhabitant()
    {

    }

    public override string ToString()
    {
        return ($"Inhabitant: {Name}, {Age}");
    }
}
