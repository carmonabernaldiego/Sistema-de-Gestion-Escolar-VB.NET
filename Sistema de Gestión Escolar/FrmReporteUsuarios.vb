Public Class FrmReporteUsuarios

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

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

    Private Sub BtnGeneral_Click(sender As Object, e As EventArgs) Handles BtnGeneral.Click
        Me.usuariosTableAdapter.FillBy(Me.bdsisescolarDataSet.usuarios)
        Me.ReportViewerUsuarios.RefreshReport()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.usuariosTableAdapter.Fill(Me.bdsisescolarDataSet.usuarios, TxtBuscar.Text)
        Me.ReportViewerUsuarios.RefreshReport()
    End Sub
End Class