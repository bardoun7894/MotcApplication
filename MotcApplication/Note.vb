Imports System.Data.OleDb

Public Class Note
    Private Sub saveReciepientBtn_Click(sender As Object, e As EventArgs) Handles saveReciepientBtn.Click
        Dim noteSql As String = "INSERT INTO note_tbl (DATENOTE,FullName,MRNP,ConsultantName,RegistererName,SHOName,CoordinatorName ,AddNote)
values(@DATENOTE,@FullName,@MRN,@ConsultantName,@RegistererName,@SHOName,@CoordinatorName,@AddNote)"

        Try
            cmd = New OleDbCommand(noteSql, conn)
            cmd.Parameters.Add(New OleDbParameter("@DATENOTE", OleDbType.Date)).Value = dateDT.Text
            cmd.Parameters.Add(New OleDbParameter("@FullName", OleDbType.VarChar)).Value = fullnameTB.Text
            cmd.Parameters.Add(New OleDbParameter("@MRNP", OleDbType.VarChar)).Value = MRNTb.Text
            cmd.Parameters.Add(New OleDbParameter("@ConsultantName", OleDbType.VarChar)).Value = ConsultantNameTB.Text
            cmd.Parameters.Add(New OleDbParameter("@RegistererName", OleDbType.VarChar)).Value = RegistererNameTB.Text
            cmd.Parameters.Add(New OleDbParameter("@SHOName", OleDbType.VarChar)).Value = SHONameTb.Text
            cmd.Parameters.Add(New OleDbParameter("@CoordinatorName", OleDbType.VarChar)).Value = CoordinatorNameTB.Text
            cmd.Parameters.Add(New OleDbParameter("@AddNote", OleDbType.VarChar)).Value = addnoteTb.Text

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("the data has Inserted", MsgBoxStyle.Information)

            Dim a As Control
            For Each a In Me.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                End If
            Next

        Catch ex As Exception
            conn.Close()

            MsgBox(ex.ToString)

        End Try




    End Sub

    Private Sub panel3_Paint(sender As Object, e As PaintEventArgs) Handles panel3.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
