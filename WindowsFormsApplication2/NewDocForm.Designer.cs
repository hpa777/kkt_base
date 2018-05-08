namespace WindowsFormsApplication2
{
    partial class NewDocForm
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label data_startLabel;
            System.Windows.Forms.Label data_endLabel;
            System.Windows.Forms.Label service_type_idLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label price_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label innLabel;
            System.Windows.Forms.Label kppLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label memberLabel;
            System.Windows.Forms.Label member_baseLabel;
            System.Windows.Forms.Label ogrnLabel;
            System.Windows.Forms.Label bankLabel;
            System.Windows.Forms.Label bank_accountLabel;
            System.Windows.Forms.Label bank_account_corLabel;
            System.Windows.Forms.Label bikLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label periodLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label model_idLabel;
            System.Windows.Forms.Label master_idLabel;
            System.Windows.Forms.Label numberLabel1;
            System.Windows.Forms.Label data_releaseLabel;
            System.Windows.Forms.Label registration_numberLabel;
            System.Windows.Forms.Label data_registrationLabel;
            System.Windows.Forms.Label fn_num_idLabel;
            System.Windows.Forms.Label data_activationLabel;
            System.Windows.Forms.Label data_changeLabel;
            System.Windows.Forms.Label ofd_idLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label mp_idLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDocForm));
            this.payment_status_idLabel = new System.Windows.Forms.Label();
            this.doc_headBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.AddDocButton = new System.Windows.Forms.ToolStripButton();
            this.doc_headBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kktDataSet = new WindowsFormsApplication2.kktDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteDocButton = new System.Windows.Forms.ToolStripButton();
            this.saveDocButton = new System.Windows.Forms.ToolStripButton();
            this.printButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.doc_headDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_status_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymentstatusdirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberImLabel = new System.Windows.Forms.Label();
            this.memberIMTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.DocNumberLabel = new System.Windows.Forms.Label();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.memberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.data_startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.periodComboBox = new System.Windows.Forms.ComboBox();
            this.member_baseTextBox = new System.Windows.Forms.TextBox();
            this.kppTextBox = new System.Windows.Forms.TextBox();
            this.data_endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_status_idComboBox = new System.Windows.Forms.ComboBox();
            this.ogrnTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.bankTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.unactive_clientCheckBox = new System.Windows.Forms.CheckBox();
            this.bikTextBox = new System.Windows.Forms.TextBox();
            this.bank_accountTextBox = new System.Windows.Forms.TextBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.bank_account_corTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.doc_kkmDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unactive_kkm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.model_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.model_kkm_dirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_type_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.servicetypedirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.price_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pricedirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.masters_dirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofd_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ofd_dirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_kkmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationButton = new System.Windows.Forms.Button();
            this.add_time_button3 = new System.Windows.Forms.Button();
            this.add_time_button2 = new System.Windows.Forms.Button();
            this.add_time_button1 = new System.Windows.Forms.Button();
            this.fn_num_label = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.deleteNumButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.model_idComboBox = new System.Windows.Forms.ComboBox();
            this.master_idComboBox = new System.Windows.Forms.ComboBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox1 = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.data_releaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ofd_idComboBox = new System.Windows.Forms.ComboBox();
            this.registration_numberTextBox = new System.Windows.Forms.TextBox();
            this.data_changeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_registrationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_activationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.service_type_idComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fn_num_idComboBox = new System.Windows.Forms.ComboBox();
            this.fn_number_dirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unactive_kkmCheckBox = new System.Windows.Forms.CheckBox();
            this.price_idComboBox = new System.Windows.Forms.ComboBox();
            this.kktBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.addKkmButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteKkmButton = new System.Windows.Forms.ToolStripButton();
            this.saveKkmButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.заявлениеОРегистрацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заявлениеОСнятииСРегистрацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dirGridView = new System.Windows.Forms.DataGridView();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportComboBox = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.fn_mp_dirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.doc_headTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.doc_headTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.kktDataSetTableAdapters.TableAdapterManager();
            this.doc_kkmTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.doc_kkmTableAdapter();
            this.fn_mp_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.fn_mp_dirTableAdapter();
            this.fn_number_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.fn_number_dirTableAdapter();
            this.masters_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.masters_dirTableAdapter();
            this.model_kkm_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.model_kkm_dirTableAdapter();
            this.ofd_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.ofd_dirTableAdapter();
            this.payment_status_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.payment_status_dirTableAdapter();
            this.price_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.price_dirTableAdapter();
            this.service_type_dirTableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.service_type_dirTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.reportDataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataTable1TableAdapter = new WindowsFormsApplication2.kktDataSetTableAdapters.reportDataTable1TableAdapter();
            this.mpComboBox = new System.Windows.Forms.ComboBox();
            numberLabel = new System.Windows.Forms.Label();
            data_startLabel = new System.Windows.Forms.Label();
            data_endLabel = new System.Windows.Forms.Label();
            service_type_idLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            price_idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            innLabel = new System.Windows.Forms.Label();
            kppLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            memberLabel = new System.Windows.Forms.Label();
            member_baseLabel = new System.Windows.Forms.Label();
            ogrnLabel = new System.Windows.Forms.Label();
            bankLabel = new System.Windows.Forms.Label();
            bank_accountLabel = new System.Windows.Forms.Label();
            bank_account_corLabel = new System.Windows.Forms.Label();
            bikLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            periodLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            model_idLabel = new System.Windows.Forms.Label();
            master_idLabel = new System.Windows.Forms.Label();
            numberLabel1 = new System.Windows.Forms.Label();
            data_releaseLabel = new System.Windows.Forms.Label();
            registration_numberLabel = new System.Windows.Forms.Label();
            data_registrationLabel = new System.Windows.Forms.Label();
            fn_num_idLabel = new System.Windows.Forms.Label();
            data_activationLabel = new System.Windows.Forms.Label();
            data_changeLabel = new System.Windows.Forms.Label();
            ofd_idLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            mp_idLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doc_headBindingNavigator)).BeginInit();
            this.doc_headBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doc_headBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kktDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doc_headDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentstatusdirBindingSource)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doc_kkmDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_kkm_dirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicetypedirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricedirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masters_dirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofd_dirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc_kkmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fn_number_dirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kktBindingNavigator)).BeginInit();
            this.kktBindingNavigator.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dirGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fn_mp_dirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.Location = new System.Drawing.Point(13, 49);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(59, 20);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "№ дог.";
            // 
            // data_startLabel
            // 
            data_startLabel.AutoSize = true;
            data_startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_startLabel.Location = new System.Drawing.Point(235, 49);
            data_startLabel.Name = "data_startLabel";
            data_startLabel.Size = new System.Drawing.Size(85, 20);
            data_startLabel.TabIndex = 4;
            data_startLabel.Text = "Нач. дата";
            // 
            // data_endLabel
            // 
            data_endLabel.AutoSize = true;
            data_endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_endLabel.Location = new System.Drawing.Point(235, 73);
            data_endLabel.Name = "data_endLabel";
            data_endLabel.Size = new System.Drawing.Size(83, 20);
            data_endLabel.TabIndex = 6;
            data_endLabel.Text = "Кон. дата";
            // 
            // service_type_idLabel
            // 
            service_type_idLabel.AutoSize = true;
            service_type_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            service_type_idLabel.Location = new System.Drawing.Point(38, 177);
            service_type_idLabel.Name = "service_type_idLabel";
            service_type_idLabel.Size = new System.Drawing.Size(61, 20);
            service_type_idLabel.TabIndex = 8;
            service_type_idLabel.Text = "Тип ТО";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            yearLabel.Location = new System.Drawing.Point(13, 76);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(73, 20);
            yearLabel.TabIndex = 13;
            yearLabel.Text = "Год дог.";
            // 
            // price_idLabel
            // 
            price_idLabel.AutoSize = true;
            price_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            price_idLabel.Location = new System.Drawing.Point(6, 211);
            price_idLabel.Name = "price_idLabel";
            price_idLabel.Size = new System.Drawing.Size(93, 20);
            price_idLabel.TabIndex = 14;
            price_idLabel.Text = "Стоимость";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(13, 106);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(83, 20);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "Название";
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            innLabel.Location = new System.Drawing.Point(13, 170);
            innLabel.Name = "innLabel";
            innLabel.Size = new System.Drawing.Size(44, 20);
            innLabel.TabIndex = 17;
            innLabel.Text = "ИНН";
            // 
            // kppLabel
            // 
            kppLabel.AutoSize = true;
            kppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kppLabel.Location = new System.Drawing.Point(271, 170);
            kppLabel.Name = "kppLabel";
            kppLabel.Size = new System.Drawing.Size(43, 20);
            kppLabel.TabIndex = 19;
            kppLabel.Text = "КПП";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(13, 202);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(86, 20);
            addressLabel.TabIndex = 21;
            addressLabel.Text = "Юр. адрес";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(13, 234);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(79, 20);
            phoneLabel.TabIndex = 23;
            phoneLabel.Text = "Телефон";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            faxLabel.Location = new System.Drawing.Point(271, 234);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(49, 20);
            faxLabel.TabIndex = 25;
            faxLabel.Text = "Факс";
            // 
            // memberLabel
            // 
            memberLabel.AutoSize = true;
            memberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            memberLabel.Location = new System.Drawing.Point(13, 266);
            memberLabel.Name = "memberLabel";
            memberLabel.Size = new System.Drawing.Size(61, 20);
            memberLabel.TabIndex = 27;
            memberLabel.Text = "В лице";
            // 
            // member_baseLabel
            // 
            member_baseLabel.AutoSize = true;
            member_baseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            member_baseLabel.Location = new System.Drawing.Point(13, 336);
            member_baseLabel.Name = "member_baseLabel";
            member_baseLabel.Size = new System.Drawing.Size(89, 40);
            member_baseLabel.TabIndex = 29;
            member_baseLabel.Text = "На\r\nосновании";
            // 
            // ogrnLabel
            // 
            ogrnLabel.AutoSize = true;
            ogrnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ogrnLabel.Location = new System.Drawing.Point(13, 375);
            ogrnLabel.Name = "ogrnLabel";
            ogrnLabel.Size = new System.Drawing.Size(52, 20);
            ogrnLabel.TabIndex = 31;
            ogrnLabel.Text = "ОГРН";
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bankLabel.Location = new System.Drawing.Point(13, 407);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(46, 20);
            bankLabel.TabIndex = 33;
            bankLabel.Text = "Банк";
            // 
            // bank_accountLabel
            // 
            bank_accountLabel.AutoSize = true;
            bank_accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bank_accountLabel.Location = new System.Drawing.Point(13, 442);
            bank_accountLabel.Name = "bank_accountLabel";
            bank_accountLabel.Size = new System.Drawing.Size(40, 20);
            bank_accountLabel.TabIndex = 35;
            bank_accountLabel.Text = "Р/сч";
            // 
            // bank_account_corLabel
            // 
            bank_account_corLabel.AutoSize = true;
            bank_account_corLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bank_account_corLabel.Location = new System.Drawing.Point(13, 471);
            bank_account_corLabel.Name = "bank_account_corLabel";
            bank_account_corLabel.Size = new System.Drawing.Size(40, 20);
            bank_account_corLabel.TabIndex = 37;
            bank_account_corLabel.Text = "К/сч";
            // 
            // bikLabel
            // 
            bikLabel.AutoSize = true;
            bikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            bikLabel.Location = new System.Drawing.Point(338, 439);
            bikLabel.Name = "bikLabel";
            bikLabel.Size = new System.Drawing.Size(41, 20);
            bikLabel.TabIndex = 39;
            bikLabel.Text = "БИК";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(13, 503);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(53, 20);
            emailLabel.TabIndex = 41;
            emailLabel.Text = "E-Mail";
            // 
            // periodLabel
            // 
            periodLabel.AutoSize = true;
            periodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            periodLabel.Location = new System.Drawing.Point(296, 535);
            periodLabel.Name = "periodLabel";
            periodLabel.Size = new System.Drawing.Size(68, 20);
            periodLabel.TabIndex = 45;
            periodLabel.Text = "Период";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(104, 563);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(329, 20);
            descriptionLabel.TabIndex = 47;
            descriptionLabel.Text = "Дополнительная информация по клиенту";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            locationLabel.Location = new System.Drawing.Point(13, 30);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(86, 40);
            locationLabel.TabIndex = 0;
            locationLabel.Text = "Место\r\nустановки";
            // 
            // model_idLabel
            // 
            model_idLabel.AutoSize = true;
            model_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            model_idLabel.Location = new System.Drawing.Point(27, 79);
            model_idLabel.Name = "model_idLabel";
            model_idLabel.Size = new System.Drawing.Size(70, 20);
            model_idLabel.TabIndex = 2;
            model_idLabel.Text = "Модель";
            // 
            // master_idLabel
            // 
            master_idLabel.AutoSize = true;
            master_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            master_idLabel.Location = new System.Drawing.Point(354, 79);
            master_idLabel.Name = "master_idLabel";
            master_idLabel.Size = new System.Drawing.Size(66, 20);
            master_idLabel.TabIndex = 4;
            master_idLabel.Text = "Мастер";
            // 
            // numberLabel1
            // 
            numberLabel1.AutoSize = true;
            numberLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel1.Location = new System.Drawing.Point(36, 113);
            numberLabel1.Name = "numberLabel1";
            numberLabel1.Size = new System.Drawing.Size(57, 20);
            numberLabel1.TabIndex = 6;
            numberLabel1.Text = "Зав.№";
            // 
            // data_releaseLabel
            // 
            data_releaseLabel.AutoSize = true;
            data_releaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_releaseLabel.Location = new System.Drawing.Point(350, 102);
            data_releaseLabel.Name = "data_releaseLabel";
            data_releaseLabel.Size = new System.Drawing.Size(70, 40);
            data_releaseLabel.TabIndex = 8;
            data_releaseLabel.Text = "Дата\r\nвыпуска\r\n";
            data_releaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // registration_numberLabel
            // 
            registration_numberLabel.AutoSize = true;
            registration_numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            registration_numberLabel.Location = new System.Drawing.Point(39, 145);
            registration_numberLabel.Name = "registration_numberLabel";
            registration_numberLabel.Size = new System.Drawing.Size(54, 20);
            registration_numberLabel.TabIndex = 10;
            registration_numberLabel.Text = "Рег.№";
            // 
            // data_registrationLabel
            // 
            data_registrationLabel.AutoSize = true;
            data_registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_registrationLabel.Location = new System.Drawing.Point(319, 142);
            data_registrationLabel.Name = "data_registrationLabel";
            data_registrationLabel.Size = new System.Drawing.Size(105, 40);
            data_registrationLabel.TabIndex = 12;
            data_registrationLabel.Text = "Дата\r\nрегистрации\r\n";
            data_registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fn_num_idLabel
            // 
            fn_num_idLabel.AutoSize = true;
            fn_num_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fn_num_idLabel.Location = new System.Drawing.Point(36, 263);
            fn_num_idLabel.Name = "fn_num_idLabel";
            fn_num_idLabel.Size = new System.Drawing.Size(57, 20);
            fn_num_idLabel.TabIndex = 16;
            fn_num_idLabel.Text = "Зав.№";
            // 
            // data_activationLabel
            // 
            data_activationLabel.AutoSize = true;
            data_activationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_activationLabel.Location = new System.Drawing.Point(4, 310);
            data_activationLabel.Name = "data_activationLabel";
            data_activationLabel.Size = new System.Drawing.Size(89, 40);
            data_activationLabel.TabIndex = 18;
            data_activationLabel.Text = "Дата\r\nактивации\r\n";
            data_activationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // data_changeLabel
            // 
            data_changeLabel.AutoSize = true;
            data_changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            data_changeLabel.Location = new System.Drawing.Point(278, 326);
            data_changeLabel.Name = "data_changeLabel";
            data_changeLabel.Size = new System.Drawing.Size(109, 20);
            data_changeLabel.TabIndex = 20;
            data_changeLabel.Text = "Дата замены";
            // 
            // ofd_idLabel
            // 
            ofd_idLabel.AutoSize = true;
            ofd_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ofd_idLabel.Location = new System.Drawing.Point(45, 356);
            ofd_idLabel.Name = "ofd_idLabel";
            ofd_idLabel.Size = new System.Drawing.Size(48, 20);
            ofd_idLabel.TabIndex = 22;
            ofd_idLabel.Text = "ОФД";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginLabel.Location = new System.Drawing.Point(38, 390);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(55, 20);
            loginLabel.TabIndex = 24;
            loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.Location = new System.Drawing.Point(344, 390);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(67, 20);
            passwordLabel.TabIndex = 26;
            passwordLabel.Text = "Пароль";
            // 
            // mp_idLabel
            // 
            mp_idLabel.AutoSize = true;
            mp_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mp_idLabel.Location = new System.Drawing.Point(59, 425);
            mp_idLabel.Name = "mp_idLabel";
            mp_idLabel.Size = new System.Drawing.Size(34, 20);
            mp_idLabel.TabIndex = 28;
            mp_idLabel.Text = "МП";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel1.Location = new System.Drawing.Point(99, 454);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(301, 20);
            descriptionLabel1.TabIndex = 30;
            descriptionLabel1.Text = "Дополнительная информация по ККМ";
            // 
            // payment_status_idLabel
            // 
            this.payment_status_idLabel.AutoSize = true;
            this.payment_status_idLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.payment_status_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payment_status_idLabel.Location = new System.Drawing.Point(13, 535);
            this.payment_status_idLabel.Name = "payment_status_idLabel";
            this.payment_status_idLabel.Size = new System.Drawing.Size(67, 20);
            this.payment_status_idLabel.TabIndex = 43;
            this.payment_status_idLabel.Text = "Оплата";
            // 
            // doc_headBindingNavigator
            // 
            this.doc_headBindingNavigator.AddNewItem = this.AddDocButton;
            this.doc_headBindingNavigator.BindingSource = this.doc_headBindingSource;
            this.doc_headBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doc_headBindingNavigator.DeleteItem = null;
            this.doc_headBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.doc_headBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.AddDocButton,
            this.deleteDocButton,
            this.saveDocButton,
            this.printButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.searchComboBox});
            this.doc_headBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doc_headBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doc_headBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doc_headBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doc_headBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doc_headBindingNavigator.Name = "doc_headBindingNavigator";
            this.doc_headBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doc_headBindingNavigator.Size = new System.Drawing.Size(599, 25);
            this.doc_headBindingNavigator.TabIndex = 1;
            this.doc_headBindingNavigator.Text = "bindingNavigator1";
            // 
            // AddDocButton
            // 
            this.AddDocButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddDocButton.Enabled = false;
            this.AddDocButton.Image = ((System.Drawing.Image)(resources.GetObject("AddDocButton.Image")));
            this.AddDocButton.Name = "AddDocButton";
            this.AddDocButton.RightToLeftAutoMirrorImage = true;
            this.AddDocButton.Size = new System.Drawing.Size(23, 22);
            this.AddDocButton.Text = "Добавить";
            this.AddDocButton.Click += new System.EventHandler(this.addDocButton_Click);
            // 
            // doc_headBindingSource
            // 
            this.doc_headBindingSource.DataMember = "doc_head";
            this.doc_headBindingSource.DataSource = this.kktDataSet;
            this.doc_headBindingSource.CurrentChanged += new System.EventHandler(this.doc_headBindingSource_CurrentChanged);
            // 
            // kktDataSet
            // 
            this.kktDataSet.DataSetName = "kktDataSet";
            this.kktDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteDocButton
            // 
            this.deleteDocButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteDocButton.Enabled = false;
            this.deleteDocButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteDocButton.Image")));
            this.deleteDocButton.Name = "deleteDocButton";
            this.deleteDocButton.RightToLeftAutoMirrorImage = true;
            this.deleteDocButton.Size = new System.Drawing.Size(23, 22);
            this.deleteDocButton.Text = "Удалить";
            this.deleteDocButton.Click += new System.EventHandler(this.DeleteDocButton_Click);
            // 
            // saveDocButton
            // 
            this.saveDocButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveDocButton.Enabled = false;
            this.saveDocButton.Image = ((System.Drawing.Image)(resources.GetObject("saveDocButton.Image")));
            this.saveDocButton.Name = "saveDocButton";
            this.saveDocButton.Size = new System.Drawing.Size(23, 22);
            this.saveDocButton.Text = "Сохранить данные";
            this.saveDocButton.Click += new System.EventHandler(this.saveDocButton_Click);
            // 
            // printButton
            // 
            this.printButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(23, 22);
            this.printButton.Text = "Печать договора";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            // 
            // searchComboBox
            // 
            this.searchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(150, 25);
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1261, 930);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1253, 904);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Договор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.doc_headBindingNavigator);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.Controls.Add(this.kktBindingNavigator);
            this.splitContainer1.Size = new System.Drawing.Size(1247, 898);
            this.splitContainer1.SplitterDistance = 599;
            this.splitContainer1.TabIndex = 49;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 25);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.doc_headDataGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.memberImLabel);
            this.splitContainer2.Panel2.Controls.Add(this.memberIMTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.fullNameTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.DocNumberLabel);
            this.splitContainer2.Panel2.Controls.Add(phoneLabel);
            this.splitContainer2.Panel2.Controls.Add(this.faxTextBox);
            this.splitContainer2.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer2.Panel2.Controls.Add(this.phoneTextBox);
            this.splitContainer2.Panel2.Controls.Add(faxLabel);
            this.splitContainer2.Panel2.Controls.Add(this.numberTextBox);
            this.splitContainer2.Panel2.Controls.Add(addressLabel);
            this.splitContainer2.Panel2.Controls.Add(this.descriptionRichTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.memberTextBox);
            this.splitContainer2.Panel2.Controls.Add(numberLabel);
            this.splitContainer2.Panel2.Controls.Add(this.addressTextBox);
            this.splitContainer2.Panel2.Controls.Add(periodLabel);
            this.splitContainer2.Panel2.Controls.Add(memberLabel);
            this.splitContainer2.Panel2.Controls.Add(this.data_startDateTimePicker);
            this.splitContainer2.Panel2.Controls.Add(kppLabel);
            this.splitContainer2.Panel2.Controls.Add(this.periodComboBox);
            this.splitContainer2.Panel2.Controls.Add(this.member_baseTextBox);
            this.splitContainer2.Panel2.Controls.Add(data_startLabel);
            this.splitContainer2.Panel2.Controls.Add(this.kppTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.payment_status_idLabel);
            this.splitContainer2.Panel2.Controls.Add(member_baseLabel);
            this.splitContainer2.Panel2.Controls.Add(this.data_endDateTimePicker);
            this.splitContainer2.Panel2.Controls.Add(innLabel);
            this.splitContainer2.Panel2.Controls.Add(this.payment_status_idComboBox);
            this.splitContainer2.Panel2.Controls.Add(this.ogrnTextBox);
            this.splitContainer2.Panel2.Controls.Add(data_endLabel);
            this.splitContainer2.Panel2.Controls.Add(this.innTextBox);
            this.splitContainer2.Panel2.Controls.Add(emailLabel);
            this.splitContainer2.Panel2.Controls.Add(ogrnLabel);
            this.splitContainer2.Panel2.Controls.Add(nameLabel);
            this.splitContainer2.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.bankTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.nameTextBox);
            this.splitContainer2.Panel2.Controls.Add(bikLabel);
            this.splitContainer2.Panel2.Controls.Add(bankLabel);
            this.splitContainer2.Panel2.Controls.Add(this.unactive_clientCheckBox);
            this.splitContainer2.Panel2.Controls.Add(this.bikTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.bank_accountTextBox);
            this.splitContainer2.Panel2.Controls.Add(bank_account_corLabel);
            this.splitContainer2.Panel2.Controls.Add(bank_accountLabel);
            this.splitContainer2.Panel2.Controls.Add(this.yearComboBox);
            this.splitContainer2.Panel2.Controls.Add(yearLabel);
            this.splitContainer2.Panel2.Controls.Add(this.bank_account_corTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(599, 873);
            this.splitContainer2.SplitterDistance = 192;
            this.splitContainer2.TabIndex = 52;
            // 
            // doc_headDataGridView
            // 
            this.doc_headDataGridView.AllowUserToAddRows = false;
            this.doc_headDataGridView.AllowUserToDeleteRows = false;
            this.doc_headDataGridView.AllowUserToOrderColumns = true;
            this.doc_headDataGridView.AutoGenerateColumns = false;
            this.doc_headDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doc_headDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.payment_status_id,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.doc_headDataGridView.DataSource = this.doc_headBindingSource;
            this.doc_headDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doc_headDataGridView.Location = new System.Drawing.Point(0, 0);
            this.doc_headDataGridView.Name = "doc_headDataGridView";
            this.doc_headDataGridView.ReadOnly = true;
            this.doc_headDataGridView.Size = new System.Drawing.Size(599, 192);
            this.doc_headDataGridView.TabIndex = 50;
            this.doc_headDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.doc_headDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn4.HeaderText = "№ дог.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn12.HeaderText = "Год дог.";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "unactive_client";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Расторгнут договор с клиентом";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn22.HeaderText = "Название";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "data_start";
            this.dataGridViewTextBoxColumn18.HeaderText = "Нач.дата";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "data_end";
            this.dataGridViewTextBoxColumn19.HeaderText = "Кон.дата";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "inn";
            this.dataGridViewTextBoxColumn23.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "kpp";
            this.dataGridViewTextBoxColumn24.HeaderText = "КПП";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn25.HeaderText = "Юр. адрес";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn26.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "fax";
            this.dataGridViewTextBoxColumn27.HeaderText = "Факс";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "member";
            this.dataGridViewTextBoxColumn28.HeaderText = "В лице";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "member base";
            this.dataGridViewTextBoxColumn29.HeaderText = "На основании";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "ogrn";
            this.dataGridViewTextBoxColumn30.HeaderText = "ОГРН";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "bank";
            this.dataGridViewTextBoxColumn31.HeaderText = "Банк";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "bank_account";
            this.dataGridViewTextBoxColumn32.HeaderText = "Р/сч";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "bank_account_cor";
            this.dataGridViewTextBoxColumn33.HeaderText = "К/сч";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "bik";
            this.dataGridViewTextBoxColumn34.HeaderText = "БИК";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn35.HeaderText = "email";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            // 
            // payment_status_id
            // 
            this.payment_status_id.DataPropertyName = "payment_status_id";
            this.payment_status_id.DataSource = this.paymentstatusdirBindingSource;
            this.payment_status_id.DisplayMember = "value";
            this.payment_status_id.HeaderText = "Оплата";
            this.payment_status_id.Name = "payment_status_id";
            this.payment_status_id.ReadOnly = true;
            this.payment_status_id.ValueMember = "id";
            // 
            // paymentstatusdirBindingSource
            // 
            this.paymentstatusdirBindingSource.DataMember = "payment_status_dir";
            this.paymentstatusdirBindingSource.DataSource = this.kktDataSet;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "period";
            this.dataGridViewTextBoxColumn37.HeaderText = "Период";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn38.HeaderText = "Доп.инфо.";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // memberImLabel
            // 
            this.memberImLabel.AutoSize = true;
            this.memberImLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memberImLabel.Location = new System.Drawing.Point(12, 291);
            this.memberImLabel.Name = "memberImLabel";
            this.memberImLabel.Size = new System.Drawing.Size(81, 40);
            this.memberImLabel.TabIndex = 55;
            this.memberImLabel.Text = "Предста-\r\nвитель";
            // 
            // memberIMTextBox
            // 
            this.memberIMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "member_im", true));
            this.memberIMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memberIMTextBox.Location = new System.Drawing.Point(108, 295);
            this.memberIMTextBox.Name = "memberIMTextBox";
            this.memberIMTextBox.Size = new System.Drawing.Size(487, 26);
            this.memberIMTextBox.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 40);
            this.label4.TabIndex = 53;
            this.label4.Text = "Полное\r\nназвание";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "full_name", true));
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameTextBox.Location = new System.Drawing.Point(108, 135);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(487, 26);
            this.fullNameTextBox.TabIndex = 52;
            // 
            // DocNumberLabel
            // 
            this.DocNumberLabel.AutoSize = true;
            this.DocNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocNumberLabel.Location = new System.Drawing.Point(194, 6);
            this.DocNumberLabel.Name = "DocNumberLabel";
            this.DocNumberLabel.Size = new System.Drawing.Size(122, 24);
            this.DocNumberLabel.TabIndex = 51;
            this.DocNumberLabel.Text = "Договор №";
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "fax", true));
            this.faxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faxTextBox.Location = new System.Drawing.Point(326, 231);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(169, 26);
            this.faxTextBox.TabIndex = 26;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(108, 231);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(130, 26);
            this.phoneTextBox.TabIndex = 24;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "number", true));
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.Location = new System.Drawing.Point(108, 44);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 26);
            this.numberTextBox.TabIndex = 1;
            this.numberTextBox.TextChanged += new System.EventHandler(this.updateDocNumberLabel);
            this.numberTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "description", true));
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(108, 586);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(487, 43);
            this.descriptionRichTextBox.TabIndex = 48;
            this.descriptionRichTextBox.Text = "";
            // 
            // memberTextBox
            // 
            this.memberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "member", true));
            this.memberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memberTextBox.Location = new System.Drawing.Point(108, 263);
            this.memberTextBox.Name = "memberTextBox";
            this.memberTextBox.Size = new System.Drawing.Size(487, 26);
            this.memberTextBox.TabIndex = 28;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(108, 199);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(487, 26);
            this.addressTextBox.TabIndex = 22;
            // 
            // data_startDateTimePicker
            // 
            this.data_startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doc_headBindingSource, "data_start", true));
            this.data_startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_startDateTimePicker.Location = new System.Drawing.Point(326, 44);
            this.data_startDateTimePicker.Name = "data_startDateTimePicker";
            this.data_startDateTimePicker.Size = new System.Drawing.Size(169, 26);
            this.data_startDateTimePicker.TabIndex = 5;
            // 
            // periodComboBox
            // 
            this.periodComboBox.CausesValidation = false;
            this.periodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "period", true));
            this.periodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.periodComboBox.FormattingEnabled = true;
            this.periodComboBox.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "1 квартал",
            "апрель",
            "май",
            "июнь",
            "2 квартал",
            "полгода",
            "июль",
            "август",
            "сентябрь",
            "3 квартал",
            "октябрь",
            "ноябрь",
            "декабрь",
            "4 квартал",
            "год"});
            this.periodComboBox.Location = new System.Drawing.Point(370, 532);
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(225, 28);
            this.periodComboBox.TabIndex = 46;
            // 
            // member_baseTextBox
            // 
            this.member_baseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "member base", true));
            this.member_baseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.member_baseTextBox.Location = new System.Drawing.Point(108, 340);
            this.member_baseTextBox.Name = "member_baseTextBox";
            this.member_baseTextBox.Size = new System.Drawing.Size(487, 26);
            this.member_baseTextBox.TabIndex = 30;
            // 
            // kppTextBox
            // 
            this.kppTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "kpp", true));
            this.kppTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kppTextBox.Location = new System.Drawing.Point(326, 167);
            this.kppTextBox.Name = "kppTextBox";
            this.kppTextBox.Size = new System.Drawing.Size(169, 26);
            this.kppTextBox.TabIndex = 20;
            // 
            // data_endDateTimePicker
            // 
            this.data_endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doc_headBindingSource, "data_end", true));
            this.data_endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_endDateTimePicker.Location = new System.Drawing.Point(326, 76);
            this.data_endDateTimePicker.Name = "data_endDateTimePicker";
            this.data_endDateTimePicker.Size = new System.Drawing.Size(169, 26);
            this.data_endDateTimePicker.TabIndex = 7;
            // 
            // payment_status_idComboBox
            // 
            this.payment_status_idComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.payment_status_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doc_headBindingSource, "payment_status_id", true));
            this.payment_status_idComboBox.DataSource = this.paymentstatusdirBindingSource;
            this.payment_status_idComboBox.DisplayMember = "value";
            this.payment_status_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payment_status_idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payment_status_idComboBox.FormattingEnabled = true;
            this.payment_status_idComboBox.Location = new System.Drawing.Point(108, 532);
            this.payment_status_idComboBox.Name = "payment_status_idComboBox";
            this.payment_status_idComboBox.Size = new System.Drawing.Size(173, 28);
            this.payment_status_idComboBox.TabIndex = 44;
            this.payment_status_idComboBox.ValueMember = "id";
            this.payment_status_idComboBox.SelectedIndexChanged += new System.EventHandler(this.payment_status_idComboBox_SelectedIndexChanged);
            // 
            // ogrnTextBox
            // 
            this.ogrnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "ogrn", true));
            this.ogrnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ogrnTextBox.Location = new System.Drawing.Point(108, 372);
            this.ogrnTextBox.Name = "ogrnTextBox";
            this.ogrnTextBox.Size = new System.Drawing.Size(224, 26);
            this.ogrnTextBox.TabIndex = 32;
            // 
            // innTextBox
            // 
            this.innTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "inn", true));
            this.innTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.innTextBox.Location = new System.Drawing.Point(108, 167);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(130, 26);
            this.innTextBox.TabIndex = 18;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(108, 500);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(224, 26);
            this.emailTextBox.TabIndex = 42;
            // 
            // bankTextBox
            // 
            this.bankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "bank", true));
            this.bankTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankTextBox.Location = new System.Drawing.Point(108, 404);
            this.bankTextBox.Name = "bankTextBox";
            this.bankTextBox.Size = new System.Drawing.Size(487, 26);
            this.bankTextBox.TabIndex = 34;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(108, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(487, 26);
            this.nameTextBox.TabIndex = 16;
            this.nameTextBox.Validated += new System.EventHandler(this.TextBox_Validated);
            // 
            // unactive_clientCheckBox
            // 
            this.unactive_clientCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.doc_headBindingSource, "unactive_client", true));
            this.unactive_clientCheckBox.Location = new System.Drawing.Point(26, 9);
            this.unactive_clientCheckBox.Name = "unactive_clientCheckBox";
            this.unactive_clientCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unactive_clientCheckBox.Size = new System.Drawing.Size(138, 24);
            this.unactive_clientCheckBox.TabIndex = 12;
            this.unactive_clientCheckBox.Text = "Договор расторгнут";
            this.unactive_clientCheckBox.UseVisualStyleBackColor = true;
            // 
            // bikTextBox
            // 
            this.bikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "bik", true));
            this.bikTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bikTextBox.Location = new System.Drawing.Point(380, 436);
            this.bikTextBox.Name = "bikTextBox";
            this.bikTextBox.Size = new System.Drawing.Size(215, 26);
            this.bikTextBox.TabIndex = 40;
            // 
            // bank_accountTextBox
            // 
            this.bank_accountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "bank_account", true));
            this.bank_accountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bank_accountTextBox.Location = new System.Drawing.Point(108, 436);
            this.bank_accountTextBox.Name = "bank_accountTextBox";
            this.bank_accountTextBox.Size = new System.Drawing.Size(224, 26);
            this.bank_accountTextBox.TabIndex = 36;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "year", true));
            this.yearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.yearComboBox.Location = new System.Drawing.Point(108, 73);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(100, 28);
            this.yearComboBox.TabIndex = 14;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.updateDocNumberLabel);
            this.yearComboBox.Validated += new System.EventHandler(this.ComboBox_Validated);
            // 
            // bank_account_corTextBox
            // 
            this.bank_account_corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_headBindingSource, "bank_account_cor", true));
            this.bank_account_corTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bank_account_corTextBox.Location = new System.Drawing.Point(108, 468);
            this.bank_account_corTextBox.Name = "bank_account_corTextBox";
            this.bank_account_corTextBox.Size = new System.Drawing.Size(224, 26);
            this.bank_account_corTextBox.TabIndex = 38;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 25);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.doc_kkmDataGridView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.mpComboBox);
            this.splitContainer3.Panel2.Controls.Add(this.locationButton);
            this.splitContainer3.Panel2.Controls.Add(this.add_time_button3);
            this.splitContainer3.Panel2.Controls.Add(this.add_time_button2);
            this.splitContainer3.Panel2.Controls.Add(this.add_time_button1);
            this.splitContainer3.Panel2.Controls.Add(this.fn_num_label);
            this.splitContainer3.Panel2.Controls.Add(this.sumLabel);
            this.splitContainer3.Panel2.Controls.Add(this.deleteNumButton);
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Panel2.Controls.Add(this.locationTextBox);
            this.splitContainer3.Panel2.Controls.Add(descriptionLabel1);
            this.splitContainer3.Panel2.Controls.Add(locationLabel);
            this.splitContainer3.Panel2.Controls.Add(this.descriptionRichTextBox1);
            this.splitContainer3.Panel2.Controls.Add(this.model_idComboBox);
            this.splitContainer3.Panel2.Controls.Add(mp_idLabel);
            this.splitContainer3.Panel2.Controls.Add(model_idLabel);
            this.splitContainer3.Panel2.Controls.Add(this.master_idComboBox);
            this.splitContainer3.Panel2.Controls.Add(passwordLabel);
            this.splitContainer3.Panel2.Controls.Add(master_idLabel);
            this.splitContainer3.Panel2.Controls.Add(this.passwordTextBox);
            this.splitContainer3.Panel2.Controls.Add(this.numberTextBox1);
            this.splitContainer3.Panel2.Controls.Add(loginLabel);
            this.splitContainer3.Panel2.Controls.Add(numberLabel1);
            this.splitContainer3.Panel2.Controls.Add(this.loginTextBox);
            this.splitContainer3.Panel2.Controls.Add(this.data_releaseDateTimePicker);
            this.splitContainer3.Panel2.Controls.Add(ofd_idLabel);
            this.splitContainer3.Panel2.Controls.Add(data_releaseLabel);
            this.splitContainer3.Panel2.Controls.Add(this.ofd_idComboBox);
            this.splitContainer3.Panel2.Controls.Add(this.registration_numberTextBox);
            this.splitContainer3.Panel2.Controls.Add(data_changeLabel);
            this.splitContainer3.Panel2.Controls.Add(registration_numberLabel);
            this.splitContainer3.Panel2.Controls.Add(this.data_changeDateTimePicker);
            this.splitContainer3.Panel2.Controls.Add(this.data_registrationDateTimePicker);
            this.splitContainer3.Panel2.Controls.Add(data_activationLabel);
            this.splitContainer3.Panel2.Controls.Add(data_registrationLabel);
            this.splitContainer3.Panel2.Controls.Add(this.data_activationDateTimePicker);
            this.splitContainer3.Panel2.Controls.Add(this.service_type_idComboBox);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(fn_num_idLabel);
            this.splitContainer3.Panel2.Controls.Add(this.fn_num_idComboBox);
            this.splitContainer3.Panel2.Controls.Add(service_type_idLabel);
            this.splitContainer3.Panel2.Controls.Add(this.unactive_kkmCheckBox);
            this.splitContainer3.Panel2.Controls.Add(this.price_idComboBox);
            this.splitContainer3.Panel2.Controls.Add(price_idLabel);
            this.splitContainer3.Size = new System.Drawing.Size(644, 873);
            this.splitContainer3.SplitterDistance = 192;
            this.splitContainer3.TabIndex = 34;
            // 
            // doc_kkmDataGridView
            // 
            this.doc_kkmDataGridView.AllowUserToAddRows = false;
            this.doc_kkmDataGridView.AllowUserToDeleteRows = false;
            this.doc_kkmDataGridView.AllowUserToOrderColumns = true;
            this.doc_kkmDataGridView.AutoGenerateColumns = false;
            this.doc_kkmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doc_kkmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.unactive_kkm,
            this.model_id,
            this.service_type_id,
            this.price_id,
            this.master_id,
            this.dataGridViewTextBoxColumn5,
            this.ofd_id,
            this.dataGridViewTextBoxColumn16});
            this.doc_kkmDataGridView.DataSource = this.doc_kkmBindingSource;
            this.doc_kkmDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doc_kkmDataGridView.Location = new System.Drawing.Point(0, 0);
            this.doc_kkmDataGridView.Name = "doc_kkmDataGridView";
            this.doc_kkmDataGridView.ReadOnly = true;
            this.doc_kkmDataGridView.Size = new System.Drawing.Size(644, 192);
            this.doc_kkmDataGridView.TabIndex = 33;
            this.doc_kkmDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.doc_kkmDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // unactive_kkm
            // 
            this.unactive_kkm.DataPropertyName = "unactive_kkm";
            this.unactive_kkm.HeaderText = "Расторгнут договор";
            this.unactive_kkm.Name = "unactive_kkm";
            this.unactive_kkm.ReadOnly = true;
            // 
            // model_id
            // 
            this.model_id.DataPropertyName = "model_id";
            this.model_id.DataSource = this.model_kkm_dirBindingSource;
            this.model_id.DisplayMember = "value";
            this.model_id.HeaderText = "Модель";
            this.model_id.Name = "model_id";
            this.model_id.ReadOnly = true;
            this.model_id.ValueMember = "id";
            // 
            // model_kkm_dirBindingSource
            // 
            this.model_kkm_dirBindingSource.DataMember = "model_kkm_dir";
            this.model_kkm_dirBindingSource.DataSource = this.kktDataSet;
            // 
            // service_type_id
            // 
            this.service_type_id.DataPropertyName = "service_type_id";
            this.service_type_id.DataSource = this.servicetypedirBindingSource;
            this.service_type_id.DisplayMember = "value";
            this.service_type_id.HeaderText = "Тип ТО";
            this.service_type_id.Name = "service_type_id";
            this.service_type_id.ReadOnly = true;
            this.service_type_id.ValueMember = "id";
            // 
            // servicetypedirBindingSource
            // 
            this.servicetypedirBindingSource.DataMember = "service_type_dir";
            this.servicetypedirBindingSource.DataSource = this.kktDataSet;
            // 
            // price_id
            // 
            this.price_id.DataPropertyName = "price_id";
            this.price_id.DataSource = this.pricedirBindingSource;
            this.price_id.DisplayMember = "value";
            this.price_id.HeaderText = "Стоимость";
            this.price_id.Name = "price_id";
            this.price_id.ReadOnly = true;
            this.price_id.ValueMember = "id";
            // 
            // pricedirBindingSource
            // 
            this.pricedirBindingSource.DataMember = "price_dir";
            this.pricedirBindingSource.DataSource = this.kktDataSet;
            // 
            // master_id
            // 
            this.master_id.DataPropertyName = "master_id";
            this.master_id.DataSource = this.masters_dirBindingSource;
            this.master_id.DisplayMember = "value";
            this.master_id.HeaderText = "Мастер";
            this.master_id.Name = "master_id";
            this.master_id.ReadOnly = true;
            this.master_id.ValueMember = "id";
            // 
            // masters_dirBindingSource
            // 
            this.masters_dirBindingSource.DataMember = "masters_dir";
            this.masters_dirBindingSource.DataSource = this.kktDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Зав.№";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ofd_id
            // 
            this.ofd_id.DataPropertyName = "ofd_id";
            this.ofd_id.DataSource = this.ofd_dirBindingSource;
            this.ofd_id.DisplayMember = "value";
            this.ofd_id.HeaderText = "ОФД";
            this.ofd_id.Name = "ofd_id";
            this.ofd_id.ReadOnly = true;
            this.ofd_id.ValueMember = "id";
            // 
            // ofd_dirBindingSource
            // 
            this.ofd_dirBindingSource.DataMember = "ofd_dir";
            this.ofd_dirBindingSource.DataSource = this.kktDataSet;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn16.HeaderText = "Доп. инфо.";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // doc_kkmBindingSource
            // 
            this.doc_kkmBindingSource.DataMember = "doc_head_ref";
            this.doc_kkmBindingSource.DataSource = this.doc_headBindingSource;
            this.doc_kkmBindingSource.CurrentChanged += new System.EventHandler(this.doc_kkmBindingSource_CurrentChanged);
            // 
            // locationButton
            // 
            this.locationButton.Location = new System.Drawing.Point(581, 47);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(26, 23);
            this.locationButton.TabIndex = 40;
            this.locationButton.Text = "...";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // add_time_button3
            // 
            this.add_time_button3.Location = new System.Drawing.Point(354, 300);
            this.add_time_button3.Name = "add_time_button3";
            this.add_time_button3.Size = new System.Drawing.Size(33, 23);
            this.add_time_button3.TabIndex = 39;
            this.add_time_button3.Text = "36";
            this.add_time_button3.UseVisualStyleBackColor = true;
            this.add_time_button3.Click += new System.EventHandler(this.add_time_button_Click);
            // 
            // add_time_button2
            // 
            this.add_time_button2.Location = new System.Drawing.Point(315, 300);
            this.add_time_button2.Name = "add_time_button2";
            this.add_time_button2.Size = new System.Drawing.Size(33, 23);
            this.add_time_button2.TabIndex = 38;
            this.add_time_button2.Text = "15";
            this.add_time_button2.UseVisualStyleBackColor = true;
            this.add_time_button2.Click += new System.EventHandler(this.add_time_button_Click);
            // 
            // add_time_button1
            // 
            this.add_time_button1.Location = new System.Drawing.Point(276, 300);
            this.add_time_button1.Name = "add_time_button1";
            this.add_time_button1.Size = new System.Drawing.Size(33, 23);
            this.add_time_button1.TabIndex = 37;
            this.add_time_button1.Text = "13";
            this.add_time_button1.UseVisualStyleBackColor = true;
            this.add_time_button1.Click += new System.EventHandler(this.add_time_button_Click);
            // 
            // fn_num_label
            // 
            this.fn_num_label.AutoSize = true;
            this.fn_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fn_num_label.Location = new System.Drawing.Point(99, 263);
            this.fn_num_label.Name = "fn_num_label";
            this.fn_num_label.Size = new System.Drawing.Size(51, 20);
            this.fn_num_label.TabIndex = 35;
            this.fn_num_label.Text = "label1";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.Location = new System.Drawing.Point(229, 211);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(160, 20);
            this.sumLabel.TabIndex = 34;
            this.sumLabel.Text = "Стоимость в месяц:";
            // 
            // deleteNumButton
            // 
            this.deleteNumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteNumButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteNumButton.Image")));
            this.deleteNumButton.Location = new System.Drawing.Point(583, 262);
            this.deleteNumButton.Name = "deleteNumButton";
            this.deleteNumButton.Size = new System.Drawing.Size(24, 23);
            this.deleteNumButton.TabIndex = 32;
            this.deleteNumButton.UseVisualStyleBackColor = true;
            this.deleteNumButton.Click += new System.EventHandler(this.deleteNumButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "ККТ:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_kkmBindingSource, "location", true));
            this.locationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationTextBox.Location = new System.Drawing.Point(102, 44);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(473, 26);
            this.locationTextBox.TabIndex = 1;
            // 
            // descriptionRichTextBox1
            // 
            this.descriptionRichTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_kkmBindingSource, "description", true));
            this.descriptionRichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionRichTextBox1.Location = new System.Drawing.Point(99, 477);
            this.descriptionRichTextBox1.Name = "descriptionRichTextBox1";
            this.descriptionRichTextBox1.Size = new System.Drawing.Size(505, 82);
            this.descriptionRichTextBox1.TabIndex = 31;
            this.descriptionRichTextBox1.Text = "";
            // 
            // model_idComboBox
            // 
            this.model_idComboBox.CausesValidation = false;
            this.model_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doc_kkmBindingSource, "model_id", true));
            this.model_idComboBox.DataSource = this.model_kkm_dirBindingSource;
            this.model_idComboBox.DisplayMember = "value";
            this.model_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.model_idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_idComboBox.FormattingEnabled = true;
            this.model_idComboBox.Location = new System.Drawing.Point(102, 76);
            this.model_idComboBox.Name = "model_idComboBox";
            this.model_idComboBox.Size = new System.Drawing.Size(239, 28);
            this.model_idComboBox.TabIndex = 3;
            this.model_idComboBox.ValueMember = "id";
            // 
            // master_idComboBox
            // 
            this.master_idComboBox.CausesValidation = false;
            this.master_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doc_kkmBindingSource, "master_id", true));
            this.master_idComboBox.DataSource = this.masters_dirBindingSource;
            this.master_idComboBox.DisplayMember = "value";
            this.master_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.master_idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.master_idComboBox.FormattingEnabled = true;
            this.master_idComboBox.Location = new System.Drawing.Point(426, 76);
            this.master_idComboBox.Name = "master_idComboBox";
            this.master_idComboBox.Size = new System.Drawing.Size(181, 28);
            this.master_idComboBox.TabIndex = 5;
            this.master_idComboBox.ValueMember = "id";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_kkmBindingSource, "password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(417, 387);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(187, 26);
            this.passwordTextBox.TabIndex = 27;
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_kkmBindingSource, "number", true));
            this.numberTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox1.Location = new System.Drawing.Point(102, 110);
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(239, 26);
            this.numberTextBox1.TabIndex = 7;
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_kkmBindingSource, "login", true));
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(99, 387);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(239, 26);
            this.loginTextBox.TabIndex = 25;
            // 
            // data_releaseDateTimePicker
            // 
            this.data_releaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doc_kkmBindingSource, "data_release", true));
            this.data_releaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_releaseDateTimePicker.Location = new System.Drawing.Point(426, 110);
            this.data_releaseDateTimePicker.Name = "data_releaseDateTimePicker";
            this.data_releaseDateTimePicker.Size = new System.Drawing.Size(181, 26);
            this.data_releaseDateTimePicker.TabIndex = 9;
            // 
            // ofd_idComboBox
            // 
            this.ofd_idComboBox.CausesValidation = false;
            this.ofd_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doc_kkmBindingSource, "ofd_id", true));
            this.ofd_idComboBox.DataSource = this.ofd_dirBindingSource;
            this.ofd_idComboBox.DisplayMember = "value";
            this.ofd_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ofd_idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ofd_idComboBox.FormattingEnabled = true;
            this.ofd_idComboBox.Location = new System.Drawing.Point(99, 353);
            this.ofd_idComboBox.Name = "ofd_idComboBox";
            this.ofd_idComboBox.Size = new System.Drawing.Size(505, 28);
            this.ofd_idComboBox.TabIndex = 23;
            this.ofd_idComboBox.ValueMember = "id";
            // 
            // registration_numberTextBox
            // 
            this.registration_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doc_kkmBindingSource, "registration_number", true));
            this.registration_numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_numberTextBox.Location = new System.Drawing.Point(102, 142);
            this.registration_numberTextBox.Name = "registration_numberTextBox";
            this.registration_numberTextBox.Size = new System.Drawing.Size(220, 26);
            this.registration_numberTextBox.TabIndex = 11;
            // 
            // data_changeDateTimePicker
            // 
            this.data_changeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doc_kkmBindingSource, "data_change", true));
            this.data_changeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_changeDateTimePicker.Location = new System.Drawing.Point(393, 317);
            this.data_changeDateTimePicker.Name = "data_changeDateTimePicker";
            this.data_changeDateTimePicker.Size = new System.Drawing.Size(171, 26);
            this.data_changeDateTimePicker.TabIndex = 21;
            // 
            // data_registrationDateTimePicker
            // 
            this.data_registrationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doc_kkmBindingSource, "data_registration", true));
            this.data_registrationDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_registrationDateTimePicker.Location = new System.Drawing.Point(426, 147);
            this.data_registrationDateTimePicker.Name = "data_registrationDateTimePicker";
            this.data_registrationDateTimePicker.Size = new System.Drawing.Size(181, 26);
            this.data_registrationDateTimePicker.TabIndex = 13;
            // 
            // data_activationDateTimePicker
            // 
            this.data_activationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doc_kkmBindingSource, "data_activation", true));
            this.data_activationDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_activationDateTimePicker.Location = new System.Drawing.Point(99, 321);
            this.data_activationDateTimePicker.Name = "data_activationDateTimePicker";
            this.data_activationDateTimePicker.Size = new System.Drawing.Size(173, 26);
            this.data_activationDateTimePicker.TabIndex = 19;
            // 
            // service_type_idComboBox
            // 
            this.service_type_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doc_kkmBindingSource, "service_type_id", true));
            this.service_type_idComboBox.DataSource = this.servicetypedirBindingSource;
            this.service_type_idComboBox.DisplayMember = "value";
            this.service_type_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.service_type_idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.service_type_idComboBox.FormattingEnabled = true;
            this.service_type_idComboBox.Location = new System.Drawing.Point(102, 174);
            this.service_type_idComboBox.Name = "service_type_idComboBox";
            this.service_type_idComboBox.Size = new System.Drawing.Size(201, 28);
            this.service_type_idComboBox.TabIndex = 9;
            this.service_type_idComboBox.ValueMember = "id";
            this.service_type_idComboBox.SelectedIndexChanged += new System.EventHandler(this.updateSumLabel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Фискальный накопитель:";
            // 
            // fn_num_idComboBox
            // 
            this.fn_num_idComboBox.CausesValidation = false;
            this.fn_num_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doc_kkmBindingSource, "fn_num_id", true));
            this.fn_num_idComboBox.DataSource = this.fn_number_dirBindingSource;
            this.fn_num_idComboBox.DisplayMember = "value";
            this.fn_num_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fn_num_idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fn_num_idComboBox.FormattingEnabled = true;
            this.fn_num_idComboBox.Location = new System.Drawing.Point(99, 260);
            this.fn_num_idComboBox.Name = "fn_num_idComboBox";
            this.fn_num_idComboBox.Size = new System.Drawing.Size(479, 28);
            this.fn_num_idComboBox.TabIndex = 17;
            this.fn_num_idComboBox.ValueMember = "id";
            // 
            // fn_number_dirBindingSource
            // 
            this.fn_number_dirBindingSource.DataMember = "fn_number_dir";
            this.fn_number_dirBindingSource.DataSource = this.kktDataSet;
            this.fn_number_dirBindingSource.Filter = "";
            // 
            // unactive_kkmCheckBox
            // 
            this.unactive_kkmCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.doc_kkmBindingSource, "unactive_kkm", true));
            this.unactive_kkmCheckBox.Location = new System.Drawing.Point(73, 9);
            this.unactive_kkmCheckBox.Name = "unactive_kkmCheckBox";
            this.unactive_kkmCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unactive_kkmCheckBox.Size = new System.Drawing.Size(140, 24);
            this.unactive_kkmCheckBox.TabIndex = 13;
            this.unactive_kkmCheckBox.Text = "Договор расторгнут";
            this.unactive_kkmCheckBox.UseVisualStyleBackColor = true;
            // 
            // price_idComboBox
            // 
            this.price_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doc_kkmBindingSource, "price_id", true));
            this.price_idComboBox.DataSource = this.pricedirBindingSource;
            this.price_idComboBox.DisplayMember = "value";
            this.price_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.price_idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_idComboBox.FormattingEnabled = true;
            this.price_idComboBox.Location = new System.Drawing.Point(102, 208);
            this.price_idComboBox.Name = "price_idComboBox";
            this.price_idComboBox.Size = new System.Drawing.Size(121, 28);
            this.price_idComboBox.TabIndex = 15;
            this.price_idComboBox.ValueMember = "id";
            this.price_idComboBox.SelectedIndexChanged += new System.EventHandler(this.updateSumLabel);
            // 
            // kktBindingNavigator
            // 
            this.kktBindingNavigator.AddNewItem = this.addKkmButton;
            this.kktBindingNavigator.BindingSource = this.doc_kkmBindingSource;
            this.kktBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.kktBindingNavigator.DeleteItem = null;
            this.kktBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.addKkmButton,
            this.deleteKkmButton,
            this.saveKkmButton,
            this.toolStripSeparator2,
            this.toolStripSplitButton1});
            this.kktBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kktBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.kktBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.kktBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.kktBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.kktBindingNavigator.Name = "kktBindingNavigator";
            this.kktBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.kktBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.kktBindingNavigator.TabIndex = 32;
            this.kktBindingNavigator.Text = "bindingNavigator1";
            // 
            // addKkmButton
            // 
            this.addKkmButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addKkmButton.Enabled = false;
            this.addKkmButton.Image = ((System.Drawing.Image)(resources.GetObject("addKkmButton.Image")));
            this.addKkmButton.Name = "addKkmButton";
            this.addKkmButton.RightToLeftAutoMirrorImage = true;
            this.addKkmButton.Size = new System.Drawing.Size(23, 22);
            this.addKkmButton.Text = "Добавить";
            this.addKkmButton.Click += new System.EventHandler(this.addKkmButton_Click);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteKkmButton
            // 
            this.deleteKkmButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteKkmButton.Enabled = false;
            this.deleteKkmButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteKkmButton.Image")));
            this.deleteKkmButton.Name = "deleteKkmButton";
            this.deleteKkmButton.RightToLeftAutoMirrorImage = true;
            this.deleteKkmButton.Size = new System.Drawing.Size(23, 22);
            this.deleteKkmButton.Text = "Удалить";
            this.deleteKkmButton.Click += new System.EventHandler(this.DeleteKkmButton_Click);
            // 
            // saveKkmButton
            // 
            this.saveKkmButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveKkmButton.Enabled = false;
            this.saveKkmButton.Image = ((System.Drawing.Image)(resources.GetObject("saveKkmButton.Image")));
            this.saveKkmButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveKkmButton.Name = "saveKkmButton";
            this.saveKkmButton.Size = new System.Drawing.Size(23, 22);
            this.saveKkmButton.Text = "Сохранить";
            this.saveKkmButton.Click += new System.EventHandler(this.saveKkmButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заявлениеОРегистрацииToolStripMenuItem,
            this.заявлениеОСнятииСРегистрацииToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "Заявления";
            // 
            // заявлениеОРегистрацииToolStripMenuItem
            // 
            this.заявлениеОРегистрацииToolStripMenuItem.Name = "заявлениеОРегистрацииToolStripMenuItem";
            this.заявлениеОРегистрацииToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.заявлениеОРегистрацииToolStripMenuItem.Text = "Заявление о регистрации";
            this.заявлениеОРегистрацииToolStripMenuItem.Click += new System.EventHandler(this.заявлениеОРегистрацииToolStripMenuItem_Click);
            // 
            // заявлениеОСнятииСРегистрацииToolStripMenuItem
            // 
            this.заявлениеОСнятииСРегистрацииToolStripMenuItem.Name = "заявлениеОСнятииСРегистрацииToolStripMenuItem";
            this.заявлениеОСнятииСРегистрацииToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.заявлениеОСнятииСРегистрацииToolStripMenuItem.Text = "Заявление о снятии с регистрации";
            this.заявлениеОСнятииСРегистрацииToolStripMenuItem.Click += new System.EventHandler(this.заявлениеОСнятииСРегистрацииToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.dirGridView);
            this.tabPage3.Controls.Add(this.dirComboBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1253, 904);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Справочники";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Leave += new System.EventHandler(this.tabPage3_Leave);
            // 
            // dirGridView
            // 
            this.dirGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dirGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.value});
            this.dirGridView.Location = new System.Drawing.Point(8, 33);
            this.dirGridView.Name = "dirGridView";
            this.dirGridView.Size = new System.Drawing.Size(582, 352);
            this.dirGridView.TabIndex = 1;
            this.dirGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dirGridView_CellEndEdit);
            this.dirGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dirGridView_UserDeletedRow);
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.DataPropertyName = "value";
            this.value.HeaderText = "";
            this.value.Name = "value";
            // 
            // dirComboBox
            // 
            this.dirComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dirComboBox.FormattingEnabled = true;
            this.dirComboBox.Location = new System.Drawing.Point(8, 6);
            this.dirComboBox.Name = "dirComboBox";
            this.dirComboBox.Size = new System.Drawing.Size(582, 21);
            this.dirComboBox.TabIndex = 0;
            this.dirComboBox.TextChanged += new System.EventHandler(this.dirComboBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.reportComboBox);
            this.tabPage2.Controls.Add(this.reportViewer1);
            this.tabPage2.Controls.Add(this.reportPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1253, 904);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Отчеты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(142, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отчет:";
            // 
            // reportComboBox
            // 
            this.reportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportComboBox.FormattingEnabled = true;
            this.reportComboBox.Location = new System.Drawing.Point(79, 8);
            this.reportComboBox.Name = "reportComboBox";
            this.reportComboBox.Size = new System.Drawing.Size(216, 28);
            this.reportComboBox.TabIndex = 3;
            this.reportComboBox.SelectedIndexChanged += new System.EventHandler(this.reportComboBox_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer1.Location = new System.Drawing.Point(0, 165);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1253, 739);
            this.reportViewer1.TabIndex = 2;
            // 
            // reportPanel
            // 
            this.reportPanel.Location = new System.Drawing.Point(301, 8);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(802, 37);
            this.reportPanel.TabIndex = 0;
            // 
            // fn_mp_dirBindingSource
            // 
            this.fn_mp_dirBindingSource.DataMember = "fn_mp_dir";
            this.fn_mp_dirBindingSource.DataSource = this.kktDataSet;
            // 
            // payfkBindingSource
            // 
            this.payfkBindingSource.DataMember = "pay_fk";
            this.payfkBindingSource.DataSource = this.paymentstatusdirBindingSource;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // doc_headTableAdapter
            // 
            this.doc_headTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = true;
            this.tableAdapterManager.doc_headTableAdapter = this.doc_headTableAdapter;
            this.tableAdapterManager.doc_kkmTableAdapter = this.doc_kkmTableAdapter;
            this.tableAdapterManager.fn_mp_dirTableAdapter = this.fn_mp_dirTableAdapter;
            this.tableAdapterManager.fn_number_dirTableAdapter = this.fn_number_dirTableAdapter;
            this.tableAdapterManager.masters_dirTableAdapter = this.masters_dirTableAdapter;
            this.tableAdapterManager.model_kkm_dirTableAdapter = this.model_kkm_dirTableAdapter;
            this.tableAdapterManager.ofd_dirTableAdapter = this.ofd_dirTableAdapter;
            this.tableAdapterManager.payment_status_dirTableAdapter = this.payment_status_dirTableAdapter;
            this.tableAdapterManager.price_dirTableAdapter = this.price_dirTableAdapter;
            this.tableAdapterManager.service_type_dirTableAdapter = this.service_type_dirTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.kktDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doc_kkmTableAdapter
            // 
            this.doc_kkmTableAdapter.ClearBeforeFill = true;
            // 
            // fn_mp_dirTableAdapter
            // 
            this.fn_mp_dirTableAdapter.ClearBeforeFill = true;
            // 
            // fn_number_dirTableAdapter
            // 
            this.fn_number_dirTableAdapter.ClearBeforeFill = true;
            // 
            // masters_dirTableAdapter
            // 
            this.masters_dirTableAdapter.ClearBeforeFill = true;
            // 
            // model_kkm_dirTableAdapter
            // 
            this.model_kkm_dirTableAdapter.ClearBeforeFill = true;
            // 
            // ofd_dirTableAdapter
            // 
            this.ofd_dirTableAdapter.ClearBeforeFill = true;
            // 
            // payment_status_dirTableAdapter
            // 
            this.payment_status_dirTableAdapter.ClearBeforeFill = true;
            // 
            // price_dirTableAdapter
            // 
            this.price_dirTableAdapter.ClearBeforeFill = true;
            // 
            // service_type_dirTableAdapter
            // 
            this.service_type_dirTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 908);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // reportDataTable1BindingSource
            // 
            this.reportDataTable1BindingSource.DataMember = "reportDataTable1";
            this.reportDataTable1BindingSource.DataSource = this.kktDataSet;
            // 
            // reportDataTable1TableAdapter
            // 
            this.reportDataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // mpComboBox
            // 
            this.mpComboBox.DataSource = this.fn_mp_dirBindingSource;
            this.mpComboBox.DisplayMember = "value";
            this.mpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mpComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mpComboBox.FormattingEnabled = true;
            this.mpComboBox.Location = new System.Drawing.Point(99, 419);
            this.mpComboBox.Name = "mpComboBox";
            this.mpComboBox.Size = new System.Drawing.Size(505, 28);
            this.mpComboBox.TabIndex = 41;
            this.mpComboBox.ValueMember = "id";
            // 
            // NewDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 930);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "NewDocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "База ККТ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDocForm_FormClosing);
            this.Load += new System.EventHandler(this.NewDocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doc_headBindingNavigator)).EndInit();
            this.doc_headBindingNavigator.ResumeLayout(false);
            this.doc_headBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doc_headBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kktDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doc_headDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentstatusdirBindingSource)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doc_kkmDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model_kkm_dirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicetypedirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricedirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masters_dirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofd_dirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc_kkmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fn_number_dirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kktBindingNavigator)).EndInit();
            this.kktBindingNavigator.ResumeLayout(false);
            this.kktBindingNavigator.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dirGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fn_mp_dirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private kktDataSet kktDataSet;
        private System.Windows.Forms.BindingSource doc_headBindingSource;
        private WindowsFormsApplication2.kktDataSetTableAdapters.doc_headTableAdapter doc_headTableAdapter;        
        private WindowsFormsApplication2.kktDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton AddDocButton;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton deleteDocButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveDocButton;
        private System.Windows.Forms.ComboBox service_type_idComboBox;
        private System.Windows.Forms.DateTimePicker data_endDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_startDateTimePicker;
        private System.Windows.Forms.TextBox numberTextBox;
        private WindowsFormsApplication2.kktDataSetTableAdapters.service_type_dirTableAdapter service_type_dirTableAdapter;
        private System.Windows.Forms.BindingSource servicetypedirBindingSource;
        private System.Windows.Forms.CheckBox unactive_clientCheckBox;
        private System.Windows.Forms.CheckBox unactive_kkmCheckBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox price_idComboBox;
        private System.Windows.Forms.BindingSource pricedirBindingSource;
        private WindowsFormsApplication2.kktDataSetTableAdapters.price_dirTableAdapter price_dirTableAdapter;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox kppTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox member_baseTextBox;
        private System.Windows.Forms.TextBox memberTextBox;
        private System.Windows.Forms.TextBox ogrnTextBox;
        private System.Windows.Forms.TextBox bank_account_corTextBox;
        private System.Windows.Forms.TextBox bank_accountTextBox;
        private System.Windows.Forms.TextBox bankTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox bikTextBox;
        private System.Windows.Forms.ComboBox payment_status_idComboBox;
        private System.Windows.Forms.BindingSource paymentstatusdirBindingSource;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.ComboBox periodComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox searchComboBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox dirComboBox;
        private System.Windows.Forms.DataGridView dirGridView;
        private WindowsFormsApplication2.kktDataSetTableAdapters.payment_status_dirTableAdapter payment_status_dirTableAdapter;
        private System.Windows.Forms.BindingSource ofd_dirBindingSource;
        private WindowsFormsApplication2.kktDataSetTableAdapters.ofd_dirTableAdapter ofd_dirTableAdapter;
        private System.Windows.Forms.BindingSource model_kkm_dirBindingSource;
        private WindowsFormsApplication2.kktDataSetTableAdapters.model_kkm_dirTableAdapter model_kkm_dirTableAdapter;
        private System.Windows.Forms.BindingSource masters_dirBindingSource;
        private WindowsFormsApplication2.kktDataSetTableAdapters.masters_dirTableAdapter masters_dirTableAdapter;
        private System.Windows.Forms.BindingSource fn_number_dirBindingSource;
        private WindowsFormsApplication2.kktDataSetTableAdapters.fn_number_dirTableAdapter fn_number_dirTableAdapter;
        private System.Windows.Forms.BindingSource fn_mp_dirBindingSource;
        private WindowsFormsApplication2.kktDataSetTableAdapters.fn_mp_dirTableAdapter fn_mp_dirTableAdapter;
        private System.Windows.Forms.BindingSource doc_kkmBindingSource;
        private WindowsFormsApplication2.kktDataSetTableAdapters.doc_kkmTableAdapter doc_kkmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ComboBox model_idComboBox;
        private System.Windows.Forms.ComboBox master_idComboBox;
        private System.Windows.Forms.TextBox registration_numberTextBox;
        private System.Windows.Forms.DateTimePicker data_releaseDateTimePicker;
        private System.Windows.Forms.TextBox numberTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker data_registrationDateTimePicker;
        private System.Windows.Forms.ComboBox fn_num_idComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker data_changeDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_activationDateTimePicker;
        private System.Windows.Forms.ComboBox ofd_idComboBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox1;
        private System.Windows.Forms.DataGridView doc_kkmDataGridView;
        private System.Windows.Forms.BindingNavigator kktBindingNavigator;
        private System.Windows.Forms.ToolStripButton addKkmButton;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton deleteKkmButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton saveKkmButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView doc_headDataGridView;
        private System.Windows.Forms.Label DocNumberLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.BindingNavigator doc_headBindingNavigator;
        private System.Windows.Forms.Button deleteNumButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewComboBoxColumn payment_status_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.BindingSource payfkBindingSource;
        private System.Windows.Forms.Label fn_num_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn unactive_kkm;
        private System.Windows.Forms.DataGridViewComboBoxColumn model_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn service_type_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn price_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn master_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn ofd_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource reportDataTable1BindingSource;
        private kktDataSetTableAdapters.reportDataTable1TableAdapter reportDataTable1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox reportComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton printButton;
        private System.Windows.Forms.Label payment_status_idLabel;
        private System.Windows.Forms.Button add_time_button3;
        private System.Windows.Forms.Button add_time_button2;
        private System.Windows.Forms.Button add_time_button1;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem заявлениеОРегистрацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заявлениеОСнятииСРегистрацииToolStripMenuItem;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox memberIMTextBox;
        private System.Windows.Forms.Label memberImLabel;
        private System.Windows.Forms.ComboBox mpComboBox;
    }
}