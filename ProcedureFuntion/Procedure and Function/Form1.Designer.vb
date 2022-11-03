<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeBrg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaBrg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtxHrgSatuan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.bHitung = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'txtKodeBrg
        '
        Me.txtKodeBrg.Location = New System.Drawing.Point(179, 34)
        Me.txtKodeBrg.Name = "txtKodeBrg"
        Me.txtKodeBrg.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeBrg.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'txtNamaBrg
        '
        Me.txtNamaBrg.Location = New System.Drawing.Point(179, 60)
        Me.txtNamaBrg.Name = "txtNamaBrg"
        Me.txtNamaBrg.Size = New System.Drawing.Size(170, 20)
        Me.txtNamaBrg.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Satuan"
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(179, 90)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(100, 20)
        Me.txtSatuan.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Harga Satuan"
        '
        'txtxHrgSatuan
        '
        Me.txtxHrgSatuan.Location = New System.Drawing.Point(179, 121)
        Me.txtxHrgSatuan.Name = "txtxHrgSatuan"
        Me.txtxHrgSatuan.Size = New System.Drawing.Size(100, 20)
        Me.txtxHrgSatuan.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jumlah"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(179, 150)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtJumlah.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Harga"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(179, 178)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 11
        '
        'bHitung
        '
        Me.bHitung.Location = New System.Drawing.Point(73, 238)
        Me.bHitung.Name = "bHitung"
        Me.bHitung.Size = New System.Drawing.Size(95, 25)
        Me.bHitung.TabIndex = 12
        Me.bHitung.Text = "Hitung"
        Me.bHitung.UseVisualStyleBackColor = True
        '
        'bClear
        '
        Me.bClear.Location = New System.Drawing.Point(174, 238)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(95, 25)
        Me.bClear.TabIndex = 13
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = True
        '
        'bExit
        '
        Me.bExit.Location = New System.Drawing.Point(275, 238)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(95, 25)
        Me.bExit.TabIndex = 14
        Me.bExit.Text = "Exit"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 300)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.bClear)
        Me.Controls.Add(Me.bHitung)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtxHrgSatuan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaBrg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeBrg)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeBrg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaBrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSatuan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtxHrgSatuan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents bHitung As Button
    Friend WithEvents bClear As Button
    Friend WithEvents bExit As Button
End Class
