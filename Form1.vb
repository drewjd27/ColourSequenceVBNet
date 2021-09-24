Public Class ColorSequence
    Dim i As Integer
    Dim j As Integer
    Dim centang, centang1, centang2, centang3, centang4, centang5, centang6, centang7, centang8, centang9, centang10,
        centang11, centang12 As Integer

    Dim skor, skor1, skor2, skor3, skor4, skor5, skor6, skor7, skor8, skor9, skor10,
       skor11, skor12 As Integer
    Dim nilai As Long



    Sub kondisiawal()
        start.Visible = True
        penghitungwaktu.Text = ""
        penghitungpersiapan.Visible = False
        groupboxfixcolors1.Visible = False
        skortotal.Text = ""
        groupboxguesscolor.Visible = False
        SUBMIT.Visible = False
        skortotal.Visible = False
        tryagain.Visible = False
        instruksiawal.Visible = True
        label.Visible = False
        cek1.Checked = False
        cek2.Checked = False
        cek3.Checked = False
        cek4.Checked = False
        cek5.Checked = False
        cek6.Checked = False
        cek7.Checked = False
        cek8.Checked = False
        cek9.Checked = False
        cek10.Checked = False
        cek11.Checked = False
        cek12.Checked = False
        cek1.Enabled = True
        cek2.Enabled = True
        cek3.Enabled = True
        cek4.Enabled = True
        cek5.Enabled = True
        cek6.Enabled = True
        cek7.Enabled = True
        cek8.Enabled = True
        cek9.Enabled = True
        cek10.Enabled = True
        cek11.Enabled = True
        cek12.Enabled = True
    End Sub

    Sub ceklis()
        If cek1.Checked = True Then
            centang1 = 1
        End If

        If cek4.Checked = True Then
            centang2 = 1
        End If

        If cek5.Checked = True Then
            centang3 = 1
        End If

        If cek7.Checked = True Then
            centang4 = 1
        End If

        If cek10.Checked = True Then
            centang5 = 1
        End If

        If cek11.Checked = True Then
            centang6 = 1
        End If

        If cek12.Checked = True Then
            centang7 = 1
        End If

        If cek2.Checked = True Then
            centang8 = 1
        End If

        If cek3.Checked = True Then
            centang9 = 1
        End If

        If cek6.Checked = True Then
            centang10 = 1
        End If

        If cek8.Checked = True Then
            centang11 = 1
        End If

        If cek9.Checked = True Then
            centang12 = 1
        End If

        centang = centang1 + centang2 + centang3 + centang4 + centang5 + centang6 + centang7 + centang8 + centang9 + centang10 + centang11 + centang12

    End Sub

    Sub score()
        If cek1.Checked = True Then
            skor1 = skor1 + 1
        Else
            skor1 = 0
        End If

        If cek4.Checked = True Then
            skor2 = 1
        Else
            skor2 = 0
        End If

        If cek5.Checked = True Then
            skor3 = 1
        Else
            skor3 = 0
        End If

        If cek7.Checked = True Then
            skor4 = 1
        Else
            skor4 = 0
        End If

        If cek10.Checked = True Then
            skor5 = 1
        Else
            skor5 = 0
        End If

        If cek11.Checked = True Then
            skor6 = 1
        Else
            skor6 = 0
        End If

        If cek12.Checked = True Then
            skor7 = 1
        Else
            skor7 = 0
        End If

        If cek2.Checked = True Then
            skor8 = 0
        Else
            skor8 = 0
        End If

        If cek3.Checked = True Then
            skor9 = 0
        Else
            skor9 = 0
        End If

        If cek6.Checked = True Then
            skor10 = 0
        Else
            skor10 = 0
        End If

        If cek8.Checked = True Then
            skor11 = 0
        Else
            skor11 = 0
        End If

        If cek9.Checked = True Then
            skor12 = 0
        Else
            skor12 = 0
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click

        start.Visible = False
        instruksiawal.Visible = False
        penghitungpersiapan.Visible = True

        Timer1.Start()
        i = 3
        Timer1.Interval = 1000

        If i = 0 Then
            Timer2.Interval = 1000
            penghitungwaktu.Text = j
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i -= 1
        If i = 2 Then
            penghitungpersiapan.Text = "SET!"
        End If

        If i = 1 Then
            penghitungpersiapan.Text = "MEMORIZE!"
        End If

        If i = 0 Then
            j = 8
            Timer2.Start()
            penghitungpersiapan.Visible = False
            groupboxfixcolors1.Visible = True
        End If

        If penghitungwaktu.Text = "0" Then
            groupboxfixcolors1.Visible = False
            groupboxguesscolor.Visible = True
            SUBMIT.Visible = True
            penghitungwaktu.Text = "TIME'S UP"
        End If

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        j -= 1
        penghitungwaktu.Text = j

        If j = 0 Then
            Timer2.Stop()
        End If
    End Sub
    Private Sub SUBMIT_Click(sender As Object, e As EventArgs) Handles SUBMIT.Click
        Call score()
        Call ceklis()

        skor = skor1 + skor2 + skor3 + skor4 + skor5 + skor6 + skor7 + skor8 + skor9 + skor10 + skor11 + skor12
        If centang > 7 Then
            MessageBox.Show("You're not allowed to check more than 7 checkboxes", "Attention")

        Else
            If skor <= 0 Then
                nilai = 0
                skortotal.Text = 0
                skortotal.Visible = True
                label.Visible = True
                tryagain.Visible = True
                cek1.Enabled = False
                cek2.Enabled = False
                cek3.Enabled = False
                cek4.Enabled = False
                cek5.Enabled = False
                cek6.Enabled = False
                cek7.Enabled = False
                cek8.Enabled = False
                cek9.Enabled = False
                cek10.Enabled = False
                cek11.Enabled = False
                cek12.Enabled = False
                SUBMIT.Visible = False
            Else
                nilai = skor * 100 / 7
                skortotal.Text = nilai
                skortotal.Visible = True
                label.Visible = True
                tryagain.Visible = True
                cek1.Enabled = False
                cek2.Enabled = False
                cek3.Enabled = False
                cek4.Enabled = False
                cek5.Enabled = False
                cek6.Enabled = False
                cek7.Enabled = False
                cek8.Enabled = False
                cek9.Enabled = False
                cek10.Enabled = False
                cek11.Enabled = False
                cek12.Enabled = False
                SUBMIT.Visible = False
            End If
        End If



    End Sub

    Private Sub tryagain_Click(sender As Object, e As EventArgs) Handles tryagain.Click
        Call kondisiawal()
    End Sub
End Class
