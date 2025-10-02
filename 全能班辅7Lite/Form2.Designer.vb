<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.随机点名ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.一周课表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.考试模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.午睡模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.软件设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于软件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重启软件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关闭软件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(122, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("HarmonyOS Sans SC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "星期日"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2
        '
        'Timer2
        '
        Me.Timer2.Interval = 2
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 2
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 500
        '
        'Timer6
        '
        Me.Timer6.Enabled = True
        Me.Timer6.Interval = 1000
        '
        'Timer7
        '
        Me.Timer7.Enabled = True
        Me.Timer7.Interval = 2000
        '
        'Timer8
        '
        Me.Timer8.Interval = 5000
        '
        'Timer9
        '
        Me.Timer9.Interval = 2
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("HarmonyOS Sans SC", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.随机点名ToolStripMenuItem, Me.一周课表ToolStripMenuItem, Me.ToolStripSeparator1, Me.考试模式ToolStripMenuItem, Me.午睡模式ToolStripMenuItem, Me.ToolStripSeparator2, Me.软件设置ToolStripMenuItem, Me.ToolStripSeparator3, Me.关于软件ToolStripMenuItem, Me.重启软件ToolStripMenuItem, Me.关闭软件ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(167, 214)
        '
        '随机点名ToolStripMenuItem
        '
        Me.随机点名ToolStripMenuItem.Name = "随机点名ToolStripMenuItem"
        Me.随机点名ToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.随机点名ToolStripMenuItem.Text = "随机点名"
        '
        '一周课表ToolStripMenuItem
        '
        Me.一周课表ToolStripMenuItem.Name = "一周课表ToolStripMenuItem"
        Me.一周课表ToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.一周课表ToolStripMenuItem.Text = "一周课表"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        '考试模式ToolStripMenuItem
        '
        Me.考试模式ToolStripMenuItem.Name = "考试模式ToolStripMenuItem"
        Me.考试模式ToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.考试模式ToolStripMenuItem.Text = "考试模式"
        '
        '午睡模式ToolStripMenuItem
        '
        Me.午睡模式ToolStripMenuItem.Name = "午睡模式ToolStripMenuItem"
        Me.午睡模式ToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.午睡模式ToolStripMenuItem.Text = "午睡模式"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        '软件设置ToolStripMenuItem
        '
        Me.软件设置ToolStripMenuItem.Name = "软件设置ToolStripMenuItem"
        Me.软件设置ToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.软件设置ToolStripMenuItem.Text = "软件设置"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(163, 6)
        '
        '关于软件ToolStripMenuItem
        '
        Me.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem"
        Me.关于软件ToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.关于软件ToolStripMenuItem.Text = "关于 全能班辅"
        '
        '重启软件ToolStripMenuItem
        '
        Me.重启软件ToolStripMenuItem.Name = "重启软件ToolStripMenuItem"
        Me.重启软件ToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.重启软件ToolStripMenuItem.Text = "重启 全能班辅"
        '
        '关闭软件ToolStripMenuItem
        '
        Me.关闭软件ToolStripMenuItem.Name = "关闭软件ToolStripMenuItem"
        Me.关闭软件ToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.关闭软件ToolStripMenuItem.Text = "关闭 全能班辅"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(165, 41)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "课表模块1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 随机点名ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 一周课表ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 考试模式ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 午睡模式ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 软件设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于软件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 重启软件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关闭软件ToolStripMenuItem As ToolStripMenuItem
End Class
