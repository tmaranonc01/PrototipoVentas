using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using PrototipoVentas.Model;
using System.Windows.Input;

namespace PrototipoVentas.ViewModel
{
	public class ArticlosViewModel
	{
		private List<Articulos> ArticulosList;

		public ArticlosViewModel()
		{
			ArticulosList = new List<Articulos>
			{
			   new Articulos{1,"naicobot",1,21,1.21},
			   new Articulos{2,"naicobot2",1,21,1.21},
			   new Articulos{3,"naicobot3",1,21,1.21},
			   new Articulos{4,"naicobot4",1,21,1.21},
			};
        }

        public IList<Articulos> articulos
        {
            get { return ArticulosList; }
            set { ArticulosList = value; }
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
