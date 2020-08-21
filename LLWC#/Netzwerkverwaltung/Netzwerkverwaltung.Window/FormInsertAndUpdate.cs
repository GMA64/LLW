using Netzwerkverwaltung.Core;
using Netzwerkverwaltung.Data;
using Netzwerkverwaltung.Validation;
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
    public partial class FormInsertAndUpdate : Form
    {
        bool isUpdate = false;
        public FormInsertAndUpdate()
        {
            InitializeComponent();
            this.Text = "Add";
            isUpdate = false;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            itembindingSourceNetwork.DataSource = new NetworkData();
        }

        public FormInsertAndUpdate(NetworkData data)
        {
            InitializeComponent();
            this.Text = "Update";
            isUpdate = true;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            itembindingSourceNetwork.DataSource = new NetworkData() {
                Id = data.Id,
                Name = data.Name,
                Gerätetype = data.Gerätetype,
                IpAdresse = data.IpAdresse,
                Kurzbeschreibung = data.Kurzbeschreibung
            };
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (isUpdate == true)
            {
                SQLiteDB.GetInstance().Update(itembindingSourceNetwork.DataSource as NetworkData);
                this.Close();
            }
            else if(isUpdate == false)
            {
                SQLiteDB.GetInstance().Insert(itembindingSourceNetwork.DataSource as NetworkData);
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void textBox_Validated(object sender, EventArgs e)
        {
            TextBoxBase text = (TextBoxBase)sender;

            errorProvider.SetIconAlignment(text, ErrorIconAlignment.MiddleLeft);
            errorProvider.SetIconPadding(text, 5);

            if (text.Name == textBox_name.Name)
            {
                try
                {
                    (itembindingSourceNetwork.Current as NetworkData).CheckName();
                    errorProvider.SetError(text, null);
                }
                catch (NetzwerkException ex)
                {
                    errorProvider.SetError(text, ex.Message);
                }
            }
            else if (text.Name == textBox_ip.Name)
            {
                try
                {
                    (itembindingSourceNetwork.Current as NetworkData).CheckIPAddress();
                    errorProvider.SetError(text, null);
                }
                catch (NetzwerkException ex)
                {
                    errorProvider.SetError(text, ex.Message);
                }
            }
            else if (text.Name == textBox_gerätetyp.Name)
            {
                try
                {
                    (itembindingSourceNetwork.Current as NetworkData).CheckGerätetyp();
                    errorProvider.SetError(text, null);
                }
                catch (NetzwerkException ex)
                {
                    errorProvider.SetError(text, ex.Message);
                }
            }
            else if (text.Name == richTextBox_beschreibung.Name)
            {
                try
                {
                    (itembindingSourceNetwork.Current as NetworkData).CheckKurzbeschreibung();
                    errorProvider.SetError(text, null);
                }
                catch (NetzwerkException ex)
                {
                    errorProvider.SetError(text, ex.Message);
                }
            }
        }
    }
}
