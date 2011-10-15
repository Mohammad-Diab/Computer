Public Class Form1
    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then ComboBox20.Enabled = True Else ComboBox20.Enabled = False
        If CheckBox9.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then ComboBox21.Enabled = True Else ComboBox21.Enabled = False
        If CheckBox10.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then ComboBox22.Enabled = True Else ComboBox22.Enabled = False
        If CheckBox12.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then ComboBox23.Enabled = True Else ComboBox23.Enabled = False
        If CheckBox11.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then ComboBox19.Enabled = True Else ComboBox19.Enabled = False
        If CheckBox8.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then ComboBox18.Enabled = True Else ComboBox18.Enabled = False
        If CheckBox7.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then ComboBox17.Enabled = True Else ComboBox17.Enabled = False
        If CheckBox6.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then ComboBox16.Enabled = True Else ComboBox16.Enabled = False
        If CheckBox5.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then ComboBox15.Enabled = True Else ComboBox15.Enabled = False
        If CheckBox4.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then ComboBox14.Enabled = True Else ComboBox14.Enabled = False
        If CheckBox3.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then ComboBox13.Enabled = True Else ComboBox13.Enabled = False
        If CheckBox2.Checked Then Button1.Enabled = False Else Button1.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then ComboBox12.Enabled = True Else ComboBox12.Enabled = False
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            PictureBox1.Image = Computer.My.Resources.Intel
            CPUC.Text = "Intel"
            ComboBox1.Enabled = True
            ComboBox1.Items.Add(Computer.My.Resources.String001)
            ComboBox1.Items.Add(Computer.My.Resources.String011)
            ComboBox1.Items.Add(Computer.My.Resources.String019)
            ComboBox1.Items.Add(Computer.My.Resources.String023)
            ComboBox1.Items.Add(Computer.My.Resources.String026)
            ComboBox1.Items.Add(Computer.My.Resources.String032)
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            RadioButton5.Enabled = False
            PictureBox1.Image = Computer.My.Resources.Amd
            CPUC.Text = "AMD"
            ComboBox1.Enabled = True
            ComboBox1.Items.Add(Computer.My.Resources.String044)
            ComboBox1.Items.Add(Computer.My.Resources.String053)
            ComboBox1.Items.Add(Computer.My.Resources.String058)
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        RamC.Text = ComboBox8.SelectedItem
        ComboBox7.Enabled = True
        ComboBox8.Enabled = False
        If DDR.Text = "DDR2" Then
            If RamC.Text = Computer.My.Resources.String076 Then
                ComboBox4.Items.Add(Computer.My.Resources.String086)
            Else
                ComboBox4.Items.Add(Computer.My.Resources.String085)
                ComboBox4.Items.Add(Computer.My.Resources.String086)
            End If
        Else
            If DDR.Text = "DDR3" Then
                ComboBox7.Items.Add(Computer.My.Resources.String080)
                ComboBox7.Items.Add(Computer.My.Resources.String081)
                ComboBox7.Items.Add(Computer.My.Resources.String082)
                ComboBox4.Items.Add(Computer.My.Resources.String088)
            End If
            If DDR.Text = "DDR3*" Then
                If RamC.Text = Computer.My.Resources.String075 Then
                    ComboBox7.Items.Add(Computer.My.Resources.String082)
                    ComboBox7.Items.Add(Computer.My.Resources.String083)
                    ComboBox7.Items.Add(Computer.My.Resources.String084)
                    ComboBox4.Items.Add(Computer.My.Resources.String088)
                End If
                If RamC.Text = Computer.My.Resources.String078 Then
                    ComboBox7.Items.Add(Computer.My.Resources.String082)
                    ComboBox4.Items.Add(Computer.My.Resources.String088)
                    ComboBox4.Items.Add(Computer.My.Resources.String091)
                End If
            End If
        End If
    End Sub


    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        HDC.Text = ComboBox11.SelectedItem
        ComboBox10.Enabled = True
        ComboBox11.Enabled = False
        If HDC.Text = Computer.My.Resources.String094 Then
            ComboBox10.Items.Clear()
            If Sata.Text = "3" Then
                ComboBox10.Items.Add(Computer.My.Resources.String095)
                ComboBox10.Items.Add(Computer.My.Resources.String096)
                ComboBox10.Items.Add(Computer.My.Resources.String097)
            Else
                If Sata.Text = "2" Then
                    ComboBox10.Items.Add(Computer.My.Resources.String102)
                End If
            End If
        End If
        If HDC.Text = Computer.My.Resources.String098 Then
            If Sata.Text = "3" Then
                ComboBox10.Items.Add(Computer.My.Resources.String099)
            Else
                If Sata.Text = "2" Then
                    ComboBox10.Items.Add(Computer.My.Resources.String106)
                    ComboBox10.Items.Add(Computer.My.Resources.String107)
                    ComboBox10.Items.Add(Computer.My.Resources.String108)
                    ComboBox10.Items.Add(Computer.My.Resources.String109)
                    ComboBox10.Items.Add(Computer.My.Resources.String110)
                    ComboBox10.Items.Add(Computer.My.Resources.String111)
                End If
            End If
        End If
        If HDC.Text = Computer.My.Resources.String103 Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add(Computer.My.Resources.String104)
        End If
    End Sub





    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        PictureBox2.Image = Computer.My.Resources.GMA
        GPUC.Text = "0"
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        CheckBox1.Enabled = True
        ComboBox13.Items.Add(Computer.My.Resources.String147)
        ComboBox13.Items.Add(Computer.My.Resources.String148)
        ComboBox13.Items.Add(Computer.My.Resources.String149)
        ComboBox13.Items.Add(Computer.My.Resources.String150)
        ComboBox13.Items.Add(Computer.My.Resources.String151)
        ComboBox13.Items.Add(Computer.My.Resources.String152)
        ComboBox13.Items.Add(Computer.My.Resources.String153)
        ComboBox13.Items.Add(Computer.My.Resources.String154)
        ComboBox13.Items.Add(Computer.My.Resources.String155)
        ComboBox13.Items.Add(Computer.My.Resources.String156)
        ComboBox13.Items.Add(Computer.My.Resources.String157)
        ComboBox13.Items.Add(Computer.My.Resources.String158)
        ComboBox14.Items.Add(Computer.My.Resources.String160)
        ComboBox14.Items.Add(Computer.My.Resources.String161)
        ComboBox14.Items.Add(Computer.My.Resources.String162)
        ComboBox14.Items.Add(Computer.My.Resources.String163)
        ComboBox14.Items.Add(Computer.My.Resources.String164)
        ComboBox14.Items.Add(Computer.My.Resources.String165)
        ComboBox14.Items.Add(Computer.My.Resources.String166)
        ComboBox14.Items.Add(Computer.My.Resources.String167)
        ComboBox14.Items.Add(Computer.My.Resources.String168)
        ComboBox15.Items.Add(Computer.My.Resources.String170)
        ComboBox15.Items.Add(Computer.My.Resources.String171)
        ComboBox15.Items.Add(Computer.My.Resources.String172)
        ComboBox15.Items.Add(Computer.My.Resources.String173)
        ComboBox15.Items.Add(Computer.My.Resources.String174)
        ComboBox15.Items.Add(Computer.My.Resources.String175)
        ComboBox15.Items.Add(Computer.My.Resources.String176)
        ComboBox16.Items.Add(Computer.My.Resources.String178)
        ComboBox16.Items.Add(Computer.My.Resources.String179)
        ComboBox16.Items.Add(Computer.My.Resources.String180)
        ComboBox17.Items.Add(Computer.My.Resources.String182)
        ComboBox17.Items.Add(Computer.My.Resources.String183)
        ComboBox17.Items.Add(Computer.My.Resources.String184)
        ComboBox17.Items.Add(Computer.My.Resources.String185)
        ComboBox17.Items.Add(Computer.My.Resources.String186)
        ComboBox17.Items.Add(Computer.My.Resources.String187)
        ComboBox17.Items.Add(Computer.My.Resources.String188)
        ComboBox18.Items.Add(Computer.My.Resources.String190)
        ComboBox18.Items.Add(Computer.My.Resources.String191)
        ComboBox18.Items.Add(Computer.My.Resources.String192)
        ComboBox18.Items.Add(Computer.My.Resources.String193)
        ComboBox18.Items.Add(Computer.My.Resources.String194)
        ComboBox18.Items.Add(Computer.My.Resources.String195)
        ComboBox19.Items.Add(Computer.My.Resources.String197)
        ComboBox19.Items.Add(Computer.My.Resources.String198)
        ComboBox19.Items.Add(Computer.My.Resources.String199)
        ComboBox19.Items.Add(Computer.My.Resources.String200)
        ComboBox20.Items.Add(Computer.My.Resources.String202)
        ComboBox20.Items.Add(Computer.My.Resources.String203)
        ComboBox21.Items.Add(Computer.My.Resources.String205)
        ComboBox21.Items.Add(Computer.My.Resources.String206)
        ComboBox21.Items.Add(Computer.My.Resources.String207)
        ComboBox22.Items.Add(Computer.My.Resources.String209)
        ComboBox22.Items.Add(Computer.My.Resources.String210)
        ComboBox22.Items.Add(Computer.My.Resources.String211)
        ComboBox23.Items.Add(Computer.My.Resources.String213)
        ComboBox23.Items.Add(Computer.My.Resources.String214)
        ComboBox23.Items.Add(Computer.My.Resources.String215)
        If Model.Text = Computer.My.Resources.String032 Or Model.Text = Computer.My.Resources.String058 Then
            ComboBox12.Items.Add(Computer.My.Resources.String143)
            ComboBox12.Items.Add(Computer.My.Resources.String144)
            ComboBox12.Items.Add(Computer.My.Resources.String145)
        End If
        If Prcessor.Text = Computer.My.Resources.String047 Or
            Prcessor.Text = Computer.My.Resources.String046 Or
            Prcessor.Text = Computer.My.Resources.String045 Or
            Prcessor.Text = Computer.My.Resources.String014 Or
            Prcessor.Text = Computer.My.Resources.String005 Then
            ComboBox12.Items.Add(Computer.My.Resources.String135)
            ComboBox12.Items.Add(Computer.My.Resources.String136)
            ComboBox12.Items.Add(Computer.My.Resources.String137)
            ComboBox12.Items.Add(Computer.My.Resources.String138)
            ComboBox12.Items.Add(Computer.My.Resources.String139)
            ComboBox12.Items.Add(Computer.My.Resources.String140)
            ComboBox12.Items.Add(Computer.My.Resources.String141)
        End If
        If Prcessor.Text = Computer.My.Resources.String002 Or
            Prcessor.Text = Computer.My.Resources.String003 Or
            Prcessor.Text = Computer.My.Resources.String004 Or
            Prcessor.Text = Computer.My.Resources.String012 Or
            Prcessor.Text = Computer.My.Resources.String013 Or
            Prcessor.Text = Computer.My.Resources.String048 Or
            Prcessor.Text = Computer.My.Resources.String049 Or
            Prcessor.Text = Computer.My.Resources.String050 Or
            Prcessor.Text = Computer.My.Resources.String051 Or
            Board.Text = Computer.My.Resources.String042 Or
            Prcessor.Text = Computer.My.Resources.String052 Then
            ComboBox12.Items.Add(Computer.My.Resources.String138)
            ComboBox12.Items.Add(Computer.My.Resources.String139)
            ComboBox12.Items.Add(Computer.My.Resources.String140)
            ComboBox12.Items.Add(Computer.My.Resources.String141)
            ComboBox12.Items.Add(Computer.My.Resources.String142)
        End If
        If Model.Text = Computer.My.Resources.String026 Or
             Model.Text = Computer.My.Resources.String053 Or
             Prcessor.Text = Computer.My.Resources.String025 Then
            ComboBox12.Items.Add(Computer.My.Resources.String141)
            ComboBox12.Items.Add(Computer.My.Resources.String142)
            ComboBox12.Items.Add(Computer.My.Resources.String143)
            ComboBox12.Items.Add(Computer.My.Resources.String144)
            ComboBox12.Items.Add(Computer.My.Resources.String145)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox2.Image = Computer.My.Resources.AMDR
        GPUC.Text = "AMD"
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        ComboBox6.Enabled = True
        ComboBox6.Items.Clear()
        If Model.Text = Computer.My.Resources.String032 Then
            ComboBox6.Items.Add(Computer.My.Resources.String124)
            ComboBox6.Items.Add(Computer.My.Resources.String125)
            ComboBox6.Items.Add(Computer.My.Resources.String126)
        End If
        If Model.Text = Computer.My.Resources.String019 Or
            Model.Text = Computer.My.Resources.String023 Then
            ComboBox6.Items.Add(Computer.My.Resources.String127)
            ComboBox6.Items.Add(Computer.My.Resources.String128)
            ComboBox6.Items.Add(Computer.My.Resources.String129)
            ComboBox6.Items.Add(Computer.My.Resources.String130)
        End If
        If Model.Text = Computer.My.Resources.String026 Or
            Model.Text = Computer.My.Resources.String053 Or
            Model.Text = Computer.My.Resources.String058 Then
            ComboBox6.Items.Add(Computer.My.Resources.String125)
            ComboBox6.Items.Add(Computer.My.Resources.String126)
            ComboBox6.Items.Add(Computer.My.Resources.String127)
            ComboBox6.Items.Add(Computer.My.Resources.String128)
        End If
        If Prcessor.Text = Computer.My.Resources.String002 Or
            Prcessor.Text = Computer.My.Resources.String003 Or
            Prcessor.Text = Computer.My.Resources.String004 Or
            Prcessor.Text = Computer.My.Resources.String012 Or
            Prcessor.Text = Computer.My.Resources.String013 Or
            Prcessor.Text = Computer.My.Resources.String048 Or
            Prcessor.Text = Computer.My.Resources.String049 Or
            Prcessor.Text = Computer.My.Resources.String050 Or
            Prcessor.Text = Computer.My.Resources.String051 Or
            Prcessor.Text = Computer.My.Resources.String052 Then
            ComboBox6.Items.Add(Computer.My.Resources.String128)
            ComboBox6.Items.Add(Computer.My.Resources.String129)
            ComboBox6.Items.Add(Computer.My.Resources.String130)
            ComboBox6.Items.Add(Computer.My.Resources.String131)
        End If
        If Prcessor.Text = Computer.My.Resources.String005 Or
            Prcessor.Text = Computer.My.Resources.String014 Or
            Prcessor.Text = Computer.My.Resources.String045 Or
            Prcessor.Text = Computer.My.Resources.String046 Or
            Prcessor.Text = Computer.My.Resources.String047 Then
            ComboBox6.Items.Add(Computer.My.Resources.String129)
            ComboBox6.Items.Add(Computer.My.Resources.String130)
            ComboBox6.Items.Add(Computer.My.Resources.String131)
            ComboBox6.Items.Add(Computer.My.Resources.String132)
            ComboBox6.Items.Add(Computer.My.Resources.String133)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox2.Image = Computer.My.Resources.Nvidia
        GPUC.Text = "Nvidia"
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        ComboBox6.Enabled = True
        ComboBox6.Items.Clear()
        If Model.Text = Computer.My.Resources.String032 Then
            ComboBox6.Items.Add(Computer.My.Resources.String113)
            ComboBox6.Items.Add(Computer.My.Resources.String114)
            ComboBox6.Items.Add(Computer.My.Resources.String115)
        End If
        If Model.Text = Computer.My.Resources.String019 Or
            Model.Text = Computer.My.Resources.String023 Then
            ComboBox6.Items.Add(Computer.My.Resources.String116)
            ComboBox6.Items.Add(Computer.My.Resources.String117)
            ComboBox6.Items.Add(Computer.My.Resources.String118)
            ComboBox6.Items.Add(Computer.My.Resources.String119)
        End If
        If Model.Text = Computer.My.Resources.String026 Or
            Model.Text = Computer.My.Resources.String053 Or
            Model.Text = Computer.My.Resources.String058 Then
            ComboBox6.Items.Add(Computer.My.Resources.String113)
            ComboBox6.Items.Add(Computer.My.Resources.String116)
            ComboBox6.Items.Add(Computer.My.Resources.String117)
        End If
        If Prcessor.Text = Computer.My.Resources.String002 Or
            Prcessor.Text = Computer.My.Resources.String003 Or
            Prcessor.Text = Computer.My.Resources.String004 Or
            Prcessor.Text = Computer.My.Resources.String012 Or
            Prcessor.Text = Computer.My.Resources.String013 Or
            Prcessor.Text = Computer.My.Resources.String048 Or
            Prcessor.Text = Computer.My.Resources.String049 Or
            Prcessor.Text = Computer.My.Resources.String050 Or
            Prcessor.Text = Computer.My.Resources.String051 Or
            Prcessor.Text = Computer.My.Resources.String052 Then
            ComboBox6.Items.Add(Computer.My.Resources.String117)
            ComboBox6.Items.Add(Computer.My.Resources.String118)
            ComboBox6.Items.Add(Computer.My.Resources.String119)
            ComboBox6.Items.Add(Computer.My.Resources.String120)
        End If
        If Prcessor.Text = Computer.My.Resources.String005 Or
            Prcessor.Text = Computer.My.Resources.String014 Or
            Prcessor.Text = Computer.My.Resources.String045 Or
            Prcessor.Text = Computer.My.Resources.String046 Or
            Prcessor.Text = Computer.My.Resources.String047 Then
            ComboBox6.Items.Add(Computer.My.Resources.String118)
            ComboBox6.Items.Add(Computer.My.Resources.String119)
            ComboBox6.Items.Add(Computer.My.Resources.String120)
            ComboBox6.Items.Add(Computer.My.Resources.String121)
            ComboBox6.Items.Add(Computer.My.Resources.String122)
        End If
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then MsgBox("You didn't Chose Any CPU Corporation!")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Enabled = True
        Model.Text = ComboBox1.SelectedItem
        ComboBox3.Items.Clear()
        If Model.Text = Computer.My.Resources.String001 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String002)
            ComboBox2.Items.Add(Computer.My.Resources.String003)
            ComboBox2.Items.Add(Computer.My.Resources.String004)
            ComboBox2.Items.Add(Computer.My.Resources.String005)
        End If
        If Model.Text = Computer.My.Resources.String011 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String012)
            ComboBox2.Items.Add(Computer.My.Resources.String013)
            ComboBox2.Items.Add(Computer.My.Resources.String014)
        End If
        If Model.Text = Computer.My.Resources.String019 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String020)
            ComboBox2.Items.Add(Computer.My.Resources.String021)
            ComboBox2.Items.Add(Computer.My.Resources.String022)
        End If
        If Model.Text = Computer.My.Resources.String023 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String024)
            ComboBox2.Items.Add(Computer.My.Resources.String025)
        End If
        If Model.Text = Computer.My.Resources.String026 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String027)
            ComboBox2.Items.Add(Computer.My.Resources.String028)
            ComboBox2.Items.Add(Computer.My.Resources.String029)
            ComboBox2.Items.Add(Computer.My.Resources.String030)
            ComboBox2.Items.Add(Computer.My.Resources.String031)
        End If
        If Model.Text = Computer.My.Resources.String032 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String033)
        End If
        If Model.Text = Computer.My.Resources.String044 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String045)
            ComboBox2.Items.Add(Computer.My.Resources.String046)
            ComboBox2.Items.Add(Computer.My.Resources.String047)
            ComboBox2.Items.Add(Computer.My.Resources.String048)
            ComboBox2.Items.Add(Computer.My.Resources.String049)
            ComboBox2.Items.Add(Computer.My.Resources.String050)
            ComboBox2.Items.Add(Computer.My.Resources.String051)
            ComboBox2.Items.Add(Computer.My.Resources.String052)
        End If
        If Model.Text = Computer.My.Resources.String053 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String054)
            ComboBox2.Items.Add(Computer.My.Resources.String055)
            ComboBox2.Items.Add(Computer.My.Resources.String056)
            ComboBox2.Items.Add(Computer.My.Resources.String057)
        End If
        If Model.Text = Computer.My.Resources.String058 Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add(Computer.My.Resources.String059)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Enabled = True
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        Prcessor.Text = ComboBox2.SelectedItem
        If Model.Text = Computer.My.Resources.String032 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String034)
            ComboBox3.Items.Add(Computer.My.Resources.String035)
            ComboBox3.Items.Add(Computer.My.Resources.String039)
        End If
        If Model.Text = Computer.My.Resources.String026 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String036)
            ComboBox3.Items.Add(Computer.My.Resources.String037)
            ComboBox3.Items.Add(Computer.My.Resources.String038)
            ComboBox3.Items.Add(Computer.My.Resources.String040)
            ComboBox3.Items.Add(Computer.My.Resources.String041)
        End If
        If Prcessor.Text = Computer.My.Resources.String025 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String036)
            ComboBox3.Items.Add(Computer.My.Resources.String037)
            ComboBox3.Items.Add(Computer.My.Resources.String038)
            ComboBox3.Items.Add(Computer.My.Resources.String040)
            ComboBox3.Items.Add(Computer.My.Resources.String041)
            ComboBox3.Items.Add(Computer.My.Resources.String042)
        End If
        If Prcessor.Text = Computer.My.Resources.String024 Or
            Prcessor.Text = Computer.My.Resources.String020 Or
            Prcessor.Text = Computer.My.Resources.String021 Or
            Prcessor.Text = Computer.My.Resources.String022 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String042)
        End If
        If Model.Text = Computer.My.Resources.String011 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String015)
            ComboBox3.Items.Add(Computer.My.Resources.String016)
            ComboBox3.Items.Add(Computer.My.Resources.String017)
            ComboBox3.Items.Add(Computer.My.Resources.String018)
        End If
        If Model.Text = Computer.My.Resources.String001 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String006)
            ComboBox3.Items.Add(Computer.My.Resources.String007)
            ComboBox3.Items.Add(Computer.My.Resources.String008)
            ComboBox3.Items.Add(Computer.My.Resources.String009)
            ComboBox3.Items.Add(Computer.My.Resources.String010)
        End If
        If Prcessor.Text = Computer.My.Resources.String045 Or
          Prcessor.Text = Computer.My.Resources.String046 Or
          Prcessor.Text = Computer.My.Resources.String047 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String060)
            ComboBox3.Items.Add(Computer.My.Resources.String061)
            ComboBox3.Items.Add(Computer.My.Resources.String062)
        End If
        If Prcessor.Text = Computer.My.Resources.String048 Or
         Prcessor.Text = Computer.My.Resources.String049 Or
         Prcessor.Text = Computer.My.Resources.String050 Or
         Prcessor.Text = Computer.My.Resources.String051 Or
         Prcessor.Text = Computer.My.Resources.String052 Or
         Prcessor.Text = Computer.My.Resources.String054 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String061)
            ComboBox3.Items.Add(Computer.My.Resources.String062)
            ComboBox3.Items.Add(Computer.My.Resources.String063)
            ComboBox3.Items.Add(Computer.My.Resources.String064)
            ComboBox3.Items.Add(Computer.My.Resources.String065)
            ComboBox3.Items.Add(Computer.My.Resources.String066)
            ComboBox3.Items.Add(Computer.My.Resources.String067)
            ComboBox3.Items.Add(Computer.My.Resources.String068)
        End If
        If Prcessor.Text = Computer.My.Resources.String055 Or
          Prcessor.Text = Computer.My.Resources.String056 Or
          Prcessor.Text = Computer.My.Resources.String057 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String063)
            ComboBox3.Items.Add(Computer.My.Resources.String064)
            ComboBox3.Items.Add(Computer.My.Resources.String065)
            ComboBox3.Items.Add(Computer.My.Resources.String066)
            ComboBox3.Items.Add(Computer.My.Resources.String067)
            ComboBox3.Items.Add(Computer.My.Resources.String068)
            ComboBox3.Items.Add(Computer.My.Resources.String069)
        End If
        If Prcessor.Text = Computer.My.Resources.String059 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.Add(Computer.My.Resources.String070)
            ComboBox3.Items.Add(Computer.My.Resources.String071)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Board.Text = ComboBox3.SelectedItem
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox8.Enabled = True
        If Model.Text = Computer.My.Resources.String032 Then
            ComboBox8.Items.Clear()
            ComboBox7.Items.Clear()
            ComboBox8.Items.Add(Computer.My.Resources.String076)
            ComboBox8.Items.Add(Computer.My.Resources.String078)
            ComboBox7.Items.Add(Computer.My.Resources.String079)
            ComboBox7.Items.Add(Computer.My.Resources.String080)
            DDR.Text = "DDR2"
        Else
            If Model.Text = Computer.My.Resources.String058 Or
            Model.Text = Computer.My.Resources.String053 Or
            Model.Text = Computer.My.Resources.String026 Or
            Model.Text = Computer.My.Resources.String023 Or
            Model.Text = Computer.My.Resources.String019 Or
            Prcessor.Text = Computer.My.Resources.String002 Or
            Prcessor.Text = Computer.My.Resources.String003 Or
            Prcessor.Text = Computer.My.Resources.String004 Or
            Prcessor.Text = Computer.My.Resources.String012 Or
            Prcessor.Text = Computer.My.Resources.String013 Or
            Prcessor.Text = Computer.My.Resources.String048 Or
            Prcessor.Text = Computer.My.Resources.String049 Or
            Prcessor.Text = Computer.My.Resources.String050 Or
            Prcessor.Text = Computer.My.Resources.String051 Or
            Prcessor.Text = Computer.My.Resources.String052 Then
                DDR.Text = "DDR3"
                ComboBox8.Items.Add(Computer.My.Resources.String075)
                ComboBox8.Items.Add(Computer.My.Resources.String076)
                ComboBox8.Items.Add(Computer.My.Resources.String077)
                ComboBox8.Items.Add(Computer.My.Resources.String078)
            Else
                If Prcessor.Text = Computer.My.Resources.String005 Or
             Prcessor.Text = Computer.My.Resources.String014 Or
             Prcessor.Text = Computer.My.Resources.String045 Or
             Prcessor.Text = Computer.My.Resources.String046 Or
             Prcessor.Text = Computer.My.Resources.String047 Then
                    DDR.Text = "DDR3*"
                    ComboBox8.Items.Add(Computer.My.Resources.String075)
                    ComboBox8.Items.Add(Computer.My.Resources.String078)
                End If
            End If
        End If
    End Sub



    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        RamB.Text = ComboBox4.SelectedItem
        ComboBox4.Enabled = False
        ComboBox11.Enabled = True
        If Board.Text = Computer.My.Resources.String006 Or
            Board.Text = Computer.My.Resources.String007 Or
            Board.Text = Computer.My.Resources.String008 Or
            Board.Text = Computer.My.Resources.String060 Or
            Board.Text = Computer.My.Resources.String061 Then
            ComboBox11.Items.Clear()
            ComboBox11.Items.Add(Computer.My.Resources.String094)
            ComboBox11.Items.Add(Computer.My.Resources.String098)
            Sata.Text = "3"
        Else
            ComboBox11.Items.Clear()
            Sata.Text = "2"
            ComboBox11.Items.Add(Computer.My.Resources.String101)
            ComboBox11.Items.Add(Computer.My.Resources.String103)
            ComboBox11.Items.Add(Computer.My.Resources.String105)

        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        RamS.Text = ComboBox7.SelectedItem
        ComboBox4.Enabled = True
        ComboBox7.Enabled = False
        If RamC.Text = Computer.My.Resources.String076 And Model.Text = Computer.My.Resources.String032 Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add(Computer.My.Resources.String086)
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        HDM.Text = ComboBox10.SelectedItem
        ComboBox10.Enabled = False
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        ComboBox6.Enabled = False
        GPUM.Text = ComboBox6.SelectedItem
        CheckBox1.Enabled = True
        ComboBox13.Items.Add(Computer.My.Resources.String147)
        ComboBox13.Items.Add(Computer.My.Resources.String148)
        ComboBox13.Items.Add(Computer.My.Resources.String149)
        ComboBox13.Items.Add(Computer.My.Resources.String150)
        ComboBox13.Items.Add(Computer.My.Resources.String151)
        ComboBox13.Items.Add(Computer.My.Resources.String152)
        ComboBox13.Items.Add(Computer.My.Resources.String153)
        ComboBox13.Items.Add(Computer.My.Resources.String154)
        ComboBox13.Items.Add(Computer.My.Resources.String155)
        ComboBox13.Items.Add(Computer.My.Resources.String156)
        ComboBox13.Items.Add(Computer.My.Resources.String157)
        ComboBox13.Items.Add(Computer.My.Resources.String158)
        ComboBox14.Items.Add(Computer.My.Resources.String160)
        ComboBox14.Items.Add(Computer.My.Resources.String161)
        ComboBox14.Items.Add(Computer.My.Resources.String162)
        ComboBox14.Items.Add(Computer.My.Resources.String163)
        ComboBox14.Items.Add(Computer.My.Resources.String164)
        ComboBox14.Items.Add(Computer.My.Resources.String165)
        ComboBox14.Items.Add(Computer.My.Resources.String166)
        ComboBox14.Items.Add(Computer.My.Resources.String167)
        ComboBox14.Items.Add(Computer.My.Resources.String168)
        ComboBox15.Items.Add(Computer.My.Resources.String170)
        ComboBox15.Items.Add(Computer.My.Resources.String171)
        ComboBox15.Items.Add(Computer.My.Resources.String172)
        ComboBox15.Items.Add(Computer.My.Resources.String173)
        ComboBox15.Items.Add(Computer.My.Resources.String174)
        ComboBox15.Items.Add(Computer.My.Resources.String175)
        ComboBox15.Items.Add(Computer.My.Resources.String176)
        ComboBox16.Items.Add(Computer.My.Resources.String178)
        ComboBox16.Items.Add(Computer.My.Resources.String179)
        ComboBox16.Items.Add(Computer.My.Resources.String180)
        ComboBox17.Items.Add(Computer.My.Resources.String182)
        ComboBox17.Items.Add(Computer.My.Resources.String183)
        ComboBox17.Items.Add(Computer.My.Resources.String184)
        ComboBox17.Items.Add(Computer.My.Resources.String185)
        ComboBox17.Items.Add(Computer.My.Resources.String186)
        ComboBox17.Items.Add(Computer.My.Resources.String187)
        ComboBox17.Items.Add(Computer.My.Resources.String188)
        ComboBox18.Items.Add(Computer.My.Resources.String190)
        ComboBox18.Items.Add(Computer.My.Resources.String191)
        ComboBox18.Items.Add(Computer.My.Resources.String192)
        ComboBox18.Items.Add(Computer.My.Resources.String193)
        ComboBox18.Items.Add(Computer.My.Resources.String194)
        ComboBox18.Items.Add(Computer.My.Resources.String195)
        ComboBox19.Items.Add(Computer.My.Resources.String197)
        ComboBox19.Items.Add(Computer.My.Resources.String198)
        ComboBox19.Items.Add(Computer.My.Resources.String199)
        ComboBox19.Items.Add(Computer.My.Resources.String200)
        ComboBox20.Items.Add(Computer.My.Resources.String202)
        ComboBox20.Items.Add(Computer.My.Resources.String203)
        ComboBox21.Items.Add(Computer.My.Resources.String205)
        ComboBox21.Items.Add(Computer.My.Resources.String206)
        ComboBox21.Items.Add(Computer.My.Resources.String207)
        ComboBox22.Items.Add(Computer.My.Resources.String209)
        ComboBox22.Items.Add(Computer.My.Resources.String210)
        ComboBox22.Items.Add(Computer.My.Resources.String211)
        ComboBox23.Items.Add(Computer.My.Resources.String213)
        ComboBox23.Items.Add(Computer.My.Resources.String214)
        ComboBox23.Items.Add(Computer.My.Resources.String215)
        If Model.Text = Computer.My.Resources.String032 Or Model.Text = Computer.My.Resources.String058 Then
            ComboBox12.Items.Add(Computer.My.Resources.String143)
            ComboBox12.Items.Add(Computer.My.Resources.String144)
            ComboBox12.Items.Add(Computer.My.Resources.String145)
        End If
        If Prcessor.Text = Computer.My.Resources.String047 Or
            Prcessor.Text = Computer.My.Resources.String046 Or
            Prcessor.Text = Computer.My.Resources.String045 Or
            Prcessor.Text = Computer.My.Resources.String014 Or
            Prcessor.Text = Computer.My.Resources.String005 Then
            ComboBox12.Items.Add(Computer.My.Resources.String135)
            ComboBox12.Items.Add(Computer.My.Resources.String136)
            ComboBox12.Items.Add(Computer.My.Resources.String137)
            ComboBox12.Items.Add(Computer.My.Resources.String138)
            ComboBox12.Items.Add(Computer.My.Resources.String139)
            ComboBox12.Items.Add(Computer.My.Resources.String140)
            ComboBox12.Items.Add(Computer.My.Resources.String141)
        End If
        If Prcessor.Text = Computer.My.Resources.String002 Or
            Prcessor.Text = Computer.My.Resources.String003 Or
            Prcessor.Text = Computer.My.Resources.String004 Or
            Prcessor.Text = Computer.My.Resources.String012 Or
            Prcessor.Text = Computer.My.Resources.String013 Or
            Prcessor.Text = Computer.My.Resources.String048 Or
            Prcessor.Text = Computer.My.Resources.String049 Or
            Prcessor.Text = Computer.My.Resources.String050 Or
            Prcessor.Text = Computer.My.Resources.String051 Or
            Board.Text = Computer.My.Resources.String042 Or
            Prcessor.Text = Computer.My.Resources.String052 Then
            ComboBox12.Items.Add(Computer.My.Resources.String138)
            ComboBox12.Items.Add(Computer.My.Resources.String139)
            ComboBox12.Items.Add(Computer.My.Resources.String140)
            ComboBox12.Items.Add(Computer.My.Resources.String141)
            ComboBox12.Items.Add(Computer.My.Resources.String142)
        End If
        If Model.Text = Computer.My.Resources.String026 Or
             Model.Text = Computer.My.Resources.String053 Or
             Prcessor.Text = Computer.My.Resources.String025 Then
            ComboBox12.Items.Add(Computer.My.Resources.String141)
            ComboBox12.Items.Add(Computer.My.Resources.String142)
            ComboBox12.Items.Add(Computer.My.Resources.String143)
            ComboBox12.Items.Add(Computer.My.Resources.String144)
            ComboBox12.Items.Add(Computer.My.Resources.String145)
        End If
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        Cace.Text = ComboBox12.SelectedItem
        CheckBox1.Enabled = False
        ComboBox12.Enabled = False
        Button1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True
        CheckBox6.Enabled = True
        CheckBox7.Enabled = True
        CheckBox8.Enabled = True
        CheckBox9.Enabled = True
        CheckBox10.Enabled = True
        CheckBox11.Enabled = True
        CheckBox12.Enabled = True
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox13.SelectedIndexChanged
        Monitor.Text = ComboBox13.SelectedItem
        CheckBox2.Enabled = False
        ComboBox13.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox14.SelectedIndexChanged
        Keyboard.Text = ComboBox14.SelectedItem
        CheckBox3.Enabled = False
        ComboBox14.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox15.SelectedIndexChanged
        Mouse.Text = ComboBox15.SelectedItem
        CheckBox4.Enabled = False
        ComboBox15.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox16.SelectedIndexChanged
        MousePad.Text = ComboBox16.SelectedItem
        CheckBox5.Enabled = False
        ComboBox16.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox17.SelectedIndexChanged
        Sperakers.Text = ComboBox17.SelectedItem
        CheckBox6.Enabled = False
        ComboBox17.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox18.SelectedIndexChanged
        Printer.Text = ComboBox18.SelectedItem
        CheckBox7.Enabled = False
        ComboBox18.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox19.SelectedIndexChanged
        Camera.Text = ComboBox19.SelectedItem
        CheckBox8.Enabled = False
        ComboBox19.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox20.SelectedIndexChanged
        Bluetooth.Text = ComboBox20.SelectedItem
        CheckBox9.Enabled = False
        ComboBox20.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox21_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox21.SelectedIndexChanged
        Scanner.Text = ComboBox21.SelectedItem
        CheckBox10.Enabled = False
        ComboBox21.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox22_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox22.SelectedIndexChanged
        OpticalDriver.Text = ComboBox22.SelectedItem
        CheckBox12.Enabled = False
        ComboBox22.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox23_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox23.SelectedIndexChanged
        Cardreader.Text = ComboBox23.SelectedItem
        CheckBox11.Enabled = False
        ComboBox23.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form2.ShowDialog()
        Button1.Enabled = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        ComboBox10.Enabled = False
        ComboBox11.Enabled = False
        ComboBox12.Enabled = False
        ComboBox13.Enabled = False
        ComboBox14.Enabled = False
        ComboBox15.Enabled = False
        ComboBox16.Enabled = False
        ComboBox17.Enabled = False
        ComboBox18.Enabled = False
        ComboBox19.Enabled = False
        ComboBox20.Enabled = False
        ComboBox21.Enabled = False
        ComboBox22.Enabled = False
        ComboBox23.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        ComboBox6.Enabled = False
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox6.Items.Clear()
        ComboBox7.Items.Clear()
        ComboBox8.Items.Clear()
        ComboBox10.Items.Clear()
        ComboBox11.Items.Clear()
        ComboBox12.Items.Clear()
        ComboBox13.Items.Clear()
        ComboBox14.Items.Clear()
        ComboBox15.Items.Clear()
        ComboBox16.Items.Clear()
        ComboBox17.Items.Clear()
        ComboBox18.Items.Clear()
        ComboBox19.Items.Clear()
        ComboBox20.Items.Clear()
        ComboBox21.Items.Clear()
        ComboBox22.Items.Clear()
        ComboBox23.Items.Clear()
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        CheckBox10.Enabled = False
        CheckBox11.Enabled = False
        CheckBox12.Enabled = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        Model.Text = "0"
        Prcessor.Text = "0"
        Board.Text = "0"
        RamB.Text = "0"
        RamC.Text = "0"
        RamS.Text = "0"
        HDC.Text = "0"
        HDM.Text = "0"
        Sata.Text = "0"
        CPUC.Text = "0"
        GPUC.Text = "0"
        GPUM.Text = "0"
        Cace.Text = "0"
        Monitor.Text = "0"
        Keyboard.Text = "0"
        Mouse.Text = "0"
        MousePad.Text = "0"
        Sperakers.Text = "0"
        Printer.Text = "0"
        Camera.Text = "0"
        Bluetooth.Text = "0"
        Scanner.Text = "0"
        OpticalDriver.Text = "0"
        Cardreader.Text = "0"
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RadioButton1.Checked = False
        Button1.Enabled = False
        RadioButton2.Checked = False
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        ComboBox10.Enabled = False
        ComboBox11.Enabled = False
        ComboBox12.Enabled = False
        ComboBox13.Enabled = False
        ComboBox14.Enabled = False
        ComboBox15.Enabled = False
        ComboBox16.Enabled = False
        ComboBox17.Enabled = False
        ComboBox18.Enabled = False
        ComboBox19.Enabled = False
        ComboBox20.Enabled = False
        ComboBox21.Enabled = False
        ComboBox22.Enabled = False
        ComboBox23.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        ComboBox6.Enabled = False
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox6.Items.Clear()
        ComboBox7.Items.Clear()
        ComboBox8.Items.Clear()
        ComboBox10.Items.Clear()
        ComboBox11.Items.Clear()
        ComboBox12.Items.Clear()
        ComboBox13.Items.Clear()
        ComboBox14.Items.Clear()
        ComboBox15.Items.Clear()
        ComboBox16.Items.Clear()
        ComboBox17.Items.Clear()
        ComboBox18.Items.Clear()
        ComboBox19.Items.Clear()
        ComboBox20.Items.Clear()
        ComboBox21.Items.Clear()
        ComboBox22.Items.Clear()
        ComboBox23.Items.Clear()
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        CheckBox10.Enabled = False
        CheckBox11.Enabled = False
        CheckBox12.Enabled = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        Model.Text = "0"
        Prcessor.Text = "0"
        Board.Text = "0"
        RamB.Text = "0"
        RamC.Text = "0"
        RamS.Text = "0"
        HDC.Text = "0"
        HDM.Text = "0"
        Sata.Text = "0"
        CPUC.Text = "0"
        GPUC.Text = "0"
        GPUM.Text = "0"
        Cace.Text = "0"
        Monitor.Text = "0"
        Keyboard.Text = "0"
        Mouse.Text = "0"
        MousePad.Text = "0"
        Sperakers.Text = "0"
        Printer.Text = "0"
        Camera.Text = "0"
        Bluetooth.Text = "0"
        Scanner.Text = "0"
        OpticalDriver.Text = "0"
        Cardreader.Text = "0"
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        RadioButton1.Checked = False
        Button1.Enabled = False
        RadioButton2.Checked = False
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        ComboBox1.Enabled = True
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        ComboBox10.Enabled = False
        ComboBox11.Enabled = False
        ComboBox12.Enabled = False
        ComboBox13.Enabled = False
        ComboBox14.Enabled = False
        ComboBox15.Enabled = False
        ComboBox16.Enabled = False
        ComboBox17.Enabled = False
        ComboBox18.Enabled = False
        ComboBox19.Enabled = False
        ComboBox20.Enabled = False
        ComboBox21.Enabled = False
        ComboBox22.Enabled = False
        ComboBox23.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        ComboBox6.Enabled = False
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox6.Items.Clear()
        ComboBox7.Items.Clear()
        ComboBox8.Items.Clear()
        ComboBox10.Items.Clear()
        ComboBox11.Items.Clear()
        ComboBox12.Items.Clear()
        ComboBox13.Items.Clear()
        ComboBox14.Items.Clear()
        ComboBox15.Items.Clear()
        ComboBox16.Items.Clear()
        ComboBox17.Items.Clear()
        ComboBox18.Items.Clear()
        ComboBox19.Items.Clear()
        ComboBox20.Items.Clear()
        ComboBox21.Items.Clear()
        ComboBox22.Items.Clear()
        ComboBox23.Items.Clear()
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        CheckBox10.Enabled = False
        CheckBox11.Enabled = False
        CheckBox12.Enabled = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        Model.Text = "0"
        Prcessor.Text = "0"
        Board.Text = "0"
        RamB.Text = "0"
        RamC.Text = "0"
        RamS.Text = "0"
        HDC.Text = "0"
        HDM.Text = "0"
        Sata.Text = "0"
        CPUC.Text = "0"
        GPUC.Text = "0"
        GPUM.Text = "0"
        Cace.Text = "0"
        Monitor.Text = "0"
        Keyboard.Text = "0"
        Mouse.Text = "0"
        MousePad.Text = "0"
        Sperakers.Text = "0"
        Printer.Text = "0"
        Camera.Text = "0"
        Bluetooth.Text = "0"
        Scanner.Text = "0"
        OpticalDriver.Text = "0"
        Cardreader.Text = "0"
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm1.ShowDialog()
    End Sub
End Class
