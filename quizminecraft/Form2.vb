Public Class Form2
    Dim objeto As Integer = 1
    Dim timer As Integer = 20


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picbox_objeto1.BackColor = Color.FromArgb(190, 190, 190)
        picbox_objeto2.BackColor = Color.FromArgb(190, 190, 190)
        picbox_objeto3.BackColor = Color.FromArgb(190, 190, 190)
        picbox_objeto4.BackColor = Color.FromArgb(190, 190, 190)
        picbox_objeto5.BackColor = Color.FromArgb(190, 190, 190)

        picbox_objeto2.Visible = False
        picbox_objeto3.Visible = False
        picbox_objeto4.Visible = False
        picbox_objeto5.Visible = False



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_left.Click
        If objeto = 1 Then
            If picbox_objeto1.Left > 293 Then
                picbox_objeto1.Left = picbox_objeto1.Left - 142
            Else
                picbox_objeto1.Left = picbox_objeto1.Left
            End If
        End If
        If objeto = 2 Then
            If picbox_objeto2.Left > 293 Then
                picbox_objeto2.Left = picbox_objeto2.Left - 142
            Else
                picbox_objeto2.Left = picbox_objeto2.Left
            End If
        End If
        If objeto = 3 Then
            If picbox_objeto3.Left > 293 Then
                picbox_objeto3.Left = picbox_objeto3.Left - 142
            Else
                picbox_objeto3.Left = picbox_objeto3.Left
            End If
        End If
        If objeto = 4 Then
            If picbox_objeto4.Left > 293 Then
                picbox_objeto4.Left = picbox_objeto4.Left - 142
            Else
                picbox_objeto4.Left = picbox_objeto4.Left
            End If
        End If
        If objeto = 5 Then
            If picbox_objeto5.Left > 293 Then
                picbox_objeto5.Left = picbox_objeto5.Left - 142
            Else
                picbox_objeto5.Left = picbox_objeto5.Left
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_right.Click
        If objeto = 1 Then
            If picbox_objeto1.Left < 577 Then
                picbox_objeto1.Left = picbox_objeto1.Left + 142
            Else
                picbox_objeto1.Left = picbox_objeto1.Left
            End If
        End If
        If objeto = 2 Then
            If picbox_objeto2.Left < 577 Then
                picbox_objeto2.Left = picbox_objeto2.Left + 142
            Else
                picbox_objeto2.Left = picbox_objeto2.Left
            End If
        End If
        If objeto = 3 Then
            If picbox_objeto3.Left < 577 Then
                picbox_objeto3.Left = picbox_objeto3.Left + 142
            Else
                picbox_objeto3.Left = picbox_objeto3.Left
            End If
        End If
        If objeto = 4 Then
            If picbox_objeto4.Left < 577 Then
                picbox_objeto4.Left = picbox_objeto4.Left + 142
            Else
                picbox_objeto4.Left = picbox_objeto4.Left
            End If
        End If
        If objeto = 5 Then
            If picbox_objeto5.Left < 577 Then
                picbox_objeto5.Left = picbox_objeto5.Left + 142
            Else
                picbox_objeto5.Left = picbox_objeto5.Left
            End If
        End If

    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        If objeto = 1 Then
            If picbox_objeto1.Top > 92 Then
                picbox_objeto1.Top = picbox_objeto1.Top - 142
            Else
                picbox_objeto1.Top = picbox_objeto1.Top
            End If
        End If
        If objeto = 2 Then
            If picbox_objeto2.Top > 92 Then
                picbox_objeto2.Top = picbox_objeto2.Top - 142
            Else
                picbox_objeto2.Top = picbox_objeto2.Top
            End If
        End If
        If objeto = 3 Then
            If picbox_objeto3.Top > 92 Then
                picbox_objeto3.Top = picbox_objeto3.Top - 142
            Else
                picbox_objeto3.Top = picbox_objeto3.Top
            End If
        End If
        If objeto = 4 Then
            If picbox_objeto4.Top > 92 Then
                picbox_objeto4.Top = picbox_objeto4.Top - 142
            Else
                picbox_objeto4.Top = picbox_objeto4.Top
            End If
        End If
        If objeto = 5 Then
            If picbox_objeto5.Top > 92 Then
                picbox_objeto5.Top = picbox_objeto5.Top -142
            Else
                picbox_objeto5.Top = picbox_objeto5.Top
            End If
        End If

    End Sub

    Private Sub btn_down_Click(sender As Object, e As EventArgs) Handles btn_down.Click
        If objeto = 1 Then
            If picbox_objeto1.Top < 376 Then
                picbox_objeto1.Top = picbox_objeto1.Top + 142
            Else
                picbox_objeto1.Top = picbox_objeto1.Top
            End If
        End If

        If objeto = 2 Then
            If picbox_objeto2.Top < 376 Then
                picbox_objeto2.Top = picbox_objeto2.Top + 142
            Else
                picbox_objeto2.Top = picbox_objeto2.Top

            End If
        End If
        If objeto = 3 Then
            If picbox_objeto3.Top < 376 Then
                picbox_objeto3.Top = picbox_objeto3.Top + 142
            Else
                picbox_objeto3.Top = picbox_objeto3.Top

            End If
        End If
        If objeto = 4 Then
            If picbox_objeto4.Top < 376 Then
                picbox_objeto4.Top = picbox_objeto4.Top + 142
            Else
                picbox_objeto4.Top = picbox_objeto4.Top

            End If
        End If
        If objeto = 5 Then
            If picbox_objeto5.Top < 376 Then
                picbox_objeto5.Top = picbox_objeto5.Top + 142
            Else
                picbox_objeto5.Top = picbox_objeto5.Top

            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If objeto = 1 Then
            If picbox_objeto1.Top = 234 And picbox_objeto1.Left = 435 Then
                picbox_objeto2.Visible = True
                objeto = 2

            ElseIf picbox_objeto1.Top = 376 And picbox_objeto1.Left = 435 Then
                picbox_objeto2.Visible = True
                objeto = 2

            End If
        End If
        If objeto = 2 Then
            If picbox_objeto1.Top = 234 And picbox_objeto2.Top = 376 And picbox_objeto2.Left = 435 Then
                picbox_objeto3.Visible = True
                objeto = 3

            ElseIf picbox_objeto1.Top = 376 And picbox_objeto2.Top = 234 And picbox_objeto2.Left = 435 Then
                picbox_objeto3.Visible = True
                objeto = 3

            End If
        End If
        If objeto = 3 Then
            If picbox_objeto3.Top = 92 And picbox_objeto3.Left = 293 Then
                picbox_objeto4.Visible = True
                objeto = 4

            ElseIf picbox_objeto3.Top = 92 And picbox_objeto3.Left = 435 Then
                picbox_objeto4.Visible = True
                objeto = 4

            ElseIf picbox_objeto3.Top = 92 And picbox_objeto3.Left = 577 Then
                picbox_objeto4.Visible = True
                objeto = 4

            End If
        End If
        If objeto = 4 Then
            If picbox_objeto3.Left = 293 And picbox_objeto4.Left = 435 And picbox_objeto4.Top = 92 Then
                picbox_objeto5.Visible = True
                objeto = 5

            ElseIf picbox_objeto3.Left = 293 And picbox_objeto4.Left = 577 And picbox_objeto4.Top = 92 Then
                picbox_objeto5.Visible = True
                objeto = 5

            ElseIf picbox_objeto3.Left = 435 And picbox_objeto4.Left = 293 And picbox_objeto4.Top = 92 Then
                picbox_objeto5.Visible = True
                objeto = 5

            ElseIf picbox_objeto3.Left = 435 And picbox_objeto4.Left = 577 And picbox_objeto4.Top = 92 Then
                picbox_objeto5.Visible = True
                objeto = 5

            ElseIf picbox_objeto3.Left = 577 And picbox_objeto4.Left = 293 And picbox_objeto4.Top = 92 Then
                picbox_objeto5.Visible = True
                objeto = 5

            ElseIf picbox_objeto3.Left = 577 And picbox_objeto4.Left = 435 And picbox_objeto4.Top = 92 Then
                picbox_objeto5.Visible = True
                objeto = 5
            End If
        End If
        If objeto = 5 Then
            If (picbox_objeto3.Left = 293 And picbox_objeto4.Left = 435 Or picbox_objeto3.Left = 435 And picbox_objeto4.Left = 293) And picbox_objeto5.Left = 577 And picbox_objeto5.Top = 92 Then
                objeto = 5
                pontos_craft = pontos_craft + 1
                Form3.Show()
                Me.Close()
            ElseIf (picbox_objeto3.Left = 435 And picbox_objeto4.Left = 577 Or picbox_objeto3.Left = 577 And picbox_objeto4.Left = 435) And picbox_objeto5.Left = 293 And picbox_objeto5.Top = 92 Then
                objeto = 5
                pontos_craft = pontos_craft + 1
                Form3.Show()
                Me.Close()
            ElseIf (picbox_objeto3.Left = 293 And picbox_objeto4.Left = 577 Or picbox_objeto3.Left = 577 And picbox_objeto4.Left = 293) And picbox_objeto5.Left = 435 And picbox_objeto5.Top = 92 Then
                objeto = 5
                pontos_craft = pontos_craft + 1
                Form3.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If timer <> 0 Then
            timer = timer - 1
            lbl_timer.Text = timer & "s"
        Else
            Timer1.Enabled = False
            picbox_objeto2.Visible = True
            picbox_objeto3.Visible = True
            picbox_objeto4.Visible = True
            picbox_objeto5.Visible = True


            picbox_objeto1.Top = 376
            picbox_objeto1.Left = 435
            picbox_objeto2.Top = 234
            picbox_objeto2.Left = 435
            picbox_objeto3.Top = 92
            picbox_objeto3.Left = 577
            picbox_objeto4.Top = 92
            picbox_objeto4.Left = 435
            picbox_objeto5.Top = 92
            picbox_objeto5.Left = 293
            objeto = 0
            Timer2.Enabled = True
            lbl_timer.Text = "Tempo Esgotado !!! :("

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Form3.Show()
        Me.Close()
    End Sub
End Class