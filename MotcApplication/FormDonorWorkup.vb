Imports System.Data.OleDb

Public Class FormDonorWorkup

    Public txtSearch As String = ""
    Dim dtDon As New DataTable
    Dim dtlabResult As New DataTable

    Dim StartingDate As String = ""
    Public xray As String = ""
    Public US As String = ""
    Dim CT As String = ""
    Dim MRI As String = ""
    Dim ECG As String = ""
    Dim Echo As String = ""
    Dim Anesthesia As String = ""
    Dim Smoking As String = ""
    Dim psychiatric As String = ""
    Dim PreviousSurgery As String = ""


    Private Sub FormDonorWorkup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        Me.ShowIcon = True
        fillDgv()
    End Sub
    Sub fillDgv()
        Try
            Dim sqlDonor As String = "select * from donor_information_tbl where MRNP like '%" & txtSearch & "%'"
            Dim sqllabResult As String = "select *  from labs_result_information where MRNP like '%" & txtSearch & "%'"
            Dim sqlWorkUP As String = "select * from myworkup_tbl where MRNP like '%" & txtSearch & "%'"

            adaterReciepient = New OleDbDataAdapter(sqlDonor, conn)
            adaterReciepient.Fill(dtDon)
            Me.donordtg.DataSource = dtDon

            adaterReciepient = New OleDbDataAdapter(sqllabResult, conn)
            adaterReciepient.Fill(dtlabResult)
            Me.labResultDGV.DataSource = dtlabResult

            cmd = New OleDbCommand(sqlWorkUP, conn)
            conn.Open()
            pla()
            workupTB.Text = StartingDate
            xraylb.Text = xray.Split(",")(0)
            usLb.Text = US.Split(",")(0)
            ctLbl.Text = CT.Split(",")(0)
            MRITB.Text = MRI.Split(",")(0)
            ECGTB.Text = ECG.Split(",")(0)
            echoTB.Text = Echo.Split(",")(0)
            anesthesiaTB.Text = Anesthesia.Split(",")(0)
            smokingTB.Text = Smoking.Split(",")(0)
            psychiatricTB.Text = psychiatric.Split(",")(0)
            PreviousSurgeryTB.Text = PreviousSurgery.Split(",")(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub



    Sub pla()

        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                StartingDate = dr("StartingDate").ToString
                xray = dr("XRay").ToString()
                US = dr("US").ToString()
                CT = dr("CT").ToString()
                MRI = dr("MRI").ToString()
                ECG = dr("ECG").ToString()
                Echo = dr("Echo").ToString()
                Anesthesia = dr("Anesthesia").ToString()
                Smoking = dr("Smoking").ToString()
                psychiatric = dr("Psychiatric").ToString()
                PreviousSurgery = dr("PreviousSurgery").ToString()
            End If
            dr.Close()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub mrnpSearchTB_TextChanged_1(sender As Object, e As EventArgs) Handles mrnpSearchTB.TextChanged

        dtDon.Clear()
        donordtg.Refresh()

        dtlabResult.Clear()
        labResultDGV.Refresh()

        txtSearch = mrnpSearchTB.Text
        fillDgv()
    End Sub
End Class
