using System.ComponentModel.DataAnnotations;


namespace Uppgift3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
