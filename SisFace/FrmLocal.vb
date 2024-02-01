Imports SisReglas
Imports SisDatos
Public Class FrmLocal
    Dim cLocal As New C_Local
    Dim cFuncBD As New C_Conexion
    Private xTipCta As String

    Private Sub FrmLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cLocal.CargaDtsLocal()
        cLocal.FillDtgLocal(Me.DataGridView1)
    End Sub

    Private Sub CmbFlgProp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFlgProp.SelectedIndexChanged
        If Me.CmbFlgProp.Text = "ESTATAL" Then
            xTipCta = "E"
        Else
            xTipCta = "P"
        End If
        Dim StrSql As String
        StrSql = "SELECT * FROM T_CUENTA WHERE (( COD_CTA = '33.1' OR COD_CTA = '33.2') OR (COD_CTA LIKE '331.%' OR COD_CTA LIKE '333.%')) AND FLG_CTA = '1' AND( TIPO_USO_CTA ='" & xTipCta & "')"
        cFuncBD.cargar_combo(Me.CmbCta, StrSql, "COD_CTA", "NOM_CTA")
        Me.CmbCta.Enabled = True


    End Sub
End Class