using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies.Interface
{
    internal interface IAdminHandler
    {
        void DeleteItem(object item);

        Form CollectData();

        void AddItem(List<string> data);

        void ChangeItemType(string type, ListBox list);

        List<string> ZipData(Form dataForm);
    }
}