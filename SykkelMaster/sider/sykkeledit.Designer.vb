﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sykkelEdit
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSykkeltype = New System.Windows.Forms.Button()
        Me.btnTom = New System.Windows.Forms.Button()
        Me.cbxPosisjon = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSlett = New System.Windows.Forms.Button()
        Me.btnOppdater = New System.Windows.Forms.Button()
        Me.btnLeggTil = New System.Windows.Forms.Button()
        Me.txtAvvik = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxHjul = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxRamme = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRammenr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxTilhorer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxSokStatus = New System.Windows.Forms.ComboBox()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxLokasjon = New System.Windows.Forms.ComboBox()
        Me.SykkelGridView = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SykkelGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSykkeltype)
        Me.GroupBox1.Controls.Add(Me.btnTom)
        Me.GroupBox1.Controls.Add(Me.cbxPosisjon)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnSlett)
        Me.GroupBox1.Controls.Add(Me.btnOppdater)
        Me.GroupBox1.Controls.Add(Me.btnLeggTil)
        Me.GroupBox1.Controls.Add(Me.txtAvvik)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbxStatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxHjul)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxRamme)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRammenr)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxTilhorer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 428)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legg til/Redigere"
        '
        'btnSykkeltype
        '
        Me.btnSykkeltype.Location = New System.Drawing.Point(207, 77)
        Me.btnSykkeltype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSykkeltype.Name = "btnSykkeltype"
        Me.btnSykkeltype.Size = New System.Drawing.Size(97, 26)
        Me.btnSykkeltype.TabIndex = 22
        Me.btnSykkeltype.Text = "Legg til"
        Me.btnSykkeltype.UseVisualStyleBackColor = True
        '
        'btnTom
        '
        Me.btnTom.Location = New System.Drawing.Point(10, 282)
        Me.btnTom.Name = "btnTom"
        Me.btnTom.Size = New System.Drawing.Size(296, 30)
        Me.btnTom.TabIndex = 9
        Me.btnTom.Text = "Tøm"
        Me.btnTom.UseVisualStyleBackColor = True
        '
        'cbxPosisjon
        '
        Me.cbxPosisjon.FormattingEnabled = True
        Me.cbxPosisjon.Location = New System.Drawing.Point(80, 50)
        Me.cbxPosisjon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxPosisjon.Name = "cbxPosisjon"
        Me.cbxPosisjon.Size = New System.Drawing.Size(224, 24)
        Me.cbxPosisjon.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Posisjon"
        '
        'btnSlett
        '
        Me.btnSlett.Location = New System.Drawing.Point(10, 391)
        Me.btnSlett.Name = "btnSlett"
        Me.btnSlett.Size = New System.Drawing.Size(296, 30)
        Me.btnSlett.TabIndex = 12
        Me.btnSlett.Text = "Slett"
        Me.btnSlett.UseVisualStyleBackColor = True
        '
        'btnOppdater
        '
        Me.btnOppdater.Location = New System.Drawing.Point(10, 354)
        Me.btnOppdater.Name = "btnOppdater"
        Me.btnOppdater.Size = New System.Drawing.Size(296, 30)
        Me.btnOppdater.TabIndex = 11
        Me.btnOppdater.Text = "Oppdater"
        Me.btnOppdater.UseVisualStyleBackColor = True
        '
        'btnLeggTil
        '
        Me.btnLeggTil.Location = New System.Drawing.Point(8, 318)
        Me.btnLeggTil.Name = "btnLeggTil"
        Me.btnLeggTil.Size = New System.Drawing.Size(296, 30)
        Me.btnLeggTil.TabIndex = 10
        Me.btnLeggTil.Text = "Legg til"
        Me.btnLeggTil.UseVisualStyleBackColor = True
        '
        'txtAvvik
        '
        Me.txtAvvik.Location = New System.Drawing.Point(80, 192)
        Me.txtAvvik.Multiline = True
        Me.txtAvvik.Name = "txtAvvik"
        Me.txtAvvik.Size = New System.Drawing.Size(224, 85)
        Me.txtAvvik.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Avviksmld"
        '
        'cbxStatus
        '
        Me.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Items.AddRange(New Object() {"Innlevert", "Leid ut", "Reparasjon"})
        Me.cbxStatus.Location = New System.Drawing.Point(80, 163)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(224, 24)
        Me.cbxStatus.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Status"
        '
        'cbxHjul
        '
        Me.cbxHjul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxHjul.FormattingEnabled = True
        Me.cbxHjul.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "24"})
        Me.cbxHjul.Location = New System.Drawing.Point(80, 134)
        Me.cbxHjul.Name = "cbxHjul"
        Me.cbxHjul.Size = New System.Drawing.Size(69, 24)
        Me.cbxHjul.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hjulstr"
        '
        'cbxRamme
        '
        Me.cbxRamme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRamme.FormattingEnabled = True
        Me.cbxRamme.Items.AddRange(New Object() {"13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbxRamme.Location = New System.Drawing.Point(235, 134)
        Me.cbxRamme.Name = "cbxRamme"
        Me.cbxRamme.Size = New System.Drawing.Size(70, 24)
        Me.cbxRamme.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rammestr"
        '
        'txtRammenr
        '
        Me.txtRammenr.Location = New System.Drawing.Point(80, 107)
        Me.txtRammenr.Name = "txtRammenr"
        Me.txtRammenr.Size = New System.Drawing.Size(224, 22)
        Me.txtRammenr.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rammenr"
        '
        'cbxTilhorer
        '
        Me.cbxTilhorer.FormattingEnabled = True
        Me.cbxTilhorer.Location = New System.Drawing.Point(80, 22)
        Me.cbxTilhorer.Name = "cbxTilhorer"
        Me.cbxTilhorer.Size = New System.Drawing.Size(224, 24)
        Me.cbxTilhorer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tilhører"
        '
        'cbxType
        '
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Location = New System.Drawing.Point(80, 78)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(122, 24)
        Me.cbxType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cbxSokStatus)
        Me.GroupBox2.Controls.Add(Me.txtSok)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbxLokasjon)
        Me.GroupBox2.Controls.Add(Me.SykkelGridView)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(881, 428)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Søk"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(455, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Status:"
        '
        'cbxSokStatus
        '
        Me.cbxSokStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSokStatus.FormattingEnabled = True
        Me.cbxSokStatus.Items.AddRange(New Object() {"Innlevert", "Leid ut", "Reparasjon"})
        Me.cbxSokStatus.Location = New System.Drawing.Point(514, 16)
        Me.cbxSokStatus.Name = "cbxSokStatus"
        Me.cbxSokStatus.Size = New System.Drawing.Size(131, 24)
        Me.cbxSokStatus.TabIndex = 20
        '
        'txtSok
        '
        Me.txtSok.Location = New System.Drawing.Point(303, 16)
        Me.txtSok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(132, 22)
        Me.txtSok.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Rammenr:"
        '
        'cbxLokasjon
        '
        Me.cbxLokasjon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLokasjon.FormattingEnabled = True
        Me.cbxLokasjon.Location = New System.Drawing.Point(77, 16)
        Me.cbxLokasjon.Name = "cbxLokasjon"
        Me.cbxLokasjon.Size = New System.Drawing.Size(131, 24)
        Me.cbxLokasjon.TabIndex = 13
        '
        'SykkelGridView
        '
        Me.SykkelGridView.AllowUserToAddRows = False
        Me.SykkelGridView.AllowUserToDeleteRows = False
        Me.SykkelGridView.AllowUserToResizeRows = False
        Me.SykkelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SykkelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SykkelGridView.Location = New System.Drawing.Point(9, 46)
        Me.SykkelGridView.Name = "SykkelGridView"
        Me.SykkelGridView.ReadOnly = True
        Me.SykkelGridView.RowHeadersVisible = False
        Me.SykkelGridView.RowTemplate.Height = 24
        Me.SykkelGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SykkelGridView.Size = New System.Drawing.Size(866, 375)
        Me.SykkelGridView.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Posisjon"
        '
        'sykkelEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 449)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sykkelEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sykkel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SykkelGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxTilhorer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxHjul As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxRamme As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRammenr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxLokasjon As System.Windows.Forms.ComboBox
    Friend WithEvents SykkelGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAvvik As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSlett As System.Windows.Forms.Button
    Friend WithEvents btnOppdater As System.Windows.Forms.Button
    Friend WithEvents btnLeggTil As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSok As System.Windows.Forms.TextBox
    Friend WithEvents cbxPosisjon As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnTom As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxSokStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSykkeltype As System.Windows.Forms.Button
End Class
