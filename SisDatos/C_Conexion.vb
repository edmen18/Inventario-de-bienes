

Imports System.Data 
Imports System.Data.SqlClient
Imports system.Windows.Forms


Public Class C_Conexion
    Private oDataAdapter As Data.SqlClient.SqlDataAdapter

    Dim str_conexion As String = "Data Source=(local)\SQLEXPRESS;Initial Catalog=DBINVENTARIO;Integrated Security=True"

    'La cadena de conexion obviamente la tienen que cambiar por la de ustedes. 

    Dim conexion As New SqlConnection
    Dim cmd As SqlCommand

    Public Sub New()
    End Sub

    Public Property srt_conexion() As String
        Get
            Return Me.str_conexion
        End Get
        Set(ByVal str As String)
            Me.str_conexion = str
        End Set
    End Property

    Public Sub New(ByVal str As String)
        Me.str_conexion = str
    End Sub

    Public Sub consulta_non_query(ByVal consulta As String)

        'Este metodo recibe como parametro la consulta completa y sirve para hacer INSERT, UPDATE Y DELETE 
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()
        Try
            cmd.ExecuteNonQuery()

            MsgBox("La operacion se realizo con exito!", MsgBoxStyle.Information, "Operacion exitosa!")
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        conexion.Close()
    End Sub

    Public Function consulta_reader(ByVal consulta As String) As DataTable
        'Este metodo recibe como parametro la consulta completa y sirve para hacer SELECT 
        Dim dt As New DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()
        Try
            dt.Load(cmd.ExecuteReader())

        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")

        End Try
        conexion.Close()
        Return dt

    End Function

    Public Sub cargar_lista(ByRef lista As ListBox, ByVal consulta As String, ByVal valueMember As String, ByVal displayMember As String)
        Dim dt As New Data.DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()

        Try
            dt.Load(cmd.ExecuteReader())

            lista.DataSource = dt
            lista.ValueMember = valueMember
            lista.DisplayMember = displayMember
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")

        End Try
        conexion.Close()
    End Sub

    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal consulta As String, ByVal valueMember As String, ByVal displayMember As String)
        Dim dt As New DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()

        Try
            dt.Load(cmd.ExecuteReader())
            combo.DataSource = dt
            combo.ValueMember = valueMember
            combo.DisplayMember = displayMember
            'conexion.Close()
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")

        End Try
        conexion.Close()
    End Sub

    Public Sub Buscar_un_dato(ByRef oControl As Object, ByVal consulta As String, ByVal DysplayMember As String)
        Dim dt As New DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()

        Try
            dt.Load(cmd.ExecuteReader())
            If dt.Rows.Count > 0 Then
                Dim oFila As DataRow
                For Each oFila In dt.Rows
                    oControl.Text = oFila.Item(DysplayMember)
                Next
            End If
        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")

        End Try
        conexion.Close()
    End Sub

    Public Function verificar_existencia(ByVal consulta As String) As Boolean
        'Devuelve true si existe, entonces no grabamos, o devuelve false si no existe entoinces debemos grabar. 
        Dim dt As New DataTable
        conexion.ConnectionString = str_conexion
        cmd = New SqlCommand(consulta, conexion)
        conexion.Open()
        Try
            dt.Load(cmd.ExecuteReader())

        Catch ex As Exception
            MsgBox("Error al operar con la base de datos!", MsgBoxStyle.Critical, "Error!")

        End Try

        conexion.Close()

        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub GuardarCambios(ByRef oDataset As Data.DataSet, ByVal Tabla As String)
        'Guaradar los datos contenidos en el Dataset a la Base de Datos de SQL Server
        Try
            oDataAdapter.Update(oDataset.Tables(Tabla))
            oDataset.Tables(Tabla).AcceptChanges()
            conexion.Close()
            MsgBox("Datos Actualizados con exito....")
        Catch ex As Exception
            MsgBox("Error al Grabar en la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        conexion.Close()
    End Sub

    Public Sub DatosIniciales(ByVal StrSql As String, ByRef oDataset As Data.DataSet, ByVal Tabla As String)
        'Datos de carga inicial para el Dataset.
        Try
            'crear Adaptador
            conexion.ConnectionString = str_conexion
            Me.oDataAdapter = New SqlDataAdapter(StrSql, conexion)
            'crear commandBuilder
            Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(oDataAdapter)
            'crear Dataset
            oDataset = New DataSet
            conexion.Open()
            'Llenar con el adaptador del dataset
            Me.oDataAdapter.Fill(oDataset, Tabla)
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al opera con la base de datos!", MsgBoxStyle.Critical, "Error!")
        End Try
        conexion.Close()
    End Sub


End Class
