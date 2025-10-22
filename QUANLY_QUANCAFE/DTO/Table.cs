using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLY_QUANCAFE.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        private string name;
        private string status;
        private int iD;

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
