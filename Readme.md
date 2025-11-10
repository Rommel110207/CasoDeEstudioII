Aplicación de Inscripción a Cursos — C#
Descripción general

Este proyecto es una aplicación de consola en C# que permite simular el proceso de inscripción de estudiantes en cursos universitarios.
El programa gestiona un catálogo de cursos, permite realizar búsquedas, inscribir estudiantes y mostrar las inscripciones realizadas.

Funcionalidades principales

    Listar cursos disponibles
        Muestra todos los cursos registrados en el sistema con su ID, nombre y área académica.

    Buscar cursos por texto
        Permite ingresar una palabra clave y busca coincidencias dentro del nombre de los cursos (sin importar mayúsculas o minúsculas).

    Inscribirse en un curso
        El estudiante puede inscribirse en un curso existente usando su ID numérico.
        El sistema evita inscripciones duplicadas.

    Ver inscripciones del estudiante
        Muestra una lista de todos los cursos en los que el estudiante actual está inscrito.

    Salir del programa
        Cierra la aplicación de manera ordenada.

Estructura del código
    Clase Course

        Representa un curso con tres propiedades:

        Id: número identificador único.

        Name: nombre del curso.

        Area: área de conocimiento (por ejemplo, “CS” o “Math”).

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

Clase Student

    Representa a un estudiante con:

    Name: nombre del estudiante.

    Enrolled: lista de cursos en los que está inscrito.

    class Student
    {
        public string Name { get; }
        public List<Course> Enrolled { get; } = new List<Course>();

        public Student(string name) => Name = name;
    }

Clase EnrollmentApp

    Contiene la lógica principal de la aplicación:

    Lista de cursos predefinidos.

    Métodos para listar, buscar, inscribir y mostrar cursos.

    Un bucle de menú interactivo que gestiona las opciones del usuario.

    Métodos principales:
        Método                      Descripción

        Run()                       Controla el flujo principal de la aplicación.
        ListCourses()               Muestra todos los cursos disponibles.
        SearchCourses()             Busca cursos por texto ingresado.
        EnrollInCourse(Student)     Permite inscribir al estudiante en un curso según su ID.
        ShowEnrollments(Student)    Muestra los cursos en los que el estudiante está inscrito.
    
Clase Program

    Punto de entrada de la aplicación.
        Llama al método EnrollmentApp.Run() para iniciar la ejecución.

        class Program {
            static void Main()
            {
                EnrollmentApp.Run();
            }
        }

Ejemplo de ejecución

    Aplicación de Inscripción a Cursos
    Nombre del estudiante: Alessandro

    Menú:
        1) Listar cursos
        2) Buscar curso
        3) Inscribir en curso (por id)
        4) Ver inscripciones
        0) Salir
        
        Opción: 1

    Cursos disponibles:
        [1] Algoritmos I - CS
        [2] Introducción a la Programación - CS
        [3] Matemática Discreta - Math
        [4] Bases de Datos - CS
        [5] Cálculo I - Math

    Luego de elegir la opción 3, el usuario puede ingresar el ID del curso y el sistema confirmará la inscripción.

Requisitos

    .NET SDK 6.0 o superior

    Un entorno de desarrollo compatible con C# (Visual Studio, VS Code, Rider, etc.)

Ejecución

    Guarda el código en un archivo llamado Program.cs.

    Abre una terminal en el directorio del proyecto.

    Compila y ejecuta:

    dotnet run

Autor

    Alessandro Torres Parodi
    Jonas Frank Ethelbert Hodgson Cajina
    Alejandro Enrique Zeledón del Cid
    Rommel Alexander Muñoz Guerrero
    Proyecto educativo de consola en C# para practicar listas, clases, métodos y LINQ.