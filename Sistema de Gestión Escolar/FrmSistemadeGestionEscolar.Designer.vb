<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSistemadeGestionEscolar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSistemadeGestionEscolar))
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarFormulariosActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesDeCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturaDeCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónDeGruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReporteDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeDocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónDeCarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónDeSemestresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdministraciónDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminitraciónDeDocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeSistemaDeGestiónEscolarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxHerramientas = New System.Windows.Forms.PictureBox()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBoxHerramientas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHeader
        '
        Me.LblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHeader.AutoEllipsis = True
        Me.LblHeader.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.SystemColors.Window
        Me.LblHeader.Location = New System.Drawing.Point(2, 0)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblHeader.Size = New System.Drawing.Size(781, 35)
        Me.LblHeader.TabIndex = 1
        Me.LblHeader.Text = "Sistema de Gestión Escolar"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.BackgroundImage = CType(resources.GetObject("BtnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinimizar.ForeColor = System.Drawing.Color.Black
        Me.BtnMinimizar.Location = New System.Drawing.Point(724, 5)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimizar.TabIndex = 0
        Me.BtnMinimizar.TabStop = False
        Me.BtnMinimizar.UseVisualStyleBackColor = False
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
        Me.BtnCerrar.Location = New System.Drawing.Point(753, 5)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.ArchivoToolStripMenuItem, Me.AlumnosToolStripMenuItem, Me.DocentesToolStripMenuItem, Me.GruposToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AdministraciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Location = New System.Drawing.Point(2, 35)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(781, 24)
        Me.MenuStrip.TabIndex = 17
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem1, Me.ToolStripMenuItem2, Me.CerrarSesiónToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        Me.UsuarioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ConfiguraciónToolStripMenuItem1
        '
        Me.ConfiguraciónToolStripMenuItem1.Name = "ConfiguraciónToolStripMenuItem1"
        Me.ConfiguraciónToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.ConfiguraciónToolStripMenuItem1.Text = "Configuración"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(147, 6)
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarFormulariosActivosToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarFormulariosActivosToolStripMenuItem
        '
        Me.CerrarFormulariosActivosToolStripMenuItem.Name = "CerrarFormulariosActivosToolStripMenuItem"
        Me.CerrarFormulariosActivosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.CerrarFormulariosActivosToolStripMenuItem.Text = "Cerrar Formularios Activos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(211, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesDeCalificacionesToolStripMenuItem})
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'ReportesDeCalificacionesToolStripMenuItem
        '
        Me.ReportesDeCalificacionesToolStripMenuItem.Name = "ReportesDeCalificacionesToolStripMenuItem"
        Me.ReportesDeCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ReportesDeCalificacionesToolStripMenuItem.Text = "Reportes de Calificaciones"
        '
        'DocentesToolStripMenuItem
        '
        Me.DocentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CapturaDeCalificacionesToolStripMenuItem})
        Me.DocentesToolStripMenuItem.Name = "DocentesToolStripMenuItem"
        Me.DocentesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.DocentesToolStripMenuItem.Text = "Docentes"
        '
        'CapturaDeCalificacionesToolStripMenuItem
        '
        Me.CapturaDeCalificacionesToolStripMenuItem.Name = "CapturaDeCalificacionesToolStripMenuItem"
        Me.CapturaDeCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CapturaDeCalificacionesToolStripMenuItem.Text = "Captura de Calificaciones"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónDeGruposToolStripMenuItem})
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'AdministraciónDeGruposToolStripMenuItem
        '
        Me.AdministraciónDeGruposToolStripMenuItem.Name = "AdministraciónDeGruposToolStripMenuItem"
        Me.AdministraciónDeGruposToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.AdministraciónDeGruposToolStripMenuItem.Text = "Administración de Grupos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeUsuariosToolStripMenuItem, Me.ToolStripMenuItem4, Me.ReporteDeAlumnosToolStripMenuItem, Me.ReporteDeDocentesToolStripMenuItem, Me.ReporteDePersonalToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteDeUsuariosToolStripMenuItem
        '
        Me.ReporteDeUsuariosToolStripMenuItem.Name = "ReporteDeUsuariosToolStripMenuItem"
        Me.ReporteDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReporteDeUsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(149, 6)
        '
        'ReporteDeAlumnosToolStripMenuItem
        '
        Me.ReporteDeAlumnosToolStripMenuItem.Name = "ReporteDeAlumnosToolStripMenuItem"
        Me.ReporteDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReporteDeAlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'ReporteDeDocentesToolStripMenuItem
        '
        Me.ReporteDeDocentesToolStripMenuItem.Name = "ReporteDeDocentesToolStripMenuItem"
        Me.ReporteDeDocentesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReporteDeDocentesToolStripMenuItem.Text = "Docentes"
        '
        'ReporteDePersonalToolStripMenuItem
        '
        Me.ReporteDePersonalToolStripMenuItem.Name = "ReporteDePersonalToolStripMenuItem"
        Me.ReporteDePersonalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReporteDePersonalToolStripMenuItem.Text = "Personal"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónDeUsuariosToolStripMenuItem, Me.AdministraciónDeCarrerasToolStripMenuItem, Me.AdministraciónDeSemestresToolStripMenuItem, Me.ToolStripMenuItem3, Me.AdministraciónDeAlumnosToolStripMenuItem, Me.AdminitraciónDeDocentesToolStripMenuItem, Me.AdministraciónDePersonalToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'AdministraciónDeUsuariosToolStripMenuItem
        '
        Me.AdministraciónDeUsuariosToolStripMenuItem.Name = "AdministraciónDeUsuariosToolStripMenuItem"
        Me.AdministraciónDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AdministraciónDeUsuariosToolStripMenuItem.Text = "Administración de Usuarios"
        '
        'AdministraciónDeCarrerasToolStripMenuItem
        '
        Me.AdministraciónDeCarrerasToolStripMenuItem.Name = "AdministraciónDeCarrerasToolStripMenuItem"
        Me.AdministraciónDeCarrerasToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AdministraciónDeCarrerasToolStripMenuItem.Text = "Administración de Carreras"
        '
        'AdministraciónDeSemestresToolStripMenuItem
        '
        Me.AdministraciónDeSemestresToolStripMenuItem.Name = "AdministraciónDeSemestresToolStripMenuItem"
        Me.AdministraciónDeSemestresToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AdministraciónDeSemestresToolStripMenuItem.Text = "Administración de Semestres"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(224, 6)
        '
        'AdministraciónDeAlumnosToolStripMenuItem
        '
        Me.AdministraciónDeAlumnosToolStripMenuItem.Name = "AdministraciónDeAlumnosToolStripMenuItem"
        Me.AdministraciónDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AdministraciónDeAlumnosToolStripMenuItem.Text = "Administración de Alumnos"
        '
        'AdminitraciónDeDocentesToolStripMenuItem
        '
        Me.AdminitraciónDeDocentesToolStripMenuItem.Name = "AdminitraciónDeDocentesToolStripMenuItem"
        Me.AdminitraciónDeDocentesToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AdminitraciónDeDocentesToolStripMenuItem.Text = "Administración de Docentes"
        '
        'AdministraciónDePersonalToolStripMenuItem
        '
        Me.AdministraciónDePersonalToolStripMenuItem.Name = "AdministraciónDePersonalToolStripMenuItem"
        Me.AdministraciónDePersonalToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AdministraciónDePersonalToolStripMenuItem.Text = "Administración de Personal"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeSistemaDeGestiónEscolarToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeSistemaDeGestiónEscolarToolStripMenuItem
        '
        Me.AcercaDeSistemaDeGestiónEscolarToolStripMenuItem.Name = "AcercaDeSistemaDeGestiónEscolarToolStripMenuItem"
        Me.AcercaDeSistemaDeGestiónEscolarToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.AcercaDeSistemaDeGestiónEscolarToolStripMenuItem.Text = "Acerca de Sistema de Gestión Escolar"
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
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.SystemColors.Window
        Me.LblHora.Location = New System.Drawing.Point(41, 10)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(56, 16)
        Me.LblHora.TabIndex = 21
        Me.LblHora.Text = "00:00:00"
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        Me.TimerHora.Interval = 1000
        '
        'FrmSistemadeGestionEscolar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.PictureBoxHerramientas)
        Me.Controls.Add(Me.BtnMinimizar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.LblHeader)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmSistemadeGestionEscolar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion Escolar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBoxHerramientas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblHeader As System.Windows.Forms.Label
    Friend WithEvents BtnMinimizar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturaDeCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesDeCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeSistemaDeGestiónEscolarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDeAlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminitraciónDeDocentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDePersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDeCarrerasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDeSemestresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBoxHerramientas As System.Windows.Forms.PictureBox
    Friend WithEvents CerrarFormulariosActivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents TimerHora As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReporteDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReporteDeAlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeDocentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDePersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDeGruposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
