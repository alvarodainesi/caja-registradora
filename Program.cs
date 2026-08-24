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

// ETAPA 4

const decimal DescuentoDiezPorCiento = 0.10m;
const decimal DescuentoCincoPorCiento = 0.05m;

decimal porcentajeDescuento = 0m;

if (total > 50000m)
{
    porcentajeDescuento = DescuentoDiezPorCiento;
}
else if (total > 20000m)
{
    porcentajeDescuento = DescuentoCincoPorCiento;
}

decimal descuentoAplicado = total * porcentajeDescuento;
decimal totalConDescuento = total - descuentoAplicado;



// ETAPA 5

const decimal DescuentoEfectivo = 0.10m;
const decimal RecargoCredito = 0.15m;

decimal totalFinal = totalConDescuento;
decimal descuentoMedioPago = 0m;
decimal recargoAplicado = 0m;
int opcionPago;


do
{
    Console.WriteLine();
    Console.WriteLine("Medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito");
    Console.Write("Opción: ");
    opcionPago = int.Parse(Console.ReadLine());

    switch (opcionPago)
    {
        case 1:
            descuentoMedioPago = totalFinal * DescuentoEfectivo;
            totalFinal -= descuentoMedioPago;
            
            break;

        case 2:
            
            break;

        case 3:
            recargoAplicado = totalFinal * RecargoCredito;
            totalFinal += recargoAplicado;
            
            break;

        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
}
while (opcionPago != 1 && opcionPago != 2 && opcionPago != 3);

// ETAPA 6

decimal descuentoTotal = descuentoAplicado + descuentoMedioPago;

string lineaTicket = "";

for (int i = 0; i < 35; i++)
{
    lineaTicket += "-";
}

Console.WriteLine();
Console.WriteLine($"{lineaTicket}");
Console.WriteLine($"         {NombreComercio}");
Console.WriteLine($"{lineaTicket}");
Console.WriteLine($"Cajero: {nombreCajero}");
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {total}");
Console.WriteLine($"Descuento: {descuentoTotal}");
Console.WriteLine($"Recargo: {recargoAplicado}");
Console.WriteLine($"{lineaTicket}");
Console.WriteLine($"TOTAL: {totalFinal}");
Console.WriteLine($"{lineaTicket}");