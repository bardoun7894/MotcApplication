Imports System.Data.OleDb

Public Class showClinic

    Dim dtReciep As New DataTable
    Dim dtMedict As New DataTable
    Dim txtsearch As String = ""
    Dim patientName As String = ""
    Dim gender As String = ""
    Dim city As String = ""
    Dim bmi As String = ""
    Dim bloodGroup As String = ""
    Dim dateOfBirth As String = ""
    Dim contactNumber As String = ""
    Dim originalDisease As String = ""
    Dim meld As String = ""
    Dim dateOfListing As String = ""
    Dim dateoftransplant As String = ""


    Sub fillDgv()
        Try
            Dim sqlreciepient As String = "select * from recipient_information_tbl where MRNP like '%" & txtsearch & "%'"
            Dim sqlWorkUP As String = "select * from lab_result_clinic where MRNP like '%" & txtsearch & "%'"
            Dim sqlmedication As String = "select DateOfClinic as DateOfClinic,medication_information as medication_information from  medication_tbl where MRNP like '%" & txtsearch & "%'"

            adaterReciepient = New OleDbDataAdapter(sqlWorkUP, conn)
            adaterReciepient.Fill(dtReciep)
            Me.dtReciepient.DataSource = dtReciep

            adaterReciepient = New OleDbDataAdapter(sqlmedication, conn)
            adaterReciepient.Fill(dtMedict)
            Me.medicationDT.DataSource = dtMedict

            cmd = New OleDbCommand(sqlreciepient, conn)
            conn.Open()
            pla()
            txtsearch = mrnpTB.Text
            data()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Sub data()
        patientnameTB.Text = patientName
        genderLB.Text = gender
        CityLB.Text = city
        bmiLB.Text = bmi
        bloodGrouplb.Text = bloodGroup
        dobLB.Text = dateOfBirth
        contactNumberlb.Text = contactNumber
        originalDiseaselb.Text = originalDisease
        MELDLB.Text = meld
        DateOfListinglb.Text = dateOfListing
        DateOfTransplantLB.Text = dateoftransplant
    End Sub

    Private Sub showClinic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False

        Me.ShowIcon = True
        fillDgv()
    End Sub

    Sub pla()
        Try
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                patientName = dr("PatientName").ToString()
                gender = dr("Gender").ToString()
                city = dr("city").ToString()
                bmi = dr("bmi").ToString()
                bloodGroup = dr("BloodGroup").ToString()
                dateOfBirth = dr("DateOfBirth").ToString()
                contactNumber = dr("ContactNumber").ToString()
                originalDisease = dr("OriginalDisease").ToString()
                meld = dr("MELD").ToString()
                dateOfListing = dr("DateofListing").ToString()
            End If
            dr.Close()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub mrnpTB_TextChanged(sender As Object, e As EventArgs) Handles mrnpTB.TextChanged

        dtReciep.Clear()
        dtReciepient.Refresh()
        dtMedict.Clear()
        medicationDT.Refresh()

        txtsearch = mrnpTB.Text
        fillDgv()
    End Sub
End Class
