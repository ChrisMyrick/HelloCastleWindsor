using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastleWindsorDI_Example.Views
{
    public interface IMainView
    {
        string Message { get; set; }
    }
}
