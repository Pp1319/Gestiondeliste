using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiondeliste
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            this.comboBoxSource.Items.AddRange(new object [] {
                "Australie", "Pays Bas", "USA"
            });
        }
    }

}