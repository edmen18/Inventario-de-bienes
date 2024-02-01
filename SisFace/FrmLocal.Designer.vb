<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocal
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Controles = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmbCta = New System.Windows.Forms.ComboBox
        Me.TxtValor = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbFlgProp = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtArea = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtNum = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDirLocal = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtNomLocal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCodLocal = New System.Windows.Forms.TextBox
        Me.Codigo = New System.Windows.Forms.Label
        Me.LblEntidad = New System.Windows.Forms.Label
        Me.CmdNuevo = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.CmdEliminar = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Controles.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 109)
        Me.DataGridView1.TabIndex = 0
        '
        'Controles
        '
        Me.Controles.Controls.Add(Me.CmdEliminar)
        Me.Controles.Controls.Add(Me.Cancelar)
        Me.Controles.Controls.Add(Me.CmdEdit)
        Me.Controles.Controls.Add(Me.CmdNuevo)
        Me.Controles.Location = New System.Drawing.Point(516, 12)
        Me.Controles.Name = "Controles"
        Me.Controles.Size = New System.Drawing.Size(96, 163)
        Me.Controles.TabIndex = 20
        Me.Controles.TabStop = False
        Me.Controles.Text = "Controles"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblEntidad)
        Me.GroupBox2.Controls.Add(Me.CmbCta)
        Me.GroupBox2.Controls.Add(Me.TxtValor)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CmbFlgProp)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtArea)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtNum)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtDirLocal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtNomLocal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtCodLocal)
        Me.GroupBox2.Controls.Add(Me.Codigo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 163)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Local"
        '
        'CmbCta
        '
        Me.CmbCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCta.DropDownWidth = 400
        Me.CmbCta.FormattingEnabled = True
        Me.CmbCta.Location = New System.Drawing.Point(89, 130)
        Me.CmbCta.Name = "CmbCta"
        Me.CmbCta.Size = New System.Drawing.Size(264, 21)
        Me.CmbCta.TabIndex = 35
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(392, 130)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(79, 20)
        Me.TxtValor.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(359, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Valor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Cta Contable"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Propiedad"
        '
        'CmbFlgProp
        '
        Me.CmbFlgProp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFlgProp.FormattingEnabled = True
        Me.CmbFlgProp.Items.AddRange(New Object() {"ESTATAL", "PRIVADA"})
        Me.CmbFlgProp.Location = New System.Drawing.Point(350, 101)
        Me.CmbFlgProp.Name = "CmbFlgProp"
        Me.CmbFlgProp.Size = New System.Drawing.Size(121, 21)
        Me.CmbFlgProp.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "mts2"
        '
        'TxtArea
        '
        Me.TxtArea.Location = New System.Drawing.Point(89, 101)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.Size = New System.Drawing.Size(130, 20)
        Me.TxtArea.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Area"
        '
        'TxtNum
        '
        Me.TxtNum.Location = New System.Drawing.Point(409, 75)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(62, 20)
        Me.TxtNum.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Numero"
        '
        'TxtDirLocal
        '
        Me.TxtDirLocal.Location = New System.Drawing.Point(89, 75)
        Me.TxtDirLocal.Name = "TxtDirLocal"
        Me.TxtDirLocal.Size = New System.Drawing.Size(264, 20)
        Me.TxtDirLocal.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Direccion"
        '
        'TxtNomLocal
        '
        Me.TxtNomLocal.Location = New System.Drawing.Point(89, 49)
        Me.TxtNomLocal.Name = "TxtNomLocal"
        Me.TxtNomLocal.Size = New System.Drawing.Size(382, 20)
        Me.TxtNomLocal.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nombre Local"
        '
        'TxtCodLocal
        '
        Me.TxtCodLocal.Location = New System.Drawing.Point(89, 23)
        Me.TxtCodLocal.Name = "TxtCodLocal"
        Me.TxtCodLocal.Size = New System.Drawing.Size(121, 20)
        Me.TxtCodLocal.TabIndex = 20
        '
        'Codigo
        '
        Me.Codigo.AutoSize = True
        Me.Codigo.Location = New System.Drawing.Point(43, 23)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(40, 13)
        Me.Codigo.TabIndex = 19
        Me.Codigo.Text = "Codigo"
        '
        'LblEntidad
        '
        Me.LblEntidad.AutoSize = True
        Me.LblEntidad.Location = New System.Drawing.Point(322, 26)
        Me.LblEntidad.Name = "LblEntidad"
        Me.LblEntidad.Size = New System.Drawing.Size(43, 13)
        Me.LblEntidad.TabIndex = 36
        Me.LblEntidad.Text = "Entidad"
        '
        'CmdNuevo
        '
        Me.CmdNuevo.Location = New System.Drawing.Point(6, 26)
        Me.CmdNuevo.Name = "CmdNuevo"
        Me.CmdNuevo.Size = New System.Drawing.Size(84, 23)
        Me.CmdNuevo.TabIndex = 0
        Me.CmdNuevo.Text = "Agregar"
        Me.CmdNuevo.UseVisualStyleBackColor = True
        '
        'CmdEdit
        '
        Me.CmdEdit.Location = New System.Drawing.Point(6, 55)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.Size = New System.Drawing.Size(84, 23)
        Me.CmdEdit.TabIndex = 1
        Me.CmdEdit.Text = "Modificar"
        Me.CmdEdit.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(6, 84)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(84, 23)
        Me.Cancelar.TabIndex = 2
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'CmdEliminar
        '
        Me.CmdEliminar.Location = New System.Drawing.Point(6, 113)
        Me.CmdEliminar.Name = "CmdEliminar"
        Me.CmdEliminar.Size = New System.Drawing.Size(84, 23)
        Me.CmdEliminar.TabIndex = 3
        Me.CmdEliminar.Text = "Eliminar"
        Me.CmdEliminar.UseVisualStyleBackColor = True
        '
        'FrmLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 318)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Controles)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmLocal"
        Me.Text = "Registro de Locales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Controles.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Controles As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblEntidad As System.Windows.Forms.Label
    Friend WithEvents CmbCta As System.Windows.Forms.ComboBox
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbFlgProp As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtArea As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDirLocal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNomLocal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodLocal As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.Label
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdNuevo As System.Windows.Forms.Button
    Friend WithEvents CmdEliminar As System.Windows.Forms.Button
End Class
