﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lokasjon
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Oppdaterlokasjon = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnDeleteLocation = New System.Windows.Forms.Button()
        Me.btnUpdateLocation = New System.Windows.Forms.Button()
        Me.btnAddLocation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPoststed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpostnr = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.txtLokasjon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Oppdaterlokasjon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Oppdaterlokasjon)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(335, 257)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Oversikt"
        '
        'Oppdaterlokasjon
        '
        Me.Oppdaterlokasjon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Oppdaterlokasjon.Location = New System.Drawing.Point(7, 17)
        Me.Oppdaterlokasjon.Margin = New System.Windows.Forms.Padding(2)
        Me.Oppdaterlokasjon.Name = "Oppdaterlokasjon"
        Me.Oppdaterlokasjon.RowTemplate.Height = 24
        Me.Oppdaterlokasjon.Size = New System.Drawing.Size(324, 232)
        Me.Oppdaterlokasjon.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BtnDeleteLocation)
        Me.GroupBox1.Controls.Add(Me.btnUpdateLocation)
        Me.GroupBox1.Controls.Add(Me.btnAddLocation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPoststed)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtpostnr)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTelefon)
        Me.GroupBox1.Controls.Add(Me.txtLokasjon)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(193, 257)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ny/rediger lokasjon"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(60, 84)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(126, 20)
        Me.txtMail.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 87)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Epost"
        '
        'BtnDeleteLocation
        '
        Me.BtnDeleteLocation.Location = New System.Drawing.Point(8, 225)
        Me.BtnDeleteLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDeleteLocation.Name = "BtnDeleteLocation"
        Me.BtnDeleteLocation.Size = New System.Drawing.Size(178, 24)
        Me.BtnDeleteLocation.TabIndex = 33
        Me.BtnDeleteLocation.Text = "Slett"
        Me.BtnDeleteLocation.UseVisualStyleBackColor = True
        '
        'btnUpdateLocation
        '
        Me.btnUpdateLocation.Location = New System.Drawing.Point(8, 196)
        Me.btnUpdateLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateLocation.Name = "btnUpdateLocation"
        Me.btnUpdateLocation.Size = New System.Drawing.Size(178, 24)
        Me.btnUpdateLocation.TabIndex = 32
        Me.btnUpdateLocation.Text = "Oppdater"
        Me.btnUpdateLocation.UseVisualStyleBackColor = True
        '
        'btnAddLocation
        '
        Me.btnAddLocation.Location = New System.Drawing.Point(8, 166)
        Me.btnAddLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddLocation.Name = "btnAddLocation"
        Me.btnAddLocation.Size = New System.Drawing.Size(178, 24)
        Me.btnAddLocation.TabIndex = 31
        Me.btnAddLocation.Text = "Legg til"
        Me.btnAddLocation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Poststed"
        '
        'txtPoststed
        '
        Me.txtPoststed.Location = New System.Drawing.Point(60, 132)
        Me.txtPoststed.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPoststed.Name = "txtPoststed"
        Me.txtPoststed.ReadOnly = True
        Me.txtPoststed.Size = New System.Drawing.Size(126, 20)
        Me.txtPoststed.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Postnr"
        '
        'txtpostnr
        '
        Me.txtpostnr.Location = New System.Drawing.Point(60, 109)
        Me.txtpostnr.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpostnr.Name = "txtpostnr"
        Me.txtpostnr.Size = New System.Drawing.Size(126, 20)
        Me.txtpostnr.TabIndex = 9
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(60, 60)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(126, 20)
        Me.txtAdresse.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefonnr"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(60, 37)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(126, 20)
        Me.txtTelefon.TabIndex = 4
        '
        'txtLokasjon
        '
        Me.txtLokasjon.Location = New System.Drawing.Point(60, 15)
        Me.txtLokasjon.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLokasjon.Name = "txtLokasjon"
        Me.txtLokasjon.Size = New System.Drawing.Size(126, 20)
        Me.txtLokasjon.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Navn"
        '
        'lokasjon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 278)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "lokasjon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lokasjon"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Oppdaterlokasjon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Oppdaterlokasjon As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpostnr As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefon As System.Windows.Forms.TextBox
    Friend WithEvents txtLokasjon As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPoststed As System.Windows.Forms.TextBox
    Friend WithEvents BtnDeleteLocation As System.Windows.Forms.Button
    Friend WithEvents btnUpdateLocation As System.Windows.Forms.Button
    Friend WithEvents btnAddLocation As System.Windows.Forms.Button
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
