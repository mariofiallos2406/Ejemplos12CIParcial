<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAcceso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcceso))
        Me.LnkRestablecer = New System.Windows.Forms.LinkLabel()
        Me.LnkRegistrarse = New System.Windows.Forms.LinkLabel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.LblContrasena = New System.Windows.Forms.Label()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.LblNombreUser = New System.Windows.Forms.Label()
        Me.LblUsuarioPlataforma = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LnkRestablecer
        '
        Me.LnkRestablecer.AutoSize = True
        Me.LnkRestablecer.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkRestablecer.LinkColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LnkRestablecer.Location = New System.Drawing.Point(324, 315)
        Me.LnkRestablecer.Name = "LnkRestablecer"
        Me.LnkRestablecer.Size = New System.Drawing.Size(188, 21)
        Me.LnkRestablecer.TabIndex = 15
        Me.LnkRestablecer.TabStop = True
        Me.LnkRestablecer.Text = "¿Olvido Su contraseña?"
        '
        'LnkRegistrarse
        '
        Me.LnkRegistrarse.AutoSize = True
        Me.LnkRegistrarse.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkRegistrarse.LinkColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.LnkRegistrarse.Location = New System.Drawing.Point(209, 315)
        Me.LnkRegistrarse.Name = "LnkRegistrarse"
        Me.LnkRegistrarse.Size = New System.Drawing.Size(96, 21)
        Me.LnkRegistrarse.TabIndex = 14
        Me.LnkRegistrarse.TabStop = True
        Me.LnkRegistrarse.Text = "Registrarse"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(577, 219)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(113, 61)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "    Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.BtnAceptar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(577, 106)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(113, 61)
        Me.BtnAceptar.TabIndex = 12
        Me.BtnAceptar.Text = "   Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.textBox2)
        Me.groupBox1.Controls.Add(Me.LblContrasena)
        Me.groupBox1.Controls.Add(Me.TxtContrasena)
        Me.groupBox1.Controls.Add(Me.LblNombreUser)
        Me.groupBox1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(68, 94)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(446, 194)
        Me.groupBox1.TabIndex = 11
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Acceso"
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(209, 49)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(179, 24)
        Me.textBox2.TabIndex = 4
        '
        'LblContrasena
        '
        Me.LblContrasena.AutoSize = True
        Me.LblContrasena.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContrasena.Location = New System.Drawing.Point(37, 125)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(75, 17)
        Me.LblContrasena.TabIndex = 2
        Me.LblContrasena.Text = "Contraseña"
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(209, 125)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContrasena.Size = New System.Drawing.Size(179, 24)
        Me.TxtContrasena.TabIndex = 3
        '
        'LblNombreUser
        '
        Me.LblNombreUser.AutoSize = True
        Me.LblNombreUser.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreUser.Location = New System.Drawing.Point(28, 56)
        Me.LblNombreUser.Name = "LblNombreUser"
        Me.LblNombreUser.Size = New System.Drawing.Size(108, 17)
        Me.LblNombreUser.TabIndex = 1
        Me.LblNombreUser.Text = "Nombre Usuario"
        '
        'LblUsuarioPlataforma
        '
        Me.LblUsuarioPlataforma.AutoSize = True
        Me.LblUsuarioPlataforma.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuarioPlataforma.Location = New System.Drawing.Point(192, 41)
        Me.LblUsuarioPlataforma.Name = "LblUsuarioPlataforma"
        Me.LblUsuarioPlataforma.Size = New System.Drawing.Size(242, 21)
        Me.LblUsuarioPlataforma.TabIndex = 10
        Me.LblUsuarioPlataforma.Text = "Usuario De La Plataforma"
        '
        'frmAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(740, 387)
        Me.Controls.Add(Me.LnkRestablecer)
        Me.Controls.Add(Me.LnkRegistrarse)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.LblUsuarioPlataforma)
        Me.Name = "frmAcceso"
        Me.Text = "Form2"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LnkRestablecer As LinkLabel
    Private WithEvents LnkRegistrarse As LinkLabel
    Private WithEvents BtnCancelar As Button
    Private WithEvents BtnAceptar As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents LblContrasena As Label
    Private WithEvents TxtContrasena As TextBox
    Private WithEvents LblNombreUser As Label
    Private WithEvents LblUsuarioPlataforma As Label
End Class
