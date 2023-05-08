
using static System.Console;


class Ejercicio11{

    public void MediaLista(){
        
        List<int> numeros = new List<int>();
        bool seguir = true;
        decimal media;
        int cantidad = 0;
        int suma = 0;

        while (seguir){
            int numero = 0;
            
            Write("Introduce un número entero positivo o \"0\" para salir: ");
                if (!int.TryParse(ReadLine(), out numero))
                {
                    WriteLine("Número invalido");
                    return;
                }
        
            if (numero != 0){
            numeros.Add(numero);
            }

            if(numero == 0){
                seguir=false;
                break;
            }

        }


        WriteLine("La lista  de numeros es la siguiente: ");
        foreach(int numero in numeros){
            suma += numero;
            cantidad++;
            WriteLine(numero);
        }

        media = (decimal)suma/cantidad;

        WriteLine("La media de la lista es " + media);



        /*
        int[] numeros = { 10, 20, 30, 40, 50 };
        double media = numeros.Average();
        WriteLine("La media es: " + media);
        */
    
}
}