using Netzwerkverwaltung.Core;
using Netzwerkverwaltung.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netzwerkverwaltung.Window
{
    public partial class FormList : Form
    {
        private IList data;
        public FormList()
        {
            InitializeComponent();

            //data = ListDB.GetInstance();
            data = SQLiteDB.GetInstance();


            //data.Insert(new NetworkData
            //{
            //    Id = 1,
            //    Name = "HP Laptop",
            //    Gerätetype = "HP Elitebook 40",
            //    IpAdresse = "123.156.486.4",
            //    Kurzbeschreibung = "Ein Laptop von LWN"
            //});

            //data.Insert(new NetworkData
            //{
            //    Id = 2,
            //    Name = "lenovo",
            //    Gerätetype = "p 50 s lite",
            //    IpAdresse = "123.156.486.4",
            //    Kurzbeschreibung = "Ein Laptop von LWN"
            //});

            //data.Insert(new NetworkData
            //{
            //    Id = 3,
            //    Name = "Dell ",
            //    Gerätetype = "HP Elitebook 40",
            //    IpAdresse = "123.156.486.4",
            //    Kurzbeschreibung = "Ein Laptop von LWN"
            //});

            itemDataBindingSourceNetwork.DataSource = data.GetAll();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            var form = new FormInsertAndUpdate();
            form.ShowDialog();
            itemDataBindingSourceNetwork.DataSource = data.GetAll().ToArray();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            var form = new FormInsertAndUpdate(itemDataBindingSourceNetwork.Current as NetworkData);
            form.ShowDialog();

            itemDataBindingSourceNetwork.DataSource = data.GetAll().ToArray();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var i = itemDataBindingSourceNetwork.Current as NetworkData;
            if (DialogResult.Yes == MessageBox.Show($"Do you want to delete {i.Name}", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                data.Delte(i);

            itemDataBindingSourceNetwork.DataSource = data.GetAll().ToArray();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            var text = textBox_Search.Text;

            if (string.IsNullOrEmpty(text))
            {
                itemDataBindingSourceNetwork.DataSource = data.GetAll();
            }
            else
            {
                itemDataBindingSourceNetwork.DataSource = data.SearchByDevice(text);
            }
        }
    }
}
