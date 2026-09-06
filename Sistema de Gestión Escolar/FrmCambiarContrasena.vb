Imports System.Data.SqlClient

Public Class FrmCambiarContrasena
    Private conexion As New SqlClient.SqlConnection

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub LimpiarContrasenasIncorrectas()
        TxtContrasenaNueva.Text = Nothing
        TxtContrasenaRepetir.Text = Nothing
        TxtContrasenaNueva.Focus()
    End Sub

    Private Sub CambiarContrasena()
        Try
            Dim consulta As String
            consulta = "UPDATE usuarios SET contrasena='" & TxtContrasenaNueva.Text & "' WHERE usuario='" & usuario & "'"

            conexion.Open()

            Dim comand As New SqlClient.SqlCommand(consulta, conexion)
            comand.ExecuteNonQuery()

            contrasena = TxtContrasenaNueva.Text

            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FrmCambiarContrasena_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = cadenaconexion
            TxtContrasena.Focus()
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
        End Try
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
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxHerramientas_DoubleClick(sender As Object, e As EventArgs) Handles PictureBoxHerramientas.DoubleClick
        Close()
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If TxtContrasena.Text = "" Then
            MsgBox("CONTRASEÑA ANTERIOR: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
        ElseIf TxtContrasenaNueva.Text = "" Then
            MsgBox("CONTRASEÑA NUEVA: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
        ElseIf TxtContrasenaRepetir.Text = "" Then
            MsgBox("REPETIR CONTRASEÑA: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
        ElseIf TxtContrasenaNueva.Text <> TxtContrasenaRepetir.Text Then
            MsgBox("LAS CONTRASEÑAS NO COINCIDEN", MessageBoxIcon.Error)
            LimpiarContrasenasIncorrectas()
        ElseIf TxtContrasenaNueva.Text = contrasena Then
            MsgBox("LA CONTRASEÑA NO PUEDE SER IGUAL QUE LA ANTEIOR", MessageBoxIcon.Error)
            LimpiarContrasenasIncorrectas()
        ElseIf TxtContrasena.Text = contrasena Then
            CambiarContrasena()
            Close()
        Else
            MsgBox("CONTRASEÑA INCORRECTA", MessageBoxIcon.Error)
            TxtContrasena.Text = Nothing
            TxtContrasena.Focus()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub
End Class