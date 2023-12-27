using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace biblio2_app
{
    public partial class AuthorsForm : Form
    {
        private DataSet _biblioDS;
        private SqlDataAdapter _authorsAdapter;
        public AuthorsForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Biblio"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand authorCommand = connection.CreateCommand();
            authorCommand.CommandType = CommandType.Text;
            authorCommand.CommandText = "SELECT * FROM Authors";

            _biblioDS = new DataSet();
            _authorsAdapter = new SqlDataAdapter(authorCommand);
            _authorsAdapter.Fill(_biblioDS, "Authors");

            bindingSourceAuthors.DataSource = _biblioDS;
            bindingSourceAuthors.DataMember = "Authors";

            txtAuthorID.DataBindings.Add(new Binding("Text", bindingSourceAuthors, "Au_ID"));
            txtAuthorName.DataBindings.Add(new Binding(("Text"), bindingSourceAuthors, "Author"));
            txtYearBorn.DataBindings.Add(new Binding(("Text"), bindingSourceAuthors, "Year Born"));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindingSourceAuthors.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bindingSourceAuthors.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSourceAuthors.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindingSourceAuthors.MoveLast();
        }

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            bindingSourceAuthors.AddNew();
            SetAddNewUI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "Biblio App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSourceAuthors.RemoveCurrent();
                bindingSourceAuthors.EndEdit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder authorsCommandBuilder = new SqlCommandBuilder(_authorsAdapter);
            _authorsAdapter.Update(_biblioDS, "Authors");
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetNavigationUI();
            bindingSourceAuthors.EndEdit();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetNavigationUI();
            bindingSourceAuthors.CancelEdit();
        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {

        }


        private void SetNavigationUI()
        {
            txtAuthorID.ReadOnly = true;
            txtAuthorName.ReadOnly = true;
            txtYearBorn.ReadOnly = true;
            btnNew.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnClose.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void SetAddNewUI()
        {
            txtAuthorID.ReadOnly = false;
            txtAuthorName.ReadOnly = false;
            txtYearBorn.ReadOnly = false;
            btnNew.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnClose.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void SetEditUI()
        {
            txtAuthorID.ReadOnly = true;
            txtAuthorName.ReadOnly = false;
            txtYearBorn.ReadOnly = false;
            btnNew.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnClose.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }
    }
}