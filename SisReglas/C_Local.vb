Imports System.Data.SqlClient
Imports SisDatos
Imports system.Windows.Forms

Public Class C_Local
    Private _codLocal As String
    Private _nomLocal As String
    Private _dirLocal As String
    Private _codUbigeo As String
    Private _area As Double
    Private _flgPropiedad As String
    Private _ctaCtble As String
    Private _valor As Double
    Private _codEntidad As String

    Private cFuncDB As New C_Conexion
    Private oDatLocal As Data.DataSet


    Public Property CodEntidad() As String
        Get
            Return _codEntidad
        End Get
        Set(ByVal value As String)
            _codEntidad = value
        End Set
    End Property
    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
        End Set
    End Property
    Public Property CtaCtble() As String
        Get
            Return _ctaCtble
        End Get
        Set(ByVal value As String)
            _ctaCtble = value
        End Set
    End Property
    Public Property FlgPropiedad() As String
        Get
            Return _flgPropiedad
        End Get
        Set(ByVal value As String)
            _flgPropiedad = value
        End Set
    End Property
    Public Property Area() As Double
        Get
            Return _area
        End Get
        Set(ByVal value As Double)
            _area = value
        End Set
    End Property
    Public Property CodUbigeo() As String
        Get
            Return _codUbigeo
        End Get
        Set(ByVal value As String)
            _codUbigeo = value
        End Set
    End Property
    Public Property DirLocal() As String
        Get
            Return _dirLocal
        End Get
        Set(ByVal value As String)
            _dirLocal = value
        End Set
    End Property
    Public Property NomLocal() As String
        Get
            Return _nomLocal
        End Get
        Set(ByVal value As String)
            _nomLocal = value
        End Set
    End Property
    Public Property CodLocal() As String
        Get
            Return _codLocal
        End Get
        Set(ByVal value As String)
            _codLocal = value
        End Set
    End Property


    Public Sub AltaLocal()
        'Creando la fila
        Dim oDataRow As DataRow
        oDataRow = Me.oDatLocal.Tables("T_LOCAL").NewRow()
        oDataRow(0) = Me.CodLocal
        oDataRow(1) = Me.NomLocal
        oDataRow(2) = Me.DirLocal
        oDataRow(3) = Me.CodUbigeo
        oDataRow(4) = Me.Area
        oDataRow(5) = Me.FlgPropiedad
        oDataRow(6) = Me.CtaCtble
        oDataRow(7) = Me.Valor
        oDataRow(8) = Me.CodEntidad
        Me.oDatLocal.Tables("T_LOCAL").Rows.Add(oDataRow)
        Me.cFuncDB.GuardarCambios(oDatLocal, "T_LOCAL")
    End Sub
    Sub CargaDtsLocal()
        cFuncDB.DatosIniciales("SELECT * FROM T_LOCAL", Me.oDatLocal, "T_LOCAL")
    End Sub

    Public Sub FillDtgLocal(ByRef DtgView As DataGridView)
        DtgView.DataSource = oDatLocal
        DtgView.DataMember = "T_LOCAL"
    End Sub
End Class
