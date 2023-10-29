namespace DrogaHamowania
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.samochod = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerAnimacjaHamowania = new System.Windows.Forms.Timer(this.components);
            this.numNachylenie = new System.Windows.Forms.NumericUpDown();
            this.numTarcie = new System.Windows.Forms.NumericUpDown();
            this.numPredkosc = new System.Windows.Forms.NumericUpDown();
            this.numReakcja = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblwynik = new System.Windows.Forms.Label();
            this.wynikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wynikiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBwynikiDataSet = new DrogaHamowania.DBwynikiDataSet();
            this.wynikiTableAdapter = new DrogaHamowania.DBwynikiDataSetTableAdapters.WynikiTableAdapter();
            this.tableAdapterManager = new DrogaHamowania.DBwynikiDataSetTableAdapters.TableAdapterManager();
            this.wynikiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.samochod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNachylenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarcie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPredkosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReakcja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBwynikiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(421, 284);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 37);
            this.btnStop.TabIndex = 31;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(342, 284);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 37);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // samochod
            // 
            this.samochod.BackColor = System.Drawing.SystemColors.HotTrack;
            this.samochod.Location = new System.Drawing.Point(0, 353);
            this.samochod.Name = "samochod";
            this.samochod.Size = new System.Drawing.Size(78, 48);
            this.samochod.TabIndex = 29;
            this.samochod.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 18);
            this.panel1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "km/h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Czas Reakcji Kierowcy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tarcie opon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prędkość samohodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nachylenie samochodu (+ ku górze, - w dół )";
            // 
            // timerAnimacjaHamowania
            // 
            this.timerAnimacjaHamowania.Enabled = true;
            this.timerAnimacjaHamowania.Interval = 20;
            this.timerAnimacjaHamowania.Tick += new System.EventHandler(this.timerAnimacjaHamowania_Tick);
            // 
            // numNachylenie
            // 
            this.numNachylenie.Location = new System.Drawing.Point(15, 60);
            this.numNachylenie.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numNachylenie.Name = "numNachylenie";
            this.numNachylenie.Size = new System.Drawing.Size(101, 20);
            this.numNachylenie.TabIndex = 32;
            // 
            // numTarcie
            // 
            this.numTarcie.DecimalPlaces = 2;
            this.numTarcie.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numTarcie.Location = new System.Drawing.Point(15, 214);
            this.numTarcie.Name = "numTarcie";
            this.numTarcie.Size = new System.Drawing.Size(101, 20);
            this.numTarcie.TabIndex = 33;
            // 
            // numPredkosc
            // 
            this.numPredkosc.Location = new System.Drawing.Point(15, 133);
            this.numPredkosc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPredkosc.Name = "numPredkosc";
            this.numPredkosc.Size = new System.Drawing.Size(101, 20);
            this.numPredkosc.TabIndex = 34;
            // 
            // numReakcja
            // 
            this.numReakcja.DecimalPlaces = 2;
            this.numReakcja.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numReakcja.Location = new System.Drawing.Point(15, 281);
            this.numReakcja.Name = "numReakcja";
            this.numReakcja.Size = new System.Drawing.Size(48, 20);
            this.numReakcja.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "s";
            // 
            // lblwynik
            // 
            this.lblwynik.AutoSize = true;
            this.lblwynik.Location = new System.Drawing.Point(232, 324);
            this.lblwynik.Name = "lblwynik";
            this.lblwynik.Size = new System.Drawing.Size(183, 13);
            this.lblwynik.TabIndex = 38;
            this.lblwynik.Text = "Całkowita droga hamowania wynosi: ";
            // 
            // wynikiBindingSource
            // 
            this.wynikiBindingSource.DataMember = "Wyniki";
            // 
            // wynikiBindingSource1
            // 
            this.wynikiBindingSource1.DataMember = "Wyniki";
            this.wynikiBindingSource1.DataSource = this.dBwynikiDataSet;
            // 
            // dBwynikiDataSet
            // 
            this.dBwynikiDataSet.DataSetName = "DBwynikiDataSet";
            this.dBwynikiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wynikiTableAdapter
            // 
            this.wynikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DrogaHamowania.DBwynikiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WynikiTableAdapter = this.wynikiTableAdapter;
            // 
            // wynikiDataGridView
            // 
            this.wynikiDataGridView.AutoGenerateColumns = false;
            this.wynikiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wynikiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.wynikiDataGridView.DataSource = this.wynikiBindingSource1;
            this.wynikiDataGridView.Location = new System.Drawing.Point(235, 25);
            this.wynikiDataGridView.Name = "wynikiDataGridView";
            this.wynikiDataGridView.Size = new System.Drawing.Size(566, 253);
            this.wynikiDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "predkosc";
            this.dataGridViewTextBoxColumn8.HeaderText = "predkosc";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nachylenie";
            this.dataGridViewTextBoxColumn9.HeaderText = "nachylenie";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "tarcie";
            this.dataGridViewTextBoxColumn10.HeaderText = "tarcie";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "reakcja";
            this.dataGridViewTextBoxColumn11.HeaderText = "reakcja";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "droga";
            this.dataGridViewTextBoxColumn12.HeaderText = "droga";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.wynikiDataGridView);
            this.Controls.Add(this.lblwynik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numReakcja);
            this.Controls.Add(this.numPredkosc);
            this.Controls.Add(this.numTarcie);
            this.Controls.Add(this.numNachylenie);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.samochod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samochod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNachylenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTarcie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPredkosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReakcja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBwynikiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox samochod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerAnimacjaHamowania;
        private System.Windows.Forms.NumericUpDown numNachylenie;
        private System.Windows.Forms.NumericUpDown numTarcie;
        private System.Windows.Forms.NumericUpDown numPredkosc;
        private System.Windows.Forms.NumericUpDown numReakcja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblwynik;
        private System.Windows.Forms.BindingSource wynikiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DBwynikiDataSet dBwynikiDataSet;
        private System.Windows.Forms.BindingSource wynikiBindingSource1;
        private DBwynikiDataSetTableAdapters.WynikiTableAdapter wynikiTableAdapter;
        private DBwynikiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView wynikiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

