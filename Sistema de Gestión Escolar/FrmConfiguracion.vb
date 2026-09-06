Imports System.Data.SqlClient

Public Class FrmConfiguracion
    Private conexion As New SqlClient.SqlConnection

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub CargarDatosUsuario()
        Try
            PictureBoxUsuario.Image = CargarImagen(My.Application.Info.DirectoryPath & cadenaimagen & imagen)
            LblNombreApellidos.Text = nombre & " " & apellidop & " " & apellidom
            LblUsuario.Text = usuario
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CambiarImagen(nombreimagen As String)
        Try
            Dim consulta As String
            consulta = "UPDATE usuarios SET imagen='" & nombreimagen & "' WHERE usuario='" & usuario & "'"

            conexion.Open()

            Dim comand As New SqlClient.SqlCommand(consulta, conexion)
            comand.ExecuteNonQuery()

            imagen = nombreimagen
            FrmSistemadeGestionEscolar.UsuarioToolStripMenuItem.Image = CargarImagen(My.Application.Info.DirectoryPath & cadenaimagen & nombreimagen)

            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub FrmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = cadenaconexion
            CargarDatosUsuario()
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
        Arrastre = False
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PictureBoxHerramientas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxHerramientas.DoubleClick
        Close()
    End Sub

    Private Sub BtnCambiarContrasena_Click(sender As Object, e As EventArgs) Handles BtnCambiarContrasena.Click
        FrmCambiarContrasena.Show()
    End Sub

    Private Sub BtnExaminar_Click(sender As Object, e As EventArgs) Handles BtnExaminar.Click
        OpenFileDialogImagen.Title = "Seleccionar Imagen de Cuenta"
        OpenFileDialogImagen.InitialDirectory = My.Application.Info.DirectoryPath & cadenaimagen
        OpenFileDialogImagen.Multiselect = False
        OpenFileDialogImagen.DefaultExt = ".jpg"
        OpenFileDialogImagen.Filter = "Archivos de Imagenes (.jpg)|*.jpg"

        If OpenFileDialogImagen.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBoxUsuario.Image = Image.FromFile(OpenFileDialogImagen.FileName)

            CambiarImagen(OpenFileDialogImagen.SafeFileName)
        End If
    End Sub
End Class