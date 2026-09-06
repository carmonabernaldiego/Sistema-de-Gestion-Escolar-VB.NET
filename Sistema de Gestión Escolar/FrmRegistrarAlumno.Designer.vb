<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarAlumno))
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.TxtIdAlumno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApellidoP = New System.Windows.Forms.TextBox()
        Me.TxtApellidoM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControlDatos = New System.Windows.Forms.TabControl()
        Me.TabPageDatosAlumno = New System.Windows.Forms.TabPage()
        Me.CbbxMunicipio = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRFC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCURP = New System.Windows.Forms.TextBox()
        Me.TabPageDatosPadre = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTelefonoTutor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtApellidoTutorM = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtApellidoTutorP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtNombreTutor = New System.Windows.Forms.TextBox()
        Me.TabPageDatosGenerales = New System.Windows.Forms.TabPage()
        Me.CheckBoxDocumentos = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRepetidor = New System.Windows.Forms.CheckBox()
        Me.CbbxCarrera = New System.Windows.Forms.ComboBox()
        Me.RichTextBoxObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DataGridViewAlumnos = New System.Windows.Forms.DataGridView()
        Me.PictureBoxHerramientas = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.TabControlDatos.SuspendLayout()
        Me.TabPageDatosAlumno.SuspendLayout()
        Me.TabPageDatosPadre.SuspendLayout()
        Me.TabPageDatosGenerales.SuspendLayout()
        CType(Me.DataGridViewAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHerramientas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnCerrar.Location = New System.Drawing.Point(475, 5)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.TabIndex = 16
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
        Me.LblHeader.Size = New System.Drawing.Size(504, 35)
        Me.LblHeader.TabIndex = 15
        Me.LblHeader.Text = "Sistema de Gestión Escolar"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtIdAlumno
        '
        Me.TxtIdAlumno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdAlumno.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtIdAlumno.Location = New System.Drawing.Point(22, 34)
        Me.TxtIdAlumno.Name = "TxtIdAlumno"
        Me.TxtIdAlumno.Size = New System.Drawing.Size(192, 26)
        Me.TxtIdAlumno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(18, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Id Alumno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(253, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNombre.Location = New System.Drawing.Point(257, 34)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(192, 26)
        Me.TxtNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(18, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Apellido Paterno"
        '
        'TxtApellidoP
        '
        Me.TxtApellidoP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtApellidoP.Location = New System.Drawing.Point(22, 85)
        Me.TxtApellidoP.Name = "TxtApellidoP"
        Me.TxtApellidoP.Size = New System.Drawing.Size(192, 26)
        Me.TxtApellidoP.TabIndex = 3
        '
        'TxtApellidoM
        '
        Me.TxtApellidoM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtApellidoM.Location = New System.Drawing.Point(257, 85)
        Me.TxtApellidoM.Name = "TxtApellidoM"
        Me.TxtApellidoM.Size = New System.Drawing.Size(192, 26)
        Me.TxtApellidoM.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(253, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Apellido Materno"
        '
        'TabControlDatos
        '
        Me.TabControlDatos.Controls.Add(Me.TabPageDatosAlumno)
        Me.TabControlDatos.Controls.Add(Me.TabPageDatosPadre)
        Me.TabControlDatos.Controls.Add(Me.TabPageDatosGenerales)
        Me.TabControlDatos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlDatos.HotTrack = True
        Me.TabControlDatos.Location = New System.Drawing.Point(12, 126)
        Me.TabControlDatos.Name = "TabControlDatos"
        Me.TabControlDatos.SelectedIndex = 0
        Me.TabControlDatos.Size = New System.Drawing.Size(480, 312)
        Me.TabControlDatos.TabIndex = 25
        '
        'TabPageDatosAlumno
        '
        Me.TabPageDatosAlumno.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPageDatosAlumno.Controls.Add(Me.CbbxMunicipio)
        Me.TabPageDatosAlumno.Controls.Add(Me.DateTimePickerFechaIngreso)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label10)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label9)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label8)
        Me.TabPageDatosAlumno.Controls.Add(Me.TxtDireccion)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label7)
        Me.TabPageDatosAlumno.Controls.Add(Me.TxtTelefono)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label6)
        Me.TabPageDatosAlumno.Controls.Add(Me.TxtRFC)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label5)
        Me.TabPageDatosAlumno.Controls.Add(Me.TxtCURP)
        Me.TabPageDatosAlumno.Controls.Add(Me.TxtNombre)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label4)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label2)
        Me.TabPageDatosAlumno.Controls.Add(Me.TxtApellidoM)
        Me.TabPageDatosAlumno.Controls.Add(Me.TxtIdAlumno)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label1)
        Me.TabPageDatosAlumno.Controls.Add(Me.Label3)
        Me.TabPageDatosAlumno.Controls.Add(Me.TxtApellidoP)
        Me.TabPageDatosAlumno.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDatosAlumno.Name = "TabPageDatosAlumno"
        Me.TabPageDatosAlumno.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDatosAlumno.Size = New System.Drawing.Size(472, 279)
        Me.TabPageDatosAlumno.TabIndex = 0
        Me.TabPageDatosAlumno.Text = "Datos del Alumno"
        '
        'CbbxMunicipio
        '
        Me.CbbxMunicipio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CbbxMunicipio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbxMunicipio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CbbxMunicipio.FormattingEnabled = True
        Me.CbbxMunicipio.Items.AddRange(New Object() {"Acacoyagua", "Acala", "Acapetahua", "Aldama", "Altamirano", "Amatán", "Amatenango de la Frontera", "Amatenango del Valle", "Ángel Albino Corzo", "Arriaga", "Bejucal de Ocampo", "Bella Vista", "Benemérito de las Américas", "Berriozábal", "Bochil", "Cacahoatán", "Catazajá", "Chalchihuitán", "Chamula", "Chanal", "Chapultenango", "Chenalhó", "Chiapa de Corzo", "Chiapilla", "Chicoasén", "Chicomosuelo", "Chilón", "Cintalpa", "Coapilla", "Comitán de Domínguez", "Copainalá", "El Bosque", "El Porvenir", "Escuintla", "Francisco León", "Frontera Comalapa", "Frontera Hidalgo", "Huehuetán", "Huitiupán", "Huixtán", "Huixtla", "Ixhuatán", "Ixtacomitán", "Ixtapa", "Ixtapangajoya", "Jiquipilas", "Jitotol", "Juárez", "La Concordia", "La Grandeza", "La Independencia", "La Libertad", "La Trinitaria", "Larráinzar", "Las Margaritas", "Las Rosas", "Mapastepec", "Maravilla Tenejapa", "Marqués de Comillas", "Mazapa de Madero", "Mazatán", "Metapa", "Mitontic", "Montecristo de Guerrero", "Motozintla", "Nicolás Ruíz", "Ocosingo", "Ocotepec", "Ocozocoautla de Espinosa", "Ostuacán", "Osumacinta", "Oxchuc", "Palenque", "Pantelhó", "Pantepec", "Pichucalco", "Pijijiapan", "Pueblo Nuevo Solistahuacán", "Rayón", "Reforma", "Sabanilla", "Salto de Agua", "San Andrés Duraznal", "San Cristóbal de las Casas", "San Fernando", "San Juan Cancuc", "San Lucas", "Santiago el Pinar", "Siltepec", "Simojovel", "Sitalá", "Socoltenango", "Solosuchiapa", "Soyaló", "Suchiapa", "Suchiate", "Sunuapa", "Tapachula", "Tapalapa", "Tapilula", "Tecpatán", "Tenejapa", "Teopisca", "Tila", "Tonalá", "Totolapa", "Tumbalá", "Tuxtla Chico", "Tuxtla Gutiérrez", "Tuzantán", "Tzimol", "Unión Juárez", "Venustiano Carranza", "Villa Comaltitlán", "Villa Corzo", "Villaflores", "Yajalón", "Zinacantán"})
        Me.CbbxMunicipio.Location = New System.Drawing.Point(22, 237)
        Me.CbbxMunicipio.Name = "CbbxMunicipio"
        Me.CbbxMunicipio.Size = New System.Drawing.Size(192, 28)
        Me.CbbxMunicipio.Sorted = True
        Me.CbbxMunicipio.TabIndex = 8
        Me.CbbxMunicipio.Text = "Seleccioné"
        '
        'DateTimePickerFechaIngreso
        '
        Me.DateTimePickerFechaIngreso.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePickerFechaIngreso.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DateTimePickerFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaIngreso.Location = New System.Drawing.Point(257, 235)
        Me.DateTimePickerFechaIngreso.Name = "DateTimePickerFechaIngreso"
        Me.DateTimePickerFechaIngreso.Size = New System.Drawing.Size(192, 26)
        Me.DateTimePickerFechaIngreso.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Location = New System.Drawing.Point(253, 215)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Fecha de Ingreso"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(18, 214)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Municipio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(253, 164)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Dirección"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDireccion.Location = New System.Drawing.Point(257, 187)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(192, 26)
        Me.TxtDireccion.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(18, 164)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTelefono.Location = New System.Drawing.Point(22, 187)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(192, 26)
        Me.TxtTelefono.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(253, 113)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "RFC"
        '
        'TxtRFC
        '
        Me.TxtRFC.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRFC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtRFC.Location = New System.Drawing.Point(257, 136)
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.Size = New System.Drawing.Size(192, 26)
        Me.TxtRFC.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(18, 113)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "CURP"
        '
        'TxtCURP
        '
        Me.TxtCURP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCURP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCURP.Location = New System.Drawing.Point(22, 136)
        Me.TxtCURP.Name = "TxtCURP"
        Me.TxtCURP.Size = New System.Drawing.Size(192, 26)
        Me.TxtCURP.TabIndex = 5
        '
        'TabPageDatosPadre
        '
        Me.TabPageDatosPadre.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPageDatosPadre.Controls.Add(Me.Label11)
        Me.TabPageDatosPadre.Controls.Add(Me.TxtTelefonoTutor)
        Me.TabPageDatosPadre.Controls.Add(Me.Label12)
        Me.TabPageDatosPadre.Controls.Add(Me.TxtApellidoTutorM)
        Me.TabPageDatosPadre.Controls.Add(Me.Label13)
        Me.TabPageDatosPadre.Controls.Add(Me.TxtApellidoTutorP)
        Me.TabPageDatosPadre.Controls.Add(Me.Label14)
        Me.TabPageDatosPadre.Controls.Add(Me.TxtNombreTutor)
        Me.TabPageDatosPadre.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDatosPadre.Name = "TabPageDatosPadre"
        Me.TabPageDatosPadre.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDatosPadre.Size = New System.Drawing.Size(472, 279)
        Me.TabPageDatosPadre.TabIndex = 1
        Me.TabPageDatosPadre.Text = "Datos del Tutor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(253, 62)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Telefono"
        '
        'TxtTelefonoTutor
        '
        Me.TxtTelefonoTutor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefonoTutor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTelefonoTutor.Location = New System.Drawing.Point(257, 85)
        Me.TxtTelefonoTutor.Name = "TxtTelefonoTutor"
        Me.TxtTelefonoTutor.Size = New System.Drawing.Size(192, 26)
        Me.TxtTelefonoTutor.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label12.Location = New System.Drawing.Point(18, 62)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 20)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Apellido Materno"
        '
        'TxtApellidoTutorM
        '
        Me.TxtApellidoTutorM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoTutorM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtApellidoTutorM.Location = New System.Drawing.Point(22, 85)
        Me.TxtApellidoTutorM.Name = "TxtApellidoTutorM"
        Me.TxtApellidoTutorM.Size = New System.Drawing.Size(192, 26)
        Me.TxtApellidoTutorM.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label13.Location = New System.Drawing.Point(253, 11)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 20)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Apellido Paterno"
        '
        'TxtApellidoTutorP
        '
        Me.TxtApellidoTutorP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoTutorP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtApellidoTutorP.Location = New System.Drawing.Point(257, 34)
        Me.TxtApellidoTutorP.Name = "TxtApellidoTutorP"
        Me.TxtApellidoTutorP.Size = New System.Drawing.Size(192, 26)
        Me.TxtApellidoTutorP.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label14.Location = New System.Drawing.Point(18, 11)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 20)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Nombre Tutor"
        '
        'TxtNombreTutor
        '
        Me.TxtNombreTutor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreTutor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNombreTutor.Location = New System.Drawing.Point(22, 34)
        Me.TxtNombreTutor.Name = "TxtNombreTutor"
        Me.TxtNombreTutor.Size = New System.Drawing.Size(192, 26)
        Me.TxtNombreTutor.TabIndex = 10
        '
        'TabPageDatosGenerales
        '
        Me.TabPageDatosGenerales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPageDatosGenerales.Controls.Add(Me.CheckBoxDocumentos)
        Me.TabPageDatosGenerales.Controls.Add(Me.CheckBoxRepetidor)
        Me.TabPageDatosGenerales.Controls.Add(Me.CbbxCarrera)
        Me.TabPageDatosGenerales.Controls.Add(Me.RichTextBoxObservaciones)
        Me.TabPageDatosGenerales.Controls.Add(Me.Label21)
        Me.TabPageDatosGenerales.Controls.Add(Me.Label27)
        Me.TabPageDatosGenerales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPageDatosGenerales.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDatosGenerales.Name = "TabPageDatosGenerales"
        Me.TabPageDatosGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDatosGenerales.Size = New System.Drawing.Size(472, 279)
        Me.TabPageDatosGenerales.TabIndex = 2
        Me.TabPageDatosGenerales.Text = "Datos Generales"
        '
        'CheckBoxDocumentos
        '
        Me.CheckBoxDocumentos.AutoSize = True
        Me.CheckBoxDocumentos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxDocumentos.Location = New System.Drawing.Point(323, 36)
        Me.CheckBoxDocumentos.Name = "CheckBoxDocumentos"
        Me.CheckBoxDocumentos.Size = New System.Drawing.Size(129, 24)
        Me.CheckBoxDocumentos.TabIndex = 16
        Me.CheckBoxDocumentos.Text = "Documentos"
        Me.CheckBoxDocumentos.UseVisualStyleBackColor = True
        '
        'CheckBoxRepetidor
        '
        Me.CheckBoxRepetidor.AutoSize = True
        Me.CheckBoxRepetidor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRepetidor.Location = New System.Drawing.Point(187, 36)
        Me.CheckBoxRepetidor.Name = "CheckBoxRepetidor"
        Me.CheckBoxRepetidor.Size = New System.Drawing.Size(107, 24)
        Me.CheckBoxRepetidor.TabIndex = 15
        Me.CheckBoxRepetidor.Text = "Repetidor"
        Me.CheckBoxRepetidor.UseVisualStyleBackColor = True
        '
        'CbbxCarrera
        '
        Me.CbbxCarrera.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CbbxCarrera.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbxCarrera.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CbbxCarrera.FormattingEnabled = True
        Me.CbbxCarrera.Items.AddRange(New Object() {"Automotriz", "Autotronica", "Construcción", "Hospitalidad Turistica", "Informatica", "Tronco Común"})
        Me.CbbxCarrera.Location = New System.Drawing.Point(17, 34)
        Me.CbbxCarrera.Name = "CbbxCarrera"
        Me.CbbxCarrera.Size = New System.Drawing.Size(164, 28)
        Me.CbbxCarrera.Sorted = True
        Me.CbbxCarrera.TabIndex = 14
        Me.CbbxCarrera.Text = "Seleccioné"
        '
        'RichTextBoxObservaciones
        '
        Me.RichTextBoxObservaciones.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxObservaciones.Location = New System.Drawing.Point(17, 99)
        Me.RichTextBoxObservaciones.Name = "RichTextBoxObservaciones"
        Me.RichTextBoxObservaciones.Size = New System.Drawing.Size(435, 165)
        Me.RichTextBoxObservaciones.TabIndex = 17
        Me.RichTextBoxObservaciones.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label21.Location = New System.Drawing.Point(13, 76)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 20)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "Observaciones"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label27.Location = New System.Drawing.Point(13, 11)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 20)
        Me.Label27.TabIndex = 59
        Me.Label27.Text = "Carrera"
        '
        'DataGridViewAlumnos
        '
        Me.DataGridViewAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewAlumnos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAlumnos.Location = New System.Drawing.Point(12, 512)
        Me.DataGridViewAlumnos.Name = "DataGridViewAlumnos"
        Me.DataGridViewAlumnos.Size = New System.Drawing.Size(480, 128)
        Me.DataGridViewAlumnos.TabIndex = 20
        '
        'PictureBoxHerramientas
        '
        Me.PictureBoxHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxHerramientas.Image = CType(resources.GetObject("PictureBoxHerramientas.Image"), System.Drawing.Image)
        Me.PictureBoxHerramientas.Location = New System.Drawing.Point(7, 8)
        Me.PictureBoxHerramientas.Name = "PictureBoxHerramientas"
        Me.PictureBoxHerramientas.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxHerramientas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxHerramientas.TabIndex = 42
        Me.PictureBoxHerramientas.TabStop = False
        '
        'Label23
        '
        Me.Label23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoEllipsis = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label23.Location = New System.Drawing.Point(90, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label23.Size = New System.Drawing.Size(301, 35)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Registro de Alumnos"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Label24
        '
        Me.Label24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoEllipsis = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Window
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Window
        Me.Label24.Location = New System.Drawing.Point(0, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label24.Size = New System.Drawing.Size(504, 68)
        Me.Label24.TabIndex = 47
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoEllipsis = True
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Window
        Me.Label25.Location = New System.Drawing.Point(501, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label25.Size = New System.Drawing.Size(10, 625)
        Me.Label25.TabIndex = 50
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoEllipsis = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.Window
        Me.Label26.Location = New System.Drawing.Point(-7, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label26.Size = New System.Drawing.Size(10, 625)
        Me.Label26.TabIndex = 51
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoEllipsis = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.Window
        Me.Label28.Location = New System.Drawing.Point(-1, 650)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label28.Size = New System.Drawing.Size(507, 10)
        Me.Label28.TabIndex = 52
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BtnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnActualizar.Location = New System.Drawing.Point(319, 54)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(30, 30)
        Me.BtnActualizar.TabIndex = 57
        Me.BtnActualizar.UseVisualStyleBackColor = False
        Me.BtnActualizar.Visible = False
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
        Me.BtnModificar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnModificar.Location = New System.Drawing.Point(354, 54)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(30, 30)
        Me.BtnModificar.TabIndex = 56
        Me.BtnModificar.UseVisualStyleBackColor = False
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
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancelar.Location = New System.Drawing.Point(462, 55)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(30, 30)
        Me.BtnCancelar.TabIndex = 55
        Me.BtnCancelar.UseVisualStyleBackColor = False
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
        Me.BtnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnEliminar.Location = New System.Drawing.Point(426, 55)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(30, 30)
        Me.BtnEliminar.TabIndex = 54
        Me.BtnEliminar.UseVisualStyleBackColor = False
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
        Me.BtnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAgregar.Location = New System.Drawing.Point(390, 54)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.BtnAgregar.TabIndex = 53
        Me.BtnAgregar.UseVisualStyleBackColor = False
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
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGuardar.Location = New System.Drawing.Point(319, 54)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(30, 30)
        Me.BtnGuardar.TabIndex = 58
        Me.BtnGuardar.UseVisualStyleBackColor = False
        Me.BtnGuardar.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.BtnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBuscar.Location = New System.Drawing.Point(12, 444)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(90, 32)
        Me.BtnBuscar.TabIndex = 19
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtBuscar.Location = New System.Drawing.Point(12, 481)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(480, 26)
        Me.TxtBuscar.TabIndex = 18
        '
        'FrmRegistrarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 654)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.PictureBoxHerramientas)
        Me.Controls.Add(Me.DataGridViewAlumnos)
        Me.Controls.Add(Me.TabControlDatos)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistrarAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Alumnos"
        Me.TabControlDatos.ResumeLayout(False)
        Me.TabPageDatosAlumno.ResumeLayout(False)
        Me.TabPageDatosAlumno.PerformLayout()
        Me.TabPageDatosPadre.ResumeLayout(False)
        Me.TabPageDatosPadre.PerformLayout()
        Me.TabPageDatosGenerales.ResumeLayout(False)
        Me.TabPageDatosGenerales.PerformLayout()
        CType(Me.DataGridViewAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHerramientas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents LblHeader As System.Windows.Forms.Label
    Friend WithEvents TxtIdAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellidoM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtApellidoP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControlDatos As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDatosAlumno As System.Windows.Forms.TabPage
    Friend WithEvents TabPageDatosPadre As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtRFC As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCURP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents CbbxMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtApellidoTutorP As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreTutor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTelefonoTutor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtApellidoTutorM As System.Windows.Forms.TextBox
    Friend WithEvents TabPageDatosGenerales As System.Windows.Forms.TabPage
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CbbxCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxDocumentos As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRepetidor As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBoxHerramientas As System.Windows.Forms.PictureBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
End Class
