Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim X As Single
        X = 0
        If Form1.RadioButton1.Checked Then
            Label8.Text = "Intel " + Form1.ComboBox1.SelectedItem
            Label9.Text = Form1.ComboBox2.SelectedItem
        Else
            Label8.Text = "AMD " + Form1.ComboBox1.SelectedItem
            Label9.Text = Form1.ComboBox2.SelectedItem
        End If
        Label11.Text = Form1.ComboBox3.SelectedItem
        Label13.Text = Form1.ComboBox8.SelectedItem + " " + Form1.ComboBox7.SelectedItem + " " + Form1.DDR.Text.Replace("*", "") + " " + Form1.ComboBox4.SelectedItem
        Label15.Text = Form1.ComboBox11.SelectedItem + " " + Form1.ComboBox10.SelectedItem
        If Form1.RadioButton5.Checked Then
            Label16.Text = "Internal Graphic"
        Else
            If Form1.RadioButton3.Checked Then
                Label16.Text = "AMD " + Form1.ComboBox6.SelectedItem
            Else
                Label16.Text = "Nvidia " + Form1.ComboBox6.SelectedItem
            End If
        End If
        Label18.Text = Form1.ComboBox12.SelectedItem
        If Form1.CheckBox2.Checked Then
            Label21.Text = Form1.ComboBox13.SelectedItem
        Else
            Label21.Text = "None"
        End If
        If Form1.CheckBox12.Checked Then
            Label34.Text = Form1.ComboBox22.SelectedItem
        Else
            Label34.Text = "None"
        End If
        If Form1.CheckBox3.Checked Then
            Label55.Text = Form1.ComboBox14.SelectedItem
        Else
            Label55.Text = "None"
        End If
        If Form1.CheckBox4.Checked Then
            Label54.Text = Form1.ComboBox15.SelectedItem
        Else
            Label54.Text = "None"
        End If
        If Form1.CheckBox5.Checked Then
            Label53.Text = Form1.ComboBox16.SelectedItem
        Else
            Label53.Text = "None"
        End If
        If Form1.CheckBox6.Checked Then
            Label52.Text = Form1.ComboBox17.SelectedItem
        Else
            Label52.Text = "None"
        End If
        If Form1.CheckBox7.Checked Then
            Label51.Text = Form1.ComboBox18.SelectedItem
        Else
            Label51.Text = "None"
        End If
        If Form1.CheckBox8.Checked Then
            Label50.Text = Form1.ComboBox19.SelectedItem
        Else
            Label50.Text = "None"
        End If
        If Form1.CheckBox9.Checked Then
            Label49.Text = Form1.ComboBox20.SelectedItem
        Else
            Label49.Text = "None"
        End If
        If Form1.CheckBox10.Checked Then
            Label48.Text = Form1.ComboBox21.SelectedItem
        Else
            Label48.Text = "None"
        End If
        If Form1.CheckBox11.Checked Then
            Label47.Text = Form1.ComboBox23.SelectedItem
        Else
            Label47.Text = "None"
        End If
        If Label9.Text = Computer_1.My.Resources.String002 Then Label10.Text = "6350"
        If Label9.Text = Computer_1.My.Resources.String003 Then Label10.Text = "10500"
        If Label9.Text = Computer_1.My.Resources.String004 Then Label10.Text = "12000"
        If Label9.Text = Computer_1.My.Resources.String005 Then Label10.Text = "15800"
        If Label9.Text = Computer_1.My.Resources.String012 Then Label10.Text = "5800"
        If Label9.Text = Computer_1.My.Resources.String013 Then Label10.Text = "9700"
        If Label9.Text = Computer_1.My.Resources.String014 Then Label10.Text = "14600"
        If Label9.Text = Computer_1.My.Resources.String020 Then Label10.Text = "13700"
        If Label9.Text = Computer_1.My.Resources.String021 Then Label10.Text = "8500"
        If Label9.Text = Computer_1.My.Resources.String022 Then Label10.Text = "7900"
        If Label9.Text = Computer_1.My.Resources.String024 Then Label10.Text = "7400"
        If Label9.Text = Computer_1.My.Resources.String025 Then Label10.Text = "5900"
        If Label9.Text = Computer_1.My.Resources.String027 Then Label10.Text = "4200"
        If Label9.Text = Computer_1.My.Resources.String028 Then Label10.Text = "3800"
        If Label9.Text = Computer_1.My.Resources.String029 Then Label10.Text = "3500"
        If Label9.Text = Computer_1.My.Resources.String030 Then Label10.Text = "2100"
        If Label9.Text = Computer_1.My.Resources.String031 Then Label10.Text = "2000"
        If Label9.Text = Computer_1.My.Resources.String033 Then Label10.Text = "1250"
        If Label9.Text = Computer_1.My.Resources.String045 Then Label10.Text = "9800"
        If Label9.Text = Computer_1.My.Resources.String046 Then Label10.Text = "9100"
        If Label9.Text = Computer_1.My.Resources.String047 Then Label10.Text = "8900"
        If Label9.Text = Computer_1.My.Resources.String048 Then Label10.Text = "9000"
        If Label9.Text = Computer_1.My.Resources.String049 Then Label10.Text = "7800"
        If Label9.Text = Computer_1.My.Resources.String050 Then Label10.Text = "6500"
        If Label9.Text = Computer_1.My.Resources.String051 Then Label10.Text = "5750"
        If Label9.Text = Computer_1.My.Resources.String052 Then Label10.Text = "4500"
        If Label9.Text = Computer_1.My.Resources.String054 Then Label10.Text = "4500"
        If Label9.Text = Computer_1.My.Resources.String055 Then Label10.Text = "3500"
        If Label9.Text = Computer_1.My.Resources.String056 Then Label10.Text = "3100"
        If Label9.Text = Computer_1.My.Resources.String057 Then Label10.Text = "2800"
        If Label9.Text = Computer_1.My.Resources.String059 Then Label10.Text = "2000"
        If Label11.Text = Computer_1.My.Resources.String006 Then Label12.Text = "10600"
        If Label11.Text = Computer_1.My.Resources.String007 Then Label12.Text = "7700"
        If Label11.Text = Computer_1.My.Resources.String008 Then Label12.Text = "6500"
        If Label11.Text = Computer_1.My.Resources.String009 Then Label12.Text = "5000"
        If Label11.Text = Computer_1.My.Resources.String010 Then Label12.Text = "4800"
        If Label11.Text = Computer_1.My.Resources.String015 Then Label12.Text = "7000"
        If Label11.Text = Computer_1.My.Resources.String016 Then Label12.Text = "5500"
        If Label11.Text = Computer_1.My.Resources.String017 Then Label12.Text = "5750"
        If Label11.Text = Computer_1.My.Resources.String018 Then Label12.Text = "4500"
        If Label11.Text = Computer_1.My.Resources.String034 Then Label12.Text = "1600"
        If Label11.Text = Computer_1.My.Resources.String035 Then Label12.Text = "1750"
        If Label11.Text = Computer_1.My.Resources.String036 Then Label12.Text = "2600"
        If Label11.Text = Computer_1.My.Resources.String037 Then Label12.Text = "2800"
        If Label11.Text = Computer_1.My.Resources.String038 Then Label12.Text = "2900"
        If Label11.Text = Computer_1.My.Resources.String039 Then Label12.Text = "3000"
        If Label11.Text = Computer_1.My.Resources.String040 Then Label12.Text = "3400"
        If Label11.Text = Computer_1.My.Resources.String041 Then Label12.Text = "3500"
        If Label11.Text = Computer_1.My.Resources.String042 Then Label12.Text = "3800"
        If Label11.Text = Computer_1.My.Resources.String060 Then Label12.Text = "12500"
        If Label11.Text = Computer_1.My.Resources.String061 Then Label12.Text = "6500"
        If Label11.Text = Computer_1.My.Resources.String062 Then Label12.Text = "5800"
        If Label11.Text = Computer_1.My.Resources.String063 Then Label12.Text = "4500"
        If Label11.Text = Computer_1.My.Resources.String064 Then Label12.Text = "4300"
        If Label11.Text = Computer_1.My.Resources.String065 Then Label12.Text = "4000"
        If Label11.Text = Computer_1.My.Resources.String066 Then Label12.Text = "3700"
        If Label11.Text = Computer_1.My.Resources.String067 Then Label12.Text = "3200"
        If Label11.Text = Computer_1.My.Resources.String068 Then Label12.Text = "3500"
        If Label11.Text = Computer_1.My.Resources.String069 Then Label12.Text = "2500"
        If Label11.Text = Computer_1.My.Resources.String070 Then Label12.Text = "2400"
        If Label11.Text = Computer_1.My.Resources.String071 Then Label12.Text = "2000"
        If Form1.RamC.Text = Computer_1.My.Resources.String076 And Form1.RamS.Text = Computer_1.My.Resources.String079 And Form1.RamB.Text = Computer_1.My.Resources.String086 And Form1.DDR.Text = "DDR2" Then Label14.Text = "850"
        If Form1.RamC.Text = Computer_1.My.Resources.String076 And Form1.RamS.Text = Computer_1.My.Resources.String080 And Form1.RamB.Text = Computer_1.My.Resources.String086 And Form1.DDR.Text = "DDR2" Then Label14.Text = "1450"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String079 And Form1.RamB.Text = Computer_1.My.Resources.String085 And Form1.DDR.Text = "DDR2" Then Label14.Text = "450"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String080 And Form1.RamB.Text = Computer_1.My.Resources.String085 And Form1.DDR.Text = "DDR2" Then Label14.Text = "900"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String079 And Form1.RamB.Text = Computer_1.My.Resources.String086 And Form1.DDR.Text = "DDR2" Then Label14.Text = "750"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String080 And Form1.RamB.Text = Computer_1.My.Resources.String086 And Form1.DDR.Text = "DDR2" Then Label14.Text = "1200"
        If Form1.RamC.Text = Computer_1.My.Resources.String075 And Form1.RamS.Text = Computer_1.My.Resources.String080 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1000"
        If Form1.RamC.Text = Computer_1.My.Resources.String075 And Form1.RamS.Text = Computer_1.My.Resources.String081 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1600"
        If Form1.RamC.Text = Computer_1.My.Resources.String075 And Form1.RamS.Text = Computer_1.My.Resources.String082 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1750"
        If Form1.RamC.Text = Computer_1.My.Resources.String076 And Form1.RamS.Text = Computer_1.My.Resources.String080 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1200"
        If Form1.RamC.Text = Computer_1.My.Resources.String076 And Form1.RamS.Text = Computer_1.My.Resources.String081 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1900"
        If Form1.RamC.Text = Computer_1.My.Resources.String076 And Form1.RamS.Text = Computer_1.My.Resources.String082 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "2400"
        If Form1.RamC.Text = Computer_1.My.Resources.String077 And Form1.RamS.Text = Computer_1.My.Resources.String080 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "950"
        If Form1.RamC.Text = Computer_1.My.Resources.String077 And Form1.RamS.Text = Computer_1.My.Resources.String081 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1550"
        If Form1.RamC.Text = Computer_1.My.Resources.String077 And Form1.RamS.Text = Computer_1.My.Resources.String082 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1900"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String080 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "650"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String081 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1100"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String082 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3" Then Label14.Text = "1300"
        If Form1.RamC.Text = Computer_1.My.Resources.String075 And Form1.RamS.Text = Computer_1.My.Resources.String082 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3*" Then Label14.Text = "1750"
        If Form1.RamC.Text = Computer_1.My.Resources.String075 And Form1.RamS.Text = Computer_1.My.Resources.String083 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3*" Then Label14.Text = "2750"
        If Form1.RamC.Text = Computer_1.My.Resources.String075 And Form1.RamS.Text = Computer_1.My.Resources.String084 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3*" Then Label14.Text = "3500"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String082 And Form1.RamB.Text = Computer_1.My.Resources.String088 And Form1.DDR.Text = "DDR3*" Then Label14.Text = "1300"
        If Form1.RamC.Text = Computer_1.My.Resources.String078 And Form1.RamS.Text = Computer_1.My.Resources.String082 And Form1.RamB.Text = Computer_1.My.Resources.String091 And Form1.DDR.Text = "DDR3*" Then Label14.Text = "5000"
        If Form1.HDM.Text = Computer_1.My.Resources.String095 Then Label17.Text = "4500"
        If Form1.HDM.Text = Computer_1.My.Resources.String096 Then Label17.Text = "3000"
        If Form1.HDM.Text = Computer_1.My.Resources.String097 And Form1.Sata.Text = "3" Then Label17.Text = "2300"
        If Form1.HDM.Text = Computer_1.My.Resources.String099 And Form1.Sata.Text = "3" Then Label17.Text = "1800"
        If Form1.HDM.Text = Computer_1.My.Resources.String102 Then Label17.Text = "2800"
        If Form1.HDM.Text = Computer_1.My.Resources.String104 And Form1.Sata.Text = "2" Then Label17.Text = "2000"
        If Form1.HDM.Text = Computer_1.My.Resources.String106 Then Label17.Text = "2800"
        If Form1.HDM.Text = Computer_1.My.Resources.String107 Then Label17.Text = "2200"
        If Form1.HDM.Text = Computer_1.My.Resources.String108 And Form1.Sata.Text = "2" Then Label17.Text = "1900"
        If Form1.HDM.Text = Computer_1.My.Resources.String109 Then Label17.Text = "1700"
        If Form1.HDM.Text = Computer_1.My.Resources.String110 Then Label17.Text = "1600"
        If Form1.HDM.Text = Computer_1.My.Resources.String111 Then Label17.Text = "1550"
        If Label16.Text = "Internal Graphic" Then Label19.Text = "0.0"
        If Form1.GPUM.Text = Computer_1.My.Resources.String113 Then Label19.Text = "1600"
        If Form1.GPUM.Text = Computer_1.My.Resources.String114 Then Label19.Text = "1900"
        If Form1.GPUM.Text = Computer_1.My.Resources.String115 Then Label19.Text = "2300"
        If Form1.GPUM.Text = Computer_1.My.Resources.String116 Then Label19.Text = "3200"
        If Form1.GPUM.Text = Computer_1.My.Resources.String117 Then Label19.Text = "3300"
        If Form1.GPUM.Text = Computer_1.My.Resources.String118 Then Label19.Text = "9500"
        If Form1.GPUM.Text = Computer_1.My.Resources.String119 Then Label19.Text = "10000"
        If Form1.GPUM.Text = Computer_1.My.Resources.String120 Then Label19.Text = "16500"
        If Form1.GPUM.Text = Computer_1.My.Resources.String121 Then Label19.Text = "24000"
        If Form1.GPUM.Text = Computer_1.My.Resources.String122 Then Label19.Text = "28000"
        If Form1.GPUM.Text = Computer_1.My.Resources.String124 Then Label19.Text = "1400"
        If Form1.GPUM.Text = Computer_1.My.Resources.String125 Then Label19.Text = "2100"
        If Form1.GPUM.Text = Computer_1.My.Resources.String126 Then Label19.Text = "3000"
        If Form1.GPUM.Text = Computer_1.My.Resources.String127 Then Label19.Text = "4500"
        If Form1.GPUM.Text = Computer_1.My.Resources.String128 Then Label19.Text = "4500"
        If Form1.GPUM.Text = Computer_1.My.Resources.String129 Then Label19.Text = "7500"
        If Form1.GPUM.Text = Computer_1.My.Resources.String130 Then Label19.Text = "9000"
        If Form1.GPUM.Text = Computer_1.My.Resources.String131 Then Label19.Text = "14000"
        If Form1.GPUM.Text = Computer_1.My.Resources.String132 Then Label19.Text = "18500"
        If Form1.GPUM.Text = Computer_1.My.Resources.String133 Then Label19.Text = "30000"
        If Label18.Text = Computer_1.My.Resources.String135 Then Label20.Text = "42000"
        If Label18.Text = Computer_1.My.Resources.String136 Then Label20.Text = "21000"
        If Label18.Text = Computer_1.My.Resources.String137 Then Label20.Text = "14600"
        If Label18.Text = Computer_1.My.Resources.String138 Then Label20.Text = "13500"
        If Label18.Text = Computer_1.My.Resources.String139 Then Label20.Text = "9600"
        If Label18.Text = Computer_1.My.Resources.String140 Then Label20.Text = "9500"
        If Label18.Text = Computer_1.My.Resources.String141 Then Label20.Text = "8200"
        If Label18.Text = Computer_1.My.Resources.String142 Then Label20.Text = "4200"
        If Label18.Text = Computer_1.My.Resources.String143 Then Label20.Text = "3500"
        If Label18.Text = Computer_1.My.Resources.String144 Then Label20.Text = "2500"
        If Label18.Text = Computer_1.My.Resources.String145 Then Label20.Text = "1300"
        If Label21.Text = Computer_1.My.Resources.String147 Then Label22.Text = "2500"
        If Label21.Text = Computer_1.My.Resources.String148 Then Label22.Text = "5000"
        If Label21.Text = Computer_1.My.Resources.String149 Then Label22.Text = "5300"
        If Label21.Text = Computer_1.My.Resources.String150 Then Label22.Text = "5400"
        If Label21.Text = Computer_1.My.Resources.String151 Then Label22.Text = "5500"
        If Label21.Text = Computer_1.My.Resources.String152 Then Label22.Text = "6100"
        If Label21.Text = Computer_1.My.Resources.String153 Then Label22.Text = "6600"
        If Label21.Text = Computer_1.My.Resources.String154 Then Label22.Text = "7000"
        If Label21.Text = Computer_1.My.Resources.String155 Then Label22.Text = "7400"
        If Label21.Text = Computer_1.My.Resources.String156 Then Label22.Text = "8100"
        If Label21.Text = Computer_1.My.Resources.String157 Then Label22.Text = "16000"
        If Label21.Text = Computer_1.My.Resources.String158 Then Label22.Text = "17000"
        If Label55.Text = Computer_1.My.Resources.String160 Then Label44.Text = "5100"
        If Label55.Text = Computer_1.My.Resources.String161 Then Label44.Text = "2600"
        If Label55.Text = Computer_1.My.Resources.String162 Then Label44.Text = "1000"
        If Label55.Text = Computer_1.My.Resources.String163 Then Label44.Text = "500"
        If Label55.Text = Computer_1.My.Resources.String164 Then Label44.Text = "400"
        If Label55.Text = Computer_1.My.Resources.String165 Then Label44.Text = "200"
        If Label55.Text = Computer_1.My.Resources.String166 Then Label44.Text = "1000"
        If Label55.Text = Computer_1.My.Resources.String167 Then Label44.Text = "500"
        If Label55.Text = Computer_1.My.Resources.String168 Then Label44.Text = "250"
        If Label54.Text = Computer_1.My.Resources.String170 Then Label43.Text = "1500"
        If Label54.Text = Computer_1.My.Resources.String171 Then Label43.Text = "800"
        If Label54.Text = Computer_1.My.Resources.String172 Then Label43.Text = "250"
        If Label54.Text = Computer_1.My.Resources.String173 Then Label43.Text = "100"
        If Label54.Text = Computer_1.My.Resources.String174 Then Label43.Text = "650"
        If Label54.Text = Computer_1.My.Resources.String175 Then Label43.Text = "500"
        If Label54.Text = Computer_1.My.Resources.String176 Then Label43.Text = "200"
        If Label53.Text = Computer_1.My.Resources.String178 Then Label42.Text = "25"
        If Label53.Text = Computer_1.My.Resources.String179 Then Label42.Text = "125"
        If Label53.Text = Computer_1.My.Resources.String180 Then Label42.Text = "400"
        If Label52.Text = Computer_1.My.Resources.String182 Then Label41.Text = "300"
        If Label52.Text = Computer_1.My.Resources.String183 Then Label41.Text = "1400"
        If Label52.Text = Computer_1.My.Resources.String184 Then Label41.Text = "2000"
        If Label52.Text = Computer_1.My.Resources.String185 Then Label41.Text = "3700"
        If Label52.Text = Computer_1.My.Resources.String186 Then Label41.Text = "250"
        If Label52.Text = Computer_1.My.Resources.String187 Then Label41.Text = "1000"
        If Label52.Text = Computer_1.My.Resources.String188 Then Label41.Text = "650"
        If Label51.Text = Computer_1.My.Resources.String190 Then Label40.Text = "2100"
        If Label51.Text = Computer_1.My.Resources.String191 Then Label40.Text = "2800"
        If Label51.Text = Computer_1.My.Resources.String192 Then Label40.Text = "4200"
        If Label51.Text = Computer_1.My.Resources.String193 Then Label40.Text = "6800"
        If Label51.Text = Computer_1.My.Resources.String194 Then Label40.Text = "8600"
        If Label51.Text = Computer_1.My.Resources.String195 Then Label40.Text = "11500"
        If Label50.Text = Computer_1.My.Resources.String197 Then Label39.Text = "350"
        If Label50.Text = Computer_1.My.Resources.String198 Then Label39.Text = "525"
        If Label50.Text = Computer_1.My.Resources.String199 Then Label39.Text = "850"
        If Label50.Text = Computer_1.My.Resources.String200 Then Label39.Text = "1000"
        If Label49.Text = Computer_1.My.Resources.String202 Then Label38.Text = "100"
        If Label49.Text = Computer_1.My.Resources.String203 Then Label38.Text = "650"
        If Label48.Text = Computer_1.My.Resources.String205 Then Label37.Text = "2500"
        If Label48.Text = Computer_1.My.Resources.String206 Then Label37.Text = "2800"
        If Label48.Text = Computer_1.My.Resources.String207 Then Label37.Text = "4500"
        If Label34.Text = Computer_1.My.Resources.String209 Then Label35.Text = "1200"
        If Label34.Text = Computer_1.My.Resources.String210 Then Label35.Text = "6500"
        If Label34.Text = Computer_1.My.Resources.String211 Then Label35.Text = "10000"
        If Label47.Text = Computer_1.My.Resources.String213 Then Label36.Text = "100"
        If Label47.Text = Computer_1.My.Resources.String214 Then Label36.Text = "400"
        If Label47.Text = Computer_1.My.Resources.String215 Then Label36.Text = "1000"
        If Label21.Text = "None" Then Label22.Text = "0.0"
        If Label34.Text = "None" Then Label35.Text = "0.0"
        If Label55.Text = "None" Then Label44.Text = "0.0"
        If Label54.Text = "None" Then Label43.Text = "0.0"
        If Label53.Text = "None" Then Label42.Text = "0.0"
        If Label52.Text = "None" Then Label41.Text = "0.0"
        If Label51.Text = "None" Then Label40.Text = "0.0"
        If Label50.Text = "None" Then Label39.Text = "0.0"
        If Label49.Text = "None" Then Label38.Text = "0.0"
        If Label48.Text = "None" Then Label37.Text = "0.0"
        If Label47.Text = "None" Then Label36.Text = "0.0"
        X = Val(Label10.Text) + Val(Label12.Text) + Val(Label14.Text) + Val(Label17.Text) + Val(Label19.Text) + Val(Label20.Text) + Val(Label22.Text) + Val(Label35.Text) + Val(Label44.Text) + Val(Label43.Text) + Val(Label42.Text) + Val(Label41.Text) + Val(Label40.Text) + Val(Label39.Text) + Val(Label38.Text) + Val(Label37.Text) + Val(Label36.Text)
        Label46.Text = X
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class