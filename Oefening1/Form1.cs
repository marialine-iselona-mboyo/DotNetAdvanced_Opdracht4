namespace Oefening1
{
    public partial class Form1 : Form
    {

        private List<System.Timers.Timer> listTimers = new List<System.Timers.Timer>();
        private Rij<TeDoen> row = new Rij<TeDoen>();
        private List<TeDoen> listObjects = new List<TeDoen>();
        private List<DateTime> listDates = new List<DateTime>();

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (timeCB.Checked == true)
            {

            } else
            {
                
            }
        }

        private void nextTaskBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void afgewerktBtn_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Off")
            {
                btn1.BackColor = Color.Red;
                
            } else if(btn1.Text == "On")
            {
                btn1.BackColor = Color.Green;
            }            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Off")
            {
                btn1.BackColor = Color.Red;

            }
            else if (btn1.Text == "On")
            {
                btn1.BackColor = Color.Green;
            }
        }
    }

    internal class Rij<T>
    {
        internal void inDeRij(TeDoen teDoen)
        {
            throw new NotImplementedException();
        }
    }
}