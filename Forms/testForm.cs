using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using informationSystem.Entities;
using informationSystem.ElementsUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace informationSystem.Forms
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
                Form f = Application.OpenForms["loginForm"];
                userFullName.Text = ((loginForm)f).fullName.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string conn = "Data Source=localhost;Initial Catalog=Trade;Integrated Security=True";
                string sqlQuerry = "SELECT ProductName, ProductStatus, ProductDescription, ProductPhoto, ProductCost, ProductStatus,ProductManufacturer FROM Product";
                SqlConnection connect = new SqlConnection(conn);
                connect.Open();
                SqlCommand command = new SqlCommand(sqlQuerry, connect);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                SqlDataReader reader = command.ExecuteReader();
                int x = 0;
                int y = 0;
            while (reader.Read())
            {
                productCard productCard = new productCard();
                productCard.AutoScroll = true;
                // productCard.Anchor = AnchorStyles.Left;
                productCard.Location = new Point(x, y);
                this.Controls.Add(productCard);
                y+=200;
                productCard.productName.Text = (string)reader["ProductName"];
                productCard.productCost.Text = ((decimal)reader["ProductCost"]).ToString();
                productCard.productDisc.Text = (string)reader["ProductDescription"];
                productCard.productManufacture.Text = (string)reader["ProductManufacturer"];
                if ((string)reader["ProductStatus"]=="true")
                {
                    productCard.productWarehouse.Text ="В наличии";
                }
                else
                {
                    productCard.productWarehouse.Text="Нет в наличии";
                }
                var a = Buffer.ByteLength((Byte[])reader["ProductPhoto"]);
                if (a != 0)
                {
                    productCard.productPicture.Image = (Bitmap)((new ImageConverter()).ConvertFrom((Byte[])reader["ProductPhoto"]));
                }
                string status = (string)reader["ProductStatus"];
                    if (status == "false")
                    {
                        productCard.BackColor = SystemColors.GrayText;
                   
                    }
            }
        }
    }
}
