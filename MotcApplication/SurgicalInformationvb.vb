Imports System.Data.OleDb

Public Class SurgicalInformationvb
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Try
            Dim surgicalrSql As String = "INSERT INTO surgical_information_tbl 
(MRNP,TypeOfBlood,UnitOfBlood,BloodLoss,DateOfAdmission,DateofTransplant,TypeOfLT,CellSaver,ICUStay,
DateOfDischarge,GraftVolume,GraftWeright,NumberOfDuct,GraftUsed,GRWR,PatientsStatusafterSurgery,Biliary,
Rejection,NoofEpisode,CombinedLiverandKindey,BiliaryAnastomosis,TypeOfLtAdultChild,TypeOfLtRelate,Vascular,Infection) values
(@MRNP,@typeOfBlood,@unitOfBlood,@bloodLoos,@DateOfAdmission,@dot,@tol,@cellSaver,@icuStay,
@dateOfDischarge,@GraftVolume,@graftWeright,@numberOfDuct,@graftUsed,@grwr,@psas,@biliary,@rejection,
@noofEpisode,@clak,@biliaryAnastomosis,@typeOfLtAdultChild,@typeOfLtRelate,@vascular,@infection)"
            Dim asc As String = ""
            If (a2aRb.Checked) Then
                asc = a2aRb.Text
            ElseIf a2cRB.Checked Then
                asc = a2cRB.Text
            End If

            Dim asrelated As String = ""
            If (relatedRB.Checked) Then
                asrelated = relatedRB.Text
            ElseIf unrelatedRB.Checked Then
                asrelated = unrelatedRB.Text
            End If

            Dim textvascular As String = ""
            If othersRb.Checked Then
                textvascular = othersTextTB.Text
            ElseIf hatRB.Checked Then
                textvascular = hatRB.Text
            ElseIf PVTRB.Checked Then
                textvascular = PVTRB.Text
            End If
            cmd = New OleDbCommand(surgicalrSql, conn)
            cmd.Parameters.Add(New OleDbParameter("@MRNP", OleDbType.VarChar)).Value = MRNP.Text
            cmd.Parameters.Add(New OleDbParameter("@typeOfBlood", OleDbType.VarChar)).Value = typeOfBloodTB.Text
            cmd.Parameters.Add(New OleDbParameter("@unitOfBlood", OleDbType.VarChar)).Value = unitOfBloodTB.Text
            cmd.Parameters.Add(New OleDbParameter("@bloodLoos", OleDbType.VarChar)).Value = bloodLossTB.Text
            cmd.Parameters.Add(New OleDbParameter("@DateOfAdmission", OleDbType.Date)).Value = DateOfAdmissiondt.Value
            cmd.Parameters.Add(New OleDbParameter("@dot", OleDbType.Date)).Value = dateOfTransplantDt.Value
            cmd.Parameters.Add(New OleDbParameter("@tol", OleDbType.VarChar)).Value = typeOfLTTB.Text
            cmd.Parameters.Add(New OleDbParameter("@cellSaver", OleDbType.VarChar)).Value = cellSaverTB.Text
            cmd.Parameters.Add(New OleDbParameter("@icuStay", OleDbType.VarChar)).Value = iCUStayTB.Text
            cmd.Parameters.Add(New OleDbParameter("@dateOfDischarge", OleDbType.Date)).Value = dateofDischargeDT.Value
            cmd.Parameters.Add(New OleDbParameter("@GraftVolume", OleDbType.VarChar)).Value = GraftVolumeTB.Text
            cmd.Parameters.Add(New OleDbParameter("@graftWeright", OleDbType.VarChar)).Value = graftWerightTB.Text
            cmd.Parameters.Add(New OleDbParameter("@numberOfDuct", OleDbType.VarChar)).Value = numberOfDuctTB.Text
            cmd.Parameters.Add(New OleDbParameter("@graftUsed", OleDbType.VarChar)).Value = graftedUsedTB.Text
            cmd.Parameters.Add(New OleDbParameter("@grwr", OleDbType.VarChar)).Value = grwrTB.Text
            cmd.Parameters.Add(New OleDbParameter("@psas", OleDbType.VarChar)).Value = pSaSTB.Text
            cmd.Parameters.Add(New OleDbParameter("@biliary", OleDbType.VarChar)).Value = billiaryTB.Text
            cmd.Parameters.Add(New OleDbParameter("@rejection", OleDbType.VarChar)).Value = rejectionTB.Text
            cmd.Parameters.Add(New OleDbParameter("@noofEpisode", OleDbType.VarChar)).Value = NoEpisodeTB.Text
            cmd.Parameters.Add(New OleDbParameter("@clak", OleDbType.VarChar)).Value = cLAKTb.Text
            cmd.Parameters.Add(New OleDbParameter("@biliaryAnastomosis", OleDbType.VarChar)).Value = biliaryAnastomosisTB.Text

            cmd.Parameters.Add(New OleDbParameter("@typeOfLtAdultChild ", OleDbType.VarChar)).Value = asc

            cmd.Parameters.Add(New OleDbParameter("@typeOfLtRelate", OleDbType.VarChar)).Value = asrelated

            cmd.Parameters.Add(New OleDbParameter("@vascular", OleDbType.VarChar)).Value = textvascular

            cmd.Parameters.Add(New OleDbParameter("@infection", OleDbType.VarChar)).Value = infectionTB.Text




            conn.Open()
            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("the data has Inserted", MsgBoxStyle.Information)

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub nextTab_Click(sender As Object, e As EventArgs) Handles nextTab.Click
        TabControl1.SelectedTab = TabPage2
        backTab.Visible = True
        saveBtn.Visible = True

        nextTab.Visible = False



    End Sub

    Private Sub PVTRB_CheckedChanged(sender As Object, e As EventArgs) Handles PVTRB.CheckedChanged

    End Sub

    Private Sub backTab_Click(sender As Object, e As EventArgs) Handles backTab.Click
        TabControl1.SelectedTab = TabPage1
        backTab.Visible = False
        saveBtn.Visible = False
        nextTab.Visible = True

    End Sub

    Private Sub panel3_Paint(sender As Object, e As PaintEventArgs) Handles panel3.Paint

    End Sub

    Private Sub unitOfBloodTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles unitOfBloodTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class
