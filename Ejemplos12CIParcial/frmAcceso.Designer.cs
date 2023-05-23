namespace Ejemplos12CIParcial
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.LblUsuarioPlataforma = new System.Windows.Forms.Label();
            this.LblNombreUser = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LnkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.LnkRestablecer = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUsuarioPlataforma
            // 
            this.LblUsuarioPlataforma.AutoSize = true;
            this.LblUsuarioPlataforma.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioPlataforma.Location = new System.Drawing.Point(173, 49);
            this.LblUsuarioPlataforma.Name = "LblUsuarioPlataforma";
            this.LblUsuarioPlataforma.Size = new System.Drawing.Size(242, 21);
            this.LblUsuarioPlataforma.TabIndex = 0;
            this.LblUsuarioPlataforma.Text = "Usuario De La Plataforma";
            // 
            // LblNombreUser
            // 
            this.LblNombreUser.AutoSize = true;
            this.LblNombreUser.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUser.Location = new System.Drawing.Point(28, 56);
            this.LblNombreUser.Name = "LblNombreUser";
            this.LblNombreUser.Size = new System.Drawing.Size(108, 17);
            this.LblNombreUser.TabIndex = 1;
            this.LblNombreUser.Text = "Nombre Usuario";
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasena.Location = new System.Drawing.Point(37, 125);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(75, 17);
            this.LblContrasena.TabIndex = 2;
            this.LblContrasena.Text = "Contraseña";
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.Location = new System.Drawing.Point(209, 125);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(179, 24);
            this.TxtContrasena.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(209, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 24);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.LblContrasena);
            this.groupBox1.Controls.Add(this.TxtContrasena);
            this.groupBox1.Controls.Add(this.LblNombreUser);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(123)))), ((int)(((byte)(38)))));
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnAceptar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(558, 114);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(113, 61);
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "   Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(123)))), ((int)(((byte)(38)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(558, 227);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(113, 61);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "    Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // LnkRegistrarse
            // 
            this.LnkRegistrarse.AutoSize = true;
            this.LnkRegistrarse.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkRegistrarse.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnkRegistrarse.Location = new System.Drawing.Point(190, 323);
            this.LnkRegistrarse.Name = "LnkRegistrarse";
            this.LnkRegistrarse.Size = new System.Drawing.Size(96, 21);
            this.LnkRegistrarse.TabIndex = 8;
            this.LnkRegistrarse.TabStop = true;
            this.LnkRegistrarse.Text = "Registrarse";
            // 
            // LnkRestablecer
            // 
            this.LnkRestablecer.AutoSize = true;
            this.LnkRestablecer.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkRestablecer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LnkRestablecer.Location = new System.Drawing.Point(305, 323);
            this.LnkRestablecer.Name = "LnkRestablecer";
            this.LnkRestablecer.Size = new System.Drawing.Size(188, 21);
            this.LnkRestablecer.TabIndex = 9;
            this.LnkRestablecer.TabStop = true;
            this.LnkRestablecer.Text = "¿Olvido Su contraseña?";
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(723, 396);
            this.Controls.Add(this.LnkRestablecer);
            this.Controls.Add(this.LnkRegistrarse);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblUsuarioPlataforma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso Al Sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuarioPlataforma;
        private System.Windows.Forms.Label LblNombreUser;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.LinkLabel LnkRegistrarse;
        private System.Windows.Forms.LinkLabel LnkRestablecer;
    }
}