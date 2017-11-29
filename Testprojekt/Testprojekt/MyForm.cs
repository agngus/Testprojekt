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
        private TextBox varuInput;
        private Shop ShoppingCart;
        private List<string> shoppingCart = new List<string>();
        private ListBox varuDisplay;
        private List<StoreStructure> assortment = new List<StoreStructure>();
        private List<StoreStructure> assortmentMaxi = new List<StoreStructure>();
        private StoreStructure Assortment;
       
        private List<string> maxiList = new List<string>();

        public MyForm()
        {
            Size = new Size(1000, 800);
            AutoSizeMode = AutoSizeMode;
          

            TableLayoutPanel panel = new TableLayoutPanel
            {
                RowCount = 7,
                ColumnCount = 2,
                Dock = DockStyle.Fill,

                BackColor = Color.Gold

            };
            Controls.Add(panel);
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 5));
            panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 2));
            panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            panel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 10));

            var headerLabel = new Label
            {
                Text = "Inköpslista",
                BackColor = Color.AntiqueWhite,
                Font = new Font("Impact", 17F),
                Anchor = AnchorStyles.Bottom,
                
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(headerLabel);
            panel.SetColumnSpan(headerLabel, 2);
            var fyllPa = new Label
            {
                Text = "Fyll på:",
                BackColor = Color.AntiqueWhite,
                Anchor = AnchorStyles.Left,
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(fyllPa);
            panel.SetColumnSpan(fyllPa, 2);
            varuInput = new TextBox
            {
                Dock = DockStyle.Fill,
                Anchor = AnchorStyles.Left,
                Height = 350,
                Width = 550
            };
            panel.Controls.Add(varuInput);
            varuInput.KeyDown += new KeyEventHandler(VaruInput_KeyDown);


            var button1 = new Button
            {
                Dock = DockStyle.Fill,
                Font = new Font("Impact", 12F),
                Text = "Maxi, Kungälv"
            };
            panel.Controls.Add(button1);
            button1.Click += Button1_Click;
            varuDisplay = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Liberation Sans", 9F)
            };
            panel.Controls.Add(varuDisplay);
            panel.SetRowSpan(varuDisplay, 3);
            varuDisplay.Items.Add("Din lista: \n");

            var button2 = new Button
            {
                Dock = DockStyle.Fill,
                Font = new Font("Impact", 12F),
                Text = "City Gross, Ytterby"
            };
            panel.Controls.Add(button2);
            button2.Click += Button2_Click;

            var button3 = new Button
            {
                Dock = DockStyle.Fill,
                Font = new Font("Impact", 12F),
                Text = "Willys, Stenungsund"
            };
            panel.Controls.Add(button3);
            button3.Click += Button3_Click;
            var empty = new Label
            {
                Anchor = AnchorStyles.Left,
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(empty);
            var mejlaTill = new Label
            {
                Text = "Mejla till:",
                BackColor = Color.AntiqueWhite,
                Anchor = AnchorStyles.Left,
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(mejlaTill);
            var mejlInput = new TextBox
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(mejlInput);
            this.ShoppingCart = new Shop();
           this.Assortment = new StoreStructure();

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            var assortment = Assortment.ReadAssortment();
            varuDisplay.Items.Clear();
            shoppingCart = ShoppingCart.LoadAllItemsToList();
            List<string> maxiList = Shop.SortInMaxiOrder(shoppingCart, assortment);
            foreach (string item in maxiList)
            {
                varuDisplay.Items.Add(item);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var assortment = Assortment.ReadAssortment(); 
            varuDisplay.Items.Clear();
            shoppingCart = ShoppingCart.LoadAllItemsToList();
            List<string> cityList = Shop.SortInCityGrossOrder(shoppingCart,assortment);
            foreach (string item in cityList)
            {
                varuDisplay.Items.Add(item);
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            var assortment = Assortment.ReadAssortment();
            varuDisplay.Items.Clear();
            shoppingCart = ShoppingCart.LoadAllItemsToList();
            List<string> willysList = Shop.SortInWillysOrder(shoppingCart, assortment);
            foreach (string item in willysList)
            {
                varuDisplay.Items.Add(item);
            }
        }

        private void VaruInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = varuInput.Text;
                ShoppingCart.AddProductToCart(input);
                varuInput.Clear();
                varuDisplay.Items.Clear();

                foreach (string item in ShoppingCart.LoadAllItemsToList())
                {
                    varuDisplay.Items.Add(item);
                }

            }
        }
    }
}
