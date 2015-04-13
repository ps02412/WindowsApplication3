Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class dangnhap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chuoiketnoi As String = "workstation id=ps02412.mssql.somee.com;packet size=4096;user id=ps02412_SQLLogin_1;pwd=tl1nptgxbj;data source=ps02412.mssql.somee.com;persist security info=False;initial catalog=ps02412"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where MaNhanVien= '" & TextBox1 & "'and password='" & TextBox2 & "'", KetNoi)
        Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("kết nói thành công")
                quanly.Show()
                Me.Hide()
            Else
                MessageBox.Show("sai tài khoản hoặc mật khẩu")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class

