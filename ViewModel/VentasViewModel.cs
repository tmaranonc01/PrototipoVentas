using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using PrototipoVentas.Model;
using System.Windows.Input;

namespace PrototipoVentas.ViewModel { 
	public class VentasViewModel
	{
		private List<Ventas> VentasList;
		
		public VentasViewModel()
		{
			VentasList = new List<Ventas>
			{
				new Ventas{1,"10/12/2020",20.3,"1234"},
				new Ventas{2,"10/12/2020",20.2,"1234"},
				new Ventas{3,"10/12/2020",20.5,"1234"},
				new Ventas{4,"10/12/2020",20.7,"1234"}
			};

		}
        public IList<Ventas> Ventas
        {
            get { return VentasList; }
            set { VentasList = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
    }
}
