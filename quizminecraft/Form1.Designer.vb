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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_crafting = New System.Windows.Forms.Button()
        Me.btn_redstone = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.lbl_crafting = New System.Windows.Forms.Label()
        Me.lbl_redstone = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.QuizMinecraft.My.Resources.Resources.hello
        Me.PictureBox1.Location = New System.Drawing.Point(581, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 182)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_crafting
        '
        Me.btn_crafting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_crafting.Font = New System.Drawing.Font("Minecraft", 27.75!)
        Me.btn_crafting.Image = Global.QuizMinecraft.My.Resources.Resources.button
        Me.btn_crafting.Location = New System.Drawing.Point(277, 195)
        Me.btn_crafting.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_crafting.Name = "btn_crafting"
        Me.btn_crafting.Size = New System.Drawing.Size(446, 99)
        Me.btn_crafting.TabIndex = 1
        Me.btn_crafting.Text = "CRAFTING          "
        Me.btn_crafting.UseVisualStyleBackColor = True
        '
        'btn_redstone
        '
        Me.btn_redstone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_redstone.Font = New System.Drawing.Font("Minecraft", 27.75!)
        Me.btn_redstone.Image = Global.QuizMinecraft.My.Resources.Resources.button
        Me.btn_redstone.Location = New System.Drawing.Point(277, 314)
        Me.btn_redstone.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_redstone.Name = "btn_redstone"
        Me.btn_redstone.Size = New System.Drawing.Size(446, 99)
        Me.btn_redstone.TabIndex = 2
        Me.btn_redstone.Text = "REDSTONE        "
        Me.btn_redstone.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_end.Image = Global.QuizMinecraft.My.Resources.Resources.button
        Me.btn_end.Location = New System.Drawing.Point(277, 432)
        Me.btn_end.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(446, 99)
        Me.btn_end.TabIndex = 3
        Me.btn_end.Text = "SAIR"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'lbl_crafting
        '
        Me.lbl_crafting.AutoSize = True
        Me.lbl_crafting.BackColor = System.Drawing.Color.Gray
        Me.lbl_crafting.Location = New System.Drawing.Point(580, 223)
        Me.lbl_crafting.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_crafting.Name = "lbl_crafting"
        Me.lbl_crafting.Size = New System.Drawing.Size(65, 37)
        Me.lbl_crafting.TabIndex = 4
        Me.lbl_crafting.Text = "/5"
        '
        'lbl_redstone
        '
        Me.lbl_redstone.AutoSize = True
        Me.lbl_redstone.BackColor = System.Drawing.Color.Gray
        Me.lbl_redstone.Location = New System.Drawing.Point(580, 342)
        Me.lbl_redstone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_redstone.Name = "lbl_redstone"
        Me.lbl_redstone.Size = New System.Drawing.Size(65, 37)
        Me.lbl_redstone.TabIndex = 5
        Me.lbl_redstone.Text = "/5"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.QuizMinecraft.My.Resources.Resources.overworld
        Me.PictureBox2.Location = New System.Drawing.Point(-6, 343)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(279, 218)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.QuizMinecraft.My.Resources.Resources.nether
        Me.PictureBox3.Location = New System.Drawing.Point(725, 342)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(259, 218)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(24.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.wallpaper1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btn_end
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_redstone)
        Me.Controls.Add(Me.lbl_crafting)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_redstone)
        Me.Controls.Add(Me.btn_crafting)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Minecraft", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(12, 8, 12, 8)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz Minecraft"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_crafting As System.Windows.Forms.Button
    Friend WithEvents btn_redstone As System.Windows.Forms.Button
    Friend WithEvents btn_end As System.Windows.Forms.Button
    Friend WithEvents lbl_crafting As System.Windows.Forms.Label
    Friend WithEvents lbl_redstone As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
