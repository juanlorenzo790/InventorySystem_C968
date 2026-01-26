namespace InventorySystem
{
    partial class mainPage
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
            this.labelInventoryMgmtSys = new System.Windows.Forms.Label();
            this.partsDataGrid = new System.Windows.Forms.DataGridView();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.partsLabelMain = new System.Windows.Forms.Label();
            this.productsLabelMain = new System.Windows.Forms.Label();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.productsTextBox = new System.Windows.Forms.TextBox();
            this.deletePartsButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.productsDeleteButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.mainPageExitButton = new System.Windows.Forms.Button();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.productsSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInventoryMgmtSys
            // 
            this.labelInventoryMgmtSys.AutoSize = true;
            this.labelInventoryMgmtSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryMgmtSys.Location = new System.Drawing.Point(12, 9);
            this.labelInventoryMgmtSys.Name = "labelInventoryMgmtSys";
            this.labelInventoryMgmtSys.Size = new System.Drawing.Size(568, 46);
            this.labelInventoryMgmtSys.TabIndex = 0;
            this.labelInventoryMgmtSys.Text = "Inventory Management System";
            // 
            // partsDataGrid
            // 
            this.partsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGrid.Location = new System.Drawing.Point(20, 220);
            this.partsDataGrid.Name = "partsDataGrid";
            this.partsDataGrid.RowHeadersWidth = 62;
            this.partsDataGrid.RowTemplate.Height = 28;
            this.partsDataGrid.Size = new System.Drawing.Size(881, 313);
            this.partsDataGrid.TabIndex = 1;
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Location = new System.Drawing.Point(956, 220);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.RowHeadersWidth = 62;
            this.productsDataGrid.RowTemplate.Height = 28;
            this.productsDataGrid.Size = new System.Drawing.Size(866, 313);
            this.productsDataGrid.TabIndex = 2;
            // 
            // partsLabelMain
            // 
            this.partsLabelMain.AutoSize = true;
            this.partsLabelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabelMain.Location = new System.Drawing.Point(14, 162);
            this.partsLabelMain.Name = "partsLabelMain";
            this.partsLabelMain.Size = new System.Drawing.Size(80, 32);
            this.partsLabelMain.TabIndex = 3;
            this.partsLabelMain.Text = "Parts";
            // 
            // productsLabelMain
            // 
            this.productsLabelMain.AutoSize = true;
            this.productsLabelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabelMain.Location = new System.Drawing.Point(950, 162);
            this.productsLabelMain.Name = "productsLabelMain";
            this.productsLabelMain.Size = new System.Drawing.Size(126, 32);
            this.productsLabelMain.TabIndex = 4;
            this.productsLabelMain.Text = "Products";
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(628, 162);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(273, 26);
            this.partsTextBox.TabIndex = 5;
            // 
            // productsTextBox
            // 
            this.productsTextBox.Location = new System.Drawing.Point(1549, 162);
            this.productsTextBox.Name = "productsTextBox";
            this.productsTextBox.Size = new System.Drawing.Size(273, 26);
            this.productsTextBox.TabIndex = 6;
            // 
            // deletePartsButton
            // 
            this.deletePartsButton.Location = new System.Drawing.Point(789, 563);
            this.deletePartsButton.Name = "deletePartsButton";
            this.deletePartsButton.Size = new System.Drawing.Size(112, 38);
            this.deletePartsButton.TabIndex = 7;
            this.deletePartsButton.Text = "Delete";
            this.deletePartsButton.UseVisualStyleBackColor = true;
            this.deletePartsButton.Click += new System.EventHandler(this.deletePartsButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(669, 563);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(112, 38);
            this.partsModifyButton.TabIndex = 8;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            this.partsModifyButton.Click += new System.EventHandler(this.partsModifyButton_Click);
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(549, 563);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(112, 38);
            this.partsAddButton.TabIndex = 9;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.partsAddButton_Click);
            // 
            // productsDeleteButton
            // 
            this.productsDeleteButton.Location = new System.Drawing.Point(1710, 563);
            this.productsDeleteButton.Name = "productsDeleteButton";
            this.productsDeleteButton.Size = new System.Drawing.Size(112, 38);
            this.productsDeleteButton.TabIndex = 10;
            this.productsDeleteButton.Text = "Delete";
            this.productsDeleteButton.UseVisualStyleBackColor = true;
            this.productsDeleteButton.Click += new System.EventHandler(this.productsDeleteButton_Click);
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(1590, 563);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(112, 38);
            this.productsModifyButton.TabIndex = 11;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            this.productsModifyButton.Click += new System.EventHandler(this.productsModifyButton_Click);
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(1470, 563);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(112, 38);
            this.productsAddButton.TabIndex = 12;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            this.productsAddButton.Click += new System.EventHandler(this.productsAddButton_Click);
            // 
            // mainPageExitButton
            // 
            this.mainPageExitButton.Location = new System.Drawing.Point(1710, 637);
            this.mainPageExitButton.Name = "mainPageExitButton";
            this.mainPageExitButton.Size = new System.Drawing.Size(112, 38);
            this.mainPageExitButton.TabIndex = 13;
            this.mainPageExitButton.Text = "Exit";
            this.mainPageExitButton.UseVisualStyleBackColor = true;
            this.mainPageExitButton.Click += new System.EventHandler(this.mainPageExitButton_Click);
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(508, 162);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(104, 31);
            this.partsSearchButton.TabIndex = 14;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.partsSearchButton_Click);
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(1429, 162);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(104, 31);
            this.productsSearchButton.TabIndex = 15;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.productsSearchButton_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1856, 774);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.mainPageExitButton);
            this.Controls.Add(this.productsAddButton);
            this.Controls.Add(this.productsModifyButton);
            this.Controls.Add(this.productsDeleteButton);
            this.Controls.Add(this.partsAddButton);
            this.Controls.Add(this.partsModifyButton);
            this.Controls.Add(this.deletePartsButton);
            this.Controls.Add(this.productsTextBox);
            this.Controls.Add(this.partsTextBox);
            this.Controls.Add(this.productsLabelMain);
            this.Controls.Add(this.partsLabelMain);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.partsDataGrid);
            this.Controls.Add(this.labelInventoryMgmtSys);
            this.Name = "mainPage";
            this.Text = "Inventory System";
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInventoryMgmtSys;
        private System.Windows.Forms.DataGridView partsDataGrid;
        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.Label partsLabelMain;
        private System.Windows.Forms.Label productsLabelMain;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.TextBox productsTextBox;
        private System.Windows.Forms.Button deletePartsButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button productsDeleteButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.Button mainPageExitButton;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.Button productsSearchButton;
    }
}

