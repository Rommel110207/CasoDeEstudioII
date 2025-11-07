using System;
using System.Collections.Generic;
using System.Linq;
// Representa un curso con id, nombre y área
class Course
{
    public int Id { get; }
    public string Name { get; }
    public string Area { get; }

    public Course(int id, string name, string area)
    {
        Id = id;
        Name = name;
        Area = area;
    }

    public override string ToString() => $"[{Id}] {Name} - {Area}";
}

// Representa a un estudiante con una lista de cursos inscritos

class Student
{
    public string Name { get; }
    public List<Course> Enrolled { get; } = new List<Course>();

    public Student(string name) => Name = name;
}
// Aplicación de consola para inscripción a cursos

class EnrollmentApp {
    static List<Course> Courses = new List<Course>() {
        new Course(1, "Algoritmos I", "CS"),
        new Course(2, "Introducción a la Programación", "CS"),
        new Course(3, "Matemática Discreta", "Math"),
        new Course(4, "Bases de Datos", "CS"),
        new Course(5, "Cálculo I", "Math"),
    };
    // Método principal de la aplicación

    public static void Run()
    {
        Console.WriteLine("Aplicación de Inscripción a Cursos");
        Console.Write("Nombre del estudiante: ");
        var studentName = Console.ReadLine()?.Trim();
        if (string.IsNullOrWhiteSpace(studentName))
        {
            Console.WriteLine("Nombre inválido. Saliendo.");
            return;
        }

        var student = new Student(studentName);

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1) Listar cursos");
            Console.WriteLine("2) Buscar curso");
            Console.WriteLine("3) Inscribir en curso (por id)");
            Console.WriteLine("4) Ver inscripciones");
            Console.WriteLine("0) Salir");
            Console.Write("Opción: ");
            var opt = Console.ReadLine()?.Trim();

            switch (opt)
            {
                case "1":
                    ListCourses();
                    break;
                case "2":
                    SearchCourses();
                    break;
                case "3":
                    EnrollInCourse(student);
                    break;
                case "4":
                    ShowEnrollments(student);
                    break;
                case "0":
                    Console.WriteLine("Hasta luego.");
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
    // Lista todos los cursos disponibles

    static void ListCourses() {
        Console.WriteLine("\nCursos disponibles:");
        foreach (var c in Courses) Console.WriteLine(c);
    }

    static void SearchCourses() {
        Console.Write("Buscar (texto): ");
        var q = Console.ReadLine() ?? "";
        var results = Courses.Where(c => c.Name.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0);
        Console.WriteLine("\nResultados:");
        foreach (var c in results) Console.WriteLine(c);
    }

    static void EnrollInCourse(Student student)
    {
        Console.Write("ID del curso para inscribirse: ");
        if (!int.TryParse(Console.ReadLine(), out var id))
        {
            Console.WriteLine("ID inválido.");
            return;
        }

        var course = Courses.FirstOrDefault(c => c.Id == id);
        if (course == null)
        {
            Console.WriteLine("Curso no encontrado.");
            return;
        }

        if (student.Enrolled.Any(e => e.Id == course.Id))
        {
            Console.WriteLine("Ya estás inscrito en ese curso.");
            return;
        }

        student.Enrolled.Add(course);
        Console.WriteLine($"Inscripción exitosa en: {course.Name}");
    }
    // Muestra los cursos en los que el estudiante está inscrito

    static void ShowEnrollments(Student student)
    {
        Console.WriteLine($"\nInscripciones de {student.Name}:");
        if (!student.Enrolled.Any())
        {
            Console.WriteLine("No hay inscripciones aún.");
            return;
        }
        foreach (var c in student.Enrolled) Console.WriteLine(c);
    }
    // Fin de la clase EnrollmentApp
}

class Program {
    static void Main()
    {
        EnrollmentApp.Run();
    }
    
    // Fin de la clase Program
}

