Public Class Form1
    Public tableauAjout(99) As Ajout
    Public actualcase As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dateentree As Date = DateTimePicker1.Value


        Dim prod As New Ajout()

        prod.TextBoxnommedicament = TextBoxnommedicament.Text
        prod.TextBoxcodemedicament = TextBoxcodemedicament.Text
        prod.TextBoxnombremedicament = TextBoxnombremedicament.Text
        prod.TextBoxentreprisefabricante = TextBoxentreprisefabricante.Text
        'prod.labelnombre = labelnombre.Text

        If prod.valider() = True Then
            tableauAjout(actualcase) = prod
            actualcase = actualcase + 1

            For i As Integer = 0 To actualcase - 1
                Form2.DataGridView1.Rows.Add(tableauAjout(i).TextBoxnommedicament, tableauAjout(i).TextBoxcodemedicament, tableauAjout(i).TextBoxentreprisefabricante, tableauAjout(i).TextBoxnombremedicament, DateTimePicker1.Value)
            Next

        End If

        If prod.valider() = True Then
            'Form2.Label1.Text = prod.TextBoxnommedicament
            'Form2.Label2.Text = prod.TextBoxcodemedicament
            'Form2.Label3.Text = prod.TextBoxentreprisefabricante
            'Form2.Label4.Text = prod.TextBoxnombremedicament
            'Form2.Label4.Text = prod.labelnombre

            'Form4.DataGridView1.Rows.Add(prod.labelnomlecteur, dateretour, dateemprunt, prod.labelcodeouvrage, prod.labelouvrage, prod.labeltitre, prod.labelnombre)

            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.DataGridView1.CurrentRow.Cells(0).Value = TextBoxnommedicament
        Form2.DataGridView1.CurrentRow.Cells(1).Value = TextBoxcodemedicament
        Form2.DataGridView1.CurrentRow.Cells(2).Value = TextBoxentreprisefabricante
        Form2.DataGridView1.CurrentRow.Cells(3).Value = TextBoxnombremedicament
        Form2.DataGridView1.CurrentRow.Cells(4).Value = DateTimePicker1


        Form2.Show()
        Me.Hide()
    End Sub
End Class
