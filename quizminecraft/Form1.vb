Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_crafting.BackColor = Color.FromArgb(198, 198, 198)
        lbl_redstone.BackColor = Color.FromArgb(198, 198, 198)
        lbl_crafting.Text = pontos_craft & "/5"
        lbl_redstone.Text = pontos_reds & "/5"

        Form13.Show()


        If pontos_craft = 5 And pontos_reds = 5 Then
            Form12.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btn_crafting_Click(sender As Object, e As EventArgs) Handles btn_crafting.Click
        pontos_craft = 0
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub btn_redstone_Click(sender As Object, e As EventArgs) Handles btn_redstone.Click
        pontos_reds = 0
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub
End Class
