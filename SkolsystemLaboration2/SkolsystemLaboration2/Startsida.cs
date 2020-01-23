using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkolsystemLaboration2
{
    public partial class Startsida : Form
    {

        public List<Kurs> Kurser { get; set; }

        public Startsida()
        {
            InitializeComponent();
            GenereraObjekt();
            UppdateraDataGrid();
        }

        public void UppdateraDataGrid()
        {
            KursDataGrid.DataSource = null;
            KursDataGrid.DataSource = Kurser;

        }

        public void UppdateraStudentLärare() 
        {   


            StudentDataGrid.DataSource = null;

            Kurs valdKurs = (Kurs)KursDataGrid.CurrentRow.DataBoundItem;
            List<Student> valdKursStudentLista = valdKurs.StudenterPåKurs;

            StudentDataGrid.DataSource = valdKursStudentLista;



            LärareDataGrid.DataSource = null;

            List<Lärare> valdKursLärareLista = valdKurs.LärarePåKurs;

            LärareDataGrid.DataSource = valdKursLärareLista;
        }


        #region genereraobjekt
        public void GenereraObjekt()
        {
            List<Student> StudentLista = new List<Student>();


            StudentLista.Add(new Student("001","Lisa", "Svensson"));
            StudentLista.Add(new Student("002","Korvi", "Sveni"));
            StudentLista.Add(new Student("003","Nyr", "Lostuio"));
            StudentLista.Add(new Student("004","Vera", "Vol"));
            StudentLista.Add(new Student("005","Olof", "Malmberg"));
            StudentLista.Add(new Student("006","Nombi", "Komf"));

            List<Student> StudentLista2 = new List<Student>();
            StudentLista2.Add(new Student("022", "Juh", "Iso"));
            StudentLista2.Add(new Student("024", "Veralol", "Volol"));
            StudentLista2.Add(new Student("025", "Solof", "Halmberg"));

            List<Lärare> LärareLista = new List<Lärare>();

            LärareLista.Add(new Lärare("101","Alfons", "Svensson"));
            LärareLista.Add(new Lärare("102","Petter", "Sveni"));
            LärareLista.Add(new Lärare("103","Anna", "Lostuio"));
            LärareLista.Add(new Lärare("104","Christer", "Vol"));
            LärareLista.Add(new Lärare("105","Håkan", "Malmberg"));
            LärareLista.Add(new Lärare("106","Anders", "Komf"));

            List<Lärare> LärareLista2 = new List<Lärare>();
            LärareLista2.Add(new Lärare("134", "Rister", "Lov"));
            LärareLista2.Add(new Lärare("145", "Åkan", "Handersson"));
            LärareLista2.Add(new Lärare("156", "Sanders", "Fomk"));


            Kurs kurs = new Kurs("01", "Systemutveckling 1", StudentLista, LärareLista);
            Kurs kurs2 = new Kurs("02", "Systemutveckling 2", StudentLista2, LärareLista2);


            Kurser = new List<Kurs>();
            Kurser.Add(kurs);
            Kurser.Add(kurs2);



        }
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Startsida_Load(object sender, EventArgs e)
        {

        }

        private void KursDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UppdateraStudentLärare();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KursIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KursnamnTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LäggTillKurs_Click(object sender, EventArgs e)
        {
            List<Student> StudentPåNyKurs = new List<Student>();
            StudentPåNyKurs.Add(new Student("skriv ID", "skriv förnamn", "skriv efternamn"));

            List<Lärare> LärarePåNyKurs = new List<Lärare>();
            LärarePåNyKurs.Add(new Lärare("skriv ID", "skriv förnamn", "skriv efternamn"));

            Kurs kurs = new Kurs(KursIDTextbox.Text, KursnamnTextbox.Text, StudentPåNyKurs, LärarePåNyKurs);

            Kurser.Add(kurs);
            UppdateraDataGrid();
            

        }
    }
}
