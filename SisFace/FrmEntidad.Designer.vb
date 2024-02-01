<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnGuaradr = New System.Windows.Forms.Button
        Me.TxtCodEnt = New System.Windows.Forms.TextBox
        Me.TxtNomEnt = New System.Windows.Forms.TextBox
        Me.TxtDepen = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGuaradr
        '
        Me.BtnGuaradr.Location = New System.Drawing.Point(348, 98)
        Me.BtnGuaradr.Name = "BtnGuaradr"
        Me.BtnGuaradr.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuaradr.TabIndex = 1
        Me.BtnGuaradr.Text = "Guardar"
        Me.BtnGuaradr.UseVisualStyleBackColor = True
        '
        'TxtCodEnt
        '
        Me.TxtCodEnt.Location = New System.Drawing.Point(283, 20)
        Me.TxtCodEnt.Name = "TxtCodEnt"
        Me.TxtCodEnt.Size = New System.Drawing.Size(140, 20)
        Me.TxtCodEnt.TabIndex = 2
        '
        'TxtNomEnt
        '
        Me.TxtNomEnt.Location = New System.Drawing.Point(170, 44)
        Me.TxtNomEnt.Name = "TxtNomEnt"
        Me.TxtNomEnt.Size = New System.Drawing.Size(253, 20)
        Me.TxtNomEnt.TabIndex = 3
        '
        'TxtDepen
        '
        Me.TxtDepen.Location = New System.Drawing.Point(170, 67)
        Me.TxtDepen.Name = "TxtDepen"
        Me.TxtDepen.Size = New System.Drawing.Size(253, 20)
        Me.TxtDepen.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(411, 106)
        Me.DataGridView1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo Entidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre de Entidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Dependencia que pertenece"
        '
        'FrmEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 248)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxtDepen)
        Me.Controls.Add(Me.TxtNomEnt)
        Me.Controls.Add(Me.TxtCodEnt)
        Me.Controls.Add(Me.BtnGuaradr)
        Me.Name = "FrmEntidad"
        Me.Text = "Registro de Entidad"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuaradr As System.Windows.Forms.Button
    Friend WithEvents TxtCodEnt As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomEnt As System.Windows.Forms.TextBox
    Friend WithEvents TxtDepen As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
