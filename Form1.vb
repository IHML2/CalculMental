Public Class CalculMental


    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Dim toppings As String = ""
        If RadioButton4.Checked = True Then
            toppings &= "CE1 "
        End If
        If RadioButton5.Checked = True Then
            toppings &= "CE2-CM1 "
        End If
        If RadioButton6.Checked = True Then
            toppings &= "CM2"
        End If
        If toppings <> "" Then
            MsgBox("Tu es : " & toppings)
        End If

        MsgBox("Ton nom est " & TextBox1.Text)
        TextBox1.Visible = False
        Label1.Visible = False
        RadioButton4.Visible = False
        RadioButton5.Visible = False
        RadioButton6.Visible = False
        Button55.Visible = False

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True

        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True
        Label30.Visible = True
        Label31.Visible = True
        Label32.Visible = True
        Label33.Visible = True
        Label34.Visible = True
        Label35.Visible = True
        Label36.Visible = True
        Label37.Visible = True
        Label38.Visible = True
        Label39.Visible = True
        Label40.Visible = True
        Label41.Visible = True
        Label42.Visible = True
        Label43.Visible = True
        Label44.Visible = True
        Label45.Visible = True
        Label46.Visible = True
        Label47.Visible = True
        Label48.Visible = True
        Label49.Visible = True
        Label50.Visible = True
        Button1.Visible = True


        Timer1.Interval = 1800
        Timer1.Enabled = True
        Timer1.Start()
        Timer2.Interval = 180000
        Timer2.Enabled = True
        Timer2.Start()
        Timer3.Interval = 1000
        Timer3.Enabled = True
        Timer3.Start()


    End Sub

    Dim i As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim random As New Random(), rndnbr As Integer
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim alt As Integer
        Dim x As Double
        If i = 0 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label2.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label2.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label2.Text = "*"
            End If
            Label1.Text = a
            Label3.Text = b
            Label4.Text = "="
            Label5.Text = x
            i = i + 1
        ElseIf i = 1 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label7.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label7.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label7.Text = "*"
            End If
            Label6.Text = a
            Label8.Text = b
            Label9.Text = "="
            Label10.Text = x
            i = i + 1
        ElseIf i = 2 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label12.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label12.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label12.Text = "*"
            End If
            Label11.Text = a
            Label13.Text = b
            Label14.Text = "="
            Label15.Text = x
            i = i + 1
        ElseIf i = 3 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label17.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label17.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label17.Text = "*"
            End If
            Label16.Text = a
            Label18.Text = b
            Label19.Text = "="
            Label20.Text = x
            i = i + 1
        ElseIf i = 4 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label22.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label22.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label22.Text = "*"
            End If
            Label21.Text = a
            Label23.Text = b
            Label24.Text = "="
            Label25.Text = x
            i = i + 1
        ElseIf i = 5 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label27.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label27.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label27.Text = "*"
            End If
            Label26.Text = a
            Label28.Text = b
            Label29.Text = "="
            Label30.Text = x
            i = i + 1
        ElseIf i = 6 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label32.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label32.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label32.Text = "*"
            End If
            Label31.Text = a
            Label33.Text = b
            Label34.Text = "="
            Label35.Text = x
            i = i + 1
        ElseIf i = 7 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label37.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label37.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label37.Text = "*"
            End If
            Label36.Text = a
            Label38.Text = b
            Label39.Text = "="
            Label40.Text = x
            i = i + 1
        ElseIf i = 8 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label42.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label42.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label42.Text = "*"
            End If
            Label41.Text = a
            Label43.Text = b
            Label44.Text = "="
            Label45.Text = x
            i = i + 1
        ElseIf i = 9 Then
            Randomize()
            rndnbr = random.Next(0, 100)
            a = rndnbr
            rndnbr = random.Next(0, 100)
            b = rndnbr
            rndnbr = random.Next(0, 8)
            c = rndnbr
            If c = 0 Or c = 3 Or c = 6 Then
                x = a + b
                Label47.Text = "+"
            ElseIf c = 1 Or c = 4 Or c = 7 Then
                If a - b < 0 Then
                    alt = a
                    a = b
                    b = alt
                End If
                x = a - b
                Label47.Text = "-"
            ElseIf c = 2 Or c = 5 Or c = 8 Then
                rndnbr = random.Next(2, 5)
                a = rndnbr
                x = a * b
                Label47.Text = "*"
            End If
            Label46.Text = a
            Label48.Text = b
            Label49.Text = "="
            Label50.Text = x
            Dim Test As Integer

            i = i + 1

            Timer2.Stop()
            Test = Timer2.Interval - Seconds
            Test = Test / 1000

            MsgBox("Il te restait : " & Test & "secondes.")


            Timer1.Stop()

        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 0 Then
            Timer1.Stop()
            Timer2.Stop()
            MsgBox("Le temps est terminé")

        End If
        ProgressBar1.Value = ProgressBar1.Value - 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CalculMental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False

        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False
        Label36.Visible = False
        Label37.Visible = False
        Label38.Visible = False
        Label39.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label42.Visible = False
        Label43.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False
        Label49.Visible = False
        Label50.Visible = False
        Button1.Visible = False

    End Sub
    Dim Seconds As Integer = 0
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Seconds += 1000
    End Sub
End Class
