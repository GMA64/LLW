namespace Geräte.View
{
    partial class FormListInsertAndUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.itembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Manufactory = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Id
            // 
            this.textBox_Id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSource, "Id", true));
            this.textBox_Id.Location = new System.Drawing.Point(89, 12);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(162, 20);
            this.textBox_Id.TabIndex = 0;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_Id.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // itembindingSource
            // 
            this.itembindingSource.DataSource = typeof(Geräte.Core.Device);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Device Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSource, "DeviceName", true));
            this.textBox_Name.Location = new System.Drawing.Point(89, 38);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(162, 20);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_Name.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Device Type";
            // 
            // textBox_Type
            // 
            this.textBox_Type.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSource, "DeviceType", true));
            this.textBox_Type.Location = new System.Drawing.Point(89, 64);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(162, 20);
            this.textBox_Type.TabIndex = 4;
            this.textBox_Type.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_Type.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manufactory";
            // 
            // textBox_Manufactory
            // 
            this.textBox_Manufactory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSource, "Manufacturere", true));
            this.textBox_Manufactory.Location = new System.Drawing.Point(89, 90);
            this.textBox_Manufactory.Name = "textBox_Manufactory";
            this.textBox_Manufactory.Size = new System.Drawing.Size(162, 20);
            this.textBox_Manufactory.TabIndex = 6;
            this.textBox_Manufactory.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_Manufactory.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(176, 208);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(95, 208);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormListInsertAndUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 243);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Manufactory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Id);
            this.Name = "FormListInsertAndUpdate";
            this.Text = "FormListInsertAndUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Manufactory;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.BindingSource itembindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}