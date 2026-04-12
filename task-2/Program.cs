using System;

namespace Program{
    // Simple class to represent a person
    public class Person{
        string name = "";
        int age = 0;

        // Constructor to initialize person details
        public Person(string name, int age){
            this.name = name;
            this.age = age;
        }

        // Method to display introduction message
        public void introduce(){
            Console.WriteLine($"Hello, my name is {this.name} and I am {this.age} years old.");
        }
    }

    class Program{
        static void Main(string[] args){
            // Create person objects
            Person p1 = new Person("Keshwanth", 21);
            Person p2 = new Person("Priya", 25);
            
            // Introduce people
            p1.introduce();
            p2.introduce();
        }
    }
}