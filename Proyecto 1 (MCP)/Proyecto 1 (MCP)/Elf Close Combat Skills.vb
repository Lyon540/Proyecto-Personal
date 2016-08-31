Public Class Elf_Close_Combat_Skills
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_CMElf.Click
        'Fixed with the Variable same as zero for evade error for commulative'
        CMElfSkill = 0
        CMElfStat = 0
        Select Case Cbo_CMElf.SelectedIndex
            'Beggin with the Combat Mastery Skill for Elf'
            Case 0
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 0
                    CMElfStat = CMElfStat + 1
                End If
            Case 1
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 10
                    CMElfStat = CMElfStat + 2
                End If
            Case 2
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 30
                    CMElfStat = CMElfStat + 3
                End If
            Case 3
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 60
                    CMElfStat = CMElfStat + 4
                End If
            Case 4
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 120
                    CMElfStat = CMElfStat + 5
                End If
            Case 5
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 180
                    CMElfStat = CMElfStat + 6
                End If
            Case 6
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 220
                    CMElfStat = CMElfStat + 8
                End If
            Case 7
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 230
                    CMElfStat = CMElfStat + 10
                End If
            Case 8
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 240
                    CMElfStat = CMElfStat + 12
                End If
            Case 9
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 250
                    CMElfStat = CMElfStat + 14
                End If
            Case 10
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 260
                    CMElfStat = CMElfStat + 15.1
                End If
            Case 11
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 270
                    CMElfStat = CMElfStat + 16.2
                End If
            Case 12
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 280
                    CMElfStat = CMElfStat + 17.3
                End If
            Case 13
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 290
                    CMElfStat = CMElfStat + 18.4
                End If
            Case 14
                If Btn_Confirm_CMElf.Created Then
                    CMElfSkill = CMElfSkill + 300
                    CMElfStat = CMElfStat + 23.9
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_DefElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_DefElf.Click
        DefElfSkill = 0
        DefElfStat = 0
        Select Case Cbo_DefElf.SelectedIndex
            'Beggin with the Defense Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 30
                    DefElfStat = DefElfStat + 2
                End If
            Case 1
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 60
                    DefElfStat = DefElfStat + 4
                End If
            Case 2
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 80
                    DefElfStat = DefElfStat + 6
                End If
            Case 3
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 90
                    DefElfStat = DefElfStat + 8
                End If
            Case 4
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 100
                    DefElfStat = DefElfStat + 10
                End If
            Case 5
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 110
                    DefElfStat = DefElfStat + 12
                End If
            Case 6
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 120
                    DefElfStat = DefElfStat + 14
                End If
            Case 7
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 130
                    DefElfStat = DefElfStat + 16
                End If
            Case 8
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 140
                    DefElfStat = DefElfStat + 18
                End If
            Case 9
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 150
                    DefElfStat = DefElfStat + 20
                End If
            Case 10
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 160
                    DefElfStat = DefElfStat + 22
                End If
            Case 11
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 170
                    DefElfStat = DefElfStat + 25
                End If
            Case 12
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 180
                    DefElfStat = DefElfStat + 28
                End If
            Case 13
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 190
                    DefElfStat = DefElfStat + 31
                End If
            Case 14
                If Btn_Confirm_DefElf.Created Then
                    DefElfSkill = DefElfSkill + 200
                    DefElfStat = DefElfStat + 41
                End If
        End Select
        Label1.Text = CMElfSkill + DefElfSkill
        Label2.Text = CMElfStat + DefElfStat
    End Sub
    Private Sub Btn_Confirm_SMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_SMElf.Click
        SMElfSkill = 0
        SMElfStat = 0
        Select Case Cbo_SMElf.SelectedIndex
            'Beggin with the Smash Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 5
                    SMElfStat = SMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 10
                    SMElfStat = SMElfStat + 0
                End If
            Case 2
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 30
                    SMElfStat = SMElfStat + 0
                End If
            Case 3
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 50
                    SMElfStat = SMElfStat + 0
                End If
            Case 4
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 70
                    SMElfStat = SMElfStat + 0
                End If
            Case 5
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 90
                    SMElfStat = SMElfStat + 0
                End If
            Case 6
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 110
                    SMElfStat = SMElfStat + 0
                End If
            Case 7
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 130
                    SMElfStat = SMElfStat + 1.5
                End If
            Case 8
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 150
                    SMElfStat = SMElfStat + 3
                End If
            Case 9
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 170
                    SMElfStat = SMElfStat + 4.5
                End If
            Case 10
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 200
                    SMElfStat = SMElfStat + 6
                End If
            Case 11
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 230
                    SMElfStat = SMElfStat + 7.5
                End If
            Case 12
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 260
                    SMElfStat = SMElfStat + 9
                End If
            Case 13
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 290
                    SMElfStat = SMElfStat + 10.5
                End If
            Case 14
                If Btn_Confirm_SMElf.Created Then
                    SMElfSkill = SMElfSkill + 300
                    SMElfStat = SMElfStat + 12
                End If
        End Select
    End Sub
    Private Sub Btn_Confirm_CoAElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_CoAElf.Click
        CoAElfSkill = 0
        CoAElfStat = 0
        Select Case Cbo_CoAElf.SelectedIndex
            'Beggin with the Counter Attack Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 20
                    CoAElfStat = CoAElfStat + 0.1
                End If
            Case 1
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 25
                    CoAElfStat = CoAElfStat + 0.2
                End If
            Case 2
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 30
                    CoAElfStat = CoAElfStat + 0.3
                End If
            Case 3
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 35
                    CoAElfStat = CoAElfStat + 0.4
                End If
            Case 4
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 40
                    CoAElfStat = CoAElfStat + 0.5
                End If
            Case 5
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 45
                    CoAElfStat = CoAElfStat + 0.6
                End If
            Case 6
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 50
                    CoAElfStat = CoAElfStat + 0.7
                End If
            Case 7
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 55
                    CoAElfStat = CoAElfStat + 0.8
                End If
            Case 8
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 60
                    CoAElfStat = CoAElfStat + 0.9
                End If
            Case 9
                If Btn_Confirm_CMElf.Created Then
                    CoAElfSkill = CoAElfSkill + 65
                    CoAElfStat = CoAElfStat + 1.0
                End If
            Case 10
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 70
                    CoAElfStat = CoAElfStat + 1.1
                End If
            Case 11
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 75
                    CoAElfStat = CoAElfStat + 1.2
                End If
            Case 12
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 80
                    CoAElfStat = CoAElfStat + 1.3
                End If
            Case 14
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 85
                    CoAElfStat = CoAElfStat + 1.4
                End If
            Case 15
                If Btn_Confirm_CoAElf.Created Then
                    CoAElfSkill = CoAElfSkill + 90
                    CoAElfStat = CoAElfStat + 1.5
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_WinMElf_Click_1(sender As Object, e As EventArgs) Handles Btn_Confirm_WinMElf.Click
        WinMElfSkill = 0
        WinMElfStat = 0
        Select Case Cbo_WinMElf.SelectedIndex
            'Beggin with the Windmill Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 0
                    WinMElfStat = WinMElfStat + 2.5
                End If
            Case 1
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 5
                    WinMElfStat = WinMElfStat + 5
                End If
            Case 2
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 10
                    WinMElfStat = WinMElfStat + 7.5
                End If
            Case 3
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 15
                    WinMElfStat = WinMElfStat + 10
                End If
            Case 4
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 30
                    WinMElfStat = WinMElfStat + 12.5
                End If
            Case 5
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 50
                    WinMElfStat = WinMElfStat + 16
                End If
            Case 6
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 70
                    WinMElfStat = WinMElfStat + 19.5
                End If
            Case 7
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 90
                    WinMElfStat = WinMElfStat + 23
                End If
            Case 8
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 120
                    WinMElfStat = WinMElfStat + 26.5
                End If
            Case 9
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 150
                    WinMElfStat = WinMElfStat + 30
                End If
            Case 10
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 180
                    WinMElfStat = WinMElfStat + 35
                End If
            Case 11
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 220
                    WinMElfStat = WinMElfStat + 40
                End If
            Case 12
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 250
                    WinMElfStat = WinMElfStat + 45
                End If
            Case 13
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 300
                    WinMElfStat = WinMElfStat + 50
                End If
            Case 14
                If Btn_Confirm_WinMElf.Created Then
                    WinMElfSkill = WinMElfSkill + 350
                    WinMElfStat = WinMElfStat + 55
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_CharElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_CharElf.Click
        CharElfSkill = 0
        CharElfStat = 0
        Select Case Cbo_CharElf.SelectedIndex
            'Beggin with the Charge Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 0
                    CharElfStat = CharElfStat + 1
                End If
            Case 1
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 5
                    CharElfStat = CharElfStat + 2
                End If
            Case 2
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 10
                    CharElfStat = CharElfStat + 3
                End If
            Case 3
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 15
                    CharElfStat = CharElfStat + 4
                End If
            Case 4
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 30
                    CharElfStat = CharElfStat + 5
                End If
            Case 5
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 50
                    CharElfStat = CharElfStat + 6
                End If
            Case 6
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 70
                    CharElfStat = CharElfStat + 8
                End If
            Case 7
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 90
                    CharElfStat = CharElfStat + 10
                End If
            Case 8
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 120
                    CharElfStat = CharElfStat + 12
                End If
            Case 9
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 150
                    CharElfStat = CharElfStat + 14
                End If
            Case 10
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 180
                    CharElfStat = CharElfStat + 17.5
                End If
            Case 11
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 220
                    CharElfStat = CharElfStat + 21
                End If
            Case 12
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 250
                    CharElfStat = CharElfStat + 24.5
                End If
            Case 13
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 300
                    CharElfStat = CharElfStat + 28
                End If
            Case 14
                If Btn_Confirm_CharElf.Created Then
                    CharElfSkill = CharElfSkill + 350
                    CharElfStat = CharElfStat + 35.5
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_AsaSElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_AsaSElf.Click
        AsaSElfSkill = 0
        AsaSElfStat = 0
        Select Case Cbo_AsaSElf.SelectedIndex
            'Beggin with the Assault Slash Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 30
                    AsaSElfStat = AsaSElfStat + 0
                End If
            Case 1
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 40
                    AsaSElfStat = AsaSElfStat + 0
                End If
            Case 2
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 50
                    AsaSElfStat = AsaSElfStat + 0
                End If
            Case 3
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 60
                    AsaSElfStat = AsaSElfStat + 0
                End If
            Case 4
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 70
                    AsaSElfStat = AsaSElfStat + 0
                End If
            Case 5
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 80
                    AsaSElfStat = AsaSElfStat + 0
                End If
            Case 6
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 100
                    AsaSElfStat = AsaSElfStat + 1
                End If
            Case 7
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 115
                    AsaSElfStat = AsaSElfStat + 2
                End If
            Case 8
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 130
                    AsaSElfStat = AsaSElfStat + 3
                End If
            Case 9
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 145
                    AsaSElfStat = AsaSElfStat + 4
                End If
            Case 10
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 170
                    AsaSElfStat = AsaSElfStat + 6
                End If
            Case 11
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 190
                    AsaSElfStat = AsaSElfStat + 8
                End If
            Case 12
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 210
                    AsaSElfStat = AsaSElfStat + 10
                End If
            Case 13
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 230
                    AsaSElfStat = AsaSElfStat + 12
                End If
            Case 14
                If Btn_Confirm_AsaSElf.Created Then
                    AsaSElfSkill = AsaSElfSkill + 250
                    AsaSElfStat = AsaSElfStat + 17
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_SwMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_SwMElf.Click
        SwMElfSkill = 0
        SwMElfStat = 0
        Select Case Cbo_SwMElf.SelectedIndex
            'Beggin with the Sword Mastery Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 20
                    SwMElfStat = SwMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 25
                    SwMElfStat = SwMElfStat + 0
                End If
            Case 2
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 30
                    SwMElfStat = SwMElfStat + 0
                End If
            Case 3
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 35
                    SwMElfStat = SwMElfStat + 0
                End If
            Case 4
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 40
                    SwMElfStat = SwMElfStat + 0
                End If
            Case 5
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 45
                    SwMElfStat = SwMElfStat + 0
                End If
            Case 6
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 50
                    SwMElfStat = SwMElfStat + 0.1
                End If
            Case 7
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 60
                    SwMElfStat = SwMElfStat + 0.2
                End If
            Case 8
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 70
                    SwMElfStat = SwMElfStat + 0.3
                End If
            Case 9
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 80
                    SwMElfStat = SwMElfStat + 0.4
                End If
            Case 10
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 100
                    SwMElfStat = SwMElfStat + 0.6
                End If
            Case 11
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 110
                    SwMElfStat = SwMElfStat + 0.8
                End If
            Case 12
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 120
                    SwMElfStat = SwMElfStat + 1.1
                End If
            Case 13
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 140
                    SwMElfStat = SwMElfStat + 1.4
                End If
            Case 14
                If Btn_Confirm_SwMElf.Created Then
                    SwMElfSkill = SwMElfSkill + 160
                    SwMElfStat = SwMElfStat + 1.9
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_AxMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_AxMElf.Click
        AxMElfSkill = 0
        AxMElfStat = 0
        Select Case Cbo_AxMElf.SelectedIndex
            'Beggin with the Axe Mastery Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 20
                    AxMElfStat = AxMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 25
                    AxMElfStat = AxMElfStat + 0
                End If
            Case 2
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 30
                    AxMElfStat = AxMElfStat + 0
                End If
            Case 3
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 35
                    AxMElfStat = AxMElfStat + 0
                End If
            Case 4
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 40
                    AxMElfStat = AxMElfStat + 0
                End If
            Case 5
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 45
                    AxMElfStat = AxMElfStat + 0
                End If
            Case 6
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 50
                    AxMElfStat = AxMElfStat + 0.5
                End If
            Case 7
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 60
                    AxMElfStat = AxMElfStat + 1
                End If
            Case 8
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 70
                    AxMElfStat = AxMElfStat + 1.5
                End If
            Case 9
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 80
                    AxMElfStat = AxMElfStat + 2
                End If
            Case 10
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 100
                    AxMElfStat = AxMElfStat + 3
                End If
            Case 11
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 110
                    AxMElfStat = AxMElfStat + 4
                End If
            Case 12
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 120
                    AxMElfStat = AxMElfStat + 5.5
                End If
            Case 13
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 140
                    AxMElfStat = AxMElfStat + 7
                End If
            Case 14
                If Btn_Confirm_AxMElf.Created Then
                    AxMElfSkill = AxMElfSkill + 160
                    AxMElfStat = AxMElfStat + 9.5
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_BlMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_BlMElf.Click
        BlMElfSkill = 0
        BlMElfStat = 0
        Select Case Cbo_BlMElf.SelectedIndex
            'Beggin with the Blunt Mastery Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 20
                    BlMElfStat = BlMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 25
                    BlMElfStat = BlMElfStat + 0
                End If
            Case 2
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 30
                    BlMElfStat = BlMElfStat + 0
                End If
            Case 3
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 35
                    BlMElfStat = BlMElfStat + 0
                End If
            Case 4
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 40
                    BlMElfStat = BlMElfStat + 0
                End If
            Case 5
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 45
                    BlMElfStat = BlMElfStat + 0
                End If
            Case 6
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 50
                    BlMElfStat = BlMElfStat + 1
                End If
            Case 7
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 60
                    BlMElfStat = BlMElfStat + 2
                End If
            Case 8
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 70
                    BlMElfStat = BlMElfStat + 3
                End If
            Case 9
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 80
                    BlMElfStat = BlMElfStat + 4
                End If
            Case 10
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 100
                    BlMElfStat = BlMElfStat + 6
                End If
            Case 11
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 110
                    BlMElfStat = BlMElfStat + 8
                End If
            Case 12
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 120
                    BlMElfStat = BlMElfStat + 11
                End If
            Case 13
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 140
                    BlMElfStat = BlMElfStat + 14
                End If
            Case 14
                If Btn_Confirm_BlMElf.Created Then
                    BlMElfSkill = BlMElfSkill + 160
                    BlMElfStat = BlMElfStat + 19
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_EvaElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_EvaElf.Click
        EvaElfSkill = 0
        EvaElfStat = 0
        Select Case Cbo_EvaElf.SelectedIndex
            'Beggin with the Evasion Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 0
                    EvaElfStat = EvaElfStat + 0
                End If
            Case 1
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 5
                    EvaElfStat = EvaElfStat + 0
                End If
            Case 2
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 10
                    EvaElfStat = EvaElfStat + 0
                End If
            Case 3
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 15
                    EvaElfStat = EvaElfStat + 0
                End If
            Case 4
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 25
                    EvaElfStat = EvaElfStat + 0
                End If
            Case 5
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 40
                    EvaElfStat = EvaElfStat + 0
                End If
            Case 6
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 60
                    EvaElfStat = EvaElfStat + 0.1
                End If
            Case 7
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 80
                    EvaElfStat = EvaElfStat + 0.2
                End If
            Case 8
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 100
                    EvaElfStat = EvaElfStat + 0.3
                End If
            Case 9
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 130
                    EvaElfStat = EvaElfStat + 0.4
                End If
            Case 10
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 160
                    EvaElfStat = EvaElfStat + 0.5
                End If
            Case 11
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 190
                    EvaElfStat = EvaElfStat + 0.6
                End If
            Case 12
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 220
                    EvaElfStat = EvaElfStat + 0.7
                End If
            Case 13
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 250
                    EvaElfStat = EvaElfStat + 0.8
                End If
            Case 14
                If Btn_Confirm_EvaElf.Created Then
                    EvaElfSkill = EvaElfSkill + 300
                    EvaElfStat = EvaElfStat + 0.9
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_CrHElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_CrHElf.Click
        CrHElfSkill = 0
        CrHElfStat = 0
        Select Case Cbo_CrHElf.SelectedIndex
            'Beggin with the Critical Hit Skill for Elf'
            'Skill & Stat no Changes with races'
            Case 0
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 10
                    CrHElfStat = CrHElfStat + 1.5
                End If
            Case 1
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 20
                    CrHElfStat = CrHElfStat + 3
                End If
            Case 2
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 30
                    CrHElfStat = CrHElfStat + 4.5
                End If
            Case 3
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 40
                    CrHElfStat = CrHElfStat + 6
                End If
            Case 4
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 50
                    CrHElfStat = CrHElfStat + 7.5
                End If
            Case 5
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 60
                    CrHElfStat = CrHElfStat + 9
                End If
            Case 6
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 70
                    CrHElfStat = CrHElfStat + 10.5
                End If
            Case 7
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 80
                    CrHElfStat = CrHElfStat + 12
                End If
            Case 8
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 90
                    CrHElfStat = CrHElfStat + 13.5
                End If
            Case 9
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 100
                    CrHElfStat = CrHElfStat + 15
                End If
            Case 10
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 110
                    CrHElfStat = CrHElfStat + 16.5
                End If
            Case 11
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 120
                    CrHElfStat = CrHElfStat + 18
                End If
            Case 12
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 130
                    CrHElfStat = CrHElfStat + 19.5
                End If
            Case 13
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 140
                    CrHElfStat = CrHElfStat + 21
                End If
            Case 14
                If Btn_Confirm_CrHElf.Created Then
                    CrHElfSkill = CrHElfSkill + 150
                    CrHElfStat = CrHElfStat + 22.5
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_ShMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_ShMElf.Click

    End Sub
End Class