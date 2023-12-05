namespace GameCard_SE172121
{
    partial class GameCardManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTittle = new Label();
            lblId = new Label();
            lblName = new Label();
            lblDescription = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            lblCreatedDate = new Label();
            dtpCreatedDate = new DateTimePicker();
            lblPrice = new Label();
            lblQuantity = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            lblProvider = new Label();
            lblGamePlatform = new Label();
            txtGamePlatForm = new TextBox();
            cboProvider = new ComboBox();
            grbGameCardInfo = new GroupBox();
            btnAdd = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            grbCRUD = new GroupBox();
            lblSearch = new Label();
            txtKeyword = new TextBox();
            btnSearch = new Button();
            lblGameCardList = new Label();
            dgvGameCardList = new DataGridView();
            grbGameCardInfo.SuspendLayout();
            grbCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGameCardList).BeginInit();
            SuspendLayout();
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTittle.Location = new Point(12, 9);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(464, 65);
            lblTittle.TabIndex = 0;
            lblTittle.Text = "Game Card Manager";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(21, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(21, 84);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtId
            // 
            txtId.Location = new Point(136, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(317, 23);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(317, 23);
            txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(136, 81);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(317, 23);
            txtDescription.TabIndex = 6;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(21, 119);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(75, 15);
            lblCreatedDate.TabIndex = 7;
            lblCreatedDate.Text = "Created Date";
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.CustomFormat = "dd/MM/yyyy";
            dtpCreatedDate.Format = DateTimePickerFormat.Custom;
            dtpCreatedDate.Location = new Point(136, 113);
            dtpCreatedDate.Margin = new Padding(3, 2, 3, 2);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(317, 23);
            dtpCreatedDate.TabIndex = 8;
            dtpCreatedDate.Value = new DateTime(2023, 11, 13, 18, 30, 52, 0);
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(21, 188);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(21, 153);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(136, 185);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(317, 23);
            txtPrice.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(136, 150);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(317, 23);
            txtQuantity.TabIndex = 12;
            // 
            // lblProvider
            // 
            lblProvider.AutoSize = true;
            lblProvider.Location = new Point(21, 251);
            lblProvider.Name = "lblProvider";
            lblProvider.Size = new Size(33, 15);
            lblProvider.TabIndex = 13;
            lblProvider.Text = "Price";
            // 
            // lblGamePlatform
            // 
            lblGamePlatform.AutoSize = true;
            lblGamePlatform.Location = new Point(21, 220);
            lblGamePlatform.Name = "lblGamePlatform";
            lblGamePlatform.Size = new Size(87, 15);
            lblGamePlatform.TabIndex = 14;
            lblGamePlatform.Text = "Game Platform";
            // 
            // txtGamePlatForm
            // 
            txtGamePlatForm.Location = new Point(136, 217);
            txtGamePlatForm.Name = "txtGamePlatForm";
            txtGamePlatForm.Size = new Size(317, 23);
            txtGamePlatForm.TabIndex = 15;
            // 
            // cboProvider
            // 
            cboProvider.FormattingEnabled = true;
            cboProvider.Location = new Point(136, 248);
            cboProvider.Margin = new Padding(3, 2, 3, 2);
            cboProvider.Name = "cboProvider";
            cboProvider.Size = new Size(317, 23);
            cboProvider.TabIndex = 16;
            // 
            // grbGameCardInfo
            // 
            grbGameCardInfo.Controls.Add(cboProvider);
            grbGameCardInfo.Controls.Add(txtGamePlatForm);
            grbGameCardInfo.Controls.Add(lblGamePlatform);
            grbGameCardInfo.Controls.Add(lblProvider);
            grbGameCardInfo.Controls.Add(txtQuantity);
            grbGameCardInfo.Controls.Add(txtPrice);
            grbGameCardInfo.Controls.Add(lblQuantity);
            grbGameCardInfo.Controls.Add(lblPrice);
            grbGameCardInfo.Controls.Add(dtpCreatedDate);
            grbGameCardInfo.Controls.Add(lblCreatedDate);
            grbGameCardInfo.Controls.Add(txtDescription);
            grbGameCardInfo.Controls.Add(txtName);
            grbGameCardInfo.Controls.Add(txtId);
            grbGameCardInfo.Controls.Add(lblDescription);
            grbGameCardInfo.Controls.Add(lblName);
            grbGameCardInfo.Controls.Add(lblId);
            grbGameCardInfo.Location = new Point(43, 90);
            grbGameCardInfo.Name = "grbGameCardInfo";
            grbGameCardInfo.Size = new Size(475, 283);
            grbGameCardInfo.TabIndex = 17;
            grbGameCardInfo.TabStop = false;
            grbGameCardInfo.Text = "  Game card info  ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 39);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(405, 413);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 39);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(142, 19);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 39);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // grbCRUD
            // 
            grbCRUD.Controls.Add(btnUpdate);
            grbCRUD.Controls.Add(btnDelete);
            grbCRUD.Controls.Add(btnAdd);
            grbCRUD.Location = new Point(43, 394);
            grbCRUD.Name = "grbCRUD";
            grbCRUD.Size = new Size(356, 73);
            grbCRUD.TabIndex = 23;
            grbCRUD.TabStop = false;
            grbCRUD.Text = "CRUD";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(591, 110);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Search";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(639, 107);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(317, 23);
            txtKeyword.TabIndex = 24;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(988, 107);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblGameCardList
            // 
            lblGameCardList.AutoSize = true;
            lblGameCardList.Location = new Point(591, 161);
            lblGameCardList.Name = "lblGameCardList";
            lblGameCardList.Size = new Size(87, 15);
            lblGameCardList.TabIndex = 25;
            lblGameCardList.Text = "Game Card List";
            // 
            // dgvGameCardList
            // 
            dgvGameCardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGameCardList.Location = new Point(591, 180);
            dgvGameCardList.Name = "dgvGameCardList";
            dgvGameCardList.RowTemplate.Height = 25;
            dgvGameCardList.Size = new Size(497, 287);
            dgvGameCardList.TabIndex = 26;
            // 
            // GameCardManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 478);
            Controls.Add(dgvGameCardList);
            Controls.Add(lblGameCardList);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(txtKeyword);
            Controls.Add(lblSearch);
            Controls.Add(grbCRUD);
            Controls.Add(grbGameCardInfo);
            Controls.Add(lblTittle);
            Name = "GameCardManagementForm";
            Text = "GameCardManagementForm";
            Load += GameCardManagementForm_Load;
            grbGameCardInfo.ResumeLayout(false);
            grbGameCardInfo.PerformLayout();
            grbCRUD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGameCardList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTittle;
        private Label lblId;
        private Label lblName;
        private Label lblDescription;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label lblCreatedDate;
        private DateTimePicker dtpCreatedDate;
        private Label lblPrice;
        private Label lblQuantity;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label lblProvider;
        private Label lblGamePlatform;
        private TextBox txtGamePlatForm;
        private ComboBox cboProvider;
        private GroupBox grbGameCardInfo;
        private Button btnAdd;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox grbCRUD;
        private Label lblSearch;
        private TextBox txtKeyword;
        private Button btnSearch;
        private Label lblGameCardList;
        private DataGridView dgvGameCardList;
    }
}