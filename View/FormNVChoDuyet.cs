﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.BLL;

namespace QuanLyPhongTroLinQ.View
{
    public partial class FormNVChoDuyet : Form
    {
        public FormNVChoDuyet()
        {
            InitializeComponent();
            showDGV(); 
        }

        private void showDGV()
        {
            DGVNVChon.DataSource = NhanVienBLL.Instance.GetDSNVViewChoDuyet();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (DGVNVChon.SelectedRows.Count >0)
            {
                foreach(DataGridViewRow dgvr in DGVNVChon.SelectedRows)
                {
                    list.Add(dgvr.Cells[0].Value.ToString());
                }
            }
            DGVNVDuyet.DataSource = NhanVienBLL.Instance.GetDSNhanVienViewByID(list); 
        }

        private void butConf_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (DataGridViewRow dgvr in DGVNVDuyet.SelectedRows)
            {
                list.Add(dgvr.Cells[0].Value.ToString());
            }
            NhanVienBLL.Instance.ChapNhanDSNhanVien(list);
        }
    }
}
