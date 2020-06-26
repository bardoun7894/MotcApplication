Public Class Form1


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        With RecieptInformation
            .Dock = DockStyle.Fill
            .TopLevel = False
            Container.Controls.Clear()
            Container.Controls.Add(RecieptInformation)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With DonorInformation
            .Dock = DockStyle.Fill
            .TopLevel = False
            Container.Controls.Clear()
            Container.Controls.Add(DonorInformation)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        With SurgicalInformationvb
            .Dock = DockStyle.Fill
            .TopLevel = False
            Container.Controls.Clear()
            Container.Controls.Add(SurgicalInformationvb)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        With LabsResult
            .Dock = DockStyle.Fill
            .TopLevel = False
            Container.Controls.Clear()
            Container.Controls.Add(LabsResult)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Note
            .Dock = DockStyle.Fill
            .TopLevel = False
            Container.Controls.Clear()
            Container.Controls.Add(Note)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        With Medication
            .Dock = DockStyle.Fill
            .TopLevel = False
            Container.Controls.Clear()
            Container.Controls.Add(Medication)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With WorkUp
            .Dock = DockStyle.Fill
            .TopLevel = False
            Container.Controls.Clear()
            Container.Controls.Add(WorkUp)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        With _ٍShowForm3
            .Dock = DockStyle.Fill
            .TopLevel = False
            Container.Controls.Clear()
            Container.Controls.Add(_ٍShowForm3)
            .BringToFront()
            .Show()
        End With
    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ShowInTaskbar = False
        Me.ShowIcon = True
    End Sub
End Class
