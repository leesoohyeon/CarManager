namespace CarManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_parkingremove = new System.Windows.Forms.Button();
            this.button_parkingadd = new System.Windows.Forms.Button();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.textBox_drivername = new System.Windows.Forms.TextBox();
            this.textBox_carnumber = new System.Windows.Forms.TextBox();
            this.textBox_parkingspot = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_allLookup = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.textBox_parkingspot_lookup = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_parkingManager = new System.Windows.Forms.DataGridView();
            this.listBox_logPrint = new System.Windows.Forms.ListBox();
            this.timer_DisplayNow = new System.Windows.Forms.Timer(this.components);
            this.statusStrip_Now = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_now = new System.Windows.Forms.ToolStripStatusLabel();
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).BeginInit();
            this.statusStrip_Now.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_parkingremove);
            this.groupBox1.Controls.Add(this.button_parkingadd);
            this.groupBox1.Controls.Add(this.textBox_phonenumber);
            this.groupBox1.Controls.Add(this.textBox_drivername);
            this.groupBox1.Controls.Add(this.textBox_carnumber);
            this.groupBox1.Controls.Add(this.textBox_parkingspot);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차/출차";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "차주이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "차량번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "공간번호";
            // 
            // button_parkingremove
            // 
            this.button_parkingremove.Location = new System.Drawing.Point(199, 55);
            this.button_parkingremove.Name = "button_parkingremove";
            this.button_parkingremove.Size = new System.Drawing.Size(75, 23);
            this.button_parkingremove.TabIndex = 5;
            this.button_parkingremove.Text = "출차";
            this.button_parkingremove.UseVisualStyleBackColor = true;
            this.button_parkingremove.Click += new System.EventHandler(this.button_parkingremove_Click);
            // 
            // button_parkingadd
            // 
            this.button_parkingadd.Location = new System.Drawing.Point(199, 25);
            this.button_parkingadd.Name = "button_parkingadd";
            this.button_parkingadd.Size = new System.Drawing.Size(75, 23);
            this.button_parkingadd.TabIndex = 4;
            this.button_parkingadd.Text = "주차";
            this.button_parkingadd.UseVisualStyleBackColor = true;
            this.button_parkingadd.Click += new System.EventHandler(this.button_parkingadd_Click);
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(71, 117);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(100, 25);
            this.textBox_phonenumber.TabIndex = 3;
            // 
            // textBox_drivername
            // 
            this.textBox_drivername.Location = new System.Drawing.Point(71, 86);
            this.textBox_drivername.Name = "textBox_drivername";
            this.textBox_drivername.Size = new System.Drawing.Size(100, 25);
            this.textBox_drivername.TabIndex = 2;
            // 
            // textBox_carnumber
            // 
            this.textBox_carnumber.Location = new System.Drawing.Point(71, 55);
            this.textBox_carnumber.Name = "textBox_carnumber";
            this.textBox_carnumber.Size = new System.Drawing.Size(100, 25);
            this.textBox_carnumber.TabIndex = 1;
            // 
            // textBox_parkingspot
            // 
            this.textBox_parkingspot.Location = new System.Drawing.Point(71, 24);
            this.textBox_parkingspot.Name = "textBox_parkingspot";
            this.textBox_parkingspot.Size = new System.Drawing.Size(100, 25);
            this.textBox_parkingspot.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.button_allLookup);
            this.groupBox2.Controls.Add(this.button_select);
            this.groupBox2.Controls.Add(this.textBox_parkingspot_lookup);
            this.groupBox2.Location = new System.Drawing.Point(384, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 공간 현황 관리";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "공간번호";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(200, 89);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(174, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "공간추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_allLookup
            // 
            this.button_allLookup.Location = new System.Drawing.Point(200, 61);
            this.button_allLookup.Name = "button_allLookup";
            this.button_allLookup.Size = new System.Drawing.Size(174, 23);
            this.button_allLookup.TabIndex = 7;
            this.button_allLookup.Text = "전체조회";
            this.button_allLookup.UseVisualStyleBackColor = true;
            this.button_allLookup.Click += new System.EventHandler(this.button_allLookup_Click);
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(200, 30);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(174, 23);
            this.button_select.TabIndex = 6;
            this.button_select.Text = "해당 공간 조회";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // textBox_parkingspot_lookup
            // 
            this.textBox_parkingspot_lookup.Location = new System.Drawing.Point(84, 28);
            this.textBox_parkingspot_lookup.Name = "textBox_parkingspot_lookup";
            this.textBox_parkingspot_lookup.Size = new System.Drawing.Size(100, 25);
            this.textBox_parkingspot_lookup.TabIndex = 4;
            this.textBox_parkingspot_lookup.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_parkingManager);
            this.groupBox3.Location = new System.Drawing.Point(25, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 202);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주차 현황";
            // 
            // dataGridView_parkingManager
            // 
            this.dataGridView_parkingManager.AllowUserToAddRows = false;
            this.dataGridView_parkingManager.AllowUserToDeleteRows = false;
            this.dataGridView_parkingManager.AutoGenerateColumns = false;
            this.dataGridView_parkingManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parkingManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn});
            this.dataGridView_parkingManager.DataSource = this.parkingCarBindingSource;
            this.dataGridView_parkingManager.Location = new System.Drawing.Point(7, 25);
            this.dataGridView_parkingManager.Name = "dataGridView_parkingManager";
            this.dataGridView_parkingManager.ReadOnly = true;
            this.dataGridView_parkingManager.RowHeadersWidth = 51;
            this.dataGridView_parkingManager.RowTemplate.Height = 27;
            this.dataGridView_parkingManager.Size = new System.Drawing.Size(726, 150);
            this.dataGridView_parkingManager.TabIndex = 0;
            this.dataGridView_parkingManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_parkingManager_CellClick);
            // 
            // listBox_logPrint
            // 
            this.listBox_logPrint.FormattingEnabled = true;
            this.listBox_logPrint.ItemHeight = 15;
            this.listBox_logPrint.Location = new System.Drawing.Point(25, 397);
            this.listBox_logPrint.Name = "listBox_logPrint";
            this.listBox_logPrint.Size = new System.Drawing.Size(752, 109);
            this.listBox_logPrint.TabIndex = 2;
            // 
            // timer_DisplayNow
            // 
            this.timer_DisplayNow.Enabled = true;
            this.timer_DisplayNow.Interval = 1000;
            this.timer_DisplayNow.Tick += new System.EventHandler(this.timer_DisplayNow_Tick);
            // 
            // statusStrip_Now
            // 
            this.statusStrip_Now.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Now.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_now});
            this.statusStrip_Now.Location = new System.Drawing.Point(0, 509);
            this.statusStrip_Now.Name = "statusStrip_Now";
            this.statusStrip_Now.Size = new System.Drawing.Size(800, 26);
            this.statusStrip_Now.TabIndex = 3;
            this.statusStrip_Now.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_now
            // 
            this.toolStripStatusLabel_now.Name = "toolStripStatusLabel_now";
            this.toolStripStatusLabel_now.Size = new System.Drawing.Size(12, 20);
            this.toolStripStatusLabel_now.Text = ".";
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "ParkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingSpotDataGridViewTextBoxColumn.Width = 125;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "DriverName";
            this.driverNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "ParkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            this.parkingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(CarManager.ParkingCar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.statusStrip_Now);
            this.Controls.Add(this.listBox_logPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parkingManager)).EndInit();
            this.statusStrip_Now.ResumeLayout(false);
            this.statusStrip_Now.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_parkingremove;
        private System.Windows.Forms.Button button_parkingadd;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.TextBox textBox_drivername;
        private System.Windows.Forms.TextBox textBox_carnumber;
        private System.Windows.Forms.TextBox textBox_parkingspot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_allLookup;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.TextBox textBox_parkingspot_lookup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_parkingManager;
        private System.Windows.Forms.ListBox listBox_logPrint;
        private System.Windows.Forms.Timer timer_DisplayNow;
        private System.Windows.Forms.StatusStrip statusStrip_Now;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_now;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
    }
}

