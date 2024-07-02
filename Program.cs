using System;
using System.ComponentModel;

namespace HeritagePoo
{
    public static class Program
    {
        public static void Main()
        {
            Animal[] animalsSet = new Animal[6];
            Human human = new Human("Bob");
            Monkey monkey = new Monkey("Cheetah");
            Elephant elephant = new Elephant("Dumbo");
            Tortoise tortoise = new Tortoise("Donatello");
            Chicken chicken = new Chicken("Chico");
            Lizard lizard = new Lizard("Denver");

            animalsSet[0] = human;
            animalsSet[1] = monkey;
            animalsSet[2] = elephant;
            animalsSet[3] = tortoise;
            animalsSet[4] = chicken;
            animalsSet[5] = lizard;

            foreach (Animal animal in animalsSet)
            {
                animal.Move(); // Move method is defined in the Animal class
                animal.Eat(); // Eat method is defined in the Animal class
                Console.WriteLine(animal.GetDescription());
            }
        }
    }

    public abstract class Animal
    {
        protected short _legsCount;
        protected bool _hairy;
        protected string _name;

        public Animal(string name, short legsCount, bool hairy)
        {
            _name = name;
            _legsCount = legsCount;
            _hairy = hairy;
        }

        public virtual void Eat()
        {
            System.Console.WriteLine(_name + " eats");
        }

        public virtual void Move()
        {
            System.Console.WriteLine(_name + " moves");
        }

        public string GetName()
        {
            return _name;
        }

        public virtual string GetDescription()
        {
            string type;
            if (this is Mammal)
            {
                type = "Mammal";
            }
            else if (this is Bird)
            {
                type = "Bird";
            }
            else
            {
                type = "Reptile";
            }
            return $"{_name} is a {type} with {_legsCount} legs or paws and " + $"{_name} is {(_hairy ? "hairy" : "not hairy")}\n";
        }
    }

    public abstract class Mammal : Animal
    {
        public Mammal(string name, short legsCount, bool hairy) : base(name, legsCount, hairy) { }
    }

    public abstract class Reptile : Animal
    {
        public Reptile(string name, short legsCount, bool hairy) : base(name, legsCount, hairy) { }
    }

    public abstract class Bird : Animal
    {
        public Bird(string name, short legsCount, bool hairy) : base(name, legsCount, hairy) { }
    }


    public class Human : Mammal
    {
        public Human(string name) : base(name, 2, true)
        { }

        public override void Move()
        {
            System.Console.WriteLine(_name + " is stood and walks on his two feet");
        }
    }

    public class Monkey : Mammal
    {
        public Monkey(string name) : base(name, 4, true)
        { }
        public override void Move()
        {
            System.Console.WriteLine(_name + " jumps from tree to tree and can either walk on two or four hands");
        }
    }

    public class Elephant : Mammal
    {
        public Elephant(string name) : base(name, 4, true)
        { }

        public override void Move()
        {
            System.Console.WriteLine(_name + " walks quite slowly on his four paws, high above Denver's head");
        }
    }
    public class Tortoise : Reptile
    {
        public Tortoise(string name) : base(name, 4, false)
        { }

        public override void Move()
        {
            System.Console.WriteLine(_name + " walks slowly and doesn't run because it's better to take your time");
        }
    }
    public class Chicken : Bird
    {
        public Chicken(string name) : base(name, 2, false)
        { }

        public override void Move()
        {
            System.Console.WriteLine(_name + " walks and jumps a little because it can't fly although it's got wings");
        }
    }

    public class Lizard : Reptile
    {
        public Lizard(string name) : base(name, 4, false)

        { }

        public override void Move()
        {
            System.Console.WriteLine(_name + " crawls with its belly on the ground");
        }
    }
}