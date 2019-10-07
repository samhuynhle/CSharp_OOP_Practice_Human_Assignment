using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human rob = new Human("Robby");
            Human bobby = new Human("Bobby");
            System.Console.WriteLine("Bobby's Health: " + bobby.Health);
            rob.Attack(bobby);
            System.Console.WriteLine("Boddy's Health after: " + bobby.Health);
        }
    }
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get
            {
                return health;
            }
        }
        public Human(string NameInput)
        {
            Name = NameInput;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string NameInput, int StrengthInput, int IntelligenceInput, int DexterityInput, int healthInput)
            {
                Name = NameInput;
                Strength = StrengthInput;

            }
        public int Attack(Human target)
        {
            target.health = target.health - ( 5 * this.Strength );
            System.Console.WriteLine(this.Name + " has attacked " + target.Name);
            return target.Health;
        }
    }
}
