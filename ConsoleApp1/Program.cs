//Programador: Brandy Piedra Mena
//Fecha: 29/05/26
//Versión 1.1
//Venta de entradas Partido Mexico vrs Cost Rica 

// Definición de variables
int numerofactura;
string cedula;
string nombredelcomprador;
int localidad;
int cantidadentradas;

double precioporentrada = 0;
string nombredelocalidad = "";
double subtotal;
double cargosdeservicio;
double totalapagar;

// Variables para estadísticas
int cantidadentradassol = 0;
int cantidadentradassombra = 0;
int cantidadentradaspreferencial = 0;
double totalsol = 0;
double totalsombra = 0;
double totalpreferencial = 0;

string continuar = "s";

// Ciclo para ingresar a realizar varias compras
do
{
    // Lectura de datos
    Console.WriteLine("Ingrese el número de factura: ");
    numerofactura = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el número de Cédula: ");
    cedula = Console.ReadLine();

    Console.WriteLine("Ingrese el nombre del comprador: ");
    nombredelcomprador = Console.ReadLine();

    Console.WriteLine("Indique el numero de localidad: ");
    localidad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Indique la cantidad de entradas:");
    cantidadentradas = Convert.ToInt32(Console.ReadLine());

    // Cantidad de entradas
    if (cantidadentradas < 1 || cantidadentradas > 4)
    {
        Console.WriteLine("La cantidad de entradas debe ser entre 1 y 4");
    }
    else
    {
        // Proceso de localidad
        if (localidad == 1)
        {
            precioporentrada = 10500;
            nombredelocalidad = "Sol Norte/Sur";
        }
        else if (localidad == 2)
        {
            precioporentrada = 20500;
            nombredelocalidad = "Sombra Este/Oeste";
        }
        else if (localidad == 3)
        {
            precioporentrada = 25500;
            nombredelocalidad = "Preferencial";
        }
        else
        {
            Console.WriteLine("Localidad inválida");
        }

        // Cálculos de la venta
        subtotal = cantidadentradas * precioporentrada;
        cargosdeservicio = cantidadentradas * 1000;
        totalapagar = subtotal + cargosdeservicio;

        // Acumuladores para estadísticas
        if (localidad == 1)
        {
            cantidadentradassol = cantidadentradassol + cantidadentradas;
            totalsol = totalsol + subtotal;
        }
        else if (localidad == 2)
        {
            cantidadentradassombra = cantidadentradassombra + cantidadentradas;
            totalsombra = totalsombra + subtotal;
        }
        else if (localidad == 3)
        {
            cantidadentradaspreferencial = cantidadentradaspreferencial + cantidadentradas;
            totalpreferencial = totalpreferencial + subtotal;
        }

        // Mostrar datos de la venta
        Console.WriteLine("Numero de Factura: " + numerofactura);
        Console.WriteLine("Cedula: " + cedula);
        Console.WriteLine("Nombre comprador: " + nombredelcomprador);
        Console.WriteLine("Localidad: " + nombredelocalidad);
        Console.WriteLine("Cantidad de Entradas: " + cantidadentradas);
        Console.WriteLine("Subtotal: " + subtotal);
        Console.WriteLine("Cargos por Servicios: " + cargosdeservicio);
        Console.WriteLine("Total a pagar: " + totalapagar);
    }

    // Pregunta si el cliente desea continuar
    Console.WriteLine("Desea ingresar otra venta? S/N");
    continuar = Console.ReadLine();

} while (continuar == "S" || continuar == "s");

// Mostrar estadísticas finales
Console.WriteLine("Cantidad Entradas Localidad Sol Norte/Sur: " + cantidadentradassol);
Console.WriteLine("Acumulado Dinero Localidad Sol Norte/Sur: " + totalsol);

Console.WriteLine("Cantidad Entradas Localidad Sombra Este/Oeste: " + cantidadentradassombra);
Console.WriteLine("Acumulado Dinero Localidad Sombra Este/Oeste: " + totalsombra);

Console.WriteLine("Cantidad Entradas Localidad Preferencial: " + cantidadentradaspreferencial);
Console.WriteLine("Acumulado Dinero Localidad Preferencial: " + totalpreferencial);