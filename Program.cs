using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create person objects
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //Show Gina's info as a sentence
            Console.WriteLine(person2.DisplayPersonInfo());

            //Show Mike's info as a list
            Console.WriteLine(person3.ToString());

            //Change Ian's favorite color and print his info as a sentance
            person1.ChangeFavoriteColour();
            Console.WriteLine(person1.DisplayPersonInfo());

            //Display Mary's age after 10 years
            Console.WriteLine($"{person4.name}'s age in 10 years is, {person4.GetAgeInTenYears()}");

            //Create and show relations
            Relation sisters = new Relation(person4, person2, "Sisters");
            Relation brothers = new Relation(person3, person1, "Brothers");
            Console.WriteLine($"The relationship between {sisters.person1.firstName} and {sisters.person2.firstName} is {sisters.relationshipType}");
            Console.WriteLine($"The relationship between {brothers.person1.firstName} and {brothers.person2.firstName} is {brothers.relationshipType}");

            //Add persons to a list
            List<Person> ListofPersons = new List<Person> { person1, person2, person3, person4 };

            //Display average age
            float average = 0;
            float iteration = 0;
            foreach (Person person in ListofPersons)
            {
                average += person.age;
                iteration += 1;
            }

            average = average / iteration;

            Console.WriteLine($"The average age is :{average}");

            //Display youngest and oldest
            List<int> ListOfAges = new List<int>();

            foreach (Person person in ListofPersons)
            {
                ListOfAges.Add(person.age);
            }

            ListOfAges.Sort();
            int youngest = ListOfAges[0];
            int oldest = ListOfAges[3];

            foreach (Person person in ListofPersons)
            {
                if (person.age == youngest)
                {
                    Console.WriteLine($"The youngest person is: {person.firstName}");
                }
                if (person.age == oldest)
                {
                    Console.WriteLine($"The oldest person is: {person.firstName}");
                }
            }

            //Display names starting with "M"
            foreach (Person person in ListofPersons)
            {
                if (person.firstName.StartsWith("M"))
                {
                    Console.WriteLine(person.ToString());
                }
            }

            //Information of the person who likes Blue
            foreach (Person person in ListofPersons)
            {
                if (person.favoriteColour == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}
