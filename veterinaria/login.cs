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
            string dato_user = "doctor_1";
            string dato_passwort = "pets1304";

            //datos del usuario
            var user = text_user.Text;
            var passwort = text_passwort.Text;


            //hacemos la funcion
            if("root" == user && "root" == passwort)
            {
                var home = new home();
                this.Hide();

                home.ShowDialog();
                this.Dispose(true);
            } else
            if (user != dato_user || passwort != dato_passwort)
            {
                MessageBox.Show("Uno de los datos est� mal puesto.", "Error", 0, MessageBoxIcon.Error);
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