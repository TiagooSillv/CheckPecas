namespace CheckPecas
{
    partial class frmControlePecaProduzidas
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
            this.txtEstimado = new System.Windows.Forms.TextBox();
            this.txtProduzidas = new System.Windows.Forms.TextBox();
            this.txrReprovadas = new System.Windows.Forms.TextBox();
            this.txtAprovadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.cbPecas = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dbCheckPecasDataSet = new CheckPecas.dbCheckPecasDataSet();
            this.tblPecasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPecasTableAdapter = new CheckPecas.dbCheckPecasDataSetTableAdapters.tblPecasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCheckPecasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPecasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // txtEstimado
            // 
            this.txtEstimado.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimado.Location = new System.Drawing.Point(182, 261);
            this.txtEstimado.Name = "txtEstimado";
            this.txtEstimado.Size = new System.Drawing.Size(100, 23);
            this.txtEstimado.TabIndex = 2;
            // 
            // txtProduzidas
            // 
            this.txtProduzidas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduzidas.Location = new System.Drawing.Point(182, 213);
            this.txtProduzidas.Name = "txtProduzidas";
            this.txtProduzidas.Size = new System.Drawing.Size(100, 23);
            this.txtProduzidas.TabIndex = 3;
            // 
            // txrReprovadas
            // 
            this.txrReprovadas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrReprovadas.Location = new System.Drawing.Point(182, 172);
            this.txrReprovadas.Name = "txrReprovadas";
            this.txrReprovadas.Size = new System.Drawing.Size(100, 23);
            this.txrReprovadas.TabIndex = 4;
            // 
            // txtAprovadas
            // 
            this.txtAprovadas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAprovadas.Location = new System.Drawing.Point(182, 127);
            this.txtAprovadas.Name = "txtAprovadas";
            this.txtAprovadas.Size = new System.Drawing.Size(100, 23);
            this.txtAprovadas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Peças";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Peças reprovadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Peças aprovadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Peças produzidas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prejuizo estimado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(323, 359);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(182, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // mtxtData
            // 
            this.mtxtData.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtData.Location = new System.Drawing.Point(182, 56);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(127, 23);
            this.mtxtData.TabIndex = 1;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            this.mtxtData.Leave += new System.EventHandler(this.mtxtData_Leave);
            // 
            // cbPecas
            // 
            this.cbPecas.DataSource = this.tblPecasBindingSource;
            this.cbPecas.DisplayMember = "nomePeca";
            this.cbPecas.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPecas.FormattingEnabled = true;
            this.cbPecas.Location = new System.Drawing.Point(182, 89);
            this.cbPecas.Name = "cbPecas";
            this.cbPecas.Size = new System.Drawing.Size(298, 26);
            this.cbPecas.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CheckPecas.Properties.Resources.logo_check_pecas_JPG;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dbCheckPecasDataSet
            // 
            this.dbCheckPecasDataSet.DataSetName = "dbCheckPecasDataSet";
            this.dbCheckPecasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPecasBindingSource
            // 
            this.tblPecasBindingSource.DataMember = "tblPecas";
            this.tblPecasBindingSource.DataSource = this.dbCheckPecasDataSet;
            // 
            // tblPecasTableAdapter
            // 
            this.tblPecasTableAdapter.ClearBeforeFill = true;
            // 
            // frmControlePecaProduzidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbPecas);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAprovadas);
            this.Controls.Add(this.txrReprovadas);
            this.Controls.Add(this.txtProduzidas);
            this.Controls.Add(this.txtEstimado);
            this.Controls.Add(this.label1);
            this.Name = "frmControlePecaProduzidas";
            this.Text = "Controle de Peças Produzidas";
            this.Load += new System.EventHandler(this.frmControlePecaProduzidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCheckPecasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPecasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstimado;
        private System.Windows.Forms.TextBox txtProduzidas;
        private System.Windows.Forms.TextBox txrReprovadas;
        private System.Windows.Forms.TextBox txtAprovadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.ComboBox cbPecas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbCheckPecasDataSet dbCheckPecasDataSet;
        private System.Windows.Forms.BindingSource tblPecasBindingSource;
        private dbCheckPecasDataSetTableAdapters.tblPecasTableAdapter tblPecasTableAdapter;
    }
}