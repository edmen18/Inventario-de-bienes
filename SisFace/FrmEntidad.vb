Imports System.Data
Imports SisReglas
Imports System.Windows.Forms


Public Class FrmEntidad
    Private cEnt As New C_Entidad

    Private Sub FrmEntidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cEnt.CargaDtsEntidad()
        cEnt.FillDtgEntidad(Me.DataGridView1)
    End Sub

   

    Private Sub BtnGuaradr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuaradr.Click
        cEnt.CodEntidad = Me.TxtCodEnt.Text
        cEnt.NomEntidad = Me.TxtNomEnt.Text
        cEnt.NomDependencia = Me.TxtDepen.Text
        cEnt.AltaEntidad()
    End Sub
End Class