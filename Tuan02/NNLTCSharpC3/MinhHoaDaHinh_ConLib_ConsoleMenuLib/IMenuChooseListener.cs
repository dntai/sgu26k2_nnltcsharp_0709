using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNLTCS.UTILS.ConsoleLib
{
    public interface IMenuChooseListener
    {
        void MenuChoose(object sender, MenuChooseEventArgs args);
    }
}
