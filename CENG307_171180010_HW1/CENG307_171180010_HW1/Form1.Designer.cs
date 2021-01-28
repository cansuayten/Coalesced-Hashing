namespace CENG307_171180010_HW1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstView_table = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstView_eisch = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstView_lich = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstView_blisch = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstView_reisch = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEisch_perf = new System.Windows.Forms.Label();
            this.lblReisch_perf = new System.Windows.Forms.Label();
            this.lblBlisch_perf = new System.Windows.Forms.Label();
            this.lblLich_perf = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtKeysize = new System.Windows.Forms.TextBox();
            this.lblPackingFactor = new System.Windows.Forms.Label();
            this.btnEisch = new System.Windows.Forms.Button();
            this.btnBlisch = new System.Windows.Forms.Button();
            this.btnLich = new System.Windows.Forms.Button();
            this.btnResich = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReischSearch = new System.Windows.Forms.Label();
            this.lblBlischSearch = new System.Windows.Forms.Label();
            this.lblEischSearch = new System.Windows.Forms.Label();
            this.lblLichSearch = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrimaryArea = new System.Windows.Forms.Label();
            this.lblHashSize = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstView_table
            // 
            this.lstView_table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.columnHeader18});
            this.lstView_table.HideSelection = false;
            this.lstView_table.Location = new System.Drawing.Point(12, 320);
            this.lstView_table.Name = "lstView_table";
            this.lstView_table.Size = new System.Drawing.Size(128, 398);
            this.lstView_table.TabIndex = 0;
            this.lstView_table.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Key";
            // 
            // lstView_eisch
            // 
            this.lstView_eisch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstView_eisch.HideSelection = false;
            this.lstView_eisch.Location = new System.Drawing.Point(155, 320);
            this.lstView_eisch.Name = "lstView_eisch";
            this.lstView_eisch.Size = new System.Drawing.Size(243, 398);
            this.lstView_eisch.TabIndex = 1;
            this.lstView_eisch.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Index";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Key";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Link";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Probe";
            // 
            // lstView_lich
            // 
            this.lstView_lich.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstView_lich.HideSelection = false;
            this.lstView_lich.Location = new System.Drawing.Point(424, 320);
            this.lstView_lich.Name = "lstView_lich";
            this.lstView_lich.Size = new System.Drawing.Size(240, 398);
            this.lstView_lich.TabIndex = 2;
            this.lstView_lich.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Key";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Link";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Probe";
            // 
            // lstView_blisch
            // 
            this.lstView_blisch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lstView_blisch.HideSelection = false;
            this.lstView_blisch.Location = new System.Drawing.Point(695, 320);
            this.lstView_blisch.Name = "lstView_blisch";
            this.lstView_blisch.Size = new System.Drawing.Size(237, 398);
            this.lstView_blisch.TabIndex = 3;
            this.lstView_blisch.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Index";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Key";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Link";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Probe";
            // 
            // lstView_reisch
            // 
            this.lstView_reisch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstView_reisch.HideSelection = false;
            this.lstView_reisch.Location = new System.Drawing.Point(955, 320);
            this.lstView_reisch.Name = "lstView_reisch";
            this.lstView_reisch.Size = new System.Drawing.Size(233, 398);
            this.lstView_reisch.TabIndex = 4;
            this.lstView_reisch.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Index";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Key";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Link";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Probe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "EISCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "LICH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1029, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "REISCH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "BLISCH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key Size:";
            // 
            // lblEisch_perf
            // 
            this.lblEisch_perf.AutoSize = true;
            this.lblEisch_perf.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEisch_perf.Location = new System.Drawing.Point(16, 43);
            this.lblEisch_perf.Name = "lblEisch_perf";
            this.lblEisch_perf.Size = new System.Drawing.Size(161, 20);
            this.lblEisch_perf.TabIndex = 10;
            this.lblEisch_perf.Text = "EISCH Performance:";
            // 
            // lblReisch_perf
            // 
            this.lblReisch_perf.AutoSize = true;
            this.lblReisch_perf.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReisch_perf.Location = new System.Drawing.Point(5, 119);
            this.lblReisch_perf.Name = "lblReisch_perf";
            this.lblReisch_perf.Size = new System.Drawing.Size(173, 20);
            this.lblReisch_perf.TabIndex = 11;
            this.lblReisch_perf.Text = "REISCH Performance:";
            // 
            // lblBlisch_perf
            // 
            this.lblBlisch_perf.AutoSize = true;
            this.lblBlisch_perf.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlisch_perf.Location = new System.Drawing.Point(5, 157);
            this.lblBlisch_perf.Name = "lblBlisch_perf";
            this.lblBlisch_perf.Size = new System.Drawing.Size(172, 20);
            this.lblBlisch_perf.TabIndex = 12;
            this.lblBlisch_perf.Text = "BLISCH Performance:";
            // 
            // lblLich_perf
            // 
            this.lblLich_perf.AutoSize = true;
            this.lblLich_perf.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLich_perf.Location = new System.Drawing.Point(25, 80);
            this.lblLich_perf.Name = "lblLich_perf";
            this.lblLich_perf.Size = new System.Drawing.Size(152, 20);
            this.lblLich_perf.TabIndex = 13;
            this.lblLich_perf.Text = "LICH Performance:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCreate.Location = new System.Drawing.Point(274, 50);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(89, 43);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtKeysize
            // 
            this.txtKeysize.Location = new System.Drawing.Point(121, 61);
            this.txtKeysize.Name = "txtKeysize";
            this.txtKeysize.Size = new System.Drawing.Size(147, 23);
            this.txtKeysize.TabIndex = 15;
            // 
            // lblPackingFactor
            // 
            this.lblPackingFactor.AutoSize = true;
            this.lblPackingFactor.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackingFactor.Location = new System.Drawing.Point(37, 116);
            this.lblPackingFactor.Name = "lblPackingFactor";
            this.lblPackingFactor.Size = new System.Drawing.Size(122, 20);
            this.lblPackingFactor.TabIndex = 16;
            this.lblPackingFactor.Text = "Packing Factor:";
            // 
            // btnEisch
            // 
            this.btnEisch.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEisch.Location = new System.Drawing.Point(401, 45);
            this.btnEisch.Name = "btnEisch";
            this.btnEisch.Size = new System.Drawing.Size(106, 71);
            this.btnEisch.TabIndex = 17;
            this.btnEisch.Text = "EISCH";
            this.btnEisch.UseVisualStyleBackColor = false;
            this.btnEisch.Click += new System.EventHandler(this.btnEisch_Click);
            // 
            // btnBlisch
            // 
            this.btnBlisch.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBlisch.Location = new System.Drawing.Point(518, 147);
            this.btnBlisch.Name = "btnBlisch";
            this.btnBlisch.Size = new System.Drawing.Size(106, 71);
            this.btnBlisch.TabIndex = 18;
            this.btnBlisch.Text = "BLISCH";
            this.btnBlisch.UseVisualStyleBackColor = false;
            this.btnBlisch.Click += new System.EventHandler(this.btnBlisch_Click);
            // 
            // btnLich
            // 
            this.btnLich.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLich.Location = new System.Drawing.Point(401, 147);
            this.btnLich.Name = "btnLich";
            this.btnLich.Size = new System.Drawing.Size(106, 71);
            this.btnLich.TabIndex = 19;
            this.btnLich.Text = "LICH";
            this.btnLich.UseVisualStyleBackColor = false;
            this.btnLich.Click += new System.EventHandler(this.btnLich_Click);
            // 
            // btnResich
            // 
            this.btnResich.BackColor = System.Drawing.Color.GhostWhite;
            this.btnResich.Location = new System.Drawing.Point(513, 45);
            this.btnResich.Name = "btnResich";
            this.btnResich.Size = new System.Drawing.Size(106, 71);
            this.btnResich.TabIndex = 20;
            this.btnResich.Text = "REISCH";
            this.btnResich.UseVisualStyleBackColor = false;
            this.btnResich.Click += new System.EventHandler(this.btnResich_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(18, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 23);
            this.txtSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSearch.Location = new System.Drawing.Point(190, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 50);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.lblReischSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblBlischSearch);
            this.groupBox1.Controls.Add(this.lblEischSearch);
            this.groupBox1.Controls.Add(this.lblLichSearch);
            this.groupBox1.Location = new System.Drawing.Point(667, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 254);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // lblReischSearch
            // 
            this.lblReischSearch.AutoSize = true;
            this.lblReischSearch.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReischSearch.Location = new System.Drawing.Point(14, 225);
            this.lblReischSearch.Name = "lblReischSearch";
            this.lblReischSearch.Size = new System.Drawing.Size(78, 20);
            this.lblReischSearch.TabIndex = 28;
            this.lblReischSearch.Text = "REISCH:";
            // 
            // lblBlischSearch
            // 
            this.lblBlischSearch.AutoSize = true;
            this.lblBlischSearch.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlischSearch.Location = new System.Drawing.Point(14, 186);
            this.lblBlischSearch.Name = "lblBlischSearch";
            this.lblBlischSearch.Size = new System.Drawing.Size(77, 20);
            this.lblBlischSearch.TabIndex = 27;
            this.lblBlischSearch.Text = "BLISCH:";
            // 
            // lblEischSearch
            // 
            this.lblEischSearch.AutoSize = true;
            this.lblEischSearch.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEischSearch.Location = new System.Drawing.Point(14, 114);
            this.lblEischSearch.Name = "lblEischSearch";
            this.lblEischSearch.Size = new System.Drawing.Size(66, 20);
            this.lblEischSearch.TabIndex = 25;
            this.lblEischSearch.Text = "EISCH:";
            // 
            // lblLichSearch
            // 
            this.lblLichSearch.AutoSize = true;
            this.lblLichSearch.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichSearch.Location = new System.Drawing.Point(14, 150);
            this.lblLichSearch.Name = "lblLichSearch";
            this.lblLichSearch.Size = new System.Drawing.Size(57, 20);
            this.lblLichSearch.TabIndex = 26;
            this.lblLichSearch.Text = "LICH:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEisch_perf);
            this.groupBox2.Controls.Add(this.lblReisch_perf);
            this.groupBox2.Controls.Add(this.lblBlisch_perf);
            this.groupBox2.Controls.Add(this.lblLich_perf);
            this.groupBox2.Location = new System.Drawing.Point(955, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 254);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Performance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1671, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 46);
            this.label7.TabIndex = 30;
            this.label7.Text = "CANSU AYTEN\r\n    171180010\r\n";
            // 
            // lblPrimaryArea
            // 
            this.lblPrimaryArea.AutoSize = true;
            this.lblPrimaryArea.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryArea.Location = new System.Drawing.Point(37, 147);
            this.lblPrimaryArea.Name = "lblPrimaryArea";
            this.lblPrimaryArea.Size = new System.Drawing.Size(220, 20);
            this.lblPrimaryArea.TabIndex = 31;
            this.lblPrimaryArea.Text = "Primary Area for Lich (0,86):";
            // 
            // lblHashSize
            // 
            this.lblHashSize.AutoSize = true;
            this.lblHashSize.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashSize.Location = new System.Drawing.Point(37, 178);
            this.lblHashSize.Name = "lblHashSize";
            this.lblHashSize.Size = new System.Drawing.Size(97, 20);
            this.lblHashSize.TabIndex = 32;
            this.lblHashSize.Text = "Hash Table:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1279, 738);
            this.Controls.Add(this.lblHashSize);
            this.Controls.Add(this.lblPrimaryArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResich);
            this.Controls.Add(this.btnLich);
            this.Controls.Add(this.btnBlisch);
            this.Controls.Add(this.btnEisch);
            this.Controls.Add(this.lblPackingFactor);
            this.Controls.Add(this.txtKeysize);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstView_reisch);
            this.Controls.Add(this.lstView_blisch);
            this.Controls.Add(this.lstView_lich);
            this.Controls.Add(this.lstView_eisch);
            this.Controls.Add(this.lstView_table);
            this.Font = new System.Drawing.Font("Calisto MT", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coalesced Hashing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstView_table;
        private System.Windows.Forms.ListView lstView_eisch;
        private System.Windows.Forms.ListView lstView_lich;
        private System.Windows.Forms.ListView lstView_blisch;
        private System.Windows.Forms.ListView lstView_reisch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEisch_perf;
        private System.Windows.Forms.Label lblReisch_perf;
        private System.Windows.Forms.Label lblBlisch_perf;
        private System.Windows.Forms.Label lblLich_perf;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtKeysize;
        private System.Windows.Forms.Label lblPackingFactor;
        private System.Windows.Forms.Button btnEisch;
        private System.Windows.Forms.Button btnBlisch;
        private System.Windows.Forms.Button btnLich;
        private System.Windows.Forms.Button btnResich;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label lblReischSearch;
        private System.Windows.Forms.Label lblBlischSearch;
        private System.Windows.Forms.Label lblEischSearch;
        private System.Windows.Forms.Label lblLichSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrimaryArea;
        private System.Windows.Forms.Label lblHashSize;
    }
}

