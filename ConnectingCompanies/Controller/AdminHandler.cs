using ConnectingCompanies.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingCompanies.Controller
{
    internal class AdminHandler : IAdminHandler
    {
        internal static void CreateStatistics(object sender, PaintEventArgs e, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Rows.Add(5);

            dgv.Rows[0].Cells[0].Value = "felhasználók";
            dgv.Rows[0].Cells[1].Value = MainForm.entities.felhasznalok.Count();
            dgv.Rows[0].Cells[2].Value = MainForm.entities.felhasznalok.Where(x => x.aktiv == true).Count();
            dgv.Rows[0].Cells[3].Value = MainForm.entities.felhasznalok.Where(x => x.aktiv == false).Count();

            dgv.Rows[1].Cells[0].Value = "csoportok";
            dgv.Rows[1].Cells[1].Value = MainForm.entities.csoportok.Count();
            dgv.Rows[1].Cells[2].Value = MainForm.entities.csoportok.Where(x => x.aktiv == true).Count();
            dgv.Rows[1].Cells[3].Value = MainForm.entities.csoportok.Where(x => x.aktiv == false).Count();

            dgv.Rows[2].Cells[0].Value = "ajánlatok";
            dgv.Rows[2].Cells[1].Value = MainForm.entities.ajanlatok.Count();
            dgv.Rows[2].Cells[2].Value = MainForm.entities.ajanlatok.Where(x => x.aktiv == true).Count();
            dgv.Rows[2].Cells[3].Value = MainForm.entities.ajanlatok.Where(x => x.aktiv == false).Count();

            dgv.Rows[3].Cells[0].Value = "események";
            dgv.Rows[3].Cells[1].Value = MainForm.entities.esemenyek.Count();
            dgv.Rows[3].Cells[2].Value = MainForm.entities.esemenyek.Where(x => x.aktiv == true).Count();
            dgv.Rows[3].Cells[3].Value = MainForm.entities.esemenyek.Where(x => x.aktiv == false).Count();

            dgv.Rows[4].Cells[0].Value = "fájlok";
            dgv.Rows[4].Cells[1].Value = MainForm.entities.kepek.Count();
            dgv.Rows[4].Cells[2].Value = "-";
            dgv.Rows[4].Cells[3].Value = "-";
        }

        private string itemType;

        public void DeleteItem(object item)
        {
            throw new NotImplementedException();
            //aktiv = false
        }

        public Form CollectData()
        {
            throw new NotImplementedException();
            //a form az adatbekéréshez
        }

        public void AddItem(List<string> data)
        {
            throw new NotImplementedException();
            //új elem mentése dbbe
        }

        public void ChangeItemType(string type, ListBox list)
        {
            this.itemType = type;
            GetItemsForList(list);
        }

        private void GetItemsForList(ListBox list)
        {
            throw new NotImplementedException();
            //lista feltöltés
        }

        public List<string> ZipData(Form dataForm)
        {
            throw new NotImplementedException();
            //formból adat kiszedés
        }
    }
}