using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;
using Microsoft.Reporting.WinForms;


namespace WindowsFormsApplication2
{
    public partial class NewDocForm : Form
    {
        public bool isValid { get; set; }

        Dictionary<string, string> doc_fields;

        kktDataSetTableAdapters.kkm_listTableAdapter kkm_list_ta;

        private DataGridViewTextBoxColumn inn_dir_col, full_name_dir_col;

        public NewDocForm()
        {
            InitializeComponent();

            kktDataSet.doc_head.Columns["data_start"].DefaultValue = System.DateTime.Today;
            kktDataSet.doc_head.Columns["data_end"].DefaultValue = System.DateTime.Today;
            kktDataSet.doc_kkm.Columns["data_release"].DefaultValue = System.DateTime.Today;
            kktDataSet.doc_kkm.Columns["data_registration"].DefaultValue = System.DateTime.Today;
            kktDataSet.doc_kkm.Columns["data_activation"].DefaultValue = System.DateTime.Today;
            kktDataSet.doc_kkm.Columns["data_change"].DefaultValue = System.DateTime.Today.AddMonths(13);

            dirGridView.AutoGenerateColumns = false;

            doc_fields = new Dictionary<string, string>();
            doc_fields.Add("name", "{0}");
            doc_fields.Add("member", "{0}");
            doc_fields.Add("member base", "{0}");
            doc_fields.Add("data_start", "{0:dd MMMM yyyy}");
            doc_fields.Add("data_end", "{0:dd MMMM yyyy}");
            doc_fields.Add("address", "{0}");
            doc_fields.Add("inn", "{0}");
            doc_fields.Add("kpp", "{0}");
            doc_fields.Add("ogrn", "{0}");
            doc_fields.Add("bank_account", "{0}");
            doc_fields.Add("bank", "{0}");
            doc_fields.Add("bik", "{0}");
            doc_fields.Add("bank_account_cor", "{0}");
            doc_fields.Add("phone", "{0}");
            doc_fields.Add("email", "{0}");

            kkm_list_ta = new kktDataSetTableAdapters.kkm_listTableAdapter();

            inn_dir_col = new DataGridViewTextBoxColumn();
            inn_dir_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            inn_dir_col.DataPropertyName = "inn";
            inn_dir_col.HeaderText = "ИНН";
            inn_dir_col.Name = "inn_dir_col";

            full_name_dir_col = new DataGridViewTextBoxColumn();
            full_name_dir_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;            
            full_name_dir_col.HeaderText = "Полное наименование";
            full_name_dir_col.Name = "full_name_dir_col";
            
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            wordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);

        }



        private void NewDocForm_Load(object sender, EventArgs e)
        {

            this.doc_headTableAdapter.Fill(this.kktDataSet.doc_head);
            this.doc_kkmTableAdapter.Fill(this.kktDataSet.doc_kkm);
            FillDir();
            fn_number_dirBindingSource.Filter = "kkm_id Is NULL and deleted Is NULL";
            fn_mp_dirBindingSource.Filter = "kkm_id Is NULL";

            doc_headBindingSource.ResetBindings(true);
            doc_kkmBindingSource.ResetBindings(true);

            addKkmButton.Enabled = deleteKkmButton.Enabled = saveKkmButton.Enabled = false;
            kktBindingNavigator.CausesValidation = true;

            dirComboBox.Items.Add(new ComboboxItem("Статус оплаты", this.paymentstatusdirBindingSource));
            dirComboBox.Items.Add(new ComboboxItem("Стоимость", this.pricedirBindingSource));
            dirComboBox.Items.Add(new ComboboxItem("Модели ККТ", this.model_kkm_dirBindingSource));
            dirComboBox.Items.Add(new ComboboxItem("Мастера", this.masters_dirBindingSource));
            dirComboBox.Items.Add(new ComboboxItem("Зав. № (Фискальный накопитель)", this.fn_number_dirBindingSource));
            dirComboBox.Items.Add(new ComboboxItem("ОФД", this.ofd_dirBindingSource));
            dirComboBox.Items.Add(new ComboboxItem("МП", this.fn_mp_dirBindingSource));

            searchComboBox.Items.Add(new ComboboxItem("нет", null));
            foreach (DataGridViewColumn col in doc_headDataGridView.Columns)
            {
                if (col.Visible == false) continue;
                ComboboxItem ci = new ComboboxItem(col.HeaderText, col.DataPropertyName);
                Type type = col.GetType();
                ci.itemType = type;
                if (type == typeof(DataGridViewComboBoxColumn))
                {
                    ci.bindingSource = ((DataGridViewComboBoxColumn)col).DataSource;
                }
                searchComboBox.Items.Add(ci);
            }

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportComboBox.Items.Add(new ComboboxItem("График замены ФН", new Report1()));
            reportComboBox.Items.Add(new ComboboxItem("Список клиентов", new Report2()));
        }


