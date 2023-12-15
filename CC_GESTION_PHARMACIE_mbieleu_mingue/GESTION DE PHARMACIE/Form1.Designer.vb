<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxnommedicament = New System.Windows.Forms.TextBox()
        Me.TextBoxcodemedicament = New System.Windows.Forms.TextBox()
        Me.TextBoxentreprisefabricante = New System.Windows.Forms.TextBox()
        Me.TextBoxnombremedicament = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(137, 9)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(514, 55)
        Me.label.TabIndex = 0
        Me.label.Text = "PARMACIE HONORE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AJOUTER DES MEDICAMENTS "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOM MEDICAMENT :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CODE MEDICAMENT :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ENTREPRISE FRABRICANTE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "NOMBRE DE MEDICAMENT :"
        '
        'TextBoxnommedicament
        '
        Me.TextBoxnommedicament.Location = New System.Drawing.Point(15, 173)
        Me.TextBoxnommedicament.Name = "TextBoxnommedicament"
        Me.TextBoxnommedicament.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxnommedicament.TabIndex = 6
        '
        'TextBoxcodemedicament
        '
        Me.TextBoxcodemedicament.Location = New System.Drawing.Point(15, 236)
        Me.TextBoxcodemedicament.Name = "TextBoxcodemedicament"
        Me.TextBoxcodemedicament.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxcodemedicament.TabIndex = 7
        '
        'TextBoxentreprisefabricante
        '
        Me.TextBoxentreprisefabricante.Location = New System.Drawing.Point(15, 303)
        Me.TextBoxentreprisefabricante.Name = "TextBoxentreprisefabricante"
        Me.TextBoxentreprisefabricante.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxentreprisefabricante.TabIndex = 8
        '
        'TextBoxnombremedicament
        '
        Me.TextBoxnombremedicament.Location = New System.Drawing.Point(374, 173)
        Me.TextBoxnombremedicament.Name = "TextBoxnombremedicament"
        Me.TextBoxnombremedicament.Size = New System.Drawing.Size(197, 20)
        Me.TextBoxnombremedicament.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(372, 236)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(199, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DATE D'ARRIVEE :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(58, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 39)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "ENREGISTRER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(360, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(247, 39)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "MODIFIER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxnombremedicament)
        Me.Controls.Add(Me.TextBoxentreprisefabricante)
        Me.Controls.Add(Me.TextBoxcodemedicament)
        Me.Controls.Add(Me.TextBoxnommedicament)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxnommedicament As TextBox
    Friend WithEvents TextBoxcodemedicament As TextBox
    Friend WithEvents TextBoxentreprisefabricante As TextBox
    Friend WithEvents TextBoxnombremedicament As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
