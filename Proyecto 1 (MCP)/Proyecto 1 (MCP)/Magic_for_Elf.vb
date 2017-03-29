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

    Private Sub Btn_Confirm_FirBElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_FirBElf.Click
        FirBElfSkill = 0
        FirBElfStat = 0
        Select Case Cbo_FirBElf.SelectedIndex
        'Beggin with the Fire Bolt Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 0
                    FIrBElfStat = FIrBElfStat + 0
                End If
            Case 1
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 0
                    FIrBElfStat = FIrBElfStat + 0.2
                End If
            Case 2
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 10
                    FIrBElfStat = FIrBElfStat + 0.6
                End If
            Case 3
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 30
                    FIrBElfStat = FIrBElfStat + 1
                End If
            Case 4
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 60
                    FIrBElfStat = FIrBElfStat + 1.4
                End If
            Case 5
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 120
                    FIrBElfStat = FIrBElfStat + 2
                End If
            Case 6
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 180
                    FIrBElfStat = FIrBElfStat + 2.6
                End If
            Case 7
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 220
                    FIrBElfStat = FIrBElfStat + 3.2
                End If
            Case 8
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 230
                    FIrBElfStat = FIrBElfStat + 4
                End If
            Case 9
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 240
                    FIrBElfStat = FIrBElfStat + 4.8
                End If
            Case 10
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 250
                    FIrBElfStat = FIrBElfStat + 5.6
                End If
            Case 11
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 260
                    FIrBElfStat = FIrBElfStat + 6.4
                End If
            Case 12
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 270
                    FIrBElfStat = FIrBElfStat + 7.4
                End If
            Case 13
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 280
                    FIrBElfStat = FIrBElfStat + 8.4
                End If
            Case 14
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 290
                    FIrBElfStat = FIrBElfStat + 9.4
                End If
            Case 0
                If Btn_Confirm_FirBElf.Created Then
                    FirBElfSkill = FirBElfSkill + 300
                    FIrBElfStat = FIrBElfStat + 10.4
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_IceBElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_IceBElf.Click
        IceBElfSkill = 0
        IceBElfStat = 0
        Select Case Cbo_IceBElf.SelectedIndex
        'Beggin with the Ice Bolt Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 0
                    IceBElfStat = IceBElfStat + 0
                End If
            Case 1
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 0
                    IceBElfStat = IceBElfStat + 0.2
                End If
            Case 2
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 10
                    IceBElfStat = IceBElfStat + 0.6
                End If
            Case 3
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 20
                    IceBElfStat = IceBElfStat + 1
                End If
            Case 4
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 40
                    IceBElfStat = IceBElfStat + 1.4
                End If
            Case 5
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 50
                    IceBElfStat = IceBElfStat + 2
                End If
            Case 6
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 60
                    IceBElfStat = IceBElfStat + 2.6
                End If
            Case 7
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 70
                    IceBElfStat = IceBElfStat + 3.2
                End If
            Case 8
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 80
                    IceBElfStat = IceBElfStat + 4
                End If
            Case 9
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 90
                    IceBElfStat = IceBElfStat + 4.8
                End If
            Case 10
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 100
                    IceBElfStat = IceBElfStat + 5.6
                End If
            Case 11
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 110
                    IceBElfStat = IceBElfStat + 6.4
                End If
            Case 12
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 120
                    IceBElfStat = IceBElfStat + 7.4
                End If
            Case 13
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 130
                    IceBElfStat = IceBElfStat + 8.4
                End If
            Case 14
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 140
                    IceBElfStat = IceBElfStat + 9.4
                End If
            Case 15
                If Btn_Confirm_IceBElf.Created Then
                    IceBElfSkill = IceBElfSkill + 150
                    IceBElfStat = IceBElfStat + 10.4
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_LightBElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_LightBElf.Click
        LightBElfSkill = 0
        LightBElfStat = 0
        Select Case Cbo_LightBElf.SelectedIndex
        'Beggin with the Lightning Bolt Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 0
                    LightBElfStat = LightBElfStat + 0
                End If
            Case 1
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 20
                    LightBElfStat = LightBElfStat + 0.2
                End If
            Case 2
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 30
                    LightBElfStat = LightBElfStat + 0.6
                End If
            Case 3
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 40
                    LightBElfStat = LightBElfStat + 1
                End If
            Case 4
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 50
                    LightBElfStat = LightBElfStat + 1.4
                End If
            Case 5
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 70
                    LightBElfStat = LightBElfStat + 2
                End If
            Case 6
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 90
                    LightBElfStat = LightBElfStat + 2.6
                End If
            Case 7
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 110
                    LightBElfStat = LightBElfStat + 3.2
                End If
            Case 8
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 120
                    LightBElfStat = LightBElfStat + 4.0
                End If
            Case 9
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 150
                    LightBElfStat = LightBElfStat + 4.8
                End If
            Case 10
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 170
                    LightBElfStat = LightBElfStat + 5.6
                End If
            Case 11
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 200
                    LightBElfStat = LightBElfStat + 6.4
                End If
            Case 12
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 230
                    LightBElfStat = LightBElfStat + 7.4
                End If
            Case 13
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 260
                    LightBElfStat = LightBElfStat + 8.4
                End If
            Case 14
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 290
                    LightBElfStat = LightBElfStat + 9.4
                End If
            Case 15
                If Btn_Confirm_LightBElf.Created Then
                    LightBElfSkill = LightBElfSkill + 320
                    LightBElfStat = LightBElfStat + 10.4
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_FireBaElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_FireBaElf.Click
        FireBaElfSkill = 0
        FIreBaElfStat = 0
        Select Case Cbo_FireBaElf.SelectedIndex
        'Beggin with the Fire Ball Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 100
                    FIreBaElfStat = FIreBaElfStat + 0
                End If
            Case 1
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 120
                    FIreBaElfStat = FIreBaElfStat + 0.6
                End If
            Case 2
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 140
                    FIreBaElfStat = FIreBaElfStat + 1.2
                End If
            Case 3
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 160
                    FIreBaElfStat = FIreBaElfStat + 1.8
                End If
            Case 4
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 180
                    FIreBaElfStat = FIreBaElfStat + 2.4
                End If
            Case 5
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 200
                    FIreBaElfStat = FIreBaElfStat + 3.2
                End If
            Case 6
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 220
                    FIreBaElfStat = FIreBaElfStat + 4.0
                End If
            Case 7
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 240
                    FIreBaElfStat = FIreBaElfStat + 4.8
                End If
            Case 8
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 260
                    FIreBaElfStat = FIreBaElfStat + 5.8
                End If
            Case 9
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 280
                    FIreBaElfStat = FIreBaElfStat + 6.8
                End If
            Case 10
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 300
                    FIreBaElfStat = FIreBaElfStat + 7.8
                End If
            Case 11
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 330
                    FIreBaElfStat = FIreBaElfStat + 8.8
                End If
            Case 12
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 360
                    FIreBaElfStat = FIreBaElfStat + 11.8
                End If
            Case 13
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 400
                    FIreBaElfStat = FIreBaElfStat + 14.8
                End If
            Case 14
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 450
                    FIreBaElfStat = FIreBaElfStat + 17.8
                End If
            Case 15
                If Btn_Confirm_FireBaElf.Created Then
                    FireBaElfSkill = FireBaElfSkill + 500
                    FIreBaElfStat = FIreBaElfStat + 20.8
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_IceSpElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_IceSpElf.Click
        IceSpElfSkill = 0
        IceSpElfStat = 0
        Select Case Cbo_IceSpElf.SelectedIndex
        'Beggin with the Ice Spear Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 0
                    IceSpElfStat = IceSpElfStat = 0
                End If
            Case 1
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 10
                    IceSpElfStat = IceSpElfStat = 0.2
                End If
            Case 2
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 20
                    IceSpElfStat = IceSpElfStat = 0.4
                End If
            Case 3
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 30
                    IceSpElfStat = IceSpElfStat = 0.6
                End If
            Case 4
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 40
                    IceSpElfStat = IceSpElfStat = 0.8
                End If
            Case 5
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 50
                    IceSpElfStat = IceSpElfStat = 1
                End If
            Case 6
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 60
                    IceSpElfStat = IceSpElfStat = 1.2
                End If
            Case 7
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 70
                    IceSpElfStat = IceSpElfStat = 1.6
                End If
            Case 8
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 80
                    IceSpElfStat = IceSpElfStat = 2
                End If
            Case 9
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 90
                    IceSpElfStat = IceSpElfStat = 2.4
                End If
            Case 10
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 100
                    IceSpElfStat = IceSpElfStat = 2.8
                End If
            Case 11
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 110
                    IceSpElfStat = IceSpElfStat = 5.9
                End If
            Case 12
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 120
                    IceSpElfStat = IceSpElfStat = 9.0
                End If
            Case 13
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 130
                    IceSpElfStat = IceSpElfStat = 12.1
                End If
            Case 14
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 140
                    IceSpElfStat = IceSpElfStat = 15.2
                End If
            Case 15
                If Btn_Confirm_IceSpElf.Created Then
                    IceSpElfSkill = IceSpElfSkill = 150
                    IceSpElfStat = IceSpElfStat = 18.3
                End If
        End Select
    End Sub

    Private Sub Btn_Confirm_ThunElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_ThunElf.Click
        ThunElfSkill = 0
        ThunElfStat = 0
        Select Case Cbo_ThunElf.SelectedIndex
        'Beggin with the thunder Skill for Elf'
        'Skill & Stat No Changes with races (Human/Elf/Giant is the same)'
            Case 0
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 50
                    ThunElfStat = ThunElfStat = 0
                End If
            Case 1
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 80
                    ThunElfStat = ThunElfStat = 3
                End If
            Case 2
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 110
                    ThunElfStat = ThunElfStat = 6
                End If
            Case 3
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 140
                    ThunElfStat = ThunElfStat = 9
                End If
            Case 4
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 170
                    ThunElfStat = ThunElfStat = 12.5
                End If
            Case 5
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 200
                    ThunElfStat = ThunElfStat = 16
                End If
            Case 6
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 230
                    ThunElfStat = ThunElfStat = 20
                End If
            Case 7
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 260
                    ThunElfStat = ThunElfStat = 24.5
                End If
            Case 8
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 290
                    ThunElfStat = ThunElfStat = 29
                End If
            Case 9
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 320
                    ThunElfStat = ThunElfStat = 34
                End If
            Case 10
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 350
                    ThunElfStat = ThunElfStat = 40.5
                End If
            Case 11
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 380
                    ThunElfStat = ThunElfStat = 44.5
                End If
            Case 12
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 420
                    ThunElfStat = ThunElfStat = 49.5
                End If
            Case 13
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 460
                    ThunElfStat = ThunElfStat = 52.5
                End If
            Case 14
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 500
                    ThunElfStat = ThunElfStat = 56.5
                End If
            Case 15
                If Btn_Confirm_ThunElf.Created Then
                    ThunElfSkill = ThunElfSkill = 550
                    ThunElfStat = ThunElfStat = 60.5
                End If
        End Select
    End Sub
End Class