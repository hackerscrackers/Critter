Imports System.Security.Cryptography
Imports System.IO
Imports System.IO.Compression
Imports Critter.CryptoUtils
Imports System.Text


Public Class Form1

    Private Sub EncryptButton_Click(sender As Object, e As EventArgs) Handles EncryptButton.Click


        Dim plainText As String = textBoxPlainText.Text
        Dim password As String = textBoxPassword.Text

        If (String.IsNullOrEmpty(plainText) Or String.IsNullOrEmpty(password)) Then
            MessageBox.Show("Inserire il testo da crittografare e la password nei corrispettivi campi")
            Return
        End If

        Try
            Dim encryptedData As Byte() = CryptoUtils.Encrypt(textBoxPlainText.Text, textBoxPassword.Text)
            If textBoxEncryptedText.Text.Count >= 0 Then
                textBoxEncryptedText.Clear()
            End If
            textBoxEncryptedText.Text = Convert.ToBase64String(encryptedData)
        Catch ex As Exception
            MessageBox.Show("Errore durante la crittografia: " + ex.Message)

        End Try
    End Sub

    Private Sub DecryptButton_Click(sender As Object, e As EventArgs) Handles DecryptButton.Click
        Dim encryptedText As String = textBoxEncryptedText.Text
        Dim password As String = textBoxPassword.Text
        Dim encoding As New ASCIIEncoding()
        If (String.IsNullOrEmpty(encryptedText) Or String.IsNullOrEmpty(password)) Then
            MessageBox.Show("Inserire il testo da crittografare e la password nei corrispettivi campi")
            Return
        End If

        Try

            Dim decryptedData As Byte() = encoding.GetBytes(CryptoUtils.Decrypt(Convert.FromBase64String(encryptedText), password))

            'Verifico se c'è del testo nella textBox e nel caso lo cancello
            If textBoxPlainText.Text.Count >= 0 Then
                textBoxPlainText.Clear()
            End If

            textBoxPlainText.Text = System.Text.Encoding.UTF8.GetString(decryptedData)
        Catch ex As Exception
            MessageBox.Show("Errore durante la decrittografia: " + ex.Message)

        End Try
    End Sub

    Public Function ReadTextFile(Optional IsRTF As RichTextBoxStreamType = RichTextBoxStreamType.RichText)
        Using openfile As New OpenFileDialog
            Try
                openfile.Filter = "File Di Testo (*.txt)|*.txt"

                'Se il file è in formato .RTF allora l'applicazione lo eseguira usando 
                'questo comando, mentre se non è .RTF usera il metodo alternativo.
                If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then


                    ' Crea un Nuovo StreamReader
                    Dim sr As New StreamReader(openfile.FileName, Encoding.UTF8)
                    ' Visualizza il testo nella RichTextBox
                    textBoxPlainText.Text = sr.ReadToEnd()
                    ' Chiude StreamReader
                    sr.Close()
                End If

            Catch ex As Exception

                'mostro l'eccezione
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                'dico alla funzione che deve ritornare con un errore
                Return False
                'faccio terminare la funzione perche è stato trovato un errore.
                Exit Function

            End Try
        End Using

        Return True 'ritorna true quando il file viene letto correttamente
    End Function
    Private Sub OpenTextButton_Click(sender As Object, e As EventArgs) Handles OpenTextButton.Click

        ReadTextFile()

    End Sub

    Friend Function SaveTextFile()
        Using SaveFile As New SaveFileDialog
            Try
                SaveFile.Filter = "File Di Testo (*.txt)|*.txt"
                'Se il savefiledialog restituisce OK allora il file verra salvato, altrimenti
                'verra restituito un errore.
                If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ' Creo un Nuovo StreamWriter
                    Dim wr As New StreamWriter(SaveFile.FileName, True, Encoding.UTF8)
                    'Salvo il testo contenuto nella RichTextBox Sul file creato tramite il 
                    'SaveFileDialog
                    wr.Write(textBoxEncryptedText.Text)
                    'Chiudo StreamWriter
                    wr.Close()


                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Return False
                Exit Function
            End Try
        End Using

        Return True
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveTextFile()
    End Sub
End Class
