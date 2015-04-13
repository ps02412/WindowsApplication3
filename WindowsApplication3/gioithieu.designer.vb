<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gioithieu
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
        Me.lblNames = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblBanquyen = New System.Windows.Forms.Label()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlTopabout = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ptbAbout = New System.Windows.Forms.PictureBox()
        Me.pnlTopabout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ptbAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNames
        '
        Me.lblNames.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.ForeColor = System.Drawing.Color.Red
        Me.lblNames.Location = New System.Drawing.Point(50, 16)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(273, 33)
        Me.lblNames.TabIndex = 0
        Me.lblNames.Text = "Giới Thiệu"
        Me.lblNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(149, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 27)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Đóng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(27, 121)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(221, 17)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Phần mềm :  Quản lý cửa hàng moto"
        '
        'lblBanquyen
        '
        Me.lblBanquyen.AutoSize = True
        Me.lblBanquyen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanquyen.Location = New System.Drawing.Point(27, 152)
        Me.lblBanquyen.Name = "lblBanquyen"
        Me.lblBanquyen.Size = New System.Drawing.Size(135, 17)
        Me.lblBanquyen.TabIndex = 3
        Me.lblBanquyen.Text = "Sinh viên : Võ Tấn Đạt"
        '
        'lblDesign
        '
        Me.lblDesign.AutoSize = True
        Me.lblDesign.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesign.Location = New System.Drawing.Point(27, 189)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(102, 17)
        Me.lblDesign.TabIndex = 4
        Me.lblDesign.Text = "MSSV : PS02412"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Lớp : PT9304"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(50, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Giới Thiệu Sản Phẩm"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTopabout
        '
        Me.pnlTopabout.BackColor = System.Drawing.Color.GhostWhite
        Me.pnlTopabout.Controls.Add(Me.lblNames)
        Me.pnlTopabout.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopabout.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopabout.Name = "pnlTopabout"
        Me.pnlTopabout.Size = New System.Drawing.Size(367, 68)
        Me.pnlTopabout.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(367, 46)
        Me.Panel1.TabIndex = 9
        '
        'ptbAbout
        '
        Me.ptbAbout.Location = New System.Drawing.Point(0, 271)
        Me.ptbAbout.Name = "ptbAbout"
        Me.ptbAbout.Size = New System.Drawing.Size(372, 105)
        Me.ptbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAbout.TabIndex = 5
        Me.ptbAbout.TabStop = False
        '
        'gioithieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(367, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlTopabout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ptbAbout)
        Me.Controls.Add(Me.lblDesign)
        Me.Controls.Add(Me.lblBanquyen)
        Me.Controls.Add(Me.lblVersion)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "gioithieu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Thông tin phần mềm"
        Me.TopMost = True
        Me.pnlTopabout.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ptbAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNames As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblBanquyen As System.Windows.Forms.Label
    Friend WithEvents lblDesign As System.Windows.Forms.Label
    Friend WithEvents ptbAbout As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlTopabout As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
