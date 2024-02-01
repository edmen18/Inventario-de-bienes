Imports SisDatos
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class C_Bien
    Private _codBienSBN As String
    Private _codBienInterno As String
    Private _codEmpleado As String
    Private _codCta As String
    Private _codTipoBien As String
    Private _resolAlta As String
    Private _valorLibro As Double
    Private _valorTasa As Double
    Private _estado As String
    Private _marca As String
    Private _modelo As String
    Private _color As String
    Private _serie As String
    Private _numMotor As String
    Private _numChasis As String
    Private _anioFab As String
    Private _placa As String
    Private _dimension As String
    Private _otros As String
    Private _fechaAdquisicion As Date
    Private _condicion As String
    Private _seguro As String
    Private _estadoActual As String

    Private oDatBien As Data.DataSet
    Private cFuncBD As New C_Conexion


    Public Property EstadoActual() As String
        Get
            Return _estadoActual
        End Get
        Set(ByVal value As String)
            _estadoActual = value
        End Set
    End Property

    Public Property Seguro() As String
        Get
            Return _seguro
        End Get
        Set(ByVal value As String)
            _seguro = value
        End Set
    End Property

    Public Property Condicion() As String
        Get
            Return _condicion
        End Get
        Set(ByVal value As String)
            _condicion = value
        End Set
    End Property

    Public Property FechaAdquisicion() As Date
        Get
            Return _fechaAdquisicion
        End Get
        Set(ByVal value As Date)
            _fechaAdquisicion = value
        End Set
    End Property

    Public Property Otros() As String
        Get
            Return _otros
        End Get
        Set(ByVal value As String)
            _otros = value
        End Set
    End Property

    Public Property Dimension() As String
        Get
            Return _dimension
        End Get
        Set(ByVal value As String)
            _dimension = value
        End Set
    End Property

    Public Property Placa() As String
        Get
            Return _placa
        End Get
        Set(ByVal value As String)
            _placa = value
        End Set
    End Property

    Public Property AnioFab() As String
        Get
            Return _anioFab
        End Get
        Set(ByVal value As String)
            _anioFab = value
        End Set
    End Property

    Public Property NumChasis() As String
        Get
            Return _numChasis
        End Get
        Set(ByVal value As String)
            _numChasis = value
        End Set
    End Property

    Public Property NumMotor() As String
        Get
            Return _numMotor
        End Get
        Set(ByVal value As String)
            _numMotor = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property

    Public Property Color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Public Property valorTasa() As Double
        Get
            Return _valorTasa
        End Get
        Set(ByVal value As Double)
            _valorTasa = value
        End Set
    End Property

    Public Property ValorLibro() As Double
        Get
            Return _valorLibro
        End Get
        Set(ByVal value As Double)
            _valorLibro = value
        End Set
    End Property

    Public Property ResolAlta() As String
        Get
            Return _resolAlta
        End Get
        Set(ByVal value As String)
            _resolAlta = value
        End Set
    End Property

    Public Property CodTipoBien() As String
        Get
            Return _codTipoBien
        End Get
        Set(ByVal value As String)
            _codTipoBien = value
        End Set
    End Property

    Public Property CodCta() As String
        Get
            Return _codCta
        End Get
        Set(ByVal value As String)
            _codCta = value
        End Set
    End Property

    Public Property CodEmpleado() As String
        Get
            Return _codEmpleado
        End Get
        Set(ByVal value As String)
            _codEmpleado = value
        End Set
    End Property

    Public Property CodBienInterno() As String
        Get
            Return _codBienInterno
        End Get
        Set(ByVal value As String)
            _codBienInterno = value
        End Set
    End Property

    Public Property CodBienSBN() As String
        Get
            Return _codBienSBN
        End Get
        Set(ByVal value As String)
            _codBienSBN = value
        End Set
    End Property

    Public Sub AltaBien()
        'Creando la fila
        Dim oDataRow As DataRow
        oDataRow = Me.oDatBien.Tables("T_BIEN").NewRow()
        oDataRow(0) = Me.CodBienSBN
        oDataRow(1) = Me.CodBienInterno
        oDataRow(2) = Me.CodEmpleado
        oDataRow(3) = Me.CodCta
        oDataRow(4) = Me.CodTipoBien
        oDataRow(5) = Me.ResolAlta
        oDataRow(6) = Me.ValorLibro
        oDataRow(7) = Me.valorTasa
        oDataRow(8) = Me.Estado
        oDataRow(9) = Me.Marca
        oDataRow(10) = Me.Modelo
        oDataRow(11) = Me.Color
        oDataRow(12) = Me.Serie
        oDataRow(13) = Me.NumMotor
        oDataRow(14) = Me.NumChasis
        oDataRow(15) = Me.AnioFab
        oDataRow(16) = Me.Placa
        oDataRow(17) = Me.Dimension
        oDataRow(18) = Me.Otros
        oDataRow(19) = Me.FechaAdquisicion
        oDataRow(20) = Me.Condicion
        oDataRow(21) = Me.Seguro
        oDataRow(22) = Me.EstadoActual

        Me.oDatBien.Tables("T_BIEN").Rows.Add(oDataRow)
        Me.cFuncBD.GuardarCambios(oDatBien, "T_BIEN")
    End Sub

    Sub getGrupoBien(ByRef oLista As ListBox, ByRef oLabel As Label)
        Dim var As String
        var = Microsoft.VisualBasic.Left(oLista.SelectedValue.ToString, 2)
        Dim strsql As String
        strsql = "SELECT * FROM T_GRUPO WHERE COD_GRUPO = '" & var & "'"
        cFuncBD.Buscar_un_dato(oLabel, strsql, "NOM_GRUPO")
    End Sub

    Sub getClaseBien(ByRef oLista As ListBox, ByRef oLabel As Label)
        Dim var As String
        var = Microsoft.VisualBasic.Left(oLista.SelectedValue.ToString, 4)
        var = Microsoft.VisualBasic.Right(var, 2)
        'MsgBox(var)
        Dim strsql As String
        strsql = "SELECT * FROM T_CLASE WHERE COD_CLASE = '" & var & "'"
        cFuncBD.Buscar_un_dato(oLabel, strsql, "NOM_CLASE")
    End Sub

    Sub GeneraCodSBN(ByRef oLabel As Label, ByRef oLabelD As Label)
        Dim strsql As String
        strsql = " SELECT  COUNT(COD_BIEN) AS CCOD FROM T_BIEN WHERE (COD_TIPO_BIEN) ='" + oLabel.Text + "'"
        cFuncBD.Buscar_un_dato(oLabelD, strsql, "CCOD")
        'oLabelD.Text = CStr(Format(oLabelD.Text, "0000"))

    End Sub

    Sub CargaDtsBien()
        cFuncBD.DatosIniciales("SELECT * FROM T_BIEN", Me.oDatBien, "T_BIEN")
    End Sub

    Public Sub FillDtgBien(ByRef DtgView As DataGridView)
        DtgView.DataSource = oDatBien
        DtgView.DataMember = "T_BIEN"
    End Sub

End Class
