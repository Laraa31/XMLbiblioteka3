using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XMLZadatak
{
    public partial class UpisKnjiga : Form
    {
        static List<Knjiga> KnjigeList = new List<Knjiga>();
        static string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string datoteka = "Knjige.xml";
        static string path = Path.Combine(path1, datoteka);
        public UpisKnjiga()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Knjiga KnjigaUpis = new Knjiga(txtbNazivKnj.Text, txtbAutorKnj.Text, Convert.ToInt32(txtbKolicinaKnj.Text), Convert.ToInt32(txtbISBNKnj.Text));
            KnjigeList.Add(KnjigaUpis);
            DialogResult dialogResult = MessageBox.Show("Zelite li upisati jos knjiga?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Knjige = XDocument.Load(path);
                    foreach (Knjiga knjiga in KnjigeList)
                    {
                        var Knjiga = new XElement("Knjiga", new XElement("Naziv", knjiga.Naziv), new XElement("Autor", knjiga.Autor),new XElement("Kolicina", knjiga.Kolicina), new XElement("ISBN", knjiga.ISBN));
                        Knjige.Root.Add(Knjiga);
                    }
                    Knjige.Save(path);
                }
                catch (Exception)
                {
                    var Knjige = new XDocument();
                    Knjige.Add(new XElement("Knjige"));
                    foreach (Knjiga knjiga in KnjigeList)
                    {
                        var Knjiga = new XElement("Knjiga",
                        new XElement("Naziv", knjiga.Naziv),
                        new XElement("Autor", knjiga.Autor),
                        new XElement("Kolicina",knjiga.Kolicina),
                        new XElement("ISBN", knjiga.ISBN));
                        Knjige.Root.Add(Knjiga);
                    }
                    Knjige.Save(path);
                }
                KnjigeList.Clear();
                this.Close();
            }
            txtbNazivKnj.Text = "";
            txtbAutorKnj.Text = "";
            txtbKolicinaKnj.Text = "";
            txtbISBNKnj.Text = "";
        }
    }
}
