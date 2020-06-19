Imports System.Data.OleDb

Public Class WorkUp


    Private Sub saveReciepientBtn_Click(sender As Object, e As EventArgs) Handles saveReciepientBtn.Click


        Dim workUpSql As String = "insert into myworkup_tbl(MRNP,StartingDate,FullName,XRay,US,CT,MRI,Mammography,ECG,Echo,BoneDensimetry,BoneScan,PapSmear,PFT,TymorIntervention,PPDSkinTest,Cononoscopy,Endoscopy,IHD,Hypertension,Smoking,Dianetic,PepticUlcer,PreviousCancer,BloodTransfusion,
PreviousSurgery,Clerance,Anesthesia,Dental,GyneObs,Neurology,Psychiatric,Nutrition,Cardiology,Grade,LiverDate,SizeLiveDate)VALUES(@MRNP,@StartingDate,@FullName,@XRay,@US,@CT,@MRI,@Mammography,@ECG,@Echo,@BoneDensimetry,@BoneScan,@PapSmear,@PFT,@TymorIntervention,@PPDSkinTest,@Cononoscopy,@Endoscopy,@IHD,@Hypertension,@Smoking,@Dianetic,@PepticUlcer,@PreviousCancer,@BloodTransfusion,@PreviousSurgery,@Clerance,@Anesthesia,@Dental,@GyneObs,@Neurology,@Psychiatric,@Nutrition,@Cardiology,@Grade,@LiverDate,@SizeLiveDate)"

        Try
            cmd = New OleDbCommand(workUpSql, conn)
            cmd.Parameters.Add(New OleDbParameter("@MRNP", OleDbType.VarChar)).Value = MRNTB.Text
            cmd.Parameters.Add(New OleDbParameter("@StartingDate", OleDbType.Date)).Value = StartingDateDT.Value
            cmd.Parameters.Add(New OleDbParameter("@FullName", OleDbType.VarChar)).Value = FullNameTB.Text
            cmd.Parameters.Add(New OleDbParameter("@XRay", OleDbType.VarChar)).Value = xRayTB.Text + ",date : " + DateTimePicker1.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@US", OleDbType.VarChar)).Value = USTB.Text + ",date : " + DateTimePicker2.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@CT", OleDbType.VarChar)).Value = CTTB.Text + ",date : " + DateTimePicker3.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@MRI", OleDbType.VarChar)).Value = mriTB.Text + ",date : " + DateTimePicker4.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Mammography", OleDbType.VarChar)).Value = MammographyTB.Text + ",date : " + DateTimePicker5.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@ECG", OleDbType.VarChar)).Value = ECGTB.Text + ",date : " + DateTimePicker6.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Echo", OleDbType.VarChar)).Value = EchoTB.Text + ",date : " + DateTimePicker7.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@BoneDensimetry", OleDbType.VarChar)).Value = BoneDensimetryTB.Text + ",date : " + DateTimePicker8.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@BoneScan", OleDbType.VarChar)).Value = BoneScanTB.Text + ",date : " + DateTimePicker9.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@PapSmear", OleDbType.VarChar)).Value = PAPSmearTB.Text + ",date : " + DateTimePicker10.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@PFT", OleDbType.VarChar)).Value = PFTTB.Text + ",date : " + DateTimePicker11.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@TymorIntervention", OleDbType.VarChar)).Value = TymorInterventionTB.Text + ",date : " + DateTimePicker12.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@PPDSkinTest", OleDbType.VarChar)).Value = PPDSkinTestTB.Text + ",date : " + DateTimePicker13.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Cononoscopy", OleDbType.VarChar)).Value = CononoscopyTB.Text + ",date : " + DateTimePicker14.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Endoscopy", OleDbType.VarChar)).Value = EndoscopyTB.Text + ",date : " + DateTimePicker15.Value.ToString

            cmd.Parameters.Add(New OleDbParameter("@IHD", OleDbType.VarChar)).Value = IHDCB.Text
            cmd.Parameters.Add(New OleDbParameter("@Hypertension", OleDbType.VarChar)).Value = HypertensionCB.Text
            cmd.Parameters.Add(New OleDbParameter("@Smoking", OleDbType.VarChar)).Value = SmokingCB.Text
            cmd.Parameters.Add(New OleDbParameter("@Dianetic", OleDbType.VarChar)).Value = DianeticCB.Text
            cmd.Parameters.Add(New OleDbParameter("@PepticUlcer", OleDbType.VarChar)).Value = PepticUlcerCB.Text
            cmd.Parameters.Add(New OleDbParameter("@PreviousCancer", OleDbType.VarChar)).Value = PreviousCancerCB.Text
            cmd.Parameters.Add(New OleDbParameter("@BloodTransfusion", OleDbType.VarChar)).Value = BloodTransfusionCB.Text
            cmd.Parameters.Add(New OleDbParameter("@PreviousSurgery", OleDbType.VarChar)).Value = PreviousSurgeryCB.Text

            cmd.Parameters.Add(New OleDbParameter("@Clerance", OleDbType.VarChar)).Value = CleranceTB.Text + ",date : " + DateTimePicker16.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Anesthesia", OleDbType.VarChar)).Value = AnesthesiaTB.Text + ",date : " + DateTimePicker17.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Dental", OleDbType.VarChar)).Value = DentalTB.Text + ",date : " + DateTimePicker18.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@GyneObs", OleDbType.VarChar)).Value = GyneObsTB.Text + ",date : " + DateTimePicker19.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Neurology", OleDbType.VarChar)).Value = NeurologyTB.Text + ",date : " + DateTimePicker20.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Psychiatric", OleDbType.VarChar)).Value = psychiatricTB.Text + ",date : " + DateTimePicker21.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Nutrition", OleDbType.VarChar)).Value = NutritionTB.Text + ",date : " + DateTimePicker22.Value.ToString
            cmd.Parameters.Add(New OleDbParameter("@Cardiology", OleDbType.VarChar)).Value = CardiologyTB.Text + ",date : " + DateTimePicker23.Value.ToString

            cmd.Parameters.Add(New OleDbParameter("@Grade", OleDbType.VarChar)).Value = GradeTB.Text
            cmd.Parameters.Add(New OleDbParameter("@LiverDate", OleDbType.Date)).Value = LiverDateDT.Value
            cmd.Parameters.Add(New OleDbParameter("@SizeLiveDate", OleDbType.VarChar)).Value = SizeCB.Text
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("the data has Inserted", MsgBoxStyle.Information)

        Catch ex As Exception
            conn.Close()

            MsgBox(ex.ToString)
        End Try



    End Sub
End Class
