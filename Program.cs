using System.ComponentModel.DataAnnotations;
using Uppgift3.Animals;
using Uppgift3.Errors;


namespace Uppgift3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>();
            var worm = new Worm(23, "Dagge", 2, true);
            var swan = new Swan(57, "Den Elake", 15, true);
            var wolfMan = new Wolfman(719, "Jack", 115);

            animalList.Add(worm);
            animalList.Add(swan);
            animalList.Add(wolfMan);

            foreach(var animal in animalList)
            {
                Console.Write($"{animal.GetType().Name} says ");
                animal.DoSound();

                if (animal is IPerson)
                {
                    (animal as IPerson)?.Talk();
                }
            }

            Console.WriteLine();
         
            var dogList = new List<Dog>();
            var horse = new Horse(15, "Hamburgerkött", 57, true);
            //dogList.Add(horse);
            //F9: För att kunna lägga till ett djur i Hundlistan, så måste djuret antingen vara av Hund-klassen eller en subklass till Hund-klassen för att kunna vara ett objekt av en klass som kan adderas till listan.
            //F10: Listan måste vara av en klass innan hund & häst divergerar från varandra & blir olika specialiseringar dvs. när dom subklassar sig. En lista med animals fungerar eller om man vill vara än mer generisk, 
            //     en lista av Objects.En punkt i klasshierarkin innan deras grenar splittar sig & dom specialiserar sig åt olika håll. 


            animalList.Add(horse);
            animalList.Add(new Dog(2, "Bjäfs", 2154, false));

            foreach(var animal in animalList)
            {
                Console.WriteLine(animal.Stats());
            }

            Console.WriteLine();
            //F13: Dom olika statsen skrivs ut, statsmetoden i varje subklass skriver först ut subklassens specifika stats & sen anropar den basklassen, Animal:s, stats metod som skriver ut alla dom stats som är gemensamma för
            //     alla klasser som ärver från Animal. 

            foreach(var animal in animalList)
            {
                if(animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }

            Console.WriteLine();


            //F17: Kommer inte åt den subklass specifika metoden i Dog när man jobbar på basklassen Animal då den är mer generell & har inte tillgång till subklassernas specialiseringar.
            foreach(var animal in animalList)
            {
               if (animal is Dog)
                {
                    Console.WriteLine((animal as Dog)?.DogStringMethod());
                }
            }

            Console.WriteLine();


            var personHandler = new PersonHandler();
            try
            {
                personHandler.CreatePerson(5, "Kurt", "Olsson", 1.75, 319.2);
                personHandler.CreatePerson(19, "Kaj", "Kindvall", 1.64, 72);
                personHandler.CreatePerson(52, "Ulf", "Kristersson", 1.43, 61);

            }catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);   
            }

            var UserErrors = new List<UserError>();
            var numericInputError = new NumericInputError();
            var textInputError = new TextInputError();
            var negativeNumericInputError = new NegativeNumericInputError();
            var tooFewCharactersError = new TooFewCharactersError();
            var tooManyCharactersError = new TooManyCharactersError();  

            UserErrors.Add(numericInputError);
            UserErrors.Add(textInputError);
            UserErrors.Add(negativeNumericInputError);
            UserErrors.Add(tooFewCharactersError);
            UserErrors.Add(tooManyCharactersError);

            foreach(var error in UserErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
           
            //var person = new Person();

            //try
            //{
            //    //person.FName = "Halebaledale";
            //    person.FName = "Kurt";

            //}catch(ArgumentException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //try
            //{
            //    person.LName = "Svensson";
            //}
            //catch (ArgumentException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //try
            //{
            //    //person.Age = -5;
            //    person.Age = 45;
            //}
            //catch (ArgumentException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //try
            //{
            //    //person.Height = -1.75;
            //    person.Height = 1.75;
            //}
            //catch (ArgumentException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //try
            //{
            //    //person.Weight = -78.9;
            //    person.Weight = 219.8;
            //}
            //catch (ArgumentException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
        }
    }
}
