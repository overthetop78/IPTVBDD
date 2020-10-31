Imports System.ComponentModel
Imports System.Windows.Forms
Imports Renci.SshNet
Imports System.Security.Cryptography
Imports System.Web.HttpUtility

Public Class Dialog_WebLinkImg
    Private Sub Btn_Accept_Click(sender As Object, e As EventArgs) Handles Btn_Accept.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'on va renomer l'image 
        Try
            NomIMG = HtmlDecode(NomChaineRech)
            NomIMG = Replace(NomIMG, " ", "_")
            NomIMG = Replace(NomIMG, "%20", "_")
            NomIMG = Replace(NomIMG, "#", "_")
            NomIMG = NomIMG & ".png"
            Dim SSH_Host As String = "82.64.11.82"
            Dim SSH_Port As Integer = 2222
            Dim Rep As Boolean = AESCrypt.RequestCode
            If Rep = False Then Exit Try
            Dim SSH_Username As String = "OtjZPxJI5pv39Xj9jRSO8w==" 'Crypté
            Dim SSH_Password As String = "GTkylnqTVe2dvUwfL50BNw ==" 'Crypté


            Dim Connexion As New PasswordConnectionInfo(SSH_Host, SSH_Port, AESCrypt.DeCrypter(SSH_Username, code), AESCrypt.DeCrypter(SSH_Password, code))
            Dim SSH_Client As New SshClient(Connexion)
            Using SSH_Client
                SSH_Client.Connect()
                If SSH_Client.IsConnected Then
                    'Il faut vérifier si les fichiers n'existent pas
                    Dim TestIMGExist = $"ls | grep {Chr(34)}{DossierLogos}{NomIMG}{Chr(34)}"
                    cmd = SSH_Client.CreateCommand(TestIMGExist)
                    Dim Result = cmd.Execute()
                    If Result <> "" Then MsgBox(cmd.Result, vbApplicationModal)
                    'https://upload.wikimedia.org/wikipedia/commons/f/fc/Bravo_TV_%282017_Logo%29.png
                    Dim DownloadIMG As String = $"wget {TestLink} -O {Chr(34)}{DossierLogos}{NomIMG}{Chr(34)}"
                    cmd = SSH_Client.CreateCommand(DownloadIMG)
                    Result = cmd.Execute()
                    Dialog_AskInfo.PictureBox_tvg_logo.ImageLocation = LinkImg & NomIMG
                    If SSH_Client.IsConnected Then
                        SSH_Client.Disconnect()
                    End If
                    SSH_Client.Dispose()
                Else
                    MsgBox("Client non connecté", vbApplicationModal + vbOKOnly)
                End If
            End Using
            'On sauvegarde la nouvelle liste
            Dim Web As New HtmlAgilityPack.HtmlWeb, url As String = "http://informaweb.freeboxos.fr/iptv/logos_tv/"
            Dim PageWeb = Web.Load(url)
            PageWeb.Save(FileWebLogo)

            Me.Close()
            ImageView.Close()
            Dialog_AskInfo.Select()
        Catch ex As Exception
            MsgBox(ex.Message, vbApplicationModal + vbExclamation + vbOKOnly, "Erreur")
        End Try
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
            If TestLink.IndexOf(".png", StringComparison.CurrentCultureIgnoreCase) <> -1 Or TestLink.IndexOf(".jpg", StringComparison.CurrentCultureIgnoreCase) <> -1 Or TestLink.IndexOf(".jpeg", StringComparison.CurrentCultureIgnoreCase) <> -1 Or TestLink.IndexOf(".gif", StringComparison.CurrentCultureIgnoreCase) <> -1 Or TestLink.IndexOf(".bmp", StringComparison.CurrentCultureIgnoreCase) <> -1 Or TestLink.IndexOf(".webp", StringComparison.CurrentCultureIgnoreCase) <> -1 Then
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
            Threading.Thread.Sleep(500)
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
        If IMGH < 200 And IMGV < 200 And IMGHR < 30 And IMGVR < 30 Then MsgBox($"Image trop petite : {IMGV}x{IMGH} - Res: {IMGVR}x{IMGHR}{vbCrLf}L'image doit dépasser 200x200 - Res: 30x30", vbApplicationModal + vbExclamation + vbOKOnly) Else Btn_Accept.Enabled = True
        'sinon c'est bon on peut rajouter l'image 

    End Sub

    Private Sub PictureBox_TestIMG_LoadProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles PictureBox_TestIMG.LoadProgressChanged
        Dim percent As Integer = 75
        ProgressBar_IMGLoad.Maximum = 75
        If e.ProgressPercentage > 75 Then
            ProgressBar_IMGLoad.Maximum = e.ProgressPercentage
            percent = e.ProgressPercentage
        End If
        ProgressBar_IMGLoad.Value = e.ProgressPercentage
    End Sub

    Private Sub txt_TestIMG_TextChanged(sender As Object, e As EventArgs) Handles txt_TestIMG.TextChanged
        'si le texte change pour eviter qu'on fasse une erreur.. ou pire... 
        Btn_Accept.Enabled = False
    End Sub

    Private Sub txt_TestIMG_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_TestIMG.MouseDoubleClick
        txt_TestIMG.Clear()
    End Sub
End Class
