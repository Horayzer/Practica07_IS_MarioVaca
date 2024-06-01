// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 07

using Datos.DTO;
using Datos.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Logica
{
    public class MiddlewareProductos
    {
        // Referencia a los servicios SOAP de cada base de datos
        ServiceSoapPractica.WebServiceVentas webTiendaMil = new ServiceSoapPractica.WebServiceVentas();
        ServiceSoapVentas.ServiceSoapVentas2Producto webSuperX = new ServiceSoapVentas.ServiceSoapVentas2Producto();
        // Listado de la base de datos servicios
        public List<ServiceSoapPractica.Productos> ListaTiendaMil()
        {
            return webTiendaMil.ListarProductos().ToList();
        }
        //Listado de la base de datos VentasBD
        public List<ServiceSoapVentas.Producto> ListarSuperX()
        {
            return webSuperX.ListarProductos().ToList();
        }
        //Integramos los datos de cada una de las listas
        public List<DTOProductos> ListaProductosSOAP()
        {
            List<DTOProductos> lista = new List<DTOProductos>();
            foreach (var item in ListaTiendaMil())
            {
                DTOProductos datoProducto = new DTOProductos();
                datoProducto.Id = item.id;
                datoProducto.Name = item.nombre;
                datoProducto.Price = (double)item.precio_unitario;
                datoProducto.Iva = item.iva;
                datoProducto.Tienda = "Tienda Mil";
                lista.Add(datoProducto);
            }
            foreach (var item in ListarSuperX())
            {
                DTOProductos datoProducto = new DTOProductos();
                datoProducto.Id = item.idProducto;
                datoProducto.Name = item.name;
                datoProducto.Price = (double)item.pvp;
                if (item.impuesto == "1")
                {
                    datoProducto.Iva = 1;
                }
                else
                {
                    datoProducto.Iva = 0;
                }
                datoProducto.Tienda = "SuperX";
                lista.Add(datoProducto);
            }
            return lista;
        }
        // Listado de productos de la base de datos ventas REST
        public List<ProductosSuperX> ListarProductosSuperX()
        {
            string url = "http://localhost:57487/api/Producto"; //Venta
            WebClient respuesta = new WebClient();
            string get = respuesta.DownloadString(new Uri(url));
            List<ProductosSuperX> listaSuperX = JsonConvert.DeserializeObject<List<ProductosSuperX>>(get);
            return listaSuperX;
        }
        // Listado de productos de la base de datos servicios REST
        public List<ProductosTiendaMil> ListarProductosTiendaMil()
        {
            string url = "http://localhost:50438/api/Productos"; //Practica
            WebClient respuesta = new WebClient();
            string get = respuesta.DownloadString(new Uri(url));
            List<ProductosTiendaMil> listaTiendaMil = JsonConvert.DeserializeObject<List<ProductosTiendaMil>>(get);
            return listaTiendaMil;
        }
        public List<DTOProductos> ListaProductosREST()
        {
            List<DTOProductos> listaproductos = new List<DTOProductos>();
            foreach (var item in ListarProductosSuperX())
            {
                DTOProductos producto = new DTOProductos();
                producto.Id = item.id;
                producto.Name = item.name;
                producto.Price = item.pvp;
                producto.Iva = item.impuesto;
                producto.Tienda = "Super X";
                listaproductos.Add(producto);
            }
            foreach (var item in ListarProductosTiendaMil())
            {
                DTOProductos producto = new DTOProductos();
                producto.Id = item.id;
                producto.Name = item.nombre;
                producto.Price = item.precio_unitario;
                producto.Iva = item.iva;
                producto.Tienda = "Tienda Mil";
                listaproductos.Add(producto);
            }
            return listaproductos;
        }
    }
}
