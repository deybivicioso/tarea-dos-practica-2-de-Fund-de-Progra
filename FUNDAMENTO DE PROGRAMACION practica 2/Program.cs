using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTO_DE_PROGRAMACION_practica_2
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            partOne();
            Console.WriteLine("presiones una tecla\n");
            Console.ReadKey();

            partTwo();
            Console.WriteLine("vuelva a presionar una tecla\n");
            Console.ReadKey();

            partThree();
            Console.WriteLine("vuelva a presionar una tecla\n");
            Console.ReadKey();

            partFour();
            Console.WriteLine("presione una tecla\n");
            Console.ReadKey();

            partFive();
            Console.WriteLine("final del programa, presione una tecla para concluir\n");
        }
       static int partOne()
        {
            int numDeDosDigitos = 89;
            int resultado1 = numDeDosDigitos / 10;
            int resultado2=numDeDosDigitos % 10;   
            
            Console.WriteLine($"el numero de dos digitos es {numDeDosDigitos}");

            Console.WriteLine($"\t{resultado1}\n");

            Console.WriteLine($"\t{resultado2}");

            return resultado1;
            
        }
        static int partTwo()
        {
            int numDeDosDigitos = 89;
            int suma = numDeDosDigitos / 10 + numDeDosDigitos % 10;

            Console.WriteLine($"el numero de dos digitos es {numDeDosDigitos}\n");

            Console.WriteLine ($"el resultado de la suma de los dos factores del digito es {suma}\n");

            return suma;
        }
        static int partThree ()
        {
            int numTresDigitos = 475; 
            int resultado1=numTresDigitos / 100;
            int residuo = (numTresDigitos % 100)/10;
            int residuo2 = (numTresDigitos % 100) % 10;

            Console.WriteLine($"el numero de tres digitos es:{numTresDigitos}\n");

            int suma = (resultado1 + residuo + residuo2);

            Console.WriteLine($"la suma de los tres digitos de 475 es: {suma}\n");

            return suma;
        }
        static int partFour()
        {
            int numCuatroDigitos = 4275;
            int resultado1 = numCuatroDigitos / 1000;
            int resultado2 = (numCuatroDigitos %1000) /100;
            int resultado3 = (numCuatroDigitos % 100) / 10;
            int resultado4 = (numCuatroDigitos % 100) % 10;

            Console.WriteLine($"el numero de cuatro digiots es:{numCuatroDigitos} \n");

            Console.WriteLine($"el primer digito es {resultado1}\n");

            Console.WriteLine($"el segund0o digito es {resultado2}\n");

            Console.WriteLine($"el tercer digito es {resultado3}\n");

            Console.WriteLine($"el cuarto digito es {resultado4}\n");

            return numCuatroDigitos;          
        }
        static int partFive ()
        {
            int niño1 = 9;
            int niño2 = 12;
            int niño3 = 15;
            int suma = (niño1 + niño2 + niño3);
            int promedio = (niño1 + niño2 + niño3) / 3;
            int edadMaxima = 15;
            int edadMinima = 9;

            Console.WriteLine($"la edad de juan es de {niño1}\n");

            Console.WriteLine($"la edad de sirvia es de {niño2}\n");

            Console.WriteLine($"la edad de galante es de {niño3}\n");

            Console.WriteLine($"la suma de las edades es: {suma}\n");

            Console.WriteLine($"el promedio de las edades es: {promedio}\n");

            Console.WriteLine($"la edad maxima es: {edadMaxima}\n");

            Console.WriteLine($"la edad minima es: {edadMinima}\n");

            return suma;
        }



    }
}
