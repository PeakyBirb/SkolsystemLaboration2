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
            UppdateraKurser();
        }




        #region genereraobjekt
        public void GenereraObjekt()
        {
            List<Student> StudentLista = new List<Student>();


            StudentLista.Add(new Student("001", "Lisa", "Svensson"));
            StudentLista.Add(new Student("002", "Korvi", "Sveni"));
            StudentLista.Add(new Student("003", "Nyr", "Lostuio"));
            StudentLista.Add(new Student("004", "Vera", "Vol"));
            StudentLista.Add(new Student("005", "Olof", "Malmberg"));
            StudentLista.Add(new Student("006", "Nombi", "Komf"));

            List<Student> StudentLista2 = new List<Student>();
            StudentLista2.Add(new Student("022", "Juh", "Iso"));
            StudentLista2.Add(new Student("024", "Veralol", "Volol"));
            StudentLista2.Add(new Student("025", "Solof", "Halmberg"));

            List<Lärare> LärareLista = new List<Lärare>();

            LärareLista.Add(new Lärare("101", "Alfons", "Svensson"));
            LärareLista.Add(new Lärare("102", "Petter", "Sveni"));
            LärareLista.Add(new Lärare("103", "Anna", "Lostuio"));
            LärareLista.Add(new Lärare("104", "Christer", "Vol"));
            LärareLista.Add(new Lärare("105", "Håkan", "Malmberg"));
            LärareLista.Add(new Lärare("106", "Anders", "Komf"));

            List<Lärare> LärareLista2 = new List<Lärare>();
            LärareLista2.Add(new Lärare("134", "Rister", "Lov"));
            LärareLista2.Add(new Lärare("145", "Åkan", "Handersson"));
            LärareLista2.Add(new Lärare("156", "Sanders", "Fomk"));


            Kurs kurs = new Kurs("01", "Systemutveckling 1", StudentLista, LärareLista);
            Kurs kurs2 = new Kurs("02", "Systemutveckling 2", StudentLista2, LärareLista2);


            Kurser = new List<Kurs>();
            Kurser.Add(kurs);
            Kurser.Add(kurs2);

            List<Laborationsuppgift> Laborationslista = new List<Laborationsuppgift>();
            Laborationslista.Add(new Laborationsuppgift("l1","Programmeringens mystiska vidunder", kurs));

            kurs.LaborationsuppgifterPåKurs = Laborationslista;

        }
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void FyllLaborationComboBox()
        {

            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            List<Laborationsuppgift> laborationsuppgifterPåKurs = new List<Laborationsuppgift>();


            
                if (valdKurs.LaborationsuppgifterPåKurs != null)
                {

                foreach (var lab in valdKurs.LaborationsuppgifterPåKurs)
                {
                    laborationsuppgifterPåKurs.Add(lab);
                }
                }
            

            LaborationComboBox.DataSource = null;
            LaborationComboBox.DataSource = laborationsuppgifterPåKurs;
            LaborationComboBox.ValueMember = "LabID";
            LaborationComboBox.DisplayMember = "LabNamn";
        }

        public void FyllStudentListBox()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            Laborationsuppgift valdLaboration = (Laborationsuppgift)LaborationComboBox.SelectedItem;
            List<Student> studenterPåKurs = new List<Student>();
            
            //studenter från en viss labb
            foreach(var student in valdKurs.StudenterPåKurs)
            {
                studenterPåKurs.Add(student);
            }

            StudentListBox.DataSource = null;
            StudentListBox.DataSource = studenterPåKurs;



        }

        public void UppdateraKurser()
        {
            KursListBox.DataSource = null;
            KursListBox.DataSource = Kurser;
            KursListBox.ValueMember = "KursID";
            KursListBox.DisplayMember = "KursNamn";

        }

        public void FyllStudentComboBox()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            List<Student> valdKursStudentLista = new List<Student>();

            foreach (var item in Kurser)
            {
                foreach (var item2 in item.StudenterPåKurs)
                {
                    valdKursStudentLista.Add(item2);
                }
            }


            StudentComboBox.DataSource = valdKursStudentLista;
            StudentComboBox.ValueMember = "Id";
            StudentComboBox.DisplayMember = "Förnamn";
        }

        public void LäggTillStudentPåKursFrånComboBox()
        {
            Student valdStudent = (Student)StudentComboBox.SelectedItem;
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            List<Student> valdaStudenter = valdKurs.StudenterPåKurs;

            if (valdaStudenter != null)
            {
                valdaStudenter.Add(valdStudent);
                valdKurs.StudenterPåKurs = valdaStudenter;
            }
            else
            {
                List<Student> nyStudentLista = new List<Student>();
                nyStudentLista.Add(valdStudent);
                valdKurs.StudenterPåKurs = nyStudentLista;
            }



            StudentDataGrid.DataSource = null;
            StudentDataGrid.DataSource = valdKurs.StudenterPåKurs;

        }

        public void FyllLärareComboBox()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            List<Lärare> valdKursLärarLista = new List<Lärare>();

            foreach (var item in Kurser)
            {
                foreach (var item2 in item.LärarePåKurs)
                {
                    valdKursLärarLista.Add(item2);
                }
            }


            LärareComboBox.DataSource = valdKursLärarLista;
            LärareComboBox.ValueMember = "Id";
            LärareComboBox.DisplayMember = "Förnamn";
        }

        public void LäggTillLärarePåKursFrånComboBox()
        {
            Lärare valdLärare = (Lärare)LärareComboBox.SelectedItem;
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            List<Lärare> valdaLärare = valdKurs.LärarePåKurs;

            if (valdaLärare != null)
            {
                valdaLärare.Add(valdLärare);
                valdKurs.LärarePåKurs = valdaLärare;
            }
            else
            {
                List<Lärare> nyLärarLista = new List<Lärare>();
                nyLärarLista.Add(valdLärare);
                valdKurs.LärarePåKurs = nyLärarLista;
            }

            LärareDataGrid.DataSource = null;
            LärareDataGrid.DataSource = valdKurs.LärarePåKurs;

        }

        public void LäggTillLaborationsuppgift()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            List<Laborationsuppgift> Laborationslista = new List<Laborationsuppgift>();
            //if not null?
            if (valdKurs.LaborationsuppgifterPåKurs != null)
            {
                Laborationslista = valdKurs.LaborationsuppgifterPåKurs;
            }
            
            
            Laborationslista.Add(new Laborationsuppgift(LabIDTextbox.Text, LabNamnTextbox.Text, valdKurs));

            valdKurs.LaborationsuppgifterPåKurs = Laborationslista;

            LabDataGrid.DataSource = null;
            LabDataGrid.DataSource = valdKurs.LaborationsuppgifterPåKurs;
            //

        }

        public void FyllLabDataGrid()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            LabDataGrid.DataSource = valdKurs.LaborationsuppgifterPåKurs;
            
            

        }




        private void Startsida_Load(object sender, EventArgs e)
        {
            FyllStudentComboBox();
            FyllLärareComboBox();
            FyllLabDataGrid();
            FyllLaborationComboBox();
        }

        private void KursDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



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
            //StudentPåNyKurs.Add(new Student("skriv ID", "skriv förnamn", "skriv efternamn"));

            List<Lärare> LärarePåNyKurs = new List<Lärare>();
            //LärarePåNyKurs.Add(new Lärare("skriv ID", "skriv förnamn", "skriv efternamn"));

            Kurs kurs = new Kurs(KursIDTextbox.Text, KursnamnTextbox.Text, null, null);

            Kurser.Add(kurs);

            KursListBox.DataSource = null;
            KursListBox.DataSource = Kurser;
            KursListBox.DisplayMember = "KursNamn";
            KursListBox.ValueMember = "KursID";
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void KursListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KursListBox.DataSource != null)
            {
                Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
                List<Student> valdKursStudentLista = valdKurs.StudenterPåKurs;

                StudentDataGrid.DataSource = valdKursStudentLista;


                List<Lärare> valdKursLärareLista = valdKurs.LärarePåKurs;

                LärareDataGrid.DataSource = valdKursLärareLista;
                FyllLabDataGrid();
                FyllLaborationComboBox();
            }

            

        }

        private void LärareDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LäggTillStudentKnapp_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LärareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LäggTillStudent_Click(object sender, EventArgs e)
        {
            LäggTillStudentPåKursFrånComboBox();
        }

        private void LäggTillLärare_Click(object sender, EventArgs e)
        {
            LäggTillLärarePåKursFrånComboBox();
        }

        private void LäggTillLabb_Click(object sender, EventArgs e)
        {
            LäggTillLaborationsuppgift();
            FyllLaborationComboBox();
        }

        private void LabDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LabIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LaborationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
