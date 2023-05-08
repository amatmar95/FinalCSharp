
using static System.Console;


class Ejercicio9{

    public void SumaNumerosPares(){
        
        List<int> numeros = new List<int>();
        bool seguir = true;
        int suma = 0;

        while (seguir){
            int numero = 0;
            Write("Introduce un número entero positivo o \"0\" para salir: ");
                if (!int.TryParse(ReadLine(), out numero))
                {
                    WriteLine("Número invalido");
                    return;
                }
                
            if (numero%2 == 0 && numero != 0){
                numeros.Add(numero);
                suma += numero;
            }
            
            if (numero == 0){
                seguir = false;
                break;
            }

        }

        WriteLine("La lista de numeros pares es la siguiente: ");
        foreach (int numero in numeros){
            WriteLine(numero);
        }
        WriteLine("La suma total de los numeros pares es " + suma);





        /*List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int suma = 0;

        foreach (int num in numeros)
        {
            if (num % 2 == 0)
                suma += num;
        }

        WriteLine("La suma de los números pares es {0}", suma);

        //ReadKey();

        */
    }
}