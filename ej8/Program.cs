using System;

// Ej 8
//
// Una compañía de videojuegos te ha contratado para escribir el programa de un videojuego
// nuevo.
// Deberás crear la parte del programa que calcula el número total de puntos que un
// jugador gana en el juego Galaxy.
// Los jugadores acumulan puntos mediante la recolección de objetos.
// Los objetos tienen asignados los siguientes puntos:
// Estrella = 10 puntos.
// Planeta = 20 puntos.
// Asteroide = 50 puntos.
// Cometa = 100 puntos.
// Si un jugador acumula más de 5.000 puntos, en una misma jugada, ganará un bono de
// 500 puntos.
// Implementa pues una jugada, donde le pidamos al usuario el nombre de un objeto y el
// número de estos que ha recogido. Mostrando el total de puntos teniendo en cuenta los bonos.
// Nota: Usar un switch para decidir los puntos del objeto.

namespace ej8
{
    class Program
    {
        static void Main(string[] args)
        {
            char tipoObjeto;
            short numeroObjetos;
            short puntosObjeto;
            int puntuacionFinal=0;

            Console.Write("Tipo de objeto recogido: Estrella (E) / Planeta (P) / Asteroide (A) / Cometa (C): ");
            tipoObjeto = char.Parse(Console.ReadLine());
            tipoObjeto = Char.ToUpper(tipoObjeto);
            Console.Write($"Cantidad recogida: ");
            numeroObjetos = short.Parse(Console.ReadLine());

            switch(tipoObjeto)
            {
                case 'E':
                puntosObjeto=10;
                break;
                case 'P':
                puntosObjeto=20;
                break;
                case 'A':
                puntosObjeto=50;
                break;
                case 'C':
                puntosObjeto=100;
                break;                                
                default:
                puntosObjeto=0;
                break;
            }

            puntuacionFinal=puntosObjeto*numeroObjetos;

            string texto;
            if (puntuacionFinal <= 5000)
			{
                texto=$"Has conseguido un total de {puntuacionFinal} puntos";
			}
            else if (puntuacionFinal > 5000)
			{
               int bonoFinal=puntuacionFinal+500;
			   texto=$"¡Felicidades! Has conseguido un total de {puntuacionFinal} puntos, por lo que al sumar más de 5000 puntos, tienes un bono de 500 puntos. Tu puntuación final es de {bonoFinal} puntos";
			}
		     else texto=$"No has conseguido ningún punto";

            Console.WriteLine(texto);
        }
    }
}
