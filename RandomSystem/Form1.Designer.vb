<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.开始SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.功能选择SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.随机生成评委ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重启RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(392, 146)
        Me.Button1.Margin = New System.Windows.Forms.Padding(9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(372, 373)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "随机生成评委"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("黑体", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 60
        Me.ListBox1.Location = New System.Drawing.Point(10, 35)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(9)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(362, 484)
        Me.ListBox1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.ItemHeight = 25
        Me.ComboBox1.Location = New System.Drawing.Point(392, 101)
        Me.ComboBox1.MaxDropDownItems = 15
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(372, 33)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "请选择演讲者姓名"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.开始SToolStripMenuItem, Me.功能选择SToolStripMenuItem, Me.帮助HToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '开始SToolStripMenuItem
        '
        Me.开始SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.重启RToolStripMenuItem, Me.退出EToolStripMenuItem})
        Me.开始SToolStripMenuItem.Name = "开始SToolStripMenuItem"
        Me.开始SToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.开始SToolStripMenuItem.Text = "开始(&S)"
        '
        '退出EToolStripMenuItem
        '
        Me.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem"
        Me.退出EToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.退出EToolStripMenuItem.Text = "退出(&E)"
        '
        '功能选择SToolStripMenuItem
        '
        Me.功能选择SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.随机生成评委ToolStripMenuItem})
        Me.功能选择SToolStripMenuItem.Name = "功能选择SToolStripMenuItem"
        Me.功能选择SToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.功能选择SToolStripMenuItem.Text = "功能选择(&S)"
        '
        '随机生成评委ToolStripMenuItem
        '
        Me.随机生成评委ToolStripMenuItem.Name = "随机生成评委ToolStripMenuItem"
        Me.随机生成评委ToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.随机生成评委ToolStripMenuItem.Text = "随机生成评委"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        '
        '重启RToolStripMenuItem
        '
        Me.重启RToolStripMenuItem.Name = "重启RToolStripMenuItem"
        Me.重启RToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.重启RToolStripMenuItem.Text = "重启(R)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(23.0!, 43.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("黑体", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(9)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RandomSystem"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 开始SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 功能选择SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 随机生成评委ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重启RToolStripMenuItem As ToolStripMenuItem
End Class
