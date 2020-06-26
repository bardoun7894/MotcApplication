Imports System.Data.OleDb

Public Class LabsResult
    Private Sub saveReciepientBtn_Click(sender As Object, e As EventArgs) Handles saveReciepientBtn.Click

        Dim labResult As String = "INSERT INTO labs_result_information 
(MRNP,DateOfBlood,WBC,Hb,Platlet,INR,BLS,
SickleCell,Na,K,BUN,Creatinine,Bili,AST,GGT,ALT
,ALP,Mg,Cholestrol,HIV,HAV_Antibody_IgM,HAV_Antibody_IgG,HBV_Core_Antibody,HBV_Core_Antibody_IgM,HBV_Surface_Antibody_Total,HBV_Surface_Antigen,HCV_Antibody_IgG,HSV,CMV_Antibody_IgG,CMV_Antibody_IgM,VZV_Antibody_IgG,Measles_Antibody_IgG
,Mumps_Antibody_IgG,Rubella_Antibody_IgG,Toxoplasma_Antibody_IgG,Toxoplasma_Antibody_IgM
,AFP,CEA,CA199,CA125,SerumIG,ANA,ASMA,AMA,AntitLKM,ANCA,ThroatCulture,MRSA,Urine,BloodCulrure,AsciticFluid,Other,FKLEVEL)
values
(@MRNP,@DateOfBlood,@WBC,@Hb,@Platlet,@INR,@BLS,@SickleCell,@Na,@K,
@BUN,@Creatinine,@Bili,@AST,@GGT,@ALT,@ALP,@Mg,@Cholestrol,@HIV,@HAV_Antibody_IgM,@HAV_Antibody_IgG,@HBV_Core_Antibody
,@HBV_Core_Antibody_IgM,@HBV_Surface_Antibody_Total,@HBV_Surface_Antigen,@HCV_Antibody_IgG,@HSV,@CMV_Antibody_IgG
,@CMV_Antibody_IgM,@VZV_Antibody_IgG,@Measles_Antibody_IgG,@Mumps_Antibody_IgG,@Rubella_Antibody_IgG,@Toxoplasma_Antibody_IgG,@Toxoplasma_Antibody_IgM
,@AFP,@CEA,@CA199,@CA125,@SerumIG,@ANA,@ASMA,@AMA,@AntitLKM,@ANCA,@ThroatCulture,@MRSA,@Urine,@BloodCulrure,@AsciticFluid,@Other,@FKLEVEL)"

        cmd = New OleDbCommand(labResult, conn)
        cmd.Parameters.Add(New OleDbParameter("@MRNP", OleDbType.VarChar)).Value = MRNTb.Text
        cmd.Parameters.Add(New OleDbParameter("@DateOfBlood", OleDbType.Date)).Value = dobloodDT.Text
        cmd.Parameters.Add(New OleDbParameter("@WBC", OleDbType.VarChar)).Value = wbcTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Hb", OleDbType.VarChar)).Value = hbTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Platlet", OleDbType.VarChar)).Value = PlatletTB.Text
        cmd.Parameters.Add(New OleDbParameter("@INR", OleDbType.VarChar)).Value = INRTB.Text
        cmd.Parameters.Add(New OleDbParameter("@BLS", OleDbType.VarChar)).Value = blsTB.Text
        cmd.Parameters.Add(New OleDbParameter("@SickleCell", OleDbType.VarChar)).Value = SickleCellTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Na", OleDbType.VarChar)).Value = naTB.Text
        cmd.Parameters.Add(New OleDbParameter("@K", OleDbType.VarChar)).Value = kTB.Text
        cmd.Parameters.Add(New OleDbParameter("@BUN", OleDbType.VarChar)).Value = bunTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Creatinine", OleDbType.VarChar)).Value = CreatinineTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Bili", OleDbType.VarChar)).Value = BiliTB.Text
        cmd.Parameters.Add(New OleDbParameter("@AST", OleDbType.VarChar)).Value = astTb.Text
        cmd.Parameters.Add(New OleDbParameter("@GGT", OleDbType.VarChar)).Value = GGTTB.Text
        cmd.Parameters.Add(New OleDbParameter("@ALT", OleDbType.VarChar)).Value = ALTTB.Text
        cmd.Parameters.Add(New OleDbParameter("@ALP", OleDbType.VarChar)).Value = ALPTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Mg", OleDbType.VarChar)).Value = MgTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Cholestrol", OleDbType.VarChar)).Value = CholestrolTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HIV", OleDbType.VarChar)).Value = himevTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HAV_Antibody_IgM", OleDbType.VarChar)).Value = HAV_Antibody_IgMTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HAV_Antibody_IgG", OleDbType.VarChar)).Value = HAV_Antibody_IgGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HBV_Core_Antibody", OleDbType.VarChar)).Value = HBV_Core_AntibodyTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HBV_Core_Antibody_IgM", OleDbType.VarChar)).Value = HBV_Core_Antibody_IgMTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HBV_Surface_Antibody_Total", OleDbType.VarChar)).Value = HBV_Surface_Antibody_TotalTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HBV_Surface_Antigen", OleDbType.VarChar)).Value = HBV_Surface_AntigenTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HCV_Antibody_IgG", OleDbType.VarChar)).Value = HCV_Antibody_IgGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@HSV", OleDbType.VarChar)).Value = HSVTB.Text
        cmd.Parameters.Add(New OleDbParameter("@CMV_Antibody_IgG", OleDbType.VarChar)).Value = CMV_Antibody_IgGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@CMV_Antibody_IgM", OleDbType.VarChar)).Value = CMV_Antibody_IgMTB.Text
        cmd.Parameters.Add(New OleDbParameter("@VZV_Antibody_IgG", OleDbType.VarChar)).Value = VZV_Antibody_IgGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Measles_Antibody_IgG", OleDbType.VarChar)).Value = Measles_Antibody_IgGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Mumps_Antibody_IgG", OleDbType.VarChar)).Value = Mumps_Antibody_IgGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Rubella_Antibody_IgG", OleDbType.VarChar)).Value = Rubella_Antibody_IgGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Toxoplasma_Antibody_IgG", OleDbType.VarChar)).Value = Toxoplasma_Antibody_IgGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Toxoplasma_Antibody_IgM", OleDbType.VarChar)).Value = Toxoplasma_Antibody_IgMTB.Text
        cmd.Parameters.Add(New OleDbParameter("@AFP", OleDbType.VarChar)).Value = AFPTB.Text
        cmd.Parameters.Add(New OleDbParameter("@CEA", OleDbType.VarChar)).Value = ceaTB.Text
        cmd.Parameters.Add(New OleDbParameter("@CA199", OleDbType.VarChar)).Value = CA199TB.Text
        cmd.Parameters.Add(New OleDbParameter("@CA125", OleDbType.VarChar)).Value = CA125TB.Text
        cmd.Parameters.Add(New OleDbParameter("@SerumIG", OleDbType.VarChar)).Value = serumLGTB.Text
        cmd.Parameters.Add(New OleDbParameter("@ANA", OleDbType.VarChar)).Value = ANATB.Text
        cmd.Parameters.Add(New OleDbParameter("@ASMA", OleDbType.VarChar)).Value = ASMATB.Text
        cmd.Parameters.Add(New OleDbParameter("@AMA", OleDbType.VarChar)).Value = amaTB.Text
        cmd.Parameters.Add(New OleDbParameter("@AntitLKM", OleDbType.VarChar)).Value = AntitLKMTB.Text
        cmd.Parameters.Add(New OleDbParameter("@ANCA", OleDbType.VarChar)).Value = ANCATB.Text
        cmd.Parameters.Add(New OleDbParameter("@ThroatCulture", OleDbType.VarChar)).Value = ThroatCultureTB.Text
        cmd.Parameters.Add(New OleDbParameter("@MRSA", OleDbType.VarChar)).Value = mrsaTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Urine", OleDbType.VarChar)).Value = urineTB.Text
        cmd.Parameters.Add(New OleDbParameter("@BloodCulrure", OleDbType.VarChar)).Value = BloodCulrureTB.Text
        cmd.Parameters.Add(New OleDbParameter("@AsciticFluid", OleDbType.VarChar)).Value = AsciticFluidTB.Text
        cmd.Parameters.Add(New OleDbParameter("@Other", OleDbType.VarChar)).Value = otherTB.Text
        cmd.Parameters.Add(New OleDbParameter("@@FKLEVEL", OleDbType.VarChar)).Value = FKLEVELTB.Text


        conn.Open()

        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("the data has Inserted", MsgBoxStyle.Information)

    End Sub

    Private Sub LabsResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub panel3_Paint(sender As Object, e As PaintEventArgs) Handles panel3.Paint

    End Sub

    Private Sub nextTab_Click(sender As Object, e As EventArgs) Handles nextTab.Click
        TabControl1.SelectedTab = TabPage2
        backTab.Visible = True
        saveReciepientBtn.Visible = True
        nextTab.Visible = False
    End Sub

    Private Sub backTab_Click(sender As Object, e As EventArgs) Handles backTab.Click
        TabControl1.SelectedTab = TabPage1
        backTab.Visible = False
        saveReciepientBtn.Visible = False
        nextTab.Visible = True
    End Sub
End Class