        private void printButton_Click(object sender, EventArgs e)
        {
            if (doc_headBindingSource.Current == null) return;
            DataRowView dh = doc_headBindingSource.Current as DataRowView;

            object oMissing = System.Reflection.Missing.Value;
            object fileName = Path.Combine(System.Windows.Forms.Application.StartupPath, "document.docx");
            object readOnly = false;
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
            wordApp.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            //Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(fileName, ReadOnly: false, Visible: true);
            Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(
                        ref fileName, ref oMissing, ref readOnly,
                     ref oMissing, ref oMissing, ref oMissing,
                     ref oMissing, ref oMissing, ref oMissing,
                     ref oMissing, ref oMissing, ref oMissing,
                     ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            aDoc.Activate();

            FindAndReplace(wordApp, "{dh_doc_number}", String.Format("{0}/{1}", dh["number"], dh["year"]));
            foreach (KeyValuePair<string, string> item in doc_fields)
            {
                FindAndReplace(wordApp, String.Format("{{dh_{0}}}", item.Key), dh[item.Key] != DBNull.Value ? dh[item.Key] : String.Empty);
            }

            if (kkm_list_ta.Fill(this.kktDataSet.kkm_list, (int)dh["id"]) > 0)
            {
                Table tb = aDoc.Tables[1];
                int kkt_count = 0;

                foreach (DataRow kkm_row in this.kktDataSet.kkm_list.Rows)
                {
                    Row newRow = kkt_count == 0 ? tb.Rows[2] : tb.Rows.Add(oMissing);
                    kkt_count++;
                    newRow.Cells[1].Range.Text = kkt_count.ToString();
                    newRow.Cells[2].Range.Text = String.Format("{0}", kkm_row["name"]);
                    newRow.Cells[3].Range.Text = String.Format("{0}", kkm_row["number"]);
                    newRow.Cells[4].Range.Text = String.Format("{0}", kkm_row["fn_number"]);
                    newRow.Cells[5].Range.Text = String.Format("{0}", kkm_row["location"]);
                    newRow.Cells[6].Range.Text = String.Format("{0:F2}", kkm_row["price"]);
                }

            }

            
            int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref oMissing);            
            if (dialogResult == 1)
            {
                aDoc.PrintOut(oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing);
            }
            
            aDoc.Close(false, oMissing, oMissing);
            wordApp.Quit(oMissing, oMissing, oMissing);
            aDoc = null;
            wordApp = null;
            
        }

        private void заявлениеОСнятииСРегистрацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doc_headBindingSource.Current == null || doc_kkmBindingSource == null) return;
            string fileName = getFileName();
            if (fileName == null) return;

            using (ExcelHelper excelHelper = new ExcelHelper("unreg.xls"))
            {
                DataRowView dh = doc_headBindingSource.Current as DataRowView;
                DataRowView dk = doc_kkmBindingSource.Current as DataRowView;
                excelHelper.setActiveSheet(1);
                //ИНН
                excelHelper.writeString(new string[] { "AN1:BU1" }, dh["inn"].ToString());
                //Наименование орг.
                excelHelper.writeString(new string[] { "A10:DN10", "A12:DN12", "A14:DN14" }, dh["full_name"].ToString());
                //Наименование ККМ
                excelHelper.writeString(new string[] { "BC20:DH20" }, getParentValue(dk.Row, "model_kkm_ref", "value"));
                //Заводской номер
                excelHelper.writeString(new string[] { "BC22:DH22" }, dk["number"].ToString());
                //Представитель
                excelHelper.writeString(new string[] { "A40:BF40", "A42:BF42", "A44:BF44" }, dh["member_im"].ToString(), true);
                excelHelper.saveDoc(fileName);
                MessageBox.Show("Файл сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void заявлениеОРегистрацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doc_headBindingSource.Current == null || doc_kkmBindingSource == null) return;
            string fileName = getFileName();
            if (fileName == null) return;            

            using (ExcelHelper excelHelper = new ExcelHelper("reg.xls"))
            {
                DataRowView dh = doc_headBindingSource.Current as DataRowView;
                excelHelper.setActiveSheet(1);
                //ОГРН
                excelHelper.writeString(new string[] { "AN1:CD1" }, dh["ogrn"].ToString());
                //ИНН
                excelHelper.writeString(new string[] { "AN4:BU4" }, dh["inn"].ToString());
                //КПП
                excelHelper.writeString(new string[] { "AN6:BL6" }, dh["kpp"].ToString());
                //Наименование орг.
                excelHelper.writeString(new string[] { "A17:DN17", "A19:DN19", "A21:DN21" }, dh["full_name"].ToString());
                //Представитель
                excelHelper.writeString(new string[] { "A36:BF36", "A38:BF38", "A40:BF40" }, dh["member_im"].ToString(), true);

                DataRowView dk = doc_kkmBindingSource.Current as DataRowView;
                excelHelper.setActiveSheet(3);
                //Наименование ККМ
                excelHelper.writeString(new string[] { "BC13:DH13", "BC15:DH15" }, getParentValue(dk.Row, "model_kkm_ref", "value"));
                //Заводской номер
                excelHelper.writeString(new string[] { "BC17:DH17", "BC19:DH19" }, dk["number"].ToString());
                //Наименовани ФН
                excelHelper.writeString(new string[] { "BC21:DH21", "BC23:DH23", "BC25:DH25", "BC27:DH27", "BC29:DH29", "BC31:DH31" }, getParentValue(dk.Row, "mp_ref", "description"));

                //Заводской номер ФН
                excelHelper.writeString(new string[] { "BC33:DH33" }, getParentValue(dk.Row, "fn_num_ref", "value"));

                //Индекс
                excelHelper.writeString(new string[] { "AE38:AT38" }, dk["zip_code"].ToString());
                //Код региона
                excelHelper.writeString(new string[] { "DK38:DN38" }, dk["region_code"].ToString());
                //Район
                excelHelper.writeString(new string[] { "AE40:DN40" }, dk["district"].ToString());
                //Город
                excelHelper.writeString(new string[] { "AE42:DN42" }, dk["city"].ToString());
                //Населенный пункт
                excelHelper.writeString(new string[] { "AE44:DN44" }, dk["settlement"].ToString());

                excelHelper.setActiveSheet(4);
                //Улица
                excelHelper.writeString(new string[] { "AE9:DN9" }, dk["street"].ToString());
                //Номер дома 
                excelHelper.writeString(new string[] { "AE11:AZ11" }, dk["house_number"].ToString());
                //Номер корпуса 
                excelHelper.writeString(new string[] { "AE13:AZ13" }, dk["building_number"].ToString());
                //Номер квартиры 
                excelHelper.writeString(new string[] { "AE15:AZ15" }, dk["apartment_number"].ToString());
                //Место установки
                excelHelper.writeString(new string[] { "AZ18:DE18", "AZ20:DE20", "AZ22:DE22", "AZ24:DE24" }, dk["location_full"].ToString());

                excelHelper.setActiveSheet(7);
                //Наименование ОФД
                excelHelper.writeString(new string[] { "BC12:DH12", "BC14:DH14", "BC16:DH16", "BC18:DH18" }, getParentValue(dk.Row, "ofd_ref", "full_name"));
                //ИНН ОФД
                excelHelper.writeString(new string[] { "BC21:CJ21" }, getParentValue(dk.Row, "ofd_ref", "inn"));
                excelHelper.saveDoc(fileName);
                MessageBox.Show("Файл сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private string getFileName()
        {
            using (SaveFileDialog fd = new SaveFileDialog())
            {
                fd.DefaultExt = "xlsx";
                fd.AddExtension = true;
                fd.Filter = "Data Files (*.xlsx)|*.xlsx";
                if (fd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    return fd.FileName;
                }
                else return null;
            }
        }

        private string getParentValue(DataRow childRow, string relationName, string fieldName){
            DataRow parentRow = childRow.GetParentRow(relationName);
            return parentRow != null ? parentRow[fieldName].ToString() : String.Empty;
        }

        private void doc_headBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView dr = doc_headBindingSource.Current as DataRowView;
            if (dr == null)
            {
                saveDocButton.Enabled = false;
                deleteDocButton.Enabled = false;
                addKkmButton.Enabled = false;

            }
            else if (dr.IsNew)
            {
                int? n = (int?)doc_headTableAdapter.GetNumber();
                numberTextBox.Text = n.HasValue ? n.ToString() : "1";
                yearComboBox.SelectedIndex = -1;
                yearComboBox.Focus();

                saveDocButton.Enabled = true;
                deleteDocButton.Enabled = false;
                addKkmButton.Enabled = false;

            }
            else if (dr.IsEdit)
            {

                saveDocButton.Enabled = true;
                deleteDocButton.Enabled = true;
                addKkmButton.Enabled = true;
            }

        }

        private void addDocButton_Click(object sender, EventArgs e)
        {
            ((ToolStripButton)sender).Enabled = false;
            addKkmButton.Enabled = false;
        }

        private void saveDocButton_Click(object sender, EventArgs e)
        {

            isValid = true;
            this.ValidateChildren();

            if (!isValid) return;
            DataRowView dr = this.doc_headBindingSource.Current as DataRowView;
            bool is_new = dr.IsNew;
            this.doc_headBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kktDataSet);
            if (is_new)
            {
                int pos = this.doc_headBindingSource.Position;
                this.doc_headTableAdapter.Fill(this.kktDataSet.doc_head);
                this.doc_headBindingSource.Position = pos;
            }

            AddDocButton.Enabled = true;
        }

        // Валидаторы

        private void TextBox_Validated(object sender, EventArgs e)
        {
            validate(((System.Windows.Forms.TextBox)sender).Text, sender);
        }

        private void ComboBox_Validated(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            validate(((ComboBox)sender).SelectedItem, sender);
        }

        private void validate(object val, object ctl)
        {
            if (val == null || String.IsNullOrEmpty(val.ToString()))
            {
                errorProvider1.SetError((Control)ctl, "Заполните поле");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError((Control)ctl, String.Empty);
            }
        }
        /*
        int _kkm_position = -1;
        bool _needKkmDgridRefresh = false;

        private void doc_kkmDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_needKkmDgridRefresh)
            {
                _needKkmDgridRefresh = false;
                doc_kkmBindingSource.CurrencyManager.Refresh();
            }
        }
        */

        private void doc_kkmBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            /*
            DataRowView previous = _kkm_position != -1 ? (DataRowView)doc_kkmBindingSource[_kkm_position] : null;
            int current = doc_kkmBindingSource.Position;
            if (previous != null && current != _kkm_position && previous.Row.RowState != DataRowState.Unchanged)
            {
                doc_kkmBindingSource.Position = _kkm_position;
                MessageBox.Show("Сохраните ККМ");
                return;
            }
            _kkm_position = current;
             */


            if (doc_kkmBindingSource.Current == null)
            {
                saveKkmButton.Enabled = false;
                deleteKkmButton.Enabled = false;
                fn_num_label.Visible = false;
                deleteNumButton.Visible = false;
                fn_num_idComboBox.Visible = true;
                fn_mp_label.Visible = false;
                deleteMpButton.Visible = false;
                mp_idComboBox.Visible = true;              
            }
            else
            {
                saveKkmButton.Enabled = true;
                deleteKkmButton.Enabled = true;
                DataRowView dr = doc_kkmBindingSource.Current as DataRowView;
                if (dr.IsNew)
                {
                    fn_num_label.Visible = false;
                    deleteNumButton.Visible = false;
                    fn_num_idComboBox.Visible = true;
                    fn_mp_label.Visible = false;
                    deleteMpButton.Visible = false;
                    mp_idComboBox.Visible = true;                    
                }
                else if (dr.IsEdit)
                {
                    locationButton.Enabled = true;
                    if (dr["fn_num_id"] != DBNull.Value)
                    {
                        fn_num_label.Text = (string)fn_number_dirTableAdapter.GetById((int)dr["fn_num_id"]);
                        fn_num_label.Visible = true;
                        deleteNumButton.Visible = true;
                        fn_num_idComboBox.Visible = false;
                    }
                    else
                    {
                        fn_num_label.Visible = false;
                        deleteNumButton.Visible = false;
                        fn_num_idComboBox.Visible = true;
                    }
                    if (dr["mp_id"] != DBNull.Value)
                    {
                        fn_mp_label.Text = (string)fn_mp_dirTableAdapter.GetById((int)dr["mp_id"]);
                        fn_mp_label.Visible = true;
                        deleteMpButton.Visible = true;
                        mp_idComboBox.Visible = false;
                    }
                    else
                    {
                        fn_mp_label.Visible = false;
                        deleteMpButton.Visible = false;
                        mp_idComboBox.Visible = true;
                    }

                }
            }

        }

        private void deleteNumButton_Click(object sender, EventArgs e)
        {
            unbindChildDoc("fn_num_ref");
            DataRowView dr = this.doc_kkmBindingSource.Current as DataRowView;
            dr["fn_num_id"] = DBNull.Value;
            this.tableAdapterManager.UpdateAll(this.kktDataSet);
            
            fn_num_label.Visible = false;
            deleteNumButton.Visible = false;
            fn_num_idComboBox.Visible = true;
            fn_num_idComboBox.SelectedItem = null;

        }

        private void deleteMpButton_Click(object sender, EventArgs e)
        {
            unbindChildDoc("mp_ref");
            DataRowView dr = this.doc_kkmBindingSource.Current as DataRowView;
            dr["mp_id"] = DBNull.Value;
            this.tableAdapterManager.UpdateAll(this.kktDataSet);

            fn_mp_label.Visible = false;
            deleteMpButton.Visible = false;
            mp_idComboBox.Visible = true;
            mp_idComboBox.SelectedItem = null;
        }

        private void addKkmButton_Click(object sender, EventArgs e)
        {
            ((ToolStripButton)sender).Enabled = false;
        }

        private void saveKkmButton_Click(object sender, EventArgs e)
        {

            if (this.doc_kkmBindingSource.Current != null)
            {
                DataRowView dr = this.doc_kkmBindingSource.Current as DataRowView;
                bool is_new = dr.IsNew;
                this.doc_kkmBindingSource.EndEdit();
                DataRow rdr = dr.Row.GetParentRow("fn_num_ref");
                if (rdr != null)
                {
                    rdr["kkm_id"] = 1;
                    fn_num_label.Text = (string)rdr["value"];
                    fn_num_label.Visible = true;
                    deleteNumButton.Visible = true;
                    fn_num_idComboBox.Visible = false;

                }
                rdr = dr.Row.GetParentRow("mp_ref");
                if (rdr != null)
                {
                    rdr["kkm_id"] = 1;
                    fn_mp_label.Text = (string)rdr["value"];
                    fn_mp_label.Visible = true;
                    deleteMpButton.Visible = true;
                    mp_idComboBox.Visible = false;

                }

                try
                {
                    this.tableAdapterManager.UpdateAll(this.kktDataSet);
                    addKkmButton.Enabled = true;
                }
                catch (System.Data.DBConcurrencyException)
                {
                    MessageBox.Show("Ошибка сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (is_new)
                {
                    int pos = this.doc_kkmBindingSource.Position;
                    this.doc_kkmTableAdapter.Fill(this.kktDataSet.doc_kkm);
                    this.doc_kkmBindingSource.Position = pos;
                }

            }
        }

        private void DeleteDocButton_Click(object sender, EventArgs e)
        {
            if (doc_headBindingSource.Current != null
                && (int)((DataRowView)doc_headBindingSource.Current)["id"] > 0
                && MessageBox.Show("Удалить?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                doc_headBindingSource.RemoveCurrent();
                try
                {
                    this.tableAdapterManager.UpdateAll(this.kktDataSet);
                }
                catch (Exception)
                {
                    this.doc_headTableAdapter.Fill(this.kktDataSet.doc_head);
                    MessageBox.Show("Удаление невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void DeleteKkmButton_Click(object sender, EventArgs e)
        {
            if (doc_kkmBindingSource.Current != null && MessageBox.Show("Удалить?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                unbindChildDoc("fn_num_ref");
                unbindChildDoc("mp_ref");
                doc_kkmBindingSource.RemoveCurrent();
                try
                {
                    this.tableAdapterManager.UpdateAll(this.kktDataSet);
                }
                catch (Exception)
                {
                    MessageBox.Show("Удаление невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private int? unbindChildDoc(string field)
        {
            DataRowView dr = doc_kkmBindingSource.Current as DataRowView;
            DataRow doc = dr.Row.GetParentRow(field);
            int? id = null;
            if (doc != null)
            {
                doc["kkm_id"] = DBNull.Value;
                id = (int)doc["id"];
                if (field == "fn_num_ref")
                {
                    doc["deleted"] = true;
                }
            }
            return id;
        }




        //Справочники
        private void FillDir()
        {
            this.fn_mp_dirTableAdapter.Fill(this.kktDataSet.fn_mp_dir);
            this.fn_number_dirTableAdapter.Fill(this.kktDataSet.fn_number_dir);
            this.masters_dirTableAdapter.Fill(this.kktDataSet.masters_dir);
            this.model_kkm_dirTableAdapter.Fill(this.kktDataSet.model_kkm_dir);
            this.ofd_dirTableAdapter.Fill(this.kktDataSet.ofd_dir);
            this.payment_status_dirTableAdapter.Fill(this.kktDataSet.payment_status_dir);
            this.price_dirTableAdapter.Fill(this.kktDataSet.price_dir);
            this.service_type_dirTableAdapter.Fill(this.kktDataSet.service_type_dir);
        }

        private void dirComboBox_TextChanged(object sender, EventArgs e)
        {
            removeDirColumn(inn_dir_col);
            removeDirColumn(full_name_dir_col);
            BindingSource source = ((ComboboxItem)dirComboBox.SelectedItem).Value as BindingSource;
            if (source.DataMember.Equals("ofd_dir"))
            {
                full_name_dir_col.DataPropertyName = "full_name";
                dirGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    inn_dir_col,
                    full_name_dir_col
                });
            }
            else if (source.DataMember.Equals("fn_mp_dir"))
            {
                full_name_dir_col.DataPropertyName = "description";
                dirGridView.Columns.Add(full_name_dir_col);
            }            
            dirGridView.DataSource = source;
        }

        private void removeDirColumn(DataGridViewColumn column)
        {
            int i = dirGridView.Columns.IndexOf(column);
            if (i > 0)
            {
                dirGridView.Columns.RemoveAt(i);
            }
        }

        private void dirGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            saveDir(((DataGridView)sender).DataSource as BindingSource);
        }

        private void dirGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            saveDir(((DataGridView)sender).DataSource as BindingSource);
        }

        private void saveDir(BindingSource bs)
        {

            try
            {
                bs.EndEdit();
                this.tableAdapterManager.UpdateAll(this.kktDataSet);
            }
            catch (System.NullReferenceException)
            {
            }
            catch (System.Data.NoNullAllowedException)
            {
            }
            catch (System.Data.DBConcurrencyException)
            {
                MessageBox.Show("Обновите справочники", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.SqlServerCe.SqlCeException)
            {
                MessageBox.Show("Удаление невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void tabPage3_Leave(object sender, EventArgs e)
        {
            FillDir();
            doc_kkmBindingSource.ResetBindings(false);
        }


        //Фильтр
        ToolStripItem searc_box = null;

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searc_box != null)
            {
                doc_headBindingNavigator.Items.Remove(searc_box);
                searc_box.Dispose();
            }
            Type type = ((ComboboxItem)searchComboBox.SelectedItem).itemType;
            if (type == null)
            {
                doc_headBindingSource.Filter = "";
                searc_box = null;
                return;
            }
            else if (type == typeof(DataGridViewTextBoxColumn))
            {
                ToolStripTextBox tb = new ToolStripTextBox();
                tb.BorderStyle = BorderStyle.Fixed3D;
                tb.TextChanged += new EventHandler(tb_TextChanged);
                searc_box = tb;
            }
            else if (type == typeof(DataGridViewCheckBoxColumn))
            {
                CheckBoxToolStripItem cb = new CheckBoxToolStripItem();
                cb.OnChecked += new EventHandler(cb_OnChecked);
                searc_box = cb;
            }
            else if (type == typeof(DataGridViewComboBoxColumn))
            {
                ToolStripComboBox cb = new ToolStripComboBox("search_box");
                cb.FlatStyle = FlatStyle.System;
                foreach (DataRowView row in ((ComboboxItem)searchComboBox.SelectedItem).bindingSource as BindingSource)
                {
                    cb.Items.Add(new ComboboxItem(row["value"].ToString(), row["id"]));
                }
                cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
                searc_box = cb;

            }
            doc_headBindingNavigator.Items.Add(searc_box);
        }

        void cb_OnChecked(object sender, EventArgs e)
        {
            doc_headBindingSource.Filter = String.Format("{0}={1}"
                , ((ComboboxItem)searchComboBox.SelectedItem).Value.ToString(), ((System.Windows.Forms.CheckBox)sender).Checked);
        }

        void tb_TextChanged(object sender, EventArgs e)
        {
            doc_headBindingSource.Filter = String.Format("convert({0}, 'System.String') like '%{1}%'"
                , ((ComboboxItem)searchComboBox.SelectedItem).Value.ToString()
                , ((ToolStripTextBox)sender).Text);
        }

        void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item = ((ToolStripComboBox)sender).SelectedItem as ComboboxItem;
            doc_headBindingSource.Filter = String.Format("{0}={1}"
                , ((ComboboxItem)searchComboBox.SelectedItem).Value.ToString(), item.Value);
        }

        //UI Update
        private void updateDocNumberLabel(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedIndex >= 0)
            {
                DocNumberLabel.Text = String.Format("Договор №{0}/{1}", numberTextBox.Text, yearComboBox.SelectedItem.ToString());
            }
        }

        private void updateSumLabel(object sender, EventArgs e)
        {
            if (service_type_idComboBox.SelectedIndex >= 0 && price_idComboBox.SelectedIndex >= 0)
            {
                int i = int.Parse(((DataRowView)service_type_idComboBox.SelectedItem)["description"].ToString());
                decimal? s = ((DataRowView)price_idComboBox.SelectedItem)["value"] as decimal?;

                if (s.HasValue)
                {
                    decimal p = Math.Round((decimal)s / i, 2);
                    sumLabel.Text = String.Format("Стоимость в месяц: {0} руб.", p);
                    return;
                }
            }
            sumLabel.Text = String.Empty;
        }
                
        private void add_time_button_Click(object sender, EventArgs e)
        {
            int months = Int16.Parse(((System.Windows.Forms.Button)sender).Text);
            data_changeDateTimePicker.Value = data_activationDateTimePicker.Value.AddMonths(months);
            data_changeDateTimePicker.DataBindings[0].WriteValue();
        }

        private void payment_status_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payment_status_idComboBox.SelectedIndex >= 0)
            {
                int i = (int)((DataRowView)payment_status_idComboBox.SelectedItem)["id"];
                if (i == 12)
                {
                    payment_status_idLabel.BackColor = Color.Red;
                    payment_status_idLabel.ForeColor = Color.White;
                    
                }
                else
                {
                    payment_status_idLabel.BackColor = Color.Transparent;
                    payment_status_idLabel.ForeColor = Color.Black;
                }
            }
        }
        

        ReportControl currentReportControl;

        private void reportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentReportControl != null)
            {
                reportPanel.Controls.Remove(currentReportControl);
            }
            currentReportControl = ((ComboboxItem)((ComboBox)sender).SelectedItem).Value as ReportControl;
            reportPanel.Controls.Add(currentReportControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentReportControl != null)
            {
                reportViewer1.Reset();
                currentReportControl.CreateReport();
                LocalReport report = reportViewer1.LocalReport;
                report.ReportPath = currentReportControl.reportPath;
                report.DataSources.Add(currentReportControl.reportDataSource);
                report.SetParameters(currentReportControl.reportParameters);
                reportViewer1.RefreshReport();
            }
        }

        private void NewDocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (this.kktDataSet.HasChanges()){
                if (MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                }
            }
             */
        }

        private void doc_headDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void doc_kkmDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            DataRowView rv = (DataRowView)doc_kkmBindingSource.Current;
            kktDataSet.doc_kkmRow selectedRow = (kktDataSet.doc_kkmRow)rv.Row;
            if (selectedRow.id > 0)
            {
                int currentPosition = doc_kkmBindingSource.Position;
                LocationForm locForm = new LocationForm(selectedRow.id);
                locForm.ShowDialog(this);
                this.doc_kkmTableAdapter.Fill(this.kktDataSet.doc_kkm);
                doc_kkmBindingSource.Position = currentPosition;
            }
        }
        

        

       

    }
}
