Public Class FrmSistemadeGestionEscolar

    Private Sub CargarDatosUsuario()
        Try
            UsuarioToolStripMenuItem.Text = nombre & " " & apellidop & " " & apellidom
            UsuarioToolStripMenuItem.Image = CargarImagen(My.Application.Info.DirectoryPath & cadenaimagen & imagen)

        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub cerrarformulariosactivos()
        FrmAcercaDe.Close()
        FrmCambiarContrasena.Close()
        FrmConfiguracion.Close()
        FrmMensajes.Close()
        FrmRegistrarAlumno.Close()
        FrmUsuarios.Close()
        FrmReporteUsuarios.Close()
    End Sub

    Private Sub FrmSistemadeGestionEscolar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        FrmIniciarSesion.Show()
    End Sub

    Private Sub FrmSistemadeGestionEscolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHora.Text = TimeOfDay
        CargarDatosUsuario()
    End Sub

    Private Sub TimerHora_Tick(sender As Object, e As EventArgs) Handles TimerHora.Tick
        LblHora.Text = TimeOfDay
    End Sub

    Private Sub PictureBoxHerramientas_DoubleClick(sender As Object, e As EventArgs) Handles PictureBoxHerramientas.DoubleClick
        End
    End Sub

    Private Sub LblMinimizar_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LblCerrar_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        End
    End Sub

    Private Sub RegistrarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AcercaDeSistemaDeGestiónEscolarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeSistemaDeGestiónEscolarToolStripMenuItem.Click
        FrmAcercaDe.MdiParent = Me
        FrmAcercaDe.Show()
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem1.Click
        FrmConfiguracion.MdiParent = Me
        FrmConfiguracion.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        FrmMensajes.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónDeUsuariosToolStripMenuItem.Click
        FrmUsuarios.MdiParent = Me
        FrmUsuarios.Show()
    End Sub

    Private Sub AdministraciónDeAlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónDeAlumnosToolStripMenuItem.Click
        FrmRegistrarAlumno.MdiParent = Me
        FrmRegistrarAlumno.Show()
    End Sub

    Private Sub CerrarFormulariosActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarFormulariosActivosToolStripMenuItem.Click
        cerrarformulariosactivos()
    End Sub

    Private Sub ReporteDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeUsuariosToolStripMenuItem.Click
        FrmReporteUsuarios.MdiParent = Me
        FrmReporteUsuarios.Show()
    End Sub
End Class