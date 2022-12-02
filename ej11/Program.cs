using System;

// Ej 11
//
// Una empresa factura a sus clientes el último día de cada mes.
// Si el cliente paga del 1 al 10 del mes siguiente se le hace un descuento de 50 centimos o
// del 10%, el que sea mayor.
// Si paga entre los días 11 y 20 no se le aplica ningún descuento.
// Si paga después del día 20 se le penaliza con 1 euro o el 5%, lo que sea mayor.
// Se desea un programa que lea los datos del cliente: nombre, dirección, CIF y el importe de
// la factura. Tras ello, confeccione una carta dirigida al cliente informándole que tiene una
// factura pendiente de ...€ y lo que deberá pagar según realice el pago del 1 al 10, del 11 al 20
// o después del 20.

namespace ej11
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombreCliente;
            string direccionCliente;
            string cifCliente;
            double importeFactura;
            double pagoAntesDia10;
            double pagoDespuesDia20;            

            Console.Write("Introduce nombre de cliente:");
            string entradaNombreCliente = Console.ReadLine();
            nombreCliente = entradaNombreCliente.ToUpper ();
            Console.Write("Introduce la dirección del cliente:");
            string entradaDireccionCliente = Console.ReadLine();
            direccionCliente = entradaDireccionCliente.ToUpper ();
            Console.Write("Introduce el CIF del cliente:");
            string entradaCifCliente = Console.ReadLine();            
            cifCliente = entradaCifCliente.ToUpper ();
            Console.Write("Introduce el importe de la factura:");
            importeFactura = double.Parse(Console.ReadLine()); 

            
            if (importeFactura >= 5)
			{
                pagoAntesDia10 = importeFactura * 0.9;
			}
		    else pagoAntesDia10 = importeFactura - 0.50;

            if (importeFactura >= 20)
			{
                pagoDespuesDia20 = importeFactura * 1.05;
			}
		    else pagoDespuesDia20 = importeFactura + 1;

            Console.WriteLine ($"Buenos días. Le comunicamos que hemos emitido una factura por importe de {importeFactura} euros a nombre de su empresa {nombreCliente} sita en {direccionCliente} con CIF {cifCliente}.");
            Console.WriteLine ($"Si realiza el pago antes del día 10 del próximo mes, le bonificamos con un descuento y el importe de la factura sería de {pagoAntesDia10} euros. Por el contrario, si lo realiza entre el día 11 y 20, perdería dicha bonificación siendo por tanto el importe a abonar el inicial de {importeFactura} euros, siendo penalizado en su factura si el pago lo hace pasado el día 20 que entonces sería de {pagoDespuesDia20} euros.");
            Console.WriteLine ("Sin otro asunto, reciba un cordial saludo.");
            Console.WriteLine ("Ángel Pérez");

        }
    }
}
