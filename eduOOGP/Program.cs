
// ##__________________________________________________Inheritance

// using System;
// class Enemy  // base class (parent) 
// {
//     public string Entity_Type = "Enemy";  // Enemy field
//     public int Enemy_Health = 100;  // Enemy field

//     public void Attack()           // Enemy method 
//     {
//         Console.WriteLine("I'm attacking you!");
//     }
// }

// class Goblin : Enemy  // derived class (child)
// {
//     public string Name = "Goblin";  // Goblin field
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create a myGoblin object
//         Goblin myGoblin = new Goblin();

//         // Call the attack() method (From the Goblin class) on the myGoblin object
//         myGoblin.Attack();

//         // Display the value of the Name field (from the Goblin class) and the value of the Entity_Type from the Goblin class
//         Console.WriteLine("Imma "+ myGoblin.Name + "\nEntity Type\t: " + myGoblin.Entity_Type + "\nHealth\t\t: " + myGoblin.Enemy_Health);
//     }
// }


// ##__________________________________________________Polymorphism

// using System;
// class Enemy  // base class (parent) 
// {
//     public string Entity_Type = "Enemy";  // Enemy field
//     public int Enemy_Health = 100;  // Enemy field

//     public virtual void Attack()           // Enemy method 
//     {
//         Console.WriteLine("I'm attacking you!");
//     }
// }

// class Goblin : Enemy  // derived class (child)
// {
//     public string Name = "Goblin";  // Goblin field

//     public override void Attack()  // Override the Attack method
//     {
//         Console.WriteLine("Hehehe ha!");
//     }
// }

// class Witch : Enemy  // derived class (child)
// {
//     public string Name = "Witch";  // Goblin field

//     public override void Attack()  // Override the Attack method
//     {
//         Console.WriteLine("nyehehehe!");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create a myGoblin object
//         Goblin myGoblin = new();
//         Witch myWitch = new();

//         // Call the attack() method (From the Goblin class) on the myGoblin object
//         myGoblin.Attack();

//         // Display the value of the Name field (from the Goblin class) and the value of the Entity_Type from the Goblin class
//         Console.WriteLine("Imma "+ myGoblin.Name + "\nEntity Type\t: " + myGoblin.Entity_Type + "\nHealth\t\t: " + myGoblin.Enemy_Health);
//         Console.WriteLine("New Encounter:\n");
//         Console.WriteLine("Imma "+ myWitch.Name + "\nEntity Type\t: " + myWitch.Entity_Type + "\nHealth\t\t: " + myWitch.Enemy_Health);
//     }
// }



// ##__________________________________________________Abstraction

// using System;
// class Enemy  // base class (parent) 
// {
//     public string Entity_Type = "Enemy";  // Enemy field
//     public int Enemy_Health = 100;  // Enemy field

//     public virtual void Attack()           // Enemy method 
//     {
//         Console.WriteLine("I'm attacking you!");
//     }
// }

// class Goblin : Enemy  // derived class (child)
// {
//     public string Name = "Goblin";  // Goblin field

//     public override void Attack()  // Override the Attack method
//     {
//         Console.WriteLine("Hehehe ha!");
//     }
// }

// class Witch : Enemy  // derived class (child)
// {
//     public string Name = "Witch";  // Goblin field

//     public override void Attack()  // Override the Attack method
//     {
//         Voice();
//         CastSpell();
//     }
//     private  void Voice()  // Override the Attack method
//     {
//         Console.WriteLine("nyehehehe!");
//     }

//     private void CastSpell()
//     {
//         Random rnd = new();
//         Console.WriteLine("I'm casting a spell on you!");
//         Console.WriteLine("You've been cursed! You've lost " + rnd.Next(10, 20) + " health points!");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create a myGoblin object
//         Goblin myGoblin = new();
//         Witch myWitch = new();

//         // Call the attack() method (From the Goblin class) on the myGoblin object
//         myGoblin.Attack();

//         // Display the value of the Name field (from the Goblin class) and the value of the Entity_Type from the Goblin class
//         Console.WriteLine("Imma "+ myGoblin.Name + "\nEntity Type\t: " + myGoblin.Entity_Type + "\nHealth\t\t: " + myGoblin.Enemy_Health);
//         Console.WriteLine("New Encounter:\n");
//         Console.WriteLine("Imma "+ myWitch.Name + "\nEntity Type\t: " + myWitch.Entity_Type + "\nHealth\t\t: " + myWitch.Enemy_Health);
//         Console.WriteLine("The witch is attacking!!!\n");
//         myWitch.Attack();
//     }
// }

// ##__________________________________________________Encapsulation

using System;
class Enemy  // base class (parent) 
{
    public string Entity_Type = "Enemy";  // Enemy field
    public int Enemy_Health = 100;  // Enemy field

    public virtual void Attack()           // Enemy method 
    {
        Console.WriteLine("I'm attacking you!");
    }
}

class Goblin : Enemy  // derived class (child)
{
    public string Name = "Goblin";  // Goblin field

    public override void Attack()  // Override the Attack method
    {
        Console.WriteLine("Hehehe ha!");
    }
}

class Witch : Enemy  // derived class (child)
{
    public string Name = "Witch";  // Goblin field

    public override void Attack()  // Override the Attack method
    {
        Voice();
        CastSpell();
    }
    private  void Voice()  // Override the Attack method
    {
        Console.WriteLine("nyehehehe!");
    }

    private void CastSpell()
    {
        Random rnd = new();
        Console.WriteLine("I'm casting a spell on you!");
        Console.WriteLine("You've been cursed! You've lost " + rnd.Next(10, 20) + " health points!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a myGoblin object
        Goblin myGoblin = new();
        Witch myWitch = new();

        // Call the attack() method (From the Goblin class) on the myGoblin object
        myGoblin.Attack();

        // Display the value of the Name field (from the Goblin class) and the value of the Entity_Type from the Goblin class
        Console.WriteLine("Imma "+ myGoblin.Name + "\nEntity Type\t: " + myGoblin.Entity_Type + "\nHealth\t\t: " + myGoblin.Enemy_Health);
        Console.WriteLine("New Encounter:\n");
        Console.WriteLine("Imma "+ myWitch.Name + "\nEntity Type\t: " + myWitch.Entity_Type + "\nHealth\t\t: " + myWitch.Enemy_Health);
        Console.WriteLine("The witch is attacking!!!\n");
        myWitch.Attack();
    }
}