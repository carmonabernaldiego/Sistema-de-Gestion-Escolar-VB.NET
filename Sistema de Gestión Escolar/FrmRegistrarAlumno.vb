Imports System.Data.SqlClient

Public Class FrmRegistrarAlumno
    Private conexion As New SqlConnection

    Dim dataset As New DataSet
    Dim dataadapter As SqlDataAdapter
    Dim table As DataTableCollection = DataSet.Tables
    Dim command As SqlCommand
    Dim cadena As String

    Dim carreraseleccionada As String
    Dim documentos As Integer
    Dim repetidor As Integer
    Dim idalumnoe As String

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

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

        TxtIdAlumno.Enabled = True
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
        TabControlDatos.Enabled = True

        TxtIdAlumno.Focus()
    End Sub

    Sub DesabilitarControles()
        TabControlDatos.Enabled = False
        TxtIdAlumno.Enabled = False
    End Sub

    Sub LimpiarControles()
        TxtIdAlumno.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellidoP.Text = Nothing
        TxtApellidoM.Text = Nothing
        TxtCURP.Text = Nothing
        TxtRFC.Text = Nothing
        TxtTelefono.Text = Nothing
        TxtDireccion.Text = Nothing
        CbbxMunicipio.Text = "Seleccioné"

        TxtNombreTutor.Text = Nothing
        TxtApellidoTutorP.Text = Nothing
        TxtApellidoTutorM.Text = Nothing
        TxtTelefonoTutor.Text = Nothing
        CbbxCarrera.Text = "Seleccioné"
        CheckBoxRepetidor.Checked = False
        CheckBoxDocumentos.Checked = False
        RichTextBoxObservaciones.Text = Nothing

        DateTimePickerFechaIngreso.Value = Today

        Me.TabControlDatos.SelectTab(0)
    End Sub

    Sub CargarDatos()
        Try
            conexion.Open()

            dataset = New DataSet
            Dim table As DataTableCollection = dataset.Tables

            cadena = "SELECT * FROM alumnos"

            table = dataset.Tables

            dataadapter = New SqlDataAdapter(cadena, conexion)

            dataadapter.Fill(dataset, "alumnos")

            DataGridViewAlumnos.DataSource = New DataView(table(0))
            DataGridViewAlumnos.Refresh()

            dataset.Dispose()
            dataadapter.Dispose()

            conexion.Close()
        Catch ex As Exception
            MsgBox("ERROR EN LA CONEXIÓN", MsgBoxStyle.Critical)
            conexion.Close()
        End Try
    End Sub

    Sub Datas()
        With dataset.Tables("alumnos")

            .DefaultView.Sort = "idalumno"

            DataGridViewAlumnos.DataSource = .DefaultView
        End With
    End Sub

    Public Function CompruebaAlumnoExiste()

        Try
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("SELECT * FROM alumnos", conexion)

            ds.Tables.Add(dt)
            da.Fill(dt)

            conexion.Open()

            For Each datarow In dt.Rows
                If idalumnoe = datarow.item(0) Then
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

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub LblHeader_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblHeader.MouseDown
        ex = e.X
        ey = e.Y

        Arrastre = True
    End Sub

    Private Sub LblHeader_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblHeader.MouseUp
        Arrastre = False
    End Sub

    Private Sub LblHeader_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblHeader.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))
    End Sub
    Private Sub CheckBoxRepetidor_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRepetidor.CheckedChanged
        If CheckBoxRepetidor.Checked = True Then
            repetidor = 1
        ElseIf CheckBoxRepetidor.Checked = False Then
            repetidor = 0
        End If
    End Sub

    Private Sub CheckBoxDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDocumentos.CheckedChanged
        If CheckBoxDocumentos.Checked = True Then
            documentos = 1
        ElseIf CheckBoxDocumentos.Checked = False Then
            documentos = 0
        End If
    End Sub

    Private Sub FrmRegistrarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TxtBuscar.Focus()
            conexion.ConnectionString = cadenaconexion

            DesabilitarControles()
            Inicio()
            CargarDatos()

            With DataGridViewAlumnos
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Try
            If TxtBuscar.Text = "" Then Exit Sub
            If DataGridViewAlumnos.Rows.Count < 1 Then Exit Sub

            With dataset.Tables("alumnos")

                .DefaultView.Sort = "idalumno"

                If DataGridViewAlumnos.Rows.Count > 0 Then
                End If

            End With

            Dim fila As Integer = dataset.Tables("alumnos").DefaultView.Find(TxtBuscar.Text)

            If fila <> -1 Then

                With DataGridViewAlumnos
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
        If TxtIdAlumno.Text = "" Then
            MsgBox("ID ALUMNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtIdAlumno.Focus()
        ElseIf TxtNombre.Text = "" Then
            MsgBox("NOMBRE: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtNombre.Focus()
        ElseIf TxtApellidoP.Text = "" Then
            MsgBox("APELLIDO PATERNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtApellidoP.Focus()
        ElseIf TxtApellidoM.Text = "" Then
            MsgBox("APELLIDO MATERNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtApellidoM.Focus()
        ElseIf TxtCURP.Text = "" Then
            MsgBox("CURP: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtCURP.Focus()
        ElseIf TxtRFC.Text = "" Then
            MsgBox("RFC: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtRFC.Focus()
        ElseIf TxtTelefono.Text = "" Then
            MsgBox("TELEFONO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtTelefono.Focus()
        ElseIf TxtDireccion.Text = "" Then
            MsgBox("DIRECCIÓN: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtDireccion.Focus()
        ElseIf CbbxMunicipio.Text = "Seleccioné" Then
            MsgBox("DEBE SELECCIONAR UN MUNICIPIO", MessageBoxIcon.Error)
            CbbxMunicipio.Focus()
        ElseIf TxtNombreTutor.Text = "" Then
            MsgBox("NOMBRE TUTOR: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtNombreTutor.Focus()
        ElseIf TxtApellidoTutorP.Text = "" Then
            MsgBox("APELLIDO PATERNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtApellidoTutorP.Focus()
        ElseIf TxtApellidoTutorM.Text = "" Then
            MsgBox("APELLIDO MATERNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtApellidoTutorM.Focus()
        ElseIf TxtTelefonoTutor.Text = "" Then
            MsgBox("TELEFONO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtTelefonoTutor.Focus()
        ElseIf CbbxCarrera.Text = "Seleccioné" Then
            MsgBox("DEBE SELECCIONAR UNA CARRERA", MessageBoxIcon.Error)
            CbbxCarrera.Focus()
        Else
            If CbbxCarrera.Text = "Automotriz" Then
                carreraseleccionada = "AUTOM"
            ElseIf CbbxCarrera.Text = "Autotronica" Then
                carreraseleccionada = "AUTO"
            ElseIf CbbxCarrera.Text = "Construcción" Then
                carreraseleccionada = "CONS"
            ElseIf CbbxCarrera.Text = "Hospitalidad Turistica" Then
                carreraseleccionada = "HOSP"
            ElseIf CbbxCarrera.Text = "Informatica" Then
                carreraseleccionada = "INFO"
            ElseIf CbbxCarrera.Text = "Tronco Común" Then
                carreraseleccionada = "TRO"
            End If
            conexion.Open()

            Dim consulta As String
            consulta = "INSERT INTO alumnos (idalumno, idcarrera, repetidor, nombre, apepat, apemat" & _
                ", direccion, municipio, telefono, curp, rfc, documentacion, nombret, apepatt, apematt" & _
                ", telefonot, observaciones, fechaingreso)" & _
                "VALUES ('" & TxtIdAlumno.Text & "', '" & carreraseleccionada & "', " & repetidor & "" & _
                ", '" & TxtNombre.Text & "', '" & TxtApellidoP.Text & "', '" & TxtApellidoM.Text & "'" & _
                ", '" & TxtDireccion.Text & "', '" & CbbxMunicipio.Text & "', " & TxtTelefono.Text & "" & _
                ", '" & TxtCURP.Text & "', '" & TxtRFC.Text & "', " & documentos & "" & _
                ", '" & TxtNombreTutor.Text & "', '" & TxtApellidoTutorP.Text & "', '" & TxtApellidoTutorM.Text & "'" & _
                ", " & TxtTelefonoTutor.Text & ", '" & RichTextBoxObservaciones.Text & "'" & _
                ", '" & DateTimePickerFechaIngreso.Value.Date.ToShortDateString & "')"

            Dim command As SqlCommand = New SqlCommand(consulta, conexion)

            Try
                command.ExecuteNonQuery()
                MsgBox("EL ALUMNO SE AGREGÓ CON ÉXITO", MsgBoxStyle.Information)

                conexion.Close()

                DesabilitarControles()
                LimpiarControles()
                Inicio()
                CargarDatos()
                Datas()
            Catch ex As Exception
                MsgBox("EL ALUMNO YA EXISTE", MsgBoxStyle.Critical)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtIdAlumno.Text = "" Then
            MsgBox("ID ALUMNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtIdAlumno.Focus()
        ElseIf TxtNombre.Text = "" Then
            MsgBox("NOMBRE: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtNombre.Focus()
        ElseIf TxtApellidoP.Text = "" Then
            MsgBox("APELLIDO PATERNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtApellidoP.Focus()
        ElseIf TxtApellidoM.Text = "" Then
            MsgBox("APELLIDO MATERNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtApellidoM.Focus()
        ElseIf TxtCURP.Text = "" Then
            MsgBox("CURP: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtCURP.Focus()
        ElseIf TxtRFC.Text = "" Then
            MsgBox("RFC: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtRFC.Focus()
        ElseIf TxtTelefono.Text = "" Then
            MsgBox("TELEFONO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtTelefono.Focus()
        ElseIf TxtDireccion.Text = "" Then
            MsgBox("DIRECCIÓN: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtDireccion.Focus()
        ElseIf CbbxMunicipio.Text = "Seleccioné" Then
            MsgBox("DEBE SELECCIONAR UN MUNICIPIO", MessageBoxIcon.Error)
            CbbxMunicipio.Focus()
        ElseIf TxtNombreTutor.Text = "" Then
            MsgBox("NOMBRE TUTOR: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtNombreTutor.Focus()
        ElseIf TxtApellidoTutorP.Text = "" Then
            MsgBox("APELLIDO PATERNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtApellidoTutorP.Focus()
        ElseIf TxtApellidoTutorM.Text = "" Then
            MsgBox("APELLIDO MATERNO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtApellidoTutorM.Focus()
        ElseIf TxtTelefonoTutor.Text = "" Then
            MsgBox("TELEFONO: ESTE CAMPO NO PUEDE ESTAR VACIO", MessageBoxIcon.Error)
            TxtTelefonoTutor.Focus()
        ElseIf CbbxCarrera.Text = "Seleccioné" Then
            MsgBox("DEBE SELECCIONAR UNA CARRERA", MessageBoxIcon.Error)
            CbbxCarrera.Focus()
        Else
            If CbbxCarrera.Text = "Automotriz" Then
                carreraseleccionada = "AUTOM"
            ElseIf CbbxCarrera.Text = "Autotronica" Then
                carreraseleccionada = "AUTO"
            ElseIf CbbxCarrera.Text = "Construcción" Then
                carreraseleccionada = "CONS"
            ElseIf CbbxCarrera.Text = "Hospitalidad Turistica" Then
                carreraseleccionada = "HOSP"
            ElseIf CbbxCarrera.Text = "Informatica" Then
                carreraseleccionada = "INFO"
            ElseIf CbbxCarrera.Text = "Tronco Común" Then
                carreraseleccionada = "TRO"
            End If

            Try
                conexion.Open()

                Dim consulta As String
                consulta = "UPDATE alumnos SET idcarrera = '" & carreraseleccionada & "'" & _
                    ", repetidor = " & repetidor & ", nombre = '" & TxtNombre.Text & "', apepat = '" & TxtApellidoP.Text & "'" & _
                    ", apemat = '" & TxtApellidoM.Text & "', direccion = '" & TxtDireccion.Text & "', municipio = '" & CbbxMunicipio.Text & "'" & _
                    ", telefono = " & TxtTelefono.Text & ", curp = '" & TxtCURP.Text & "', rfc = '" & TxtRFC.Text & "'" & _
                    ", documentacion = '" & documentos & "', nombret = '" & TxtNombreTutor.Text & "', apepatt = '" & TxtApellidoTutorP.Text & "'" & _
                    ", apematt = '" & TxtApellidoTutorM.Text & "', telefonot = " & TxtTelefonoTutor.Text & "" & _
                    ", observaciones = '" & RichTextBoxObservaciones.Text & "', fechaingreso = '" & DateTimePickerFechaIngreso.Value.Date.ToShortDateString & "' WHERE idalumno ='" & TxtIdAlumno.Text & "'"

                Dim command As SqlCommand = New SqlCommand(consulta, conexion)


                command.ExecuteNonQuery()
                MsgBox("EL ALUMNO SE ACTUALIZO CON ÉXITO", MsgBoxStyle.Information)

                conexion.Close()

                DesabilitarControles()
                LimpiarControles()
                Inicio()
                CargarDatos()
                Datas()
            Catch ex As Exception
                MsgBox("ERROR AL ACTUALIZAR EL REGISTRO", MsgBoxStyle.Critical)
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Modificar()

        Dim filaseleccionada As DataGridViewRow = DataGridViewAlumnos.CurrentRow

        conexion.Open()

        Dim consulta As String
        consulta = "SELECT * FROM alumnos WHERE idalumno='" & filaseleccionada.Cells("idalumno").Value & "'"

        Dim command As New SqlClient.SqlCommand(consulta, conexion)

        Dim datareader As SqlClient.SqlDataReader
        datareader = command.ExecuteReader

        If datareader.Read Then
            TxtIdAlumno.Text = datareader(0)

            If datareader(1) = "AUTOM" Then
                CbbxCarrera.Text = "Automotriz"
                carreraseleccionada = "AUTOM"
            ElseIf datareader(1) = "AUTO" Then
                CbbxCarrera.Text = "Autotronica"
                carreraseleccionada = "AUTO"
            ElseIf datareader(1) = "CONS" Then
                CbbxCarrera.Text = "Construcción"
                carreraseleccionada = "CONS"
            ElseIf datareader(1) = "HOSP" Then
                CbbxCarrera.Text = "Hospitalidad Turistica"
                carreraseleccionada = "HOSP"
            ElseIf datareader(1) = "INFO" Then
                CbbxCarrera.Text = "Informatica"
                carreraseleccionada = "INFO"
            ElseIf datareader(1) = "TRO" Then
                CbbxCarrera.Text = "Tronco Común"
                carreraseleccionada = "TRO"
            End If

            If datareader(2) = 1 Then
                CheckBoxRepetidor.Checked = True
                repetidor = 1
            Else
                CheckBoxRepetidor.Checked = False
                repetidor = 0
            End If

            TxtNombre.Text = datareader(3)
            TxtApellidoP.Text = datareader(4)
            TxtApellidoM.Text = datareader(5)
            TxtDireccion.Text = datareader(6)
            CbbxMunicipio.Text = datareader(7)
            TxtTelefono.Text = datareader(8)
            TxtCURP.Text = datareader(9)
            TxtRFC.Text = datareader(10)

            If datareader(11) = 1 Then
                CheckBoxDocumentos.Checked = True
                documentos = 1
            Else
                CheckBoxDocumentos.Checked = False
                documentos = 0
            End If

            TxtNombreTutor.Text = datareader(12)
            TxtApellidoTutorP.Text = datareader(13)
            TxtApellidoTutorM.Text = datareader(14)
            TxtTelefonoTutor.Text = datareader(15)
            RichTextBoxObservaciones.Text = datareader(16)

            DateTimePickerFechaIngreso.Value = datareader(17)
        End If
        conexion.Close()

        Datas()
        HabilitarControles()
        TxtIdAlumno.Enabled = False
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Agregar()
        HabilitarControles()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        idalumnoe = InputBox("INGRESA EL ID DE USUARIO A ELIMINAR")

        If idalumnoe <> "" Then
            If MsgBox("¿ESTÁ SEGURO DE ELIMINAR EL REGISTRO?", vbYesNo, "") = vbYes Then
                If CompruebaAlumnoExiste() = True Then
                    conexion.Open()

                    Dim consulta As String
                    consulta = "DELETE FROM alumnos WHERE idalumno='" & idalumnoe & "'"

                    Dim command As SqlCommand = New SqlCommand(consulta, conexion)

                    Try
                        command.ExecuteNonQuery()
                        MsgBox("EL ALUMNO SE ELIMINO CON ÉXITO", MsgBoxStyle.Information)

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
                    MsgBox("EL ALUMNO NO EXISTE", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Inicio()
        LimpiarControles()
        DesabilitarControles()
        TxtBuscar.Focus()
    End Sub
End Class