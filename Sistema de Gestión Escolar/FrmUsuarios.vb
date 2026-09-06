Imports System.Data.SqlClient

Public Class FrmUsuarios
    Private conexion As New SqlConnection

    Dim dataset As New DataSet
    Dim dataadapter As SqlDataAdapter
    Dim table As DataTableCollection = dataset.Tables
    Dim command As SqlCommand
    Dim cadena As String


    Dim imagenseleccionada As String
    Dim permisosasignados As Integer
    Dim vmodificar As Boolean
    Dim usuarioe As String

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Public Function CompruebaUsuarioExiste()
        Try
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("SELECT * FROM usuarios", conexion)

            ds.Tables.Add(dt)
            da.Fill(dt)

            conexion.Open()

            For Each datarow In dt.Rows
                If usuarioe = datarow.item(0) Then
                    conexion.Close()
                    Return True
                End If
                conexion.Close()
                conexion.Open()
            Next

            conexion.Close()
            Return False
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function CompruebaAlumnoExiste()
        Try
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("SELECT * FROM alumnos", conexion)

            ds.Tables.Add(dt)
            da.Fill(dt)

            conexion.Open()

            For Each datarow In dt.Rows
                If TxtUsuario.Text = datarow.item(0) Then
                    conexion.Close()
                    Return True
                End If
                conexion.Close()
                conexion.Open()
            Next

            conexion.Close()
            Return False
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Sub Inicio()
        BtnGuardar.Visible = False
        BtnActualizar.Visible = False

        BtnGuardar.BackColor = Color.LightGray
        BtnModificar.BackColor = Color.WhiteSmoke
        BtnAgregar.BackColor = Color.WhiteSmoke
        BtnEliminar.BackColor = Color.WhiteSmoke
        BtnCancelar.BackColor = Color.LightGray

        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        BtnAgregar.Enabled = True
        BtnEliminar.Enabled = True
        BtnCancelar.Enabled = False

        TxtUsuario.Enabled = False
    End Sub

    Sub Agregar()
        BtnGuardar.Visible = True
        BtnActualizar.Visible = False

        BtnGuardar.BackColor = Color.WhiteSmoke
        BtnModificar.BackColor = Color.LightGray
        BtnAgregar.BackColor = Color.LightGray
        BtnEliminar.BackColor = Color.LightGray
        BtnCancelar.BackColor = Color.WhiteSmoke

        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        BtnAgregar.Enabled = False
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = True
    End Sub

    Sub Modificar()
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True

        BtnGuardar.BackColor = Color.WhiteSmoke
        BtnModificar.BackColor = Color.LightGray
        BtnAgregar.BackColor = Color.LightGray
        BtnEliminar.BackColor = Color.LightGray
        BtnCancelar.BackColor = Color.WhiteSmoke

        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
        BtnAgregar.Enabled = False
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = True
    End Sub

    Sub HabilitarControles()
        CbbxOpcion.Enabled = True
        TxtUsuario.Enabled = True
        TxtContrasena.Enabled = True
        TxtContrasenaRepetir.Enabled = True
        BtnExaminar.Enabled = True

        LblTipoCuenta.Enabled = True
        LblUsuario.Enabled = True
        LblContrasena.Enabled = True
        LblRepetirContrasena.Enabled = True

        CbbxOpcion.Focus()
    End Sub

    Sub DesabilitarControles()
        CbbxOpcion.Enabled = False
        TxtUsuario.Enabled = False
        TxtContrasena.Enabled = False
        TxtContrasenaRepetir.Enabled = False
        BtnExaminar.Enabled = False

        LblTipoCuenta.Enabled = False
        LblUsuario.Enabled = False
        LblContrasena.Enabled = False
        LblRepetirContrasena.Enabled = False
    End Sub

    Sub LimpiarControles()
        CbbxOpcion.Text = "Seleccioné"
        TxtUsuario.Text = Nothing
        TxtContrasena.Text = Nothing
        TxtContrasenaRepetir.Text = Nothing
        imagenseleccionada = Nothing
        permisosasignados = Nothing
        PictureBoxUsuario.Image = CargarImagen(My.Application.Info.DirectoryPath & cadenaimagen & "usuario.jpg")
    End Sub

    Sub CargarDatos()
        Try
            conexion.Open()

            dataset = New DataSet
            Dim table As DataTableCollection = dataset.Tables

            cadena = "SELECT usuario, nombre, apepat, apemat, imagen, permisos, contrasena FROM usuarios, alumnos WHERE usuarios.usuario = alumnos.idalumno"

            table = dataset.Tables

            dataadapter = New SqlDataAdapter(cadena, conexion)

            dataadapter.Fill(dataset, "usuarios")

            DataGridViewUsuarios.DataSource = New DataView(table(0))
            DataGridViewUsuarios.Refresh()

            dataset.Dispose()
            dataadapter.Dispose()

            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
            conexion.Close()
        End Try
    End Sub

    Sub Datas()
        With dataset.Tables("usuarios")

            .DefaultView.Sort = "usuario"

            DataGridViewUsuarios.DataSource = .DefaultView
        End With
    End Sub

    Private Sub LblHeader_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblHeader.MouseDown
        ex = e.X
        ey = e.Y

        Arrastre = True
    End Sub

    Private Sub LblHeader_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblHeader.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub LblHeader_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblHeader.MouseUp
        Arrastre = False
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub PictureBoxHerramientas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxHerramientas.DoubleClick
        Close()
    End Sub

    Private Sub TxtContrasena_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtContrasena.MouseClick
        If vmodificar = True Then
            TxtContrasena.Text = Nothing
            TxtContrasenaRepetir.Text = Nothing
        End If
    End Sub

    Private Sub TxtContrasenaRepetir_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtContrasenaRepetir.MouseClick
        If vmodificar = True Then
            TxtContrasena.Text = Nothing
            TxtContrasenaRepetir.Text = Nothing
        End If
    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TxtBuscar.Focus()
            conexion.ConnectionString = cadenaconexion

            DesabilitarControles()
            Inicio()
            CargarDatos()

            With DataGridViewUsuarios
                .ReadOnly = False

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect

                .MultiSelect = False

                .AllowUserToAddRows = False
            End With

            Datas()
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles BtnExaminar.Click
        OpenFileDialogImagen.Title = "Seleccionar Imagen de Cuenta"
        OpenFileDialogImagen.InitialDirectory = My.Application.Info.DirectoryPath & cadenaimagen
        OpenFileDialogImagen.Multiselect = False
        OpenFileDialogImagen.DefaultExt = ".jpg"
        OpenFileDialogImagen.Filter = "Archivos de Imagenes (.jpg)|*.jpg"

        If OpenFileDialogImagen.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBoxUsuario.Image = Image.FromFile(OpenFileDialogImagen.FileName)
            imagenseleccionada = OpenFileDialogImagen.SafeFileName
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            If TxtBuscar.Text = "" Then Exit Sub
            If DataGridViewUsuarios.Rows.Count < 1 Then Exit Sub

            With dataset.Tables("usuarios")

                .DefaultView.Sort = "usuario"

                If DataGridViewUsuarios.Rows.Count > 0 Then
                End If

            End With

            Dim fila As Integer = dataset.Tables("usuarios").DefaultView.Find(TxtBuscar.Text)

            If fila <> -1 Then

                With DataGridViewUsuarios
                    .FirstDisplayedScrollingRowIndex = fila
                    .CurrentCell = .Rows(fila).Cells(0)
                    .Select()
                End With
            Else
                MsgBox("NO SE ENCONTRO EL REGISTRO", MessageBoxIcon.Information)
                TxtBuscar.Focus()
            End If

            Datas()
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CbbxOpcion.Text = "Seleccioné" Then
            MsgBox("DEBE SELECCIONAR EL TIPO DE CUENTA", MessageBoxIcon.Error)
            CbbxOpcion.Focus()
        ElseIf TxtUsuario.Text = "" Then
            MsgBox("USUARIO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtUsuario.Focus()
        ElseIf TxtContrasena.Text = "" Then
            MsgBox("CONTRASEÑA: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtContrasena.Focus()
        ElseIf TxtContrasenaRepetir.Text = "" Then
            MsgBox("REPETIR CONTRASEÑA: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtContrasenaRepetir.Focus()
        ElseIf imagenseleccionada = Nothing Then
            MsgBox("DEBE SELECCIONAR UNA IMAGEN", MessageBoxIcon.Error)
            BtnExaminar.PerformClick()
        ElseIf CompruebaAlumnoExiste() = False Then
            MsgBox("EL USUARIO NECESITA ESTAR REGISTRADO EN EL SISTEMA", MessageBoxIcon.Error)
        Else
            If CbbxOpcion.Text = "Administrador" Then
                permisosasignados = 100
            ElseIf CbbxOpcion.Text = "Docente" Then
                permisosasignados = 50
            ElseIf CbbxOpcion.Text = "Alumno" Then
                permisosasignados = 25
            End If

            conexion.Open()

            Dim consulta As String
            consulta = "INSERT INTO usuarios (usuario, contrasena, permisos, imagen) VALUES('" & TxtUsuario.Text & "', '" & TxtContrasena.Text & "', " & permisosasignados & ", '" & imagenseleccionada & "')"

            Dim command As SqlCommand = New SqlCommand(consulta, conexion)

            Try
                command.ExecuteNonQuery()
                MsgBox("EL USUARIO SE AGREGÓ CON ÉXITO", MsgBoxStyle.Information)

                conexion.Close()

                DesabilitarControles()
                LimpiarControles()
                Inicio()
                CargarDatos()
                Datas()
            Catch ex As Exception
                MsgBox("EL USUARIO YA EXISTE", MsgBoxStyle.Critical)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If CbbxOpcion.Text = "Seleccioné" Then
            MsgBox("DEBE SELECCIONAR EL TIPO DE CUENTA", MessageBoxIcon.Error)
            CbbxOpcion.Focus()
        ElseIf TxtUsuario.Text = "" Then
            MsgBox("USUARIO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtUsuario.Focus()
        ElseIf TxtContrasena.Text = "" Then
            MsgBox("CONTRASEÑA: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtContrasena.Focus()
        ElseIf TxtContrasenaRepetir.Text = "" Then
            MsgBox("REPETIR CONTRASEÑA: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtContrasenaRepetir.Focus()
        ElseIf imagenseleccionada = Nothing Then
            MsgBox("DEBE SELECCIONAR UNA IMAGEN", MessageBoxIcon.Error)
            BtnExaminar.PerformClick()
        ElseIf CompruebaAlumnoExiste() = False Then
            MsgBox("EL USUARIO NECESITA ESTAR REGISTRADO EN EL SISTEMA", MessageBoxIcon.Error)
        Else
            If CbbxOpcion.Text = "Administrador" Then
                permisosasignados = 100
            ElseIf CbbxOpcion.Text = "Docente" Then
                permisosasignados = 50
            ElseIf CbbxOpcion.Text = "Alumno" Then
                permisosasignados = 25
            End If

            conexion.Open()

            Dim consulta As String
            consulta = "UPDATE usuarios SET contrasena = '" & TxtContrasena.Text & "', permisos=" & permisosasignados & ", imagen='" & imagenseleccionada & "' WHERE usuario='" & TxtUsuario.Text & "'"

            Dim command As SqlCommand = New SqlCommand(consulta, conexion)

            Try
                command.ExecuteNonQuery()
                MsgBox("EL USUARIO SE ACTUALIZO CON ÉXITO", MsgBoxStyle.Information)

                conexion.Close()

                DesabilitarControles()
                LimpiarControles()
                Inicio()
                CargarDatos()
                Datas()
            Catch ex As Exception
                MsgBox("ERROR AL ACTUALIZAR LA INFORMACIÓN DEL USUARIO", MsgBoxStyle.Critical)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Modificar()
        vmodificar = True

        Dim filaseleccionada As DataGridViewRow = DataGridViewUsuarios.CurrentRow

        conexion.Open()

        Dim consulta As String
        consulta = "SELECT * FROM usuarios, alumnos WHERE usuarios.usuario = alumnos.idalumno AND usuario='" & filaseleccionada.Cells("usuario").Value & "'"

        Dim command As New SqlClient.SqlCommand(consulta, conexion)

        Dim datareader As SqlClient.SqlDataReader
        datareader = command.ExecuteReader

        If datareader.Read Then
            TxtUsuario.Text = datareader(0)
            TxtContrasena.Text = datareader(1)
            TxtContrasenaRepetir.Text = datareader(1)
            permisosasignados = datareader(2)

            If permisosasignados = 100 Then
                CbbxOpcion.Text = "Administrador"
            End If

            imagenseleccionada = datareader(3)
            PictureBoxUsuario.Image = CargarImagen(My.Application.Info.DirectoryPath & cadenaimagen & datareader(3))
        End If
        conexion.Close()

        Datas()
        HabilitarControles()
        TxtUsuario.Enabled = False
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Agregar()
        vmodificar = False
        HabilitarControles()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        usuarioe = InputBox("INGRESA EL ID DE USUARIO A ELIMINAR")

        If usuarioe <> "" Then
            If MsgBox("¿ESTÁ SEGURO DE ELIMINAR EL REGISTRO?", vbYesNo, "") = vbYes Then
                If CompruebaUsuarioExiste() = True Then
                    conexion.Open()

                    Dim consulta As String
                    consulta = "DELETE FROM usuarios WHERE usuario='" & usuarioe & "'"

                    Dim command As SqlCommand = New SqlCommand(consulta, conexion)

                    Try
                        command.ExecuteNonQuery()
                        MsgBox("EL USUARIO SE ELIMINO CON ÉXITO", MsgBoxStyle.Information)

                        conexion.Close()

                        DesabilitarControles()
                        LimpiarControles()
                        Inicio()
                        CargarDatos()
                        Datas()
                    Catch ex As Exception
                        MsgBox("ERROR AL EIMINAR EL REGISTRO", MsgBoxStyle.Critical)
                        conexion.Close()
                    End Try
                Else
                    MsgBox("EL USUARIO NO EXISTE", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Inicio()
        LimpiarControles
        DesabilitarControles()
        TxtBuscar.Focus()
    End Sub
End Class