<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EncryptButton = New System.Windows.Forms.Button()
        Me.DecryptButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textBoxPlainText = New System.Windows.Forms.TextBox()
        Me.textBoxEncryptedText = New System.Windows.Forms.TextBox()
        Me.textBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenTextButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EncryptButton
        '
        Me.EncryptButton.Location = New System.Drawing.Point(22, 247)
        Me.EncryptButton.Name = "EncryptButton"
        Me.EncryptButton.Size = New System.Drawing.Size(75, 23)
        Me.EncryptButton.TabIndex = 0
        Me.EncryptButton.Text = "Cifra"
        Me.EncryptButton.UseVisualStyleBackColor = True
        '
        'DecryptButton
        '
        Me.DecryptButton.Location = New System.Drawing.Point(346, 247)
        Me.DecryptButton.Name = "DecryptButton"
        Me.DecryptButton.Size = New System.Drawing.Size(75, 23)
        Me.DecryptButton.TabIndex = 1
        Me.DecryptButton.Text = "Decifra"
        Me.DecryptButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Testo da cifrare:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Testo da decifrare"
        '
        'textBoxPlainText
        '
        Me.textBoxPlainText.Location = New System.Drawing.Point(22, 140)
        Me.textBoxPlainText.Multiline = True
        Me.textBoxPlainText.Name = "textBoxPlainText"
        Me.textBoxPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBoxPlainText.Size = New System.Drawing.Size(250, 101)
        Me.textBoxPlainText.TabIndex = 4
        '
        'textBoxEncryptedText
        '
        Me.textBoxEncryptedText.Location = New System.Drawing.Point(346, 140)
        Me.textBoxEncryptedText.Multiline = True
        Me.textBoxEncryptedText.Name = "textBoxEncryptedText"
        Me.textBoxEncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBoxEncryptedText.Size = New System.Drawing.Size(250, 101)
        Me.textBoxEncryptedText.TabIndex = 5
        '
        'textBoxPassword
        '
        Me.textBoxPassword.Location = New System.Drawing.Point(238, 314)
        Me.textBoxPassword.Name = "textBoxPassword"
        Me.textBoxPassword.Size = New System.Drawing.Size(342, 23)
        Me.textBoxPassword.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'OpenTextButton
        '
        Me.OpenTextButton.Location = New System.Drawing.Point(181, 247)
        Me.OpenTextButton.Name = "OpenTextButton"
        Me.OpenTextButton.Size = New System.Drawing.Size(91, 41)
        Me.OpenTextButton.TabIndex = 8
        Me.OpenTextButton.Text = "Apri File di Testo"
        Me.OpenTextButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(504, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Salva il testo crittografato"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Coral
        Me.Label4.Location = New System.Drawing.Point(238, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(344, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "La password usata non viene salvata se si vuole poter decifrare o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ricifrare il t" &
    "esto bisogna ricordarla."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OpenTextButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textBoxPassword)
        Me.Controls.Add(Me.textBoxEncryptedText)
        Me.Controls.Add(Me.textBoxPlainText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DecryptButton)
        Me.Controls.Add(Me.EncryptButton)
        Me.Name = "Form1"
        Me.Text = "Critter is an ""SHA256 AND AES256"" Crypter and Decrypter for text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EncryptButton As Button
    Friend WithEvents DecryptButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textBoxPlainText As TextBox
    Friend WithEvents textBoxEncryptedText As TextBox
    Friend WithEvents textBoxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OpenTextButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
