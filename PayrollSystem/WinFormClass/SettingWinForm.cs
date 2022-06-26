using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public class SettingWinForm
    {
        public static Form CurrentForm { get; set; }
        public static Form DynamicForm { get; set; }
        public static Form ParentForm { get; set; }
        public static Form ChildForm { get; set; }
    }
}
