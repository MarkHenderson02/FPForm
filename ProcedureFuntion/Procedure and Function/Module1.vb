Module Module1
    Function Hitung()
        Dim Jumlah, HrgSatuan, Total As Integer
        Jumlah = Val(Form1.txtJumlah.Text)
        HrgSatuan = Val(Form1.txtxHrgSatuan.Text)
        Total = Jumlah * HrgSatuan
        Return Total
    End Function

    Sub Bersih()
        Form1.txtKodeBrg.Text = ""
        Form1.txtNamaBrg.Text = ""
        Form1.txtSatuan.Text = ""
        Form1.txtJumlah.Text = ""
        Form1.txtTotal.Text = ""
        Form1.txtKodeBrg.Focus()
        Form1.txtTotal.Enabled = False
    End Sub

    Sub CekDataKosong()
        If Form1.txtKodeBrg.Text = "" Then
            MessageBox.Show("Kode Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form1.txtKodeBrg.Focus()
        ElseIf Form1.txtNamaBrg.Text = "" Then
            MessageBox.Show("Nama Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form1.txtNamaBrg.Focus()
        ElseIf Form1.txtSatuan.Text = "" Then
            MessageBox.Show("Satuan Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form1.txtSatuan.Focus()
        ElseIf Form1.txtxHrgSatuan.Text = "" Then
            MessageBox.Show("Harga Satuan Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form1.txtxHrgSatuan.Focus()
        ElseIf Form1.txtJumlah.Text = "" Then
            MessageBox.Show("Jumlah Barang Harus Diisi", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form1.txtJumlah.Focus()
        Else
            Form1.txtTotal.Text = Hitung()
        End If
    End Sub
End Module
