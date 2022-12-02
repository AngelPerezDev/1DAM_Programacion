using System;

// Ej 7
//
// Gestión de un hotel
// Se pedirá el número de noches y si quieren habitación individual ( 'I' ) o habitación
// doble ( 'D' ).
// Si el número de noches es mayor de 2 y la habitación es individual cobraremos 25€ pero
// si la habitación es doble cobraremos 40€.
// Si el número de noches es menor o igual a 2 y la habitación individual cobraremos**
// 27€**, pero si la habitación es doble cobraremos 44€.
// Nota: Realiza el ejercicio con switch - when

namespace ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            char tipoHabitacion;
            short numeroNoches;
            int costeAlojamiento=0;

            Console.Write("Tipo de habitación. Individual (I) o doble (D): ");
            tipoHabitacion = char.Parse(Console.ReadLine());
            tipoHabitacion = Char.ToUpper(tipoHabitacion);
            Console.Write("Número de noches: ");
            numeroNoches = short.Parse(Console.ReadLine());

            switch (tipoHabitacion)
            {
                case 'I' when numeroNoches<=2:
                    costeAlojamiento = numeroNoches*27;
                    break;

                case 'D' when numeroNoches<=2:
                    costeAlojamiento = numeroNoches*44;
                    break;

                case 'I' when numeroNoches>2:
                    costeAlojamiento = numeroNoches*25;
                    break;
            
                case 'D' when numeroNoches>2:
                    costeAlojamiento = numeroNoches*40;
                    break;

                default:
                    costeAlojamiento = 0;
                    break;
            }

            Console.Write($"El coste de alojamiento es de {costeAlojamiento} euros");

        }
    }
}
