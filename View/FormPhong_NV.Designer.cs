
namespace QuanLyPhongTroLinQ.View
{
    partial class FormPhong_NV
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbID = new System.Windows.Forms.CheckBox();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.cbTen = new System.Windows.Forms.CheckBox();
            this.cbLoai = new System.Windows.Forms.CheckBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.DGVPhongTro = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.butDefault = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.lblNote);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.gbSearch);
            this.panel4.Controls.Add(this.lblTieuDe);
            this.panel4.Controls.Add(this.DGVPhongTro);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.butDefault);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 496);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách phòng trọ";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbID);
            this.gbSearch.Controls.Add(this.cbTT);
            this.gbSearch.Controls.Add(this.cbTen);
            this.gbSearch.Controls.Add(this.cbLoai);
            this.gbSearch.Location = new System.Drawing.Point(35, 158);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSearch.Size = new System.Drawing.Size(406, 36);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search theo:";
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Location = new System.Drawing.Point(25, 15);
            this.cbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(37, 17);
            this.cbID.TabIndex = 4;
            this.cbID.Text = "ID";
            this.cbID.UseVisualStyleBackColor = true;
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(321, 15);
            this.cbTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(74, 17);
            this.cbTT.TabIndex = 4;
            this.cbTT.Text = "Tình trạng";
            this.cbTT.UseVisualStyleBackColor = true;
            // 
            // cbTen
            // 
            this.cbTen.AutoSize = true;
            this.cbTen.Location = new System.Drawing.Point(99, 15);
            this.cbTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(78, 17);
            this.cbTen.TabIndex = 4;
            this.cbTen.Text = "Tên phòng";
            this.cbTen.UseVisualStyleBackColor = true;
            // 
            // cbLoai
            // 
            this.cbLoai.AutoSize = true;
            this.cbLoai.Location = new System.Drawing.Point(208, 15);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(79, 17);
            this.cbLoai.TabIndex = 4;
            this.cbLoai.Text = "Loại phòng";
            this.cbLoai.UseVisualStyleBackColor = true;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(187, 196);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(421, 40);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Bảng danh sách các phòng trọ";
            // 
            // DGVPhongTro
            // 
            this.DGVPhongTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPhongTro.ColumnHeadersHeight = 30;
            this.DGVPhongTro.Location = new System.Drawing.Point(38, 238);
            this.DGVPhongTro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVPhongTro.Name = "DGVPhongTro";
            this.DGVPhongTro.RowHeadersWidth = 80;
            this.DGVPhongTro.RowTemplate.Height = 24;
            this.DGVPhongTro.Size = new System.Drawing.Size(701, 191);
            this.DGVPhongTro.TabIndex = 2;
            this.DGVPhongTro.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVPhongTro_RowHeaderMouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.ForeColor = System.Drawing.Color.Yellow;
            this.btnSearch.Location = new System.Drawing.Point(505, 97);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 44);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // butDefault
            // 
            this.butDefault.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butDefault.ForeColor = System.Drawing.Color.Yellow;
            this.butDefault.Location = new System.Drawing.Point(505, 150);
            this.butDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butDefault.Name = "butDefault";
            this.butDefault.Size = new System.Drawing.Size(132, 44);
            this.butDefault.TabIndex = 1;
            this.butDefault.Text = "Default";
            this.butDefault.UseVisualStyleBackColor = false;
            this.butDefault.Click += new System.EventHandler(this.butDefault_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(35, 105);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(117, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNote.Location = new System.Drawing.Point(35, 450);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(299, 32);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "Ghi chú : Có thể xem thiết bị 1 phòng bằng \r\ncách double click chuột trái";
            // 
            // FormPhong_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 514);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 70);
            this.Name = "FormPhong_NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhongTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView DGVPhongTro;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.CheckBox cbID;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.CheckBox cbTen;
        private System.Windows.Forms.CheckBox cbLoai;
        private System.Windows.Forms.Button butDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNote;
    }
}