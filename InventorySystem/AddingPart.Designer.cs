namespace InventorySystem
{
    partial class AddingPartPage
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.addPartInHouseRadButton = new System.Windows.Forms.RadioButton();
            this.AddPartOutsourcedRadButton = new System.Windows.Forms.RadioButton();
            this.addPartLabelid = new System.Windows.Forms.Label();
            this.addPartLabelName = new System.Windows.Forms.Label();
            this.addPartLabelInventory = new System.Windows.Forms.Label();
            this.addPartLabelPriCst = new System.Windows.Forms.Label();
            this.addPartLabelMax = new System.Windows.Forms.Label();
            this.addPartLabelMin = new System.Windows.Forms.Label();
            this.addPartLabelMachid = new System.Windows.Forms.Label();
            this.addPartTxtBoxid = new System.Windows.Forms.TextBox();
            this.addPartTxtBoxName = new System.Windows.Forms.TextBox();
            this.addPartTxtBoxInventory = new System.Windows.Forms.TextBox();
            this.addPartTxtBoxPriCos = new System.Windows.Forms.TextBox();
            this.addPartTxtBoxMachid = new System.Windows.Forms.TextBox();
            this.addPartTxtBoxMax = new System.Windows.Forms.TextBox();
            this.addPartTxtBoxMin = new System.Windows.Forms.TextBox();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(124, 32);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // addPartInHouseRadButton
            // 
            this.addPartInHouseRadButton.AutoSize = true;
            this.addPartInHouseRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInHouseRadButton.Location = new System.Drawing.Point(248, 13);
            this.addPartInHouseRadButton.Name = "addPartInHouseRadButton";
            this.addPartInHouseRadButton.Size = new System.Drawing.Size(117, 29);
            this.addPartInHouseRadButton.TabIndex = 1;
            this.addPartInHouseRadButton.TabStop = true;
            this.addPartInHouseRadButton.Text = "In-House";
            this.addPartInHouseRadButton.UseVisualStyleBackColor = true;
            this.addPartInHouseRadButton.CheckedChanged += new System.EventHandler(this.addPartInHouseRadButton_CheckedChanged);
            // 
            // AddPartOutsourcedRadButton
            // 
            this.AddPartOutsourcedRadButton.AutoSize = true;
            this.AddPartOutsourcedRadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartOutsourcedRadButton.Location = new System.Drawing.Point(404, 13);
            this.AddPartOutsourcedRadButton.Name = "AddPartOutsourcedRadButton";
            this.AddPartOutsourcedRadButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddPartOutsourcedRadButton.Size = new System.Drawing.Size(139, 29);
            this.AddPartOutsourcedRadButton.TabIndex = 2;
            this.AddPartOutsourcedRadButton.TabStop = true;
            this.AddPartOutsourcedRadButton.Text = "Outsourced";
            this.AddPartOutsourcedRadButton.UseVisualStyleBackColor = true;
            this.AddPartOutsourcedRadButton.CheckedChanged += new System.EventHandler(this.AddPartOutsourcedRadButton_CheckedChanged);
            // 
            // addPartLabelid
            // 
            this.addPartLabelid.AutoSize = true;
            this.addPartLabelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabelid.Location = new System.Drawing.Point(172, 111);
            this.addPartLabelid.Name = "addPartLabelid";
            this.addPartLabelid.Size = new System.Drawing.Size(36, 29);
            this.addPartLabelid.TabIndex = 3;
            this.addPartLabelid.Text = "ID";
            // 
            // addPartLabelName
            // 
            this.addPartLabelName.AutoSize = true;
            this.addPartLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabelName.Location = new System.Drawing.Point(130, 171);
            this.addPartLabelName.Name = "addPartLabelName";
            this.addPartLabelName.Size = new System.Drawing.Size(78, 29);
            this.addPartLabelName.TabIndex = 4;
            this.addPartLabelName.Text = "Name";
            // 
            // addPartLabelInventory
            // 
            this.addPartLabelInventory.AutoSize = true;
            this.addPartLabelInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabelInventory.Location = new System.Drawing.Point(99, 240);
            this.addPartLabelInventory.Name = "addPartLabelInventory";
            this.addPartLabelInventory.Size = new System.Drawing.Size(109, 29);
            this.addPartLabelInventory.TabIndex = 5;
            this.addPartLabelInventory.Text = "Inventory";
            // 
            // addPartLabelPriCst
            // 
            this.addPartLabelPriCst.AutoSize = true;
            this.addPartLabelPriCst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabelPriCst.Location = new System.Drawing.Point(71, 319);
            this.addPartLabelPriCst.Name = "addPartLabelPriCst";
            this.addPartLabelPriCst.Size = new System.Drawing.Size(137, 29);
            this.addPartLabelPriCst.TabIndex = 6;
            this.addPartLabelPriCst.Text = "Price / Cost";
            // 
            // addPartLabelMax
            // 
            this.addPartLabelMax.AutoSize = true;
            this.addPartLabelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabelMax.Location = new System.Drawing.Point(151, 398);
            this.addPartLabelMax.Name = "addPartLabelMax";
            this.addPartLabelMax.Size = new System.Drawing.Size(57, 29);
            this.addPartLabelMax.TabIndex = 7;
            this.addPartLabelMax.Text = "Max";
            // 
            // addPartLabelMin
            // 
            this.addPartLabelMin.AutoSize = true;
            this.addPartLabelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabelMin.Location = new System.Drawing.Point(427, 398);
            this.addPartLabelMin.Name = "addPartLabelMin";
            this.addPartLabelMin.Size = new System.Drawing.Size(52, 29);
            this.addPartLabelMin.TabIndex = 8;
            this.addPartLabelMin.Text = "Min";
            // 
            // addPartLabelMachid
            // 
            this.addPartLabelMachid.AutoSize = true;
            this.addPartLabelMachid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabelMachid.Location = new System.Drawing.Point(75, 474);
            this.addPartLabelMachid.Name = "addPartLabelMachid";
            this.addPartLabelMachid.Size = new System.Drawing.Size(133, 29);
            this.addPartLabelMachid.TabIndex = 9;
            this.addPartLabelMachid.Text = "Machine ID";
            // 
            // addPartTxtBoxid
            // 
            this.addPartTxtBoxid.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addPartTxtBoxid.Location = new System.Drawing.Point(284, 115);
            this.addPartTxtBoxid.Name = "addPartTxtBoxid";
            this.addPartTxtBoxid.ReadOnly = true;
            this.addPartTxtBoxid.Size = new System.Drawing.Size(259, 26);
            this.addPartTxtBoxid.TabIndex = 10;
            // 
            // addPartTxtBoxName
            // 
            this.addPartTxtBoxName.Location = new System.Drawing.Point(284, 175);
            this.addPartTxtBoxName.Name = "addPartTxtBoxName";
            this.addPartTxtBoxName.Size = new System.Drawing.Size(259, 26);
            this.addPartTxtBoxName.TabIndex = 11;
            // 
            // addPartTxtBoxInventory
            // 
            this.addPartTxtBoxInventory.Location = new System.Drawing.Point(284, 244);
            this.addPartTxtBoxInventory.Name = "addPartTxtBoxInventory";
            this.addPartTxtBoxInventory.Size = new System.Drawing.Size(259, 26);
            this.addPartTxtBoxInventory.TabIndex = 12;
            // 
            // addPartTxtBoxPriCos
            // 
            this.addPartTxtBoxPriCos.Location = new System.Drawing.Point(284, 322);
            this.addPartTxtBoxPriCos.Name = "addPartTxtBoxPriCos";
            this.addPartTxtBoxPriCos.Size = new System.Drawing.Size(259, 26);
            this.addPartTxtBoxPriCos.TabIndex = 13;
            // 
            // addPartTxtBoxMachid
            // 
            this.addPartTxtBoxMachid.Location = new System.Drawing.Point(284, 478);
            this.addPartTxtBoxMachid.Name = "addPartTxtBoxMachid";
            this.addPartTxtBoxMachid.Size = new System.Drawing.Size(259, 26);
            this.addPartTxtBoxMachid.TabIndex = 14;
            // 
            // addPartTxtBoxMax
            // 
            this.addPartTxtBoxMax.Location = new System.Drawing.Point(284, 401);
            this.addPartTxtBoxMax.Name = "addPartTxtBoxMax";
            this.addPartTxtBoxMax.Size = new System.Drawing.Size(125, 26);
            this.addPartTxtBoxMax.TabIndex = 15;
            // 
            // addPartTxtBoxMin
            // 
            this.addPartTxtBoxMin.Location = new System.Drawing.Point(542, 401);
            this.addPartTxtBoxMin.Name = "addPartTxtBoxMin";
            this.addPartTxtBoxMin.Size = new System.Drawing.Size(125, 26);
            this.addPartTxtBoxMin.TabIndex = 16;
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Location = new System.Drawing.Point(387, 563);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(101, 45);
            this.addPartSaveButton.TabIndex = 17;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addPartSaveButton_Click);
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Location = new System.Drawing.Point(566, 563);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(101, 45);
            this.addPartCancelButton.TabIndex = 18;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancelButton_Click);
            // 
            // AddingPartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 697);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.addPartTxtBoxMin);
            this.Controls.Add(this.addPartTxtBoxMax);
            this.Controls.Add(this.addPartTxtBoxMachid);
            this.Controls.Add(this.addPartTxtBoxPriCos);
            this.Controls.Add(this.addPartTxtBoxInventory);
            this.Controls.Add(this.addPartTxtBoxName);
            this.Controls.Add(this.addPartTxtBoxid);
            this.Controls.Add(this.addPartLabelMachid);
            this.Controls.Add(this.addPartLabelMin);
            this.Controls.Add(this.addPartLabelMax);
            this.Controls.Add(this.addPartLabelPriCst);
            this.Controls.Add(this.addPartLabelInventory);
            this.Controls.Add(this.addPartLabelName);
            this.Controls.Add(this.addPartLabelid);
            this.Controls.Add(this.AddPartOutsourcedRadButton);
            this.Controls.Add(this.addPartInHouseRadButton);
            this.Controls.Add(this.addPartLabel);
            this.Name = "AddingPartPage";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton addPartInHouseRadButton;
        private System.Windows.Forms.RadioButton AddPartOutsourcedRadButton;
        private System.Windows.Forms.Label addPartLabelid;
        private System.Windows.Forms.Label addPartLabelName;
        private System.Windows.Forms.Label addPartLabelInventory;
        private System.Windows.Forms.Label addPartLabelPriCst;
        private System.Windows.Forms.Label addPartLabelMax;
        private System.Windows.Forms.Label addPartLabelMin;
        private System.Windows.Forms.Label addPartLabelMachid;
        private System.Windows.Forms.TextBox addPartTxtBoxid;
        private System.Windows.Forms.TextBox addPartTxtBoxName;
        private System.Windows.Forms.TextBox addPartTxtBoxInventory;
        private System.Windows.Forms.TextBox addPartTxtBoxPriCos;
        private System.Windows.Forms.TextBox addPartTxtBoxMachid;
        private System.Windows.Forms.TextBox addPartTxtBoxMax;
        private System.Windows.Forms.TextBox addPartTxtBoxMin;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Button addPartCancelButton;
    }
}