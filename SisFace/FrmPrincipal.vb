Public Class FrmPrincipal

    
    Private Sub BHPrincipal_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles BHPrincipal.ToolClick
        Select Case e.Tool.Key
            Case "Registro de Bienes"    ' ButtonTool
                ' Place code here
                'Dim fBien As New FrmBien
                FrmBien.MdiParent = Me
                FrmBien.Show()
            Case "Salir del Sitema"
                Dispose()
                End


        End Select

    End Sub
End Class