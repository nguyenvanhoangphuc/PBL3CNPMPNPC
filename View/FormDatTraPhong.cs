﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTroLinQ.DTO;
using QuanLyPhongTroLinQ.BLL;
namespace QuanLyPhongTroLinQ.View
{
    public partial class FormDatTraPhong : Form
    {
        public FormDatTraPhong()
        {
            InitializeComponent();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = BLL_DatTraPhong.Instance.GetNguoiChuaThueBySDT(txtSDT.Text);
            dgv.Columns["QLDatPhongs"].Visible = false;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                FormDatPhong f = new FormDatPhong(new NguoiThue()
                {
                    ID = dgv.SelectedRows[0].Cells["ID"].Value.ToString(),
                    SDT = dgv.SelectedRows[0].Cells["SDT"].Value.ToString(),
                    CCCD = dgv.SelectedRows[0].Cells["CCCD"].Value.ToString(),
                    HoTen = dgv.SelectedRows[0].Cells["HoTen"].Value.ToString(),
                    QueQuan = dgv.SelectedRows[0].Cells["QueQuan"].Value.ToString(),
                    TinhTrang = Convert.ToBoolean(dgv.SelectedRows[0].Cells["TinhTrang"].Value.ToString())
                }
                );
                f.t = new FormDatPhong.Mydel(Refreshdgv);
                f.Show();
            }
        }
        public void Refreshdgv()
        {
            dgv.DataSource = BLL_DatTraPhong.Instance.GetNguoiChuaThueBySDT(txtSDT.Text);
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            FormTraPhong f = new FormTraPhong();
            f.t = new FormTraPhong.Mydel(Refresh);
            f.Show();


        }
    }
}
