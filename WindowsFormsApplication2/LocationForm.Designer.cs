namespace WindowsFormsApplication2
{
    partial class LocationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dockkmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kktDataSet = new WindowsFormsApplication2.kktDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.regionCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.settlementTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.houseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buildingNumberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.apartmentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.locationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.doc_kkmTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.doc_kkmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dockkmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kktDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Почтовый индекс";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "zip_code", true));
            this.zipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zipCodeTextBox.Location = new System.Drawing.Point(169, 4);
            this.zipCodeTextBox.Mask = "000000";
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(61, 26);
            this.zipCodeTextBox.TabIndex = 1;
            // 
            // dockkmBindingSource
            // 
            this.dockkmBindingSource.DataMember = "doc_kkm";
            this.dockkmBindingSource.DataSource = this.kktDataSet;
            // 
            // kktDataSet
            // 
            this.kktDataSet.DataSetName = "kktDataSet";
            this.kktDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(529, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Регион (код)";
            // 
            // regionCodeTextBox
            // 
            this.regionCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "region_code", true));
            this.regionCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regionCodeTextBox.Location = new System.Drawing.Point(639, 1);
            this.regionCodeTextBox.Mask = "00";
            this.regionCodeTextBox.Name = "regionCodeTextBox";
            this.regionCodeTextBox.Size = new System.Drawing.Size(25, 26);
            this.regionCodeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Район";
            // 
            // districtTextBox
            // 
            this.districtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "district", true));
            this.districtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtTextBox.Location = new System.Drawing.Point(169, 36);
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(495, 26);
            this.districtTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Город";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "city", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(169, 68);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(495, 26);
            this.cityTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Населенный пункт";
            // 
            // settlementTextBox
            // 
            this.settlementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "settlement", true));
            this.settlementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settlementTextBox.Location = new System.Drawing.Point(169, 100);
            this.settlementTextBox.Name = "settlementTextBox";
            this.settlementTextBox.Size = new System.Drawing.Size(495, 26);
            this.settlementTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Улица";
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "street", true));
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetTextBox.Location = new System.Drawing.Point(169, 132);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(495, 26);
            this.streetTextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 40);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер дома\r\n(владения)";
            // 
            // houseNumberTextBox
            // 
            this.houseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "house_number", true));
            this.houseNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.houseNumberTextBox.Location = new System.Drawing.Point(169, 164);
            this.houseNumberTextBox.Name = "houseNumberTextBox";
            this.houseNumberTextBox.Size = new System.Drawing.Size(130, 26);
            this.houseNumberTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 40);
            this.label8.TabIndex = 14;
            this.label8.Text = "Номер корпуса\r\n(строения)";
            // 
            // buildingNumberTextBox
            // 
            this.buildingNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "building_number", true));
            this.buildingNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildingNumberTextBox.Location = new System.Drawing.Point(169, 213);
            this.buildingNumberTextBox.Name = "buildingNumberTextBox";
            this.buildingNumberTextBox.Size = new System.Drawing.Size(130, 26);
            this.buildingNumberTextBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 40);
            this.label9.TabIndex = 16;
            this.label9.Text = "Номер квартиры\r\n(помещения)";
            // 
            // apartmentNumberTextBox
            // 
            this.apartmentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "apartment_number", true));
            this.apartmentNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apartmentNumberTextBox.Location = new System.Drawing.Point(169, 262);
            this.apartmentNumberTextBox.Name = "apartmentNumberTextBox";
            this.apartmentNumberTextBox.Size = new System.Drawing.Size(130, 26);
            this.apartmentNumberTextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 40);
            this.label10.TabIndex = 18;
            this.label10.Text = "Место установки (применения)\r\nконтрольно-кассовой техники";
            // 
            // locationRichTextBox
            // 
            this.locationRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dockkmBindingSource, "location_full", true));
            this.locationRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationRichTextBox.Location = new System.Drawing.Point(262, 314);
            this.locationRichTextBox.Name = "locationRichTextBox";
            this.locationRichTextBox.Size = new System.Drawing.Size(402, 46);
            this.locationRichTextBox.TabIndex = 19;
            this.locationRichTextBox.Text = "";
            // 
            // doc_kkmTableAdapter
            // 
            this.doc_kkmTableAdapter.ClearBeforeFill = true;
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 428);
            this.Controls.Add(this.locationRichTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.apartmentNumberTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buildingNumberTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.houseNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.settlementTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.districtTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regionCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocationForm";
            this.Text = "Адрес установки ККМ";
            
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LocationForm_FormClosed);
            this.Load += new System.EventHandler(this.LocationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockkmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kktDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox zipCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox regionCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox districtTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox settlementTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox houseNumberTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox buildingNumberTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox apartmentNumberTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox locationRichTextBox;
        private kktDataSet kktDataSet;
        private System.Windows.Forms.BindingSource dockkmBindingSource;
        private kktDataSetTableAdapters.doc_kkmTableAdapter doc_kkmTableAdapter;
    }
}