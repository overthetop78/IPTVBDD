Imports System.ComponentModel
Imports System.Windows.Forms
Imports HtmlAgilityPack

Public Class Dialog_AskInfo
    Public FileWebLogo As String = Application.StartupPath & "\listelogo.txt"


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Bouton modifier
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'On va donc ajouter la ligne à la base de données en appelant la fonction RecData
        Dim Result As Boolean = mod_var.RecData
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

    Private Sub Dialog_AskInfo_Load(sender As Object, e As EventArgs)


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

    Private Sub Dialog_AskInfo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txt_NomChaine.Text = mod_var.NomChaine
        txt_tvg_id.Text = mod_var.tvg_id
        txt_tvg_chno.Text = mod_var.tvg_chno
        txt_tvg_shift.Text = mod_var.tvg_shift
        txt_group.Text = mod_var.group_channel
        If txt_NomChaine.Text = Nothing Or txt_NomChaine.Text = "" Then Button_Garder.Enabled = False
        If mod_var.tvg_logo <> Nothing Then PictureBox_tvg_logo.ImageLocation = tvg_logo
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
                    If s <> "TV" And s.Length > 1 And Ligne.IndexOf(s, 0, Ligne.Length, StringComparison.CurrentCultureIgnoreCase) <> -1 And t = 0 Then
                        Ligne2 = Ligne
                        If Split.Count > 1 Then t = Split.Count Else t = 0
                    End If
                    If s.Length > 0 And Ligne.IndexOf(s, 0, Ligne.Length, StringComparison.CurrentCultureIgnoreCase) <> -1 And t > 1 Then
                        Ligne2 = Ligne
                    End If
                    If Split.Last = s And Ligne2 <> Nothing Then
                        Resultat.Add(Ligne2)
                        'MsgBox("trouvé: " & Ligne2, vbApplicationModal + vbOKOnly, "Find")
                        Ligne2 = Nothing
                        t = 0
                    End If
                Next
                PageWeb.Add(Ligne)
                Ligne = Strm.ReadLine
            Loop

            'On envoie les données
            ImageView.ImgList(Resultat.Count, Resultat)


        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbApplicationModal + vbOKOnly, "Erreur")
            Exit Sub
        End Try


    End Sub

    Private Sub PictureBox_tvg_logo_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles PictureBox_tvg_logo.LoadCompleted
        PictureBox_tvg_logo.Cursor = Cursors.Arrow
    End Sub
End Class
