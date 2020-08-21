namespace Netzwerkverwaltung.Window
{
    partial class FormInsertAndUpdate
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.itembindingSourceNetwork = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_gerätetyp = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_beschreibung = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSourceNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSourceNetwork, "Name", true));
            this.textBox_name.Location = new System.Drawing.Point(89, 57);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(168, 20);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_name.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // itembindingSourceNetwork
            // 
            this.itembindingSourceNetwork.DataSource = typeof(Netzwerkverwaltung.Data.NetworkData);
            // 
            // textBox_ip
            // 
            this.textBox_ip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSourceNetwork, "IpAdresse", true));
            this.textBox_ip.Location = new System.Drawing.Point(89, 83);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(168, 20);
            this.textBox_ip.TabIndex = 1;
            this.textBox_ip.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_ip.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // textBox_gerätetyp
            // 
            this.textBox_gerätetyp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSourceNetwork, "Gerätetype", true));
            this.textBox_gerätetyp.Location = new System.Drawing.Point(89, 109);
            this.textBox_gerätetyp.Name = "textBox_gerätetyp";
            this.textBox_gerätetyp.Size = new System.Drawing.Size(168, 20);
            this.textBox_gerätetyp.TabIndex = 2;
            this.textBox_gerätetyp.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox_gerätetyp.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(182, 279);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(101, 279);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP-Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gerätetyp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Beschreibung";
            // 
            // richTextBox_beschreibung
            // 
            this.richTextBox_beschreibung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSourceNetwork, "Kurzbeschreibung", true));
            this.richTextBox_beschreibung.Location = new System.Drawing.Point(89, 135);
            this.richTextBox_beschreibung.Name = "richTextBox_beschreibung";
            this.richTextBox_beschreibung.Size = new System.Drawing.Size(168, 119);
            this.richTextBox_beschreibung.TabIndex = 10;
            this.richTextBox_beschreibung.Text = "";
            this.richTextBox_beschreibung.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.richTextBox_beschreibung.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itembindingSourceNetwork, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(89, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id";
            // 
            // FormInsertAndUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 323);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox_beschreibung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_gerätetyp);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.textBox_name);
            this.Name = "FormInsertAndUpdate";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.itembindingSourceNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_gerätetyp;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_beschreibung;
        private System.Windows.Forms.BindingSource itembindingSourceNetwork;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

