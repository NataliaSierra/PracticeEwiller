
using System;
// Integración estructuras condicionales y cíclicas (while if-else) (for if-else)
namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Estructura condicional simple.");
            Console.WriteLine("2: Estructura condicional doble.");
            Console.WriteLine("3: Estructura condicional multiple.");
            Console.WriteLine("4: Estructura condicional anidado.");
            Console.WriteLine("5: Estructura dependiendo De o Segun.");
            Console.WriteLine("6: Estructura ciclica.");
            Console.WriteLine("7: Integración estructuras condicionales y cíclicas (while if-else) (for if-else).");

            int option;
            Console.Write("Ingresa la opcion deseada: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //Condicionales Simples
                    int cantidadB;
                    Console.Write("Ingrese la cantidad en Bodega: ");
                    cantidadB = int.Parse(Console.ReadLine());

                    int minimaR;
                    Console.Write("Ingrese la cantidad minima requerida: ");
                    minimaR = int.Parse(Console.ReadLine());

                    if (cantidadB > minimaR)
                    {
                        Console.WriteLine("No es necesario realizar el pedido al proveedor");
                    }
                    Console.ReadKey();
                break;



                case 2:
                    //Condicionales Dobles

                    int cantidadB1;
                    Console.Write("Ingrese la cantidad en Bodega: ");
                    cantidadB1 = int.Parse(Console.ReadLine());

                    int minimaR1;
                    Console.Write("Ingrese la cantidad minima requerida: ");
                    minimaR1 = int.Parse(Console.ReadLine());

                    if (cantidadB1 > minimaR1)
                    {
                        Console.WriteLine("No es necesario realizar el pedido al proveedor");
                    }
                    else
                    {
                        Console.WriteLine("Es necesario realizar el pedido al proveedor");
                    }

                    break;



                case 3:
                    //Condicionales Multiples

                int cantidadB2;
                Console.Write("Ingrese la cantidad en Bodega: ");
                cantidadB2 = int.Parse(Console.ReadLine());

                int minimaR2;
                Console.Write("Ingrese la cantidad minima requerida: ");
                minimaR2 = int.Parse(Console.ReadLine());

                if (cantidadB2 > minimaR2)
                {
                    Console.WriteLine("No es necesario realizar el pedido al proveedor");

                    int operation2 = (cantidadB2 - minimaR2);
                    Console.WriteLine("Unidades que hacen falta por vender: " + operation2);

                    if (operation2 < 10)
                    {
                        Console.WriteLine("Alerta generada");
                    }
                }
                else
                {
                    Console.WriteLine("Es necesario realizar el pedido al proveedor");
                }
                break;



                case 4:
                    //Condicionales Anidados

                    int cantidadB3;
                    Console.Write("Ingrese la cantidad en Bodega: ");
                    cantidadB3 = int.Parse(Console.ReadLine());

                    int minimaR3;
                    Console.Write("Ingrese la cantidad minima requerida: ");
                    minimaR3 = int.Parse(Console.ReadLine());

                    if (cantidadB3 > minimaR3)
                    {
                        Console.WriteLine("No es necesario realizar el pedido al proveedor");

                        int operation3 = (cantidadB3 - minimaR3);
                        Console.WriteLine("Unidades que hacen falta por vender: " + operation3);

                        if (operation3 < 10)
                        {
                            Console.WriteLine("Alerta generada");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Es necesario realizar el pedido al proveedor");

                        int uComprar3;
                        Console.Write("Unidades de compra deseadas: ");
                        uComprar3 = int.Parse(Console.ReadLine());

                        int vCompra3;
                        Console.Write("Valor de compra del Producto: ");
                        vCompra3 = int.Parse(Console.ReadLine());
                        float dCaja3;
                        Console.Write("Dinero en caja:");
                        dCaja3 = float.Parse(Console.ReadLine());

                        int multip3;
                        multip3 = (vCompra3 * uComprar3);
                        if (multip3 > dCaja3)
                        {
                            Console.WriteLine("NO es porsible realizar el pedido");
                        }
                        else
                        {
                            Console.WriteLine("SI es posible realizar el pedido");
                        }
                    }

                    break;



                case 5:
                    //Estructuras ciclicas

                    int cProductos;
                    Console.Write("Ingrese la cantidad de Productos: ");
                    cProductos = int.Parse(Console.ReadLine());

                    var vTotal = 0;
                    for (int i = 1; i <= cProductos; i++)
                    {
                        int cProduct;
                        Console.Write("Ingrese la cantidad del producto " + i + ": ");
                        cProduct = int.Parse(Console.ReadLine());

                        int vProduct;
                        Console.Write("Ingrese el valor del producto " + i + ": ");
                        vProduct = int.Parse(Console.ReadLine());

                        int calculo;
                        calculo = (vProduct * cProduct);

                        vTotal += calculo;
                    }
                    Console.WriteLine("Total de factura: $" + vTotal);
            
                    break;



                case 6:
                    //Estructura dependiendo de o Según
   
                    int dSemana;
                    Console.Write("Ingrese el dia de la semana (En numero): ");
                    dSemana = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el valor de su compra, sin descuento: ");
                    double vCompra = double.Parse(Console.ReadLine());

                    switch (dSemana)
                    {
                        case 1:
                            double calculo;
                            calculo = (vCompra * 0.05);
                            double dcto;
                            dcto = (vCompra - calculo);
                            Console.WriteLine("Valor a pagar con descuento: $" + dcto);
                            break;

                        case 2:
                            double calculo1;
                            calculo1 = (vCompra * 0.03);
                            double dcto1;
                            dcto1 = (vCompra - calculo1);
                            Console.WriteLine("Valor a pagar con descuento: $" + dcto1);
                            break;

                        case 3:
                            double calculo2;
                            calculo2 = (vCompra * 0.10);
                            double dcto2;
                            dcto2 = (vCompra - calculo2);
                            Console.WriteLine("Valor a pagar con descuento: $" + dcto2);
                            break;

                        case 4:
                            double calculo3;
                            calculo3 = (vCompra * 0.04);
                            double dcto3;
                            dcto3 = (vCompra - calculo3);
                            Console.WriteLine("Valor a pagar con descuento: $" + dcto3);
                            break;

                        case 5:
                            double calculo4;
                            calculo4 = (vCompra * 0.06);
                            double dcto4;
                            dcto4 = (vCompra - calculo4);
                            Console.WriteLine("Valor a pagar con descuento: $" + dcto4);
                            break;

                        case 6:
                            double calculo5;
                            calculo5 = (vCompra * 0.02);
                            double dcto5;
                            dcto5 = (vCompra - calculo5);
                            Console.WriteLine("Valor a pagar con descuento: $" + dcto5);
                            break;

                        case 7:
                            double calculo6;
                            calculo6 = (vCompra * 0.01);
                            double dcto6;
                            dcto6 = (vCompra - calculo6);
                            Console.WriteLine("Valor a pagar con descuento: $" + dcto6);
                            break;
                    }

                    break;



                case 7:
                    // Integración estructuras condicionales y cíclicas (while if-else) (for if-else)
   
                    int cClientes7;

                    Console.Write("Ingrese la cantidad de Clientes: ");
                    cClientes7 = int.Parse(Console.ReadLine());

                    var tVentas7 = 0;
                    for (int y = 1; y <= cClientes7; y++)
                    {
                        int cProductos7;
                        Console.Write("Ingrese la cantidad de Productos del Cliente " + y + ":");
                        cProductos7 = int.Parse(Console.ReadLine());

                        var vTotal7 = 0;
                        for (int i = 1; i <= cProductos7; i++)
                        {

                            int cProduct7;
                            Console.Write("Ingrese la cantidad del producto " + i + ": ");
                            cProduct7 = int.Parse(Console.ReadLine());

                            int vProduct7;
                            Console.Write("Ingrese el valor del producto " + i + ": ");
                            vProduct7 = int.Parse(Console.ReadLine());

                            int calculo7;
                            calculo7 = (vProduct7 * cProduct7);

                            vTotal7 += calculo7;
                            if (vTotal7 > 100000)
                            {
                                double descuento7;
                                descuento7 = (vTotal7 * 0.10);
                                double rFinal7;
                                rFinal7 = (vTotal7 - descuento7);
                                Console.WriteLine("Valor a pagar con descuento: $" + rFinal7);
                            }

                            tVentas7 += calculo7++;
                        }
                        Console.WriteLine("Total de la factura: $" + vTotal7);

                    }
                    Console.WriteLine("Total vendido: $" + tVentas7);
            
                    break;
            }
        }
    }
}

