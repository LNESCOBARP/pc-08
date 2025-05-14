class Program
{
   public static string[] nombres = new string[10];
    public static int[] notas = new int[10];

    public static void Menu()
    {
        int opcion;
        do
        {
        Console.WriteLine("En el siguiente menu, seleccione que desea ver ");
        Console.WriteLine("1. nombre y notas aprobadas");
        Console.WriteLine("2. nombre y notas no aprobadas");
        Console.WriteLine("3. El promedio de notas del grupo");
        Console.WriteLine("4. Salir");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Seleccione un numero del 1 al 4");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Aprobados();
                    break;
                case 2:
                    Reprobados();
                    break;
                case 3:
                    PromedioGrupo();
                    break;
                case 4:
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Seleccione un número del 1 al 4");
                    break;
            }
            Console.WriteLine("\n");
        } while (opcion != 4);
    }    
    public static void Nombre()
    {
        Console.WriteLine("Ingrese los nombres de los estudiantes");
        for (int n = 0; n < nombres.Length; n++)
        {
            Console.WriteLine($"Ingrese el {n + 1} nombre de los estudiantes");
            nombres[n] = Console.ReadLine();
        }
        Console.WriteLine();
    }
    public static void Notas()
    {
        for (int i = 0; i < 10; i++)
        {
            int nota;
            while (true)
            {
                Console.Write($"Ingrese la nota para {nombres[i]}: ");
                if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 100)
                {
                    notas[i] = nota;
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese un número entre 0 y 100");
                }
             }
        }
        Console.WriteLine("\n");
    }
    public static void Aprobados()
    {
        Console.WriteLine("Los estudiantes aporbados son: ");
        for (int i = 0; i < 10; i++)
        {
            if (notas[i] >= 65)
                Console.WriteLine($"{nombres[i]}: {notas[i]}");
        }
        Console.WriteLine("\n");
    } 
    public static void Reprobados()
    {
        Console.WriteLine("Los estudiantes reprobados son: ");
        for (int i = 0; i < 10; i++)
        {
            if (notas[i] < 65)
            Console.WriteLine($"{nombres[i]}: {notas[i]}");
        }
        Console.WriteLine("\n");
    } 
    public static void PromedioGrupo()
    {
        int suma = 0;

        for (int i = 0; i < 10; i++)
        {
            suma += notas[i];
        }

        double promedio = (double)suma / 10;
        Console.WriteLine($"El promedio del grupo es de: {promedio}");
    }
    static void Main(string[] args)
    {
        Nombre();
        Notas();
        Menu();
    }
}