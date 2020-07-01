Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Data.Sqlite
Imports Vlc.DotNet.Core
Imports Vlc.DotNet.Forms
Imports Vlc.DotNet.Core.Interops
Imports Vlc.DotNet.Core.Interops.Signatures


Public Class Form1
    Public Shared FichierM3U As String, Adresse As String = Nothing, AdresseHTTP As String, Pseudo As String, Pass As String, HTTPVer As String, DBLink As String, HTTPPort As String, NoCanal As Integer = 0
    Public Shared DBConnect As String = "Data Source=" & Application.StartupPath & "\" & "IPTVDatabase.sqlite", DBFile As String = Application.StartupPath & "\" & "IPTVDatabase.sqlite"
    Public RepNomChaine As String = Nothing, Reptvg_id As String = Nothing
    Public NomChaine As String = Nothing, tvg_chno As String = Nothing, tvg_name As String = Nothing, tvg_id As String = Nothing, tvg_shift As String = Nothing, group_title As String = Nothing, tvg_logo As String = Nothing
    Public FileWebLogo As String = Application.StartupPath & "\listelogo.txt"
    Public Shared VideoCodec As String = Nothing, VideoTrack As VideoTrack, VideoH As Integer = 0, VideoV As Integer = 0, VideoBitRate As Integer = 0, VideoDesc As String = Nothing, VideoID As Integer = 0, VideoLang As String = Nothing
    Public Shared VideoLevel As Integer = 0, VideoOriginalCodec As String = Nothing, VideoProfile As Integer = 0, VideoTrackID As Integer = 0, VideoTrackName As String = Nothing, VideoFPS As Single
    Public Shared AudioCodec As String = Nothing, AudioTrack As AudioTrack, AudioChannel As Integer = 0, AudioRate As Integer = 0, AudioBitRate As Integer = 0, AudioDesc As String = Nothing, AudioID As Integer = 0, AudioLang As String = Nothing
    Public Shared AudioLevel As Integer = 0, AudioOriginalCodec As String = Nothing, AudioProfile As Integer = 0
    Public Shared AudioCodec2 As String = Nothing, AudioTrack2 As AudioTrack, AudioChannel2 As Integer = 0, AudioRate2 As Integer = 0, AudioBitRate2 As Integer = 0, AudioDesc2 As String = Nothing, AudioID2 As Integer = 0, AudioLang2 As String = Nothing



    Public Shared AudioLevel2 As Integer = 0, AudioOriginalCodec2 As String = Nothing, AudioProfile2 As Integer = 0
    Public Shared AudioTrackID As Integer = 0, AudioTrackName As String = Nothing, AudioTrackID2 As Integer = 0, AudioTrackName2 As String = Nothing
    Public Shared SubtitleCodec As String = Nothing, SubtitleTrack As SubtitleTrack, SubtitleTrackEnc As String = Nothing, SubtitleBitrate As Integer = 0, SubtitleDesc As String = Nothing, SubtitleID As Integer = 0, SubtitleLang As String = Nothing
    Public Shared SubtitleLevel As Integer = 0, SubtitleOriginalCodec As String = Nothing, SubtitleProfile As Integer = 0
    Public Shared SubtitleCodec2 As String = Nothing, SubtitleTrack2 As SubtitleTrack, SubtitleTrackEnc2 As String = Nothing, SubtitleBitrate2 As Integer = 0, SubtitleDesc2 As String = Nothing, SubtitleID2 As Integer = 0, SubtitleLang2 As String = Nothing
    Public Shared SubtitleLevel2 As Integer = 0, SubtitleOriginalCodec2 As String = Nothing, SubtitleProfile2 As Integer = 0
    Public Shared SubtitleTrackID As Integer = 0, SubtitleTrackName As String = Nothing, SubtitleTrackID2 As Integer = 0, SubtitleTrackName2 As String = Nothing



    Private Delegate Sub ModifNumericUpDownDelegate(ByVal i As Integer)
    Private Sub ModifNumericUpDown(ByVal i As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New ModifNumericUpDownDelegate(AddressOf ModifNumericUpDown), i)
        Else
            Try
                NumericUpDown1.Value = i
            Catch ex As Exception
                MsgBox(ex.Message, vbApplicationModal)
            End Try
        End If
    End Sub

    Private Delegate Sub UpdateListDelegate(ByVal itemName As String)
    Private Sub UpdateList(ByVal itemName As String)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateListDelegate(AddressOf UpdateList), itemName)
        Else
            ' UpdateList
            ' add list add code
            Try
                ListBox1.Items.Add(itemName)
                ListBox1.TopIndex = ListBox1.Items.Count - 1
            Catch ex As Exception
                MsgBox(ex.Message, vbApplicationModal)
            End Try
        End If
    End Sub

    Private Delegate Sub UpdateProgressBarDelegate(ByVal itemName As Single)
    Private Sub UpdateProgressBar(ByVal itemName As String)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateListDelegate(AddressOf UpdateProgressBar), itemName)
        Else
            StatutBarProgress.Value = CInt(itemName)
            StatutBarProgress.ToolTipText = itemName & " %"
        End If
    End Sub

    Private Delegate Sub UpdateDialogDelegate(Question As Integer, OldAnswer As String)
    Private Sub UpdateDialog(Question As Integer, OldAnswer As String)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateDialogDelegate(AddressOf UpdateDialog), Question, OldAnswer)
        Else
            Select Case Question
                Case 1
                    mod_var.NomChaine = OldAnswer
                Case 2
                    mod_var.tvg_id = OldAnswer
                Case 3
                    mod_var.tvg_chno = OldAnswer
                Case 4
                    mod_var.group_channel = OldAnswer
                Case 5
                    mod_var.tvg_shift = OldAnswer
                Case 6
                    mod_var.tvg_logo = OldAnswer
                    If OldAnswer = Nothing Or OldAnswer = "" Then
                        Dialog_AskInfo.PictureBox_tvg_logo.Image = Nothing
                        Dialog_AskInfo.PictureBox_tvg_logo.BackgroundImage = Nothing
                    End If
                Case 7
                    mod_var.Pays = OldAnswer
                Case 8
                    mod_var.Desc = OldAnswer
                Case 9
                    mod_var.Cat = OldAnswer
                Case Else
                    Exit Select
            End Select
        End If
    End Sub

    Private Delegate Sub UpdateInfoDelegate(ByVal NomChaine, VideoTrackID, VideoTrackName, VideoCodec, VideoV, VideoH, VideoFPS, VideoOriginalCodec, AudioTrackID, AudioTrackName, AudioCodec, AudioLang, AudioChannel, AudioRate, AudioOriginalCodec,
AudioTrackID2, AudioTrackName2, AudioCodec2, AudioLang2, AudioChannel2, AudioRate2, AudioOriginalCodec2, SubtitleTrackID, SubtitleTrackName, SubtitleCodec, SubtitleLang, SubtitleDesc, SubtitleOriginalCodec,
SubtitleTrackID2, SubtitleTrackName2, SubtitleCodec2, SubtitleLang2, SubtitleDesc2, SubtitleOriginalCodec2)
    Private Sub UpdateInfo(ByVal NomChaine, VideoTrackID, VideoTrackName, VideoCodec, VideoV, VideoH, VideoFPS, VideoOriginalCodec, AudioTrackID, AudioTrackName, AudioCodec, AudioLang, AudioChannel, AudioRate, AudioOriginalCodec,
AudioTrackID2, AudioTrackName2, AudioCodec2, AudioLang2, AudioChannel2, AudioRate2, AudioOriginalCodec2, SubtitleTrackID, SubtitleTrackName, SubtitleCodec, SubtitleLang, SubtitleDesc, SubtitleOriginalCodec,
SubtitleTrackID2, SubtitleTrackName2, SubtitleCodec2, SubtitleLang2, SubtitleDesc2, SubtitleOriginalCodec2)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateInfoDelegate(AddressOf UpdateInfo), NomChaine, VideoTrackID, VideoTrackName, VideoCodec, VideoV, VideoH, VideoFPS, VideoOriginalCodec, AudioTrackID, AudioTrackName, AudioCodec, AudioLang, AudioChannel, AudioRate, AudioOriginalCodec,
AudioTrackID2, AudioTrackName2, AudioCodec2, AudioLang2, AudioChannel2, AudioRate2, AudioOriginalCodec2, SubtitleTrackID, SubtitleTrackName, SubtitleCodec, SubtitleLang, SubtitleDesc, SubtitleOriginalCodec,
SubtitleTrackID2, SubtitleTrackName2, SubtitleCodec2, SubtitleLang2, SubtitleDesc2, SubtitleOriginalCodec2)
        Else
            lbl_NameChannel.Text = NomChaine
            'Video
            lbl_VideoIDVal.Text = CStr(VideoTrackID)
            lbl_VideoNameVal.Text = VideoTrackName
            lbl_VideoCodecVal.Text = UCase(VideoCodec)
            lbl_VideoResVal.Text = CStr(VideoV) & "x" & CStr(VideoH)
            lbl_VideoFPSVal.Text = CStr(VideoFPS) & " FPS"
            lbl_VideoDefVal.Text = CStr(VideoH) & "P"
            lbl_VideoOriginalCodecVal.Text = UCase(VideoOriginalCodec)
            'Audio 1
            lbl_AudioID1Val.Text = CStr(AudioTrackID)
            lbl_AudioName1Val.Text = AudioTrackName
            lbl_AudioCodec1Val.Text = UCase(AudioCodec)
            lbl_AudioLang1Val.Text = UCase(AudioLang)
            lbl_AudioChannel1Val.Text = CStr(AudioChannel)
            lbl_AudioRate1Val.Text = CStr(AudioRate) & " khz"
            lbl_AudioOriginalCodec1Val.Text = UCase(AudioOriginalCodec)
            'Audio 2
            lbl_AudioID2Val.Text = CStr(AudioTrackID2)
            lbl_AudioName2Val.Text = AudioTrackName2
            lbl_AudioCodec2Val.Text = UCase(AudioCodec2)
            lbl_AudioLang2Val.Text = UCase(AudioLang2)
            lbl_AudioChannel2Val.Text = CStr(AudioChannel2)
            lbl_AudioRate2Val.Text = CStr(AudioRate2) & " khz"
            lbl_AudioOriginalCodec2Val.Text = UCase(AudioOriginalCodec2)
            'Subtitle 1
            lbl_SubID1Val.Text = CStr(SubtitleTrackID)
            lbl_SubName1Val.Text = SubtitleTrackName
            lbl_SubCodec1Val.Text = UCase(SubtitleCodec)
            lbl_SubLang1Val.Text = UCase(SubtitleLang)
            lbl_SubDesc1Val.Text = SubtitleDesc
            lbl_SubOriginalCodec1Val.Text = SubtitleOriginalCodec
            'Subtitle 2
            lbl_SubID2Val.Text = CStr(SubtitleTrackID2)
            lbl_SubName2Val.Text = SubtitleTrackName2
            lbl_SubCodec2Val.Text = UCase(SubtitleCodec2)
            lbl_SubLang2Val.Text = UCase(SubtitleLang2)
            lbl_SubDesc2Val.Text = SubtitleDesc2
            lbl_SubOriginalCodec2Val.Text = SubtitleOriginalCodec2

        End If
    End Sub
    Private Sub VlcControl1_Click(sender As Object, e As EventArgs) Handles VlcControl1.Click

    End Sub

    Public SQLConnexion As SqliteConnection, SQLCommand As SqliteCommand

    Private Sub ListeScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeScanToolStripMenuItem.Click
        'Scan des canaux de la liste M3U ligne par ligne 
        ScanCanal(2, FichierM3U, AdresseHTTP)
    End Sub

    Private Sub ActiveScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveScanToolStripMenuItem.Click
        'Scan des canaux présent dans la base de données étant actif
        ScanCanal(3, FichierM3U, AdresseHTTP)
    End Sub

    Private Sub NoActiveScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoActiveScanToolStripMenuItem.Click
        'Scan des canaux présent dans la base de données étant inactif 
        ScanCanal(4, FichierM3U, AdresseHTTP)
    End Sub

    Private Sub FullScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScanToolStripMenuItem.Click
        'Scan des canaux 1 par 1 à partir de 0 . Ajout dans la base de données ou modifie si il existe déjà
        ' Si le canal ne donne aucun signal , des paramètres automatique seront effectués
        ScanCanal(1, FichierM3U, AdresseHTTP)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Affichage nom de l'application et version
        Me.Text = "IPTV DataBase - " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & " Build " & My.Application.Info.Version.Build
        Me.Width = 1500 / 15 * 10
        'verification si la base de donnée existe déjà
        ScanToolStripMenuItem.Enabled = False
        ExportStripMenuItem.Enabled = False
        If File.Exists(DBFile) = False Then CreationDB(DBConnect)

        StatutBar_InfoBGW.BackColor = Color.Black
        StatutBar_InfoBGW.ToolTipText = "Aucun fichier chargé"
        NumericUpDown1.ReadOnly = False

        'Dialog_AskInfo 
        Dialog_AskInfo.Owner = Me
        Dialog_AskInfo.StartPosition = FormStartPosition.CenterScreen

        If File.Exists(FileWebLogo) = False Or File.GetCreationTime(FileWebLogo) < DateTime.Today Or File.GetLastWriteTime(FileWebLogo) < DateTime.Today Then
            Dim Web As New HtmlAgilityPack.HtmlWeb, url As String = "http://informaweb.freeboxos.fr/iptv/logos_tv/"
            Dim PageWeb = Web.Load(url)
            PageWeb.Save(FileWebLogo)
        End If

    End Sub


    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub Btn_StopScan_Click(sender As Object, e As EventArgs) Handles Btn_StopScan.Click
        If BGW.WorkerSupportsCancellation = True Then
            BGW.CancelAsync()
            NumericUpDown1.ReadOnly = False
        End If
    End Sub


    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        'Ouvrir un fichier m3u 
        With OpenFileDialog1
            .Filter = "Liste de lecture M3U|*.m3u|Tout|*.*"
            .DefaultExt = "m3u"
            .FileName = ""
            .RestoreDirectory = True
            .ShowDialog()
            FichierM3U = .FileName
        End With
        If OpenFileDialog1.FileName = Nothing Then Exit Sub
        'Scan du fichier par la fonction ScanM3UFile
        If ScanM3UFile(FichierM3U) = True Then UpdateList("Chargement effectué")
        'Le fichier chargé on peut maintenant le lire ligne par ligne pour en extraire les données
        'Extraction du lien de connexion, du pseudo et mot de passe pour pouvoir scanner 
        'Extraction des nom de chaine TV et le numéro de canal IPTV pour les rentrer dans une base de données
        If ExtractLink(FichierM3U) = True Then
            UpdateList("Extraction effectuée")
            ScanToolStripMenuItem.Enabled = True
            ExportStripMenuItem.Enabled = True
        End If
        StatutBar_InfoBGW.BackColor = Color.DarkGreen
        StatutBar_InfoBGW.ToolTipText = "Liste de Lecture chargée"
    End Sub

    Public Function ScanM3UFile(FichierM3U As String) As Boolean
        'vérification si le fichier est bien un fichier M3U et s'il est valide en IPTV 
        Dim Lignes As String() = File.ReadAllLines(FichierM3U)
        'Test de la premiere ligne qui doit être #EXTM3U
        Dim i As Integer = 0
        For i = 0 To Lignes.Length - 1
            Try
                If Lignes(i).Contains("#EXTM3U") = True Then
                    Exit For
                Else
                    If i = Lignes.Length - 1 Then
                        MsgBox("Ce fichier n'est pas une liste de lecture M3U", vbApplicationModal + vbExclamation + vbOKOnly, "Fichier non valide")
                        Exit For
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical + vbApplicationModal + vbOKOnly, "Erreur")

            Finally
                'On continue car le fichier est bien un M3U 

            End Try
        Next
        'Test de la seconde ligne qui doit etre #EXTINF et la suivante qui doit etre http
        For i = 0 To Lignes.Length - 1
            Try
                If Lignes(i).Contains("#EXTINF") = True Then
                    If Lignes(i + 1).Contains("http") = True Then
                        ScanM3UFile = True
                        Exit For
                    Else
                        If i = Lignes.Length - 1 Then
                            MsgBox("Aucune chaine IPTV trouvée", vbApplicationModal + vbExclamation + vbOKOnly, "Fichier non valide")
                            Exit For
                        End If
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical + vbApplicationModal + vbOKOnly, "Erreur")

            Finally
                'On continue car le fichier est bien un M3U 

            End Try
        Next
        Return ScanM3UFile
    End Function

    Private Sub StatutBar_NoCanal_Click(sender As Object, e As EventArgs)

    End Sub

    Function ExtractLink(FichierM3U) As Boolean
        Dim Lignes As String() = File.ReadAllLines(FichierM3U), HTTPCount As Integer
        Dim i As Integer = 0
        For i = 0 To Lignes.Length - 1
            Try
                If Lignes(i).Contains("#EXTINF") Then i = i + 1 Else Exit Try
                If Lignes(i).Contains("http") = True Then
                    'extraction des infos
                    Dim LigneHTTP As String = Lignes(i)
                    If Lignes(i).Contains("http://") Then
                        HTTPCount = 7
                        HTTPVer = "http"
                    ElseIf Lignes(i).Contains("https://") Then
                        HTTPCount = 8
                        HTTPVer = "https"
                    End If
                    LigneHTTP = Mid(Lignes(i), HTTPCount + 1)
                    AdresseHTTP = Mid(LigneHTTP, 1, InStr(LigneHTTP, "/") - 1)
                    LigneHTTP = Mid(LigneHTTP, AdresseHTTP.Length + 2)
                    Pseudo = Mid(LigneHTTP, 1, InStr(LigneHTTP, "/") - 1)
                    LigneHTTP = Mid(LigneHTTP, Pseudo.Length + 2)
                    Pass = Mid(LigneHTTP, 1, InStr(LigneHTTP, "/") - 1)
                    LigneHTTP = Mid(LigneHTTP, Pass.Length + 2)
                    HTTPPort = Mid(AdresseHTTP, InStr(AdresseHTTP, ":") + 1)
                    AdresseHTTP = Mid(AdresseHTTP, 1, InStr(AdresseHTTP, ":") - 1)
                    Adresse = AdresseHTTP
                    If Adresse.Contains(".") Then Adresse = Replace(Adresse, ".", "_")
                    If Adresse.Contains("-") Then Adresse = Replace(Adresse, "-", "_")
                    'Connexion a la base de données 
                    Try
                            Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect)
                            SQLConnexion.Open()
                            SQLCommand = SQLConnexion.CreateCommand()
                        'On doit tester si la table existe, sinon on la créer

                        ' on va tester si la ligne existe déjà . Si oui , on vérifiera que la table associée existe
                        ' Si non, on va créer la ligne et la table 
                        Dim TestLigneDB As Boolean
                        Dim cmd As String = "SELECT * FROM InfoIPTV WHERE AdresseHTTP='" & AdresseHTTP & "';"
                        SQLCommand.CommandText = cmd
                        TestLigneDB = SQLCommand.ExecuteScalar

                        If TestLigneDB = False Then
                            'creation de la ligne
                            SQLCommand = SQLConnexion.CreateCommand()
                            cmd = "INSERT INTO InfoIPTV (HTTPVer,AdresseHTTP,HTTPPort,Pseudo,Pass) VALUES ('" & HTTPVer & "','" & AdresseHTTP & "','" & HTTPPort & "','" & Pseudo & "','" & Pass & "');"
                            SQLCommand.CommandText = cmd
                            SQLCommand.ExecuteNonQuery()
                            'creation de la table . Il faut : le numéro du canal (du http), le Nom de la chaine, le nom EPG de la chaine, Le numéro de la chaine, le groupe de la chaine, le lien vers le logo de la chaine, le timeshift, 
                            ' description de la chaine, Type de chaines (Sports, Generalistes, Musicales, Radio, Cinema, Divertissements, Jeunesse, Decouvertes, Locales, Infos,etc..), Pays, 
                            ' Type video (AVC, HEVC, MPEG2), résolution video (1920*1080), définition video (1080P, 720P, 540P), FPS,  Nombre de langage, Langue 1 (Fra), Langue 1 Type (AAC, Dolby Digital), Langue 2 (Eng) Langue 2 Type (AAC, Dolby Digital)
                            ' Nombre de Sous-titre, Sous-titre 1 (Fra), Sous-Titre 2 (Eng) 
                            SQLCommand = SQLConnexion.CreateCommand()
                            cmd = "CREATE TABLE '" & Adresse & "' (
    NoCanal INT NOT NULL PRIMARY KEY,
    NomChaine VARCHAR(100) NOT NULL,
    NomEPG VARCHAR(100),
    NoChaine VARCHAR(10),
    GroupeChaine VARCHAR(100),
    LinkLogo VARCHAR(255),
    Timeshift VARCHAR(10),
    Description TEXT,
    CatChaine VARCHAR(100),
    Pays VARCHAR(100),
    VideoID INT,
    VideoName VARCHAR(50),
    VideoCodec VARCHAR(10),
    VideoV INT,
    VideoH INT,
    VideoFPS SINGLE,
    VideoOriginalCodec VARCHAR(10),
    AudioID1 INT,
    AudioName1 VARCHAR(100),
    AudioCodec1 VARCHAR(10),
    AudioLang1 VARCHAR(10),
    AudioChannel1 INT,
    AudioRate1 INT,
    AudioOriginalCodec1 VARCHAR(10),
    AudioID2 INT,
    AudioName2 VARCHAR(100),
    AudioCodec2 VARCHAR(10),
    AudioLang2 VARCHAR(10),
    AudioChannel2 INT,
    AudioRate2 INT,
    AudioOriginalCodec2 VARCHAR(10),
    SubID1 INT,
    SubName1 VARCHAR(50),
    SubCodec1 VARCHAR(10),
    SubLang1 VARCHAR(10),
    SubDesc1 TEXT,
    SubOriginalCodec1 VARCHAR(10),
    SubID2 INT,
    SubName2 VARCHAR(50),
    SubCodec2 VARCHAR(10),
    SubLang2 VARCHAR(10),
    SubDesc2 TEXT,
    SubOriginalCodec2 VARCHAR(10)
    );"

                            SQLCommand.CommandText = cmd

                            SQLCommand.ExecuteNonQuery()
                        End If
                        SQLConnexion.Close()
                            ExtractLink = True
                        Catch ex As Exception
                            MsgBox("L'erreur suivante a été rencontrée : " & vbCrLf & ex.Message, vbApplicationModal + vbCritical + vbOKOnly, "Erreur")
                        End Try
                        Exit For
                    End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical + vbApplicationModal + vbOKOnly, "Erreur")
            End Try
        Next

        Return ExtractLink
    End Function

    Function CreationDB(DBConnect)
        Try
            Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect)
            SQLConnexion.Open()
            SQLCommand = SQLConnexion.CreateCommand()
            Dim cmd As String = "
                            CREATE TABLE InfoIPTV (
                                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                HTTPVer VARCHAR(10) NOT NULL, 
                                AdresseHTTP VARCHAR(50) NOT NULL, 
                                HTTPPort VARCHAR(5) NOT NULL,
                                Pseudo VARCHAAR(50) NOT NULL, 
                                Pass VARCHAR(50) NOT NULL);"
            SQLCommand.CommandText = cmd
            SQLCommand.ExecuteNonQuery()
            SQLConnexion.Close()
        Catch ex As Exception
            MsgBox("L'erreur suivante a été rencontrée:" & ex.Message)
        End Try

        CreationDB = True
        Return CreationDB
    End Function

    Private Sub VlcControl1_VlcLibDirectoryNeeded(sender As Object, e As VlcLibDirectoryNeededEventArgs) Handles VlcControl1.VlcLibDirectoryNeeded
        e.VlcLibDirectory = If(IntPtr.Size = 4,
            New DirectoryInfo(Application.StartupPath & "\libvlc\win-x86\"),
            New DirectoryInfo(Application.StartupPath & "\libvlc\win-x64\"))
    End Sub

    Public Function ScanCanal(ByVal ScanType As Integer, Optional FichierM3U As String = Nothing, Optional AdresseHTTP As String = Nothing) As Boolean
        'Recupération des infos dans la base de données
        NumericUpDown1.ReadOnly = True
        Try
            Dim ID As Integer = 0, HTTP As String = Nothing, AdresseA As String = Nothing, Port As String = Nothing, Pseudo As String = Nothing, Pass As String = Nothing, FullAddress As String = Nothing
            'Charger le fichier dans une List String
            Dim Lignes As String() = File.ReadAllLines(FichierM3U)
            Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect)
            SQLConnexion.Open()
            SQLCommand = SQLConnexion.CreateCommand()
            Dim cmd As String = "SELECT * FROM InfoIPTV WHERE AdresseHTTP='" & AdresseHTTP & "';"
            SQLCommand.CommandText = cmd
            Dim Result As SqliteDataReader = SQLCommand.ExecuteReader()
            Do While Result.Read
                ID = Result.GetString(0)
                HTTP = Result.GetString(1)
                AdresseA = Result.GetString(2)
                Port = Result.GetString(3)
                Pseudo = Result.GetString(4)
                Pass = Result.GetString(5)
            Loop
            Result.Close()
            SQLConnexion.Close()
            FullAddress = HTTP & "://" & AdresseA & ":" & Port & "/" & Pseudo & "/" & Pass & "/"
            Dim Arg As New List(Of String) From {
                CStr(ScanType),
                FichierM3U,
                AdresseHTTP,
                FullAddress
            }
            If BGW.IsBusy <> True Then
                StatutBar_InfoBGW.BackColor = Color.Orange
                StatutBar_InfoBGW.ToolTipText = "Scan en cours"
                BGW.RunWorkerAsync(Arg)
                Btn_StopScan.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("L'erreur suivante a été rencontrée:" & ex.Message)
        End Try
        Return ScanCanal

    End Function


    Private Sub CheckBox_ShowLogs_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ShowLogs.CheckedChanged
        If CheckBox_ShowLogs.Checked Then
            Me.Width = 2100 / 15 * 10
        Else
            Me.Width = 1500 / 15 * 10
        End If
    End Sub

    Private Sub BGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGW.DoWork
        'Scan Type 
        Try
            Dim BGWArg As List(Of String) = CType(e.Argument, List(Of String))
            Dim BGWScantype As Integer = CInt(BGWArg(0)), BGWFichierM3U As String = BGWArg(1), BGWAdresseHTTP As String = BGWArg(2), BGWFullAddress As String = BGWArg(3)
            Dim ResultScan As Boolean

            Select Case BGWScantype
            'Full Scan
                Case 1
                    ' On va scanner 1 par 1 tous les canaux 
                    Try
                        'comme on ne sait pas combien il y a de canaux disponible, on doit faire une boucle qui va de 1 en 1 
                        Dim i As Integer = CInt(NumericUpDown1.Value)
                        While e.Cancel = False

                            If BGW.CancellationPending = True Then
                                e.Cancel = True
                                Exit While
                            End If
                            'On peut maintenant utiliser la fonction qui scannera les chaines 
                            ResultScan = ScannerFull(i, BGWScantype, BGWFichierM3U, BGWFullAddress, BGWAdresseHTTP)
                            i = CInt(NumericUpDown1.Value) + 1
                            ModifNumericUpDown(i)

                        End While

                    Catch ex As Exception
                        MsgBox(ex.Message, vbApplicationModal)
                    End Try
            'Liste Scan
                Case 2
                    'On scanne la liste M3U en utilisant la fonction approprié 
                    Try

                        'Il va falloir lire le fichier M3U ligne par ligne et récuperer le numéro de canal
                        Dim Strm As StreamReader = New StreamReader(BGWFichierM3U), ListeM3U As New List(Of String), i As Integer
                            While Strm.EndOfStream <> True
                                ListeM3U.Add(Strm.ReadLine)
                            End While
                            ' On a notre List(of string) on peut maintenant scanner les lignes pour trouver le http 
                            Dim iii As Integer = 0, ii As Integer = 0, Ligne As String = Nothing
                        For ii = 0 To ListeM3U.Count - 1
                            If e.Cancel = False Then

                                If BGW.CancellationPending = True Then
                                    e.Cancel = True
                                    Exit For
                                End If
                            Else
                                Exit For
                            End If
                            If ListeM3U.Item(ii).Contains("#EXTINF") = True Then
                                    iii = ii + 1
                                    If ListeM3U.Item(iii).Contains(BGWFullAddress) Then
                                        Ligne = ListeM3U.Item(iii)
                                        i = CInt(Replace(Ligne, BGWFullAddress, ""))
                                    ModifNumericUpDown(i)
                                    ResultScan = ScannerFull(i, BGWScantype, BGWFichierM3U, BGWFullAddress, BGWAdresseHTTP)
                                    End If
                                ii = ii + 1
                            End If
                        Next


                    Catch ex As Exception
                        MsgBox(ex.Message, vbApplicationModal)
                    End Try
            'Active Scan
                Case 3
                    'On scanne seulement les lignes de la base de données. On va lire ligne par ligne
                    Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect)
                    SQLConnexion.Open()
                    SQLCommand = SQLConnexion.CreateCommand()
                    Dim cmd As String = "SELECT * FROM '" & Adresse & "';"
                    SQLCommand.CommandText = cmd
                    Dim Result As SqliteDataReader = SQLCommand.ExecuteReader()
                    'Si la table ne contient aucune ligne on quitte la sub
                    If Result.HasRows = False Then Exit Sub
                    'sinon on continue 
                    'Mainenant on va lire un par un les fichiers 
                    Dim ResNoCanal As Integer = 0
                    While Result.Read
                        'Pour qu'on puisse arreter quand on veut
                        If e.Cancel = False Then

                            If BGW.CancellationPending = True Then
                                e.Cancel = True
                                Exit While
                            End If
                        Else
                            Exit While
                        End If
                        ResNoCanal = Result.GetInt32(0)
                            ModifNumericUpDown(ResNoCanal)
                            ResultScan = ScannerFull(ResNoCanal, BGWScantype, BGWFichierM3U, BGWFullAddress, BGWAdresseHTTP)
                        End While
                    Result.Close()
                    SQLConnexion.Close()

            'Inactive Scan
                Case 4
                    'On scanne seulement les lignes manquantes de la base de données. Rien de plus simple, on commence de 1 et on teste si le NoCanal existe.
                    'Si oui, on passe au suivant, si non , on fait la recherche. 
                    Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect)
                    SQLConnexion.Open()
                    SQLCommand = SQLConnexion.CreateCommand()
                    Dim cmd As String = "SELECT * FROM '" & Adresse & "';"
                    SQLCommand.CommandText = cmd
                    Dim Result As SqliteDataReader = SQLCommand.ExecuteReader()
                    'Si la table ne contient aucune ligne on quitte la sub
                    If Result.HasRows = False Then Exit Sub
                    Result.Close()
                    SQLConnexion.Close()
                    'sinon on continue 
                    'On va lire un par un le NoCanal 
                    'On va d'abord regarder par ou on commence grace au NumericUpDown 
                    Dim i As Integer = NumericUpDown1.Value
                    'On va chercher dans la base de données si i existe , si oui on laisse tomber, si non, on continue de scanner 
                    'Tant que Cancel n'est pas vrai on peut continuer de scanner 
                    While e.Cancel = False
                        'Mais si la demande d'arreter de scanner a été faite, on l'execute
                        If BGW.CancellationPending = True Then
                            e.Cancel = True
                            SQLConnexion.Close()
                            Exit While
                        End If
                        'on peut commencer le scan 
                        'On vérifie que i n'est pas la BDD
                        SQLConnexion.Open()
                        SQLCommand = SQLConnexion.CreateCommand()
                        cmd = "SELECT * FROM '" & Adresse & "' WHERE NoCanal=" & i & ";"
                        SQLCommand.CommandText = cmd
                        Result = SQLCommand.ExecuteReader
                        'Si le resultat ne contient pas la ligne 

                        If Result.HasRows = False Then
                                ResultScan = ScannerFull(i, BGWScantype, BGWFichierM3U, BGWFullAddress, BGWAdresseHTTP)
                            End If

                        i = i + 1
                        ModifNumericUpDown(i)
                        Result.Close()
                        SQLConnexion.Close()
                    End While

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGW.RunWorkerCompleted
        If Not (e.Error Is Nothing) Then
            StatutBar_InfoBGW.BackColor = Color.Red
            StatutBar_InfoBGW.ToolTipText = "Une erreur est survenue ! Détail : " + e.Error.Message
        ElseIf e.Cancelled Then
            StatutBar_InfoBGW.BackColor = Color.Purple
            StatutBar_InfoBGW.ToolTipText = "Opération annulée !"
        Else
            StatutBar_InfoBGW.BackColor = Color.Green
            StatutBar_InfoBGW.ToolTipText = "Opération terminée !"
            TabControl1.SelectedIndex = 1 'affiche la page Base de données
        End If
        Btn_StopScan.Enabled = False
        NumericUpDown1.ReadOnly = False
    End Sub

    Private Sub BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BGW.ProgressChanged

    End Sub

    Public Function ScannerFull(ByVal i As Integer, ByVal ScanType As Integer, ByVal FichierM3U As String, ByVal FullAddress As String, ByVal AdresseHTTP As String) As Boolean
        'i = i + CInt(NumericUpDown1.Value)
        Dim AllFullAddress As String = FullAddress & i
        NoCanal = i
        VlcControl1.Play(New Uri(FullAddress & i))
        Threading.Thread.Sleep(250)
        StatutBar_NoCanal.Text = CStr(i)
        Application.DoEvents()
        If VlcControl1.VlcMediaPlayer.CouldPlay = True Then
            Threading.Thread.Sleep(2000)
            If VlcControl1.IsPlaying = True Then
                UpdateList("Adresse : " & FullAddress & i) ' Adresse du lien 

                'Info Video 
                Dim MediaInfos = VlcControl1.GetCurrentMedia().Tracks

                For Each MediaInfo In MediaInfos
                    If MediaInfo.Type = MediaTrackTypes.Video Then
                        VideoCodec = FourCCConverter.FromFourCC(MediaInfo.CodecFourcc) 'Codec Video
                        VideoTrack = MediaInfo.TrackInfo 'Liste Info Piste
                        VideoV = VideoTrack.Width  'Largeur
                        VideoH = VideoTrack.Height 'Hauteur
                        VideoBitRate = MediaInfo.Bitrate 'Bitrate
                        VideoDesc = MediaInfo.Description ' Description
                        VideoID = MediaInfo.Id ' ID Video
                        VideoLang = MediaInfo.Language 'Video Langage
                        VideoLevel = MediaInfo.Level 'Video Level
                        VideoOriginalCodec = FourCCConverter.FromFourCC(MediaInfo.OriginalFourcc) 'Codec Original
                        VideoProfile = MediaInfo.Profile
                    End If
                Next
                ' ID et Nom de la piste video si elle existe 
                If VlcControl1.Video.Tracks.Count > 1 Then
                    VideoTrackID = VlcControl1.Video.Tracks.Current.ID
                    VideoTrackName = VlcControl1.Video.Tracks.Current.Name
                    'VlcControl1.Video.Teletext = 100
                End If
                ' FPS 
                VideoFPS = VlcControl1.VlcMediaPlayer.FramesPerSecond

                UpdateList("[VIDEO]")
                UpdateList("Codec : " & VideoCodec)
                UpdateList("Definition : " & CStr(VideoH) & "P | Resolution : " & CStr(VideoV) & "x" & CStr(VideoH))
                UpdateList("BitRate : " & CStr(VideoBitRate) & " | Description : " & VideoDesc)
                UpdateList("ID : " & CStr(VideoID) & " | Langue : " & VideoLang & " | Level : " & CStr(VideoLevel))
                UpdateList("Original Codec : " & VideoOriginalCodec & "| Profile : " & CStr(VideoProfile))
                UpdateList("ID Video : " & CStr(VideoTrackID) & " | Nom Video : " & VideoTrackName)
                UpdateList("FPS : " & CStr(VideoFPS))
                UpdateList("-------------------------------------------------------------------")

                'Info Audio

                'Audio 1
                If VlcControl1.Audio.Tracks.Count >= 2 Then
                    For Each MediaInfo In MediaInfos
                        If MediaInfo.Type = MediaTrackTypes.Audio Then
                            AudioCodec = FourCCConverter.FromFourCC(MediaInfo.CodecFourcc)
                            AudioTrack = MediaInfo.TrackInfo
                            AudioChannel = AudioTrack.Channels
                            AudioRate = AudioTrack.Rate
                            AudioBitRate = MediaInfo.Bitrate
                            AudioDesc = MediaInfo.Description
                            AudioID = MediaInfo.Id
                            AudioLang = MediaInfo.Language
                            AudioLevel = MediaInfo.Level
                            AudioOriginalCodec = FourCCConverter.FromFourCC(MediaInfo.OriginalFourcc)
                            AudioProfile = MediaInfo.Profile
                        End If
                    Next

                    AudioTrackID = VlcControl1.Audio.Tracks.Current.ID
                    AudioTrackName = VlcControl1.Audio.Tracks.Current.Name

                    UpdateList("[AUDIO 1]")
                    UpdateList("Codec : " & AudioCodec)
                    UpdateList("Canaux : " & CStr(AudioChannel) & " | Rate : " & CStr(AudioRate))
                    UpdateList("BitRate : " & CStr(AudioBitRate) & " | Description : " & AudioDesc)
                    UpdateList("ID : " & CStr(AudioID) & " | Langue : " & AudioLang & " | Level : " & CStr(AudioLevel))
                    UpdateList("Original Codec : " & AudioOriginalCodec & "| Profile : " & CStr(AudioProfile))
                    UpdateList("ID Audio : " & CStr(AudioTrackID) & " | Nom Audio : " & AudioTrackName)
                    UpdateList("-------------------------------------------------------------------")

                End If

                'Audio 2
                If VlcControl1.Audio.Tracks.Count >= 3 Then
                    Dim AudioTracks As IEnumerable(Of TrackDescription) = VlcControl1.Audio.Tracks.All
                    VlcControl1.Audio.Tracks.Current = AudioTracks(2)
                    MediaInfos = VlcControl1.GetCurrentMedia().Tracks
                    For Each MediaInfo In MediaInfos
                        If MediaInfo.Type = MediaTrackTypes.Audio Then
                            AudioCodec2 = FourCCConverter.FromFourCC(MediaInfo.CodecFourcc)
                            AudioTrack2 = MediaInfo.TrackInfo
                            AudioChannel2 = AudioTrack2.Channels
                            AudioRate2 = AudioTrack2.Rate
                            AudioBitRate2 = MediaInfo.Bitrate
                            AudioDesc2 = MediaInfo.Description
                            AudioID2 = MediaInfo.Id
                            AudioLang2 = MediaInfo.Language
                            AudioLevel2 = MediaInfo.Level
                            AudioOriginalCodec2 = FourCCConverter.FromFourCC(MediaInfo.OriginalFourcc)
                            AudioProfile2 = MediaInfo.Profile
                        End If
                    Next
                    AudioTrackID2 = VlcControl1.Audio.Tracks.Current.ID
                    AudioTrackName2 = VlcControl1.Audio.Tracks.Current.Name

                    UpdateList("[AUDIO 2]")
                    UpdateList("Codec : " & AudioCodec2)
                    UpdateList("Canaux : " & CStr(AudioChannel2) & " | Rate : " & CStr(AudioRate2))
                    UpdateList("BitRate : " & CStr(AudioBitRate2) & " | Description : " & AudioDesc2)
                    UpdateList("ID : " & CStr(AudioID2) & " | Langue : " & AudioLang2 & " | Level : " & CStr(AudioLevel2))
                    UpdateList("Original Codec : " & AudioOriginalCodec2 & "| Profile : " & CStr(AudioProfile2))
                    UpdateList("ID Audio : " & CStr(AudioTrackID2) & " | Nom Audio : " & AudioTrackName2)
                    UpdateList("-------------------------------------------------------------------")

                End If

                'Info Sous-Titre
                If VlcControl1.SubTitles.Count >= 2 Then
                    Dim SubtitleTracks As IEnumerable(Of TrackDescription) = VlcControl1.SubTitles.All
                    VlcControl1.SubTitles.Current = SubtitleTracks(1)
                    For Each MediaInfo In MediaInfos
                        If MediaInfo.Type = MediaTrackTypes.Text Then
                            SubtitleCodec = FourCCConverter.FromFourCC(MediaInfo.CodecFourcc)
                            SubtitleTrack = MediaInfo.TrackInfo
                            SubtitleTrackEnc = SubtitleTrack.Encoding
                            SubtitleBitrate = MediaInfo.Bitrate
                            SubtitleDesc = MediaInfo.Description
                            SubtitleID = MediaInfo.Id
                            SubtitleLang = MediaInfo.Language
                            SubtitleLevel = MediaInfo.Level
                            SubtitleOriginalCodec = FourCCConverter.FromFourCC(MediaInfo.OriginalFourcc)
                            SubtitleProfile = MediaInfo.Profile
                        End If
                    Next
                    SubtitleTrackID = VlcControl1.SubTitles.Current.ID
                    SubtitleTrackName = VlcControl1.SubTitles.Current.Name

                    UpdateList("[SUBTITLE 1]")
                    UpdateList("Codec : " & SubtitleCodec)
                    UpdateList("Encodage : " & SubtitleTrackEnc)
                    UpdateList("BitRate : " & CStr(SubtitleBitrate) & " | Description : " & SubtitleDesc)
                    UpdateList("ID : " & CStr(SubtitleID) & " | Langue : " & SubtitleLang & " | Level : " & CStr(SubtitleLevel))
                    UpdateList("Original Codec : " & SubtitleOriginalCodec & "| Profile : " & CStr(SubtitleProfile))
                    UpdateList("ID Subtitle : " & CStr(SubtitleTrackID) & " | Nom Subtitle : " & SubtitleTrackName)
                    UpdateList("-------------------------------------------------------------------")

                End If
                If VlcControl1.SubTitles.Count >= 3 Then
                    Dim SubtitleTracks As IEnumerable(Of TrackDescription) = VlcControl1.SubTitles.All
                    VlcControl1.SubTitles.Current = SubtitleTracks(2)
                    MediaInfos = VlcControl1.GetCurrentMedia().Tracks
                    For Each MediaInfo In MediaInfos
                        If MediaInfo.Type = MediaTrackTypes.Text Then
                            SubtitleCodec2 = FourCCConverter.FromFourCC(MediaInfo.CodecFourcc)
                            SubtitleTrack2 = MediaInfo.TrackInfo
                            SubtitleTrackEnc2 = SubtitleTrack2.Encoding
                            SubtitleBitrate2 = MediaInfo.Bitrate
                            SubtitleDesc2 = MediaInfo.Description
                            SubtitleID2 = MediaInfo.Id
                            SubtitleLang2 = MediaInfo.Language
                            SubtitleLevel2 = MediaInfo.Level
                            SubtitleOriginalCodec2 = FourCCConverter.FromFourCC(MediaInfo.OriginalFourcc)
                            SubtitleProfile2 = MediaInfo.Profile
                        End If
                    Next
                    SubtitleTrackID2 = VlcControl1.SubTitles.Current.ID
                    SubtitleTrackName2 = VlcControl1.SubTitles.Current.Name

                    UpdateList("[SUBTITLE 2]")
                    UpdateList("Codec : " & SubtitleCodec2)
                    UpdateList("Encodage : " & SubtitleTrackEnc2)
                    UpdateList("BitRate : " & CStr(SubtitleBitrate2) & " | Description : " & SubtitleDesc2)
                    UpdateList("ID : " & CStr(SubtitleID2) & " | Langue : " & SubtitleLang2 & " | Level : " & CStr(SubtitleLevel2))
                    UpdateList("Original Codec : " & SubtitleOriginalCodec2 & "| Profile : " & CStr(SubtitleProfile2))
                    UpdateList("ID Subtitle : " & CStr(SubtitleTrackID2) & " | Nom Subtitle : " & SubtitleTrackName2)
                    UpdateList("-------------------------------------------------------------------")
                End If


                ' Maintenant qu'on a toutes les infos sur le stream en cours, on va chercher dans le fichier principal si il y a une correspondance.
                'Pour se faire, on va chercher la ligne http du lien et si on trouve, on va lire la ligne au dessus pour récuperer des info comme le nom de chaine. 
                Dim ResultatLigne As String = Nothing, ii As Integer, iii As Integer
                Dim Lignes As String() = File.ReadAllLines(FichierM3U)


                For ii = 0 To Lignes.Count - 1
                    If Lignes(ii).Contains(AllFullAddress) Then
                        iii = ii - 1
                        'On vérifie si Lignes(iii) contient bien EXTINF, sinon on indique une erreur
                        If Lignes(iii).Contains("EXTINF") Then
                            ResultatLigne = Lignes(iii)
                            'ResultatLigne donne la ligne au dessus qui contient toutes les infos, on va vérifier ce qu'on trouve. 
                            NomChaine = Mid(ResultatLigne, InStr(ResultatLigne, ",") + 1) 'Ca devrait donner le nom qui se trouve après la virgule 
                            'On va chercher ce qu'on trouve comme info, si elle existe
                            If ResultatLigne.Contains("tvg-chno") Then
                                tvg_chno = Mid(ResultatLigne, InStr(ResultatLigne, "tvg-chno") + 10)
                                tvg_chno = Mid(tvg_chno, 1, InStr(tvg_chno, Chr(34)) - 1)
                            End If
                            If ResultatLigne.Contains("tvg-name") Then
                                tvg_name = Mid(ResultatLigne, InStr(ResultatLigne, "tvg-name") + 10)
                                tvg_name = Mid(tvg_name, 1, InStr(tvg_name, Chr(34)) - 1)
                            End If
                            If ResultatLigne.Contains("tvg-id") Then
                                tvg_id = Mid(ResultatLigne, InStr(ResultatLigne, "tvg-id") + 8)
                                tvg_id = Mid(tvg_id, 1, InStr(tvg_id, Chr(34)) - 1)
                            End If
                            If ResultatLigne.Contains("tvg-shift") Then
                                tvg_shift = Mid(ResultatLigne, InStr(ResultatLigne, "tvg-shift") + 11)
                                tvg_shift = Mid(tvg_shift, 1, InStr(tvg_shift, Chr(34)) - 1)
                            End If
                            If ResultatLigne.Contains("group-title") Then
                                group_title = Mid(ResultatLigne, InStr(ResultatLigne, "group-title") + 13)
                                group_title = Mid(group_title, 1, InStr(group_title, Chr(34)) - 1)
                            End If
                            If ResultatLigne.Contains("tvg-logo") Then
                                tvg_logo = Mid(ResultatLigne, InStr(ResultatLigne, "tvg-logo") + 10)
                                tvg_logo = Mid(tvg_logo, 1, InStr(tvg_logo, Chr(34)) - 1)
                            End If
                            Exit For
                        Else
                            MsgBox("Fichier incorrect", vbApplicationModal)
                        End If
                    End If
                Next
                If NomChaine <> Nothing Then UpdateList(NomChaine)
                If tvg_chno <> Nothing Then UpdateList(tvg_chno)
                If tvg_name <> Nothing Then UpdateList(tvg_name)
                If tvg_id <> Nothing Then UpdateList(tvg_id)
                If tvg_logo <> Nothing Then UpdateList(tvg_logo)
                If tvg_shift <> Nothing Then UpdateList(tvg_shift)
                If group_title <> Nothing Then UpdateList(group_title)

                'Maintenant qu'on a toutes les infos dans des variables on peut rechercher une correspondance dans la base de données
                'On recherche dans la table AdresseHTTP si une des variable existe 
                Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect)
                SQLConnexion.Open()
                SQLCommand = SQLConnexion.CreateCommand()
                'recherche dans la base de données AdresseHTTP la ligne ou ID est egal a l'ID qui represente le canal IPTV

                SQLCommand.CommandText = "SELECT * FROM '" & Adresse & "' WHERE NoCanal = " & i & ";"
                Dim ResultReq As SqliteDataReader
                ResultReq = SQLCommand.ExecuteReader()
                Dim RNoCanal As Integer = 0, RNomChaine As String = Nothing, RNomEPG As String = Nothing, RNoChaine As String = Nothing, RGroupChaine As String = Nothing, RLinkLogo As String = Nothing, RTimeshift As String = Nothing,
                    RDescription As String = Nothing, RCatChaine As String = Nothing, RPays As String = Nothing, RVideoID As Integer = 0, RVideoName As String = Nothing, RVideoCodec As String = Nothing, RVideoV As Integer = 0,
                    RVideoH As Integer, RVideoFPS As Single, RVideoOriginalCodec As String = Nothing, RAudioID1 As Integer, RAudioName1 As String = Nothing, RAudioCodec1 As String = Nothing, RAudioLang1 As String = Nothing,
                    RAudioChannel1 As Integer = 0, RAudioRate1 As Integer = 0, RAudioOriginalCodec1 As String = Nothing, RAudioID2 As Integer = 0, RAudioName2 As String = Nothing, RAudioCodec2 As String = Nothing, RAudioLang2 As String = Nothing,
                    RAudioChannel2 As Integer = 0, RAudioRate2 As Integer = 0, RAudioOriginalCodec2 As String = Nothing, RSubID1 As Integer = 0, RSubName1 As String = Nothing, RSubCodec1 As String = Nothing, RSubLang1 As String = Nothing,
                    RSubDesc1 As String = Nothing, RSubOriginalCodec1 As String = Nothing, RSubID2 As Integer = 0, RSubName2 As String = Nothing, RSubCodec2 As String = Nothing, RSubLang2 As String = Nothing,
                    RSubDesc2 As String = Nothing, RSubOriginalCodec2 As String = Nothing
                Try
                    Do While ResultReq.Read
                        RNoCanal = ResultReq(0)
                        RNomChaine = ResultReq(1)
                        RNomEPG = ResultReq(2)
                        RNoChaine = ResultReq(3)
                        RGroupChaine = ResultReq(4)
                        RLinkLogo = ResultReq(5)
                        RTimeshift = ResultReq(6)
                        RDescription = ResultReq(7)
                        RCatChaine = ResultReq(8)
                        RPays = ResultReq(9)
                        RVideoID = ResultReq(10)
                        RVideoName = ResultReq(11)
                        RVideoCodec = ResultReq(12)
                        RVideoV = ResultReq(13)
                        RVideoH = ResultReq(14)
                        RVideoFPS = ResultReq(15)
                        RVideoOriginalCodec = ResultReq(16)
                        RAudioID1 = ResultReq(17)
                        RAudioName1 = ResultReq(18)
                        RAudioCodec1 = ResultReq(19)
                        RAudioLang1 = ResultReq(20)
                        RAudioChannel1 = ResultReq(21)
                        RAudioRate1 = ResultReq(22)
                        RAudioOriginalCodec1 = ResultReq(23)
                        RAudioID2 = ResultReq(24)
                        RAudioName2 = ResultReq(25)
                        RAudioCodec2 = ResultReq(26)
                        RAudioLang2 = ResultReq(27)
                        RAudioChannel2 = ResultReq(28)
                        RAudioRate2 = ResultReq(29)
                        RAudioOriginalCodec2 = ResultReq(30)
                        RSubID1 = ResultReq(31)
                        RSubName1 = ResultReq(32)
                        RSubCodec1 = ResultReq(33)
                        RSubLang1 = ResultReq(34)
                        RSubDesc1 = ResultReq(35)
                        RSubOriginalCodec1 = ResultReq(36)
                        RSubID2 = ResultReq(37)
                        RSubName2 = ResultReq(38)
                        RSubCodec2 = ResultReq(39)
                        RSubLang2 = ResultReq(40)
                        RSubDesc2 = ResultReq(41)
                        RSubOriginalCodec2 = ResultReq(4)
                    Loop

                Catch ex As Exception
                    Dim Erreur As String = ex.Message + vbCrLf + ex.HelpLink & vbCrLf & CStr(ex.HResult) & vbCrLf & ex.Source & vbCrLf & ex.StackTrace
                    MsgBox(Erreur, vbApplicationModal)
                End Try
                ResultReq.Close()
                SQLConnexion.Close()

                UpdateInfo(NomChaine, VideoTrackID, VideoTrackName, VideoCodec, VideoV, VideoH, VideoFPS, VideoOriginalCodec, AudioTrackID, AudioTrackName, AudioCodec, AudioLang, AudioChannel, AudioRate, AudioOriginalCodec,
AudioTrackID2, AudioTrackName2, AudioCodec2, AudioLang2, AudioChannel2, AudioRate2, AudioOriginalCodec2, SubtitleTrackID, SubtitleTrackName, SubtitleCodec, SubtitleLang, SubtitleDesc, SubtitleOriginalCodec,
SubtitleTrackID2, SubtitleTrackName2, SubtitleCodec2, SubtitleLang2, SubtitleDesc2, SubtitleOriginalCodec2)

                If RNoCanal = 0 Then
                    'L'entrée n'existe pas, il va falloir la créer. On va poser des questions à l'utilisateur et il va renseigner les choix (avec l'aide du fichier M3U comme aide) 
                    'il n'y a pas beaucoup à demander : 
                    ' - Le Nom de la Chaine : On va afficher le nom présent dans le fichier M3U si celui si existe (Si il n'existe pas, Garder sera grisé). Un espace pour changer le nom (si vide, erreur) deux boutons : Garder et Modifier
                    ' - Le Nom EPG : Idem  (Dans une autre version, je pourrais voir si je peux faire une recherche sur un fichier des Nom EPG possible.
                    ' - Le Numéro de la Chaine : Idem (Dans une autre version, je pourrais voir si je peux faire une recherche du numéro de Chaine par rapport a un choix de Fournisseur)
                    ' - le Groupe de la chaine : Idem 
                    ' - le lien du logo de la Chaine : Idem, avec affichage du logo et demande si ca convient, sinon, un nouveau bouton Rechercher qui permet de chercher dans le serveur si il y a des correspondances , puis les afficher une par une
                    ' - Le Timeshift : Idem 
                    ' - La Description : Elle ne sera que dans la base de données (Pourrait etre utile pour fichier XML) la description peut être vide. 
                    ' - La Catégorie de la Chaine : Elle ne sera que dans la base de données (Pourrait être utile pour fichier XML) La Catégorie peut être vide. 
                    ' - Le Pays de la Chaine : Il ne sera présent que dans la base de données (Pourrais être utile pour fichier XML) Le Pays Peut être vide. 
                    ' Toutes les autres infos seront automatiquement ajoutée .

                    'Info a envoyer a la boite de dialogue 
                    ' 1 = Nom de Chaine 
                    While Microsoft.VisualBasic.Left(NomChaine, 1) = " "
                        NomChaine = Mid(NomChaine, 2)
                    End While
                    'Ouverture de la fenetre de dialogue avec les infos trouvées dans le fichier M3U
                    UpdateDialog(1, NomChaine)
                    UpdateDialog(2, tvg_id)
                    UpdateDialog(3, tvg_chno)
                    UpdateDialog(4, group_title)
                    UpdateDialog(5, tvg_shift)
                    'Lien du logo de la chaine 
                    UpdateDialog(6, tvg_logo)

                    Dialog_AskInfo.ShowDialog()


                Else
                    'L'entrée existe , on va afficher un récap avec des textbox grisé. Le bouton Modifier qui permet de modifier l'entrée, un bouton Passer qui permettra de continuer le scan
                    UpdateDialog(1, RNomChaine)
                    UpdateDialog(2, RNomEPG)
                    UpdateDialog(3, RNoChaine)
                    UpdateDialog(4, RGroupChaine)
                    UpdateDialog(5, RTimeshift)
                    'Lien du logo de la chaine 
                    UpdateDialog(6, RLinkLogo)
                    UpdateDialog(7, RPays)
                    UpdateDialog(8, RDescription)
                    UpdateDialog(9, RCatChaine)


                    Dialog_AskInfo.ShowDialog()

                End If




                UpdateList("********************************************************")
                Threading.Thread.Sleep(10000)
            Else
                UpdateList("********************************************************")
                UpdateList("Aucune chaine trouvé sur " & CStr(NoCanal))
                UpdateList("********************************************************")
                Threading.Thread.Sleep(1000)
            End If
        End If


        Return ScannerFull
    End Function

    Private Sub VlcControl1_VideoOutChanged(sender As Object, e As VlcMediaPlayerVideoOutChangedEventArgs) Handles VlcControl1.VideoOutChanged


    End Sub

    Private Sub VlcControl1_EncounteredError(sender As Object, e As VlcMediaPlayerEncounteredErrorEventArgs) Handles VlcControl1.EncounteredError
        Threading.Thread.Sleep(1000)

    End Sub

    Private Sub ListBox1_TextChanged(sender As Object, e As EventArgs) Handles ListBox1.TextChanged

    End Sub

    Private Sub VlcControl1_Buffering(sender As Object, e As VlcMediaPlayerBufferingEventArgs) Handles VlcControl1.Buffering
        Dim Buffer As String = e.NewCache.ToString
        UpdateProgressBar(Buffer)

    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        ListBox1.Items.Clear()
    End Sub
End Class
