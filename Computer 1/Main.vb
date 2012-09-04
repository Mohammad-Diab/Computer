Imports System.Windows.Forms
Public Class Main
    Dim Intel As Array = {Computer.My.Resources.String032, Computer.My.Resources.String026, Computer.My.Resources.String023, Computer.My.Resources.String019, Computer.My.Resources.String011, Computer.My.Resources.String001}
    Dim AMD As Array = {Computer.My.Resources.String058, Computer.My.Resources.String053, Computer.My.Resources.String044}
    Dim SecondCorei As Array = {Computer.My.Resources.String005, Computer.My.Resources.String004, Computer.My.Resources.String003, Computer.My.Resources.String002}
    Dim Corei As Array = {Computer.My.Resources.String012, Computer.My.Resources.String013, Computer.My.Resources.String014}
    Dim Core2Quad As Array = {Computer.My.Resources.String020, Computer.My.Resources.String021, Computer.My.Resources.String022}
    Dim Core2Duo As Array = {Computer.My.Resources.String024, Computer.My.Resources.String025}
    Dim Pentum As Array = {Computer.My.Resources.String027, Computer.My.Resources.String028, Computer.My.Resources.String029, Computer.My.Resources.String030, Computer.My.Resources.String031}
    Dim Celeron As Array = {Computer.My.Resources.String033}
    Dim Phenom2 As Array = {Computer.My.Resources.String045, Computer.My.Resources.String046, Computer.My.Resources.String047, Computer.My.Resources.String048, Computer.My.Resources.String049, Computer.My.Resources.String050, Computer.My.Resources.String051, Computer.My.Resources.String052}
    Dim Athlon2 As Array = {Computer.My.Resources.String054, Computer.My.Resources.String055, Computer.My.Resources.String056, Computer.My.Resources.String057}
    Dim Sempron As Array = {Computer.My.Resources.String059}
    Dim CeleronBoard As Array = {Computer.My.Resources.String034, Computer.My.Resources.String035, Computer.My.Resources.String039}
    Dim PentumBoard As Array = {Computer.My.Resources.String036, Computer.My.Resources.String037, Computer.My.Resources.String038, Computer.My.Resources.String040, Computer.My.Resources.String041, Computer.My.Resources.String042} 'And Core 2 Dou E7500
    Dim Core2Board As Array = {Computer.My.Resources.String040, Computer.My.Resources.String041, Computer.My.Resources.String042} 'Except Core 2 Dou E7500
    Dim CoreiBoard As Array = {Computer.My.Resources.String015, Computer.My.Resources.String016, Computer.My.Resources.String017, Computer.My.Resources.String018}
    Dim SecondCoreiBoard As Array = {Computer.My.Resources.String006, Computer.My.Resources.String007, Computer.My.Resources.String008, Computer.My.Resources.String009, Computer.My.Resources.String010}
    Dim SempronBoard As Array = {Computer.My.Resources.String070, Computer.My.Resources.String071}
    Dim Athlon2BoardDual As Array = {Computer.My.Resources.String063, Computer.My.Resources.String064, Computer.My.Resources.String065, Computer.My.Resources.String066, Computer.My.Resources.String067, Computer.My.Resources.String068, Computer.My.Resources.String069}
    Dim Athlon2BoardQuad As Array = {Computer.My.Resources.String061, Computer.My.Resources.String062, Computer.My.Resources.String063, Computer.My.Resources.String064, Computer.My.Resources.String065, Computer.My.Resources.String066, Computer.My.Resources.String067, Computer.My.Resources.String068}
    Dim Phenom2Board As Array = {Computer.My.Resources.String060, Computer.My.Resources.String061, Computer.My.Resources.String062}
    Dim DDR2 As Array = {Computer.My.Resources.String076, Computer.My.Resources.String078}
    Dim DDR3 As Array = {Computer.My.Resources.String075, Computer.My.Resources.String076, Computer.My.Resources.String077, Computer.My.Resources.String078}
    Dim SuperDDR3 As Array = {Computer.My.Resources.String075, Computer.My.Resources.String078}
    Dim SuperAMDGraphgic As Array = {Computer.My.Resources.String127, Computer.My.Resources.String128, Computer.My.Resources.String129, Computer.My.Resources.String130, Computer.My.Resources.String131, Computer.My.Resources.String132, Computer.My.Resources.String133} '+GigaByte P45T-ES3G
    Dim SuperNvidiaGraphgic As Array = {Computer.My.Resources.String117, Computer.My.Resources.String118, Computer.My.Resources.String119, Computer.My.Resources.String120, Computer.My.Resources.String121, Computer.My.Resources.String122} '+GigaByte P45T-ES3G
    Dim NormalNvidiaGraphgic As Array = {Computer.My.Resources.String115, Computer.My.Resources.String116, Computer.My.Resources.String117, Computer.My.Resources.String118, Computer.My.Resources.String119}
    Dim NormalAMDGraphgic As Array = {Computer.My.Resources.String125, Computer.My.Resources.String126, Computer.My.Resources.String127, Computer.My.Resources.String128, Computer.My.Resources.String129, Computer.My.Resources.String130}
    Dim BasicAMDGraphgic As Array = {Computer.My.Resources.String124, Computer.My.Resources.String125, Computer.My.Resources.String126}
    Dim BasicNvidiaGraphgic As Array = {Computer.My.Resources.String113, Computer.My.Resources.String114, Computer.My.Resources.String115}
    Dim BasicCase As Array = {Computer.My.Resources.String145, Computer.My.Resources.String144, Computer.My.Resources.String143, Computer.My.Resources.String142}
    Dim ProfissionalCase As Array = {Computer.My.Resources.String143, Computer.My.Resources.String142, Computer.My.Resources.String141, Computer.My.Resources.String140, Computer.My.Resources.String139, Computer.My.Resources.String138, Computer.My.Resources.String137, Computer.My.Resources.String136, Computer.My.Resources.String135}
    Dim Monitor As Array = {"None", Computer.My.Resources.String147, Computer.My.Resources.String148, Computer.My.Resources.String149, Computer.My.Resources.String150, Computer.My.Resources.String151, Computer.My.Resources.String152, Computer.My.Resources.String153, Computer.My.Resources.String154, Computer.My.Resources.String155, Computer.My.Resources.String156, Computer.My.Resources.String157, Computer.My.Resources.String158}
    Dim Mouse As Array = {"None", Computer.My.Resources.String168, Computer.My.Resources.String167, Computer.My.Resources.String166, Computer.My.Resources.String165, Computer.My.Resources.String164, Computer.My.Resources.String163, Computer.My.Resources.String162, Computer.My.Resources.String161, Computer.My.Resources.String160}
    Dim Keyboard As Array = {"None", Computer.My.Resources.String176, Computer.My.Resources.String175, Computer.My.Resources.String174, Computer.My.Resources.String173, Computer.My.Resources.String172, Computer.My.Resources.String171, Computer.My.Resources.String170}
    Dim MousePad As Array = {"None", Computer.My.Resources.String178, Computer.My.Resources.String179, Computer.My.Resources.String180}
    Dim Speaker As Array = {"None", Computer.My.Resources.String186, Computer.My.Resources.String182, Computer.My.Resources.String188, Computer.My.Resources.String187, Computer.My.Resources.String183, Computer.My.Resources.String184, Computer.My.Resources.String185}
    Dim Printer As Array = {"None", Computer.My.Resources.String190, Computer.My.Resources.String191, Computer.My.Resources.String192, Computer.My.Resources.String193, Computer.My.Resources.String194, Computer.My.Resources.String195}
    Dim WebCam As Array = {"None", Computer.My.Resources.String197, Computer.My.Resources.String198, Computer.My.Resources.String199, Computer.My.Resources.String200}
    Dim Bluetooth As Array = {"None", Computer.My.Resources.String202, Computer.My.Resources.String203}
    Dim Scaner As Array = {"None", Computer.My.Resources.String205, Computer.My.Resources.String206, Computer.My.Resources.String207}
    Dim OpticalDriver As Array = {"None", Computer.My.Resources.String209, Computer.My.Resources.String210, Computer.My.Resources.String211}
    Dim CardReader As Array = {"None", Computer.My.Resources.String213, Computer.My.Resources.String214, Computer.My.Resources.String215}
    Public PC As String() = {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"}

    Public Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.ShowDialog()
    End Sub

    Sub Hide1()
        ComboBox12.Enabled = False
        ComboBox12.Items.Clear()
        Button1.Enabled = False
    End Sub

    Sub Hide2()
        ComboBox6.Enabled = False
        ComboBox6.Items.Clear()
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        RadioButton5.Enabled = False
        PictureBox2.Image = Nothing
    End Sub

    Sub Hide3()
        ComboBox10.Enabled = False
        ComboBox11.Enabled = False
        ComboBox10.Items.Clear()
        ComboBox11.Items.Clear()
    End Sub

    Sub Hide4()
        ComboBox4.Enabled = False
        ComboBox7.Enabled = False
        ComboBox8.Enabled = False
        ComboBox4.Items.Clear()
        ComboBox7.Items.Clear()
        ComboBox8.Items.Clear()
    End Sub

    Sub Hide5()
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
    End Sub

    Sub Hide6()
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
        ComboBox22.Items.Clear()
        ComboBox13.Items.Clear()
        ComboBox14.Items.Clear()
        ComboBox15.Items.Clear()
        ComboBox16.Items.Clear()
        ComboBox17.Items.Clear()
        ComboBox18.Items.Clear()
        ComboBox20.Items.Clear()
        ComboBox21.Items.Clear()
        ComboBox19.Items.Clear()
        ComboBox23.Items.Clear()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Confirm.ShowDialog()
    End Sub

    Public Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        Hide5()
        PictureBox1.Image = Computer.My.Resources.Intel
        PC(0) = "Intel"
        ComboBox1.Enabled = True
        ComboBox1.Items.AddRange(Intel)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        Hide5()
        PictureBox1.Image = Computer.My.Resources.AMD
        PC(0) = "AMD"
        ComboBox1.Enabled = True
        ComboBox1.Items.AddRange(AMD)
    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then MsgBox("لم تقم باختيار الشركة! قم بختيار اسم الشركة ثم اختر الموديل", MsgBoxStyle.Information)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        PC(1) = ComboBox1.SelectedItem
        Select Case PC(1)
            Case Computer.My.Resources.String001
                ComboBox2.Items.AddRange(SecondCorei)
            Case Computer.My.Resources.String011
                ComboBox2.Items.AddRange(Corei)
            Case Computer.My.Resources.String019
                ComboBox2.Items.AddRange(Core2Quad)
            Case Computer.My.Resources.String023
                ComboBox2.Items.AddRange(Core2Duo)
            Case Computer.My.Resources.String026
                ComboBox2.Items.AddRange(Pentum)
            Case Computer.My.Resources.String032
                ComboBox2.Items.AddRange(Celeron)
            Case Computer.My.Resources.String044
                ComboBox2.Items.AddRange(Phenom2)
            Case Computer.My.Resources.String053
                ComboBox2.Items.AddRange(Athlon2)
            Case Computer.My.Resources.String058
                ComboBox2.Items.AddRange(Sempron)
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        ComboBox3.Items.Clear()
        ComboBox3.Enabled = True
        PC(2) = ComboBox2.SelectedItem
        Select Case PC(1)
            Case Computer.My.Resources.String001
                ComboBox3.Items.AddRange(SecondCoreiBoard)
            Case Computer.My.Resources.String011
                ComboBox3.Items.AddRange(CoreiBoard)
            Case Computer.My.Resources.String019
                ComboBox3.Items.AddRange(Core2Board)
            Case Computer.My.Resources.String023
                ComboBox3.Items.AddRange(Core2Board)
            Case Computer.My.Resources.String026
                ComboBox3.Items.AddRange(PentumBoard)
            Case Computer.My.Resources.String032
                ComboBox3.Items.AddRange(CeleronBoard)
            Case Computer.My.Resources.String044
                ComboBox3.Items.AddRange(Phenom2Board)
            Case Computer.My.Resources.String053
                ComboBox3.Items.AddRange(Athlon2BoardDual)
            Case Computer.My.Resources.String058
                ComboBox3.Items.AddRange(SempronBoard)
        End Select
        If PC(2) = Computer.My.Resources.String025 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.AddRange(PentumBoard)
        End If
        If PC(2) = Computer.My.Resources.String051 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.AddRange(Athlon2BoardQuad)
        End If
        If PC(2) = Computer.My.Resources.String048 OrElse PC(2) = Computer.My.Resources.String049 OrElse PC(2) = Computer.My.Resources.String050 Then
            ComboBox3.Items.Clear()
            ComboBox3.Items.AddRange(Athlon2BoardQuad)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        ComboBox8.Enabled = True
        PC(3) = ComboBox3.SelectedItem
        ComboBox8.Items.Clear()
        If PC(1) = Computer.My.Resources.String032 Then
            ComboBox8.Items.AddRange(DDR2)
            PC(4) = "DDR2"
        ElseIf PC(2) = Computer.My.Resources.String005 OrElse PC(2) = Computer.My.Resources.String014 OrElse PC(2) = Computer.My.Resources.String045 OrElse PC(2) = Computer.My.Resources.String046 OrElse PC(2) = Computer.My.Resources.String047 Then
            ComboBox8.Items.AddRange(SuperDDR3)
            PC(4) = "DDR3*"
        Else
            ComboBox8.Items.AddRange(DDR3)
            PC(4) = "DDR3"
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        PC(5) = ComboBox8.SelectedItem
        Hide1()
        Hide2()
        Hide3()
        ComboBox7.Enabled = True
        ComboBox4.Enabled = False
        ComboBox7.Items.Clear()
        ComboBox4.Items.Clear()
        If PC(4) = "DDR2" Then
            ComboBox7.Items.Add(Computer.My.Resources.String079)
            ComboBox7.Items.Add(Computer.My.Resources.String080)
        Else
            If PC(4) = "DDR3" Then
                ComboBox7.Items.Add(Computer.My.Resources.String080)
                ComboBox7.Items.Add(Computer.My.Resources.String081)
                ComboBox7.Items.Add(Computer.My.Resources.String082)
            End If
            If PC(4) = "DDR3*" Then
                If PC(5) = Computer.My.Resources.String075 Then
                    ComboBox7.Items.Add(Computer.My.Resources.String082)
                    ComboBox7.Items.Add(Computer.My.Resources.String083)
                    ComboBox7.Items.Add(Computer.My.Resources.String084)
                End If
                If PC(5) = Computer.My.Resources.String078 Then
                    ComboBox7.Items.Add(Computer.My.Resources.String082)
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        Hide1()
        Hide2()
        Hide3()
        ComboBox4.Enabled = True
        ComboBox4.Items.Clear()
        PC(6) = ComboBox7.SelectedItem
        If PC(4) = "DDR2" Then
            If PC(5) = Computer.My.Resources.String076 Then
                ComboBox4.Items.Add(Computer.My.Resources.String086)
            Else
                ComboBox4.Items.Add(Computer.My.Resources.String085)
                ComboBox4.Items.Add(Computer.My.Resources.String086)
            End If
        Else
            If PC(4) = "DDR3" Then
                ComboBox4.Items.Add(Computer.My.Resources.String088)
            End If
            If PC(4) = "DDR3*" Then
                If PC(5) = Computer.My.Resources.String075 Then
                    ComboBox4.Items.Add(Computer.My.Resources.String088)
                End If
                If PC(5) = Computer.My.Resources.String078 Then
                    ComboBox4.Items.Add(Computer.My.Resources.String088)
                    ComboBox4.Items.Add(Computer.My.Resources.String091)
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Hide1()
        Hide2()
        Hide3()
        PC(24) = ComboBox4.SelectedItem
        ComboBox11.Enabled = True
        ComboBox11.Items.Clear()
        If PC(3) = Computer.My.Resources.String006 OrElse PC(3) = Computer.My.Resources.String007 OrElse PC(3) = Computer.My.Resources.String008 OrElse PC(3) = Computer.My.Resources.String060 OrElse PC(3) = Computer.My.Resources.String061 Then
            ComboBox11.Items.Clear()
            ComboBox11.Items.Add(Computer.My.Resources.String094)
            ComboBox11.Items.Add(Computer.My.Resources.String098)
            PC(7) = "3"
        Else
            ComboBox11.Items.Clear()
            PC(7) = "2"
            ComboBox11.Items.Add(Computer.My.Resources.String101)
            ComboBox11.Items.Add(Computer.My.Resources.String103)
            ComboBox11.Items.Add(Computer.My.Resources.String105)
        End If
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        PC(8) = ComboBox11.SelectedItem
        Hide1()
        Hide2()
        ComboBox10.Enabled = True
        ComboBox10.Items.Clear()
        If PC(8) = Computer.My.Resources.String094 Then
            ComboBox10.Items.Clear()
            If PC(7) = "3" Then
                ComboBox10.Items.Add(Computer.My.Resources.String095)
                ComboBox10.Items.Add(Computer.My.Resources.String096)
                ComboBox10.Items.Add(Computer.My.Resources.String097)
            Else
                If PC(7) = "2" Then
                    ComboBox10.Items.Add(Computer.My.Resources.String102)
                End If
            End If
        End If
        If PC(8) = Computer.My.Resources.String098 Then
            If PC(7) = "3" Then
                ComboBox10.Items.Add(Computer.My.Resources.String099)
            Else
                If PC(7) = "2" Then
                    ComboBox10.Items.Add(Computer.My.Resources.String106)
                    ComboBox10.Items.Add(Computer.My.Resources.String107)
                    ComboBox10.Items.Add(Computer.My.Resources.String108)
                    ComboBox10.Items.Add(Computer.My.Resources.String109)
                    ComboBox10.Items.Add(Computer.My.Resources.String110)
                    ComboBox10.Items.Add(Computer.My.Resources.String111)
                End If
            End If
        End If
        If PC(8) = Computer.My.Resources.String103 Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add(Computer.My.Resources.String104)
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        PC(9) = ComboBox10.SelectedItem
        Hide1()
        Hide2()
        ComboBox6.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
    End Sub

    Sub FillCase()
        If PC(3) = Computer.My.Resources.String042 OrElse PC(2) = Computer.My.Resources.String014 OrElse PC(2) = Computer.My.Resources.String045 OrElse PC(2) = Computer.My.Resources.String046 OrElse PC(2) = Computer.My.Resources.String047 OrElse PC(3) = Computer.My.Resources.String060 OrElse PC(3) = Computer.My.Resources.String061 Then
            ComboBox12.Items.AddRange(ProfissionalCase)
        Else
            ComboBox12.Items.AddRange(BasicCase)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Hide1()
        PC(10) = "None"
        ComboBox6.Items.Clear()
        ComboBox6.Enabled = False
        ComboBox12.Enabled = True
        FillCase()
        PictureBox2.Image = Computer.My.Resources.GMA
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Hide1()
        PictureBox2.Image = Computer.My.Resources.AMDGraphic
        PC(10) = "AMD"
        ComboBox6.Enabled = True
        ComboBox6.Items.Clear()
        ComboBox12.Enabled = False
        If PC(1) = Computer.My.Resources.String032 OrElse PC(1) = Computer.My.Resources.String058 Then
            ComboBox6.Items.AddRange(BasicAMDGraphgic)
        ElseIf PC(2) = Computer.My.Resources.String005 OrElse PC(2) = Computer.My.Resources.String014 OrElse PC(2) = Computer.My.Resources.String045 OrElse PC(2) = Computer.My.Resources.String046 OrElse PC(2) = Computer.My.Resources.String047 Then
            ComboBox6.Items.AddRange(SuperAMDGraphgic)
        Else
            ComboBox6.Items.AddRange(NormalAMDGraphgic)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Hide1()
        PictureBox2.Image = Computer.My.Resources.Nvidia
        PC(10) = "Nvidia"
        ComboBox6.Enabled = True
        ComboBox6.Items.Clear()
        ComboBox12.Enabled = False
        If PC(1) = Computer.My.Resources.String032 OrElse PC(1) = Computer.My.Resources.String058 Then
            ComboBox6.Items.AddRange(BasicNvidiaGraphgic)
        ElseIf PC(2) = Computer.My.Resources.String005 OrElse PC(2) = Computer.My.Resources.String014 OrElse PC(2) = Computer.My.Resources.String045 OrElse PC(2) = Computer.My.Resources.String046 OrElse PC(2) = Computer.My.Resources.String047 Then
            ComboBox6.Items.AddRange(SuperNvidiaGraphgic)
        Else
            ComboBox6.Items.AddRange(NormalNvidiaGraphgic)
        End If
    End Sub

    Private Sub ComboBox6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox6.Click
        If RadioButton3.Checked = False AndAlso RadioButton4.Checked = False AndAlso RadioButton5.Checked = False Then MsgBox("أختر أحد الخيارات أعلاه ثم اختر النوع.", MsgBoxStyle.Information)
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        PC(11) = ComboBox6.SelectedItem
        Hide1()
        ComboBox12.Enabled = True
        ComboBox12.Items.Clear()
        FillCase()
    End Sub

    Sub fillother()
        PC(13) = "None"
        PC(14) = "None"
        PC(15) = "None"
        PC(16) = "None"
        PC(17) = "None"
        PC(18) = "None"
        PC(19) = "None"
        PC(20) = "None"
        PC(21) = "None"
        PC(22) = "None"
        PC(23) = "None"
        ComboBox22.Items.Clear()
        ComboBox13.Items.Clear()
        ComboBox14.Items.Clear()
        ComboBox15.Items.Clear()
        ComboBox16.Items.Clear()
        ComboBox17.Items.Clear()
        ComboBox18.Items.Clear()
        ComboBox20.Items.Clear()
        ComboBox21.Items.Clear()
        ComboBox19.Items.Clear()
        ComboBox23.Items.Clear()
        ComboBox13.Enabled = True
        ComboBox14.Enabled = True
        ComboBox15.Enabled = True
        ComboBox16.Enabled = True
        ComboBox17.Enabled = True
        ComboBox18.Enabled = True
        ComboBox19.Enabled = True
        ComboBox20.Enabled = True
        ComboBox21.Enabled = True
        ComboBox22.Enabled = True
        ComboBox23.Enabled = True
        ComboBox22.Items.AddRange(OpticalDriver)
        ComboBox13.Items.AddRange(Monitor)
        ComboBox14.Items.AddRange(Keyboard)
        ComboBox15.Items.AddRange(Mouse)
        ComboBox16.Items.AddRange(MousePad)
        ComboBox17.Items.AddRange(Speaker)
        ComboBox18.Items.AddRange(Printer)
        ComboBox20.Items.AddRange(Bluetooth)
        ComboBox21.Items.AddRange(Scaner)
        ComboBox19.Items.AddRange(WebCam)
        ComboBox23.Items.AddRange(CardReader)
        ComboBox13.SelectedItem = "None"
        ComboBox14.SelectedItem = "None"
        ComboBox15.SelectedItem = "None"
        ComboBox16.SelectedItem = "None"
        ComboBox17.SelectedItem = "None"
        ComboBox18.SelectedItem = "None"
        ComboBox19.SelectedItem = "None"
        ComboBox20.SelectedItem = "None"
        ComboBox21.SelectedItem = "None"
        ComboBox22.SelectedItem = "None"
        ComboBox23.SelectedItem = "None"
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        fillother()
        PC(12) = ComboBox12.SelectedItem
    End Sub

    Private Sub ComboBox22_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox22.SelectedIndexChanged
        PC(13) = ComboBox22.SelectedItem
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox13.SelectedIndexChanged
        PC(14) = ComboBox13.SelectedItem
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox14.SelectedIndexChanged
        PC(15) = ComboBox14.SelectedItem
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox15.SelectedIndexChanged
        PC(16) = ComboBox15.SelectedItem
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox16.SelectedIndexChanged
        PC(17) = ComboBox16.SelectedItem
    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox17.SelectedIndexChanged
        PC(18) = ComboBox17.SelectedItem
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox18.SelectedIndexChanged
        PC(19) = ComboBox18.SelectedItem
    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox20.SelectedIndexChanged
        PC(20) = ComboBox20.SelectedItem
    End Sub

    Private Sub ComboBox21_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox21.SelectedIndexChanged
        PC(21) = ComboBox21.SelectedItem
    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox19.SelectedIndexChanged
        PC(22) = ComboBox19.SelectedItem
    End Sub

    Private Sub ComboBox23_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox23.SelectedIndexChanged
        PC(23) = ComboBox23.SelectedItem
    End Sub

    Sub Rest()
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        Hide5()
        Hide6()
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        For i As Integer = 0 To 24
            PC(i) = "0"
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Result.ShowDialog()
        Rest()
        Rest()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Rest()
        Rest()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Rest()
        Rest()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Confirm.ShowDialog()
    End Sub
End Class