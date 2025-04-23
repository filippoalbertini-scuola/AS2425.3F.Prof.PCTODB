using System.Data;
using System.Data.SQLite;

namespace AS2324._3G.Prof.PCTODB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElencoPiloti_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/

            // imposta la connessione

            // sqlite Data Source=c:\mydb.db;Version=3;
            strConnessione = "Data Source=" + @"C:\Appl\Scuola\AS_2023_2024\3G\AS2324.3G.Prof.PCTODB\AS2324.3G.Prof.PCTODB\DB\MotoGP.db" + ";Version=3;";

            // contenitore per i dati estratti
            DataTable dtDati = new DataTable();

            // query per l'estrazione dei dati dal database
            query = "SELECT * FROM Piloti";

            //connessione e query
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

        }

        private void btnElencoSquadre_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/

            // imposta la connessione

            // sqlite Data Source=c:\mydb.db;Version=3;
            strConnessione = "Data Source=" + @"C:\Appl\Scuola\AS_2023_2024\3G\AS2324.3G.Prof.PCTODB\AS2324.3G.Prof.PCTODB\DB\MotoGP.db" + ";Version=3;";

            // contenitore per i dati estratti
            DataTable dtDati = new DataTable();

            // query per l'estrazione dei dati dal database
            query = "SELECT * FROM Squadre";

            //connessione e query
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
