Imports SisDatos
Imports SisReglas
Imports System.Data

Public Class FrmBien
    Private cFuncBD As New C_Conexion
    Private cBien As New C_Bien
    Private xTipCta As String
    Private xTipoBien As String
    Private oDtBien As DataTable

    Private Sub TxtBusca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBusca.TextChanged
        Dim strSql As String
        strSql = "SELECT * FROM T_TIPOBIEN WHERE DESCRIPCION LIKE '" & Me.TxtBusca.Text & "%'"
        cFuncBD.cargar_lista(Me.LstBien, strSql, "COD_TIPO_BIEN", "DESCRIPCION")

    End Sub

    Private Sub CmbTipoCta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoCta.SelectedIndexChanged
        If Me.CmbTipoCta.Text = "DE USO PRIVADO" Then
            xTipCta = "P"
        Else
            xTipCta = "E"
        End If
    End Sub

    Private Sub RbActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbActivo.CheckedChanged
        If Me.RbActivo.Checked = True Then
            xTipoBien = "A"
        Else
            xTipoBien = "O"
        End If
        Dim StrSql As String
        StrSql = "Select cod_cta,nom_cta From T_CUENTA where TIPO_USO_CTA='" + xTipCta + "' AND TIPO_CTA ='" + xTipoBien + "' "
        cFuncBD.cargar_combo(Me.CmbCtaCtble, StrSql, "COD_CTA", "NOM_CTA")
        Me.CmbCtaCtble.Enabled = True
    End Sub

    Private Sub LstBien_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstBien.SelectedIndexChanged
        Me.LblCodPat.Text = Me.LstBien.SelectedValue.ToString
        Me.LblDenominacion.Text = Me.LstBien.Text
    End Sub
   
    Private Sub LblCodPat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblCodPat.TextChanged
        Me.cBien.getGrupoBien(Me.LstBien, Me.LblGrupoGen)
        Me.cBien.getClaseBien(Me.LstBien, Me.LblClase)

        Me.cBien.GeneraCodSBN(Me.LblCodPat, Me.LblCorrelat)

    End Sub

    Private Sub FrmBien_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        LlenaCboLocal()
    End Sub

    Sub LlenaCboLocal()
        Dim StrSql As String
        StrSql = "Select cod_local,nom_local From T_LOCAL"
        cFuncBD.cargar_combo(Me.CmbLocal, StrSql, "COD_LOCAL", "NOM_LOCAL")
    End Sub

    Sub LlenaCboArea()
        Try
            Dim xCodLocal = Me.CmbLocal.SelectedValue.ToString
            Dim StrSql As String
            StrSql = "Select cod_area,nom_area From T_AREA where cod_local='" + xCodLocal + "'"
            cFuncBD.cargar_combo(Me.CmbArea, StrSql, "COD_AREA", "NOM_AREA")
        Catch ex As Exception

        End Try
    End Sub

    Sub LlenaCboOficina()
        Try
            Dim xCodArea = Me.CmbArea.SelectedValue.ToString
            Dim StrSql As String
            StrSql = "Select cod_oficina,nom_oficina From T_OFICINA where cod_area='" + xCodArea + "'"
            cFuncBD.cargar_combo(Me.CmbOficina, StrSql, "COD_OFICINA", "NOM_OFICINA")
        Catch ex As Exception

        End Try
    End Sub

    Sub LlenaCboFuncionario()
        Try
            Dim xCodOfi = Me.CmbOficina.SelectedValue.ToString
            Dim StrSql As String
            StrSql = "Select cod_emp,nom_emp From T_FUNCIONARIO where cod_oficina='" + xCodOfi + "'"
            cFuncBD.cargar_combo(Me.CmbUsuario, StrSql, "COD_EMP", "NOM_EMP")

        Catch ex As Exception
            'MsgBox("No hay datos en la Lista", MsgBoxStyle.Exclamation, "SAF-2010")

        End Try
    End Sub

    Private Sub CmbLocal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLocal.LostFocus
        LlenaCboArea()
    End Sub

    Private Sub CmbArea_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbArea.LostFocus
        LlenaCboOficina()
    End Sub

    Private Sub CmbOficina_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbOficina.LostFocus
        LlenaCboFuncionario()
    End Sub

    Private Sub CmdGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGrabar.Click
        Dim x As Integer
        x = Val(Me.LblCorrelat.Text) + 1
      
        Me.cBien.CodBienSBN = Me.LblCodPat.Text & Format(x, "0000")

        Me.cBien.CodBienInterno = Me.TxtCodInterno.Text
        Me.cBien.CodEmpleado = Me.CmbUsuario.SelectedValue.ToString
        Me.cBien.CodCta = Me.CmbCtaCtble.SelectedValue.ToString
        Me.cBien.CodTipoBien = Me.LblCodPat.Text
        Me.cBien.ResolAlta = Me.TxtResAlta.Text
        Me.cBien.ValorLibro = Me.TxtValorLib.Text
        Me.cBien.Estado = Microsoft.VisualBasic.Left(Me.CmbEstadoBien.Text, 1)
        Me.cBien.Marca = Me.TxtMarca.Text
        Me.cBien.Modelo = Me.TxtModelo.Text
        Me.cBien.Color = Me.TxtColor.Text
        Me.cBien.Serie = Me.TxtSerie.Text
        Me.cBien.NumMotor = Me.TxtNMotor.Text
        Me.cBien.NumChasis = Me.TxtNChasis.Text
        Me.cBien.AnioFab = Me.TxtAnioFab.Text
        Me.cBien.Placa = Me.TxtPlaca.Text
        Me.cBien.Dimension = Me.TxtDimension.Text
        Me.cBien.Otros = Me.TxtOtros.Text
        Me.cBien.FechaAdquisicion = Me.DtpFecha.Text
        Me.cBien.Condicion = Microsoft.VisualBasic.Left(Me.CmbFormaAdq.Text, 1)
        If Me.ChkAsegurado.Checked = True Then
            Me.cBien.Seguro = "S"
        Else
            Me.cBien.Seguro = "N"
        End If
        Me.cBien.EstadoActual = "A"
        Me.cBien.AltaBien()
        If Me.RbtxUni.Checked = True Then
            'Limpiar controles
            Me.TxtBusca.Text = ""
        Else
            Me.cBien.GeneraCodSBN(Me.LblCodPat, Me.LblCorrelat)
        End If
    End Sub

    Private Sub FrmBien_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'DBINVENTARIODataSet.T_CUENTA' Puede moverla o quitarla según sea necesario.
        'Me.T_CUENTATableAdapter.Fill(Me.DBINVENTARIODataSet.T_CUENTA)
        cBien.CargaDtsBien()
        cBien.FillDtgBien(Dgv1)
    End Sub

   
    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dispose()
    End Sub
End Class