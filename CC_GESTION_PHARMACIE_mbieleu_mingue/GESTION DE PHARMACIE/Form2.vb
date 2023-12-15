Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nommedicament As String = DataGridView1.CurrentRow.Cells(0).Value
        Dim codemedicament As String = DataGridView1.CurrentRow.Cells(1).Value
        Dim entreprisefabricante As String = DataGridView1.CurrentRow.Cells(2).Value

        Dim nombremedicament As String = DataGridView1.CurrentRow.Cells(3).Value
        Dim dateentree As Date = DataGridView1.CurrentRow.Cells(4).Value


        Form1.TextBoxnommedicament.Text = nommedicament
        Form1.TextBoxcodemedicament.Text = codemedicament
        Form1.TextBoxentreprisefabricante.Text = entreprisefabricante
        Form1.TextBoxnommedicament.Text = nombremedicament
        Form1.DateTimePicker1.Text = dateentree


        Form1.Button1.Enabled() = False

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim position = DataGridView1.CurrentRow.Index
        DataGridView1.Rows.RemoveAt(position)
    End Sub
End Class