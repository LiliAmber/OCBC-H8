using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Web_API_Kantor.Models
{
    public class EmployeeItem
    {
        //public EmployeeItem()
        //{
        //}

        private Models.EmployeeContext context;

        public int id { get; set; }
        public string nama { get; set; }
        public string jenis_kelmain { get; set; }
        public string alamat { get; set; }

    }
}
