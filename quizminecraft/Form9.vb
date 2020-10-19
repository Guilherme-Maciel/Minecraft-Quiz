Public Class Form9
    Dim sele As Integer = 0
    Dim timer As Integer = 10

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If sele = 0 Then
            btn_select.BackgroundImage = My.Resources.select_on
            sele = 1
        Else
            btn_select.BackgroundImage = My.Resources.select_off
            sele = 0
        End If
    End Sub

    Private Sub btn_pedra_Click(sender As Object, e As EventArgs) Handles btn_pedra.Click
        If sele = 1 Then
            picbox_challe.BackgroundImage = My.Resources.reds3_pedra
            btn_select.Visible = False
            Timer1.Enabled = True
            timer_crono.Enabled = False
            sele = 0
            lbl_msg.Text = "A pedra funcionou mal :("
        End If
    End Sub
    Private Sub btn_bloco_Click(sender As Object, e As EventArgs) Handles btn_bloco.Click
        If sele = 1 Then
            picbox_challe.BackgroundImage = My.Resources.reds3_bloco
            btn_select.Visible = False
            Timer1.Enabled = True
            timer_crono.Enabled = False
            pontos_reds = pontos_reds + 1
            sele = 0
            lbl_msg.Text = "Orgulho... B)"
        End If
    End Sub
    Private Sub btn_redstone_Click(sender As Object, e As EventArgs) Handles btn_redstone.Click
        If sele = 1 Then
            picbox_challe.BackgroundImage = My.Resources.reds3_pedra
            btn_select.Visible = False
            Timer2.Enabled = True
            timer_crono.Enabled = False
            sele = 0
            lbl_msg.Text = "A redstone funcionou mal :("
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub timer_crono_Tick(sender As Object, e As EventArgs) Handles timer_crono.Tick
        If timer <> 0 Then
            timer = timer - 1
            lbl_timer.Text = timer & "s"
        Else
            timer_crono.Enabled = False
            Timer1.Enabled = True
            picbox_challe.BackgroundImage = My.Resources.reds1_rept
            btn_select.Visible = False
            sele = 0
            lbl_msg.Text = "Tempo Esgotado !!! :("

        End If
    End Sub
End Class
