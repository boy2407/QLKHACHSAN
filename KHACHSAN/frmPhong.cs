﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
namespace KHACHSAN
{
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmPhong()
        {
            InitializeComponent();
            DataTable datatbl = Friend.laydulieu("select  C.IDLOAIPHONG,C.IDPHONG,C.TRANGTHAI,C.IDTANG,B.TENLOAIPHONG,A.TENTANG,C.TENPHONG from tb_Tang A, tb_LoaiPhong  B, tb_Phong C where A.IDTANG = C.IDTANG and B.IDLOAIPHONG = C.IDLOAIPHONG");
            gcDanhSach.DataSource = datatbl;
        }
        public frmPhong(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        tb_SYS_USER _user;
        int _right;

        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        PHONG _phong;
        TANG _tang;
        LOAIPHONG _loaiphong;
        bool _them;
        string _idp;
        private void frmPhong_Load(object sender, EventArgs e)
        {
            _tang = new TANG();
            _phong = new PHONG();
            _loaiphong = new LOAIPHONG();

            
            loadTang();
           loadLoaiPhong();
            showHideControl(true);
            _enabled(false);
            loadData();
         
        }

        private void CboTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPhongByIDTang();
        }

        private void CboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPhongByIDLoaiPhong();
        }

        void loadData()
        {
            DataTable datatbl = Friend.laydulieu("select  C.IDLOAIPHONG,C.IDPHONG,C.TRANGTHAI,C.IDTANG,B.TENLOAIPHONG,A.TENTANG,C.TENPHONG from tb_Tang A, tb_LoaiPhong  B, tb_Phong C where C.MACTY='"+Friend._macty+ "'and C.MADVI='" + Friend._madvi+ "'and A.IDTANG = C.IDTANG and B.IDLOAIPHONG = C.IDLOAIPHONG");
            gcDanhSach.DataSource = datatbl;
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadTang()
        {
            cboTang.DataSource = _tang.getALL(Friend._macty,Friend._madvi);
            cboTang.DisplayMember = "TENTANG";
            cboTang.ValueMember = "IDTANG";

        }
        void loadLoaiPhong()
        {
            cboLoaiPhong.DataSource = _loaiphong.getAll(Friend._macty, Friend._madvi);
            cboLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cboLoaiPhong.ValueMember = "IDLOAIPHONG";
            
        }
        void loadPhongByIDTang()
        {
            gcDanhSach.DataSource = _phong.getAll_tang(int.Parse(cboTang.SelectedValue.ToString()),Friend._macty,Friend._madvi);
            gvDanhSach.OptionsBehavior.Editable = false;
            
        }
        void loadPhongByIDLoaiPhong()
        {
            gcDanhSach.DataSource = _phong.getAll_loaiphong(int.Parse(cboLoaiPhong.SelectedValue.ToString()), Friend._macty, Friend._madvi);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }
        void _enabled(bool t)
        {
            txtTen.Enabled = t;
           
            cboLoaiPhong.Enabled = t;
            cboTang.Enabled = t;
            chkDisabled.Enabled = t;
        }
        void _reset()
        {
           
            
            txtTen.Text = "";          
            chkDisabled.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Bạn không có quyền thao tác?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            showHideControl(false);          
            _them = true;
            _enabled(true);
            _reset();
          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Bạn không có quyền thao tác?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _enabled(true);
            _them = false;
            showHideControl(false);
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Bạn không có quyền thao tác?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var p = _phong.getItem(int.Parse(_idp));
                if(p.TRANGTHAI==true)
                {
                    MessageBox.Show("Phòng đang được đặt không được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }    
                _phong.delete(int.Parse(_idp));
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Bạn không có quyền thao tác?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            if (_them == true)
            {
                tb_Phong p = new tb_Phong();              
                p.TENPHONG = txtTen.Text;
                p.IDLOAIPHONG = int.Parse(cboLoaiPhong.SelectedValue.ToString());             
                p.IDTANG = int.Parse(cboTang.SelectedValue.ToString());
                p.TRANGTHAI = chkDisabled.Checked;
                p.MACTY = Friend._macty;
                p.MADVI = Friend._madvi;

                ///toio khong co disabled 
                ///không có mà check box để disda
                _phong.add(p);
            }
            else
            {
                tb_Phong p = _phong.getItem(int.Parse(_idp));
                p.TENPHONG = txtTen.Text;
                p.IDLOAIPHONG = int.Parse(cboLoaiPhong.SelectedValue.ToString());
                p.IDTANG = int.Parse(cboTang.SelectedValue.ToString());             
                p.TRANGTHAI = chkDisabled.Checked;
                _phong.update(p);

            }
            objMain.gControl.Gallery.Groups.Clear();
            objMain.showRoom();
            loadData();
            _them = false;
            _enabled(false);
            
            showHideControl(true);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enabled(false);
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idp = gvDanhSach.GetFocusedRowCellValue("IDPHONG").ToString();

                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENPHONG").ToString();
                cboTang.Text = gvDanhSach.GetFocusedRowCellValue("TENTANG").ToString();
                cboLoaiPhong.Text = gvDanhSach.GetFocusedRowCellValue("TENLOAIPHONG").ToString();                
                chkDisabled.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());
            }
        }

        private void cboTang_KeyPress(object sender, KeyPressEventArgs e)
        {
           
             e.Handled = true;

        }
    }
}