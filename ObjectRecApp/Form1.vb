Imports Emgu.CV
Imports Emgu.Util
Imports Emgu.CV.Util
Imports Emgu.CV.Structure

Public Class Form1
    Dim capturez As Capture = New Capture
    Dim imagez As Image(Of Gray, Byte)

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        imagez = capturez.RetrieveGrayFrame
        imagez._EqualizeHist() 'Makes for closer comparisons
        PictureBox1.Image = imagez.ToBitmap

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Datagridview has 2 columns, the first is an image column, the second is a text column.
        'The first image column has a imagelayout of stretch.
        DataGridView1.Rows.Add()
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = imagez.ToBitmap
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Height = DataGridView1.Columns(0).Width * 0.75
        'Putting a 0.75 * width for the height keeps it at 4:3 aspect ratio, so it looks normal.
DataGridView1.Rows(DataGridView1.Rows.Count- 1).Cells(1).Value = "Image" & DataGridView1.Rows.Count - 1

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim imagelist(DataGridView1.Rows.Count - 1) As Image(Of Gray, Byte)
        Dim labellist(DataGridView1.Rows.Count - 1) As String

        For i = 0 To DataGridView1.Rows.Count - 1
            Dim tempimage As Bitmap = DataGridView1.Rows(i).Cells(0).Value
            imagelist(i) = New Image(Of Gray, Byte)(tempimage)
            labellist(i) = DataGridView1.Rows(i).Cells(1).Value
        Next
        Dim TermCrit As MCvTermCriteria = New MCvTermCriteria(16, 0.001)
        Dim maxdistance As Integer = 5000 'The higher the number, the difference is allowed
        Dim EobjectRec As EigenObjectRecognizer = New EigenObjectRecognizer(imagelist, labellist, maxdistance, TermCrit)

        Try
            TextBox1.Text = EobjectRec.Recognize(imagez).Label
        Catch ex As Exception
            TextBox1.Text = "No!" 'This means nothing was close enough for a good match
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        DataGridView1.Rows.Clear()
    End Sub
End Class