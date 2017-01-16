Public Class CalculMental
    Dim niveau As Integer = 0


    Private Sub Button55_Click(sender As Object, e As EventArgs)


        MsgBox("Ton nom est " & TextBox1.Text)
        TextBox1.Visible = False
        Label1.Visible = False

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


    End Sub
    Dim flag1 As Integer = 0
    Dim flag As Integer = 0
    Dim i As Integer = 0
    Dim resultatfinal As Integer





    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CalculMental_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox2.Enabled = False
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



        TextBox2.Visible = False
        PictureBox6.Visible = False
        PictureBox5.Visible = False

        Label1.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label2.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label3.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label4.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label5.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label6.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label7.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label8.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label9.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label10.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label11.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label12.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label13.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label14.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label15.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label16.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label17.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label18.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label19.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label20.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label21.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label22.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label23.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label24.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label25.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label26.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label27.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label28.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label29.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label30.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label31.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label32.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label33.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label34.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label35.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label36.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label37.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label38.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label39.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label40.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label41.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label42.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label43.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label44.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label45.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label46.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label47.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label48.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label49.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label50.Font = New Font("EraserDust", 10, FontStyle.Regular)
        Label51.Font = New Font("EraserDust", 12, FontStyle.Regular)
        Label52.Font = New Font("EraserDust", 14, FontStyle.Regular)


    End Sub
    Dim Seconds As Integer = 0
    Dim temps As Integer = 180
    Private Sub TextBox1_TextChanged_1(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Seconds += 1000
        Dim Test As Integer = 0
        If temps = 0 Then
            temps = 180
        End If
        temps = temps - 1
        Test = Timer2.Interval - Seconds
        Test = Test / 1000
        Label52.Text = "Temps restant : " & temps & " secondes"

        If Test = 0 Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub




    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        niveau = 1
        PictureBox8.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True
        TextBox1.Visible = False
        Label1.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True

        PictureBox3.Visible = False
        PictureBox2.Visible = False
        PictureBox1.Visible = False
        PictureBox4.Visible = False

        TextBox2.Visible = True



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        niveau = 2
        PictureBox8.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True
        TextBox1.Visible = False
        Label1.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True

        PictureBox3.Visible = False
        PictureBox2.Visible = False
        PictureBox1.Visible = False
        PictureBox4.Visible = False

        TextBox2.Visible = True



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        niveau = 3
        PictureBox8.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True
        TextBox1.Visible = False
        Label1.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True

        PictureBox3.Visible = False
        PictureBox2.Visible = False
        PictureBox1.Visible = False
        PictureBox4.Visible = False

        TextBox2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        resultatfinal = Val(TextBox2.Text)
        flag = 1
    End Sub

    Private Sub TextBox2_TextChanged_2(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            resultatfinal = Val(TextBox2.Text)
            TextBox2.Text = ""
            flag = 1
            flag1 = 1
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Dim stopWatch As New Stopwatch()
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim compteur As Integer = 0
        PictureBox6.Visible = False
        Label51.Visible = True
        Label52.Visible = True
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer1.Interval = 1800
        Timer2.Interval = 180000
        Timer3.Interval = 1000
        Timer1.Start()
        temps = 180

        Timer2.Start()


        Timer3.Start()


        Stopwatch.Start()


        If niveau = 1 Then
            Dim random As New Random(), rndnbr As Integer
            Dim a As Integer
            Dim b As Integer
            Dim c As Integer
            Dim alt As Integer
            Dim x As Integer


            TextBox2.Enabled = True

            If i = 0 Then


                Label5.ForeColor = Color.Black


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
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label1.Text = a
                Label3.Text = b
                Label4.Text = "="
                Label5.Text = "?"

                flag1 = 0

                While flag1 = 0
                    Application.DoEvents()

                End While

                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label5.ForeColor = Color.Green
                    PictureBox10.Visible = False
                    PictureBox9.Visible = True
                    Label5.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label5.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label5.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If






            End If


            If i = 1 Then


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
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                Label10.Visible = True

                Label6.Text = a
                Label8.Text = b
                Label9.Text = "="
                Label10.Text = "?"

                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label10.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label10.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label10.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label10.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 2 Then
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
                Label11.Visible = True
                Label12.Visible = True
                Label13.Visible = True

                Label14.Visible = True
                Label15.Visible = True
                Label11.Text = a
                Label13.Text = b
                Label14.Text = "="
                Label15.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label15.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label15.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label15.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label15.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 3 Then
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
                Label16.Visible = True
                Label17.Visible = True
                Label18.Visible = True
                Label19.Visible = True
                Label20.Visible = True
                Label16.Text = a
                Label18.Text = b
                Label19.Text = "="
                Label20.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label20.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label20.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label20.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label20.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 4 Then
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
                Label21.Visible = True
                Label22.Visible = True
                Label23.Visible = True
                Label24.Visible = True
                Label25.Visible = True
                Label21.Text = a
                Label23.Text = b
                Label24.Text = "="
                Label25.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label25.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label25.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label25.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label25.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If

            If i = 5 Then
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
                Label26.Visible = True
                Label27.Visible = True
                Label28.Visible = True
                Label29.Visible = True
                Label30.Visible = True
                Label26.Text = a
                Label28.Text = b
                Label29.Text = "="
                Label30.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label30.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label30.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label30.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label30.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If

            If i = 6 Then
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
                Label31.Visible = True
                Label32.Visible = True
                Label33.Visible = True
                Label34.Visible = True
                Label35.Visible = True
                Label31.Text = a
                Label33.Text = b
                Label34.Text = "="
                Label35.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label35.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label35.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label35.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label35.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 7 Then
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
                Label36.Visible = True
                Label37.Visible = True
                Label38.Visible = True
                Label39.Visible = True
                Label40.Visible = True
                Label36.Text = a
                Label38.Text = b
                Label39.Text = "="
                Label40.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label40.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label40.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label40.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label40.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 8 Then
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
                Label41.Visible = True
                Label42.Visible = True
                Label43.Visible = True
                Label44.Visible = True
                Label45.Visible = True
                Label41.Text = a
                Label43.Text = b
                Label44.Text = "="
                Label45.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label45.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label45.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label45.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label45.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 9 Then
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
                Label46.Visible = True
                Label47.Visible = True
                Label48.Visible = True
                Label49.Visible = True
                Label50.Visible = True
                Label46.Text = a
                Label48.Text = b
                Label49.Text = "="
                Label50.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label50.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label50.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label50.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label50.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
                Dim Test As Integer

                TextBox2.Enabled = False

                Timer2.Stop()
                Test = Timer2.Interval - Seconds
                Test = Test / 1000




                Timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                PictureBox10.Visible = False
                PictureBox9.Visible = False
                If compteur < 5 Then
                    Label51.Text = "Dommage, tu peux retenter ta chance !"
                End If

                If compteur > 4 And compteur <= 9 Then
                    Label51.Text = "Bravo, mais tu peux encore t'améliorer !"
                End If
                If compteur = 10 Then
                    Label51.Text = "Bravo, tu as tout réussi !"
                End If
            End If

        End If

        If niveau = 2 Then
            Dim random As New Random(), rndnbr As Integer
            Dim a As Integer
            Dim b As Integer
            Dim c As Integer
            Dim alt As Integer
            Dim x As Integer


            TextBox2.Enabled = True

            If i = 0 Then


                Label5.ForeColor = Color.Black


                Randomize()
                rndnbr = random.Next(0, 1000)
                a = rndnbr
                rndnbr = random.Next(0, 1000)
                b = rndnbr
                rndnbr = random.Next(0, 11)
                c = 9
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label2.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label2.Text = "/"
                    x = a / b
                End If
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label1.Text = a
                Label3.Text = b
                Label4.Text = "="
                Label5.Text = "?"

                flag1 = 0

                While flag1 = 0
                    Application.DoEvents()

                End While

                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label5.ForeColor = Color.Green
                    PictureBox10.Visible = False
                    PictureBox9.Visible = True
                    Label5.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label5.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label5.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If






            End If


            If i = 1 Then


                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label7.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label7.Text = "/"
                    x = a / b
                End If
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                Label10.Visible = True

                Label6.Text = a
                Label8.Text = b
                Label9.Text = "="
                Label10.Text = "?"

                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label10.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label10.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label10.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label10.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 2 Then
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label12.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label12.Text = "/"
                    x = a / b
                End If
                Label11.Visible = True
                Label12.Visible = True
                Label13.Visible = True

                Label14.Visible = True
                Label15.Visible = True
                Label11.Text = a
                Label13.Text = b
                Label14.Text = "="
                Label15.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label15.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label15.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label15.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label15.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 3 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label17.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label17.Text = "/"
                    x = a / b
                End If
                Label16.Visible = True
                Label17.Visible = True
                Label18.Visible = True
                Label19.Visible = True
                Label20.Visible = True
                Label16.Text = a
                Label18.Text = b
                Label19.Text = "="
                Label20.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label20.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label20.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label20.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label20.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 4 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label22.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label22.Text = "/"
                    x = a / b
                End If
                Label21.Visible = True
                Label22.Visible = True
                Label23.Visible = True
                Label24.Visible = True
                Label25.Visible = True
                Label21.Text = a
                Label23.Text = b
                Label24.Text = "="
                Label25.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label25.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label25.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label25.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label25.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If

            If i = 5 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label27.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label27.Text = "/"
                    x = a / b
                End If
                Label26.Visible = True
                Label27.Visible = True
                Label28.Visible = True
                Label29.Visible = True
                Label30.Visible = True
                Label26.Text = a
                Label28.Text = b
                Label29.Text = "="
                Label30.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label30.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label30.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label30.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label30.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If

            If i = 6 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label32.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label32.Text = "/"
                    x = a / b
                End If
                Label31.Visible = True
                Label32.Visible = True
                Label33.Visible = True
                Label34.Visible = True
                Label35.Visible = True
                Label31.Text = a
                Label33.Text = b
                Label34.Text = "="
                Label35.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label35.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label35.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label35.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label35.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 7 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label37.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label37.Text = "/"
                    x = a / b
                End If
                Label36.Visible = True
                Label37.Visible = True
                Label38.Visible = True
                Label39.Visible = True
                Label40.Visible = True
                Label36.Text = a
                Label38.Text = b
                Label39.Text = "="
                Label40.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label40.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label40.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label40.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label40.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 8 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label42.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label42.Text = "/"
                    x = a / b
                End If
                Label41.Visible = True
                Label42.Visible = True
                Label43.Visible = True
                Label44.Visible = True
                Label45.Visible = True
                Label41.Text = a
                Label43.Text = b
                Label44.Text = "="
                Label45.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label45.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label45.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label45.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label45.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 9 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label47.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(1, 3)
                    alt = rndnbr
                    If alt = 1 Then
                        b = 2
                    ElseIf alt = 2 Then
                        b = 5
                    Else
                        b = 10
                    End If
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(1, 3)
                        alt = rndnbr
                        If alt = 1 Then
                            b = 2
                        ElseIf alt = 2 Then
                            b = 5
                        Else
                            b = 10
                            alt = a Mod b
                        End If
                    End While
                    Label47.Text = "/"
                    x = a / b
                End If
                Label46.Visible = True
                Label47.Visible = True
                Label48.Visible = True
                Label49.Visible = True
                Label50.Visible = True
                Label46.Text = a
                Label48.Text = b
                Label49.Text = "="
                Label50.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label50.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label50.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label50.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label50.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
                Dim Test As Integer

                TextBox2.Enabled = False

                Timer2.Stop()
                Test = Timer2.Interval - Seconds
                Test = Test / 1000




                Timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                PictureBox10.Visible = False
                PictureBox9.Visible = False
                If compteur < 5 Then
                    Label51.Text = "Dommage, tu peux retenter ta chance !"
                End If

                If compteur > 4 And compteur <= 9 Then
                    Label51.Text = "Bravo, mais tu peux encore t'améliorer !"
                End If
                If compteur = 10 Then
                    Label51.Text = "Bravo, tu as tout réussi !"
                End If
            End If

        End If



        If niveau = 3 Then
            Dim random As New Random(), rndnbr As Integer
            Dim a As Integer
            Dim b As Integer
            Dim c As Integer
            Dim alt As Integer
            Dim x As Integer


            TextBox2.Enabled = True

            If i = 0 Then
                Label5.ForeColor = Color.Black


                Randomize()
                rndnbr = random.Next(0, 10000)
                a = rndnbr
                rndnbr = random.Next(0, 10000)
                b = rndnbr
                rndnbr = random.Next(0, 11)
                c = 9
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label2.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While

                    Label2.Text = "/"
                    x = a / b
                End If
                Label1.Visible = True
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label1.Text = a
                Label3.Text = b
                Label4.Text = "="
                Label5.Text = "?"

                flag1 = 0

                While flag1 = 0
                    Application.DoEvents()

                End While

                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label5.ForeColor = Color.Green
                    PictureBox10.Visible = False
                    PictureBox9.Visible = True
                    Label5.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label5.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label5.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If






            End If


            If i = 1 Then


                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label7.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label7.Text = "/"
                    x = a / b
                End If
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                Label10.Visible = True

                Label6.Text = a
                Label8.Text = b
                Label9.Text = "="
                Label10.Text = "?"

                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label10.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label10.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label10.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label10.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 2 Then
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label12.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label12.Text = "/"
                    x = a / b
                End If
                Label11.Visible = True
                Label12.Visible = True
                Label13.Visible = True

                Label14.Visible = True
                Label15.Visible = True
                Label11.Text = a
                Label13.Text = b
                Label14.Text = "="
                Label15.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label15.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label15.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label15.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label15.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 3 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label17.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label17.Text = "/"
                    x = a / b
                End If
                Label16.Visible = True
                Label17.Visible = True
                Label18.Visible = True
                Label19.Visible = True
                Label20.Visible = True
                Label16.Text = a
                Label18.Text = b
                Label19.Text = "="
                Label20.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label20.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label20.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label20.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label20.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 4 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label22.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label22.Text = "/"
                    x = a / b
                End If
                Label21.Visible = True
                Label22.Visible = True
                Label23.Visible = True
                Label24.Visible = True
                Label25.Visible = True
                Label21.Text = a
                Label23.Text = b
                Label24.Text = "="
                Label25.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label25.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label25.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label25.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label25.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If

            If i = 5 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label27.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label27.Text = "/"
                    x = a / b
                End If
                Label26.Visible = True
                Label27.Visible = True
                Label28.Visible = True
                Label29.Visible = True
                Label30.Visible = True
                Label26.Text = a
                Label28.Text = b
                Label29.Text = "="
                Label30.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label30.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label30.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label30.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label30.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If

            If i = 6 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label32.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label32.Text = "/"
                    x = a / b
                End If
                Label31.Visible = True
                Label32.Visible = True
                Label33.Visible = True
                Label34.Visible = True
                Label35.Visible = True
                Label31.Text = a
                Label33.Text = b
                Label34.Text = "="
                Label35.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label35.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label35.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label35.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label35.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If

            End If


            If i = 7 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label37.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label37.Text = "/"
                    x = a / b
                End If
                Label36.Visible = True
                Label37.Visible = True
                Label38.Visible = True
                Label39.Visible = True
                Label40.Visible = True
                Label36.Text = a
                Label38.Text = b
                Label39.Text = "="
                Label40.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label40.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label40.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label40.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label40.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 8 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label42.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label42.Text = "/"
                    x = a / b
                End If
                Label41.Visible = True
                Label42.Visible = True
                Label43.Visible = True
                Label44.Visible = True
                Label45.Visible = True
                Label41.Text = a
                Label43.Text = b
                Label44.Text = "="
                Label45.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label45.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label45.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label45.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label45.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
            End If


            If i = 9 Then
                Randomize()
                rndnbr = random.Next(0, 100)
                a = rndnbr
                rndnbr = random.Next(0, 100)
                b = rndnbr
                rndnbr = random.Next(0, 11)
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
                    rndnbr = random.Next(2, 10)
                    a = rndnbr
                    x = a * b
                    Label47.Text = "*"
                ElseIf c = 9 Or c = 10 Or c = 11 Then
                    rndnbr = random.Next(2, 10)
                    b = rndnbr
                    alt = a Mod b
                    While alt <> 0
                        rndnbr = random.Next(0, 100)
                        a = rndnbr
                        rndnbr = random.Next(2, 10)
                        b = rndnbr
                        alt = a Mod b
                    End While
                    Label47.Text = "/"
                    x = a / b
                End If
                Label46.Visible = True
                Label47.Visible = True
                Label48.Visible = True
                Label49.Visible = True
                Label50.Visible = True
                Label46.Text = a
                Label48.Text = b
                Label49.Text = "="
                Label50.Text = "?"
                flag = 0
                While flag = 0
                    Application.DoEvents()

                End While
                i = i + 1
                If resultatfinal = x Then
                    Label50.ForeColor = Color.Green
                    PictureBox9.Visible = True
                    PictureBox10.Visible = False
                    Label50.Text = x
                    compteur = compteur + 1
                    Label51.Text = "Bravo, tu as trouvé la bonne réponse !"
                Else
                    Label50.ForeColor = Color.Red
                    PictureBox9.Visible = False
                    PictureBox10.Visible = True
                    Label50.Text = x

                    Label51.Text = "Dommage, ce n'est pas la bonne réponse !"


                End If
                Dim Test As Integer

                TextBox2.Enabled = False

                Timer2.Stop()
                Test = Timer2.Interval - Seconds
                Test = Test / 1000




                Timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                PictureBox10.Visible = False
                PictureBox9.Visible = False
                If compteur < 5 Then
                    Label51.Text = "Dommage, tu peux retenter ta chance !"
                End If

                If compteur > 4 And compteur <= 9 Then
                    Label51.Text = "Bravo, mais tu peux encore t'améliorer !"
                End If
                If compteur = 10 Then
                    Label51.Text = "Bravo, tu as tout réussi !"
                End If
            End If

        End If



    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox4.Visible = True
        PictureBox11.Visible = False
        PictureBox10.Visible = False
        PictureBox12.Visible = False
        Label52.Visible = False
        PictureBox9.Visible = False
        Label51.Visible = False
        TextBox1.Visible = True
        PictureBox3.Visible = True
        PictureBox2.Visible = True
        PictureBox1.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False

        TextBox2.Visible = False

        Label51.Text = ""
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
        PictureBox8.Visible = False
        i = 0

    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click

    End Sub
    Dim stpw As New Stopwatch


    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        i = 0

        temps = 180
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False


        Timer1.Interval = 1800
        Timer2.Interval = 180000
        Timer3.Interval = 1000



        TextBox2.Text.DefaultIfEmpty


        Label51.Text = ""
        Label52.Visible = False
        PictureBox10.Visible = False
        PictureBox9.Visible = False
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
        PictureBox6.Visible = True

    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
