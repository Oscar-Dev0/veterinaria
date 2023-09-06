namespace veterinaria
{
    public partial class Veterinaria_login : Form
    {
        Database database;
        public Veterinaria_login(object s)
        {
            InitializeComponent();
            database = (Database)s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //datos del usuario
            var user = text_user.Text;
            var passwort = text_passwort.Text;

            // Sacamos la lista de usuario
            var users = database.users();
            var user_db = users.Find((s) => s.Name == user);
            var user_b = user_db != null ? true : false;

            //hacemos la funcion
            if(user_b) if (user_db?.Password == passwort) {
                var home = new home(user, database);
                this.Hide();
                home.ShowDialog();
                this.Dispose(true);
            }
            else
            {
                MessageBox.Show("Uno de los datos está mal puesto.", "Error", 0, MessageBoxIcon.Error);
                return;
            };





        }
    }
}