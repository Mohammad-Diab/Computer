Public Class Window3
    Dim Category As Array = {"المعالج", "اللوحة الأم", "الذاكرة", "القرص الصلب", "بطاقة الاظهار", "العلبة الخارجية", "السواقة الليزرية", "الشاشة", "لوحة المفاتيح", "الفأرة", "مكبرات الصوت", "وسادة الفأرة", "الطابعة", "بلوتوث", "الماسحة الضوئية", "كاميرا الويب", "قارئة الذواكر"}
    Dim cases As Array = {Computer.My.Resources.String145, Computer.My.Resources.String144, Computer.My.Resources.String143, Computer.My.Resources.String142, Computer.My.Resources.String141, Computer.My.Resources.String140, Computer.My.Resources.String139, Computer.My.Resources.String138, Computer.My.Resources.String137, Computer.My.Resources.String136, Computer.My.Resources.String135}
    Dim Nvidia_Graphic_Card As Array = {Computer.My.Resources.String113, Computer.My.Resources.String114, Computer.My.Resources.String115, Computer.My.Resources.String116, Computer.My.Resources.String117, Computer.My.Resources.String118, Computer.My.Resources.String119, Computer.My.Resources.String120, Computer.My.Resources.String121, Computer.My.Resources.String122}
    Dim AMD_Graphic_Card As Array = {Computer.My.Resources.String124, Computer.My.Resources.String125, Computer.My.Resources.String126, Computer.My.Resources.String127, Computer.My.Resources.String128, Computer.My.Resources.String129, Computer.My.Resources.String130, Computer.My.Resources.String131, Computer.My.Resources.String132, Computer.My.Resources.String133}
    Dim AMD_Mother_Board As Array = {Computer.My.Resources.String059, Computer.My.Resources.String060, Computer.My.Resources.String061, Computer.My.Resources.String062, Computer.My.Resources.String063, Computer.My.Resources.String064, Computer.My.Resources.String065, Computer.My.Resources.String066, Computer.My.Resources.String067, Computer.My.Resources.String068, Computer.My.Resources.String069, Computer.My.Resources.String070, Computer.My.Resources.String071}
    Dim Intel_Mother_Board As Array = {Computer.My.Resources.String034, Computer.My.Resources.String035, Computer.My.Resources.String036, Computer.My.Resources.String037, Computer.My.Resources.String038, Computer.My.Resources.String039, Computer.My.Resources.String040, Computer.My.Resources.String041, Computer.My.Resources.String042, Computer.My.Resources.String018, Computer.My.Resources.String017, Computer.My.Resources.String016, Computer.My.Resources.String015, Computer.My.Resources.String010, Computer.My.Resources.String009, Computer.My.Resources.String008, Computer.My.Resources.String007, Computer.My.Resources.String006}

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        For i As Integer = 0 To 16
            ComboBox1.Items.Add(Category(i))
        Next
    End Sub

    Private Sub ComboBox1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox1.SelectionChanged
        ComboBox2.Items.Clear()
        Label4.Content = "0.0"
        Select Case ComboBox1.SelectedItem
            Case "قارئة الذواكر"
                For i As Integer = 1 To 3
                    ComboBox2.Items.Add(MainWindow.CardReader(i))
                Next
            Case "كاميرا الويب"
                For i As Integer = 1 To 4
                    ComboBox2.Items.Add(MainWindow.WebCam(i))
                Next
            Case "الماسحة الضوئية"
                For i As Integer = 1 To 3
                    ComboBox2.Items.Add(MainWindow.Scaner(i))
                Next
            Case "بلوتوث"
                For i As Integer = 1 To 2
                    ComboBox2.Items.Add(MainWindow.Bluetooth(i))
                Next
            Case "الطابعة"
                For i As Integer = 1 To 6
                    ComboBox2.Items.Add(MainWindow.Printer(i))
                Next
            Case "وسادة الفأرة"
                For i As Integer = 1 To 3
                    ComboBox2.Items.Add(MainWindow.MousePad(i))
                Next
            Case "مكبرات الصوت"
                For i As Integer = 1 To 7
                    ComboBox2.Items.Add(MainWindow.Speaker(i))
                Next
            Case "الفأرة"
                For i As Integer = 1 To 7
                    ComboBox2.Items.Add(MainWindow.Mouse(i))
                Next
            Case "لوحة المفاتيح"
                For i As Integer = 1 To 9
                    ComboBox2.Items.Add(MainWindow.Keyboard(i))
                Next
            Case "الشاشة"
                For i As Integer = 1 To 12
                    ComboBox2.Items.Add(MainWindow.Monitor(i))
                Next
            Case "السواقة الليزرية"
                For i As Integer = 1 To 3
                    ComboBox2.Items.Add(MainWindow.OpticalDriver(i))
                Next
            Case "العلبة الخارجية"
                For i As Integer = 0 To 10
                    ComboBox2.Items.Add(cases(i))
                Next
            Case "بطاقة الاظهار"
                For i As Integer = 0 To 9
                    ComboBox2.Items.Add("Nvidia " + Nvidia_Graphic_Card(i))
                Next
                For i As Integer = 0 To 9
                    ComboBox2.Items.Add("AMD " + AMD_Graphic_Card(i))
                Next
            Case "القرص الصلب"
                ComboBox2.Items.Add("WD " + Computer.My.Resources.String111 + " Sata 2")
                ComboBox2.Items.Add("WD " + Computer.My.Resources.String110 + " Sata 2")
                ComboBox2.Items.Add("WD " + Computer.My.Resources.String109 + " Sata 2")
                ComboBox2.Items.Add("WD " + Computer.My.Resources.String108 + " Sata 2")
                ComboBox2.Items.Add("WD " + Computer.My.Resources.String107 + " Sata 2")
                ComboBox2.Items.Add("WD " + Computer.My.Resources.String106 + " Sata 2")
                ComboBox2.Items.Add("Samsung " + Computer.My.Resources.String104 + " Sata 2")
                ComboBox2.Items.Add("Seagate " + Computer.My.Resources.String102 + " Sata 2")
                ComboBox2.Items.Add("WD " + Computer.My.Resources.String099 + " Sata 3")
                ComboBox2.Items.Add("Seagate " + Computer.My.Resources.String097 + " Sata 3")
                ComboBox2.Items.Add("Seagate " + Computer.My.Resources.String096 + " Sata 3")
                ComboBox2.Items.Add("Seagate " + Computer.My.Resources.String095 + " Sata 3")
            Case "الذاكرة"
                ComboBox2.Items.Add("Other 1GB DDR2 PC667")
                ComboBox2.Items.Add("Other 2GB DDR2 PC667")
                ComboBox2.Items.Add("Other 1GB DDR2 PC800")
                ComboBox2.Items.Add("Other 2GB DDR2 PC800")
                ComboBox2.Items.Add("Zepplein 1GB DDR2 PC800")
                ComboBox2.Items.Add("Zepplein 2GB DDR2 PC800")
                ComboBox2.Items.Add("Other 2GB DDR3 PC1333")
                ComboBox2.Items.Add("Other 3GB DDR3 PC1333")
                ComboBox2.Items.Add("Other 4GB DDR3 PC1333")
                ComboBox2.Items.Add("Other 4GB DDR3 PC2000")
                ComboBox2.Items.Add("KingSton 2GB DDR3 PC1333")
                ComboBox2.Items.Add("KingSton 3GB DDR3 PC1333")
                ComboBox2.Items.Add("KingSton 4GB DDR3 PC1333")
                ComboBox2.Items.Add("KingSton 6GB DDR3 PC1333")
                ComboBox2.Items.Add("KingSton 8GB DDR3 PC1333")
                ComboBox2.Items.Add("Zepplein 2GB DDR3 PC1333")
                ComboBox2.Items.Add("Zepplein 3GB DDR3 PC1333")
                ComboBox2.Items.Add("Zepplein 4GB DDR3 PC1333")
                ComboBox2.Items.Add("Ketron 2GB DDR3 PC1333")
                ComboBox2.Items.Add("Ketron 3GB DDR3 PC1333")
                ComboBox2.Items.Add("Ketron 4GB DDR3 PC1333")
            Case "اللوحة الأم"
                For i As Integer = 0 To 17
                    ComboBox2.Items.Add(Intel_Mother_Board(i))
                Next
                For i As Integer = 0 To 12
                    ComboBox2.Items.Add(AMD_Mother_Board(i))
                Next
            Case "المعالج"
                ComboBox2.Items.Add("Intel " + "Celeron " + Computer.My.Resources.String033)
                For i As Integer = 0 To 4
                    ComboBox2.Items.Add("Intel " + "Pentium " + MainWindow.Pentum(i))
                Next
                For i As Integer = 0 To 1
                    ComboBox2.Items.Add("Intel " + "Core 2 Duo " + MainWindow.Core2Duo(i))
                Next
                For i As Integer = 0 To 2
                    ComboBox2.Items.Add("Intel " + "Core 2 Quad " + MainWindow.Core2Quad(i))
                Next
                For i As Integer = 0 To 2
                    ComboBox2.Items.Add("Intel " + "Core " + MainWindow.Corei(i))
                Next
                For i As Integer = 0 To 3
                    ComboBox2.Items.Add("Intel " + "2nd Generation Core " + MainWindow.SecondCorei(i))
                Next
                ComboBox2.Items.Add("AMD " + "Sempron " + Computer.My.Resources.String059)
                For i As Integer = 0 To 3
                    ComboBox2.Items.Add("AMD " + "Athlon II " + MainWindow.Athlon2(i))
                Next
                For i As Integer = 0 To 7
                    ComboBox2.Items.Add("AMD " + "Phenom II " + MainWindow.Phenom2(i))
                Next
        End Select
    End Sub

    Private Sub ComboBox2_PreviewMouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles ComboBox2.PreviewMouseLeftButtonUp
        If ComboBox1.SelectedItem = Nothing Then MessageBox.Show("قم باختيار الصنف أولا", "خطأ", MessageBoxButton.OK, MessageBoxImage.Information)
    End Sub

    Private Sub ComboBox2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles ComboBox2.SelectionChanged
        If ComboBox2.SelectedItem = "Intel " + "2nd Generation Core " + Computer.My.Resources.String002 Then Label4.Content = "6350"
        If ComboBox2.SelectedItem = "Intel " + "2nd Generation Core " + Computer.My.Resources.String003 Then Label4.Content = "10500"
        If ComboBox2.SelectedItem = "Intel " + "2nd Generation Core " + Computer.My.Resources.String004 Then Label4.Content = "12000"
        If ComboBox2.SelectedItem = "Intel " + "2nd Generation Core " + Computer.My.Resources.String005 Then Label4.Content = "15800"
        If ComboBox2.SelectedItem = "Intel " + "Core " + Computer.My.Resources.String012 Then Label4.Content = "5800"
        If ComboBox2.SelectedItem = "Intel " + "Core " + Computer.My.Resources.String013 Then Label4.Content = "9700"
        If ComboBox2.SelectedItem = "Intel " + "Core " + Computer.My.Resources.String014 Then Label4.Content = "14600"
        If ComboBox2.SelectedItem = "Intel " + "Core 2 Quad " + Computer.My.Resources.String020 Then Label4.Content = "13700"
        If ComboBox2.SelectedItem = "Intel " + "Core 2 Quad " + Computer.My.Resources.String021 Then Label4.Content = "8500"
        If ComboBox2.SelectedItem = "Intel " + "Core 2 Quad " + Computer.My.Resources.String022 Then Label4.Content = "7900"
        If ComboBox2.SelectedItem = "Intel " + "Core 2 Duo " + Computer.My.Resources.String024 Then Label4.Content = "7400"
        If ComboBox2.SelectedItem = "Intel " + "Core 2 Duo " + Computer.My.Resources.String025 Then Label4.Content = "5900"
        If ComboBox2.SelectedItem = "Intel " + "Pentium " + Computer.My.Resources.String027 Then Label4.Content = "4200"
        If ComboBox2.SelectedItem = "Intel " + "Pentium " + Computer.My.Resources.String028 Then Label4.Content = "3800"
        If ComboBox2.SelectedItem = "Intel " + "Pentium " + Computer.My.Resources.String029 Then Label4.Content = "3500"
        If ComboBox2.SelectedItem = "Intel " + "Pentium " + Computer.My.Resources.String030 Then Label4.Content = "2100"
        If ComboBox2.SelectedItem = "Intel " + "Pentium " + Computer.My.Resources.String031 Then Label4.Content = "2000"
        If ComboBox2.SelectedItem = "Intel " + "Celeron " + Computer.My.Resources.String033 Then Label4.Content = "1250"
        If ComboBox2.SelectedItem = "AMD " + "Phenom II " + Computer.My.Resources.String045 Then Label4.Content = "9800"
        If ComboBox2.SelectedItem = "AMD " + "Phenom II " + Computer.My.Resources.String046 Then Label4.Content = "9100"
        If ComboBox2.SelectedItem = "AMD " + "Phenom II " + Computer.My.Resources.String047 Then Label4.Content = "8900"
        If ComboBox2.SelectedItem = "AMD " + "Phenom II " + Computer.My.Resources.String048 Then Label4.Content = "9000"
        If ComboBox2.SelectedItem = "AMD " + "Phenom II " + Computer.My.Resources.String049 Then Label4.Content = "7800"
        If ComboBox2.SelectedItem = "AMD " + "Phenom II " + Computer.My.Resources.String050 Then Label4.Content = "6500"
        If ComboBox2.SelectedItem = "AMD " + "Phenom II " + Computer.My.Resources.String051 Then Label4.Content = "5750"
        If ComboBox2.SelectedItem = "AMD " + "Phenom II " + Computer.My.Resources.String052 Then Label4.Content = "4500"
        If ComboBox2.SelectedItem = "AMD " + "Athlon II " + Computer.My.Resources.String054 Then Label4.Content = "4500"
        If ComboBox2.SelectedItem = "AMD " + "Athlon II " + Computer.My.Resources.String055 Then Label4.Content = "3500"
        If ComboBox2.SelectedItem = "AMD " + "Athlon II " + Computer.My.Resources.String056 Then Label4.Content = "3100"
        If ComboBox2.SelectedItem = "AMD " + "Athlon II " + Computer.My.Resources.String057 Then Label4.Content = "2800"
        If ComboBox2.SelectedItem = "AMD " + "Sempron " + Computer.My.Resources.String059 Then Label4.Content = "2000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String006 Then Label4.Content = "10600"
        If ComboBox2.SelectedItem = Computer.My.Resources.String007 Then Label4.Content = "7700"
        If ComboBox2.SelectedItem = Computer.My.Resources.String008 Then Label4.Content = "6500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String009 Then Label4.Content = "5000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String010 Then Label4.Content = "4800"
        If ComboBox2.SelectedItem = Computer.My.Resources.String015 Then Label4.Content = "7000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String016 Then Label4.Content = "5500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String017 Then Label4.Content = "5750"
        If ComboBox2.SelectedItem = Computer.My.Resources.String018 Then Label4.Content = "4500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String034 Then Label4.Content = "1600"
        If ComboBox2.SelectedItem = Computer.My.Resources.String035 Then Label4.Content = "1750"
        If ComboBox2.SelectedItem = Computer.My.Resources.String036 Then Label4.Content = "2600"
        If ComboBox2.SelectedItem = Computer.My.Resources.String037 Then Label4.Content = "2800"
        If ComboBox2.SelectedItem = Computer.My.Resources.String038 Then Label4.Content = "2900"
        If ComboBox2.SelectedItem = Computer.My.Resources.String039 Then Label4.Content = "3000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String040 Then Label4.Content = "3400"
        If ComboBox2.SelectedItem = Computer.My.Resources.String041 Then Label4.Content = "3500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String042 Then Label4.Content = "3800"
        If ComboBox2.SelectedItem = Computer.My.Resources.String060 Then Label4.Content = "12500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String061 Then Label4.Content = "6500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String062 Then Label4.Content = "5800"
        If ComboBox2.SelectedItem = Computer.My.Resources.String063 Then Label4.Content = "4500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String064 Then Label4.Content = "4300"
        If ComboBox2.SelectedItem = Computer.My.Resources.String065 Then Label4.Content = "4000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String066 Then Label4.Content = "3700"
        If ComboBox2.SelectedItem = Computer.My.Resources.String067 Then Label4.Content = "3200"
        If ComboBox2.SelectedItem = Computer.My.Resources.String068 Then Label4.Content = "3500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String069 Then Label4.Content = "2500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String070 Then Label4.Content = "2400"
        If ComboBox2.SelectedItem = Computer.My.Resources.String071 Then Label4.Content = "2000"
        If ComboBox2.SelectedItem = "Zepplein 1GB DDR2 PC800" Then Label4.Content = "850"
        If ComboBox2.SelectedItem = "Zepplein 2GB DDR2 PC800" Then Label4.Content = "1450"
        If ComboBox2.SelectedItem = "Other 1GB DDR2 PC667" Then Label4.Content = "450"
        If ComboBox2.SelectedItem = "Other 2GB DDR2 PC667" Then Label4.Content = "900"
        If ComboBox2.SelectedItem = "Other 1GB DDR2 PC800" Then Label4.Content = "750"
        If ComboBox2.SelectedItem = "Other 2GB DDR2 PC800" Then Label4.Content = "1200"
        If ComboBox2.SelectedItem = "KingSton 2GB DDR3 PC1333" Then Label4.Content = "1000"
        If ComboBox2.SelectedItem = "KingSton 3GB DDR3 PC1333" Then Label4.Content = "1600"
        If ComboBox2.SelectedItem = "KingSton 4GB DDR3 PC1333" Then Label4.Content = "1750"
        If ComboBox2.SelectedItem = "KingSton 6GB DDR3 PC1333" Then Label4.Content = "2750"
        If ComboBox2.SelectedItem = "KingSton 8GB DDR3 PC1333" Then Label4.Content = "3500"
        If ComboBox2.SelectedItem = "Zepplein 2GB DDR3 PC1333" Then Label4.Content = "1200"
        If ComboBox2.SelectedItem = "Zepplein 3GB DDR3 PC1333" Then Label4.Content = "1900"
        If ComboBox2.SelectedItem = "Zepplein 4GB DDR3 PC1333" Then Label4.Content = "2400"
        If ComboBox2.SelectedItem = "Ketron 2GB DDR3 PC1333" Then Label4.Content = "950"
        If ComboBox2.SelectedItem = "Ketron 3GB DDR3 PC1333" Then Label4.Content = "1550"
        If ComboBox2.SelectedItem = "Ketron 4GB DDR3 PC1333" Then Label4.Content = "1900"
        If ComboBox2.SelectedItem = "Other 2GB DDR3 PC1333" Then Label4.Content = "650"
        If ComboBox2.SelectedItem = "Other 3GB DDR3 PC1333" Then Label4.Content = "1100"
        If ComboBox2.SelectedItem = "Other 4GB DDR3 PC1333" Then Label4.Content = "1300"
        If ComboBox2.SelectedItem = "Other 4GB DDR3 PC2000" Then Label4.Content = "5000"
        If ComboBox2.SelectedItem = "Seagate " + Computer.My.Resources.String095 + " Sata 3" Then Label4.Content = "4500"
        If ComboBox2.SelectedItem = "Seagate " + Computer.My.Resources.String096 + " Sata 3" Then Label4.Content = "3000"
        If ComboBox2.SelectedItem = "Seagate " + Computer.My.Resources.String097 + " Sata 3" Then Label4.Content = "2300"
        If ComboBox2.SelectedItem = "WD " + Computer.My.Resources.String099 + " Sata 3" Then Label4.Content = "1800"
        If ComboBox2.SelectedItem = "Seagate " + Computer.My.Resources.String102 + " Sata 2" Then Label4.Content = "2800"
        If ComboBox2.SelectedItem = "Samsung " + Computer.My.Resources.String104 + " Sata 2" Then Label4.Content = "2000"
        If ComboBox2.SelectedItem = "WD " + Computer.My.Resources.String106 + " Sata 2" Then Label4.Content = "2800"
        If ComboBox2.SelectedItem = "WD " + Computer.My.Resources.String107 + " Sata 2" Then Label4.Content = "2200"
        If ComboBox2.SelectedItem = "WD " + Computer.My.Resources.String108 + " Sata 2" Then Label4.Content = "1900"
        If ComboBox2.SelectedItem = "WD " + Computer.My.Resources.String109 + " Sata 2" Then Label4.Content = "1700"
        If ComboBox2.SelectedItem = "WD " + Computer.My.Resources.String110 + " Sata 2" Then Label4.Content = "1600"
        If ComboBox2.SelectedItem = "WD " + Computer.My.Resources.String111 + " Sata 2" Then Label4.Content = "1550"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String113 Then Label4.Content = "1600"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String114 Then Label4.Content = "2300"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String115 Then Label4.Content = "3200"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String116 Then Label4.Content = "3300"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String117 Then Label4.Content = "6000"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String118 Then Label4.Content = "9500"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String119 Then Label4.Content = "10000"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String120 Then Label4.Content = "16500"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String121 Then Label4.Content = "24000"
        If ComboBox2.SelectedItem = "Nvidia " + Computer.My.Resources.String122 Then Label4.Content = "28000"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String124 Then Label4.Content = "1400"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String125 Then Label4.Content = "2100"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String126 Then Label4.Content = "3000"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String127 Then Label4.Content = "4500"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String128 Then Label4.Content = "4500"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String129 Then Label4.Content = "7500"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String130 Then Label4.Content = "9000"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String131 Then Label4.Content = "14000"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String132 Then Label4.Content = "18500"
        If ComboBox2.SelectedItem = "AMD " + Computer.My.Resources.String133 Then Label4.Content = "30000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String135 Then Label4.Content = "42000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String136 Then Label4.Content = "21000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String137 Then Label4.Content = "14600"
        If ComboBox2.SelectedItem = Computer.My.Resources.String138 Then Label4.Content = "13500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String139 Then Label4.Content = "9600"
        If ComboBox2.SelectedItem = Computer.My.Resources.String140 Then Label4.Content = "9500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String141 Then Label4.Content = "8200"
        If ComboBox2.SelectedItem = Computer.My.Resources.String142 Then Label4.Content = "4200"
        If ComboBox2.SelectedItem = Computer.My.Resources.String143 Then Label4.Content = "3500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String144 Then Label4.Content = "2500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String145 Then Label4.Content = "1300"
        If ComboBox2.SelectedItem = Computer.My.Resources.String147 Then Label4.Content = "2500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String148 Then Label4.Content = "5000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String149 Then Label4.Content = "5300"
        If ComboBox2.SelectedItem = Computer.My.Resources.String150 Then Label4.Content = "5400"
        If ComboBox2.SelectedItem = Computer.My.Resources.String151 Then Label4.Content = "5500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String152 Then Label4.Content = "6100"
        If ComboBox2.SelectedItem = Computer.My.Resources.String153 Then Label4.Content = "6600"
        If ComboBox2.SelectedItem = Computer.My.Resources.String154 Then Label4.Content = "7000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String155 Then Label4.Content = "7400"
        If ComboBox2.SelectedItem = Computer.My.Resources.String156 Then Label4.Content = "8100"
        If ComboBox2.SelectedItem = Computer.My.Resources.String157 Then Label4.Content = "16000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String158 Then Label4.Content = "17000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String160 Then Label4.Content = "5100"
        If ComboBox2.SelectedItem = Computer.My.Resources.String161 Then Label4.Content = "2600"
        If ComboBox2.SelectedItem = Computer.My.Resources.String162 Then Label4.Content = "1000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String163 Then Label4.Content = "500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String164 Then Label4.Content = "400"
        If ComboBox2.SelectedItem = Computer.My.Resources.String165 Then Label4.Content = "200"
        If ComboBox2.SelectedItem = Computer.My.Resources.String166 Then Label4.Content = "1000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String167 Then Label4.Content = "500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String168 Then Label4.Content = "250"
        If ComboBox2.SelectedItem = Computer.My.Resources.String170 Then Label4.Content = "1500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String171 Then Label4.Content = "800"
        If ComboBox2.SelectedItem = Computer.My.Resources.String172 Then Label4.Content = "250"
        If ComboBox2.SelectedItem = Computer.My.Resources.String173 Then Label4.Content = "100"
        If ComboBox2.SelectedItem = Computer.My.Resources.String174 Then Label4.Content = "650"
        If ComboBox2.SelectedItem = Computer.My.Resources.String175 Then Label4.Content = "500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String176 Then Label4.Content = "200"
        If ComboBox2.SelectedItem = Computer.My.Resources.String178 Then Label4.Content = "25"
        If ComboBox2.SelectedItem = Computer.My.Resources.String179 Then Label4.Content = "125"
        If ComboBox2.SelectedItem = Computer.My.Resources.String180 Then Label4.Content = "400"
        If ComboBox2.SelectedItem = Computer.My.Resources.String182 Then Label4.Content = "300"
        If ComboBox2.SelectedItem = Computer.My.Resources.String183 Then Label4.Content = "1400"
        If ComboBox2.SelectedItem = Computer.My.Resources.String184 Then Label4.Content = "2000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String185 Then Label4.Content = "3700"
        If ComboBox2.SelectedItem = Computer.My.Resources.String186 Then Label4.Content = "250"
        If ComboBox2.SelectedItem = Computer.My.Resources.String187 Then Label4.Content = "1000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String188 Then Label4.Content = "650"
        If ComboBox2.SelectedItem = Computer.My.Resources.String190 Then Label4.Content = "2100"
        If ComboBox2.SelectedItem = Computer.My.Resources.String191 Then Label4.Content = "2800"
        If ComboBox2.SelectedItem = Computer.My.Resources.String192 Then Label4.Content = "4200"
        If ComboBox2.SelectedItem = Computer.My.Resources.String193 Then Label4.Content = "6800"
        If ComboBox2.SelectedItem = Computer.My.Resources.String194 Then Label4.Content = "8600"
        If ComboBox2.SelectedItem = Computer.My.Resources.String195 Then Label4.Content = "11500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String197 Then Label4.Content = "350"
        If ComboBox2.SelectedItem = Computer.My.Resources.String198 Then Label4.Content = "525"
        If ComboBox2.SelectedItem = Computer.My.Resources.String199 Then Label4.Content = "850"
        If ComboBox2.SelectedItem = Computer.My.Resources.String200 Then Label4.Content = "1000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String202 Then Label4.Content = "100"
        If ComboBox2.SelectedItem = Computer.My.Resources.String203 Then Label4.Content = "650"
        If ComboBox2.SelectedItem = Computer.My.Resources.String205 Then Label4.Content = "2500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String206 Then Label4.Content = "2800"
        If ComboBox2.SelectedItem = Computer.My.Resources.String207 Then Label4.Content = "4500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String209 Then Label4.Content = "1200"
        If ComboBox2.SelectedItem = Computer.My.Resources.String210 Then Label4.Content = "6500"
        If ComboBox2.SelectedItem = Computer.My.Resources.String211 Then Label4.Content = "10000"
        If ComboBox2.SelectedItem = Computer.My.Resources.String213 Then Label4.Content = "100"
        If ComboBox2.SelectedItem = Computer.My.Resources.String214 Then Label4.Content = "400"
        If ComboBox2.SelectedItem = Computer.My.Resources.String215 Then Label4.Content = "1000"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
