using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog3_Proyecto1
{
    public class C_LISTAS
    {
        public List<C_CLIENTES> listaClientes = new List<C_CLIENTES>();
        public List<C_VEHICULOS> listaVehiculos = new List<C_VEHICULOS>();
        public List<C_ALQUILER> listaAlquiler = new List<C_ALQUILER>();

        public bool llenarListaCliente(C_CLIENTES cliente)
        {
            if (listaClientes.Contains(cliente))
                return false;
            else
            {
                listaClientes.Add(cliente);
                return true;
            }
        }

        public bool llenarListaVehiculos(C_VEHICULOS car)
        {
            if (listaVehiculos.Contains(car))
                return false;
            else
            {
                listaVehiculos.Add(car);
                return true;
            }
        }
    }
}
