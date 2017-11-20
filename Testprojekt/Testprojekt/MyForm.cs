using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Testprojekt
{
    class MyForm : Form
    {
        public MyForm()
        {
            TableLayoutPanel panel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 3,
                Dock = DockStyle.Fill ,
                BackColor = Color.Gold

            };
            Controls.Add(panel);
           
        }
    }
}
