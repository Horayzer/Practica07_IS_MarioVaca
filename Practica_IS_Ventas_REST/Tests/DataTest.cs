using DataAccess;
using Data;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class DataTest
    {
        static void Main(string[] args) 
        {

            // Probar la capa de Datos (Data)
            Console.WriteLine("Probando la capa de Datos (Data):");

            Console.WriteLine("0) Clientes \n1) Categorias \n2) DetalleFacturas \n3) Facturas \n4) Productos \n5) ObtenerDetalleFactura");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                switch (num)
                {
                    case 0: //Listar
                        DataCliente dataCli = new DataCliente();
                        List<Clientes> listaClientes = dataCli.Listar();
                        foreach (var cliente in listaClientes)
                        {
                            Console.WriteLine($"ID: {cliente.id}, Nombre: {cliente.nombre}, Cédula: {cliente.cedula}");
                        }
                        Console.WriteLine();

                        Console.ReadKey();
                        break;
                    case 1: //Listar by id
                        DataCategoria dataCat = new DataCategoria();
                        Categorias cat = dataCat.ByID(1);

                        Console.WriteLine($"ID: {cat.id}, Nombre: {cat.nombre}");

                        Console.WriteLine();

                        Console.ReadKey();
                        break;
                    case 2: 
                        break;
                    case 3:
                        break;
                    case 4: //Añadir
                        DataProducto dataPro = new DataProducto();
                        List<Productos> listPro = dataPro.Listar();
                        foreach (var pro in listPro)
                        {
                            Console.WriteLine($"ID: {pro.id}, Nombre: {pro.nombre}, Cédula: {pro.precio_unitario}");
                        }
                        Console.WriteLine();

                        Console.ReadKey();
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            }

            // Probar la capa de Datos (Data)
            Console.WriteLine("Probando la capa de logica (Logic):");

            Console.WriteLine("0) Clientes \n1) Categorias \n2) DetalleFacturas \n3) Facturas \n4) Productos \n5) ObtenerDetalleFactura");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                switch (num)
                {
                    case 0: //Listar
                        LogicCliente logicCli = new LogicCliente();
                        List<Clientes> listaClientesLogic = logicCli.ListarClientes();

                        foreach (var item in listaClientesLogic)
                        {
                            Console.WriteLine($"ID: {item.id}, Nombre: {item.nombre}, Cedula: {item.cedula}");
                        }
                        Console.WriteLine();

                        Console.ReadKey();
                        break;
                    case 1: //ByID
                        LogicCategoria logiCat = new LogicCategoria();
                        Categorias cat = logiCat.ListarByID(2);
                        Console.WriteLine($"ID: {cat.id}, Nombre: {cat.nombre}");
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        LogicProducto logicPro = new LogicProducto();
                        List<Productos> listaProductosLogic = logicPro.ListarProductos(); //Listar

                        //Listar Productos
                        foreach (var item in listaProductosLogic)
                        {
                            Console.WriteLine($"ID: {item.id}, Nombre: {item.nombre}, PrecioUnitario: {item.precio_unitario}");
                        }
                        Console.WriteLine();

                        Console.ReadKey();
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
