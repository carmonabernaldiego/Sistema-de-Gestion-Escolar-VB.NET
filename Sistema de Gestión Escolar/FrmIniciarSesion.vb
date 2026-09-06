Imports System.Data.SqlClient

Public Class FrmIniciarSesion
    Private conexion As New SqlClient.SqlConnection

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Public Function Usuarios()

        Cursor = Cursors.WaitCursor

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SELECT * FROM usuarios", conexion)

        ds.Tables.Add(dt)
        da.Fill(dt)

        conexion.Open()

        For Each datarow In dt.Rows
            If TxtUsuario.Text = datarow.item(0) And TxtContrasena.Text = datarow(1) Then
                If 100 = datarow(2) Then
                    conexion.Close()
                    LoadingUser()
                    Return True
                ElseIf 75 = datarow(2) Then
                    Return True
                ElseIf 50 = datarow(2) Then
                    Return True
                ElseIf 25 = datarow(2) Then
                    Return True
                End If
            End If
            conexion.Close()
        Next

        conexion.Close()
        Cursor = Cursors.Default
        Return False

    End Function

    Private Sub LoadingUser()

        conexion.Open()

        Dim consulta As String
        consulta = "SELECT * FROM usuarios, alumnos WHERE usuarios.usuario = alumnos.idalumno AND usuario='" & TxtUsuario.Text & "'"

        Dim command As New SqlClient.SqlCommand(consulta, conexion)

        Dim datareader As SqlClient.SqlDataReader
        datareader = command.ExecuteReader

        If datareader.Read Then
            usuario = datareader(0)
            contrasena = datareader(1)
            nombre = datareader(7)
            apellidop = datareader(8)
            apellidom = datareader(9)
            imagen = datareader(3)
        End If
        conexion.Close()

        Me.Hide()

    End Sub

    Private Sub RestablecerFormulario()
        CbbxOpcion.Text = "Seleccione"
        CbbxOpcion.Focus()
        TxtUsuario.Text = Nothing
        TxtContrasena.Text = Nothing
        Cursor = Cursors.Default
    End Sub
    Private Sub FrmIniciarSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearConexion()
        My.Settings.Item("bdsisescolarConnectionString") = cadenaconexion
        My.Settings.Save()
        conexion.ConnectionString = cadenaconexion
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

    Private Sub BtnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        End
    End Sub

    Private Sub PictureBoxHerramientas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxHerramientas.DoubleClick
        End
    End Sub

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        If CbbxOpcion.Text = "Seleccioné" Then
            MsgBox("DEBE SELECCIONAR EL TIPO DE CUENTA", MessageBoxIcon.Error)
            CbbxOpcion.Focus()
        ElseIf TxtUsuario.Text = "" Then
            MsgBox("USUARIO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtUsuario.Focus()
        ElseIf TxtContrasena.Text = "" Then
            MsgBox("CONTRASEÑA: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtContrasena.Focus()
        ElseIf CbbxOpcion.Text = "Administrador" And Usuarios() = True Then
            FrmSistemadeGestionEscolar.Show()
            RestablecerFormulario()
        ElseIf CbbxOpcion.Text = "Alumno" And Usuarios() = True Then
            FrmSistemadeGestionEscolar.Show()
            RestablecerFormulario()
        ElseIf CbbxOpcion.Text = "Docente" And Usuarios() = True Then
            FrmSistemadeGestionEscolar.Show()
            RestablecerFormulario()
        Else
            MsgBox("USUARIO O CONTRASEÑA INCORRECTOS", MessageBoxIcon.Error)
            RestablecerFormulario()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class
