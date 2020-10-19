<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.lbl_msg = New System.Windows.Forms.Label()
        Me.picbox_challe = New System.Windows.Forms.PictureBox()
        Me.btn_rept = New System.Windows.Forms.Button()
        Me.btn_pedra = New System.Windows.Forms.Button()
        Me.btn_redstone = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer_crono = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picbox_challe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_msg
        '
        Me.lbl_msg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_msg.Font = New System.Drawing.Font("Minecraft", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.Location = New System.Drawing.Point(12, 21)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(960, 35)
        Me.lbl_msg.TabIndex = 7
        Me.lbl_msg.Text = "Acenda a luz !!!"
        Me.lbl_msg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picbox_challe
        '
        Me.picbox_challe.BackColor = System.Drawing.Color.Transparent
        Me.picbox_challe.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.reds4_lob
        Me.picbox_challe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picbox_challe.Location = New System.Drawing.Point(227, 76)
        Me.picbox_challe.Name = "picbox_challe"
        Me.picbox_challe.Size = New System.Drawing.Size(546, 365)
        Me.picbox_challe.TabIndex = 8
        Me.picbox_challe.TabStop = False
        '
        'btn_rept
        '
        Me.btn_rept.BackColor = System.Drawing.Color.Transparent
        Me.btn_rept.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.repetidor
        Me.btn_rept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_rept.FlatAppearance.BorderSize = 0
        Me.btn_rept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rept.ForeColor = System.Drawing.Color.Transparent
        Me.btn_rept.Location = New System.Drawing.Point(349, 456)
        Me.btn_rept.Name = "btn_rept"
        Me.btn_rept.Size = New System.Drawing.Size(106, 104)
        Me.btn_rept.TabIndex = 11
        Me.btn_rept.UseVisualStyleBackColor = False
        '
        'btn_pedra
        '
        Me.btn_pedra.BackColor = System.Drawing.Color.Transparent
        Me.btn_pedra.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.pedra
        Me.btn_pedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_pedra.FlatAppearance.BorderSize = 0
        Me.btn_pedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pedra.ForeColor = System.Drawing.Color.Transparent
        Me.btn_pedra.Location = New System.Drawing.Point(547, 456)
        Me.btn_pedra.Name = "btn_pedra"
        Me.btn_pedra.Size = New System.Drawing.Size(106, 104)
        Me.btn_pedra.TabIndex = 10
        Me.btn_pedra.UseVisualStyleBackColor = False
        '
        'btn_redstone
        '
        Me.btn_redstone.BackColor = System.Drawing.Color.Transparent
        Me.btn_redstone.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.redstone
        Me.btn_redstone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_redstone.FlatAppearance.BorderSize = 0
        Me.btn_redstone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_redstone.ForeColor = System.Drawing.Color.Transparent
        Me.btn_redstone.Location = New System.Drawing.Point(447, 456)
        Me.btn_redstone.Name = "btn_redstone"
        Me.btn_redstone.Size = New System.Drawing.Size(106, 104)
        Me.btn_redstone.TabIndex = 9
        Me.btn_redstone.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Minecraft", 18.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(709, 501)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Level 4 - Prozinho"
        '
        'lbl_timer
        '
        Me.lbl_timer.AutoSize = True
        Me.lbl_timer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_timer.Font = New System.Drawing.Font("Minecraft", 30.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_timer.ForeColor = System.Drawing.Color.Orange
        Me.lbl_timer.Location = New System.Drawing.Point(54, 498)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(83, 41)
        Me.lbl_timer.TabIndex = 12
        Me.lbl_timer.Text = "10s"
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.Transparent
        Me.btn_select.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.select_off
        Me.btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_select.FlatAppearance.BorderSize = 0
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.ForeColor = System.Drawing.Color.Transparent
        Me.btn_select.Location = New System.Drawing.Point(448, 150)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(44, 44)
        Me.btn_select.TabIndex = 14
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'timer_crono
        '
        Me.timer_crono.Enabled = True
        Me.timer_crono.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuizMinecraft.My.Resources.Resources.wallpaper3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_timer)
        Me.Controls.Add(Me.btn_rept)
        Me.Controls.Add(Me.btn_pedra)
        Me.Controls.Add(Me.btn_redstone)
        Me.Controls.Add(Me.picbox_challe)
        Me.Controls.Add(Me.lbl_msg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz Minecraft"
        CType(Me.picbox_challe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_msg As System.Windows.Forms.Label
    Friend WithEvents picbox_challe As System.Windows.Forms.PictureBox
    Friend WithEvents btn_rept As System.Windows.Forms.Button
    Friend WithEvents btn_pedra As System.Windows.Forms.Button
    Friend WithEvents btn_redstone As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_timer As System.Windows.Forms.Label
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents timer_crono As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
