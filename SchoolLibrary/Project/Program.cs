using System;
using System.Collections.Generic;
using System.Linq;
using SchoolLibrary;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vi laver vores "database" as en art, som er classes Collection.
            Collection collection = new Collection(new List<Student>(), new List<Employee>(), new List<Team>());

            Console.WriteLine("---------------------------------------------");

            //Vi tilføjer 3 students ved brug af classen "Collection"'s "add" function.
            collection.add("Carl", 17);
            collection.add("Brad", 19);
            collection.add("Jack", 21);
            //Vi laver en student list som er det samme som getStudents returnerer.
            List<Student> collectionStudents = collection.getStudents();
            //Derefter bruger vi den liste til at køre gennem alle navne i listen, og printe den ud i console
            for (int i = 0; i < collection.students.Count; i++)
            {
                Console.WriteLine(collectionStudents[i].name);
            }

            Console.WriteLine("---------------------------------------------");

            //Her remover vi en student fra collection's studenter liste, ved brug af "remove" functionen som collection ineholder.
            collection.remove(collection.students.Find(x => x.id == 2));
            //Vi printer alle navne ud igen, for at se, at han er blevet fjernet
            for (int i = 0; i < collection.students.Count; i++)
            {
                Console.WriteLine(collectionStudents[i].name);
            }

            Console.WriteLine("---------------------------------------------");

            //Vi tilføjer et team gennem "add" functionen
            collection.add("Team 1");
            //Vi finder teamet i collection's liste, og tilføjer Carl via teamet's add function
            collection.teams.Find(x => x.name == "Team 1").add(collection.students.Find(x => x.name == "Carl"));
            //Vi laver en student list som er det samme som det getStudents returnerer.
            List<Student> students = collection.teams.Find(x => x.name == "Team 1").getStudents();
            //Så printer vi alle students i teamet ud i console
            for (int i = 0; i < collection.teams.Find(x => x.name == "Team 1").students.Count; i++)
            {
                Console.WriteLine(students[i].name);
            }

            Console.WriteLine("---------------------------------------------");

            //Vi opretter en lærer gennem collection's add function
            collection.add("Jesper", 19000, 29, false, true);
            //Vi laver en liste som er det samme som det collection's getTeachers function returnerer
            List<Employee> collectionTeachers = collection.getTeachers();
            //Vi printer listen ud
            for (int i = 0; i < collection.teachers.Count; i++)
            {
                Console.WriteLine(collectionTeachers[i].name);
            }

            Console.WriteLine("---------------------------------------------");

            //Vi laver endnu et team
            collection.add("Team 2");
            //Vi tilføjer Jesper til begge teams (Team 2 bliver brugt senere)
            collection.teams.Find(x => x.name == "Team 1").add(collection.teachers.Find(x => x.name == "Jesper"));
            collection.teams.Find(x => x.name == "Team 2").add(collection.teachers.Find(x => x.name == "Jesper"));
            //Vi finder Team 1 og kører dens getTeachers function
            List<Employee> teachers = collection.teams.Find(x => x.name == "Team 1").getTeachers();
            //Vi printer listen ud
            for (int i = 0; i < collection.teams.Find(x => x.name == "Team 1").students.Count; i++)
            {
                Console.WriteLine(teachers[i].name);
            }

            Console.WriteLine("---------------------------------------------");

            //Vi finder Jesper, som er en teacher, hvor vi bruger functionen getProfile inde i Employee classen, som returnerer alle variables i classen, som en string.
            Console.WriteLine(collection.teachers.Find(x => x.name == "Jesper").getProfile());

            Console.WriteLine("---------------------------------------------");

            //Vi bruger "edit" functionen som ligger i classen Student, hvor vi siger at hans alder går op med 1.
            collection.students.Find(x => x.name == "Carl").edit(collection.students.Find(x => x.name == "Carl").age += 1);
            //Vi printer det ud i console
            Console.WriteLine(collection.students.Find(x => x.name == "Carl").age);

            Console.WriteLine("---------------------------------------------");

            //Vi går ind og bruger getTeams functionen som ligger i Student classen.
            List<Team> teams = collection.students.Find(x => x.name == "Carl").getTeams();
            //Vi printer alle teams ud i console
            for (int i = 0; i < collection.students.Find(x => x.name == "Carl").teams.Count; i++)
            {
                Console.WriteLine(teams[i].name);
            }

            Console.WriteLine("---------------------------------------------");

            //Vi tilføjer en ny student til Team 1
            collection.teams.Find(x => x.name == "Team 1").add(collection.students.Find(x => x.name == "Brad"));
            //Vi finder team 1 og giver os listen af alle students på teamet
            List<Student> listOfStudents = collection.teams.Find(x => x.name == "Team 1").getStudents();
            //Vi printer alle deres navne ud
            for (int i = 0; i < collection.teams.Find(x => x.name == "Team 1").students.Count; i++)
            {
                Console.WriteLine(listOfStudents[i].name);
            }

            Console.WriteLine("---------------------------------------------");

            //Vi tilføjer Carl til Team 2
            collection.teams.Find(x => x.name == "Team 2").add(collection.students.Find(x => x.name == "Carl"));
            //Vi få en profil over Carl, hvor vi kan se, at begge teams han er med i, er på hans profil
            Console.WriteLine(collection.students.Find(x => x.name == "Carl").getProfile());

            Console.WriteLine("---------------------------------------------");
        }
    }
}
