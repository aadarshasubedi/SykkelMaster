﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class innlevering
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lokasjoner = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxLeieAvtaler = New System.Windows.Forms.ComboBox()
        Me.AvsluttLeie = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.oversiktGrid = New System.Windows.Forms.DataGridView()
        Me.SendMeldingContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SendMeldingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rediger_kunde = New System.Windows.Forms.Button()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSokKunde = New System.Windows.Forms.TextBox()
        Me.cbxKunde = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tilbehorGrid = New System.Windows.Forms.DataGridView()
        Me.cbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.oversiktGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SendMeldingContext.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.tilbehorGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lokasjoner)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbxLeieAvtaler)
        Me.GroupBox2.Controls.Add(Me.AvsluttLeie)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 149)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(232, 193)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Innlevering"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 65)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 76)
        Me.TextBox1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Avvik"
        '
        'lokasjoner
        '
        Me.lokasjoner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lokasjoner.FormattingEnabled = True
        Me.lokasjoner.Location = New System.Drawing.Point(64, 41)
        Me.lokasjoner.Margin = New System.Windows.Forms.Padding(2)
        Me.lokasjoner.Name = "lokasjoner"
        Me.lokasjoner.Size = New System.Drawing.Size(151, 21)
        Me.lokasjoner.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Sted"
        '
        'cbxLeieAvtaler
        '
        Me.cbxLeieAvtaler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLeieAvtaler.FormattingEnabled = True
        Me.cbxLeieAvtaler.Location = New System.Drawing.Point(64, 17)
        Me.cbxLeieAvtaler.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxLeieAvtaler.Name = "cbxLeieAvtaler"
        Me.cbxLeieAvtaler.Size = New System.Drawing.Size(151, 21)
        Me.cbxLeieAvtaler.TabIndex = 23
        '
        'AvsluttLeie
        '
        Me.AvsluttLeie.Location = New System.Drawing.Point(7, 145)
        Me.AvsluttLeie.Margin = New System.Windows.Forms.Padding(2)
        Me.AvsluttLeie.Name = "AvsluttLeie"
        Me.AvsluttLeie.Size = New System.Drawing.Size(207, 41)
        Me.AvsluttLeie.TabIndex = 22
        Me.AvsluttLeie.Text = "Avslutt leie"
        Me.AvsluttLeie.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "OrdreNr"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.oversiktGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(652, 182)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avtale"
        '
        'oversiktGrid
        '
        Me.oversiktGrid.AllowUserToAddRows = False
        Me.oversiktGrid.AllowUserToDeleteRows = False
        Me.oversiktGrid.AllowUserToResizeRows = False
        Me.oversiktGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.oversiktGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.oversiktGrid.ContextMenuStrip = Me.SendMeldingContext
        Me.oversiktGrid.Location = New System.Drawing.Point(4, 14)
        Me.oversiktGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.oversiktGrid.MultiSelect = False
        Me.oversiktGrid.Name = "oversiktGrid"
        Me.oversiktGrid.ReadOnly = True
        Me.oversiktGrid.RowHeadersVisible = False
        Me.oversiktGrid.RowTemplate.Height = 24
        Me.oversiktGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.oversiktGrid.Size = New System.Drawing.Size(643, 159)
        Me.oversiktGrid.TabIndex = 0
        '
        'SendMeldingContext
        '
        Me.SendMeldingContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendMeldingToolStripMenuItem})
        Me.SendMeldingContext.Name = "SendMeldingContext"
        Me.SendMeldingContext.Size = New System.Drawing.Size(148, 26)
        '
        'SendMeldingToolStripMenuItem
        '
        Me.SendMeldingToolStripMenuItem.Name = "SendMeldingToolStripMenuItem"
        Me.SendMeldingToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SendMeldingToolStripMenuItem.Text = "Send melding"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rediger_kunde)
        Me.GroupBox3.Controls.Add(Me.txtTelefon)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtSokKunde)
        Me.GroupBox3.Controls.Add(Me.cbxKunde)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(232, 134)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kunde"
        '
        'Rediger_kunde
        '
        Me.Rediger_kunde.Location = New System.Drawing.Point(10, 88)
        Me.Rediger_kunde.Margin = New System.Windows.Forms.Padding(2)
        Me.Rediger_kunde.Name = "Rediger_kunde"
        Me.Rediger_kunde.Size = New System.Drawing.Size(88, 41)
        Me.Rediger_kunde.TabIndex = 14
        Me.Rediger_kunde.Text = "Rediger kunde"
        Me.Rediger_kunde.UseVisualStyleBackColor = True
        '
        'txtTelefon
        '
        Me.txtTelefon.Enabled = False
        Me.txtTelefon.Location = New System.Drawing.Point(65, 65)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(151, 20)
        Me.txtTelefon.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Telefonnr"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Navn"
        '
        'txtSokKunde
        '
        Me.txtSokKunde.Location = New System.Drawing.Point(65, 17)
        Me.txtSokKunde.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSokKunde.Name = "txtSokKunde"
        Me.txtSokKunde.Size = New System.Drawing.Size(151, 20)
        Me.txtSokKunde.TabIndex = 14
        '
        'cbxKunde
        '
        Me.cbxKunde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKunde.FormattingEnabled = True
        Me.cbxKunde.Location = New System.Drawing.Point(65, 41)
        Me.cbxKunde.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxKunde.Name = "cbxKunde"
        Me.cbxKunde.Size = New System.Drawing.Size(151, 21)
        Me.cbxKunde.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Søk"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tilbehorGrid)
        Me.GroupBox4.Location = New System.Drawing.Point(246, 206)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox4.Size = New System.Drawing.Size(652, 135)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tilbehør"
        '
        'tilbehorGrid
        '
        Me.tilbehorGrid.AllowUserToAddRows = False
        Me.tilbehorGrid.AllowUserToDeleteRows = False
        Me.tilbehorGrid.AllowUserToResizeRows = False
        Me.tilbehorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tilbehorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tilbehorGrid.Location = New System.Drawing.Point(5, 15)
        Me.tilbehorGrid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tilbehorGrid.MultiSelect = False
        Me.tilbehorGrid.Name = "tilbehorGrid"
        Me.tilbehorGrid.ReadOnly = True
        Me.tilbehorGrid.RowHeadersVisible = False
        Me.tilbehorGrid.RowTemplate.Height = 24
        Me.tilbehorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tilbehorGrid.Size = New System.Drawing.Size(641, 117)
        Me.tilbehorGrid.TabIndex = 0
        '
        'cbxStatus
        '
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Items.AddRange(New Object() {"Leid ut", "Tidsfrist gått ut", "Tidsfrist ikke gått ut"})
        Me.cbxStatus.Location = New System.Drawing.Point(769, 4)
        Me.cbxStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(126, 21)
        Me.cbxStatus.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(737, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Søk:"
        '
        'innlevering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 347)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxStatus)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "innlevering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Innlevering"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.oversiktGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SendMeldingContext.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.tilbehorGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lokasjoner As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxLeieAvtaler As System.Windows.Forms.ComboBox
    Friend WithEvents AvsluttLeie As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents oversiktGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rediger_kunde As System.Windows.Forms.Button
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSokKunde As System.Windows.Forms.TextBox
    Friend WithEvents cbxKunde As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tilbehorGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SendMeldingContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SendMeldingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
