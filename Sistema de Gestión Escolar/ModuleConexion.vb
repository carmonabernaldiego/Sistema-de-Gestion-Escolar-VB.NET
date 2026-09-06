Module ModuleConexion
    Public cadenaconexion As String
    Public cadenaimagen As String

    Public Sub CrearConexion()
        cadenaconexion = "Server=(localdb)\MSSQLLocalDB;Database=bdsisescolar;Integrated Security=True;"
        cadenaimagen = "\..\..\imagenes\usuarios\"
    End Sub
End Module
