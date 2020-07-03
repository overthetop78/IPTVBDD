Imports System.IO
Imports System.Security.Cryptography

Module AESCrypt
    Public code As String = "ThisWordIsCrypted"

    Public Function RequestCode() As Boolean
        Dim Fichier As String = Application.StartupPath & "\" & "code.key"
        Dim CodeExtract As String = "ExtractionCode"
        If File.Exists(Fichier) = True Then
            Dim FichierKey As String = File.ReadAllText(Fichier)
            code = DeCrypter(FichierKey, CodeExtract)
            Return True
        Else
            MsgBox("Le Fichier Key n'existe pas. Vous ne pouvez pas uploader des images", vbApplicationModal + vbInformation + vbOKOnly, "Fichier non trouvé")
            Return False
        End If
    End Function

    Public Function Crypter(ByVal input As String, ByVal pass As String) As String
        Dim AES As New RijndaelManaged
        Dim Hash_AES As New MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(Text.Encoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = CipherMode.ECB
            Dim DESEncrypter As ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = Text.Encoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function DeCrypter(ByVal input As String, ByVal pass As String) As String
        Dim AES As New RijndaelManaged
        Dim Hash_AES As New MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(Text.Encoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = CipherMode.ECB
            Dim DESDecrypter As ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = Text.Encoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
