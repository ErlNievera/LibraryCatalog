using System.Text;

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

            DisplayTotalBooks();
            DisplayStatus("Ready");
            dgBooks.DataSource = _catalog;

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

            RefreshDataGrid();
            DisplayStatus("Book Added!");
            ClearContents();
        }

        private void dgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var isbn = dgBooks.Rows[e.RowIndex].Cells[0].Value.ToString();

            Book book = _catalog.First(m => m.ISBN == isbn);

            txtISBN.Text = book.ISBN;
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            cmbCategory.Text = book.Category;
            chkAvailable.Checked = book.IsAvailable;

            txtISBN.Enabled = false;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                lblError.Text = "Please Select Book First";
                return;
            }

            Book book = _catalog.First(m => m.ISBN == txtISBN.Text);
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Category = cmbCategory.Text;
            book.IsAvailable = chkAvailable.Checked;

            RefreshDataGrid();
            DisplayStatus("Book Update");
            ClearContents();

            txtISBN.Enabled = true;
        }

        private void ClearContents()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            chkAvailable.Checked = false;
            chkConfirmDelete.Checked = false;
            lblError.Text = string.Empty;
        }

        private void DisplayStatus(string message)
        {
            lblStatus.Text = message;
        }

        private void RefreshDataGrid()
        {
            dgBooks.DataSource = null;
            dgBooks.DataSource = _catalog;
        }

        private void DisplayTotalBooks()
        {
            lblTotalBooks.Text = string.Format("Total Books: {0}", _catalog.Count.ToString());
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                lblError.Text = "Please Select Book First";
                return;
            }

            Book book = _catalog.First(m => m.ISBN == txtISBN.Text);

            if (chkConfirmDelete.Checked)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _catalog.Remove(book);
                    DisplayStatus("Book Deleted!");
                }
            }

            RefreshDataGrid();
            DisplayTotalBooks();
            ClearContents();

            txtISBN.Enabled = true;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            List<Book> filteredBooks = _catalog
                    .Where(m =>
                    m.Category == cmbFilterCategory.Text ||
                    m.Title.Contains(txtSearch.Text)
                    ).ToList();
            dgBooks.DataSource = null;
            dgBooks.DataSource = filteredBooks;
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToCsv(dgBooks);
        }

        private void ExportDataGridViewToCsv(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "LibraryCatalog.csv"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            StringBuilder csv = new StringBuilder();

            // Header row
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                csv.Append(dgv.Columns[i].HeaderText);
                if (i < dgv.Columns.Count - 1)
                    csv.Append(",");
            }
            csv.AppendLine();

            // Data rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    string value = row.Cells[i].Value?.ToString() ?? string.Empty;

                    // Escape commas and quotes
                    value = value.Replace("\"", "\"\"");
                    csv.Append($"\"{value}\"");

                    if (i < dgv.Columns.Count - 1)
                        csv.Append(",");
                }
                csv.AppendLine();
            }

            File.WriteAllText(saveFileDialog.FileName, csv.ToString(), Encoding.UTF8);

            MessageBox.Show("Export completed successfully!", "Export CSV");
        }
    }
}
