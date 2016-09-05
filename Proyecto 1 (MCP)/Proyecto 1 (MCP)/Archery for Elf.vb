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
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
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
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
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
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
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
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
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
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
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
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
    End Sub
    Private Sub Btn_Confirm_FinSElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_FinSElf.Click
        FinSElfSkill = 0
        FinSElfStat = 0
        Select Case Cbo_FinSElf.SelectedIndex
            'Beggin with the Final Shot Skill (Elf Only Skill)'
            Case 0
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 0
                    FinSElfStat = FinSElfStat + 0
                End If
            Case 1
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 20
                    FinSElfStat = FinSElfStat + 0.2
                End If
            Case 2
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 50
                    FinSElfStat = FinSElfStat + 0.4
                End If
            Case 3
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 80
                    FinSElfStat = FinSElfStat + 0.6
                End If
            Case 4
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 100
                    FinSElfStat = FinSElfStat + 0.8
                End If
            Case 5
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 120
                    FinSElfStat = FinSElfStat + 1
                End If
            Case 6
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 150
                    FinSElfStat = FinSElfStat + 1.2
                End If
            Case 7
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 180
                    FinSElfStat = FinSElfStat + 2
                End If
            Case 8
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 200
                    FinSElfStat = FinSElfStat + 2.8
                End If
            Case 9
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 230
                    FinSElfStat = FinSElfStat + 3.6
                End If
            Case 10
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 260
                    FinSElfStat = FinSElfStat + 4.4
                End If
            Case 11
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 290
                    FinSElfStat = FinSElfStat + 6.2
                End If
            Case 12
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 320
                    FinSElfStat = FinSElfStat + 7.5
                End If
            Case 13
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 350
                    FinSElfStat = FinSElfStat + 8.8
                End If
            Case 14
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 380
                    FinSElfStat = FinSElfStat + 10.1
                End If
            Case 15
                If Btn_Confirm_FinSElf.Created Then
                    FinSElfSkill = FinSElfSkill + 430
                    FinSElfStat = FinSElfStat + 13.1
                End If
        End Select
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
    End Sub
    Private Sub Btn_Confirm_MirMElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_MirMElf.Click
        MirMElfSkill = 0
        MirMElfStat = 0
        Select Case Cbo_MirMElf.SelectedIndex
            'Beggin with the Mirage Missile Skill (Elf Only Skill)'
            Case 0
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 0
                    MirMElfStat = MirMElfStat + 0
                End If
            Case 1
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 5
                    MirMElfStat = MirMElfStat + 0.1
                End If
            Case 2
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 10
                    MirMElfStat = MirMElfStat + 0.2
                End If
            Case 3
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 30
                    MirMElfStat = MirMElfStat + 0.3
                End If
            Case 4
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 50
                    MirMElfStat = MirMElfStat + 0.4
                End If
            Case 5
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 70
                    MirMElfStat = MirMElfStat + 0.5
                End If
            Case 6
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 90
                    MirMElfStat = MirMElfStat + 0.8
                End If
            Case 7
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 110
                    MirMElfStat = MirMElfStat + 1.1
                End If
            Case 8
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 130
                    MirMElfStat = MirMElfStat + 1.4
                End If
            Case 9
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 150
                    MirMElfStat = MirMElfStat + 1.7
                End If
            Case 10
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 170
                    MirMElfStat = MirMElfStat + 2
                End If
            Case 11
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 200
                    MirMElfStat = MirMElfStat + 2.4
                End If
            Case 12
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 230
                    MirMElfStat = MirMElfStat + 2.8
                End If
            Case 13
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 260
                    MirMElfStat = MirMElfStat + 3.2
                End If
            Case 14
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 290
                    MirMElfStat = MirMElfStat + 3.6
                End If
            Case 15
                If Btn_Confirm_MirMElf.Created Then
                    MirMElfSkill = MirMElfSkill + 320
                    MirMElfStat = MirMElfStat + 5.1
                End If
        End Select
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
    End Sub
    Private Sub Btn_Confirm_SpiSElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_SpiSElf.Click
        SpiSElfSkill = 0
        SpiSElfStat = 0
        Select Case Cbo_SpiSElf.SelectedIndex
            'Skill & Stat no Changes with races'
            'Beggin with the Spider Shot Skill'
            Case 0
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 0
                End If
            Case 1
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 0.1
                End If
            Case 2
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 0.6
                End If
            Case 3
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 0.7
                End If
            Case 4
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 1.2
                End If
            Case 5
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 1.3
                End If
            Case 6
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 1.8
                End If
            Case 7
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 2.4
                End If
            Case 8
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 3
                End If
            Case 9
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 4.2
                End If
            Case 10
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 5.4
                End If
            Case 11
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 6.6
                End If
            Case 12
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 7.8
                End If
            Case 13
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 9
                End If
            Case 14
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 10.3
                End If
            Case 15
                If Btn_Confirm_SpiSElf.Created Then
                    SpiSElfSkill = SpiSElfSkill + 0
                    SpiSElfStat = SpiSElfStat + 12.3
                End If
        End Select
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
    End Sub
    Private Sub Btn_Confirm_UrgSElf_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_UrgSElf.Click
        UrgSElfSkill = 0
        UrgSElfStat = 0
        Select Case Cbo_UrgSElf.SelectedIndex
            'Skill & Stat no Changes with races'
            'Beggin with the Spider Shot Skill'
            Case 0
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 0
                    UrgSElfStat = UrgSElfStat + 0
                End If
            Case 1
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 0
                    UrgSElfStat = UrgSElfStat + 0.1
                End If
            Case 2
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 10
                    UrgSElfStat = UrgSElfStat + 0.2
                End If
            Case 3
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 20
                    UrgSElfStat = UrgSElfStat + 0.3
                End If
            Case 4
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 30
                    UrgSElfStat = UrgSElfStat + 0.4
                End If
            Case 5
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 40
                    UrgSElfStat = UrgSElfStat + 0.5
                End If
            Case 6
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 50
                    UrgSElfStat = UrgSElfStat + 0.6
                End If
            Case 7
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 70
                    UrgSElfStat = UrgSElfStat + 1.2
                End If
            Case 8
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 85
                    UrgSElfStat = UrgSElfStat + 1.8
                End If
            Case 9
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 100
                    UrgSElfStat = UrgSElfStat + 2.4
                End If
            Case 10
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 115
                    UrgSElfStat = UrgSElfStat + 3
                End If
            Case 11
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 145
                    UrgSElfStat = UrgSElfStat + 3.6
                End If
            Case 12
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 175
                    UrgSElfStat = UrgSElfStat + 4.3
                End If
            Case 13
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 205
                    UrgSElfStat = UrgSElfStat + 5
                End If
            Case 14
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 235
                    UrgSElfStat = UrgSElfStat + 5.7
                End If
            Case 15
                If Btn_Confirm_UrgSElf.Created Then
                    UrgSElfSkill = UrgSElfSkill + 265
                    UrgSElfStat = UrgSElfStat + 7
                End If
        End Select
        ArchElfSkill = RanElfSkill + MaSElfSkill + SupSElfSkill + CraSElfSkill + BowMElfSkill + CroMElfSkill + FinSElfSkill + MirMElfSkill + SpiSElfSkill + UrgSElfSkill
        Label1.Text = ArchElfSkill
        ArchElfStat = RanElfStat + MaSElfStat + SupSElfStat + CraSElfStat + BowMElfStat + CroMElfStat + FinSElfStat + MirMElfStat + SpiSElfStat + UrgSElfStat
        Label2.Text = ArchElfStat
    End Sub
    Private Sub Btn_ReturnElfSkills_Click(sender As Object, e As EventArgs) Handles Btn_ReturnElfSkills.Click
        Me.Hide()
        Elf_Skills.Show()
    End Sub
End Class