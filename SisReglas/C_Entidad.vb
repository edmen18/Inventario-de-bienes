Imports System.Data.SqlClient
Imports SisDatos
Imports system.Windows.Forms

Public Class C_Entidad
    Private _codEntidad As String
    Private _nomEntidad As String
    Private _nomDependencia As String

    Dim cFuncDB As New C_Conexion
    Private oDatEnt As Data.DataSet

    Public Property NomDependencia() As String
        Get
            Return _nomDependencia
        End Get
        Set(ByVal value As String)
            _nomDependencia = value
        End Set
    End Property
    Public Property NomEntidad() As String
        Get
            Return _nomEntidad
        End Get
        Set(ByVal value As String)
            _nomEntidad = value
        End Set
    End Property
    Public Property CodEntidad() As String
        Get
            Return _codEntidad
        End Get
        Set(ByVal value As String)
            _codEntidad = value
        End Set
    End Property

    Public Sub AltaEntidad()
        'Creando la fila
        Dim oDataRow As DataRow
        oDataRow = Me.oDatEnt.Tables("T_ENTIDAD").NewRow()
        oDataRow(0) = Me.CodEntidad
        oDataRow(1) = Me.NomEntidad
        oDataRow(2) = Me.NomDependencia
        Me.oDatEnt.Tables("T_ENTIDAD").Rows.Add(oDataRow)
        Me.cFuncDB.GuardarCambios(oDatEnt, "T_ENTIDAD")
    End Sub

    Public Sub FillDtgEntidad(ByRef DtgView As DataGridView)
        DtgView.DataSource = oDatEnt
        DtgView.DataMember = "T_ENTIDAD"
    End Sub

    Sub CargaDtsEntidad()
        cFuncDB.DatosIniciales("SELECT * FROM T_ENTIDAD", Me.oDatEnt, "T_ENTIDAD")
    End Sub

End Class
