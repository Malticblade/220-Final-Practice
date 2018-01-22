namespace _220_Final_Practice
{
    partial class frmMain
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
            this.grpbxSortBy = new System.Windows.Forms.GroupBox();
            this.btnHeight = new System.Windows.Forms.Button();
            this.btnWeight = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.grpbxPokeDex = new System.Windows.Forms.GroupBox();
            this.dgvPokedex = new System.Windows.Forms.DataGridView();
            this.dgvParty = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbxNewPokemon = new System.Windows.Forms.GroupBox();
            this.txtbxType = new System.Windows.Forms.TextBox();
            this.txtbxHeight = new System.Windows.Forms.TextBox();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.txtbxHP = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpbxCurrentSort = new System.Windows.Forms.GroupBox();
            this.rbHeight = new System.Windows.Forms.RadioButton();
            this.rbWeight = new System.Windows.Forms.RadioButton();
            this.rbType = new System.Windows.Forms.RadioButton();
            this.rbHP = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearPty = new System.Windows.Forms.Button();
            this.grpbxParty = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddPokemon = new System.Windows.Forms.Button();
            this.grpbxSortBy.SuspendLayout();
            this.grpbxPokeDex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParty)).BeginInit();
            this.gpbxNewPokemon.SuspendLayout();
            this.grpbxCurrentSort.SuspendLayout();
            this.grpbxParty.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxSortBy
            // 
            this.grpbxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxSortBy.Controls.Add(this.btnHeight);
            this.grpbxSortBy.Controls.Add(this.btnWeight);
            this.grpbxSortBy.Controls.Add(this.btnType);
            this.grpbxSortBy.Controls.Add(this.btnHP);
            this.grpbxSortBy.Controls.Add(this.btnName);
            this.grpbxSortBy.Location = new System.Drawing.Point(385, 65);
            this.grpbxSortBy.MinimumSize = new System.Drawing.Size(87, 188);
            this.grpbxSortBy.Name = "grpbxSortBy";
            this.grpbxSortBy.Size = new System.Drawing.Size(87, 191);
            this.grpbxSortBy.TabIndex = 1;
            this.grpbxSortBy.TabStop = false;
            this.grpbxSortBy.Text = "Sort By";
            // 
            // btnHeight
            // 
            this.btnHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeight.Location = new System.Drawing.Point(6, 145);
            this.btnHeight.Name = "btnHeight";
            this.btnHeight.Size = new System.Drawing.Size(75, 25);
            this.btnHeight.TabIndex = 12;
            this.btnHeight.Text = "Height";
            this.btnHeight.UseVisualStyleBackColor = true;
            this.btnHeight.Click += new System.EventHandler(this.btnHeight_Click);
            // 
            // btnWeight
            // 
            this.btnWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeight.Location = new System.Drawing.Point(6, 114);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(75, 25);
            this.btnWeight.TabIndex = 11;
            this.btnWeight.Text = "Weight";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // btnType
            // 
            this.btnType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnType.Location = new System.Drawing.Point(6, 83);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 25);
            this.btnType.TabIndex = 10;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnHP
            // 
            this.btnHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHP.Location = new System.Drawing.Point(6, 52);
            this.btnHP.Name = "btnHP";
            this.btnHP.Size = new System.Drawing.Size(75, 25);
            this.btnHP.TabIndex = 9;
            this.btnHP.Text = "HP";
            this.btnHP.UseVisualStyleBackColor = true;
            this.btnHP.Click += new System.EventHandler(this.btnHP_Click);
            // 
            // btnName
            // 
            this.btnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnName.Location = new System.Drawing.Point(6, 20);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 25);
            this.btnName.TabIndex = 8;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // grpbxPokeDex
            // 
            this.grpbxPokeDex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxPokeDex.Controls.Add(this.dgvPokedex);
            this.grpbxPokeDex.Location = new System.Drawing.Point(12, 65);
            this.grpbxPokeDex.Name = "grpbxPokeDex";
            this.grpbxPokeDex.Size = new System.Drawing.Size(367, 191);
            this.grpbxPokeDex.TabIndex = 2;
            this.grpbxPokeDex.TabStop = false;
            this.grpbxPokeDex.Text = "PokeDex";
            // 
            // dgvPokedex
            // 
            this.dgvPokedex.AllowUserToAddRows = false;
            this.dgvPokedex.AllowUserToDeleteRows = false;
            this.dgvPokedex.AllowUserToResizeColumns = false;
            this.dgvPokedex.AllowUserToResizeRows = false;
            this.dgvPokedex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokedex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPokedex.Location = new System.Drawing.Point(3, 16);
            this.dgvPokedex.MultiSelect = false;
            this.dgvPokedex.Name = "dgvPokedex";
            this.dgvPokedex.ReadOnly = true;
            this.dgvPokedex.RowHeadersVisible = false;
            this.dgvPokedex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokedex.Size = new System.Drawing.Size(361, 172);
            this.dgvPokedex.TabIndex = 8;
            // 
            // dgvParty
            // 
            this.dgvParty.AllowUserToAddRows = false;
            this.dgvParty.AllowUserToDeleteRows = false;
            this.dgvParty.AllowUserToResizeColumns = false;
            this.dgvParty.AllowUserToResizeRows = false;
            this.dgvParty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParty.Location = new System.Drawing.Point(3, 16);
            this.dgvParty.MultiSelect = false;
            this.dgvParty.Name = "dgvParty";
            this.dgvParty.ReadOnly = true;
            this.dgvParty.RowHeadersVisible = false;
            this.dgvParty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParty.Size = new System.Drawing.Size(361, 172);
            this.dgvParty.TabIndex = 2;
            this.dgvParty.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(397, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "0 Pokemon in Party";
            // 
            // gpbxNewPokemon
            // 
            this.gpbxNewPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxNewPokemon.Controls.Add(this.txtbxType);
            this.gpbxNewPokemon.Controls.Add(this.txtbxHeight);
            this.gpbxNewPokemon.Controls.Add(this.txtbxWeight);
            this.gpbxNewPokemon.Controls.Add(this.txtbxHP);
            this.gpbxNewPokemon.Controls.Add(this.txtbxName);
            this.gpbxNewPokemon.Controls.Add(this.lblHeight);
            this.gpbxNewPokemon.Controls.Add(this.lblWeight);
            this.gpbxNewPokemon.Controls.Add(this.lblType);
            this.gpbxNewPokemon.Controls.Add(this.lblHP);
            this.gpbxNewPokemon.Controls.Add(this.lblName);
            this.gpbxNewPokemon.Location = new System.Drawing.Point(9, 456);
            this.gpbxNewPokemon.Name = "gpbxNewPokemon";
            this.gpbxNewPokemon.Size = new System.Drawing.Size(370, 151);
            this.gpbxNewPokemon.TabIndex = 15;
            this.gpbxNewPokemon.TabStop = false;
            this.gpbxNewPokemon.Text = "Details";
            // 
            // txtbxType
            // 
            this.txtbxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxType.Location = new System.Drawing.Point(48, 44);
            this.txtbxType.Name = "txtbxType";
            this.txtbxType.ReadOnly = true;
            this.txtbxType.Size = new System.Drawing.Size(316, 20);
            this.txtbxType.TabIndex = 2;
            // 
            // txtbxHeight
            // 
            this.txtbxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxHeight.Location = new System.Drawing.Point(48, 122);
            this.txtbxHeight.Name = "txtbxHeight";
            this.txtbxHeight.ReadOnly = true;
            this.txtbxHeight.Size = new System.Drawing.Size(316, 20);
            this.txtbxHeight.TabIndex = 5;
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxWeight.Location = new System.Drawing.Point(48, 96);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.ReadOnly = true;
            this.txtbxWeight.Size = new System.Drawing.Size(316, 20);
            this.txtbxWeight.TabIndex = 4;
            // 
            // txtbxHP
            // 
            this.txtbxHP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxHP.Location = new System.Drawing.Point(48, 70);
            this.txtbxHP.Name = "txtbxHP";
            this.txtbxHP.ReadOnly = true;
            this.txtbxHP.Size = new System.Drawing.Size(316, 20);
            this.txtbxHP.TabIndex = 3;
            // 
            // txtbxName
            // 
            this.txtbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxName.Location = new System.Drawing.Point(48, 18);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.ReadOnly = true;
            this.txtbxName.Size = new System.Drawing.Size(316, 20);
            this.txtbxName.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(7, 127);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 14);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(7, 100);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(40, 14);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 14);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(7, 74);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 14);
            this.lblHP.TabIndex = 1;
            this.lblHP.Text = "HP";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grpbxCurrentSort
            // 
            this.grpbxCurrentSort.Controls.Add(this.rbHeight);
            this.grpbxCurrentSort.Controls.Add(this.rbWeight);
            this.grpbxCurrentSort.Controls.Add(this.rbType);
            this.grpbxCurrentSort.Controls.Add(this.rbHP);
            this.grpbxCurrentSort.Controls.Add(this.rbName);
            this.grpbxCurrentSort.Enabled = false;
            this.grpbxCurrentSort.Location = new System.Drawing.Point(12, 12);
            this.grpbxCurrentSort.Name = "grpbxCurrentSort";
            this.grpbxCurrentSort.Size = new System.Drawing.Size(305, 42);
            this.grpbxCurrentSort.TabIndex = 17;
            this.grpbxCurrentSort.TabStop = false;
            this.grpbxCurrentSort.Text = "Current Sort";
            // 
            // rbHeight
            // 
            this.rbHeight.AutoSize = true;
            this.rbHeight.Enabled = false;
            this.rbHeight.Location = new System.Drawing.Point(229, 19);
            this.rbHeight.Name = "rbHeight";
            this.rbHeight.Size = new System.Drawing.Size(56, 18);
            this.rbHeight.TabIndex = 4;
            this.rbHeight.TabStop = true;
            this.rbHeight.Text = "Height";
            this.rbHeight.UseVisualStyleBackColor = true;
            // 
            // rbWeight
            // 
            this.rbWeight.AutoSize = true;
            this.rbWeight.Enabled = false;
            this.rbWeight.Location = new System.Drawing.Point(165, 19);
            this.rbWeight.Name = "rbWeight";
            this.rbWeight.Size = new System.Drawing.Size(58, 18);
            this.rbWeight.TabIndex = 3;
            this.rbWeight.TabStop = true;
            this.rbWeight.Text = "Weight";
            this.rbWeight.UseVisualStyleBackColor = true;
            // 
            // rbType
            // 
            this.rbType.AutoSize = true;
            this.rbType.Enabled = false;
            this.rbType.Location = new System.Drawing.Point(110, 19);
            this.rbType.Name = "rbType";
            this.rbType.Size = new System.Drawing.Size(49, 18);
            this.rbType.TabIndex = 2;
            this.rbType.TabStop = true;
            this.rbType.Text = "Type";
            this.rbType.UseVisualStyleBackColor = true;
            // 
            // rbHP
            // 
            this.rbHP.AutoSize = true;
            this.rbHP.Enabled = false;
            this.rbHP.Location = new System.Drawing.Point(64, 19);
            this.rbHP.Name = "rbHP";
            this.rbHP.Size = new System.Drawing.Size(40, 18);
            this.rbHP.TabIndex = 1;
            this.rbHP.TabStop = true;
            this.rbHP.Text = "HP";
            this.rbHP.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbName.Enabled = false;
            this.rbName.Location = new System.Drawing.Point(6, 19);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(52, 18);
            this.rbName.TabIndex = 0;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(6, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearPty
            // 
            this.btnClearPty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPty.Location = new System.Drawing.Point(6, 79);
            this.btnClearPty.Name = "btnClearPty";
            this.btnClearPty.Size = new System.Drawing.Size(75, 25);
            this.btnClearPty.TabIndex = 16;
            this.btnClearPty.Text = "Clear";
            this.btnClearPty.UseVisualStyleBackColor = true;
            this.btnClearPty.Click += new System.EventHandler(this.btnClearPty_Click);
            // 
            // grpbxParty
            // 
            this.grpbxParty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxParty.Controls.Add(this.btnRemove);
            this.grpbxParty.Controls.Add(this.btnAdd);
            this.grpbxParty.Controls.Add(this.btnClearPty);
            this.grpbxParty.Location = new System.Drawing.Point(385, 259);
            this.grpbxParty.Name = "grpbxParty";
            this.grpbxParty.Size = new System.Drawing.Size(87, 111);
            this.grpbxParty.TabIndex = 17;
            this.grpbxParty.TabStop = false;
            this.grpbxParty.Text = "Party";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(6, 48);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 25);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvParty);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 191);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Party";
            // 
            // btnAddPokemon
            // 
            this.btnAddPokemon.Location = new System.Drawing.Point(369, 26);
            this.btnAddPokemon.Name = "btnAddPokemon";
            this.btnAddPokemon.Size = new System.Drawing.Size(91, 23);
            this.btnAddPokemon.TabIndex = 19;
            this.btnAddPokemon.Text = "Add Pokemon";
            this.btnAddPokemon.UseVisualStyleBackColor = true;
            this.btnAddPokemon.Click += new System.EventHandler(this.btnAddPokemon_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(484, 636);
            this.Controls.Add(this.btnAddPokemon);
            this.Controls.Add(this.grpbxCurrentSort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpbxParty);
            this.Controls.Add(this.gpbxNewPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbxPokeDex);
            this.Controls.Add(this.grpbxSortBy);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(480, 675);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeDex";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpbxSortBy.ResumeLayout(false);
            this.grpbxPokeDex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParty)).EndInit();
            this.gpbxNewPokemon.ResumeLayout(false);
            this.gpbxNewPokemon.PerformLayout();
            this.grpbxCurrentSort.ResumeLayout(false);
            this.grpbxCurrentSort.PerformLayout();
            this.grpbxParty.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbxSortBy;
        private System.Windows.Forms.GroupBox grpbxPokeDex;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHeight;
        private System.Windows.Forms.Button btnWeight;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.GroupBox gpbxNewPokemon;
        private System.Windows.Forms.TextBox txtbxType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxHeight;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.TextBox txtbxHP;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvParty;
        private System.Windows.Forms.GroupBox grpbxCurrentSort;
        private System.Windows.Forms.RadioButton rbHeight;
        private System.Windows.Forms.RadioButton rbWeight;
        private System.Windows.Forms.RadioButton rbType;
        private System.Windows.Forms.RadioButton rbHP;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.DataGridView dgvPokedex;
        private System.Windows.Forms.Button btnClearPty;
        private System.Windows.Forms.GroupBox grpbxParty;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddPokemon;
    }
}


