Imports System.Runtime.InteropServices

Public Class Form1

    <DllImport("PowerFunctions.dll")>
    Public Shared Function mW2dBm(mW As Double) As Double

    End Function

    <DllImport("PowerFunctions.dll")>
    Public Shared Function dBm2mW(dBm As Double) As Double

    End Function



    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Dim temp As New Point()

        temp.X = Me.ClientSize.Width / 2 - BoxOfConversions.Width / 2
        temp.Y = Me.ClientSize.Height / 2 - BoxOfConversions.Height / 2

        BoxOfConversions.Location = temp

    End Sub

    'mW2dBm
    Private Sub btn_mW2dBm_Click(sender As Object, e As EventArgs) Handles btn_mW2dBm.Click

        lbl_mW2dBm.Text = mW2dBm(ud_mW2dBm.Value).ToString("F4")

    End Sub

    Private Sub ud_mW2dBm_ValueChanged(sender As Object, e As EventArgs) Handles ud_mW2dBm.ValueChanged

        lbl_mW2dBm.Text = mW2dBm(ud_mW2dBm.Value).ToString("F4")

    End Sub


    'dBm2mW
    Private Sub btn_dBm2mW_Click(sender As Object, e As EventArgs) Handles btn_dBm2mW.Click

        lbl_dBm2mW.Text = dBm2mW(ud_dBm2mW.Value).ToString("F4")

    End Sub

    Private Sub ud_dBm2mW_ValueChanged(sender As Object, e As EventArgs) Handles ud_dBm2mW.ValueChanged

        lbl_dBm2mW.Text = dBm2mW(ud_dBm2mW.Value).ToString("F4")

    End Sub
End Class
