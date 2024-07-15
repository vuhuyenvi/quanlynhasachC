using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.QLKH
{
    internal class KhachHangBUS
    {
        KhachHangDAO khachHangDAO;
        public KhachHangBUS() 
        { 
            khachHangDAO = new KhachHangDAO();
        }
        public List<KhachHangDTO> getAll()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            DataTable dt = khachHangDAO.getAll();
            //chuyen mõi dong cua dt => KhoaDTO => them vao list
            foreach (DataRow row in dt.Rows)
            {
                KhachHangDTO khDTO = new KhachHangDTO(row["MAKH"].ToString(), row["HOTENKH"].ToString(), row["EMAILKH"].ToString(), row["DIACHIKH"].ToString(), row["SODT"].ToString());
                list.Add(khDTO);
            }
            return list;
        }
        public bool Update(KhachHangDTO khDTO)
        {
            return khachHangDAO.update(khDTO);
        }
        public bool delete(KhachHangDTO khDTO)
        {
            return khachHangDAO.Delete(khDTO);
        }
    }
}
