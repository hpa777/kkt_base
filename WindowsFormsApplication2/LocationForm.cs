using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class LocationForm : Form
    {

        private int _id;

        public LocationForm(int id)
        {            
            InitializeComponent();
            _id = id;            
        }
               

        private void LocationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kktDataSet.doc_kkm' table. You can move, or remove it, as needed.
            this.doc_kkmTableAdapter.FillById(this.kktDataSet.doc_kkm, _id);
        }
                
        private void LocationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dockkmBindingSource.EndEdit();
            DataRowView rv = (DataRowView)dockkmBindingSource.Current;
            kktDataSet.doc_kkmRow selectedRow = (kktDataSet.doc_kkmRow)rv.Row;
            doc_kkmTableAdapter.Update(selectedRow);
        }

       

        

        
    }
}
