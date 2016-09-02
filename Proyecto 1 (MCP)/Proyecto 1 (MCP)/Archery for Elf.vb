Public Class Archery_for_Elf
    Private Sub Btn_Confirm_RanElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_RanElf.Click
        'Fixed with the Variable same as zero for evade error for commulative'
        RanElfSkill = 0
        RanElfStat = 0
        Select Case Cbo_RanElf.SelectedIndex
            'Beggin with the Range Attack Skill for Elf'
            Case 0
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 0
                    RanElfStat = RanElfStat + 0
                End If
            Case 1
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 0
                    RanElfStat = RanElfStat + 0.1
                End If
            Case 2
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 10
                    RanElfStat = RanElfStat + 0.2
                End If
            Case 3
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 20
                    RanElfStat = RanElfStat + 0.3
                End If
            Case 4
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 40
                    RanElfStat = RanElfStat + 0.4
                End If
            Case 5
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 80
                    RanElfStat = RanElfStat + 0.5
                End If
            Case 6
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 120
                    RanElfStat = RanElfStat + 0.6
                End If
            Case 7
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 160
                    RanElfStat = RanElfStat + 0.8
                End If
            Case 8
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 200
                    RanElfStat = RanElfStat + 1
                End If
            Case 9
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 240
                    RanElfStat = RanElfStat + 1.2
                End If
            Case 10
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 250
                    RanElfStat = RanElfStat + 2.3
                End If
            Case 11
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 260
                    RanElfStat = RanElfStat + 3.4
                End If
            Case 12
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 270
                    RanElfStat = RanElfStat + 4.5
                End If
            Case 13
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 280
                    RanElfStat = RanElfStat + 5.6
                End If
            Case 14
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 290
                    RanElfStat = RanElfStat + 6.7
                End If
            Case 15
                If Btn_Confirm_RanElf.Created Then
                    RanElfSkill = RanElfSkill + 300
                    RanElfStat = RanElfStat + 12.2
                End If
        End Select
    End Sub
    Private Sub Btn_Confirm_MaSElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_MaSElf.Click
        MaSElfSkill = 0
        MaSElfStat = 0
        Select Case Cbo_MaSElf.SelectedIndex
            'Skill & Stat no Changes with races'
            'Beggin with the Magnum Shot Skill for Elf'
            Case 0
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 0
                    MaSElfStat = MaSElfStat + 0
                End If
            Case 1
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 5
                    MaSElfStat = MaSElfStat + 0
                End If
            Case 2
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 10
                    MaSElfStat = MaSElfStat + 0
                End If
            Case 3
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 30
                    MaSElfStat = MaSElfStat + 0
                End If
            Case 4
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 50
                    MaSElfStat = MaSElfStat + 0
                End If
            Case 5
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 70
                    MaSElfStat = MaSElfStat + 0
                End If
            Case 6
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 90
                    MaSElfStat = MaSElfStat + 0
                End If
            Case 7
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 110
                    MaSElfStat = MaSElfStat + 0.2
                End If
            Case 8
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 130
                    MaSElfStat = MaSElfStat + 0.4
                End If
            Case 9
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 150
                    MaSElfStat = MaSElfStat + 0.6
                End If
            Case 10
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 170
                    MaSElfStat = MaSElfStat + 0.8
                End If
            Case 11
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 200
                    MaSElfStat = MaSElfStat + 1
                End If
            Case 12
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 230
                    MaSElfStat = MaSElfStat + 1.2
                End If
            Case 13
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 260
                    MaSElfStat = MaSElfStat + 1.4
                End If
            Case 14
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 290
                    MaSElfStat = MaSElfStat + 1.6
                End If
            Case 15
                If Btn_Confirm_MaSElf.Created Then
                    MaSElfSkill = MaSElfSkill + 320
                    MaSElfStat = MaSElfStat + 1.9
                End If
        End Select
    End Sub
    Private Sub Btn_Confirm_SupSElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_SupSElf.Click
        SupSElfSkill = 0
        SupSElfStat = 0
        Select Case Cbo_SupSElf.SelectedIndex
            'Skill & Stat no Changes with races'
            'Beggin with the Magnum Shot Skill for Elf'
            Case 0
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 0
                    SupSElfStat = SupSElfStat + 0
                End If
            Case 1
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 0
                    SupSElfStat = SupSElfStat + 0.1
                End If
            Case 2
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 10
                    SupSElfStat = SupSElfStat + 0.2
                End If
            Case 3
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 20
                    SupSElfStat = SupSElfStat + 0.3
                End If
            Case 4
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 30
                    SupSElfStat = SupSElfStat + 0.4
                End If
            Case 5
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 50
                    SupSElfStat = SupSElfStat + 0.5
                End If
            Case 6
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 70
                    SupSElfStat = SupSElfStat + 0.6
                End If
            Case 7
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 90
                    SupSElfStat = SupSElfStat + 0.8
                End If
            Case 8
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 120
                    SupSElfStat = SupSElfStat + 1
                End If
            Case 9
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 150
                    SupSElfStat = SupSElfStat + 1.2
                End If
            Case 10
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 180
                    SupSElfStat = SupSElfStat + 1.4
                End If
            Case 11
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 210
                    SupSElfStat = SupSElfStat + 1.7
                End If
            Case 12
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 240
                    SupSElfStat = SupSElfStat + 2
                End If
            Case 13
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 270
                    SupSElfStat = SupSElfStat + 2.3
                End If
            Case 14
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 300
                    SupSElfStat = SupSElfStat + 2.7
                End If
            Case 15
                If Btn_Confirm_SupSElf.Created Then
                    SupSElfSkill = SupSElfSkill + 330
                    SupSElfStat = SupSElfStat + 3.2
                End If
        End Select
    End Sub
    Private Sub Btn_Confirm_CraSElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_CraSElf.Click
        CraSElfSkill = 0
        CraSElfStat = 0
        Select Case Cbo_CraSElf.SelectedIndex
            'Skill & Stat no Changes with races'
            'Beggin with the Crash Shot Skill for Elf'
            Case 0
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 0
                End If
            Case 1
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 0.1
                End If
            Case 2
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 0.2
                End If
            Case 3
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 0.3
                End If
            Case 4
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 0.4
                End If
            Case 5
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 0.5
                End If
            Case 6
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 0.6
                End If
            Case 7
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 1.8
                End If
            Case 8
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 2.5
                End If
            Case 9
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 3.2
                End If
            Case 10
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 3.9
                End If
            Case 11
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 5.2
                End If
            Case 12
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 6.5
                End If
            Case 13
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 7.8
                End If
            Case 14
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 9.1
                End If
            Case 15
                If Btn_Confirm_CraSElf.Created Then
                    CraSElfSkill = CraSElfSkill + 0
                    CraSElfStat = CraSElfStat + 11.1
                End If
        End Select
    End Sub
    Private Sub Btn_Confirm_BowMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_BowMElf.Click
        BowMElfSkill = 0
        BowMElfStat = 0
        Select Case Cbo_BowMElf.SelectedIndex
            'Skill & Stat no Changes with races'
            'Beggin with the Crash Shot Skill for Elf'
            Case 0
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 0
                    BowMElfStat = BowMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 20
                    BowMElfStat = BowMElfStat + 0
                End If
            Case 2
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 25
                    BowMElfStat = BowMElfStat + 0
                End If
            Case 3
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 30
                    BowMElfStat = BowMElfStat + 0
                End If
            Case 4
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 35
                    BowMElfStat = BowMElfStat + 0
                End If
            Case 5
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 40
                    BowMElfStat = BowMElfStat + 0
                End If
            Case 6
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 45
                    BowMElfStat = BowMElfStat + 0
                End If
            Case 7
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 50
                    BowMElfStat = BowMElfStat + 0.1
                End If
            Case 8
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 60
                    BowMElfStat = BowMElfStat + 0.2
                End If
            Case 9
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 70
                    BowMElfStat = BowMElfStat + 0.3
                End If
            Case 10
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 80
                    BowMElfStat = BowMElfStat + 0.4
                End If
            Case 11
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 100
                    BowMElfStat = BowMElfStat + 0.6
                End If
            Case 12
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 110
                    BowMElfStat = BowMElfStat + 0.8
                End If
            Case 13
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 120
                    BowMElfStat = BowMElfStat + 1.1
                End If
            Case 14
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 140
                    BowMElfStat = BowMElfStat + 1.4
                End If
            Case 15
                If Btn_Confirm_BowMElf.Created Then
                    BowMElfSkill = BowMElfSkill + 160
                    BowMElfStat = BowMElfStat + 1.9
                End If
        End Select
    End Sub
    Private Sub Btn_Confirm_CroMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_CroMElf.Click
        CroMElfSkill = 0
        CroMElfStat = 0
        Select Case Cbo_CroMElf.SelectedIndex
            'Skill & Stat no Changes with races'
            'Beggin with the Crash Shot Skill for Elf'
            Case 0
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 0
                    CroMElfStat = CroMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 20
                    CroMElfStat = CroMElfStat + 0
                End If
            Case 2
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 25
                    CroMElfStat = CroMElfStat + 0
                End If
            Case 3
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 30
                    CroMElfStat = CroMElfStat + 0
                End If
            Case 4
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 35
                    CroMElfStat = CroMElfStat + 0
                End If
            Case 5
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 40
                    CroMElfStat = CroMElfStat + 0
                End If
            Case 6
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 45
                    CroMElfStat = CroMElfStat + 0
                End If
            Case 7
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 50
                    CroMElfStat = CroMElfStat + 0.5
                End If
            Case 8
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 60
                    CroMElfStat = CroMElfStat + 1
                End If
            Case 9
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 70
                    CroMElfStat = CroMElfStat + 1.5
                End If
            Case 10
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 80
                    CroMElfStat = CroMElfStat + 2
                End If
            Case 11
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 100
                    CroMElfStat = CroMElfStat + 3
                End If
            Case 12
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 110
                    CroMElfStat = CroMElfStat + 4
                End If
            Case 13
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 120
                    CroMElfStat = CroMElfStat + 5.5
                End If
            Case 14
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 140
                    CroMElfStat = CroMElfStat + 7
                End If
            Case 15
                If Btn_Confirm_CroMElf.Created Then
                    CroMElfSkill = CroMElfSkill + 160
                    CroMElfStat = CroMElfStat + 9.5
                End If
        End Select
    End Sub
End Class