Public Class Elf_Close_Combat_Skills
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Confirm_CMElf.Click
        'Fixed with the Variable same as zero for evade error for commulative'
        CCElfSkill = 0
        CCElfStat = 0
        Select Case Cbo_CMElf.SelectedIndex
            'Beggin with the Close Combat Skills for Elf'
            Case 0
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 0
                    CCElfStat = CCElfStat + 1
                End If
            Case 1
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 10
                    CCElfStat = CCElfStat + 2
                End If
            Case 2
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 30
                    CCElfStat = CCElfStat + 3
                End If
            Case 3
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 60
                    CCElfStat = CCElfStat + 4
                End If
            Case 4
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 120
                    CCElfStat = CCElfStat + 5
                End If
            Case 5
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 180
                    CCElfStat = CCElfStat + 6
                End If
            Case 6
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 220
                    CCElfStat = CCElfStat + 8
                End If
            Case 7
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 230
                    CCElfStat = CCElfStat + 10
                End If
            Case 8
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 240
                    CCElfStat = CCElfStat + 12
                End If
            Case 9
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 250
                    CCElfStat = CCElfStat + 14
                End If
            Case 10
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 260
                    CCElfStat = CCElfStat + 15.1
                End If
            Case 11
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 270
                    CCElfStat = CCElfStat + 16.2
                End If
            Case 12
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 280
                    CCElfStat = CCElfStat + 17.3
                End If
            Case 13
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 290
                    CCElfStat = CCElfStat + 18.4
                End If
            Case 14
                If Btn_Confirm_CMElf.Created Then
                    CCElfSkill = CCElfSkill + 300
                    CCElfStat = CCElfStat + 23.9
                End If
        End Select
        Label1.Text = CCElfSkill
        Label2.Text = CCElfStat
    End Sub
End Class