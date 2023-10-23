namespace animalHandler
{
    internal class Program
    {     
        class Animal
        {
            
            public int animalSpeed { get; set; }
            public double animalLengthM { get; set; }
            public int animalWeight { get; set; }
            public string animalName { get; set; }
            public string animalType { get; set; }




            public Animal(int animalspeed, 
                double animallengthM, int animalweight, 
                string animalname, string animaltype)
            {
                animalSpeed = animalspeed;
                animalLengthM = animallengthM;
                animalWeight = animalweight;
                animalName = animalname;
                animalType = animaltype;
            }

            public virtual void makeSound()
            {
                Console.WriteLine("Djuret gör ett ljud");
            }
            public void eat()
            {
                Console.WriteLine("Djuret äter");
            }
            public void sleep()
            {
                Console.WriteLine("Djuret sover");
            }
            public void hunting()
            {
                Console.WriteLine("Djuret jager efter byte");
            }

        }       
        class dog : Animal
        {
            public bool dogBark { get; set; }
            public override void makeSound() 
                { Console.WriteLine("Woof!"); }
            
            public dog(int animalspeed,
                double animallengthM, int animalweight,
                string animalname, string animaltype, bool dogbark)
                : base(animalspeed, animallengthM, animalweight, animalname,animaltype)
            {
                dogBark = dogbark;
            }
            public void Guarding()
            {
                Console.WriteLine("Hunden vaktar");
            }
            
        }

        class dogBulldog : dog
        {
            bool doTricks { get; set; }
            public dogBulldog(int animalspeed,
                double animallengthM, int animalweight,
                string animalname, string animaltype, bool dogbark, bool dotricks)
                : base(animalspeed, animallengthM, animalweight, animalname, animaltype, dogbark)
            {
                doTricks = dotricks;
            }

            
        }

        class dogChihuahua : dog
        {
            
            bool Color { get; set; }
            public dogChihuahua(int animalspeed,
                double animallengthM, int animalweight,
                string animalname, string animaltype, bool dogbark, bool color)
                :base(animalspeed, animallengthM, animalweight, animalname, animaltype, dogbark)
            {
                Color = Color;
            }
        }

        class cat : Animal
        {
            bool lovesToSleep { get; set; }
            public override void makeSound()
            { Console.WriteLine("Meow!"); }
            public cat(int animalspeed,
                double animallengthM, int animalweight,
                string animalname, string animaltype, bool lovestosleep)
                :base(animalspeed, animallengthM, animalweight, animalname, animaltype)
            {
                lovesToSleep = lovestosleep;
            }

        }
        
        class bear : Animal
        {
            bool killsHuman;
            public override void makeSound()
            { Console.WriteLine("Rawr!"); }
            public bear(int animalspeed,
                double animallengthM, int animalweight,
                string animalname, string animaltype, bool killshuman)
                :base(animalspeed, animallengthM, animalweight, animalname, animaltype)
            {
                killsHuman = killshuman;
            }
        }
        
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal(100, 2, 140, "Viktor", "Däggdjur");
            dog hund = new dog(35, 0.4, 20, "Rufs", "Däggdjur", true);
            dogBulldog bulldogA = new dogBulldog(33, 0.4, 16, "Tedor", "Däggdjur", true, true);
            dogChihuahua chihuahuaA = new dogChihuahua(14, 0.3, 10, "Adam", "DäggDjur", true, true);
            cat katt = new cat(32, 0.4, 10, "Tiger", "Däggdjur", true);
            bear bjorn = new bear(56, 2, 500, "Björne", "Däggdjur", true);


            genericAnimal.makeSound();
            hund.makeSound();
            bulldogA.makeSound();
            chihuahuaA.makeSound();
            katt.makeSound();
            bjorn.makeSound();
            
        }
    }
}