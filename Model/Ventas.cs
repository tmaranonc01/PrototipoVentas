using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace PrototipoVentas.Model
{
    public class Ventas : INotifyPropertyChanged
    {

        private int idVenta;
        private DateTime fecha;
        private double importe;
        private string numTarjeta;

        public int IdVenta
        {
            get
            {
                return idVenta;
            }
            set
            {
                idVenta = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        public double Importe
        {
            get
            {
                return importe;
            }
            set
            {
                importe = value;
            }
        }

        public string NumTarjeta
        {
            get
            {
                return numTarjeta;
            }
            set
            {
                numTarjeta = value;
            }
        }
    }
}
