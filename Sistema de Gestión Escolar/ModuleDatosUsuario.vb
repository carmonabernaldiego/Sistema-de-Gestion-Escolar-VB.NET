Module ModuleDatosUsuario

    Public Function CargarImagen(ByVal nombreimagen As String) As Bitmap
        Return New Bitmap(nombreimagen)
    End Function

    Public Sub DestruirSesion()
        usuario = Nothing
        contrasena = Nothing
        nombre = Nothing
        apellidop = Nothing
        apellidom = Nothing
        imagen = Nothing
    End Sub

    Public usuario As String
    Public contrasena As String
    Public nombre As String
    Public apellidop As String
    Public apellidom As String
    Public imagen As String
End Module
