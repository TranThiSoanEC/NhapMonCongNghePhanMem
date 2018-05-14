﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BUS
{
    public class BUS_TaoLop
    {
        DAL_TaoLop dsLop = new DAL_TaoLop();
        DAL_TaoLop dsLopCoSan = new DAL_TaoLop();

        public DataTable getLopHoc()
        {
            return dsLop.getDanhSachLop();
        }
        public DataTable getLopHocCoSan(string NamHoc, string Lop)
        {
            return dsLopCoSan.getDanhSachLopCoSan(NamHoc, Lop);
        }

    }
}