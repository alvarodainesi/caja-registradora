// ETAPA 1 
const string NombreComercio = "KIOSCO EL RECREO";

Console.WriteLine($"=== {NombreComercio} ===");

Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta.");



// ETAPA 3

decimal total = 0m;
int cantidadProductos = 0;
int opcion;

do
{
    Console.WriteLine();
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Precio del producto: ");
            decimal precioProducto = decimal.Parse(Console.ReadLine());

            total += precioProducto;
            cantidadProductos++;

            Console.WriteLine($"Producto cargado: {nombreProducto} - Precio: ${precioProducto}");
            break;

        case 2:
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}
while (opcion != 2);

Console.WriteLine();
Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"Total de la venta: ${total}");

