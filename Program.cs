using System;
using System.Collections.Generic;
using System.Linq;

namespace testStageOneBackEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n**********Seleccione la opcion de su preferencia:" +
                "\n**************Digite 1 para el primer punto" +
                "\n**************Digite 2 para el segundo punto" +
                "\n**************Digite 3 para el tercer punto ");
                int optionThePoints = int.Parse(Console.ReadLine());

                if (optionThePoints == 1)
                {
                   
                    PointOne();

                }
                else if (optionThePoints == 2)
                {
                    PointSecond();

                }
                else if (optionThePoints == 3)
                {

                    PointThird();

                }
                else
                {
                    Console.Write("Ingrese una opcion valida ");
                }

            } while (true);
        }

        static void PointOne()
        {

            int gradeFirtsStudent = 0;
            int gradeSecondStudent = 0;
            int gradeThirdStudent = 0;

            try
            {
                Console.Write("Digite la nota final del primer estudiante: ");
                gradeFirtsStudent = int.Parse(Console.ReadLine());
                Console.Write("Digite la nota final del segundo estudiante: ");
                gradeSecondStudent = int.Parse(Console.ReadLine());
                Console.Write("Digite la nota final del tercer estudiante: ");
                gradeThirdStudent = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor ingrese datos correctos");
            }

            if (gradeFirtsStudent > gradeSecondStudent && gradeFirtsStudent > gradeThirdStudent)
            {
                if (gradeSecondStudent > gradeThirdStudent)
                    Console.WriteLine($"La nota mayor fue de: {gradeFirtsStudent}, La segunda mejor nota fue de: {gradeSecondStudent}, La menor nota fue de: {gradeThirdStudent}");
                else
                    Console.WriteLine($"La nota mayor fue de: {gradeFirtsStudent}, La segunda mejor nota fue de: {gradeThirdStudent}, La menor nota fue de: {gradeSecondStudent}");
            }
            else if (gradeSecondStudent > gradeFirtsStudent && gradeSecondStudent > gradeThirdStudent)
            {
                if (gradeFirtsStudent > gradeThirdStudent)
                    Console.WriteLine($"La nota mayor fue de: {gradeSecondStudent}, La segunda mejor nota fue de: {gradeFirtsStudent}, La menor nota fue de: {gradeThirdStudent}");
                else
                    Console.WriteLine($"La nota mayor fue de: {gradeSecondStudent}, La segunda mejor nota fue de: {gradeThirdStudent}, La menor nota fue de: {gradeFirtsStudent}");
            }
            else if (gradeThirdStudent > gradeFirtsStudent && gradeThirdStudent > gradeSecondStudent)
            {
                if (gradeFirtsStudent > gradeSecondStudent)
                    Console.WriteLine($"La nota mayor fue de: {gradeThirdStudent}, La segunda mejor nota fue de: {gradeFirtsStudent}, La menor nota fue de: {gradeSecondStudent}");
                else
                    Console.WriteLine($"La nota mayor fue de: {gradeThirdStudent}, La segunda mejor nota fue de: {gradeSecondStudent}, La menor nota fue de: {gradeFirtsStudent}");
            }

            Console.ReadKey();
        }

        static void PointSecond()
        {
            List<string> listClassmate = new List<string>();

            Console.Write("Cuantos son los estudiantes de su clase? ");
            int countStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countStudents; i++)
            {
                Console.Write("Digite el nombre de sus compañeros de clases: ");
                listClassmate.Add(Console.ReadLine());
            }

            for (int i = 0; i < listClassmate.Count; i++)
                Console.WriteLine(listClassmate[i]);

            Console.Write("Que estudiante desea eliminar? ");
            string studentToDelete = Console.ReadLine();
            listClassmate.Remove(studentToDelete);
            Console.Write("\n*********La lista de los estudiantes actualizada es: ");
            listClassmate.Sort();

            for (int i = 0; i < listClassmate.Count; i++)
                Console.WriteLine(listClassmate[i]);

        }

        static void PointThird()
        {
            Dictionary<string, string> classmatesOfCourse = new Dictionary<string, string>();
            
            Console.Write("Cuantos son los estudiantes de su clase? ");
            int countStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countStudents; i++)
            {
                Console.Write("Digite el nombre de su compañero de clases: ");
                string name = Console.ReadLine();
                Console.Write($"Digite el numero de cedula de {name}:  ");
                string id = Console.ReadLine();
                classmatesOfCourse.Add(id, name);
            }

            foreach (var student in classmatesOfCourse)
                Console.WriteLine($"Estos son los compañeros de clase: {student.Value} - {student.Key}");

            int optionToLookOrDeleteClassmate;

            do
            {
                Console.WriteLine("\n**********Seleccione la opcion de su preferencia:" +
                "\n**************Digite 1 si desea consultar por la cedula" +
                "\n**************Digite 2 si desea eliminar la informacion de un estudiante" +
                "\n**************Digite 3 si desea ver los datos actualizados de los estudiantes ");
                optionToLookOrDeleteClassmate = int.Parse(Console.ReadLine());

                if (optionToLookOrDeleteClassmate == 1)
                {
                    Console.WriteLine($"Ingrese la cedula a consultar: ");
                    string idToLook = Console.ReadLine();
                    //classmatesOfCourse.ContainsKey(idToLook);
                    Console.WriteLine($"Este es la informacion sobre el estudiante: {classmatesOfCourse[idToLook]}");
                }
                else if (optionToLookOrDeleteClassmate == 2)
                {
                    Console.WriteLine($"Ingrese la cedula para eliminar la informacion del estudiante: ");
                    string idToRemove = Console.ReadLine();
                    classmatesOfCourse.Remove(idToRemove);
                    Console.WriteLine($"La informacion correspondiente fue borrada ");
                } else if (optionToLookOrDeleteClassmate == 3)
                {
                    Dictionary<string, string> ordered = classmatesOfCourse.OrderBy(student => student.Value).ToDictionary(idStudent => idStudent.Key, student => student.Value);
                    foreach (var student in ordered)
                        Console.WriteLine($"Estos son los compañeros actualizados de la clase: {student.Value} - {student.Key}");
                }

            } while (optionToLookOrDeleteClassmate == 1 || optionToLookOrDeleteClassmate == 2 || optionToLookOrDeleteClassmate == 3);
        }
    }
}
