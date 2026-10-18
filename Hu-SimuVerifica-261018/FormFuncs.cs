using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hu_SimuVerifica_261018
{
    public static class FormFuncs
    {
        public static void UpdateViewer<T>(DataGridView dgv, List<T> l)
        {
            dgv.DataSource = null;
            dgv.DataSource = l;
        }
    }
}
