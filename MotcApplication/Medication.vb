Imports System.Data.OleDb

Public Class Medication


    Private Sub saveReciepientBtn_Click(sender As Object, e As EventArgs) Handles saveReciepientBtn.Click
        Dim s As String = ""
        For I As Integer = 0 To ListView1.Items.Count - 1
            ListView1.Items(I).Selected = True
            s += ListView1.Items(I).Text.ToString()
        Next

        Try
            Dim medicationSql As String = "INSERT INTO medication_tbl 
           (FullName,MRNP,DateOfClinic,medication_information ) 
            values
           (@FullName,@MRNP,@DateOfClinic,@medication_information)"

            cmd = New OleDbCommand(medicationSql, conn)
            cmd.Parameters.Add(New OleDbParameter("@FullName", OleDbType.VarChar)).Value = FullNameTB.Text
            cmd.Parameters.Add(New OleDbParameter("@MRNP", OleDbType.VarChar)).Value = MRNTB.Text
            cmd.Parameters.Add(New OleDbParameter("@DateOfClinic", OleDbType.Date)).Value = doClinicDT.Text
            cmd.Parameters.Add(New OleDbParameter("@medication_information", OleDbType.VarChar)).Value = s
            conn.Open()
            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("the data has Inserted", MsgBoxStyle.Information)

        Catch ex As Exception
            conn.Close()

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub addToListBtn_Click(sender As Object, e As EventArgs) Handles addToListBtn.Click
        Dim medInfo As String = "[drug name : " + drugTB.Text + " , Dose : " + routeTB.Text + " ] , "
        ListView1.Items.Add(medInfo)
        ListView1.Items.ToString()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
