using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi.Data
{
    public class Board
    {
        public List<Card>? ToDo { get; set; }
        public List<Card>? InProgress { get; set; }
        public List<Card>? Done { get; set; }
    }
}
