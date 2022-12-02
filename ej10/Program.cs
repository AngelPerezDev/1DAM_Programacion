using System;

// Ej 10
//
// Modifica el programa anterior de forma que ahora además, se deba tener en cuenta la nota de
// prácticas para realizar la média, siendo ambas exactas.
// El resultado será una nota numérica que puede tener decimales, además tanto en las
// prácticas como en los exámenes solo se podrán evaluar con tres notas (4, 7, 10).
// Con todo esto y las siguientes valoraciones, calcula la nota numérica final:
// Si la nota del examen es 4, la nota será la misma que la del examen independientemente
// de la de las prácticas.
// Si la nota del examen es 7 y la de prácticas es mayor o igual a 7 la nota será la media
// entre ambas
// Si la nota del examen es 7 y la de prácticas es 4 la nota final será 5
// Si la nota del examen es 10 y la de prácticas menor o igual a 7 la nota final será 9
// Si la nota del examen es 10 y la de prácticas es 10, la nota final será 11
// Se indicará nota incorrecta en caso de introducir una nota no permitida y podemos usar una
// ternaria y la variable notaFinal nullable.
// Nota: Para hacer este ejercicio deberás usar la expresión switch de C#8 con tuplas.

namespace ej10
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaExamen;
            int notaPracticas;
            string notaFinal;

            Console.Write("Introduce la nota que has sacado en el examen sin decimales:");
            notaExamen = int.Parse(Console.ReadLine());
            Console.Write("Introduce la nota que has sacado en prácticas sin decimales:");
            notaPracticas = int.Parse(Console.ReadLine());            

            notaFinal = notaExamen <= notaPracticas
            ? "4"
            : (notaExamen, notaPracticas) switch
                {
                    (7, 4) => "5",
                    (7, 7) => "7",
                    (7, 10) => "8'5",
                    (10, 4) => "9",
                    (10, 7) => "9",
                    (10, 10) => "11",                                                                                
                    (_, _) => "NOTA INCORRECTA",
                };

            Console.WriteLine("Tu nota final es un " + notaFinal);
        }
    }
}
