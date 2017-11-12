namespace WindowsFormsApplication2
{
    partial class Report2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mastersdirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kktDataSet = new WindowsFormsApplication2.kktDataSet();
            this.masters_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.masters_dirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mastersdirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kktDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мастер:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mastersdirBindingSource;
            this.comboBox1.DisplayMember = "value";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id";
            // 
            // mastersdirBindingSource
            // 
            this.mastersdirBindingSource.DataMember = "masters_dir";
            this.mastersdirBindingSource.DataSource = this.kktDataSet;
            // 
            // kktDataSet
            // 
            this.kktDataSet.DataSetName = "kktDataSet";
            this.kktDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masters_dirTableAdapter
            // 
            this.masters_dirTableAdapter.ClearBeforeFill = true;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Report2";
            this.Size = new System.Drawing.Size(457, 31);
            ((System.ComponentModel.ISupportInitialize)(this.mastersdirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kktDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource mastersdirBindingSource;
        private kktDataSet kktDataSet;
        private kktDataSetTableAdapters.masters_dirTableAdapter masters_dirTableAdapter;
    }
}
