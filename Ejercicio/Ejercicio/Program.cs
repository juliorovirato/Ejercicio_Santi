using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables globales.
            int[,] mat = new int[2, 4];
            string Resultado = "Continue", resp1, resp2, resp3;
            //Inicializamos los valores dentro de la matriz.
            mat[0, 0] = 1; //Gallina
            mat[0, 1] = 2; //Maiz
            mat[0, 2] = 3; //Lobo
            mat[0, 3] = 4; //Granjero
            mat[1, 0] = 0; //Gallina
            mat[1, 1] = 0; //Maiz
            mat[1, 2] = 0; //Lobo
            mat[1, 3] = 0; //Granjero
            //Dar bienvenida, dar las reglas del juego y algo más.
            Console.WriteLine("Bienvenido al juego del granjero.");
            Console.WriteLine("");
            Console.WriteLine("El juego consiste en suponer que eres un granjero,");
            Console.WriteLine("tienes dos animales y un objeto al lado izquierdo de un lago,");
            Console.WriteLine("los cuales debes llevar al lado derecho del lago un objeto a la vez en 7 movimientos.");
            Console.WriteLine("");
            Console.WriteLine("Reglas");
            Console.WriteLine("* Solo puede llevar un objeto a la vez.");
            Console.WriteLine("* El lobo no puede estar solo con la gallina ya que este se la come.");
            Console.WriteLine("* La gallina no puede estar sola con el maíz ya que esta se come el maíz.");
            Console.WriteLine("");
            Console.WriteLine("El juego solo te dira si ganas o pierdes,");
            Console.WriteLine("en caso de que te siga pidiendo movimientos es porque el juego continua,");
            Console.WriteLine("mucha suerte, utiliza tu lógica.");
            Console.WriteLine("");
            //Ordenes del juego
            while (Resultado == "Continue")
            {
                //Pedir que objeto desea mover.
                Console.WriteLine("Elija el número correspondiente al objeto que desea llevar al otro lado del lago.");
                Console.WriteLine("1- Gallina.");
                Console.WriteLine("2- Maíz.");
                Console.WriteLine("3- Lobo.");
                Console.WriteLine("4- Vacío.");
                Console.WriteLine("");
                resp1 = Console.ReadLine();
                Console.WriteLine("");
                //Pedir a que lado desea mover el objeto.
                Console.WriteLine("Elija el número correspondiente al lado donde lo desea trasladar.");
                Console.WriteLine("1- Derecha.");
                Console.WriteLine("2- Izquierda.");
                Console.WriteLine("");
                resp2 = Console.ReadLine();
                Console.WriteLine("");
                //Condiciones del movimiento.
                //Movimiento de la gallina.
                if (resp1 == "1" && resp2 == "1")
                {
                    if (mat[1, 0] == 0)
                    {
                        mat[1, 0] = 1;
                        mat[0, 0] = 0;
                        mat[1, 3] = 4;
                        mat[0, 3] = 0;
                    }
                    else
                    {
                        Console.WriteLine("La gallina ya se encuentra en este lado.");
                        Console.WriteLine("");
                    }
                }
                if (resp1 == "1" && resp2 == "2")
                {
                    if (mat[0, 0] == 0)
                    {
                        mat[0, 0] = 1;
                        mat[1, 0] = 0;
                        mat[1, 3] = 0;
                        mat[0, 3] = 4;
                    }
                    else
                    {
                        Console.WriteLine("La gallina ya se encuentra en este lado.");
                        Console.WriteLine("");
                    }
                }
                //Movimientos del maiz.
                if (resp1 == "2" && resp2 == "1")
                {
                    if (mat[1, 1] == 0)
                    {
                        mat[1, 1] = 2;
                        mat[0, 1] = 0;
                        mat[1, 3] = 4;
                        mat[0, 3] = 0;
                    }
                    else
                    {
                        Console.WriteLine("El maíz ya se encuentra en este lado.");
                        Console.WriteLine("");
                    }
                }
                if (resp1 == "2" && resp2 == "2")
                {
                    if (mat[0, 1] == 0)
                    {
                        mat[0, 1] = 2;
                        mat[1, 1] = 0;
                        mat[1, 3] = 0;
                        mat[0, 3] = 4;
                    }
                    else
                    {
                        Console.WriteLine("El maíz ya se encuentra en este lado.");
                        Console.WriteLine("");
                    }
                }
                //Movimientos del lobo.
                if (resp1 == "3" && resp2 == "1")
                {
                    if (mat[1, 2] == 0)
                    {
                        mat[1, 2] = 3;
                        mat[0, 2] = 0;
                        mat[1, 3] = 4;
                        mat[0, 3] = 0;
                    }
                    else
                    {
                        Console.WriteLine("El lobo ya se encuentra en este lado.");
                        Console.WriteLine("");
                    }
                }
                if (resp1 == "3" && resp2 == "2")
                {
                    if (mat[0, 2] == 0)
                    {
                        mat[0, 2] = 3;
                        mat[1, 2] = 0;
                        mat[1, 3] = 0;
                        mat[0, 3] = 4;
                    }
                    else
                    {
                        Console.WriteLine("El lobo ya se encuentra en este lado.");
                        Console.WriteLine("");
                    }
                }
                //Movimientos granjero Vacío.
                if (resp1 == "4" && resp2 == "1")
                {
                    if (mat[1, 3] == 0)
                    {
                        mat[1, 3] = 4;
                        mat[0, 3] = 0;
                    }
                    else
                    {
                        Console.WriteLine("Granjero ya se encuentra en este lado.");
                        Console.WriteLine("");
                    }
                }
                if (resp1 == "4" && resp2 == "2")
                {
                    if (mat[0, 3] == 0)
                    {
                        mat[1, 3] = 0;
                        mat[0, 3] = 4;
                    }
                    else
                    {
                        Console.WriteLine("El granjero ya se encuentra en este lado.");
                        Console.WriteLine("");
                    }
                }
                //Revisa el estado del juego con las condiciones dadas al jugador
                if ((mat[0, 0] == 1 && mat[0, 1] == 2 && mat[0, 2] == 0 && mat[0, 3] == 0) || (mat[0, 0] == 1 && mat[0, 1] == 0 && mat[0, 2] == 3 && mat[0, 3] == 0) || (mat[1, 0] == 1 && mat[1, 1] == 2 && mat[1, 2] == 0 && mat[1, 3] == 0) || (mat[1, 0] == 1 && mat[1, 1] == 0 && mat[1, 2] == 3 && mat[1, 3] == 0))
                {
                    Resultado = "Perdio";
                }
                else
                {
                    if ((mat[1, 0] == 1 && mat[1, 1] == 2 && mat[1, 2] == 3))
                    {
                        Resultado = "Gano";
                    }
                    else
                    {
                        Resultado = "Continue";
                    }
                }
            }
            //Imprimir el resultado del juego.
            Console.WriteLine(Resultado);
            Console.ReadKey();
        }
    }
}
