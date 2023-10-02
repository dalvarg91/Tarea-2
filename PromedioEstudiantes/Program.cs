using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioEstudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float[] quiz = new float[3];
            float[] tarea = new float[3];
            float[] examen = new float[3];
            int carnet = 0;
            string nombre = "";
            float suma = 0;
            float suma1 = 0;
            float suma2 = 0;
            float promedio = 0;
            float promediofinal = 0;
            float porcentaje = 0;
            float porcentaje1 = 0;
            float porcentaje2 = 0;

            Console.WriteLine("Digite su numero de carnet ");
            carnet = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre ");
            nombre = Console.ReadLine();

            //---------PROMEDIO DE QUICES---------------------------

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese la nota del quiz {i + 1}");
                quiz[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < quiz.Length; i++)
            {
                suma += quiz[i];
            }
            promedio = suma / 3;
            porcentaje = promedio * 25 / 100;

            //---------PROMEDIO DE TAREAS----------------------------

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine($"Ingrese la nota de la tarea {x + 1}");
                tarea[x] = float.Parse(Console.ReadLine());
            }
            for (int x = 0; x < tarea.Length; x++)
            {
                suma1 += tarea[x];
            }
            promedio = suma1 / 3;
            porcentaje1 = promedio * 30 / 100;

            //---------PROMEDIO DE EXAMENES-------------------------

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Ingrese la nota del examen {j + 1}");
                examen[j] = float.Parse(Console.ReadLine());
            }
            for (int j = 0; j < examen.Length; j++)
            {
                suma2 += examen[j];
            }
            promedio = suma2 / 3;
            porcentaje2 = promedio * 45 / 100;

            //----------PROMEDIO FINAL----------------------------
            promediofinal = porcentaje + porcentaje1 + porcentaje2;

            Console.WriteLine($"Nombre:{nombre} \nN° de identificacion:{carnet} \nPorcentaje obtenido de quices: {porcentaje}% \nPorcentaje obtenido de tareas: {porcentaje1}%  \nPorcentaje obtenido de examenes: {porcentaje2}% \nPromedio Final: {promediofinal}");
            if (promediofinal >= 70)
            {
                Console.WriteLine("Condicion: ¡Aprobado!");
            }
            else if (promediofinal >= 50 && promediofinal < 70)
            {
                Console.WriteLine("Condicion: ¡Aplazado!");
            }
            else
            {
                Console.WriteLine("Condicion: ¡Reprobado!");
            }

            Console.Read();
        }
    }
}
