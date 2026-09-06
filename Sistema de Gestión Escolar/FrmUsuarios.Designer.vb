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
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
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
        Me.PictureBoxHerramientas.Location = New System.Drawing.Point(7, 8)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(531, 5)
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
        Me.LblHeader.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.SystemColors.Window
        Me.LblHeader.Location = New System.Drawing.Point(0, 0)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblHeader.Size = New System.Drawing.Size(560, 35)
        Me.LblHeader.TabIndex = 18
        Me.LblHeader.Text = "Sistema de Gestión Escolar"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAdministracionUsuarios
        '
        Me.LblAdministracionUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAdministracionUsuarios.AutoEllipsis = True
        Me.LblAdministracionUsuarios.BackColor = System.Drawing.Color.White
        Me.LblAdministracionUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdministracionUsuarios.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblAdministracionUsuarios.Location = New System.Drawing.Point(90, 51)
        Me.LblAdministracionUsuarios.Name = "LblAdministracionUsuarios"
        Me.LblAdministracionUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblAdministracionUsuarios.Size = New System.Drawing.Size(442, 35)
        Me.LblAdministracionUsuarios.TabIndex = 25
        Me.LblAdministracionUsuarios.Text = "Administración de Usuarios"
        Me.LblAdministracionUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBoxImagenSistema
        '
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
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(0, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(560, 68)
        Me.Label4.TabIndex = 23
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnExaminar
        '
        Me.BtnExaminar.BackColor = System.Drawing.Color.Transparent
        Me.BtnExaminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnExaminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExaminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnExaminar.Location = New System.Drawing.Point(17, 370)
        Me.BtnExaminar.Name = "BtnExaminar"
        Me.BtnExaminar.Size = New System.Drawing.Size(90, 32)
        Me.BtnExaminar.TabIndex = 5
        Me.BtnExaminar.Text = "Examinar"
        Me.BtnExaminar.UseVisualStyleBackColor = False
        '
        'PictureBoxUsuario
        '
        Me.PictureBoxUsuario.Image = CType(resources.GetObject("PictureBoxUsuario.Image"), System.Drawing.Image)
        Me.PictureBoxUsuario.Location = New System.Drawing.Point(17, 179)
        Me.PictureBoxUsuario.Name = "PictureBoxUsuario"
        Me.PictureBoxUsuario.Size = New System.Drawing.Size(175, 175)
        Me.PictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUsuario.TabIndex = 27
        Me.PictureBoxUsuario.TabStop = False
        '
        'CbbxOpcion
        '
        Me.CbbxOpcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CbbxOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbxOpcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CbbxOpcion.FormattingEnabled = True
        Me.CbbxOpcion.Items.AddRange(New Object() {"Administrador", "Alumno", "Docente"})
        Me.CbbxOpcion.Location = New System.Drawing.Point(17, 141)
        Me.CbbxOpcion.Name = "CbbxOpcion"
        Me.CbbxOpcion.Size = New System.Drawing.Size(175, 28)
        Me.CbbxOpcion.Sorted = True
        Me.CbbxOpcion.TabIndex = 1
        Me.CbbxOpcion.Text = "Seleccioné"
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtContrasena.Location = New System.Drawing.Point(215, 264)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(220, 26)
        Me.TxtContrasena.TabIndex = 3
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtUsuario.Location = New System.Drawing.Point(215, 202)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(220, 26)
        Me.TxtUsuario.TabIndex = 2
        '
        'LblContrasena
        '
        Me.LblContrasena.AutoSize = True
        Me.LblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.LblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContrasena.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblContrasena.Location = New System.Drawing.Point(211, 241)
        Me.LblContrasena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblContrasena.Name = "LblContrasena"
        Me.LblContrasena.Size = New System.Drawing.Size(102, 20)
        Me.LblContrasena.TabIndex = 28
        Me.LblContrasena.Text = "Contraseña"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblUsuario.Location = New System.Drawing.Point(211, 179)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(71, 20)
        Me.LblUsuario.TabIndex = 29
        Me.LblUsuario.Text = "Usuario"
        '
        'LblTipoCuenta
        '
        Me.LblTipoCuenta.AutoSize = True
        Me.LblTipoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoCuenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblTipoCuenta.Location = New System.Drawing.Point(13, 118)
        Me.LblTipoCuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoCuenta.Name = "LblTipoCuenta"
        Me.LblTipoCuenta.Size = New System.Drawing.Size(131, 20)
        Me.LblTipoCuenta.TabIndex = 30
        Me.LblTipoCuenta.Text = "Tipo de Cuenta"
        '
        'TxtContrasenaRepetir
        '
        Me.TxtContrasenaRepetir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasenaRepetir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtContrasenaRepetir.Location = New System.Drawing.Point(215, 328)
        Me.TxtContrasenaRepetir.Name = "TxtContrasenaRepetir"
        Me.TxtContrasenaRepetir.Size = New System.Drawing.Size(220, 26)
        Me.TxtContrasenaRepetir.TabIndex = 4
        Me.TxtContrasenaRepetir.UseSystemPasswordChar = True
        '
        'LblRepetirContrasena
        '
        Me.LblRepetirContrasena.AutoSize = True
        Me.LblRepetirContrasena.BackColor = System.Drawing.Color.Transparent
        Me.LblRepetirContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRepetirContrasena.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblRepetirContrasena.Location = New System.Drawing.Point(211, 305)
        Me.LblRepetirContrasena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRepetirContrasena.Name = "LblRepetirContrasena"
        Me.LblRepetirContrasena.Size = New System.Drawing.Size(166, 20)
        Me.LblRepetirContrasena.TabIndex = 34
        Me.LblRepetirContrasena.Text = "Repetir Contraseña"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGuardar.Location = New System.Drawing.Point(369, 53)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(30, 30)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.UseVisualStyleBackColor = False
        Me.BtnGuardar.Visible = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnAgregar.BackgroundImage = CType(resources.GetObject("BtnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAgregar.Location = New System.Drawing.Point(441, 54)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.BtnAgregar.TabIndex = 9
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEliminar.Location = New System.Drawing.Point(477, 55)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancelar.Location = New System.Drawing.Point(513, 55)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(30, 30)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(215, 368)
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(328, 118)
        Me.DataGridViewUsuarios.TabIndex = 44
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtBuscar.Location = New System.Drawing.Point(17, 460)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(175, 26)
        Me.TxtBuscar.TabIndex = 6
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBuscar.Location = New System.Drawing.Point(17, 422)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(90, 32)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnModificar.Location = New System.Drawing.Point(405, 54)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(30, 30)
        Me.BtnModificar.TabIndex = 45
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnActualizar.BackgroundImage = CType(resources.GetObject("BtnActualizar.BackgroundImage"), System.Drawing.Image)
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnActualizar.Location = New System.Drawing.Point(369, 53)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(30, 30)
        Me.BtnActualizar.TabIndex = 46
        Me.BtnActualizar.UseVisualStyleBackColor = False
        Me.BtnActualizar.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoEllipsis = True
        Me.Label8.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(-2, 497)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(565, 10)
        Me.Label8.TabIndex = 47
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoEllipsis = True
        Me.Label25.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Window
        Me.Label25.Location = New System.Drawing.Point(557, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label25.Size = New System.Drawing.Size(10, 462)
        Me.Label25.TabIndex = 51
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(-7, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(10, 462)
        Me.Label1.TabIndex = 52
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
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
