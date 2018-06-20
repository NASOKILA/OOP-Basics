﻿using System;
using System.Collections.Generic;
using System.Text;


public class Child : Person
{
    const int MAX_AGE = 15;

    public Child(string name, int age)
        :base(name, age)
    {

    }

    public override int Age
    {
        get { return base.Age; }
        set 
        {
            if(value > MAX_AGE)
            {
                throw new ArgumentException("Child's age must be less than 15!");
            }
            
            base.Age = value;
        }
    }
}
