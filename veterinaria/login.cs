namespace veterinaria
{
    public partial class Veterinaria_login : Form
    {
        public Veterinaria_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///quemar los datos
            string dato_user = "root";
            string dato_passwort = "root";

            //datos del usuario
            var user = text_user.Text;
            var passwort = text_passwort.Text;


            //hacemos la funcion
            if (user != dato_user || passwort != dato_passwort)
            {
                MessageBox.Show("Uno de los datos está mal puesto.", "Error", 0, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var home = new home();
                this.Hide();

                home.ShowDialog();
                this.Dispose(true);
            }





        }
    }
}