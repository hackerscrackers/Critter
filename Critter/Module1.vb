Imports System.Security.Cryptography
Imports System.IO
Imports System.IO.Compression

Module CryptoUtils
    Private ReadOnly _salt As Byte() = {&H26, &H4, &H1E, &H3D, &H95, &HF2, &H44, &HAF, &H8E, &H1D, &H9F, &H1F, &H61, &HD0, &H8C, &H97}
    Private ReadOnly _iterations As Integer = 10000

    Function Encrypt(ByVal plainText As String, ByVal password As String) As Byte()
        Using deriveBytes = New Rfc2898DeriveBytes(password, _salt, _iterations, HashAlgorithmName.SHA256)
            Dim key As Byte() = deriveBytes.GetBytes(32)
            Dim iv As Byte() = deriveBytes.GetBytes(16)

            Using aes As Aes = Aes.Create()
                aes.Key = key
                aes.IV = iv
                aes.Mode = CipherMode.CBC
                aes.Padding = PaddingMode.PKCS7

                Using memoryStream = New MemoryStream()

                    Using cryptoStream = New CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write)

                        Using streamWriter = New StreamWriter(cryptoStream)
                            streamWriter.Write(plainText)
                        End Using
                    End Using

                    Return memoryStream.ToArray()
                End Using
            End Using
        End Using
    End Function

    Function Decrypt(ByVal encryptedData As Byte(), ByVal password As String) As String
        Using deriveBytes = New Rfc2898DeriveBytes(password, _salt, _iterations, HashAlgorithmName.SHA256)
            Dim key As Byte() = deriveBytes.GetBytes(32)
            Dim iv As Byte() = deriveBytes.GetBytes(16)

            Using aes As Aes = Aes.Create()
                aes.Key = key
                aes.IV = iv
                aes.Mode = CipherMode.CBC
                aes.Padding = PaddingMode.PKCS7

                Using memoryStream = New MemoryStream(encryptedData)

                    Using cryptoStream = New CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read)

                        Using streamReader = New StreamReader(cryptoStream)
                            Return streamReader.ReadToEnd()
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Function
End Module
