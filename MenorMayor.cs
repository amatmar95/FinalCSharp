using static System.Console;

class Ejercicio1{

    public void MenorMayor(){

    bool seguir = true;
    int mayor = 0;
    int menor = 999999999;
    while (seguir){
        int numero = 0;
        Write("Introduce un número entero positivo o \"0\" para salir: ");
        if (!int.TryParse(ReadLine(), out numero))
        {
            WriteLine("Número invalido");
            return;
        }

        if (numero > mayor){
            mayor = numero;
        }
        
        if (numero < menor && numero > 0){
            menor = numero;
        }

        if (numero == 0){
            seguir = false;
            break;
        }

    }

        WriteLine("El mayor número es: " + mayor);
        WriteLine("El menor número es: " + menor);
        //ReadLine();

        /*
        int[] numeros = { 5, 3, 8, 1, 7, 2 };
        int mayor = numeros[0];
        int menor = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }
            if (numero < menor)
            {
                menor = numero;
            }
        }

        WriteLine("El mayor número es: " + mayor);
        WriteLine("El menor número es: " + menor);
        ReadLine();
        */


    }
}