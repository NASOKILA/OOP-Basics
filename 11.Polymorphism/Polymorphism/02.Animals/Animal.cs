﻿using System;
using System.Collections.Generic;
using System.Text;

public class Animal
{
    public Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavoriteFood = favoriteFood;
    }

    public string Name { get; set; }

    public string FavoriteFood { get; set; }

    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
    }
}