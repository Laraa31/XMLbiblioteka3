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
    public partial class Pretraga : Form
    {

        public Pretraga()
        {
            InitializeComponent();
        }

        private void btnPretraziKnj_Click(object sender, EventArgs e)
        {

            rtbIspis.Clear();
            List<Knjiga> KnjigeList = new List<Knjiga>();
             string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
             string datoteka = "Knjige.xml";
             string path = Path.Combine(path1, datoteka);


            if (txtNazivKnj.Text != "")
            {
                XDocument doc = XDocument.Load(path);
                XElement root=doc.Root;

                var rez= root.Elements("Knjiga").FirstOrDefault(m=>m.Element("Naziv").Value==txtNazivKnj.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else if(txtAutor.Text != "")
            {
                XDocument doc = XDocument.Load(path);
                XElement root = doc.Root;

                var rez = root.Elements("Knjiga").FirstOrDefault(m => m.Element("Autor").Value == txtAutor.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else if(txtKolicina.Text != "")
            {
                XDocument doc = XDocument.Load(path);
                XElement root = doc.Root;

                var rez = root.Elements("Knjiga").FirstOrDefault(m => m.Element("Kolicina").Value == txtKolicina.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else if(txtISBN.Text != "")
            {
                XDocument doc = XDocument.Load(path);
                XElement root = doc.Root;

                var rez = root.Elements("Knjiga").FirstOrDefault(m => m.Element("ISBN").Value == txtISBN.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ništa niste upisali! Upišite parametar po kojem želite pretražiti knjigu.", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }

            txtNazivKnj.Clear();
            txtKolicina.Clear();
            txtAutor.Clear();
            txtISBN.Clear();

        }

        private void btnPretraziKor_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
