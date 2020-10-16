namespace Library_Statistics_Reader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.FromDateLabel = new System.Windows.Forms.Label();
            this.ToDateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileCountDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoEnqLabel = new System.Windows.Forms.Label();
            this.DoorTotLabel = new System.Windows.Forms.Label();
            this.DirectEnqLabel = new System.Windows.Forms.Label();
            this.TotCountLabel = new System.Windows.Forms.Label();
            this.TechEnqLabel = new System.Windows.Forms.Label();
            this.EContEnqTotLabel = new System.Windows.Forms.Label();
            this.TeleEnqLabel = new System.Windows.Forms.Label();
            this.TeleEnqTotLabel = new System.Windows.Forms.Label();
            this.EContEnqLabel = new System.Windows.Forms.Label();
            this.TotalEnqCountLabel = new System.Windows.Forms.Label();
            this.DirectEnqTotLabel = new System.Windows.Forms.Label();
            this.DoorCountLabel = new System.Windows.Forms.Label();
            this.InfoEnqTotLabel = new System.Windows.Forms.Label();
            this.TechEnqTotLabel = new System.Windows.Forms.Label();
            this.InfoAvg = new System.Windows.Forms.Label();
            this.DirAvg = new System.Windows.Forms.Label();
            this.TechAvg = new System.Windows.Forms.Label();
            this.TeleAvg = new System.Windows.Forms.Label();
            this.EContAvg = new System.Windows.Forms.Label();
            this.TotAvg = new System.Windows.Forms.Label();
            this.DoorAvg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FileLocationButton = new System.Windows.Forms.Button();
            this.FileLocationLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDatePicker.Location = new System.Drawing.Point(84, 67);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(149, 29);
            this.FromDatePicker.TabIndex = 0;
            this.FromDatePicker.ValueChanged += new System.EventHandler(this.FromDatePicker_ValueChanged);
            this.FromDatePicker.MouseHover += new System.EventHandler(this.FromDatePicker_MouseHover);
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "All",
            "BH-Circulation",
            "HB",
            "HB-Circulation",
            "HB-Info",
            "HW-Circulation",
            "MB",
            "MB-Circulation",
            "MB-Info",
            "MB-Toy",
            "TR-Circulation"});
            this.LocationComboBox.Location = new System.Drawing.Point(178, 12);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(160, 32);
            this.LocationComboBox.TabIndex = 1;
            this.LocationComboBox.SelectedIndexChanged += new System.EventHandler(this.LocationComboBox_SelectedIndexChanged);
            this.LocationComboBox.MouseHover += new System.EventHandler(this.LocationComboBox_MouseHover);
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDatePicker.Location = new System.Drawing.Point(303, 66);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(152, 29);
            this.ToDatePicker.TabIndex = 2;
            this.ToDatePicker.ValueChanged += new System.EventHandler(this.ToDatePicker_ValueChanged);
            this.ToDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToDatePicker_KeyDown);
            this.ToDatePicker.MouseHover += new System.EventHandler(this.ToDatePicker_MouseHover);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(83, 15);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(89, 24);
            this.LocationLabel.TabIndex = 3;
            this.LocationLabel.Text = "Location";
            // 
            // FromDateLabel
            // 
            this.FromDateLabel.AutoSize = true;
            this.FromDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateLabel.Location = new System.Drawing.Point(12, 71);
            this.FromDateLabel.Name = "FromDateLabel";
            this.FromDateLabel.Size = new System.Drawing.Size(59, 24);
            this.FromDateLabel.TabIndex = 4;
            this.FromDateLabel.Text = "From";
            // 
            // ToDateLabel
            // 
            this.ToDateLabel.AutoSize = true;
            this.ToDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateLabel.Location = new System.Drawing.Point(262, 71);
            this.ToDateLabel.Name = "ToDateLabel";
            this.ToDateLabel.Size = new System.Drawing.Size(35, 24);
            this.ToDateLabel.TabIndex = 5;
            this.ToDateLabel.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FileCountDisplay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ResultsButton);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 525);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Totals";
            // 
            // FileCountDisplay
            // 
            this.FileCountDisplay.AutoSize = true;
            this.FileCountDisplay.Location = new System.Drawing.Point(172, 365);
            this.FileCountDisplay.Name = "FileCountDisplay";
            this.FileCountDisplay.Size = new System.Drawing.Size(21, 24);
            this.FileCountDisplay.TabIndex = 16;
            this.FileCountDisplay.Text = "0";
            this.FileCountDisplay.Click += new System.EventHandler(this.FileCountDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Files In Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // ResultsButton
            // 
            this.ResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsButton.Location = new System.Drawing.Point(201, 433);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(93, 35);
            this.ResultsButton.TabIndex = 7;
            this.ResultsButton.Text = "Update";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            this.ResultsButton.MouseHover += new System.EventHandler(this.ResultsButton_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.InfoEnqLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DoorTotLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.DirectEnqLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TotCountLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TechEnqLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.EContEnqTotLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TeleEnqLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TeleEnqTotLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EContEnqLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotalEnqCountLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DirectEnqTotLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DoorCountLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.InfoEnqTotLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TechEnqTotLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.InfoAvg, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DirAvg, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TechAvg, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TeleAvg, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.EContAvg, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotAvg, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DoorAvg, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(523, 331);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // InfoEnqLabel
            // 
            this.InfoEnqLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoEnqLabel.AutoSize = true;
            this.InfoEnqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEnqLabel.Location = new System.Drawing.Point(37, 12);
            this.InfoEnqLabel.Name = "InfoEnqLabel";
            this.InfoEnqLabel.Size = new System.Drawing.Size(187, 24);
            this.InfoEnqLabel.TabIndex = 0;
            this.InfoEnqLabel.Text = "Information Enquiries";
            // 
            // DoorTotLabel
            // 
            this.DoorTotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoorTotLabel.AutoSize = true;
            this.DoorTotLabel.Location = new System.Drawing.Point(315, 294);
            this.DoorTotLabel.Name = "DoorTotLabel";
            this.DoorTotLabel.Size = new System.Drawing.Size(21, 24);
            this.DoorTotLabel.TabIndex = 13;
            this.DoorTotLabel.Text = "0";
            // 
            // DirectEnqLabel
            // 
            this.DirectEnqLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirectEnqLabel.AutoSize = true;
            this.DirectEnqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectEnqLabel.Location = new System.Drawing.Point(39, 59);
            this.DirectEnqLabel.Name = "DirectEnqLabel";
            this.DirectEnqLabel.Size = new System.Drawing.Size(183, 24);
            this.DirectEnqLabel.TabIndex = 1;
            this.DirectEnqLabel.Text = "Directional Enquiries";
            // 
            // TotCountLabel
            // 
            this.TotCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotCountLabel.AutoSize = true;
            this.TotCountLabel.Location = new System.Drawing.Point(315, 247);
            this.TotCountLabel.Name = "TotCountLabel";
            this.TotCountLabel.Size = new System.Drawing.Size(21, 24);
            this.TotCountLabel.TabIndex = 12;
            this.TotCountLabel.Text = "0";
            // 
            // TechEnqLabel
            // 
            this.TechEnqLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechEnqLabel.AutoSize = true;
            this.TechEnqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechEnqLabel.Location = new System.Drawing.Point(41, 106);
            this.TechEnqLabel.Name = "TechEnqLabel";
            this.TechEnqLabel.Size = new System.Drawing.Size(178, 24);
            this.TechEnqLabel.TabIndex = 2;
            this.TechEnqLabel.Text = "Technical Enquiries";
            this.TechEnqLabel.Click += new System.EventHandler(this.TechEnqLabel_Click);
            // 
            // EContEnqTotLabel
            // 
            this.EContEnqTotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EContEnqTotLabel.AutoSize = true;
            this.EContEnqTotLabel.Location = new System.Drawing.Point(315, 200);
            this.EContEnqTotLabel.Name = "EContEnqTotLabel";
            this.EContEnqTotLabel.Size = new System.Drawing.Size(21, 24);
            this.EContEnqTotLabel.TabIndex = 11;
            this.EContEnqTotLabel.Text = "0";
            // 
            // TeleEnqLabel
            // 
            this.TeleEnqLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeleEnqLabel.AutoSize = true;
            this.TeleEnqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeleEnqLabel.Location = new System.Drawing.Point(36, 153);
            this.TeleEnqLabel.Name = "TeleEnqLabel";
            this.TeleEnqLabel.Size = new System.Drawing.Size(188, 24);
            this.TeleEnqLabel.TabIndex = 3;
            this.TeleEnqLabel.Text = "Telephone Enquiries";
            // 
            // TeleEnqTotLabel
            // 
            this.TeleEnqTotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeleEnqTotLabel.AutoSize = true;
            this.TeleEnqTotLabel.Location = new System.Drawing.Point(315, 153);
            this.TeleEnqTotLabel.Name = "TeleEnqTotLabel";
            this.TeleEnqTotLabel.Size = new System.Drawing.Size(21, 24);
            this.TeleEnqTotLabel.TabIndex = 10;
            this.TeleEnqTotLabel.Text = "0";
            // 
            // EContEnqLabel
            // 
            this.EContEnqLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EContEnqLabel.AutoSize = true;
            this.EContEnqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EContEnqLabel.Location = new System.Drawing.Point(41, 200);
            this.EContEnqLabel.Name = "EContEnqLabel";
            this.EContEnqLabel.Size = new System.Drawing.Size(179, 24);
            this.EContEnqLabel.TabIndex = 4;
            this.EContEnqLabel.Text = "E-Content Enquiries";
            // 
            // TotalEnqCountLabel
            // 
            this.TotalEnqCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalEnqCountLabel.AutoSize = true;
            this.TotalEnqCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEnqCountLabel.Location = new System.Drawing.Point(62, 247);
            this.TotalEnqCountLabel.Name = "TotalEnqCountLabel";
            this.TotalEnqCountLabel.Size = new System.Drawing.Size(136, 24);
            this.TotalEnqCountLabel.TabIndex = 5;
            this.TotalEnqCountLabel.Text = "Total Enquiries";
            // 
            // DirectEnqTotLabel
            // 
            this.DirectEnqTotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirectEnqTotLabel.AutoSize = true;
            this.DirectEnqTotLabel.Location = new System.Drawing.Point(315, 59);
            this.DirectEnqTotLabel.Name = "DirectEnqTotLabel";
            this.DirectEnqTotLabel.Size = new System.Drawing.Size(21, 24);
            this.DirectEnqTotLabel.TabIndex = 8;
            this.DirectEnqTotLabel.Text = "0";
            // 
            // DoorCountLabel
            // 
            this.DoorCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoorCountLabel.AutoSize = true;
            this.DoorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoorCountLabel.Location = new System.Drawing.Point(54, 294);
            this.DoorCountLabel.Name = "DoorCountLabel";
            this.DoorCountLabel.Size = new System.Drawing.Size(152, 24);
            this.DoorCountLabel.TabIndex = 6;
            this.DoorCountLabel.Text = "Door Count Total";
            // 
            // InfoEnqTotLabel
            // 
            this.InfoEnqTotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoEnqTotLabel.AutoSize = true;
            this.InfoEnqTotLabel.Location = new System.Drawing.Point(315, 12);
            this.InfoEnqTotLabel.Name = "InfoEnqTotLabel";
            this.InfoEnqTotLabel.Size = new System.Drawing.Size(21, 24);
            this.InfoEnqTotLabel.TabIndex = 7;
            this.InfoEnqTotLabel.Text = "0";
            this.InfoEnqTotLabel.Click += new System.EventHandler(this.InfoEnqTotLabel_Click);
            // 
            // TechEnqTotLabel
            // 
            this.TechEnqTotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechEnqTotLabel.AutoSize = true;
            this.TechEnqTotLabel.Location = new System.Drawing.Point(315, 106);
            this.TechEnqTotLabel.Name = "TechEnqTotLabel";
            this.TechEnqTotLabel.Size = new System.Drawing.Size(21, 24);
            this.TechEnqTotLabel.TabIndex = 9;
            this.TechEnqTotLabel.Text = "0";
            // 
            // InfoAvg
            // 
            this.InfoAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoAvg.AutoSize = true;
            this.InfoAvg.Location = new System.Drawing.Point(446, 12);
            this.InfoAvg.Name = "InfoAvg";
            this.InfoAvg.Size = new System.Drawing.Size(21, 24);
            this.InfoAvg.TabIndex = 14;
            this.InfoAvg.Text = "0";
            // 
            // DirAvg
            // 
            this.DirAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirAvg.AutoSize = true;
            this.DirAvg.Location = new System.Drawing.Point(446, 59);
            this.DirAvg.Name = "DirAvg";
            this.DirAvg.Size = new System.Drawing.Size(21, 24);
            this.DirAvg.TabIndex = 15;
            this.DirAvg.Text = "0";
            // 
            // TechAvg
            // 
            this.TechAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechAvg.AutoSize = true;
            this.TechAvg.Location = new System.Drawing.Point(446, 106);
            this.TechAvg.Name = "TechAvg";
            this.TechAvg.Size = new System.Drawing.Size(21, 24);
            this.TechAvg.TabIndex = 16;
            this.TechAvg.Text = "0";
            // 
            // TeleAvg
            // 
            this.TeleAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeleAvg.AutoSize = true;
            this.TeleAvg.Location = new System.Drawing.Point(446, 153);
            this.TeleAvg.Name = "TeleAvg";
            this.TeleAvg.Size = new System.Drawing.Size(21, 24);
            this.TeleAvg.TabIndex = 17;
            this.TeleAvg.Text = "0";
            // 
            // EContAvg
            // 
            this.EContAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EContAvg.AutoSize = true;
            this.EContAvg.Location = new System.Drawing.Point(446, 200);
            this.EContAvg.Name = "EContAvg";
            this.EContAvg.Size = new System.Drawing.Size(21, 24);
            this.EContAvg.TabIndex = 18;
            this.EContAvg.Text = "0";
            // 
            // TotAvg
            // 
            this.TotAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotAvg.AutoSize = true;
            this.TotAvg.Location = new System.Drawing.Point(446, 247);
            this.TotAvg.Name = "TotAvg";
            this.TotAvg.Size = new System.Drawing.Size(21, 24);
            this.TotAvg.TabIndex = 19;
            this.TotAvg.Text = "0";
            // 
            // DoorAvg
            // 
            this.DoorAvg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoorAvg.AutoSize = true;
            this.DoorAvg.Location = new System.Drawing.Point(446, 294);
            this.DoorAvg.Name = "DoorAvg";
            this.DoorAvg.Size = new System.Drawing.Size(21, 24);
            this.DoorAvg.TabIndex = 20;
            this.DoorAvg.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Averages";
            // 
            // FileLocationButton
            // 
            this.FileLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLocationButton.Location = new System.Drawing.Point(3, 109);
            this.FileLocationButton.Name = "FileLocationButton";
            this.FileLocationButton.Size = new System.Drawing.Size(120, 35);
            this.FileLocationButton.TabIndex = 8;
            this.FileLocationButton.Text = "File Location";
            this.FileLocationButton.UseVisualStyleBackColor = true;
            this.FileLocationButton.Click += new System.EventHandler(this.FileLocationButton_Click);
            this.FileLocationButton.MouseHover += new System.EventHandler(this.FileLocationButton_MouseHover);
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.AutoSize = true;
            this.FileLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLocationLabel.Location = new System.Drawing.Point(129, 116);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(0, 20);
            this.FileLocationLabel.TabIndex = 10;
            this.FileLocationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(545, 630);
            this.Controls.Add(this.FileLocationLabel);
            this.Controls.Add(this.FileLocationButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ToDateLabel);
            this.Controls.Add(this.FromDateLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.FromDatePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Library Statistics Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FromDatePicker;
        private System.Windows.Forms.ComboBox LocationComboBox;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label FromDateLabel;
        private System.Windows.Forms.Label ToDateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DoorCountLabel;
        private System.Windows.Forms.Label TotalEnqCountLabel;
        private System.Windows.Forms.Label EContEnqLabel;
        private System.Windows.Forms.Label TeleEnqLabel;
        private System.Windows.Forms.Label TechEnqLabel;
        private System.Windows.Forms.Label DirectEnqLabel;
        private System.Windows.Forms.Label InfoEnqLabel;
        private System.Windows.Forms.Label DoorTotLabel;
        private System.Windows.Forms.Label TotCountLabel;
        private System.Windows.Forms.Label EContEnqTotLabel;
        private System.Windows.Forms.Label TeleEnqTotLabel;
        private System.Windows.Forms.Label TechEnqTotLabel;
        private System.Windows.Forms.Label DirectEnqTotLabel;
        private System.Windows.Forms.Label InfoEnqTotLabel;
        private System.Windows.Forms.Button ResultsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FileLocationButton;
        private System.Windows.Forms.Label FileLocationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FileCountDisplay;
        private System.Windows.Forms.Label InfoAvg;
        private System.Windows.Forms.Label DirAvg;
        private System.Windows.Forms.Label TechAvg;
        private System.Windows.Forms.Label TeleAvg;
        private System.Windows.Forms.Label EContAvg;
        private System.Windows.Forms.Label TotAvg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DoorAvg;
        private System.Windows.Forms.Label label2;
    }
}

