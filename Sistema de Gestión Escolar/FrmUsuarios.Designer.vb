<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
    'No lo modifique con el editor de cÃ³digo.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Dim dgvHeaderStyle As New System.Windows.Forms.DataGridViewCellStyle()
        Dim dgvRowStyle As New System.Windows.Forms.DataGridViewCellStyle()
        Dim dgvAltStyle As New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBoxHerramientas = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.LblAdministracionUsuarios = New System.Windows.Forms.Label()
        Me.PictureBoxImagenSistema = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnExaminar = New System.Windows.Forms.Button()
        Me.PictureBoxUsuario = New System.Windows.Forms.PictureBox()
        Me.CbbxOpcion = New System.Windows.Forms.ComboBox()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblContrasena = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblTipoCuenta = New System.Windows.Forms.Label()
        Me.TxtContrasenaRepetir = New System.Windows.Forms.TextBox()
        Me.LblRepetirContrasena = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.DataGridViewUsuarios = New System.Windows.Forms.DataGridView()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.OpenFileDialogImagen = New System.Windows.Forms.OpenFileDialog()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxHerramientas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImagenSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxHerramientas
        '
        Me.PictureBoxHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxHerramientas.Image = CType(resources.GetObject("PictureBoxHerramientas.Image"), System.Drawing.Image)
        Me.PictureBoxHerramientas.Location = New System.Drawing.Point(8, 8)
        Me.PictureBoxHerramientas.Name = "PictureBoxHerramientas"
        Me.PictureBoxHerramientas.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxHerramientas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHerramientas.TabIndex = 19
        Me.PictureBoxHerramientas.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(524, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(32, 28)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        Me.BtnCerrar.Text = "X"
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LblHeader
        '
        Me.LblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHeader.AutoEllipsis = True
        Me.LblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LblHeader.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.White
        Me.LblHeader.Location = New System.Drawing.Point(0, 0)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblHeader.Size = New System.Drawing.Size(560, 36)
        Me.LblHeader.TabIndex = 18
        Me.LblHeader.Text = "Sistema de GestiÃ³n Escolar"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAdministracionUsuarios
        '
        Me.LblAdministracionUsuarios.BackColor = System.Drawing.Color.White
        Me.LblAdministracionUsuarios.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdministracionUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LblAdministracionUsuarios.Location = New System.Drawing.Point(72, 44)
        Me.LblAdministracionUsuarios.Name = "LblAdministracionUsuarios"
        Me.LblAdministracionUsuarios.Size = New System.Drawing.Size(262, 50)
        Me.LblAdministracionUsuarios.TabIndex = 25
        Me.LblAdministracionUsuarios.Text = "AdministraciÃ³n de Usuarios"
        Me.LblAdministracionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBoxImagenSistema
        '
        Me.PictureBoxImagenSistema.BackColor = System.Drawing.Color.White
        Me.PictureBoxImagenSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxImagenSistema.Image = CType(resources.GetObject("PictureBoxImagenSistema.Image"), System.Drawing.Image)
        Me.PictureBoxImagenSistema.Location = New System.Drawing.Point(16, 44)
        Me.PictureBoxImagenSistema.Name = "PictureBoxImagenSistema"
        Me.PictureBoxImagenSistema.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxImagenSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxImagenSistema.TabIndex = 24
        Me.PictureBoxImagenSistema.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(560, 68)
        Me.Label4.TabIndex = 23
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnExaminar
        '
        Me.BtnExaminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnExaminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnExaminar.FlatAppearance.BorderSize = 1
        Me.BtnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExaminar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExaminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnExaminar.Location = New System.Drawing.Point(17, 368)
        Me.BtnExaminar.Name = "BtnExaminar"
        Me.BtnExaminar.Size = New System.Drawing.Size(175, 30)
        Me.BtnExaminar.TabIndex = 5
        Me.BtnExaminar.Text = "Examinar Foto"
        Me.BtnExaminar.UseVisualStyleBackColor = False
        '
        'PictureBoxUsuario
        '
        Me.PictureBoxUsuario.BackColor = System.Drawing.Color.White
        Me.PictureBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxUsuario.Image = CType(resources.GetObject("PictureBoxUsuario.Image"), System.Drawing.Image)
        Me.PictureBoxUsuario.Location = New System.Drawing.Point(17, 185)
        Me.PictureBoxUsuario.Name = "PictureBoxUsuario"
        Me.PictureBoxUsuario.Size = New System.Drawing.Size(175, 175)
        Me.PictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUsuario.TabIndex = 27
        Me.PictureBoxUsuario.TabStop = False
        '
        'CbbxOpcion
        '
        Me.CbbxOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbxOpcion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbxOpcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.CbbxOpcion.FormattingEnabled = True
        Me.CbbxOpcion.Items.AddRange(New Object() {"Administrador", "Alumno", "Docente"})
        Me.CbbxOpcion.Location = New System.Drawing.Point(17, 142)
        Me.CbbxOpcion.Name = "CbbxOpcion"
        Me.CbbxOpcion.Size = New System.Drawing.Size(175, 25)
        Me.CbbxOpcion.Sorted = True
        Me.CbbxOpcion.TabIndex = 1
        '
        'TxtContrasena
        '
        Me.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtContrasena.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TxtContrasena.Location = New System.Drawing.Point(215, 245)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(328, 25)
        Me.TxtContrasena.TabIndex = 3
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TxtUsuario.Location = New System.Drawing.Point(215, 185)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(328, 25)
        Me.TxtUsuario.TabIndex = 2
        '
        'LblContrasena
        '
        Me.LblContrasena.AutoSize = True
        Me.LblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.LblContrasena.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LblContrasena.Location = New System.Drawing.Point(212, 224)
        Me.LblContrasena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(74, 17)
        Me.LblContrasena.TabIndex = 28
        Me.LblContrasena.Text = "Contraseña"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LblUsuario.Location = New System.Drawing.Point(212, 164)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(53, 17)
        Me.LblUsuario.TabIndex = 29
        Me.LblUsuario.Text = "Usuario"
        '
        'LblTipoCuenta
        '
        Me.LblTipoCuenta.AutoSize = True
        Me.LblTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoCuenta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LblTipoCuenta.Location = New System.Drawing.Point(14, 121)
        Me.LblTipoCuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoCuenta.Name = "LblTipoCuenta"
        Me.LblTipoCuenta.Size = New System.Drawing.Size(95, 17)
        Me.LblTipoCuenta.TabIndex = 30
        Me.LblTipoCuenta.Text = "Tipo de Cuenta"
        '
        'TxtContrasenaRepetir
        '
        Me.TxtContrasenaRepetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtContrasenaRepetir.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasenaRepetir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TxtContrasenaRepetir.Location = New System.Drawing.Point(215, 305)
        Me.TxtContrasenaRepetir.Name = "TxtContrasenaRepetir"
        Me.TxtContrasenaRepetir.Size = New System.Drawing.Size(328, 25)
        Me.TxtContrasenaRepetir.TabIndex = 4
        Me.TxtContrasenaRepetir.UseSystemPasswordChar = True
        '
        'LblRepetirContrasena
        '
        Me.LblRepetirContrasena.AutoSize = True
        Me.LblRepetirContrasena.BackColor = System.Drawing.Color.Transparent
        Me.LblRepetirContrasena.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRepetirContrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.LblRepetirContrasena.Location = New System.Drawing.Point(212, 284)
        Me.LblRepetirContrasena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRepetirContrasena.Name = "LblRepetirContrasena"
        Me.LblRepetirContrasena.Size = New System.Drawing.Size(119, 17)
        Me.LblRepetirContrasena.TabIndex = 31
        Me.LblRepetirContrasena.Text = "Repetir Contraseña"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(333, 53)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(32, 32)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAgregar.BackgroundImage = CType(resources.GetObject("BtnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnAgregar.FlatAppearance.BorderSize = 1
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAgregar.Location = New System.Drawing.Point(441, 54)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(32, 32)
        Me.BtnAgregar.TabIndex = 9
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnEliminar.FlatAppearance.BorderSize = 1
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEliminar.Location = New System.Drawing.Point(479, 54)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(32, 32)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.BorderSize = 1
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancelar.Location = New System.Drawing.Point(517, 54)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'DataGridViewUsuarios
        '
        dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        dgvHeaderStyle.ForeColor = System.Drawing.Color.White
        dgvHeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgvRowStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgvRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(233, Byte), Integer))
        dgvRowStyle.SelectionForeColor = System.Drawing.Color.White
        dgvAltStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        dgvAltStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgvAltStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(233, Byte), Integer))
        dgvAltStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DataGridViewUsuarios.EnableHeadersVisualStyles = False
        Me.DataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dgvHeaderStyle
        Me.DataGridViewUsuarios.DefaultCellStyle = dgvRowStyle
        Me.DataGridViewUsuarios.AlternatingRowsDefaultCellStyle = dgvAltStyle
        Me.DataGridViewUsuarios.RowHeadersVisible = False
        Me.DataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(215, 345)
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(328, 140)
        Me.DataGridViewUsuarios.TabIndex = 44
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TxtBuscar.Location = New System.Drawing.Point(17, 455)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(175, 25)
        Me.TxtBuscar.TabIndex = 6
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnBuscar.FlatAppearance.BorderSize = 1
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BtnBuscar.Location = New System.Drawing.Point(17, 415)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(175, 30)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar Usuario"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnModificar.FlatAppearance.BorderSize = 1
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnModificar.Location = New System.Drawing.Point(403, 54)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(32, 32)
        Me.BtnModificar.TabIndex = 45
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnActualizar.BackgroundImage = CType(resources.GetObject("BtnActualizar.BackgroundImage"), System.Drawing.Image)
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.BtnActualizar.FlatAppearance.BorderSize = 1
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnActualizar.Location = New System.Drawing.Point(365, 54)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(32, 32)
        Me.BtnActualizar.TabIndex = 46
        Me.BtnActualizar.UseVisualStyleBackColor = False
        Me.BtnActualizar.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(0, 499)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(560, 1)
        Me.Label8.TabIndex = 47
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(559, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(1, 464)
        Me.Label25.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1, 464)
        Me.Label1.TabIndex = 52
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.DataGridViewUsuarios)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtContrasenaRepetir)
        Me.Controls.Add(Me.LblRepetirContrasena)
        Me.Controls.Add(Me.CbbxOpcion)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblContrasena)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LblTipoCuenta)
        Me.Controls.Add(Me.BtnExaminar)
        Me.Controls.Add(Me.PictureBoxUsuario)
        Me.Controls.Add(Me.LblAdministracionUsuarios)
        Me.Controls.Add(Me.PictureBoxImagenSistema)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBoxHerramientas)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(560, 500)
        Me.MinimumSize = New System.Drawing.Size(560, 500)
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUsuarios"
        CType(Me.PictureBoxHerramientas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImagenSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBoxHerramientas As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents LblHeader As System.Windows.Forms.Label
    Friend WithEvents LblAdministracionUsuarios As System.Windows.Forms.Label
    Friend WithEvents PictureBoxImagenSistema As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnExaminar As System.Windows.Forms.Button
    Friend WithEvents PictureBoxUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents CbbxOpcion As System.Windows.Forms.ComboBox
    Friend WithEvents TxtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblContrasena As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents LblTipoCuenta As System.Windows.Forms.Label
    Friend WithEvents TxtContrasenaRepetir As System.Windows.Forms.TextBox
    Friend WithEvents LblRepetirContrasena As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class