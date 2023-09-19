using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veterinaria.src.functions;

namespace veterinaria
{
    public partial class report : Form
    {
        Database database;
        public report(object s)
        {
            InitializeComponent();
            database = (Database)s;
        }
    }
}
