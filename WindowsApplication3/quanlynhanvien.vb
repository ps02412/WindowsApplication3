Imports System.Data.SqlClient

Public Class quanlynhanvien
    Dim chuoiketnoi As String = "workstation id=ps02412.mssql.somee.com;packet size=4096;user id=ps02412_SQLLogin_1;pwd=tl1nptgxbj;data source=ps02412.mssql.somee.com;persist security info=False;initial catalog=ps02412"
    Dim tb As New DataTable
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtManv.Text = DataGridView1.Item(0, index).Value
        txtTennv.Text = DataGridView1.Item(1, index).Value
        txtnamsinh.Text = DataGridView1.Item(2, index).Value
        txtgioitinh.Text = DataGridView1.Item(3, index).Value
        txtdienthoai.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtManv.Text = DataGridView1.Item(0, index).Value
        txtTennv.Text = DataGridView1.Item(1, index).Value
        txtnamsinh.Text = DataGridView1.Item(2, index).Value
        txtgioitinh.Text = DataGridView1.Item(3, index).Value
        txtdienthoai.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim stradd As String = "update sanpham set tansanpham = @tensanpham,dongia = @dongia,soluong=@soluong,chitietsp=@chitiet where masanpham =@masanpham"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@masanpham", txtManv.Text)
            com.Parameters.AddWithValue("@tensanpham", txtTennv.Text)
            com.Parameters.AddWithValue("@dongia", txtnamsinh.Text)
            com.Parameters.AddWithValue("@soluong", txtgioitinh.Text)
            com.Parameters.AddWithValue("@chitiet", txtdienthoai.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loadData()
    End Sub

    Private Sub loadData()
        Throw New NotImplementedException
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(chuoiketnoi)
        ketnoi.Open()
        Dim stradd As String = "delete from sanpham where masanpham =@masanpham"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@masanpham", txtManv.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi noi thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loadata()
    End Sub

    Private Sub loadata()
        Throw New NotImplementedException
    End Sub

    Private Sub quanlynhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class