namespace CapaPresentacion
{
    partial class frmChangePassword
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
            this.txtClaveAnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveNew1 = new System.Windows.Forms.TextBox();
            this.txtClaveNew2 = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClaveAnt
            // 
            this.txtClaveAnt.Location = new System.Drawing.Point(178, 66);
            this.txtClaveAnt.Name = "txtClaveAnt";
            this.txtClaveAnt.PasswordChar = '*';
            this.txtClaveAnt.Size = new System.Drawing.Size(227, 20);
            this.txtClaveAnt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave Anterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave Anterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave Anterior";
            // 
            // txtClaveNew1
            // 
            this.txtClaveNew1.Location = new System.Drawing.Point(178, 111);
            this.txtClaveNew1.Name = "txtClaveNew1";
            this.txtClaveNew1.PasswordChar = '*';
            this.txtClaveNew1.Size = new System.Drawing.Size(227, 20);
            this.txtClaveNew1.TabIndex = 4;
            // 
            // txtClaveNew2
            // 
            this.txtClaveNew2.Location = new System.Drawing.Point(178, 153);
            this.txtClaveNew2.Name = "txtClaveNew2";
            this.txtClaveNew2.PasswordChar = '*';
            this.txtClaveNew2.Size = new System.Drawing.Size(227, 20);
            this.txtClaveNew2.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(58, 21);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(347, 19);
            this.txtUsuario.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(244, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtClaveNew2);
            this.Controls.Add(this.txtClaveNew1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClaveAnt);
            this.Name = "frmChangePassword";
            this.Text = "Cambiar el PassWord";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClaveAnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveNew1;
        private System.Windows.Forms.TextBox txtClaveNew2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}