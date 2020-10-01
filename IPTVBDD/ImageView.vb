Imports System.Windows.Forms
Imports System.Web.HttpUtility

Public Class ImageView

    'Création de la Sub qui récuperera les données
    Public Sub ImgList(ImageCountSub As Integer, ImageListSub As List(Of String))
        ImageListName.Clear()
        ImageListURL.Clear()
        If ImageCountSub > 0 Then
            ImageCount = ImageCountSub - 1

            'Traiter la liste avec deux nouvelles listes modifiant les lignes
            For i = 0 To ImageCount
                'Traitement de la ligne
                Dim tt As String = ImageListSub.Item(i)
                Dim ttURL As String = Mid(tt, InStr(tt, "href=") + 6)
                Dim ttName As String = Mid(ttURL, InStr(ttURL, ">") + 1)
                ttURL = Mid(ttURL, 1, InStr(ttURL, ">") - 2)
                ttName = Mid(ttName, 1, InStr(ttName, "<") - 1)
                ttURL = LinkImg & ttURL
                Try
                    ImageListURL.Add(ttURL)
                    ImageListName.Add(ttName)
                Catch ex As Exception
                    MsgBox("Erreur: " & ex.Message, vbApplicationModal + vbOKOnly, "Erreur")

                End Try
            Next

            ScrollPic.Maximum = ImageCount
            ScrollPic.Value = 0
            PictureView.ImageLocation = ImageListURL.Item(ScrollPic.Value)
            lbl_ImageName.Text = ImageListName.Item(ScrollPic.Value)

            'Ouverture de la fenetre
            Me.ShowDialog()
        Else
            'On dit qu'aucune image n'a été trouvé et on demande : soit de changer le nom , soit de faire une recherche sur internet et de rentrer l'adresse de l'image (acceptant que les png, jpg jpeg gif...)
            Dim Requete As MsgBoxResult = MsgBox("Aucune image trouvée pour [ " & Dialog_AskInfo.txt_NomChaine.Text & " ]" &
                                                 vbCrLf & "Modifier le nom de la chaine ou chercher le logo sur Internet ?" &
                                                 vbCrLf & "Selectionner [Oui] pour chercher le logo sur Internet" &
                                                 vbCrLf & "Selectionner [Non] pour modifier le nom de la chaine", vbApplicationModal + vbExclamation + vbYesNo, "Aucun Logo")
            If Requete = vbYes Then
                'on fait la recherche sur Internet en ouvrant le navigateur vers googleimage et la recherche du nom de chaine 
                'on ouvre une boite de dialogue permettant de rentrer le lien d'une image qu'on controlera si elle est valide (taille poids, extension, p-e meme une verif du nom)
                'si c'est Ok, on va enregistrer l'image vers le serveur par SFTP en renommant l'image par rapport au nom de la chaine.
                NomChaineRech = Dialog_AskInfo.txt_NomChaine.Text
                HtmlEncode(NomChaineRech)
                NomChaineRech = Replace(NomChaineRech, Chr(32), "%20")
                Process.Start("https://www.google.fr/search?hl=fr&tbm=isch&source=hp&q=logo%20" & NomChaineRech)
                Dialog_WebLinkImg.ShowDialog()

            ElseIf Requete = vbNo Then
                'On revient a la dialog_askinfo pour changer le nom
                Exit Sub
            End If
        End If

    End Sub

    Private Sub ScrollPic_Scroll(sender As Object, e As ScrollEventArgs) Handles ScrollPic.Scroll
        Try
            PictureView.ImageLocation = ImageListURL.Item(ScrollPic.Value)
            lbl_ImageName.Text = ImageListName.Item(ScrollPic.Value)
            Threading.Thread.Sleep(100)
        Catch ex As Exception
            MsgBox(ex.Message, vbApplicationModal)
        End Try
    End Sub

    Private Sub Btn_AddLogo_Click(sender As Object, e As EventArgs) Handles Btn_AddLogo.Click
        Dim Confirm As MsgBoxResult = MsgBox("Vous n'avez pas trouver le bon logo ?" & vbCrLf & "Voulez-vous en ajouter une nouvelle ?", vbApplicationModal + vbInformation + vbYesNo, "Confirmation")
        If Confirm = MsgBoxResult.No Then
            Exit Sub
        Else
            NomChaineRech = Dialog_AskInfo.txt_NomChaine.Text
            HtmlEncode(NomChaineRech)
            NomChaineRech = Replace(NomChaineRech, Chr(32), "%20")
            Process.Start("https://www.google.fr/search?hl=fr&tbm=isch&source=hp&q=logo%20" & NomChaineRech)
            Dialog_WebLinkImg.ShowDialog()
        End If

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Copie du lien de l'image vers tvg_logo
        tvg_logo = PictureView.ImageLocation
        Dialog_AskInfo.PictureBox_tvg_logo.ImageLocation = PictureView.ImageLocation
        ImageListName.Clear()
        ImageListURL.Clear()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        ImageListName.Clear()
        ImageListURL.Clear()
        Me.Close()
    End Sub




End Class
