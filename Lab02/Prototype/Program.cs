namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 4");
        
        // father of all fathers
        
        Virus fatherVirus = new Virus(10.5, 5, "Father", "Coronavirus");

        // first gen children
        Virus child1 = new Virus(7.2, 3, "Child1", "Coronavirus");
        Virus child2 = new Virus(6.8, 2, "Child2", "Coronavirus");
        Virus child3 = new Virus(5.9, 1, "Child3", "Coronavirus");
        fatherVirus.AddChild(child1);
        fatherVirus.AddChild(child2);
        fatherVirus.AddChild(child3);
        
        // second gen children (child1 is father now)
        Virus grandChild1 = new Virus(4.0, 1, "GrandChild1", "Coronavirus");
        Virus grandChild2 = new Virus(3.5, 1, "GrandChild2", "Coronavirus");
        child1.AddChild(grandChild1);
        child1.AddChild(grandChild2);
        
        Console.WriteLine($"{new string('=', 40)}\n");
        Console.WriteLine("Original Father Virus info:");
        fatherVirus.ShowFamilyTree();
        Console.WriteLine($"{new string('=', 40)}\n\n");
        
        
        Virus clonedFather = (Virus)fatherVirus.Clone();
        Console.WriteLine($"{new string('=', 40)}\n");
        Console.WriteLine("Cloned Father Virus info (with clone method):");
        clonedFather.ShowFamilyTree();
        Console.WriteLine($"{new string('=', 40)}\n\n");
        
        
        // output 
        //     Task 4
        //     ========================================
        //
        // Original Father Virus info:
        // Father (Coronavirus), Age: 5, Weight: 10,5
        //     -Child1 (Coronavirus), Age: 3, Weight: 7,2
        //     --GrandChild1 (Coronavirus), Age: 1, Weight: 4
        //     --GrandChild2 (Coronavirus), Age: 1, Weight: 3,5
        //     -Child2 (Coronavirus), Age: 2, Weight: 6,8
        //     -Child3 (Coronavirus), Age: 1, Weight: 5,9
        //     ========================================
        //
        //
        //     ========================================
        //
        // Cloned Father Virus info:
        // Father (Coronavirus), Age: 5, Weight: 10,5
        //     -Child1 (Coronavirus), Age: 3, Weight: 7,2
        //     --GrandChild1 (Coronavirus), Age: 1, Weight: 4
        //     --GrandChild2 (Coronavirus), Age: 1, Weight: 3,5
        //     -Child2 (Coronavirus), Age: 2, Weight: 6,8
        //     -Child3 (Coronavirus), Age: 1, Weight: 5,9
        //     ========================================


    }
}