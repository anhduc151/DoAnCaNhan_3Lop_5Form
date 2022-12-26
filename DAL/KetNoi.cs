using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KetNoi
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Truong_Hoc\win_form\source\repos\DoAnCaNhan_3Lop_5Form\GUI\DoAn.mdf;Integrated Security=True");
    }
}
