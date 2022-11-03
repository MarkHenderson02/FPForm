Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        Call Bersih()
    End Sub

    Private Sub bHitung_Click(sender As Object, e As EventArgs) Handles bHitung.Click
        Call CekDataKosong()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin Tutup Form Ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
