Imports System.ComponentModel
Imports System.Windows.Forms
Imports HtmlAgilityPack

Public Class Dialog_AskInfo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Bouton modifier
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'On va donc ajouter la ligne à la base de données en appelant la fonction RecData
        Dim Result As Boolean = RecData()
        If Result = False Then
            Exit Sub
        Else
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Bouton annuler
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button_Garder_Click(sender As Object, e As EventArgs) Handles Button_Garder.Click
        'Bouton garder les infos 
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes

        Me.Close()
    End Sub

    Private Sub txt_tvg_chno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tvg_chno.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Or Not Char.IsPunctuation(e.KeyChar) Or Not Char.IsSeparator(e.KeyChar) Or Not Char.IsSymbol(e.KeyChar) Then
            If (e.KeyChar = Chr(34)) Then
                e.Handled = True
            End If

        End If
    End Sub


    Private Sub txt_NomChaine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NomChaine.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Or Not Char.IsPunctuation(e.KeyChar) Or Not Char.IsSeparator(e.KeyChar) Or Not Char.IsSymbol(e.KeyChar) Then
            If (e.KeyChar = Chr(34)) Then
                e.Handled = True
            End If

        End If
    End Sub



    Private Sub txt_tvg_shift_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tvg_shift.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Or Not Char.IsPunctuation(e.KeyChar) Or Not Char.IsSeparator(e.KeyChar) Or Not Char.IsSymbol(e.KeyChar) Then
            If (e.KeyChar = Chr(34)) Then
                e.Handled = True
            End If

        End If
    End Sub



    Private Sub txt_tvg_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tvg_id.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Or Not Char.IsPunctuation(e.KeyChar) Or Not Char.IsSeparator(e.KeyChar) Or Not Char.IsSymbol(e.KeyChar) Then
            If (e.KeyChar = Chr(34)) Then
                e.Handled = True
            End If

        End If
    End Sub


    Private Sub txt_group_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_group.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Or Not Char.IsPunctuation(e.KeyChar) Or Not Char.IsSeparator(e.KeyChar) Or Not Char.IsSymbol(e.KeyChar) Then
            If (e.KeyChar = Chr(34)) Then
                e.Handled = True
            End If

        End If
    End Sub


    Private Sub txt_categorie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_categorie.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Or Not Char.IsPunctuation(e.KeyChar) Or Not Char.IsSeparator(e.KeyChar) Or Not Char.IsSymbol(e.KeyChar) Then
            If (e.KeyChar = Chr(34)) Then
                e.Handled = True
            End If

        End If
    End Sub


    Private Sub txt_Pays_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Pays.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Or Not Char.IsPunctuation(e.KeyChar) Or Not Char.IsSeparator(e.KeyChar) Or Not Char.IsSymbol(e.KeyChar) Then
            If (e.KeyChar = Chr(34)) Then
                e.Handled = True
            End If

        End If
    End Sub



    Private Sub txt_Desc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Desc.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) Or Not Char.IsPunctuation(e.KeyChar) Or Not Char.IsSeparator(e.KeyChar) Or Not Char.IsSymbol(e.KeyChar) Then
            If (e.KeyChar = Chr(34)) Then
                e.Handled = True
            End If

        End If
    End Sub



    Private Sub PictureBox_tvg_logo_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox_tvg_logo.DoubleClick
        'Changement de la photo 
        PictureBox_tvg_logo.Cursor = Cursors.AppStarting
        'Il faudra ouvrir une form avec le choix de plusieurs images trouvées
        'd'abord etre sur que le nom de la chaine est bien marquée dans le textbox nomchaine 
        'ensuite, il faut faire un scan sur le serveur (on peut aussi faire un scan sur google image ou autre. on verra plus tard) 
        'on fait une recherche instring dans les liens qu'on trouve. , on prend ensuite le http/https et le bmp, png, jpeg, jpg, gif etc.. pour etre sur que ce soit une image
        'on peut ensuite faire une liste de ce qu'on trouve 
        If txt_NomChaine.Text = Nothing Or txt_NomChaine.Text = "" Then
            MsgBox("Erreur", vbApplicationModal + vbOKOnly, "Erreur")
            Exit Sub
        End If
        'Donc on continue si le nom est bien indiqué. On va rechercher dans le serveur , mais... il peut etre inaccessible, donc on fait un Try
        Try
            'On met en variable le nom de la chaine pour l'utiliser et modifier a souhait
            Dim NomChaine As String = txt_NomChaine.Text
            'On supprime les mots inutiles dans la recherche. 
            If NomChaine.Contains(" - ") = True Then NomChaine = Mid(NomChaine, InStr(NomChaine, " - ") + 3)
            If NomChaine.Contains(" FHD") = True Then NomChaine = Mid(NomChaine, 1, InStr(NomChaine, " FHD"))
            If NomChaine.Contains(" HD") = True Then NomChaine = Mid(NomChaine, 1, InStr(NomChaine, " HD"))
            If NomChaine.Contains(" SD") = True Then NomChaine = Mid(NomChaine, 1, InStr(NomChaine, " SD"))

            'Obligé de splitter le nom pour une meilleure recherche
            Dim Split As String() = NomChaine.Split(New [Char]() {" "c})

            'On récupère le fichier html des logos dans une variable
            Dim PageWeb As New List(Of String)
            Dim Strm As IO.StreamReader = New IO.StreamReader(FileWebLogo)
            Dim Ligne As String = Strm.ReadLine, Ligne2 As String = Nothing
            Dim Resultat As New List(Of String), Resultat2 As New List(Of String)
            'tant que Strm n'est pas au bout du fichier
            Dim t As Integer = 0
            Do While Not Strm.EndOfStream
                ' pour s = le/s mot/s a tester de Split
                For Each s As String In Split
                    'Si le mot est trouvé dans la ligne
                    If Ligne.IndexOf(s, 0, Ligne.Length, StringComparison.CurrentCultureIgnoreCase) <> -1 Then
                        'Si Split a plus d'un mot
                        If Split.Count > 1 Then
                            'Si la longueur est plus grande que 2
                            If s.Length > 2 Then
                                'si la ligne n'est pas déjà dans le fichier pour eviter d'avoir des doublons ou si resultat ne contient rien
                                If Resultat.Count < 1 Or Resultat.IndexOf(Ligne) = -1 Then
                                    'On ajoute la ligne
                                    Resultat.Add(Ligne)
                                End If
                                'Sinon si longueur plus petit que 2
                            End If
                                'Si Split = 1 mot seulement
                            ElseIf Split.Count = 1 Then
                            Resultat.Add(Ligne)
                        End If
                    End If
                Next
                PageWeb.Add(Ligne)
                Ligne = Strm.ReadLine
            Loop

            'On envoie les données
            Strm.Close()
            Strm.Dispose()
            PageWeb.Clear()
            Ligne = Nothing
            ImageView.ImgList(Resultat.Count, Resultat)
            Resultat.Clear()



        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbApplicationModal + vbOKOnly, "Erreur")
            Exit Sub
        End Try


    End Sub

    Private Sub PictureBox_tvg_logo_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles PictureBox_tvg_logo.LoadCompleted
        PictureBox_tvg_logo.Cursor = Cursors.Arrow
    End Sub

    Private Sub txt_Desc_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_Desc.MouseDoubleClick
        txt_Desc.Clear()
    End Sub

    Private Sub txt_Pays_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_Pays.MouseDoubleClick
        txt_Pays.Clear()
    End Sub

    Private Sub txt_categorie_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_categorie.MouseDoubleClick
        txt_categorie.Clear()
    End Sub

    Private Sub txt_group_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_group.MouseDoubleClick
        txt_group.Clear()
    End Sub

    Private Sub txt_tvg_id_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tvg_id.MouseDoubleClick
        txt_tvg_id.Clear()
    End Sub

    Private Sub txt_tvg_shift_MouseDoubleClick(sender As Object, e As EventArgs) Handles txt_tvg_shift.MouseDoubleClick
        txt_tvg_shift.Clear()
    End Sub

    Private Sub txt_tvg_chno_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_tvg_chno.MouseDoubleClick
        txt_tvg_chno.Clear()
    End Sub

    Private Sub txt_NomChaine_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_NomChaine.MouseDoubleClick
        txt_NomChaine.Clear()
    End Sub

    Private Sub Btn_Rech_Click(sender As Object, e As EventArgs) Handles Btn_Rech.Click
        'le bouton recherche permet de rechercher dans la base de données s'il y a déjà des infos sur la chaine , ce qui évite de tout réécrire
        Dim NomChaineRech As String = txt_NomChaine.Text
        If NomChaineRech = Nothing Or NomChaineRech = "" Then
            MsgBox("Aucun nom de chaine !" + vbApplicationModal + vbOKOnly + vbExclamation, "Erreur")
        Else
            'On peut rechercher le nom dans la BDD, on va voir s'il donne un resultat ou non
            Dim Result As Boolean = RechercheNomChaine(NomChaineRech)
            If Result = False Then
                MsgBox($"Aucune entrée trouvée pour : {NomChaineRech}", vbApplicationModal + vbExclamation + vbOKOnly, "Erreur")
            End If
        End If
    End Sub
End Class
