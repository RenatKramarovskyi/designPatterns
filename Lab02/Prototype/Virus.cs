using System;
using System.Collections.Generic;

namespace Singleton;

public class Virus : ICloneable
{
    public double Weight { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public List<Virus> Children { get; set; }


    public Virus(double weight, int age, string name, string species)
    {
        Weight = weight;
        Age = age;
        Name = name;
        Species = species;
        Children = new List<Virus>();
    }
    
    public void AddChild(Virus child)
    {
        Children.Add(child);
    }
    
    public object Clone()
    {
        Virus clone = new Virus(this.Weight, this.Age, this.Name, this.Species);

        foreach (var child in this.Children)
        {
            clone.AddChild((Virus)child.Clone());
        }

        return clone;
    }
    
    public void ShowFamilyTree(int level = 0)
    {
        Console.WriteLine(new string('-', level) + Name + " (" + Species + "), Age: " + Age + ", Weight: " + Weight);

        foreach (var child in Children)
        {
            child.ShowFamilyTree(level + 1);
        }
    }
}