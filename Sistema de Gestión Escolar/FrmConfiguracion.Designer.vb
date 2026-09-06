<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracion))
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.PictureBoxHerramientas = New System.Windows.Forms.PictureBox()
        Me.PictureBoxUsuario = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblNombreApellidos = New System.Windows.Forms.Label()
        Me.BtnExaminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCambiarContrasena = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialogImagen = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxHerramientas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Black
        Me.BtnCerrar.Location = New System.Drawing.Point(621, 5)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LblHeader
        '
        Me.LblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHeader.AutoEllipsis = True
        Me.LblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LblHeader.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.SystemColors.Window
        Me.LblHeader.Location = New System.Drawing.Point(0, 0)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblHeader.Size = New System.Drawing.Size(650, 35)
        Me.LblHeader.TabIndex = 12
        Me.LblHeader.Text = "Sistema de Gestión Escolar"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxHerramientas
        '
        Me.PictureBoxHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxHerramientas.Image = CType(resources.GetObject("PictureBoxHerramientas.Image"), System.Drawing.Image)
        Me.PictureBoxHerramientas.Location = New System.Drawing.Point(7, 8)
        Me.PictureBoxHerramientas.Name = "PictureBoxHerramientas"
        Me.PictureBoxHerramientas.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxHerramientas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHerramientas.TabIndex = 16
        Me.PictureBoxHerramientas.TabStop = False
        '
        'PictureBoxUsuario
        '
        Me.PictureBoxUsuario.Location = New System.Drawing.Point(16, 118)
        Me.PictureBoxUsuario.Name = "PictureBoxUsuario"
        Me.PictureBoxUsuario.Size = New System.Drawing.Size(175, 175)
        Me.PictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUsuario.TabIndex = 18
        Me.PictureBoxUsuario.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(0, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(649, 68)
        Me.Label4.TabIndex = 20
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(90, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(532, 35)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Configuración de la Cuenta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblUsuario
        '
        Me.LblUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblUsuario.AutoEllipsis = True
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblUsuario.Location = New System.Drawing.Point(201, 164)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblUsuario.Size = New System.Drawing.Size(108, 20)
        Me.LblUsuario.TabIndex = 23
        Me.LblUsuario.Text = "Id de Usuario"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNombreApellidos
        '
        Me.LblNombreApellidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNombreApellidos.AutoEllipsis = True
        Me.LblNombreApellidos.AutoSize = True
        Me.LblNombreApellidos.BackColor = System.Drawing.Color.Transparent
        Me.LblNombreApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreApellidos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblNombreApellidos.Location = New System.Drawing.Point(201, 144)
        Me.LblNombreApellidos.Name = "LblNombreApellidos"
        Me.LblNombreApellidos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblNombreApellidos.Size = New System.Drawing.Size(141, 20)
        Me.LblNombreApellidos.TabIndex = 24
        Me.LblNombreApellidos.Text = "Nombre Apellidos"
        Me.LblNombreApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnExaminar
        '
        Me.BtnExaminar.BackColor = System.Drawing.Color.Transparent
        Me.BtnExaminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnExaminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExaminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExaminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnExaminar.Location = New System.Drawing.Point(16, 309)
        Me.BtnExaminar.Name = "BtnExaminar"
        Me.BtnExaminar.Size = New System.Drawing.Size(90, 32)
        Me.BtnExaminar.TabIndex = 1
        Me.BtnExaminar.Text = "Examinar"
        Me.BtnExaminar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(196, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Contraseña"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(196, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(432, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Una contraseña segura te ayuda a proteger mejor tu cuenta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnCambiarContrasena
        '
        Me.BtnCambiarContrasena.BackColor = System.Drawing.Color.Transparent
        Me.BtnCambiarContrasena.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnCambiarContrasena.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnCambiarContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCambiarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCambiarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCambiarContrasena.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCambiarContrasena.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCambiarContrasena.Location = New System.Drawing.Point(201, 261)
        Me.BtnCambiarContrasena.Name = "BtnCambiarContrasena"
        Me.BtnCambiarContrasena.Size = New System.Drawing.Size(90, 32)
        Me.BtnCambiarContrasena.TabIndex = 2
        Me.BtnCambiarContrasena.Text = "Cambiar"
        Me.BtnCambiarContrasena.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(201, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(163, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Nombre de Usuario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(647, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(10, 349)
        Me.Label2.TabIndex = 30
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoEllipsis = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(-7, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(10, 349)
        Me.Label7.TabIndex = 31
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoEllipsis = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(-1, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(653, 10)
        Me.Label8.TabIndex = 32
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(650, 380)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCambiarContrasena)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnExaminar)
        Me.Controls.Add(Me.LblNombreApellidos)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBoxUsuario)
        Me.Controls.Add(Me.PictureBoxHerramientas)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FrmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConfiguracion"
        CType(Me.PictureBoxHerramientas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents LblHeader As System.Windows.Forms.Label
    Friend WithEvents PictureBoxHerramientas As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents LblNombreApellidos As System.Windows.Forms.Label
    Friend WithEvents BtnExaminar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnCambiarContrasena As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialogImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
