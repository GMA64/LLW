using Geräte.Core;
using Geräte.Data;
using Geräte.Validation;
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
    public partial class FormListInsertAndUpdate : Form
    {
        bool isUpdate = false;
        public FormListInsertAndUpdate()
        {
            InitializeComponent();
            isUpdate = false;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            itembindingSource.DataSource = new Device();

        }
        public FormListInsertAndUpdate(Device device)
        {
            InitializeComponent();
            isUpdate = true;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            itembindingSource.DataSource = new Device
            {
                Id = device.Id,
                DeviceName = device.DeviceName,
                DeviceType = device.DeviceType,
                Manufacturere = device.Manufacturere
            };
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                ListDB.GetInstance().Update(itembindingSource.Current as Device);
                this.Close();
            }
            else
            {
                ListDB.GetInstance().Insert(itembindingSource.Current as Device);
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

            errorProvider.SetIconPadding(text, 5);
            errorProvider.SetIconAlignment(text, ErrorIconAlignment.MiddleLeft);

            if(text.Name == textBox_Name.Name)
            {
                try
                {
                    (itembindingSource.Current as Device).CheckDeviceName();
                    errorProvider.SetError(text, null);
                }
                catch (DeviceException ex)
                {
                    errorProvider.SetError(text, ex.Message);
                }
            }

            if (text.Name == textBox_Type.Name)
            {
                try
                {
                    (itembindingSource.Current as Device).CheckDeviceType();
                    errorProvider.SetError(text, null);
                }
                catch (DeviceException ex)
                {
                    errorProvider.SetError(text, ex.Message);
                }
            }

            if (text.Name == textBox_Manufactory.Name)
            {
                try
                {
                    (itembindingSource.Current as Device).CheckManufacturere();
                    errorProvider.SetError(text, null);
                }
                catch (DeviceException ex)
                {
                    errorProvider.SetError(text, ex.Message);
                }
            }
        }
    }
}
