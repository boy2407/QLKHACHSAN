﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
   public class THIETBI
    {
        Entities db;
        public THIETBI()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_ThietBi>getALL(string macty, string madvi)
        {
            return db.tb_ThietBi.Where(x=>x.MADVI==madvi&&x.MACTY==macty).ToList();
        }
        /// <summary>
        /// true IN
        /// false OUT
        /// </summary>
        /// <param name="idphong"></param>
        /// <param name="bl"></param>
        /// <returns></returns>
        public List<tb_ThietBi> getALLInOrOut_Room(int idphong,bool bl)
        {
            List<tb_ThietBi> lstTB = new List<tb_ThietBi>();
            var lst = db.tb_Phong_ThietBi.Where(x => x.IDPHONG == idphong).ToList();
            var lsttb = db.tb_ThietBi.ToList();
            if (bl)
            {
               
                foreach (var item in lsttb)
                {
                    foreach (var it in lst)
                    {
                        if (item.IDTB != it.IDTB)
                        {
                            lstTB.Add(item);
                        }
                    }

                }
                return lstTB;
            }    
            else
            {
              
                foreach (var item in lsttb)
                {
                    foreach (var it in lst)
                    {
                        if (item.IDTB != it.IDTB )
                        {
                            lstTB.Add(item);

                        }    
                    }
                   
                }
                return lstTB;
            }    
           
            
        }
        public tb_ThietBi getItem(int idtb)
        {
            return db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idtb);
        }
        public int  UsebleQuantily( int idtb)
        {         
           var tb = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idtb);
           int res = (int)(tb.TONGSLN - tb.TONGSLX);
            return res;
        }
        public void add(tb_ThietBi tb)
        {
            try
            {
                db.tb_ThietBi.Add(tb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void update(tb_ThietBi tb)
        {
            tb_ThietBi _tb = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == tb.IDTB);
            _tb.TENTB = tb.TENTB;
            _tb.DONGIA = tb.DONGIA;
            _tb.TONGSLX = tb.TONGSLX;
            _tb.TONGSLN = tb.TONGSLN;
            try
            {
             
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void delete(int idtb)
        {
            tb_ThietBi _tb = db.tb_ThietBi.FirstOrDefault(x => x.IDTB == idtb);
            db.tb_ThietBi.Remove(_tb);
            try
            {

                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu." + ex.Message);
            }
        }
    }
}
