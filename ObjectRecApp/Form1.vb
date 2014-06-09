Imports Emgu.CV
Imports Emgu.CV.Util
Imports Emgu.CV.Structure

Public Class Form1

    Dim capturez As Capture = New Capture

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim imagez As Image(Of Bgr, Byte) = capturez.QueryFrame() 'Instead of QueryFrame, you may need to do RetrieveBgrFrame depending on the version of EmguCV you download.

        PictureBox1.Image = imagez.ToBitmap()

    End Sub
End Class