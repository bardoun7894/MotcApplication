Imports System.Data.OleDb

Public Class showNote


    Dim textsearch As String = ""


    Dim dtNote As New DataTable

    Sub FillDGV()
        Dim sql As String = "select * from note_tbl where MRNP like  '%" & textsearch & "%' "
        Dim s As String
        adaterNote = New OleDbDataAdapter(Sql, conn)
        adaterNote.Fill(dtNote)
        Me.dtNoteg.DataSource = dtNote

        cmd = New OleDbCommand(Sql, conn)
        conn.Open()
        dr = cmd.ExecuteReader
        While dr.Read()
            s = dr.Item("AddNote").ToString()
        End While
        dr.Close()
        conn.Close()

        RichTextBox1.Text = s



    End Sub

    Private Sub showNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDGV()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        dtNote.Clear()
        dtNoteg.Refresh()
        textsearch = TextBox1.Text
        FillDGV()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

End Class
