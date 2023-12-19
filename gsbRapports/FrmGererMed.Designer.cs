namespace gsbRapports
{
    partial class FrmGererMed
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFam = new System.Windows.Forms.ComboBox();
            this.bdgFam = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offrirsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgMed = new System.Windows.Forms.BindingSource(this.components);
            this.btnAfficher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionner une famille de médicaments :";
            // 
            // cmbFam
            // 
            this.cmbFam.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbFam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdgFam, "id", true));
            this.cmbFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgFam, "id", true));
            this.cmbFam.DataSource = this.bdgFam;
            this.cmbFam.DisplayMember = "id";
            this.cmbFam.FormattingEnabled = true;
            this.cmbFam.Location = new System.Drawing.Point(303, 87);
            this.cmbFam.Name = "cmbFam";
            this.cmbFam.Size = new System.Drawing.Size(121, 21);
            this.cmbFam.TabIndex = 0;
            // 
            // bdgFam
            // 
            this.bdgFam.DataSource = typeof(gsbRapports.famille);
            // 
            // dgvMed
            // 
            this.dgvMed.AutoGenerateColumns = false;
            this.dgvMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCommercialDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn,
            this.familleDataGridViewTextBoxColumn,
            this.offrirsDataGridViewTextBoxColumn});
            this.dgvMed.DataSource = this.bdgMed;
            this.dgvMed.Location = new System.Drawing.Point(44, 203);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(645, 150);
            this.dgvMed.TabIndex = 2;
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "composition";
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "effets";
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            // 
            // familleDataGridViewTextBoxColumn
            // 
            this.familleDataGridViewTextBoxColumn.DataPropertyName = "famille";
            this.familleDataGridViewTextBoxColumn.HeaderText = "famille";
            this.familleDataGridViewTextBoxColumn.Name = "familleDataGridViewTextBoxColumn";
            // 
            // offrirsDataGridViewTextBoxColumn
            // 
            this.offrirsDataGridViewTextBoxColumn.DataPropertyName = "offrirs";
            this.offrirsDataGridViewTextBoxColumn.HeaderText = "offrirs";
            this.offrirsDataGridViewTextBoxColumn.Name = "offrirsDataGridViewTextBoxColumn";
            // 
            // bdgMed
            // 
            this.bdgMed.DataSource = typeof(gsbRapports.medicament);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(323, 133);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(77, 30);
            this.btnAfficher.TabIndex = 3;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGererMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dgvMed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFam);
            this.Name = "FrmGererMed";
            this.Text = "FrmGererMed";
            this.Load += new System.EventHandler(this.FrmGererMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgFam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFam;
        private System.Windows.Forms.BindingSource bdgFam;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdgMed;
        private System.Windows.Forms.Button btnAfficher;
    }
}