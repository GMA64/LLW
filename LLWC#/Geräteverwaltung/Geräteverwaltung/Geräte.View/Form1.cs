using Geräte.Core;
using Geräte.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geräte.View
{
    public partial class Form1 : Form
    {
        private IList data;
        public Form1()
        {
            InitializeComponent();
            data = ListDB.GetInstance();


            itemBindingSource.DataSource = data.GetAll();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            var form = new FormListInsertAndUpdate();
            form.ShowDialog();

            itemBindingSource.DataSource = data.GetAll().ToArray();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            var form = new FormListInsertAndUpdate(itemBindingSource.Current as Device);
            form.ShowDialog();

            itemBindingSource.DataSource = data.GetAll().ToArray();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var item = itemBindingSource.Current as Device;

            if (DialogResult.Yes == MessageBox.Show("Dou you want to Delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                data.Delete(item);
            }

            itemBindingSource.DataSource = data.GetAll().ToArray();
        }
    }
}
