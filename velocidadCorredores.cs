using System;

class VelocidadCorredores{
    static void Main(){
        Console.WriteLine("Ingrese el tiempo de cada corredor en formato (minutos, segundos). Ingrese (0,0) para finalizar el codigo: \n");
        while (true){
            Console.Write("Ingrese los minutos: ");
            int minutos;
            //while donde determina si el numero ingresado es entero o no
            while (!int.TryParse(Console.ReadLine(), out minutos) || minutos < 0)
            {
                Console.Write("Ingrese un numero entero: ");
            }
            Console.Write("Ingrese los segundos: ");
            int segundos;
            //while donde determina si el numero ingresado es entero o no
            while (!int.TryParse(Console.ReadLine(), out segundos) || segundos < 0 || segundos >= 60){
                Console.Write("Ingrese un numero entre el 0 y el 59: ");
            }
            //Condicional para finalizar el programa
            if (minutos == 0 && segundos == 0){
                Console.WriteLine("\nFin de la entrada de datos.");
                break;
            }
            int tiempoTotalSegundos = (minutos * 60) + segundos;
            double velocidad = 1500.0 / tiempoTotalSegundos;
            Console.WriteLine($"Tiempo del corredor: {minutos} minutos y {segundos} segundos.");
            Console.WriteLine($"Velocidad: {velocidad:F2} m/s\n");
        }
    }
}
