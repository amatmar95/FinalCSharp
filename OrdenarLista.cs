
using static System.Console;

class Ejercicio5{

    public void OrdenarLista(){
        
        List <string> nombres = new List<string>();
        bool seguir = true;

        while (seguir){
            Write("Introduzca un nombre: ");
            string? nombre = ReadLine();
            nombres.Add(nombre);

            Write("¿Quieres introducir otro nombre? (s/n): ");
            string? respuesta = ReadLine();
            if (respuesta.ToLower() == "n")
            {
                seguir = false;
                break;
            }
        }

        nombres.Sort();

        WriteLine("\nLista de nombres ordenada:");
        foreach (string nombre in nombres)
        {
            WriteLine(nombre);
        }



        /*
        string[] nombres = { "Juan", "Maria", "Ana", "Pedro" };

        Array.Sort(nombres);

        WriteLine("Lista ordenada alfabéticamente:");

        foreach (string nombre in nombres)
        {
            WriteLine(nombre);
        }
        */
    }
}