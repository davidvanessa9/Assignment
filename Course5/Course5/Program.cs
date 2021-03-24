using System;

namespace Course5
{
    //use classes model real world hierarchies
    //use objects model real world hierarchies
    /*
    public class Apartment 
    {
        public int NumberOfRooms;
        public double Price;

       public double modifyPrice(int price2)
        {
            return Price + price2;
        }


    }

    public class Rooms : Apartment
    {
        public double Meters;
        public string RoomName;


       
    }
    class Program
    {
        static void Main(string[] args)
        {

            Apartment apartment = new Apartment {NumberOfRooms = 5, Price = 80000 }; //creating the object apartment
            //display the object 
            Console.WriteLine("The apartment has " + apartment.NumberOfRooms + " rooms and costs " + apartment.Price);
            int number = apartment.NumberOfRooms;
            double meter = 20;
            string []rooms = { "bathroom", "kitchen", "livingroom", "dormitory", "office" };
            for(int i = 0; i < number; i++)
            {
                Rooms room = new Rooms { Meters = meter + 0 * 10, RoomName = rooms[i] }; //creating an object for every instance of the string array rooms
                Console.WriteLine(i + " room has " + room.Meters + " and it's called " + room.RoomName); //display the room object created


            }

            Console.ReadKey();

        }
    }
    */


    //overloading and overriding
    //use properties
    
    class Program
    {
        public class Animal
        {
            private string name;

            
            /*
            public void Sound()
            {
            //the method Sound before making it virtual
                Console.WriteLine("Animal");
            }
            */
            
            public virtual  void Sound()
            {
                Console.WriteLine("Animal");
            }

            
        }

        public class Dog : Animal
        {
            private string bread;


            /*
            public void Sound()
            {
            //the method Sound before making it override
                Console.WriteLine("bark-bark");
            }
            */


            public override void Sound()
            {
                Console.WriteLine("bark-bark");
            }
            


        }

        public class Cat: Animal
        {
            private int age;  //encapsulation-private field
            private string color; //encapsulation-private field

            //using a property
            public string Color { get { return color; } 
                                  set { color = value; }
                                }

            public Cat(int age)
            {
                this.age = age;
            }


            public int Age()
            {
                return age;
            }

            //overloading
            public int Age(int age1)
            {
                return age + age1;
            }

            public void Sound()
            {
                Console.WriteLine("meow");
            }
        }

        static void Main(string[] args)
        {
            /*
            Animal animal = new Animal();
            animal.Sound();
            */
            Animal dog = new Dog();
            dog.Sound(); 

            Cat cat = new Cat(10);
            Console.WriteLine(cat.Age());  //overloading
            Console.WriteLine(cat.Age(10));

            //using properties
            cat.Color = "black"; //set
            Console.WriteLine("The color of the cat is: " + cat.Color); //get
        }

    }
}
