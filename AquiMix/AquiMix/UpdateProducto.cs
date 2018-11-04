using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquiMix
{
    public partial class UpdateProducto : Form
    {
        public UpdateProducto()
        {
            InitializeComponent();
        }

        private void UpdateProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aquiMixDataSet.Menu' Puede moverla o quitarla según sea necesario.
            this.menuTableAdapter.Fill(this.aquiMixDataSet.Menu);

        }
    }
}
