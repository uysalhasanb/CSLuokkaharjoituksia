﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokkaharjoituksia1
{
    // A superclass for various pet animals
    class Pet 
    { 
        public virtual void Eats()
        {
            Console.WriteLine("Eats some food");
        }
    }

    // A subclass of pet
    class Hare : Pet 
    { 
        public override void Eats() 
        {
            Console.WriteLine("Eats carrots and grass");
        }
    }
    class Hooman
    {
        // Define properties of Hooman ie. fields
        public string name = "Essi Esimerkki";
        public int age = 30;
        public string gender = "Emäntä";

        // Default constructor w/o arguments
        // No need to define, will be created automatically
        public Hooman()
        {

        }

        // Constructor with one argument
        public Hooman(string name)
        {
            this.name = name;
        }

        // Constructor with 2 arguments
        public Hooman(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Constructor with 3 arguments
        public Hooman(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

        }
    
        // A method to say momethin
        public void SayOpinion()
        {
            Console.WriteLine("Voi, lemmikit ne on elämän suola");
        }
    }

    class CatOwner : Hooman 
    {
        public new void SayOpinion()
        { Console.WriteLine("Kissat ovat itsenäisiä ja pitävät hiiret loitolla");
        }
    }

    class DogOwner : Hooman
    {
        public new void SayOpinion()
        { 
            Console.WriteLine("Koira on uskollinen ja luotettava kumppani, ihmisen paras ystävä ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create (instantiate) a hooman object from Hooman class
            Hooman owner = new Hooman("Ossi Omistaja", 35, "isäntä");

            //Call the SayOpinion method
            owner.SayOpinion();
                   
            // Save owners name property to a variable 
            string who = owner.name;

            // Test it by echoing it to a console
            Console.WriteLine("totesi " + who);

            // Create a new catowner object           
            CatOwner catOwner = new CatOwner();

            // Use catOwners SayOpinion method
            catOwner.SayOpinion();            

            // Create a new dogowner and call SayOpinion method
            DogOwner dogOwner = new DogOwner(); 
            dogOwner.SayOpinion();

            //Keep the window opent until enter pressed
            Console.ReadLine();

        }
    }
}
