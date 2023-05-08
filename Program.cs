
using static System.Console;
bool seguir = true;
while (seguir){
WriteLine("Seleccione una opcion: ");
WriteLine("1 - Numeros menor y mayor");
WriteLine("2 - Numero par o impar");
WriteLine("3 - Año bisiesto");
WriteLine("4 - Palindromo");
WriteLine("5 - Ordenar lista");
WriteLine("6 - Factorial");
WriteLine("7 - Numero primo");
WriteLine("8 - Calcular area y volumen de cubo");
WriteLine("9 - Suma de numeros pares");
WriteLine("10 - Numero positivo, negativo o \"0\"");
WriteLine("11 - Media de lista de numeros");
WriteLine("12 - Adivinar numero aleatorio");
WriteLine("13 - Anagrama");
WriteLine("14 - Eliminar numeros duplicados de lista");
WriteLine("15 - Capicua");
WriteLine("0 - Salir");
Write ("Introduzca su opcion: ");
int opcion = 0;
    if (int.TryParse(ReadLine(), out opcion)){

        switch(opcion){
            case 0:
                WriteLine("Gracias! Hasta Pronto!");
                //return;
                seguir = false;
                break;
            case 1:
                var miEjercicio1 = new Ejercicio1();
                miEjercicio1.MenorMayor();
                break;
            case 2:
                var miEjercicio2 = new Ejercicio2();
                miEjercicio2.ParImpar();
                break;
            case 3:
                var miEjercicio3 = new Ejercicio3();
                miEjercicio3.AnyoBisiesto();
                break;
            case 4:
                var miEjercicio4 = new Ejercicio4();
                miEjercicio4.Palindromo();
                break;
            case 5:
                var miEjercicio5 = new Ejercicio5();
                miEjercicio5.OrdenarLista();
                break;
            case 6:
                var miEjercicio6 = new Ejercicio6();
                miEjercicio6.Factorial();
                break;
            case 7:
                var miEjercicio7 = new Ejercicio7();
                miEjercicio7.NumeroPrimo();
                break;
            case 8:
                var miEjercicio8 = new Ejercicio8();
                miEjercicio8.AreaVolumenCubo();
                break;
            case 9:
                var miEjercicio9 = new Ejercicio9();
                miEjercicio9.SumaNumerosPares();
                break;
            case 10:
                var miEjercicio10 = new Ejercicio10();
                miEjercicio10.NumeroPositivoNegativoCero();
                break;
            case 11:
                var miEjercicio11 = new Ejercicio11();
                miEjercicio11.MediaLista();
                break;
            case 12:
                var miEjercicio12 = new Ejercicio12();
                miEjercicio12.AdivinarNumero();;
                break;
            case 13:
                var miEjercicio13 = new Ejercicio13();
                miEjercicio13.Anagrama();
                break;
            case 14:
                var miEjercicio14 = new Ejercicio14();
                miEjercicio14.EliminarDuplicados();
                break;
            case 15:
                var miEjercicio15 = new Ejercicio15();
                miEjercicio15.Capicua();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

WriteLine("Pulse una tecla para continuar...");
ReadKey();
Clear();
}