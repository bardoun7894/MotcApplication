Imports System.Data.OleDb

Public Class RecieptInformation


    Private Sub saveReciepientBtn_Click(sender As Object, e As EventArgs) Handles saveReciepientBtn.Click


        Dim recieptSql As String = "INSERT INTO recipient_information_tbl(
PatientIDNumber,MRNP,PatientName,Gender,DateOfBirth,Height,Weight,BMI,MELD,BloodGroup,ContactNumber,City,OriginalDisease,TypeofTransplant,TypeofOrgan
,DateofListing,motcList) values (@pin,@pMrn,@pName,@gender,@dob,@height,@weight,@bmi,@meld,@bloodG,@cNumber,@city,@oDisease,@tot,@too,@doListing,@motcList)"
        Dim checkedGender As String = ""

        If recieptmaleRb.Checked Then
            checkedGender = "male"
        ElseIf recieptfemaleRb.Checked Then
            checkedGender = "female"
        End If
        Try
            cmd = New OleDbCommand(recieptSql, conn)

            cmd.Parameters.Add(New OleDbParameter("@pin", OleDbType.VarChar)).Value = IDTb.Text
            cmd.Parameters.Add(New OleDbParameter("@pMrn", OleDbType.Integer)).Value = MRNTb.Text
            cmd.Parameters.Add(New OleDbParameter("@pName", OleDbType.VarChar)).Value = RecieptNameTB.Text
            cmd.Parameters.Add(New OleDbParameter("@gender", OleDbType.VarChar)).Value = checkedGender
            cmd.Parameters.Add(New OleDbParameter("@dob", OleDbType.VarChar)).Value = dobDT.Value
            cmd.Parameters.Add(New OleDbParameter("@height", OleDbType.Integer)).Value = heightTB.Text
            cmd.Parameters.Add(New OleDbParameter("@weight", OleDbType.Integer)).Value = WeightTB.Text
            cmd.Parameters.Add(New OleDbParameter("@bmi", OleDbType.Integer)).Value = bmiTB.Text
            cmd.Parameters.Add(New OleDbParameter("@meld", OleDbType.Integer)).Value = meldTB.Text
            cmd.Parameters.Add(New OleDbParameter("@bloodG", OleDbType.VarChar)).Value = bloodGCB.Text
            cmd.Parameters.Add(New OleDbParameter("@cNumber", OleDbType.VarChar)).Value = contactNumberTB.Text
            cmd.Parameters.Add(New OleDbParameter("@city", OleDbType.VarChar)).Value = cityTB.Text
            cmd.Parameters.Add(New OleDbParameter("@oDisease", OleDbType.VarChar)).Value = originalDiseaseTb.Text
            cmd.Parameters.Add(New OleDbParameter("@tot", OleDbType.VarChar)).Value = TypeTransplantTB.Text
            cmd.Parameters.Add(New OleDbParameter("@too", OleDbType.VarChar)).Value = TypeOrganTB.Text
            cmd.Parameters.Add(New OleDbParameter("@doListing", OleDbType.VarChar)).Value = listingDt.Value
            cmd.Parameters.Add(New OleDbParameter("@motcList", OleDbType.VarChar)).Value = motcListCB.Text

            conn.Open()

            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("the data has Inserted", MsgBoxStyle.Information)
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub patientIdTB_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub IDTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDTb.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub MRNTb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MRNTb.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub heightTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles heightTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub WeightTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WeightTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub bmiTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bmiTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub meldTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles meldTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub contactNumberTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contactNumberTB.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57  '0--9'
            Case 46   '(.)'
            Case 8     'backspace'
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub panel3_Paint(sender As Object, e As PaintEventArgs) Handles panel3.Paint

    End Sub
End Class
