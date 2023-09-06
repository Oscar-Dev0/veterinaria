using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterinaria
{
    public partial class invoice : Form
    {
        Database database;
        public invoice(object s)
        {
            InitializeComponent();
            database = (Database)s;
        }
    }
}
