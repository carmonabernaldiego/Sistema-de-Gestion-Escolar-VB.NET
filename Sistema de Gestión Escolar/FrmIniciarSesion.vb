Imports System.Data.SqlClient

Public Class FrmIniciarSesion
    Private conexion As New SqlClient.SqlConnection

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Public Function Usuarios() As Boolean

        Cursor = Cursors.WaitCursor

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter("SELECT * FROM usuarios", conexion)
        da.Fill(dt)

        For Each datarow As DataRow In dt.Rows
            If TxtUsuario.Text = datarow(0).ToString() AndAlso TxtContrasena.Text = datarow(1).ToString() Then
                Dim rol As Integer = Convert.ToInt32(datarow(2))
                If rol = 100 Then
                    LoadingUser()
                    Cursor = Cursors.Default
                    Return True
                ElseIf rol = 75 OrElse rol = 50 OrElse rol = 25 Then
                    Cursor = Cursors.Default
                    Return True
                End If
            End If
        Next

        Cursor = Cursors.Default
        Return False

    End Function

    Private Sub LoadingUser()

        Using cmd As New SqlClient.SqlCommand("SELECT * FROM usuarios, alumnos WHERE usuarios.usuario = alumnos.idalumno AND usuario = @usr", conexion)
            cmd.Parameters.AddWithValue("@usr", TxtUsuario.Text.Trim())
            If conexion.State <> ConnectionState.Open Then conexion.Open()

            Using datareader As SqlClient.SqlDataReader = cmd.ExecuteReader()
                If datareader.Read() Then
                    usuario = datareader(0).ToString()
                    contrasena = datareader(1).ToString()
                    nombre = datareader(7).ToString()
                    apellidop = datareader(8).ToString()
                    apellidom = datareader(9).ToString()
                    imagen = datareader(3).ToString()
                End If
            End Using
            conexion.Close()
        End Using

        Me.Hide()

    End Sub

    Private Sub RestablecerFormulario()
        If CbbxOpcion.Items.Count > 0 Then
            CbbxOpcion.SelectedIndex = 0
        End If
        TxtUsuario.Text = Nothing
        TxtContrasena.Text = Nothing
        Cursor = Cursors.Default
    End Sub

    Private Sub FrmIniciarSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrearConexion()
        My.Settings.Item("bdsisescolarConnectionString") = cadenaconexion
        My.Settings.Save()
        conexion.ConnectionString = cadenaconexion
        If CbbxOpcion.Items.Count > 0 AndAlso CbbxOpcion.SelectedIndex = -1 Then
            CbbxOpcion.SelectedIndex = 0
        End If
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
        If CbbxOpcion.SelectedIndex < 0 OrElse CbbxOpcion.Text.StartsWith("Seleccion", StringComparison.OrdinalIgnoreCase) Then
            MsgBox("DEBE SELECCIONAR EL TIPO DE CUENTA", MessageBoxIcon.Error)
            CbbxOpcion.Focus()
        ElseIf TxtUsuario.Text.Trim() = "" Then
            MsgBox("USUARIO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtUsuario.Focus()
        ElseIf TxtContrasena.Text = "" Then
            MsgBox("CONTRASEÃ‘A: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtContrasena.Focus()
        ElseIf Usuarios() = True Then
            FrmSistemadeGestionEscolar.Show()
            RestablecerFormulario()
        Else
            MsgBox("USUARIO O CONTRASEÃ‘A INCORRECTOS", MessageBoxIcon.Error)
            RestablecerFormulario()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
End Class