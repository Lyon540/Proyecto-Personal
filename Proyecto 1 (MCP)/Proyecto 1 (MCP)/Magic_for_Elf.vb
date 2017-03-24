Public Class Magic_for_Elf
    Private Sub Btn_Confirm_MagMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_MagMElf.Click
        MagMElfSkill = 0
        MagMElfStat = 0
        Select Case Cbo_MagMElf.SelectedIndex
            'Beggin with the Magic Mastery Skill for Elf'
            'Skill & Stat Changes with races (Giants Only, Human/Elf is the same)'
            Case 0
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 0
                    MagMElfStat = MagMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 0
                    MagMElfStat = MagMElfStat + 5
                End If
            Case 2
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 10
                    MagMElfStat = MagMElfStat + 10
                End If
            Case 3
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 30
                    MagMElfStat = MagMElfStat + 15
                End If
            Case 4
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 60
                    MagMElfStat = MagMElfStat + 20
                End If
            Case 5
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 120
                    MagMElfStat = MagMElfStat + 25
                End If
            Case 6
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 180
                    MagMElfStat = MagMElfStat + 30
                End If
            Case 7
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 220
                    MagMElfStat = MagMElfStat + 35.2
                End If
            Case 8
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 230
                    MagMElfStat = MagMElfStat + 40.4
                End If
            Case 9
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 240
                    MagMElfStat = MagMElfStat + 45.6
                End If
            Case 10
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 250
                    MagMElfStat = MagMElfStat + 50.8
                End If
            Case 11
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 260
                    MagMElfStat = MagMElfStat + 56.2
                End If
            Case 12
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 270
                    MagMElfStat = MagMElfStat + 61.6
                End If
            Case 13
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 280
                    MagMElfStat = MagMElfStat + 67.0
                End If
            Case 14
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 290
                    MagMElfStat = MagMElfStat + 72.4
                End If
            Case 15
                If Btn_Confirm_MagMElf.Created Then
                    MagMElfSkill = MagMElfSkill + 300
                    MagMElfStat = MagMElfStat + 78.4
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_MedElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_MedElf.Click
        MedElfSkill = 0
        MedElfStat = 0
        Select Case Cbo_MedElf.SelectedIndex
            'Beggin with the Meditation Skill for Elf'
            'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 0
                    MedElfStat = MedElfStat + 0
                End If
            Case 1
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 0
                    MedElfStat = MedElfStat + 2.5
                End If
            Case 2
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 0
                    MedElfStat = MedElfStat + 5.0
                End If
            Case 3
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 0
                    MedElfStat = MedElfStat + 7.5
                End If
            Case 4
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 0
                    MedElfStat = MedElfStat + 10
                End If
            Case 5
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 0
                    MedElfStat = MedElfStat + 13.5
                End If
            Case 6
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 0
                    MedElfStat = MedElfStat + 17.0
                End If
            Case 7
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 23
                    MedElfStat = MedElfStat + 20.5
                End If
            Case 8
                If Btn_Confirm_MedElf.Created Then
                    MedElfSkill = MedElfSkill + 26
                    MedElfStat = MedElfStat + 24.0
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_EnchElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_EnchElf.Click
        EnchElfSkill = 0
        EnchElfStat = 0
        Select Case Cbo_EnchElf.SelectedIndex
            'Beggin with the Enchant Skill for Elf'
            'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 0
                End If
            Case 1
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 0.3
                End If
            Case 2
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 0.6
                End If
            Case 3
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 0.9
                End If
            Case 4
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 1.2
                End If
            Case 5
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 1.5
                End If
            Case 6
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 1.8
                End If
            Case 7
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 2.1
                End If
            Case 8
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 2.4
                End If
            Case 9
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 2.7
                End If
            Case 10
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 3.0
                End If
            Case 11
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 3.3
                End If
            Case 12
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 3.6
                End If
            Case 13
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 3.9
                End If
            Case 14
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 4.2
                End If
            Case 15
                If Btn_Confirm_EnchElf.Created Then
                    EnchElfSkill = EnchElfSkill + 0
                    EnchElfStat = EnchElfStat + 4.5
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_FireMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_FireMElf.Click
        FireMElfSkill = 0
        FireMElfStat = 0
        Select Case Cbo_FireMElf.SelectedIndex
            'Beggin with the Fire Mastery Skill for Elf'
            'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 0
                    FireMElfStat = FireMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 20
                    FireMElfStat = FireMElfStat + 1.7
                End If
            Case 2
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 30
                    FireMElfStat = FireMElfStat + 1.9
                End If
            Case 3
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 40
                    FireMElfStat = FireMElfStat + 2.1
                End If
            Case 4
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 50
                    FireMElfStat = FireMElfStat + 2.3
                End If
            Case 5
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 60
                    FireMElfStat = FireMElfStat + 2.5
                End If
            Case 6
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 70
                    FireMElfStat = FireMElfStat + 2.7
                End If
            Case 7
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 80
                    FireMElfStat = FireMElfStat + 4.4
                End If
            Case 8
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 90
                    FireMElfStat = FireMElfStat + 4.6
                End If
            Case 9
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 100
                    FireMElfStat = FireMElfStat + 4.8
                End If
            Case 10
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 120
                    FireMElfStat = FireMElfStat + 5.0
                End If
            Case 11
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 140
                    FireMElfStat = FireMElfStat + 6.7
                End If
            Case 12
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 160
                    FireMElfStat = FireMElfStat + 6.9
                End If
            Case 13
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 180
                    FireMElfStat = FireMElfStat + 7.1
                End If
            Case 14
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 200
                    FireMElfStat = FireMElfStat + 7.3
                End If
            Case 15
                If Btn_Confirm_FireMElf.Created Then
                    FireMElfSkill = FireMElfSkill + 250
                    FireMElfStat = FireMElfStat + 10.4
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_IceMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_IceMElf.Click
        IceMElfSkill = 0
        IceMElfStat = 0
        Select Case Cbo_IceMElf.SelectedIndex
        'Beggin with the Ice Mastery Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 0
                    IceMElfStat = IceMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 20
                    IceMElfStat = IceMElfStat + 1.7
                End If
            Case 2
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 30
                    IceMElfStat = IceMElfStat + 1.9
                End If
            Case 3
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 40
                    IceMElfStat = IceMElfStat + 2.1
                End If
            Case 4
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 50
                    IceMElfStat = IceMElfStat + 2.3
                End If
            Case 5
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 60
                    IceMElfStat = IceMElfStat + 2.5
                End If
            Case 6
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 70
                    IceMElfStat = IceMElfStat + 2.7
                End If
            Case 7
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 80
                    IceMElfStat = IceMElfStat + 4.4
                End If
            Case 8
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 90
                    IceMElfStat = IceMElfStat + 4.6
                End If
            Case 9
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 100
                    IceMElfStat = IceMElfStat + 4.8
                End If
            Case 10
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 120
                    IceMElfStat = IceMElfStat + 5.0
                End If
            Case 11
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 140
                    IceMElfStat = IceMElfStat + 6.7
                End If
            Case 12
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 160
                    IceMElfStat = IceMElfStat + 6.9
                End If
            Case 13
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 180
                    IceMElfStat = IceMElfStat + 7.1
                End If
            Case 14
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 200
                    IceMElfStat = IceMElfStat + 7.3
                End If
            Case 15
                If Btn_Confirm_IceMElf.Created Then
                    IceMElfSkill = IceMElfSkill + 250
                    IceMElfStat = IceMElfStat + 10.4
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_LightMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_LightMElf.Click
        LightMElfSkill = 0
        LightMElfStat = 0
        Select Case Cbo_LightMElf.SelectedIndex
        'Beggin with the Lightning Mastery Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 0
                    LightMElfStat = LightMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 20
                    LightMElfStat = LightMElfStat + 1.7
                End If
            Case 2
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 30
                    LightMElfStat = LightMElfStat + 1.9
                End If
            Case 3
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 40
                    LightMElfStat = LightMElfStat + 2.1
                End If
            Case 4
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 50
                    LightMElfStat = LightMElfStat + 2.3
                End If
            Case 5
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 60
                    LightMElfStat = LightMElfStat + 2.5
                End If
            Case 6
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 70
                    LightMElfStat = LightMElfStat + 2.7
                End If
            Case 7
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 80
                    LightMElfStat = LightMElfStat + 4.4
                End If
            Case 8
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 90
                    LightMElfStat = LightMElfStat + 4.6
                End If
            Case 9
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 100
                    LightMElfStat = LightMElfStat + 4.8
                End If
            Case 10
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 120
                    LightMElfStat = LightMElfStat + 5.0
                End If
            Case 11
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 140
                    LightMElfStat = LightMElfStat + 6.7
                End If
            Case 12
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 160
                    LightMElfStat = LightMElfStat + 6.9
                End If
            Case 13
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 180
                    LightMElfStat = LightMElfStat + 7.1
                End If
            Case 14
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 200
                    LightMElfStat = LightMElfStat + 7.3
                End If
            Case 15
                If Btn_Confirm_LightMElf.Created Then
                    LightMElfSkill = LightMElfSkill + 250
                    LightMElfStat = LightMElfStat + 10.4
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_BolMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_BolMElf.Click
        BolMElfSkill = 0
        BolMElfStat = 0
        Select Case Cbo_BolMElf.SelectedIndex
        'Beggin with the Bolt Mastery Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 0
                    BolMElfStat = BolMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 15
                    BolMElfStat = BolMElfStat + 0.5
                End If
            Case 2
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 20
                    BolMElfStat = BolMElfStat + 1.0
                End If
            Case 3
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 25
                    BolMElfStat = BolMElfStat + 1.5
                End If
            Case 4
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 30
                    BolMElfStat = BolMElfStat + 2.0
                End If
            Case 5
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 35
                    BolMElfStat = BolMElfStat + 2.5
                End If
            Case 6
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 40
                    BolMElfStat = BolMElfStat + 3.5
                End If
            Case 7
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 45
                    BolMElfStat = BolMElfStat + 4.0
                End If
            Case 8
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 50
                    BolMElfStat = BolMElfStat + 4.5
                End If
            Case 9
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 55
                    BolMElfStat = BolMElfStat + 5.0
                End If
            Case 10
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 60
                    BolMElfStat = BolMElfStat + 5.5
                End If
            Case 11
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 80
                    BolMElfStat = BolMElfStat + 6.5
                End If
            Case 12
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 100
                    BolMElfStat = BolMElfStat + 7.5
                End If
            Case 13
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 120
                    BolMElfStat = BolMElfStat + 8.5
                End If
            Case 14
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 140
                    BolMElfStat = BolMElfStat + 9.5
                End If
            Case 15
                If Btn_Confirm_BolMElf.Created Then
                    BolMElfSkill = BolMElfSkill + 160
                    BolMElfStat = BolMElfStat + 10.5
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_FusBElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_FusBElf.Click
        FusBElfSkill = 0
        FusBElfStat = 0
        Select Case Cbo_FusBElf.SelectedIndex
        'Beggin with the Fusion Bolt Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 0
                    FusBElfStat = FusBElfStat + 0
                End If
            Case 1
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 30
                    FusBElfStat = FusBElfStat + 0
                End If
            Case 2
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 40
                    FusBElfStat = FusBElfStat + 0
                End If
            Case 3
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 50
                    FusBElfStat = FusBElfStat + 0
                End If
            Case 4
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 60
                    FusBElfStat = FusBElfStat + 0.2
                End If
            Case 5
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 70
                    FusBElfStat = FusBElfStat + 0.4
                End If
            Case 6
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 80
                    FusBElfStat = FusBElfStat + 0.6
                End If
            Case 7
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 100
                    FusBElfStat = FusBElfStat + 1
                End If
            Case 8
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 115
                    FusBElfStat = FusBElfStat + 1.4
                End If
            Case 9
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 130
                    FusBElfStat = FusBElfStat + 1.8
                End If
            Case 10
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 145
                    FusBElfStat = FusBElfStat + 2.2
                End If
            Case 11
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 180
                    FusBElfStat = FusBElfStat + 2.8
                End If
            Case 12
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 195
                    FusBElfStat = FusBElfStat + 3.4
                End If
            Case 13
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 210
                    FusBElfStat = FusBElfStat + 4.0
                End If
            Case 14
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 225
                    FusBElfStat = FusBElfStat + 4.8
                End If
            Case 15
                If Btn_Confirm_FusBElf.Created Then
                    FusBElfSkill = FusBElfSkill + 250
                    FusBElfStat = FusBElfStat + 5.8
                End If
        End Select
    End Sub
End Class