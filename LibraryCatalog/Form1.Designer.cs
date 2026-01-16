namespace LibraryCatalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbCategory = new ComboBox();
            chkAvailable = new CheckBox();
            label5 = new Label();
            btnAddBook = new Button();
            btnUpdateBook = new Button();
            btnClearInputs = new Button();
            dgBooks = new DataGridView();
            gbActionManagement = new GroupBox();
            chkConfirmDelete = new CheckBox();
            btnClearAll = new Button();
            btnRemoveSelected = new Button();
            gbFilteringSearching = new GroupBox();
            btnResetFilter = new Button();
            btnApplyFilter = new Button();
            label7 = new Label();
            label6 = new Label();
            txtSearch = new TextBox();
            cmbFilterCategory = new ComboBox();
            toolStrip1 = new ToolStrip();
            lblTotalBooks = new ToolStripLabel();
            lblStatus = new ToolStripLabel();
            lblError = new ToolStripLabel();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgBooks).BeginInit();
            gbActionManagement.SuspendLayout();
            gbFilteringSearching.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Arial Rounded MT Bold", 9F);
            txtISBN.Location = new Point(86, 57);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(257, 21);
            txtISBN.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Arial Rounded MT Bold", 9F);
            txtTitle.Location = new Point(86, 92);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(257, 21);
            txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Arial Rounded MT Bold", 9F);
            txtAuthor.Location = new Point(86, 129);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(257, 21);
            txtAuthor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9.75F);
            label1.Location = new Point(22, 60);
            label1.Name = "label1";
            label1.Size = new Size(38, 16);
            label1.TabIndex = 3;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9.75F);
            label2.Location = new Point(22, 92);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9.75F);
            label3.Location = new Point(22, 129);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 5;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 14);
            label4.Name = "label4";
            label4.Size = new Size(239, 23);
            label4.TabIndex = 6;
            label4.Text = "Library Catalog System";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Arial Rounded MT Bold", 9F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science", "History", "Misc" });
            cmbCategory.Location = new Point(86, 166);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(257, 22);
            cmbCategory.TabIndex = 7;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAvailable.Location = new Point(84, 198);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(100, 20);
            chkAvailable.TabIndex = 8;
            chkAvailable.Text = "Is Available";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9.75F);
            label5.Location = new Point(17, 165);
            label5.Name = "label5";
            label5.Size = new Size(63, 16);
            label5.TabIndex = 9;
            label5.Text = "Category";
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Georgia", 9F);
            btnAddBook.Location = new Point(74, 235);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(90, 27);
            btnAddBook.TabIndex = 10;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Georgia", 9F);
            btnUpdateBook.Location = new Point(170, 235);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(91, 27);
            btnUpdateBook.TabIndex = 11;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnClearInputs
            // 
            btnClearInputs.Font = new Font("Georgia", 9F);
            btnClearInputs.Location = new Point(267, 235);
            btnClearInputs.Name = "btnClearInputs";
            btnClearInputs.Size = new Size(88, 27);
            btnClearInputs.TabIndex = 12;
            btnClearInputs.Text = "Clear";
            btnClearInputs.UseVisualStyleBackColor = true;
            // 
            // dgBooks
            // 
            dgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBooks.Location = new Point(516, 114);
            dgBooks.Name = "dgBooks";
            dgBooks.Size = new Size(643, 502);
            dgBooks.TabIndex = 13;
            dgBooks.CellClick += dgBooks_CellClick;
            // 
            // gbActionManagement
            // 
            gbActionManagement.Controls.Add(chkConfirmDelete);
            gbActionManagement.Controls.Add(btnClearAll);
            gbActionManagement.Controls.Add(btnRemoveSelected);
            gbActionManagement.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbActionManagement.Location = new Point(29, 308);
            gbActionManagement.Name = "gbActionManagement";
            gbActionManagement.Size = new Size(283, 137);
            gbActionManagement.TabIndex = 14;
            gbActionManagement.TabStop = false;
            gbActionManagement.Text = "Action Management";
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkConfirmDelete.Location = new Point(80, 98);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(135, 22);
            chkConfirmDelete.TabIndex = 2;
            chkConfirmDelete.Text = "Confirm Delete?";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearAll.Location = new Point(141, 35);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(126, 48);
            btnClearAll.TabIndex = 1;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveSelected.Location = new Point(19, 35);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(116, 48);
            btnRemoveSelected.TabIndex = 0;
            btnRemoveSelected.Text = "Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = true;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // gbFilteringSearching
            // 
            gbFilteringSearching.Controls.Add(btnResetFilter);
            gbFilteringSearching.Controls.Add(btnApplyFilter);
            gbFilteringSearching.Controls.Add(label7);
            gbFilteringSearching.Controls.Add(label6);
            gbFilteringSearching.Controls.Add(txtSearch);
            gbFilteringSearching.Controls.Add(cmbFilterCategory);
            gbFilteringSearching.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilteringSearching.Location = new Point(516, 8);
            gbFilteringSearching.Name = "gbFilteringSearching";
            gbFilteringSearching.Size = new Size(643, 100);
            gbFilteringSearching.TabIndex = 15;
            gbFilteringSearching.TabStop = false;
            gbFilteringSearching.Text = "Filtering and Searching";
            // 
            // btnResetFilter
            // 
            btnResetFilter.Font = new Font("Georgia", 9.75F);
            btnResetFilter.Location = new Point(532, 48);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(105, 23);
            btnResetFilter.TabIndex = 5;
            btnResetFilter.Text = "Reset Filter";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Font = new Font("Georgia", 9.75F);
            btnApplyFilter.Location = new Point(425, 48);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(90, 23);
            btnApplyFilter.TabIndex = 4;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold);
            label7.Location = new Point(173, 24);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 3;
            label7.Text = "Search";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold);
            label6.Location = new Point(9, 24);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 2;
            label6.Text = "Category";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial", 9F);
            txtSearch.Location = new Point(173, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 21);
            txtSearch.TabIndex = 1;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.Font = new Font("Arial", 9F);
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science", "History", "Misc" });
            cmbFilterCategory.Location = new Point(6, 49);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(149, 23);
            cmbFilterCategory.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { lblTotalBooks, lblStatus, lblError });
            toolStrip1.Location = new Point(0, 603);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1171, 25);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(0, 22);
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 22);
            // 
            // lblError
            // 
            lblError.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 22);
            // 
            // btnExport
            // 
            btnExport.Location = new Point(119, 462);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 34);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1171, 628);
            Controls.Add(btnExport);
            Controls.Add(toolStrip1);
            Controls.Add(gbFilteringSearching);
            Controls.Add(gbActionManagement);
            Controls.Add(dgBooks);
            Controls.Add(btnClearInputs);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnAddBook);
            Controls.Add(label5);
            Controls.Add(chkAvailable);
            Controls.Add(cmbCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtISBN);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Catalog";
            ((System.ComponentModel.ISupportInitialize)dgBooks).EndInit();
            gbActionManagement.ResumeLayout(false);
            gbActionManagement.PerformLayout();
            gbFilteringSearching.ResumeLayout(false);
            gbFilteringSearching.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbCategory;
        private CheckBox chkAvailable;
        private Label label5;
        private Button btnAddBook;
        private Button btnUpdateBook;
        private Button btnClearInputs;
        private DataGridView dgBooks;
        private GroupBox gbActionManagement;
        private CheckBox chkConfirmDelete;
        private Button btnClearAll;
        private Button btnRemoveSelected;
        private GroupBox gbFilteringSearching;
        private Label label6;
        private TextBox txtSearch;
        private ComboBox cmbFilterCategory;
        private Label label7;
        private Button btnResetFilter;
        private Button btnApplyFilter;
        private ToolStrip toolStrip1;
        private ToolStripLabel lblTotalBooks;
        private ToolStripLabel lblStatus;
        private ToolStripLabel lblError;
        private Button btnExport;
    }
}
