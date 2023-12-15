Public Class Ajout
    Public TextBoxnommedicament As String
    Public TextBoxcodemedicament As String
    Public TextBoxentreprisefabricante As String
    Public TextBoxnombremedicament As String



    Public Function valider() As Boolean
        Dim state As Boolean = True

        If Not IsNumeric(Me.TextBoxcodemedicament) Then
            state = False
        End If

        If Me.TextBoxnommedicament.Length > 50 Then
            state = False
        End If

        If Not IsNumeric(Me.TextBoxnombremedicament) Then
            state = False
        Else
            If Me.TextBoxnombremedicament <= 100 And Me.TextBoxnombremedicament >= 5000 Then
                state = False
            End If
        End If
        If Me.TextBoxentreprisefabricante.Length > 50 Then
            state = False
        End If


        Return state
    End Function
End Class
