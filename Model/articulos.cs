using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace PrototipoVentas.Model
{
    public class Articulos : INotifyPropertyChanged
    {

        private int idArticulo;
        private string descripcion;
        private double precioCoste;
        private double iva;
        private double pvp;

        public int IdArticulo
        {
            get
            {
                return idArticulo;
            }
            set
            {
                idArticulo = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        public double PrecioCoste
        {
            get
            {
                return precioCoste;
            }
            set
            {
                precioCoste = value;
            }
        }
        public double IVA
        {
            get
            {
                return iva;
            }
            set
            {
                iva = value;
            }
        }
        public double PVP
        {
            get
            {
                return pvp;
            }
            set
            {
                pvp = value;
            }
        }
    }
}

/*Hola Mundo*/

 