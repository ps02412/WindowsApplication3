<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanlynhanvien
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
        Me.btnthem = New System.Windows.Forms.Button()
        Me.ofdPicture = New System.Windows.Forms.OpenFileDialog()
        Me.grbThongtinsp = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.txtnamsinh = New System.Windows.Forms.TextBox()
        Me.txtdienthoai = New System.Windows.Forms.TextBox()
        Me.txtgioitinh = New System.Windows.Forms.TextBox()
        Me.txtTennv = New System.Windows.Forms.TextBox()
        Me.txtManv = New System.Windows.Forms.TextBox()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.lblThongtin = New System.Windows.Forms.Label()
        Me.ptbHinhanh = New System.Windows.Forms.PictureBox()
        Me.lblXuatxu = New System.Windows.Forms.Label()
        Me.lblLoaisp = New System.Windows.Forms.Label()
        Me.lblHangsx = New System.Windows.Forms.Label()
        Me.lblTensp = New System.Windows.Forms.Label()
        Me.gpbdanhsachnhanvien = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grbThongtinsp.SuspendLayout()
        CType(Me.ptbHinhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbdanhsachnhanvien.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.Location = New System.Drawing.Point(251, 190)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 30)
        Me.btnthem.TabIndex = 7
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'ofdPicture
        '
        Me.ofdPicture.FileName = "OpenFileDialog1"
        '
        'grbThongtinsp
        '
        Me.grbThongtinsp.BackColor = System.Drawing.SystemColors.ControlDark
        Me.grbThongtinsp.Controls.Add(Me.Button1)
        Me.grbThongtinsp.Controls.Add(Me.btnxoa)
        Me.grbThongtinsp.Controls.Add(Me.btnsua)
        Me.grbThongtinsp.Controls.Add(Me.txtnamsinh)
        Me.grbThongtinsp.Controls.Add(Me.btnthem)
        Me.grbThongtinsp.Controls.Add(Me.txtdienthoai)
        Me.grbThongtinsp.Controls.Add(Me.txtgioitinh)
        Me.grbThongtinsp.Controls.Add(Me.txtTennv)
        Me.grbThongtinsp.Controls.Add(Me.txtManv)
        Me.grbThongtinsp.Controls.Add(Me.lblmasp)
        Me.grbThongtinsp.Controls.Add(Me.lblThongtin)
        Me.grbThongtinsp.Controls.Add(Me.ptbHinhanh)
        Me.grbThongtinsp.Controls.Add(Me.lblXuatxu)
        Me.grbThongtinsp.Controls.Add(Me.lblLoaisp)
        Me.grbThongtinsp.Controls.Add(Me.lblHangsx)
        Me.grbThongtinsp.Controls.Add(Me.lblTensp)
        Me.grbThongtinsp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbThongtinsp.Location = New System.Drawing.Point(8, 7)
        Me.grbThongtinsp.Name = "grbThongtinsp"
        Me.grbThongtinsp.Size = New System.Drawing.Size(706, 243)
        Me.grbThongtinsp.TabIndex = 9
        Me.grbThongtinsp.TabStop = False
        Me.grbThongtinsp.Text = "Thông tin Nhân viên"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(503, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Thoát"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(413, 190)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 30)
        Me.btnxoa.TabIndex = 13
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.Location = New System.Drawing.Point(332, 190)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 30)
        Me.btnsua.TabIndex = 12
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'txtnamsinh
        '
        Me.txtnamsinh.Location = New System.Drawing.Point(133, 89)
        Me.txtnamsinh.Name = "txtnamsinh"
        Me.txtnamsinh.Size = New System.Drawing.Size(156, 25)
        Me.txtnamsinh.TabIndex = 5
        '
        'txtdienthoai
        '
        Me.txtdienthoai.Location = New System.Drawing.Point(133, 155)
        Me.txtdienthoai.Name = "txtdienthoai"
        Me.txtdienthoai.Size = New System.Drawing.Size(156, 25)
        Me.txtdienthoai.TabIndex = 4
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Location = New System.Drawing.Point(133, 121)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(156, 25)
        Me.txtgioitinh.TabIndex = 3
        '
        'txtTennv
        '
        Me.txtTennv.Location = New System.Drawing.Point(133, 58)
        Me.txtTennv.Name = "txtTennv"
        Me.txtTennv.Size = New System.Drawing.Size(365, 25)
        Me.txtTennv.TabIndex = 2
        '
        'txtManv
        '
        Me.txtManv.Location = New System.Drawing.Point(133, 24)
        Me.txtManv.Name = "txtManv"
        Me.txtManv.Size = New System.Drawing.Size(89, 25)
        Me.txtManv.TabIndex = 1
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.Location = New System.Drawing.Point(6, 27)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(97, 17)
        Me.lblmasp.TabIndex = 10
        Me.lblmasp.Text = "&Mã nhân viên : "
        '
        'lblThongtin
        '
        Me.lblThongtin.AutoSize = True
        Me.lblThongtin.Location = New System.Drawing.Point(6, 197)
        Me.lblThongtin.Name = "lblThongtin"
        Me.lblThongtin.Size = New System.Drawing.Size(0, 17)
        Me.lblThongtin.TabIndex = 9
        '
        'ptbHinhanh
        '
        Me.ptbHinhanh.BackColor = System.Drawing.Color.GhostWhite
        Me.ptbHinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbHinhanh.Location = New System.Drawing.Point(523, 19)
        Me.ptbHinhanh.Name = "ptbHinhanh"
        Me.ptbHinhanh.Size = New System.Drawing.Size(177, 161)
        Me.ptbHinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbHinhanh.TabIndex = 8
        Me.ptbHinhanh.TabStop = False
        '
        'lblXuatxu
        '
        Me.lblXuatxu.AutoSize = True
        Me.lblXuatxu.Location = New System.Drawing.Point(6, 92)
        Me.lblXuatxu.Name = "lblXuatxu"
        Me.lblXuatxu.Size = New System.Drawing.Size(74, 17)
        Me.lblXuatxu.TabIndex = 6
        Me.lblXuatxu.Text = "&Năm sinh : "
        '
        'lblLoaisp
        '
        Me.lblLoaisp.AutoSize = True
        Me.lblLoaisp.Location = New System.Drawing.Point(6, 155)
        Me.lblLoaisp.Name = "lblLoaisp"
        Me.lblLoaisp.Size = New System.Drawing.Size(74, 17)
        Me.lblLoaisp.TabIndex = 4
        Me.lblLoaisp.Text = "&Điện thoại :"
        '
        'lblHangsx
        '
        Me.lblHangsx.AutoSize = True
        Me.lblHangsx.Location = New System.Drawing.Point(6, 124)
        Me.lblHangsx.Name = "lblHangsx"
        Me.lblHangsx.Size = New System.Drawing.Size(67, 17)
        Me.lblHangsx.TabIndex = 2
        Me.lblHangsx.Text = "&Giới tính : "
        '
        'lblTensp
        '
        Me.lblTensp.AutoSize = True
        Me.lblTensp.Location = New System.Drawing.Point(6, 61)
        Me.lblTensp.Name = "lblTensp"
        Me.lblTensp.Size = New System.Drawing.Size(99, 17)
        Me.lblTensp.TabIndex = 0
        Me.lblTensp.Text = "&Tên nhân viên : "
        '
        'gpbdanhsachnhanvien
        '
        Me.gpbdanhsachnhanvien.Controls.Add(Me.DataGridView1)
        Me.gpbdanhsachnhanvien.Location = New System.Drawing.Point(8, 256)
        Me.gpbdanhsachnhanvien.Name = "gpbdanhsachnhanvien"
        Me.gpbdanhsachnhanvien.Size = New System.Drawing.Size(706, 192)
        Me.gpbdanhsachnhanvien.TabIndex = 14
        Me.gpbdanhsachnhanvien.TabStop = False
        Me.gpbdanhsachnhanvien.Text = "Danh sách nhân viên"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(686, 158)
        Me.DataGridView1.TabIndex = 0
        '
        'quanlynhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(715, 448)
        Me.Controls.Add(Me.gpbdanhsachnhanvien)
        Me.Controls.Add(Me.grbThongtinsp)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "quanlynhanvien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Quản lý nhân viên"
        Me.grbThongtinsp.ResumeLayout(False)
        Me.grbThongtinsp.PerformLayout()
        CType(Me.ptbHinhanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbdanhsachnhanvien.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents ofdPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grbThongtinsp As System.Windows.Forms.GroupBox
    Friend WithEvents lblThongtin As System.Windows.Forms.Label
    Friend WithEvents ptbHinhanh As System.Windows.Forms.PictureBox
    Friend WithEvents lblXuatxu As System.Windows.Forms.Label
    Friend WithEvents lblLoaisp As System.Windows.Forms.Label
    Friend WithEvents lblHangsx As System.Windows.Forms.Label
    Friend WithEvents lblTensp As System.Windows.Forms.Label
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents txtnamsinh As System.Windows.Forms.TextBox
    Friend WithEvents txtdienthoai As System.Windows.Forms.TextBox
    Friend WithEvents txtgioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtTennv As System.Windows.Forms.TextBox
    Friend WithEvents txtManv As System.Windows.Forms.TextBox
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents gpbdanhsachnhanvien As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
