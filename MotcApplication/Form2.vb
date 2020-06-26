Imports System.Data.OleDb

Public Class Form2

    Dim dtReciep As New DataTable
    Dim dtDon As New DataTable
    Dim dttransplantList As New DataTable

    '  Dim dtReciep As New DataTable
    Dim textsearch As String = ""

    Sub FillDGV()


        adaterReciepient = New OleDbDataAdapter("select MRNP as PatientMRN,PatientName as PatientName,Gender as Gender,DateOfBirth as DateOfBirth,BMI as BMI,MELD as MELD,BloodGroup as BloodGroup,OriginalDisease as OriginalDisease,DateofListing as DateOfListing,City as City,motcList as motcList from recipient_information_tbl where MRNP like  '%" & textsearch & "%' ", conn)
        adaterReciepient.Fill(dtReciep)
        Me.dtReciepient.DataSource = dtReciep
        adaterDonor = New OleDbDataAdapter("select MRND as DonorMRN,FullName as donorName,Gender as Gender,DateOfBirth as DateOfBirth,BMI as BMI,BloodGroup as BloodGroup,Related as Related,TypeofRelationship as TypeofRelationship,City as City,ContactNumber as ContactNumber from donor_information_tbl where MRNP like  '%" & textsearch & "%' ", conn)
        adaterDonor.Fill(dtDon)
        Me.dtg.DataSource = dtDon


        adapterTransplantList = New OleDbDataAdapter("select * from transplantlist_tbl where MRNP like  '%" & textsearch & "%' ", conn)
        adapterTransplantList.Fill(dttransplantList)
        Me.dgvTransplantlist.DataSource = dttransplantList

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        Me.ShowIcon = True
        FillDGV()
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mrnpSearchTB_TextChanged(sender As Object, e As EventArgs) Handles mrnpSearchTB.TextChanged
        dtReciep.Clear()
        dtDon.Clear()
        dtg.Refresh()
        dtReciepient.Refresh()
        dttransplantList.Clear()
        dgvTransplantlist.Refresh()

        textsearch = mrnpSearchTB.Text
        FillDGV()
    End Sub
End Class
