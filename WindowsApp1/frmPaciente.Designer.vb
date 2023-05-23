<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaciente))
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.textBox8 = New System.Windows.Forms.TextBox()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.LblFechaNac = New System.Windows.Forms.Label()
        Me.LblEdadPaciente = New System.Windows.Forms.Label()
        Me.LblDNIPaciente = New System.Windows.Forms.Label()
        Me.LblTelefonoPaciente = New System.Windows.Forms.Label()
        Me.LblNombrePacientes = New System.Windows.Forms.Label()
        Me.LblDireccionPacientes = New System.Windows.Forms.Label()
        Me.LblCodigoPaciente = New System.Windows.Forms.Label()
        Me.LblIngresosPaciente = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(525, 239)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 18)
        Me.label1.TabIndex = 39
        Me.label1.Text = "Foto:"
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(528, 260)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(167, 124)
        Me.pictureBox1.TabIndex = 38
        Me.pictureBox1.TabStop = False
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.BtnBuscar)
        Me.groupBox2.Controls.Add(Me.BtnEliminar)
        Me.groupBox2.Controls.Add(Me.BtnActualizar)
        Me.groupBox2.Controls.Add(Me.BtnCancelar)
        Me.groupBox2.Controls.Add(Me.BtnGuardar)
        Me.groupBox2.Controls.Add(Me.BtnNuevo)
        Me.groupBox2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.groupBox2.Location = New System.Drawing.Point(738, 22)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(171, 474)
        Me.groupBox2.TabIndex = 37
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Mantenimiento"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnBuscar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(25, 409)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(129, 47)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEliminar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(25, 334)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(129, 47)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "  Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnActualizar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(25, 254)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(129, 47)
        Me.BtnActualizar.TabIndex = 3
        Me.BtnActualizar.Text = "   Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCancelar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(25, 188)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(129, 47)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "  Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGuardar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(25, 111)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(129, 47)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "  Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNuevo.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(25, 39)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(129, 47)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.BtnPrimero)
        Me.groupBox1.Controls.Add(Me.BtnUltimo)
        Me.groupBox1.Controls.Add(Me.BtnSiguiente)
        Me.groupBox1.Controls.Add(Me.BtnAnterior)
        Me.groupBox1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.groupBox1.Location = New System.Drawing.Point(62, 400)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(645, 100)
        Me.groupBox1.TabIndex = 36
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Navegación"
        '
        'BtnPrimero
        '
        Me.BtnPrimero.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrimero.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrimero.Image = CType(resources.GetObject("BtnPrimero.Image"), System.Drawing.Image)
        Me.BtnPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrimero.Location = New System.Drawing.Point(325, 31)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(145, 47)
        Me.BtnPrimero.TabIndex = 20
        Me.BtnPrimero.Text = "  Primero"
        Me.BtnPrimero.UseVisualStyleBackColor = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnUltimo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUltimo.Image = CType(resources.GetObject("BtnUltimo.Image"), System.Drawing.Image)
        Me.BtnUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUltimo.Location = New System.Drawing.Point(476, 31)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(145, 47)
        Me.BtnUltimo.TabIndex = 21
        Me.BtnUltimo.Text = "Último"
        Me.BtnUltimo.UseVisualStyleBackColor = False
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSiguiente.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.Image = CType(resources.GetObject("BtnSiguiente.Image"), System.Drawing.Image)
        Me.BtnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSiguiente.Location = New System.Drawing.Point(23, 31)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(145, 47)
        Me.BtnSiguiente.TabIndex = 18
        Me.BtnSiguiente.Text = "   Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = False
        '
        'BtnAnterior
        '
        Me.BtnAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAnterior.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnterior.Location = New System.Drawing.Point(174, 31)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(145, 47)
        Me.BtnAnterior.TabIndex = 19
        Me.BtnAnterior.Text = "  Anterior"
        Me.BtnAnterior.UseVisualStyleBackColor = False
        '
        'textBox8
        '
        Me.textBox8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox8.Location = New System.Drawing.Point(251, 83)
        Me.textBox8.MaxLength = 5
        Me.textBox8.Name = "textBox8"
        Me.textBox8.Size = New System.Drawing.Size(82, 25)
        Me.textBox8.TabIndex = 35
        '
        'textBox7
        '
        Me.textBox7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox7.Location = New System.Drawing.Point(251, 118)
        Me.textBox7.MaxLength = 50
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(407, 25)
        Me.textBox7.TabIndex = 34
        '
        'textBox6
        '
        Me.textBox6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox6.Location = New System.Drawing.Point(251, 159)
        Me.textBox6.MaxLength = 150
        Me.textBox6.Multiline = True
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(407, 53)
        Me.textBox6.TabIndex = 33
        '
        'textBox5
        '
        Me.textBox5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox5.Location = New System.Drawing.Point(251, 232)
        Me.textBox5.MaxLength = 15
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(144, 25)
        Me.textBox5.TabIndex = 32
        '
        'textBox4
        '
        Me.textBox4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.Location = New System.Drawing.Point(251, 276)
        Me.textBox4.MaxLength = 15
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(179, 25)
        Me.textBox4.TabIndex = 31
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.Location = New System.Drawing.Point(251, 312)
        Me.textBox3.MaxLength = 3
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(45, 25)
        Me.textBox3.TabIndex = 30
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.Location = New System.Drawing.Point(251, 352)
        Me.textBox2.MaxLength = 10
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(102, 25)
        Me.textBox2.TabIndex = 29
        '
        'LblFechaNac
        '
        Me.LblFechaNac.AutoSize = True
        Me.LblFechaNac.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaNac.Location = New System.Drawing.Point(41, 356)
        Me.LblFechaNac.Name = "LblFechaNac"
        Me.LblFechaNac.Size = New System.Drawing.Size(173, 21)
        Me.LblFechaNac.TabIndex = 28
        Me.LblFechaNac.Text = "Fecha Nacimiento:"
        '
        'LblEdadPaciente
        '
        Me.LblEdadPaciente.AutoSize = True
        Me.LblEdadPaciente.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdadPaciente.Location = New System.Drawing.Point(41, 316)
        Me.LblEdadPaciente.Name = "LblEdadPaciente"
        Me.LblEdadPaciente.Size = New System.Drawing.Size(59, 21)
        Me.LblEdadPaciente.TabIndex = 27
        Me.LblEdadPaciente.Text = "Edad:"
        '
        'LblDNIPaciente
        '
        Me.LblDNIPaciente.AutoSize = True
        Me.LblDNIPaciente.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDNIPaciente.Location = New System.Drawing.Point(41, 276)
        Me.LblDNIPaciente.Name = "LblDNIPaciente"
        Me.LblDNIPaciente.Size = New System.Drawing.Size(53, 21)
        Me.LblDNIPaciente.TabIndex = 26
        Me.LblDNIPaciente.Text = "DNI:"
        '
        'LblTelefonoPaciente
        '
        Me.LblTelefonoPaciente.AutoSize = True
        Me.LblTelefonoPaciente.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefonoPaciente.Location = New System.Drawing.Point(41, 236)
        Me.LblTelefonoPaciente.Name = "LblTelefonoPaciente"
        Me.LblTelefonoPaciente.Size = New System.Drawing.Size(92, 21)
        Me.LblTelefonoPaciente.TabIndex = 25
        Me.LblTelefonoPaciente.Text = "Teléfono:"
        '
        'LblNombrePacientes
        '
        Me.LblNombrePacientes.AutoSize = True
        Me.LblNombrePacientes.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombrePacientes.Location = New System.Drawing.Point(41, 118)
        Me.LblNombrePacientes.Name = "LblNombrePacientes"
        Me.LblNombrePacientes.Size = New System.Drawing.Size(81, 21)
        Me.LblNombrePacientes.TabIndex = 24
        Me.LblNombrePacientes.Text = "Nombre:"
        '
        'LblDireccionPacientes
        '
        Me.LblDireccionPacientes.AutoSize = True
        Me.LblDireccionPacientes.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccionPacientes.Location = New System.Drawing.Point(41, 169)
        Me.LblDireccionPacientes.Name = "LblDireccionPacientes"
        Me.LblDireccionPacientes.Size = New System.Drawing.Size(100, 21)
        Me.LblDireccionPacientes.TabIndex = 23
        Me.LblDireccionPacientes.Text = "Dirección:"
        '
        'LblCodigoPaciente
        '
        Me.LblCodigoPaciente.AutoSize = True
        Me.LblCodigoPaciente.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigoPaciente.Location = New System.Drawing.Point(41, 80)
        Me.LblCodigoPaciente.Name = "LblCodigoPaciente"
        Me.LblCodigoPaciente.Size = New System.Drawing.Size(72, 21)
        Me.LblCodigoPaciente.TabIndex = 22
        Me.LblCodigoPaciente.Text = "Código:"
        '
        'LblIngresosPaciente
        '
        Me.LblIngresosPaciente.AutoSize = True
        Me.LblIngresosPaciente.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresosPaciente.Location = New System.Drawing.Point(291, 22)
        Me.LblIngresosPaciente.Name = "LblIngresosPaciente"
        Me.LblIngresosPaciente.Size = New System.Drawing.Size(248, 29)
        Me.LblIngresosPaciente.TabIndex = 21
        Me.LblIngresosPaciente.Text = "Ingreso de Paciente"
        '
        'frmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 522)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.textBox8)
        Me.Controls.Add(Me.textBox7)
        Me.Controls.Add(Me.textBox6)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.LblFechaNac)
        Me.Controls.Add(Me.LblEdadPaciente)
        Me.Controls.Add(Me.LblDNIPaciente)
        Me.Controls.Add(Me.LblTelefonoPaciente)
        Me.Controls.Add(Me.LblNombrePacientes)
        Me.Controls.Add(Me.LblDireccionPacientes)
        Me.Controls.Add(Me.LblCodigoPaciente)
        Me.Controls.Add(Me.LblIngresosPaciente)
        Me.Name = "frmPaciente"
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents BtnBuscar As Button
    Private WithEvents BtnEliminar As Button
    Private WithEvents BtnActualizar As Button
    Private WithEvents BtnCancelar As Button
    Private WithEvents BtnGuardar As Button
    Private WithEvents BtnNuevo As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents BtnPrimero As Button
    Private WithEvents BtnUltimo As Button
    Private WithEvents BtnSiguiente As Button
    Private WithEvents BtnAnterior As Button
    Private WithEvents textBox8 As TextBox
    Private WithEvents textBox7 As TextBox
    Private WithEvents textBox6 As TextBox
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents LblFechaNac As Label
    Private WithEvents LblEdadPaciente As Label
    Private WithEvents LblDNIPaciente As Label
    Private WithEvents LblTelefonoPaciente As Label
    Private WithEvents LblNombrePacientes As Label
    Private WithEvents LblDireccionPacientes As Label
    Private WithEvents LblCodigoPaciente As Label
    Private WithEvents LblIngresosPaciente As Label
End Class
