namespace LibraryCatalog
{
    public partial class Form1 : Form
    {
        private readonly List<Book> _catalog = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            _catalog.Add(new Book
            {
                ISBN = "1",
                Title = "Harry Potter",
                Author = "JK Rowling",
                Category = "Fiction",
                IsAvailable = true
            });

            dgBooks.DataSource = _catalog;
            lblTotalBooks.Text = string.Format("Total Books: {0}", _catalog.Count.ToString());
            lblStatus.Text = "Ready";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                lblError.Text = "ISBN is empty!";
                return;
            }

            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                lblError.Text = "Title is empty!";
                return;
            }

            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                lblError.Text = "Author is empty!";
                return;
            }

            if (string.IsNullOrEmpty(cmbCategory.Text))
            {
                lblError.Text = "Category is empty!";
                return;
            }

            if (_catalog.Any(m => m.ISBN.Equals(txtISBN.Text)))
            {
                lblError.Text = "ISBN Already exist!";
                return;
            }

            _catalog.Add(new Book
            {
                ISBN = txtISBN.Text,
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Category = cmbCategory.Text,
                IsAvailable = chkAvailable.Checked
            });

            dgBooks.DataSource = null;
            dgBooks.DataSource = _catalog;
            lblTotalBooks.Text = string.Format("Total Books: {0}", _catalog.Count.ToString());
            lblStatus.Text = "Book Added!";

            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            chkAvailable.Checked = false;
        }
    }
}
