namespace mika_desktop.Mhs
{
    partial class MhsForm
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
            this.tbSearchMhs = new System.Windows.Forms.TextBox();
            this.dgvMhs = new System.Windows.Forms.DataGridView();
            this.mhsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhsNIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhsNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhsJurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhsPeminatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhsSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhsKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFilterMhs = new System.Windows.Forms.ComboBox();
            this.btnFilterMhs = new System.Windows.Forms.Button();
            this.btnNilaiMhs = new System.Windows.Forms.Button();
            this.btnAbsensiMhs = new System.Windows.Forms.Button();
            this.btnProfilMhs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMhs = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMngAbsence = new System.Windows.Forms.Button();
            this.btnMngScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchMhs
            // 
            this.tbSearchMhs.Location = new System.Drawing.Point(98, 71);
            this.tbSearchMhs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbSearchMhs.Name = "tbSearchMhs";
            this.tbSearchMhs.Size = new System.Drawing.Size(210, 26);
            this.tbSearchMhs.TabIndex = 0;
            // 
            // dgvMhs
            // 
            this.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMhs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mhsNo,
            this.mhsNIM,
            this.mhsNama,
            this.mhsJurusan,
            this.mhsPeminatan,
            this.mhsSemester,
            this.mhsKelas});
            this.dgvMhs.Location = new System.Drawing.Point(12, 107);
            this.dgvMhs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvMhs.Name = "dgvMhs";
            this.dgvMhs.Size = new System.Drawing.Size(1143, 586);
            this.dgvMhs.TabIndex = 1;
            this.dgvMhs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMhs_CellContentClick);
            // 
            // mhsNo
            // 
            this.mhsNo.HeaderText = "No";
            this.mhsNo.Name = "mhsNo";
            // 
            // mhsNIM
            // 
            this.mhsNIM.HeaderText = "NIM";
            this.mhsNIM.Name = "mhsNIM";
            // 
            // mhsNama
            // 
            this.mhsNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mhsNama.HeaderText = "Nama";
            this.mhsNama.Name = "mhsNama";
            // 
            // mhsJurusan
            // 
            this.mhsJurusan.HeaderText = "Jurusan";
            this.mhsJurusan.Name = "mhsJurusan";
            this.mhsJurusan.Width = 200;
            // 
            // mhsPeminatan
            // 
            this.mhsPeminatan.HeaderText = "Peminatan";
            this.mhsPeminatan.Name = "mhsPeminatan";
            this.mhsPeminatan.Width = 200;
            // 
            // mhsSemester
            // 
            this.mhsSemester.HeaderText = "Semester";
            this.mhsSemester.Name = "mhsSemester";
            // 
            // mhsKelas
            // 
            this.mhsKelas.HeaderText = "Kelas";
            this.mhsKelas.Name = "mhsKelas";
            // 
            // cbFilterMhs
            // 
            this.cbFilterMhs.FormattingEnabled = true;
            this.cbFilterMhs.Location = new System.Drawing.Point(370, 71);
            this.cbFilterMhs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbFilterMhs.Name = "cbFilterMhs";
            this.cbFilterMhs.Size = new System.Drawing.Size(135, 28);
            this.cbFilterMhs.TabIndex = 2;
            // 
            // btnFilterMhs
            // 
            this.btnFilterMhs.Location = new System.Drawing.Point(523, 67);
            this.btnFilterMhs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFilterMhs.Name = "btnFilterMhs";
            this.btnFilterMhs.Size = new System.Drawing.Size(88, 35);
            this.btnFilterMhs.TabIndex = 3;
            this.btnFilterMhs.Text = "Confirm";
            this.btnFilterMhs.UseVisualStyleBackColor = true;
            // 
            // btnNilaiMhs
            // 
            this.btnNilaiMhs.Location = new System.Drawing.Point(45, 26);
            this.btnNilaiMhs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNilaiMhs.Name = "btnNilaiMhs";
            this.btnNilaiMhs.Size = new System.Drawing.Size(99, 35);
            this.btnNilaiMhs.TabIndex = 4;
            this.btnNilaiMhs.Text = "Nilai";
            this.btnNilaiMhs.UseVisualStyleBackColor = true;
            // 
            // btnAbsensiMhs
            // 
            this.btnAbsensiMhs.Location = new System.Drawing.Point(150, 26);
            this.btnAbsensiMhs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAbsensiMhs.Name = "btnAbsensiMhs";
            this.btnAbsensiMhs.Size = new System.Drawing.Size(99, 35);
            this.btnAbsensiMhs.TabIndex = 5;
            this.btnAbsensiMhs.Text = "Absensi";
            this.btnAbsensiMhs.UseVisualStyleBackColor = true;
            // 
            // btnProfilMhs
            // 
            this.btnProfilMhs.Location = new System.Drawing.Point(255, 26);
            this.btnProfilMhs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnProfilMhs.Name = "btnProfilMhs";
            this.btnProfilMhs.Size = new System.Drawing.Size(99, 35);
            this.btnProfilMhs.TabIndex = 6;
            this.btnProfilMhs.Text = "Profil";
            this.btnProfilMhs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter";
            // 
            // btnAddMhs
            // 
            this.btnAddMhs.Location = new System.Drawing.Point(1032, 26);
            this.btnAddMhs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddMhs.Name = "btnAddMhs";
            this.btnAddMhs.Size = new System.Drawing.Size(123, 35);
            this.btnAddMhs.TabIndex = 9;
            this.btnAddMhs.Text = "Add New Student";
            this.btnAddMhs.UseVisualStyleBackColor = true;
            this.btnAddMhs.Click += new System.EventHandler(this.btnAddMhs_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1080, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMngAbsence
            // 
            this.btnMngAbsence.Location = new System.Drawing.Point(897, 26);
            this.btnMngAbsence.Name = "btnMngAbsence";
            this.btnMngAbsence.Size = new System.Drawing.Size(129, 35);
            this.btnMngAbsence.TabIndex = 11;
            this.btnMngAbsence.Text = "Manage Absence";
            this.btnMngAbsence.UseVisualStyleBackColor = true;
            this.btnMngAbsence.Click += new System.EventHandler(this.btnMngAbsence_Click);
            // 
            // btnMngScore
            // 
            this.btnMngScore.Location = new System.Drawing.Point(772, 26);
            this.btnMngScore.Name = "btnMngScore";
            this.btnMngScore.Size = new System.Drawing.Size(119, 35);
            this.btnMngScore.TabIndex = 12;
            this.btnMngScore.Text = "Manage Score";
            this.btnMngScore.UseVisualStyleBackColor = true;
            this.btnMngScore.Click += new System.EventHandler(this.btnMngScore_Click);
            // 
            // MhsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 729);
            this.Controls.Add(this.btnMngScore);
            this.Controls.Add(this.btnMngAbsence);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddMhs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProfilMhs);
            this.Controls.Add(this.btnAbsensiMhs);
            this.Controls.Add(this.btnNilaiMhs);
            this.Controls.Add(this.btnFilterMhs);
            this.Controls.Add(this.cbFilterMhs);
            this.Controls.Add(this.dgvMhs);
            this.Controls.Add(this.tbSearchMhs);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MhsForm";
            this.Text = "MhsForm";
            this.Load += new System.EventHandler(this.MhsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchMhs;
        private System.Windows.Forms.DataGridView dgvMhs;
        private System.Windows.Forms.ComboBox cbFilterMhs;
        private System.Windows.Forms.Button btnFilterMhs;
        private System.Windows.Forms.Button btnNilaiMhs;
        private System.Windows.Forms.Button btnAbsensiMhs;
        private System.Windows.Forms.Button btnProfilMhs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMhs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsNIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsJurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsPeminatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsKelas;
        private System.Windows.Forms.Button btnMngAbsence;
        private System.Windows.Forms.Button btnMngScore;
    }
}