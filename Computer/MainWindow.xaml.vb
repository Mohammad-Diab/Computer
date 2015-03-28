Imports System.IO

Class MainWindow
    Dim Intel As Array = {Computer.My.Resources.String032, Computer.My.Resources.String026, Computer.My.Resources.String023, Computer.My.Resources.String019, Computer.My.Resources.String011, Computer.My.Resources.String001}
    Dim AMD As Array = {Computer.My.Resources.String058, Computer.My.Resources.String053, Computer.My.Resources.String044}
    Public Shared SecondCorei As Array = {Computer.My.Resources.String005, Computer.My.Resources.String004, Computer.My.Resources.String003, Computer.My.Resources.String002}
    Public Shared Corei As Array = {Computer.My.Resources.String012, Computer.My.Resources.String013, Computer.My.Resources.String014}
    Public Shared Core2Quad As Array = {Computer.My.Resources.String020, Computer.My.Resources.String021, Computer.My.Resources.String022}
    Public Shared Core2Duo As Array = {Computer.My.Resources.String024, Computer.My.Resources.String025}
    Public Shared Pentum As Array = {Computer.My.Resources.String027, Computer.My.Resources.String028, Computer.My.Resources.String029, Computer.My.Resources.String030, Computer.My.Resources.String031}
    Public Shared Celeron As Array = {Computer.My.Resources.String033}
    Public Shared Phenom2 As Array = {Computer.My.Resources.String045, Computer.My.Resources.String046, Computer.My.Resources.String047, Computer.My.Resources.String048, Computer.My.Resources.String049, Computer.My.Resources.String050, Computer.My.Resources.String051, Computer.My.Resources.String052}
    Public Shared Athlon2 As Array = {Computer.My.Resources.String054, Computer.My.Resources.String055, Computer.My.Resources.String056, Computer.My.Resources.String057}
    Public Shared Sempron As Array = {Computer.My.Resources.String059}
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
    Dim ProfissionalCase As Array = {Computer.My.Resources.String142, Computer.My.Resources.String141, Computer.My.Resources.String140, Computer.My.Resources.String139, Computer.My.Resources.String138, Computer.My.Resources.String137, Computer.My.Resources.String136, Computer.My.Resources.String135}
    Public Shared Monitor As Array = {"None", Computer.My.Resources.String147, Computer.My.Resources.String148, Computer.My.Resources.String149, Computer.My.Resources.String150, Computer.My.Resources.String151, Computer.My.Resources.String152, Computer.My.Resources.String153, Computer.My.Resources.String154, Computer.My.Resources.String155, Computer.My.Resources.String156, Computer.My.Resources.String157, Computer.My.Resources.String158}
    Public Shared Keyboard As Array = {"None", Computer.My.Resources.String168, Computer.My.Resources.String167, Computer.My.Resources.String166, Computer.My.Resources.String165, Computer.My.Resources.String164, Computer.My.Resources.String163, Computer.My.Resources.String162, Computer.My.Resources.String161, Computer.My.Resources.String160}
    Public Shared Mouse As Array = {"None", Computer.My.Resources.String176, Computer.My.Resources.String175, Computer.My.Resources.String174, Computer.My.Resources.String173, Computer.My.Resources.String172, Computer.My.Resources.String171, Computer.My.Resources.String170}
    Public Shared MousePad As Array = {"None", Computer.My.Resources.String178, Computer.My.Resources.String179, Computer.My.Resources.String180}
    Public Shared Speaker As Array = {"None", Computer.My.Resources.String186, Computer.My.Resources.String182, Computer.My.Resources.String188, Computer.My.Resources.String187, Computer.My.Resources.String183, Computer.My.Resources.String184, Computer.My.Resources.String185}
    Public Shared Printer As Array = {"None", Computer.My.Resources.String190, Computer.My.Resources.String191, Computer.My.Resources.String192, Computer.My.Resources.String193, Computer.My.Resources.String194, Computer.My.Resources.String195}
    Public Shared WebCam As Array = {"None", Computer.My.Resources.String197, Computer.My.Resources.String198, Computer.My.Resources.String199, Computer.My.Resources.String200}
    Public Shared Bluetooth As Array = {"None", Computer.My.Resources.String202, Computer.My.Resources.String203}
    Public Shared Scaner As Array = {"None", Computer.My.Resources.String205, Computer.My.Resources.String206, Computer.My.Resources.String207}
    Public Shared OpticalDriver As Array = {"None", Computer.My.Resources.String209, Computer.My.Resources.String210, Computer.My.Resources.String211}
    Public Shared CardReader As Array = {"None", Computer.My.Resources.String213, Computer.My.Resources.String214, Computer.My.Resources.String215}
    Public Shared PC As String() = {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"}

    Sub Hide1()
        ComboBox12.Items.Clear()
        Button1.IsEnabled = False
        ComboBox12.IsEnabled = False
    End Sub

    Sub Hide2()
        ComboBox6.Items.Clear()
        ComboBox6.IsEnabled = False
        RadioButton3.IsChecked = False
        RadioButton4.IsChecked = False
        RadioButton5.IsChecked = False
        RadioButton3.IsEnabled = False
        RadioButton4.IsEnabled = False
        RadioButton5.IsEnabled = False
        PictureBox2.Source = Nothing
    End Sub

    Sub Hide3()
        ComboBox10.Items.Clear()
        ComboBox11.Items.Clear()
        ComboBox10.IsEnabled = False
        ComboBox11.IsEnabled = False
    End Sub

    Sub Hide4()
        ComboBox8.Items.Clear()
        ComboBox7.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox4.IsEnabled = False
        ComboBox7.IsEnabled = False
        ComboBox8.IsEnabled = False
    End Sub

    Sub Hide5()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox2.IsEnabled = False
        ComboBox3.IsEnabled = False
    End Sub

    Sub Hide6()
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
        ComboBox13.IsEnabled = False
        ComboBox14.IsEnabled = False
        ComboBox15.IsEnabled = False
        ComboBox16.IsEnabled = False
        ComboBox17.IsEnabled = False
        ComboBox18.IsEnabled = False
        ComboBox19.IsEnabled = False
        ComboBox20.IsEnabled = False
        ComboBox21.IsEnabled = False
        ComboBox22.IsEnabled = False
        ComboBox23.IsEnabled = False
    End Sub

    Sub FillCase()
        If PC(3) = Computer.My.Resources.String042 OrElse PC(2) = Computer.My.Resources.String045 OrElse PC(2) = Computer.My.Resources.String046 OrElse PC(2) = Computer.My.Resources.String047 OrElse PC(3) = Computer.My.Resources.String060 OrElse PC(3) = Computer.My.Resources.String061 OrElse PC(1) = Computer.My.Resources.String001 OrElse PC(1) = Computer.My.Resources.String011 OrElse PC(2) = Computer.My.Resources.String020 OrElse PC(2) = Computer.My.Resources.String048 OrElse PC(2) = Computer.My.Resources.String049 OrElse PC(2) = Computer.My.Resources.String050 OrElse PC(3) = Computer.My.Resources.String062 OrElse PC(3) = Computer.My.Resources.String063 OrElse PC(3) = Computer.My.Resources.String064 OrElse PC(3) = Computer.My.Resources.String065 OrElse PC(11) = Computer.My.Resources.String117 OrElse PC(11) = Computer.My.Resources.String118 OrElse PC(11) = Computer.My.Resources.String119 OrElse PC(11) = Computer.My.Resources.String120 OrElse PC(11) = Computer.My.Resources.String121 OrElse PC(11) = Computer.My.Resources.String122 OrElse PC(11) = Computer.My.Resources.String129 OrElse PC(11) = Computer.My.Resources.String130 OrElse PC(11) = Computer.My.Resources.String131 OrElse PC(11) = Computer.My.Resources.String132 OrElse PC(11) = Computer.My.Resources.String133 Then
            For i As Integer = 0 To 7
                ComboBox12.Items.Add(ProfissionalCase(i))
            Next
        Else
            For i As Integer = 0 To 3
                ComboBox12.Items.Add(BasicCase(i))
            Next
        End If
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
        ComboBox13.IsEnabled = True
        ComboBox14.IsEnabled = True
        ComboBox15.IsEnabled = True
        ComboBox16.IsEnabled = True
        ComboBox17.IsEnabled = True
        ComboBox18.IsEnabled = True
        ComboBox19.IsEnabled = True
        ComboBox20.IsEnabled = True
        ComboBox21.IsEnabled = True
        ComboBox22.IsEnabled = True
        ComboBox23.IsEnabled = True
        For i As Integer = 0 To 3
            ComboBox22.Items.Add(OpticalDriver(i))
        Next
        For i As Integer = 0 To 12
            ComboBox13.Items.Add(Monitor(i))
        Next
        For i As Integer = 0 To 9
            ComboBox14.Items.Add(Keyboard(i))
        Next
        For i As Integer = 0 To 7
            ComboBox15.Items.Add(Mouse(i))
        Next
        For i As Integer = 0 To 3
            ComboBox16.Items.Add(MousePad(i))
        Next
        For i As Integer = 0 To 7
            ComboBox17.Items.Add(Speaker(i))
        Next
        For i As Integer = 0 To 6
            ComboBox18.Items.Add(Printer(i))
        Next
        For i As Integer = 0 To 2
            ComboBox20.Items.Add(Bluetooth(i))
        Next
        For i As Integer = 0 To 3
            ComboBox21.Items.Add(Scaner(i))
        Next
        For i As Integer = 0 To 4
            ComboBox19.Items.Add(WebCam(i))
        Next
        For i As Integer = 0 To 3
            ComboBox23.Items.Add(CardReader(i))
        Next
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
        Button1.IsEnabled = True
    End Sub

    Public Sub Rest()
        Hide5()
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        Hide6()
        PictureBox1.Source = Nothing
        PictureBox2.Source = Nothing
        RadioButton1.IsChecked = False
        RadioButton2.IsChecked = False
        For i As Integer = 0 To 24
            PC(i) = "0"
        Next
    End Sub


    Private Sub RadioButton1_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioButton1.Checked
        Hide5()
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        PictureBox1.Source = Image1.Source
        PC(0) = "Intel"
        ComboBox1.IsEnabled = True
        For i As Integer = 0 To 5
            ComboBox1.Items.Add(Intel(i))
        Next
    End Sub

    Private Sub RadioButton2_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioButton2.Checked
        Hide5()
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        PictureBox1.Source = Image2.Source
        PC(0) = "AMD"
        ComboBox1.IsEnabled = True
        For i As Integer = 0 To 2
            ComboBox1.Items.Add(AMD(i))
        Next
    End Sub

    Private Sub ComboBox1_MouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles ComboBox1.PreviewMouseLeftButtonUp
        If RadioButton1.IsChecked = False And RadioButton2.IsChecked = False Then MessageBox.Show("لم تقم باختيار الشركة! قم باختيار اسم الشركة ثم اختر الموديل", "خطأ", MessageBoxButton.OK, MessageBoxImage.Information)
    End Sub

    Private Sub ComboBox1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox1.SelectionChanged
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        ComboBox2.IsEnabled = True
        ComboBox3.IsEnabled = False
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        PC(1) = ComboBox1.SelectedItem
        Select Case PC(1)
            Case Computer.My.Resources.String001
                For i As Integer = 0 To 3
                    ComboBox2.Items.Add(SecondCorei(i))
                Next
            Case Computer.My.Resources.String011
                For i As Integer = 0 To 2
                    ComboBox2.Items.Add(Corei(i))
                Next
            Case Computer.My.Resources.String019
                For i As Integer = 0 To 2
                    ComboBox2.Items.Add(Core2Quad(i))
                Next
            Case Computer.My.Resources.String023
                For i As Integer = 0 To 1
                    ComboBox2.Items.Add(Core2Duo(i))
                Next
            Case Computer.My.Resources.String026
                For i As Integer = 0 To 4
                    ComboBox2.Items.Add(Pentum(i))
                Next
            Case Computer.My.Resources.String032
                ComboBox2.Items.Add(Celeron(0))
            Case Computer.My.Resources.String044
                For i As Integer = 0 To 7
                    ComboBox2.Items.Add(Phenom2(i))
                Next
            Case Computer.My.Resources.String053
                For i As Integer = 0 To 3
                    ComboBox2.Items.Add(Athlon2(i))
                Next
            Case Computer.My.Resources.String058
                ComboBox2.Items.Add(Sempron(0))
        End Select
    End Sub

    Private Sub ComboBox2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox2.SelectionChanged
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        ComboBox3.Items.Clear()
        ComboBox3.IsEnabled = True
        PC(2) = ComboBox2.SelectedItem
        Select Case PC(1)
            Case Computer.My.Resources.String001
                For i As Integer = 0 To 4
                    ComboBox3.Items.Add(SecondCoreiBoard(i))
                Next
            Case Computer.My.Resources.String011
                For i As Integer = 0 To 3
                    ComboBox3.Items.Add(CoreiBoard(i))
                Next
            Case Computer.My.Resources.String019
                For i As Integer = 0 To 2
                    ComboBox3.Items.Add(Core2Board(i))
                Next
            Case Computer.My.Resources.String023
                For i As Integer = 0 To 2
                    ComboBox3.Items.Add(Core2Board(i))
                Next
            Case Computer.My.Resources.String026
                For i As Integer = 0 To 5
                    ComboBox3.Items.Add(PentumBoard(i))
                Next
            Case Computer.My.Resources.String032
                For i As Integer = 0 To 2
                    ComboBox3.Items.Add(CeleronBoard(i))
                Next
            Case Computer.My.Resources.String044
                For i As Integer = 0 To 2
                    ComboBox3.Items.Add(Phenom2Board(i))
                Next
            Case Computer.My.Resources.String053
                For i As Integer = 0 To 6
                    ComboBox3.Items.Add(Athlon2BoardDual(i))
                Next
            Case Computer.My.Resources.String058
                For i As Integer = 0 To 1
                    ComboBox3.Items.Add(SempronBoard(i))
                Next
        End Select
        If PC(2) = Computer.My.Resources.String025 Then
            ComboBox3.Items.Clear()
            For i As Integer = 0 To 5
                ComboBox3.Items.Add(PentumBoard(i))
            Next
        End If
        If PC(2) = Computer.My.Resources.String051 OrElse PC(2) = Computer.My.Resources.String052 Then
            ComboBox3.Items.Clear()
            For i As Integer = 0 To 6
                ComboBox3.Items.Add(Athlon2BoardDual(i))
            Next
        End If
        If PC(2) = Computer.My.Resources.String048 OrElse PC(2) = Computer.My.Resources.String049 OrElse PC(2) = Computer.My.Resources.String050 Then
            ComboBox3.Items.Clear()
            For i As Integer = 0 To 7
                ComboBox3.Items.Add(Athlon2BoardQuad(i))
            Next
        End If
    End Sub

    Private Sub ComboBox3_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox3.SelectionChanged
        Hide1()
        Hide2()
        Hide3()
        Hide4()
        ComboBox8.IsEnabled = True
        PC(3) = ComboBox3.SelectedItem
        ComboBox8.Items.Clear()
        If PC(1) = Computer.My.Resources.String032 Then
            For i As Integer = 0 To 1
                ComboBox8.Items.Add(DDR2(i))
            Next
            PC(4) = "DDR2"
        ElseIf PC(2) = Computer.My.Resources.String005 OrElse PC(2) = Computer.My.Resources.String014 OrElse PC(2) = Computer.My.Resources.String045 OrElse PC(2) = Computer.My.Resources.String046 OrElse PC(2) = Computer.My.Resources.String047 Then
            For i As Integer = 0 To 1
                ComboBox8.Items.Add(SuperDDR3(i))
            Next
            PC(4) = "DDR3*"
        Else
            For i As Integer = 0 To 3
                ComboBox8.Items.Add(DDR3(i))
            Next
            PC(4) = "DDR3"
        End If
    End Sub

    Private Sub ComboBox8_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Input.KeyEventArgs) Handles ComboBox8.PreviewKeyDown
        If PC(0) = "0" OrElse PC(1) = "0" OrElse PC(2) = "0" OrElse PC(3) = "0" Then
            ComboBox8.IsEnabled = False
            ComboBox8.Items.Clear()
            MessageBox.Show("قم باختيار المعالج واللوحة الأم أولا", "خطأ", MessageBoxButton.OK, MessageBoxImage.Information)
        End If
    End Sub

    Private Sub ComboBox8_PreviewMouseUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles ComboBox8.PreviewMouseUp
        If PC(0) = "0" OrElse PC(1) = "0" OrElse PC(2) = "0" OrElse PC(3) = "0" Then
            ComboBox8.IsEnabled = False
            ComboBox8.Items.Clear()
            MessageBox.Show("قم باختيار المعالج واللوحة الأم أولا", "خطأ", MessageBoxButton.OK, MessageBoxImage.Information)
        End If
    End Sub

    Private Sub ComboBox8_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox8.SelectionChanged
        PC(5) = ComboBox8.SelectedItem
        Hide1()
        Hide2()
        Hide3()
        ComboBox7.IsEnabled = True
        ComboBox4.IsEnabled = False
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

    Private Sub ComboBox7_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox7.SelectionChanged
        Hide1()
        Hide2()
        Hide3()
        ComboBox4.IsEnabled = True
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

    Private Sub ComboBox4_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox4.SelectionChanged
        Hide1()
        Hide2()
        Hide3()
        PC(24) = ComboBox4.SelectedItem
        ComboBox11.IsEnabled = True
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

    Private Sub ComboBox10_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox10.SelectionChanged
        PC(9) = ComboBox10.SelectedItem
        Hide1()
        Hide2()
        ComboBox6.IsEnabled = True
        RadioButton3.IsEnabled = True
        RadioButton4.IsEnabled = True
        RadioButton5.IsEnabled = True
    End Sub

    Private Sub ComboBox11_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox11.SelectionChanged
        PC(8) = ComboBox11.SelectedItem
        Hide1()
        Hide2()
        ComboBox10.IsEnabled = True
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

    Private Sub RadioButton5_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioButton5.Checked
        Hide1()
        PC(10) = "None"
        ComboBox6.Items.Clear()
        ComboBox6.IsEnabled = False
        ComboBox12.IsEnabled = True
        FillCase()
        PictureBox2.Source = Image3.Source
    End Sub

    Private Sub RadioButton3_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioButton3.Checked
        Hide1()
        PictureBox2.Source = Image5.Source
        PC(10) = "AMD"
        ComboBox6.IsEnabled = True
        ComboBox6.Items.Clear()
        ComboBox12.IsEnabled = False
        If PC(1) = Computer.My.Resources.String032 OrElse PC(1) = Computer.My.Resources.String058 OrElse PC(2) = Computer.My.Resources.String030 OrElse PC(2) = Computer.My.Resources.String031 Then
            For i As Integer = 0 To 2
                ComboBox6.Items.Add(BasicAMDGraphgic(i))
            Next
        ElseIf PC(2) = Computer.My.Resources.String005 OrElse PC(2) = Computer.My.Resources.String014 OrElse PC(2) = Computer.My.Resources.String045 OrElse PC(2) = Computer.My.Resources.String046 OrElse PC(2) = Computer.My.Resources.String047 Then
            For i As Integer = 0 To 6
                ComboBox6.Items.Add(SuperAMDGraphgic(i))
            Next
        Else
            For i As Integer = 0 To 5
                ComboBox6.Items.Add(NormalAMDGraphgic(i))
            Next
        End If
    End Sub

    Private Sub RadioButton4_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioButton4.Checked
        Hide1()
        PictureBox2.Source = Image4.Source
        PC(10) = "Nvidia"
        ComboBox6.IsEnabled = True
        ComboBox6.Items.Clear()
        ComboBox12.IsEnabled = False
        If PC(1) = Computer.My.Resources.String032 OrElse PC(1) = Computer.My.Resources.String058 OrElse PC(2) = Computer.My.Resources.String030 OrElse PC(2) = Computer.My.Resources.String031 Then
            For i As Integer = 0 To 2
                ComboBox6.Items.Add(BasicNvidiaGraphgic(i))
            Next
        ElseIf PC(2) = Computer.My.Resources.String005 OrElse PC(2) = Computer.My.Resources.String014 OrElse PC(2) = Computer.My.Resources.String045 OrElse PC(2) = Computer.My.Resources.String046 OrElse PC(2) = Computer.My.Resources.String047 Then
            For i As Integer = 0 To 5
                ComboBox6.Items.Add(SuperNvidiaGraphgic(i))
            Next
        Else
            For i As Integer = 0 To 4
                ComboBox6.Items.Add(NormalNvidiaGraphgic(i))
            Next
        End If
    End Sub

    Private Sub ComboBox6_PreviewMouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles ComboBox6.PreviewMouseLeftButtonUp
        If RadioButton3.IsChecked = False AndAlso RadioButton4.IsChecked = False AndAlso RadioButton5.IsChecked = False Then MessageBox.Show("أختر أحد الخيارات أعلاه ثم اختر النوع.", "خطأ", MessageBoxButton.OK, MsgBoxStyle.Information)
    End Sub

    Private Sub ComboBox6_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox6.SelectionChanged
        PC(11) = ComboBox6.SelectedItem
        Hide1()
        ComboBox12.IsEnabled = True
        ComboBox12.Items.Clear()
        FillCase()
    End Sub

    Private Sub ComboBox12_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox12.SelectionChanged
        fillother()
        PC(12) = ComboBox12.SelectedItem
    End Sub

    Private Sub ComboBox22_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox22.SelectionChanged
        PC(13) = ComboBox22.SelectedItem
    End Sub

    Private Sub ComboBox13_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox13.SelectionChanged
        PC(14) = ComboBox13.SelectedItem
    End Sub

    Private Sub ComboBox14_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox14.SelectionChanged
        PC(15) = ComboBox14.SelectedItem
    End Sub

    Private Sub ComboBox15_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox15.SelectionChanged
        PC(16) = ComboBox15.SelectedItem
    End Sub

    Private Sub ComboBox17_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox17.SelectionChanged
        PC(18) = ComboBox17.SelectedItem
    End Sub

    Private Sub ComboBox16_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox16.SelectionChanged
        PC(17) = ComboBox16.SelectedItem
    End Sub

    Private Sub ComboBox18_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox18.SelectionChanged
        PC(19) = ComboBox18.SelectedItem
    End Sub

    Private Sub ComboBox20_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox20.SelectionChanged
        PC(20) = ComboBox20.SelectedItem
    End Sub

    Private Sub ComboBox21_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox21.SelectionChanged
        PC(21) = ComboBox21.SelectedItem
    End Sub

    Private Sub ComboBox19_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox19.SelectionChanged
        PC(22) = ComboBox19.SelectedItem
    End Sub

    Private Sub ComboBox23_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox23.SelectionChanged
        PC(23) = ComboBox23.SelectedItem
    End Sub

    Private Sub NewFile_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles NewFile.Click
        Rest()
    End Sub

    Private Sub exit_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles [exit].Click
        End
    End Sub

    Private Sub about_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles about.Click
        Dim About_Dialog As New Window1
        About_Dialog.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim Result_Dialog As New Window2
        Result_Dialog.ShowDialog()
        Rest()
    End Sub

    Private Sub ChooseElement_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles ChooseElement.Click
        Dim Choose_Dialog As New Window3
        Choose_Dialog.ShowDialog()
    End Sub

    Private Sub help_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles help.Click
        Dim help_dialog As New Window4
        help_dialog.Show()
    End Sub

End Class
