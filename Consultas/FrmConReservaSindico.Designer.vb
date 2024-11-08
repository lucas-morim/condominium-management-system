<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConReservaSindico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConReservaSindico))
        Me.DgdReservaSind = New System.Windows.Forms.DataGridView()
        Me.txtTotalRes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.btnLoc = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdReservaSind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdReservaSind
        '
        Me.DgdReservaSind.AllowUserToAddRows = False
        Me.DgdReservaSind.AllowUserToDeleteRows = False
        Me.DgdReservaSind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdReservaSind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdReservaSind.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column9, Me.Column10, Me.Column6, Me.Column7, Me.Column2, Me.Column3, Me.Column5, Me.Column8, Me.Column4})
        Me.DgdReservaSind.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdReservaSind.Location = New System.Drawing.Point(11, 83)
        Me.DgdReservaSind.Name = "DgdReservaSind"
        Me.DgdReservaSind.ReadOnly = True
        Me.DgdReservaSind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdReservaSind.Size = New System.Drawing.Size(1026, 507)
        Me.DgdReservaSind.TabIndex = 44
        '
        'txtTotalRes
        '
        Me.txtTotalRes.Location = New System.Drawing.Point(181, 597)
        Me.txtTotalRes.Name = "txtTotalRes"
        Me.txtTotalRes.Size = New System.Drawing.Size(194, 27)
        Me.txtTotalRes.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 600)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Valor Total das Reservas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(567, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 18)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Fim"
        '
        'DtpFim
        '
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(543, 33)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(97, 27)
        Me.DtpFim.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(406, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Início"
        '
        'DtpIni
        '
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(383, 33)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(97, 27)
        Me.DtpIni.TabIndex = 72
        '
        'btnLoc
        '
        Me.btnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoc.Location = New System.Drawing.Point(944, 594)
        Me.btnLoc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(92, 32)
        Me.btnLoc.TabIndex = 76
        Me.btnLoc.Text = "Localizar"
        Me.btnLoc.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codres"
        Me.Column1.HeaderText = "Código de Reserva"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 145
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "codarea"
        Me.Column9.HeaderText = "Código da Área"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        Me.Column9.Width = 99
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "nomarea"
        Me.Column10.HeaderText = "Nome da Área"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 92
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "datres"
        Me.Column6.HeaderText = "Data"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 66
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.DataPropertyName = "horres"
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column7.HeaderText = "Horário"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 85
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nomres"
        Me.Column2.HeaderText = "Nome do Morador"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 145
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "codmor"
        Me.Column3.HeaderText = "Código do Morador"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        Me.Column3.Width = 152
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "qtdpar"
        Me.Column5.HeaderText = "Quantidade de Participantes"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 202
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.DataPropertyName = "conres"
        Me.Column8.HeaderText = "Convidados"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.Width = 112
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "valres"
        Me.Column4.HeaderText = "Valor da Reserva"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 132
        '
        'FrmConReservaSindico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 634)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalRes)
        Me.Controls.Add(Me.DgdReservaSind)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmConReservaSindico"
        Me.Text = "                                                                                 " & _
    "                                                                          CONSUL" & _
    "TA DE RESERVAS"
        CType(Me.DgdReservaSind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdReservaSind As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalRes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLoc As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
