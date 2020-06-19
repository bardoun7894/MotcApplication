
Imports System.Data.OleDb
Public Class DonorInformation

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Try
            Dim donorSql As String = "INSERT INTO donor_information_tbl 
            (FullName,MRNP,PatientIDNumber,TypeofID,MRND,ExMRN,DateOfBirth,Gender,Smoking,Height,Weight,BMI,Related
           ,TypeofRelationship,BloodGroup,ContactNumber,City,TakingMedication,PreviousSurgery,MedicalCondition)values
            (@fullName,@MRNP,@pin,@tod,@mrnd,@exmrn,@dob,@gender,@smoking,@height,@weight,@bmi,@Related,@torelation,@bloodG,
               @cNumber,@city,@takeMedication,@pSurgery,@medicalCondition)"
            Dim checkedGender As String = ""
            If donormaleRb.Checked Then
                checkedGender = "male"
            ElseIf donorfemaleRb.Checked Then
                checkedGender = "female"
            End If
            cmd = New OleDbCommand(donorSql, conn)
            cmd.Parameters.Add(New OleDbParameter("@fullName", OleDbType.VarChar)).Value = donorNameTB.Text
            cmd.Parameters.Add(New OleDbParameter("@MRNP", OleDbType.VarChar)).Value = MRNPTB.Text
            cmd.Parameters.Add(New OleDbParameter("@pin", OleDbType.BigInt)).Value = donorPidTB.Text
            cmd.Parameters.Add(New OleDbParameter("@tod", OleDbType.VarChar)).Value = donorTypeIdTB.Text
            cmd.Parameters.Add(New OleDbParameter("@mrnd", OleDbType.Integer)).Value = donorMRNTb.Text
            cmd.Parameters.Add(New OleDbParameter("@exmrn", OleDbType.Integer)).Value = donorExMRN.Text
            cmd.Parameters.Add(New OleDbParameter("@dob", OleDbType.Date)).Value = donordobDT.Value
            cmd.Parameters.Add(New OleDbParameter("@gender", OleDbType.VarChar)).Value = checkedGender
            cmd.Parameters.Add(New OleDbParameter("@smoking", OleDbType.VarChar)).Value = donorSmokCB.Text
            cmd.Parameters.Add(New OleDbParameter("@height", OleDbType.Integer)).Value = donorheightTB.Text
            cmd.Parameters.Add(New OleDbParameter("@weight", OleDbType.Integer)).Value = donorWeightTB.Text
            cmd.Parameters.Add(New OleDbParameter("@bmi", OleDbType.Integer)).Value = donorbmiTB.Text
            cmd.Parameters.Add(New OleDbParameter("@Related", OleDbType.VarChar)).Value = donorRolationCB.Text
            cmd.Parameters.Add(New OleDbParameter("@torelation", OleDbType.VarChar)).Value = donorTypeRelationTB.Text
            cmd.Parameters.Add(New OleDbParameter("@bloodG", OleDbType.VarChar)).Value = donorBloodGroupCB.Text
            cmd.Parameters.Add(New OleDbParameter("@cNumber", OleDbType.VarChar)).Value = donorContactNumberTB.Text
            cmd.Parameters.Add(New OleDbParameter("@city", OleDbType.VarChar)).Value = donorCityTB.Text
            cmd.Parameters.Add(New OleDbParameter("@takeMedication", OleDbType.VarChar)).Value = takingMedicationTb.Text
            cmd.Parameters.Add(New OleDbParameter("@pSurgery", OleDbType.VarChar)).Value = takingSurgeryTB.Text
            cmd.Parameters.Add(New OleDbParameter("@medicalCondition", OleDbType.VarChar)).Value = takingMedicationTb.Text

            conn.Open()
            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("the data has Inserted", MsgBoxStyle.Information)

        Catch ex As Exception
            conn.Close()
            MsgBox(ex.ToString)

        End Try

    End Sub




    Private Sub donorExMRN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donorExMRN.KeyPress
        Select Case Asc(e.KeyChar)

            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub donorPidTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donorPidTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub donorMRNTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donorMRNTb.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub donorWeightTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donorWeightTB.KeyPress
        Select Case Asc(e.KeyChar)

            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub donorheightTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donorheightTB.KeyPress
        Select Case Asc(e.KeyChar)

            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub donorbmiTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles donorbmiTB.KeyPress
        Select Case Asc(e.KeyChar)

            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class
