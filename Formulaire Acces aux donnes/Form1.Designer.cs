namespace Formulaire_Acces_aux_donnes
{
    partial class Form1
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
            this.lblNomLivre = new System.Windows.Forms.Label();
            this.lblprix = new System.Windows.Forms.Label();
            this.comboBoxselect = new System.Windows.Forms.ComboBox();
            this.textBoxprix = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dataGridViewlivre = new System.Windows.Forms.DataGridView();
            this.btnafficher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlivre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomLivre
            // 
            this.lblNomLivre.AutoSize = true;
            this.lblNomLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLivre.Location = new System.Drawing.Point(12, 33);
            this.lblNomLivre.Name = "lblNomLivre";
            this.lblNomLivre.Size = new System.Drawing.Size(117, 24);
            this.lblNomLivre.TabIndex = 0;
            this.lblNomLivre.Text = "Nom de livre";
            this.lblNomLivre.Click += new System.EventHandler(this.lblNomLivre_Click);
            // 
            // lblprix
            // 
            this.lblprix.AutoSize = true;
            this.lblprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprix.Location = new System.Drawing.Point(12, 62);
            this.lblprix.Name = "lblprix";
            this.lblprix.Size = new System.Drawing.Size(42, 24);
            this.lblprix.TabIndex = 1;
            this.lblprix.Text = "Prix";
            // 
            // comboBoxselect
            // 
            this.comboBoxselect.FormattingEnabled = true;
            this.comboBoxselect.Location = new System.Drawing.Point(169, 30);
            this.comboBoxselect.Name = "comboBoxselect";
            this.comboBoxselect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxselect.TabIndex = 2;
            this.comboBoxselect.SelectedIndexChanged += new System.EventHandler(this.comboBoxselect_SelectedIndexChanged);
            // 
            // textBoxprix
            // 
            this.textBoxprix.Location = new System.Drawing.Point(169, 62);
            this.textBoxprix.Name = "textBoxprix";
            this.textBoxprix.Size = new System.Drawing.Size(100, 20);
            this.textBoxprix.TabIndex = 3;
            this.textBoxprix.TextChanged += new System.EventHandler(this.textBoxprix_TextChanged);
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(52, 127);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(90, 39);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(169, 127);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(90, 39);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(291, 127);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 39);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.Location = new System.Drawing.Point(405, 127);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(90, 39);
            this.btnconfirm.TabIndex = 7;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(515, 127);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 39);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dataGridViewlivre
            // 
            this.dataGridViewlivre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewlivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewlivre.Location = new System.Drawing.Point(143, 188);
            this.dataGridViewlivre.Name = "dataGridViewlivre";
            this.dataGridViewlivre.Size = new System.Drawing.Size(317, 150);
            this.dataGridViewlivre.TabIndex = 9;
            this.dataGridViewlivre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewlivre_CellContentClick);
            // 
            // btnafficher
            // 
            this.btnafficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafficher.Location = new System.Drawing.Point(259, 354);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(90, 35);
            this.btnafficher.TabIndex = 10;
            this.btnafficher.Text = "afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnafficher);
            this.Controls.Add(this.dataGridViewlivre);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.textBoxprix);
            this.Controls.Add(this.comboBoxselect);
            this.Controls.Add(this.lblprix);
            this.Controls.Add(this.lblNomLivre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlivre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomLivre;
        private System.Windows.Forms.Label lblprix;
        private System.Windows.Forms.ComboBox comboBoxselect;
        private System.Windows.Forms.TextBox textBoxprix;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView dataGridViewlivre;
        private System.Windows.Forms.Button btnafficher;
    }
}

