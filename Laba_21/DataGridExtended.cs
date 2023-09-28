using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Laba_21
{
    public class DataGridExtended : DataGrid
    {
        private int page;

        public int Page { get { return page; } set {  page = value; } }
    }
}
