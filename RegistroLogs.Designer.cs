namespace pryBlaiotta2705
{
    partial class RegistroLogs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnRegistrarLogs = new System.Windows.Forms.Button();
            this.btnCrearUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(91, 57);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(91, 111);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnRegistrarLogs
            // 
            this.btnRegistrarLogs.Location = new System.Drawing.Point(46, 168);
            this.btnRegistrarLogs.Name = "btnRegistrarLogs";
            this.btnRegistrarLogs.Size = new System.Drawing.Size(128, 23);
            this.btnRegistrarLogs.TabIndex = 4;
            this.btnRegistrarLogs.Text = "Registrar Log";
            this.btnRegistrarLogs.UseVisualStyleBackColor = true;
            this.btnRegistrarLogs.Click += new System.EventHandler(this.btnRegistrarLogs_Click);
            // 
            // btnCrearUsuarios
            // 
            this.btnCrearUsuarios.Location = new System.Drawing.Point(46, 212);
            this.btnCrearUsuarios.Name = "btnCrearUsuarios";
            this.btnCrearUsuarios.Size = new System.Drawing.Size(128, 23);
            this.btnCrearUsuarios.TabIndex = 5;
            this.btnCrearUsuarios.Text = "Crear Usuarios";
            this.btnCrearUsuarios.UseVisualStyleBackColor = true;
            this.btnCrearUsuarios.Click += new System.EventHandler(this.btnCrearUsuarios_Click);
            // 
            // RegistroLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 237);
            this.Controls.Add(this.btnCrearUsuarios);
            this.Controls.Add(this.btnRegistrarLogs);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroLogs";
            this.Text = "RegistroLogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnRegistrarLogs;
        private System.Windows.Forms.Button btnCrearUsuarios;
    }
}