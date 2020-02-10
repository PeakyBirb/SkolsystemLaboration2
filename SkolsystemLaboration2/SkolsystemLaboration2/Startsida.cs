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
            Betyg nullbetyg = new Betyg(null, null, null, null);
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

            LärareLista.Add(new Lärare("101", "Alfons", "Svensson", 28000));
            LärareLista.Add(new Lärare("102", "Petter", "Sveni", 30100));
            LärareLista.Add(new Lärare("103", "Anna", "Lostuio", 25300));
            LärareLista.Add(new Lärare("104", "Christer", "Vol", 32500));
            LärareLista.Add(new Lärare("105", "Håkan", "Malmberg", 28555));
            LärareLista.Add(new Lärare("106", "Anders", "Komf", 38200));

            List<Lärare> LärareLista2 = new List<Lärare>();
            LärareLista2.Add(new Lärare("134", "Rister", "Lov", 26999));
            LärareLista2.Add(new Lärare("145", "Åkan", "Handersson", 26800));
            LärareLista2.Add(new Lärare("156", "Sanders", "Fomk", 30200));

            List<Betyg> betyglista = new List<Betyg>();
            betyglista.Add(nullbetyg);

            Kurs kurs = new Kurs("01", "Systemutveckling 1", StudentLista, LärareLista);
            Kurs kurs2 = new Kurs("02", "Systemutveckling 2", StudentLista2, LärareLista2);

            kurs.BetygLista = betyglista;
            kurs2.BetygLista = betyglista;

            Kurser = new List<Kurs>();
            Kurser.Add(kurs);
            Kurser.Add(kurs2);

            foreach (var Kurs in Kurser)
            {
                foreach (var student in Kurs.StudenterPåKurs)
                {
                    if (student.StudentensKursLista == null)
                    {
                        List<Kurs> tillfälligStudentKursLista = new List<Kurs>();
                        student.StudentensKursLista = tillfälligStudentKursLista;
                        
                    }
                    student.StudentensKursLista.Add(Kurs);
                }
            }

            List<Betyg> NullBetyg = new List<Betyg>();

            List<Laborationsuppgift> Laborationslista = new List<Laborationsuppgift>();
            Laborationslista.Add(new Laborationsuppgift("l1", "Programmeringens mystiska vidunder", kurs, NullBetyg));

            kurs.LaborationsuppgifterPåKurs = Laborationslista;

        }
        #endregion
        

        public void LäggTillNyKurs(string kursID, string kursnamn, List<Student> studenterPåKurs, List<Lärare> lärarePåKurs)
        {
            Kurs kurs = new Kurs(kursID, kursnamn, studenterPåKurs, lärarePåKurs);

            Kurser.Add(kurs);
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

            if (valdKurs.StudenterPåKurs != null)
            {
                foreach (var student in valdKurs.StudenterPåKurs)
                {
                    studenterPåKurs.Add(student);
                }
            }

            StudentListBox.DataSource = null;
            StudentListBox.DataSource = studenterPåKurs;
            StudentListBox.ValueMember = "Id";
            StudentListBox.DisplayMember = "Förnamn";


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


        }

        public void UppdateraStudentDataGrid()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
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

        }

        public void UppdateraLärareDataGrid()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            LärareDataGrid.DataSource = null;
            LärareDataGrid.DataSource = valdKurs.LärarePåKurs;
        }

        public void LäggTillLaborationsuppgift()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            List<Laborationsuppgift> Laborationslista = new List<Laborationsuppgift>();

            if (valdKurs.LaborationsuppgifterPåKurs != null)
            {
                Laborationslista = valdKurs.LaborationsuppgifterPåKurs;
            }

            List<Betyg> NullBetyg = new List<Betyg>();

            Laborationslista.Add(new Laborationsuppgift(LabIDTextbox.Text, LabNamnTextbox.Text, valdKurs, NullBetyg));

            valdKurs.LaborationsuppgifterPåKurs = Laborationslista;

            LabDataGrid.DataSource = null;
            LabDataGrid.DataSource = valdKurs.LaborationsuppgifterPåKurs;


        }

        public void FyllLabDataGrid()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            LabDataGrid.DataSource = valdKurs.LaborationsuppgifterPåKurs;

        }

        public void VisaBetyg()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            Student valdStudent = (Student)StudentListBox.SelectedItem;
            Laborationsuppgift valdLab = (Laborationsuppgift)LaborationComboBox.SelectedItem;

            if (valdLab != null)
            {

                if (valdLab.BetygLista != null)
                {

                    var result = (from b in valdLab.BetygLista
                                  where valdStudent == b.Student
                                  select b.TilldelatBetyg).SingleOrDefault();


                    if (result != null)
                    {

                        betygLabel.Text = result.ToString();
                    }
                    else
                    {
                        betygLabel.Text = "Inget betyg";
                    }

                }
                else
                {
                    betygLabel.Text = "Inget betyg";
                }
            }
        }

        public void SättBetyg()
        {
            Kurs valdKurs = (Kurs)KursListBox.SelectedItem;
            Student valdStudent = (Student)StudentListBox.SelectedItem;
            Laborationsuppgift valdLab = (Laborationsuppgift)LaborationComboBox.SelectedItem;
            string nyttBetyg = NyttBetygComboBox.Text;

            Betyg betyg = new Betyg(valdKurs, valdLab, valdStudent, nyttBetyg);

            valdKurs.BetygLista = UppdateraBetygLista(valdKurs.BetygLista, betyg);
            valdStudent.BetygLista = UppdateraBetygLista(valdStudent.BetygLista, betyg);
            valdLab.BetygLista = UppdateraBetygLista(valdLab.BetygLista, betyg);


        }



        public List<Betyg> UppdateraBetygLista(List<Betyg> gammalBetygLista, Betyg nyttBetyg)
        {
            List<Betyg> nyBetygLista = new List<Betyg>();
            if (gammalBetygLista != null)
            {
                nyBetygLista = gammalBetygLista;
                nyBetygLista.Add(nyttBetyg);
                return nyBetygLista;
            }
            else
            {
                nyBetygLista.Add(nyttBetyg);
                return nyBetygLista;
            }

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

            LäggTillNyKurs(KursIDTextbox.Text, KursnamnTextbox.Text, null, null);

            UppdateraKurser();
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
            FyllLaborationComboBox();
            UppdateraStudentDataGrid();
        }

        private void LäggTillLärare_Click(object sender, EventArgs e)
        {
            LäggTillLärarePåKursFrånComboBox();
            UppdateraLärareDataGrid();
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
            FyllStudentListBox();
        }

        private void StudentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisaBetyg();
        }

        private void OkBetygButton_Click(object sender, EventArgs e)
        {
            SättBetyg();
            VisaBetyg();
            UppdateraStudenterListBox();
        }
        public void UppdateraStudenterListBox()
        {
            StudentListBox.DataSource = null;
            StudentListBox.DataSource = (((Kurs)KursListBox.SelectedItem).StudenterPåKurs);
            StudentListBox.DisplayMember = "Förnamn";
        }

        private void betygLabel_Click(object sender, EventArgs e)
        {

        }

        private void NyttBetygTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentBetygDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
