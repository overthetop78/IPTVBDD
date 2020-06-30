Imports System.ComponentModel
Imports System.Windows.Forms
Imports Renci.SshNet
Imports System.Security.Cryptography
Imports System.Web.HttpUtility

Public Class Dialog_WebLinkImg
    Public Shared TestLink As String = Nothing
    Public Shared IMGH As Integer, IMGHR As Integer, IMGV As Integer, IMGVR As Integer,
    IMGPixel As Imaging.PixelFormat, IMGPalette As Imaging.ColorPalette, IMGRawFormat As Imaging.ImageFormat
    Public cmd As SshCommand, DossierLogos As String = "/var/www/html/iptv/logos_tv/"

    Private Sub Btn_Accept_Click(sender As Object, e As EventArgs) Handles Btn_Accept.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'on va renomer l'image 
        Try
            Dim NomIMG As String = ImageView.NomChaineRech
            If NomIMG.IndexOf(" ") <> -1 Then Replace(NomIMG, " ", "_")
            NomIMG = NomIMG & ".png"
            Dim SSH_Host As String = "82.64.11.82"
            Dim SSH_Port As Integer = 2222
            Dim SSH_Username As String = "8fTLuKoRxlm+0jZq+5hbug==" 'Crypté
            Dim SSH_Password As String = "5UzBMMkt4w5pgbZ/7UT/9w==" 'Crypté

            Dim Connexion As New PasswordConnectionInfo(SSH_Host, SSH_Port, AESCrypt.DeCrypter(SSH_Username, code), AESCrypt.DeCrypter(SSH_Password, code))
            Dim SSH_Client As New SshClient(Connexion)
            Using SSH_Client
                SSH_Client.Connect()



                'Il faut vérifier si les fichiers n'existent pas
                Dim NomLink As String = TestLink
                While NomLink.IndexOf("/") <> -1
                    NomLink = Mid(NomLink, InStr(NomLink, "/") + 1)
                End While
                NomLink = HtmlDecode(NomLink)
                Dim TestIMGExist As String = "ls | grep " & Chr(34) & DossierLogos & NomLink & Chr(34)
                cmd = SSH_Client.RunCommand(TestIMGExist)
                If cmd.Result <> "" Then MsgBox(cmd.Result, vbApplicationModal)
                TestIMGExist = "ls | grep " & Chr(34) & DossierLogos & NomIMG & Chr(34)
                cmd = SSH_Client.RunCommand(TestIMGExist)
                If cmd.Result <> "" Then MsgBox(cmd.Result, vbApplicationModal)
                'https://upload.wikimedia.org/wikipedia/commons/f/fc/Bravo_TV_%282017_Logo%29.png
                Dim DownloadIMG As String = "wget " & TestLink & " -o " & Chr(34) & DossierLogos & NomIMG & Chr(34)
                cmd = SSH_Client.RunCommand(DownloadIMG)

                SSH_Client.Disconnect()

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbApplicationModal + vbExclamation + vbOKOnly, "Erreur")
        End Try
        Me.Close()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Btn_TestIMG_Click(sender As Object, e As EventArgs) Handles Btn_TestIMG.Click
        'si la ligne est vide
        TestLink = txt_TestIMG.Text
        If TestLink = Nothing Or TestLink = "" Then Exit Sub
        'si la ligne contient qq chose , on verifie ce qu'elle contient 

        If TestLink.IndexOf("http") = -1 Then Exit Sub
        Try
            If TestLink.IndexOf(".png") <> -1 Or TestLink.IndexOf(".jpg") <> -1 Or TestLink.IndexOf(".jpeg") <> -1 Or TestLink.IndexOf(".gif") <> -1 Then
                'on peut afficher l'image et recuperer ce qu'on trouve 
                PictureBox_TestIMG.ImageLocation = TestLink
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbApplicationModal + vbExclamation + vbOKOnly)
            Exit Sub
        End Try


    End Sub

    Private Sub PictureBox_TestIMG_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles PictureBox_TestIMG.LoadCompleted
        Try
            Threading.Thread.Sleep(1000)
            IMGH = PictureBox_TestIMG.Image.Height
            IMGHR = PictureBox_TestIMG.Image.HorizontalResolution
            IMGV = PictureBox_TestIMG.Image.Width
            IMGVR = PictureBox_TestIMG.Image.VerticalResolution
            IMGPixel = PictureBox_TestIMG.Image.PixelFormat
            IMGPalette = PictureBox_TestIMG.Image.Palette
            IMGRawFormat = PictureBox_TestIMG.Image.RawFormat

        Catch ex As Exception
            MsgBox("Image Invalide", vbApplicationModal + vbExclamation + vbOKOnly, "Erreur")
            Exit Sub
        End Try
        'on a réussi a avoir toutes les infos de l'image permettant de savoir si l'image est bonne
        'Si l'image ne fait pas la taille voulue on indique que l'image n'est pas bonne, sinon on permet d'accepter l'image
        If IMGH < 200 And IMGV < 200 And IMGHR < 30 And IMGVR < 30 Then MsgBox("Image trop petite : " & IMGV & "x" & IMGH & " - Res: " & IMGVR & "x" & IMGHR & vbCrLf & "L'image doit dépasser 200x200 - Res: 30x30", vbApplicationModal + vbExclamation + vbOKOnly) Else Btn_Accept.Enabled = True



        'sinon c'est bon on peut rajouter l'image 


    End Sub

    Private Sub PictureBox_TestIMG_LoadProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles PictureBox_TestIMG.LoadProgressChanged
        Dim percent As Integer = 75
        If e.ProgressPercentage > 75 Then
            ProgressBar_IMGLoad.Maximum = e.ProgressPercentage
            percent = e.ProgressPercentage
        End If
        While e.ProgressPercentage < percent
            Application.DoEvents()
            ProgressBar_IMGLoad.Value = e.ProgressPercentage
        End While
    End Sub

    Private Sub txt_TestIMG_TextChanged(sender As Object, e As EventArgs) Handles txt_TestIMG.TextChanged
        'si le texte change pour eviter qu'on fasse une erreur.. ou pire... 
        Btn_Accept.Enabled = False
    End Sub
End Class
