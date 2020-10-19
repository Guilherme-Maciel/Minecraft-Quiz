<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_right = New System.Windows.Forms.Button()
        Me.btn_left = New System.Windows.Forms.Button()
        Me.btn_down = New System.Windows.Forms.Button()
        Me.btn_up = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picbox_objeto1 = New System.Windows.Forms.PictureBox()
        Me.picbox_objeto2 = New System.Windows.Forms.PictureBox()
        Me.picbox_objeto3 = New System.Windows.Forms.PictureBox()
        Me.picbox_objeto4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_timer = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_objeto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_objeto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_objeto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_objeto4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.crafting
        Me.PictureBox1.Location = New System.Drawing.Point(274, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 450)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_ok
        '
        Me.btn_ok.Font = New System.Drawing.Font("Minecraft", 24.0!)
        Me.btn_ok.Location = New System.Drawing.Point(841, 49)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(88, 88)
        Me.btn_ok.TabIndex = 8
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_right
        '
        Me.btn_right.BackColor = System.Drawing.Color.Transparent
        Me.btn_right.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.right
        Me.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_right.CausesValidation = False
        Me.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_right.Location = New System.Drawing.Point(40, 225)
        Me.btn_right.Name = "btn_right"
        Me.btn_right.Size = New System.Drawing.Size(116, 116)
        Me.btn_right.TabIndex = 12
        Me.btn_right.UseVisualStyleBackColor = False
        '
        'btn_left
        '
        Me.btn_left.BackColor = System.Drawing.Color.Transparent
        Me.btn_left.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.left
        Me.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_left.CausesValidation = False
        Me.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_left.Location = New System.Drawing.Point(40, 410)
        Me.btn_left.Name = "btn_left"
        Me.btn_left.Size = New System.Drawing.Size(116, 116)
        Me.btn_left.TabIndex = 11
        Me.btn_left.UseVisualStyleBackColor = False
        '
        'btn_down
        '
        Me.btn_down.BackColor = System.Drawing.Color.Transparent
        Me.btn_down.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.down
        Me.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_down.CausesValidation = False
        Me.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_down.Location = New System.Drawing.Point(829, 411)
        Me.btn_down.Name = "btn_down"
        Me.btn_down.Size = New System.Drawing.Size(116, 116)
        Me.btn_down.TabIndex = 10
        Me.btn_down.UseVisualStyleBackColor = False
        '
        'btn_up
        '
        Me.btn_up.BackColor = System.Drawing.Color.Transparent
        Me.btn_up.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.up
        Me.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_up.CausesValidation = False
        Me.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_up.Location = New System.Drawing.Point(829, 226)
        Me.btn_up.Name = "btn_up"
        Me.btn_up.Size = New System.Drawing.Size(116, 116)
        Me.btn_up.TabIndex = 9
        Me.btn_up.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.QuizMinecraft.My.Resources.Resources.enxadad
        Me.PictureBox2.Location = New System.Drawing.Point(29, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 166)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'picbox_objeto1
        '
        Me.picbox_objeto1.BackColor = System.Drawing.Color.Transparent
        Me.picbox_objeto1.Image = Global.QuizMinecraft.My.Resources.Resources.stick
        Me.picbox_objeto1.Location = New System.Drawing.Point(577, 234)
        Me.picbox_objeto1.Name = "picbox_objeto1"
        Me.picbox_objeto1.Size = New System.Drawing.Size(130, 130)
        Me.picbox_objeto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_objeto1.TabIndex = 14
        Me.picbox_objeto1.TabStop = False
        '
        'picbox_objeto2
        '
        Me.picbox_objeto2.BackColor = System.Drawing.Color.Transparent
        Me.picbox_objeto2.Image = Global.QuizMinecraft.My.Resources.Resources.stick
        Me.picbox_objeto2.Location = New System.Drawing.Point(577, 234)
        Me.picbox_objeto2.Name = "picbox_objeto2"
        Me.picbox_objeto2.Size = New System.Drawing.Size(130, 130)
        Me.picbox_objeto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_objeto2.TabIndex = 15
        Me.picbox_objeto2.TabStop = False
        '
        'picbox_objeto3
        '
        Me.picbox_objeto3.BackColor = System.Drawing.Color.Transparent
        Me.picbox_objeto3.Image = Global.QuizMinecraft.My.Resources.Resources.diamante
        Me.picbox_objeto3.Location = New System.Drawing.Point(577, 234)
        Me.picbox_objeto3.Name = "picbox_objeto3"
        Me.picbox_objeto3.Size = New System.Drawing.Size(130, 130)
        Me.picbox_objeto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_objeto3.TabIndex = 16
        Me.picbox_objeto3.TabStop = False
        '
        'picbox_objeto4
        '
        Me.picbox_objeto4.BackColor = System.Drawing.Color.Transparent
        Me.picbox_objeto4.Image = Global.QuizMinecraft.My.Resources.Resources.diamante
        Me.picbox_objeto4.Location = New System.Drawing.Point(577, 234)
        Me.picbox_objeto4.Name = "picbox_objeto4"
        Me.picbox_objeto4.Size = New System.Drawing.Size(130, 130)
        Me.picbox_objeto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_objeto4.TabIndex = 17
        Me.picbox_objeto4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'lbl_timer
        '
        Me.lbl_timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_timer.Font = New System.Drawing.Font("Minecraft", 24.0!)
        Me.lbl_timer.Location = New System.Drawing.Point(274, 26)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(449, 50)
        Me.lbl_timer.TabIndex = 18
        Me.lbl_timer.Text = "20 s"
        Me.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.wallpaper2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.lbl_timer)
        Me.Controls.Add(Me.picbox_objeto4)
        Me.Controls.Add(Me.picbox_objeto3)
        Me.Controls.Add(Me.picbox_objeto2)
        Me.Controls.Add(Me.picbox_objeto1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_right)
        Me.Controls.Add(Me.btn_left)
        Me.Controls.Add(Me.btn_down)
        Me.Controls.Add(Me.btn_up)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz Minecraft"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_objeto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_objeto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_objeto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_objeto4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents btn_right As System.Windows.Forms.Button
    Friend WithEvents btn_left As System.Windows.Forms.Button
    Friend WithEvents btn_down As System.Windows.Forms.Button
    Friend WithEvents btn_up As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_objeto1 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_objeto2 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_objeto3 As System.Windows.Forms.PictureBox
    Friend WithEvents picbox_objeto4 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lbl_timer As System.Windows.Forms.Label
End Class
