namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            myBankClass statement1 = new myBankClass("faruk");
            myBankClass statement2 = new myBankClass("sharuk");
            myBankClass statement3 = new myBankClass("arun");

            List<myBankClass> statements = new List<myBankClass>();

            statements.Add(statement1);
            statements.Add(statement2);
            statements.Add(statement3);

            dataGridView1.DataSource = statements;
        }
    }
}
