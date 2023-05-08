
using static System.Console;

class Ejercicio14{

    public void EliminarDuplicados(){
        List<int> numeros = new List<int>();
        List<int> numerosSinDuplicados = new List<int>();
        bool seguir = true;

        while(seguir){
            int numero = 0;
            
            Write("Introduce un número entero positivo o \"0\" para salir: ");
                if (!int.TryParse(ReadLine(), out numero))
                {
                    WriteLine("Número invalido");
                    return;
                }
            if(numero != 0){
            numeros.Add(numero);
            }

            if(numero == 0){
                seguir=false;
                break;
            }
        }
        
        foreach (int numero in numeros)
        {
            if (!numerosSinDuplicados.Contains(numero))
            {
                numerosSinDuplicados.Add(numero);
            }
        }


        WriteLine();
        WriteLine("Números originales: " + string.Join(", ", numeros));
        WriteLine("Lista sin duplicados: " + string.Join(", ", numerosSinDuplicados));

}
}