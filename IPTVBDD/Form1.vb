Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Data.Sqlite
Imports Vlc.DotNet.Core
Imports Vlc.DotNet.Forms
Imports Vlc.DotNet.Core.Interops
Imports Vlc.DotNet.Core.Interops.Signatures
Imports System.Web.HttpUtility

Public Class Form1
    Public Delegate Sub AffichageDelegate()
    Public Sub AffichageDialogAsk()
        If InvokeRequired Then
            Invoke(New AffichageDelegate(AddressOf AffichageDialogAsk))
        Else
            Try
                Dialog_AskInfo.ShowDialog(Me)
            Catch ex As Exception
                MsgBox(ex.Message, vbApplicationModal)
            End Try
        End If
    End Sub

    Public Delegate Sub ModifNumericUpDownDelegate(ByVal i As Integer)
    Public Sub ModifNumericUpDown(ByVal i As Integer)
        If InvokeRequired Then
            Invoke(New ModifNumericUpDownDelegate(AddressOf ModifNumericUpDown), i)
        Else
            Try
                NumericUpDown1.Value = i
            Catch ex As Exception
                MsgBox(ex.Message, vbApplicationModal)
            End Try
        End If
    End Sub

    Public Delegate Sub UpdateListDelegate(ByVal itemName As String)
    Public Sub UpdateList(ByVal itemName As String)
        If InvokeRequired Then
            Invoke(New UpdateListDelegate(AddressOf UpdateList), itemName)
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

    Public Delegate Sub UpdateProgressBarDelegate(ByVal itemName As Single)
    Public Sub UpdateProgressBar(ByVal itemName As String)
        If InvokeRequired Then
            Invoke(New UpdateListDelegate(AddressOf UpdateProgressBar), itemName)
        Else
            StatutBarProgress.Value = CInt(itemName)
            StatutBarProgress.ToolTipText = itemName & " %"
        End If
    End Sub

    Public Delegate Sub UpdateDialogDelegate(Question As Integer, OldAnswer As String)
    Public Sub UpdateDialog(Question As Integer, OldAnswer As String)
        If InvokeRequired Then
            Invoke(New UpdateDialogDelegate(AddressOf UpdateDialog), Question, OldAnswer)
        Else
            Select Case Question
                Case 1
                    NomChaine = HtmlDecode(OldAnswer)
                    Dialog_AskInfo.txt_NomChaine.Text = NomChaine
                Case 2
                    tvg_id = HtmlDecode(OldAnswer)
                    Dialog_AskInfo.txt_tvg_id.Text = tvg_id
                Case 3
                    tvg_chno = OldAnswer
                    Dialog_AskInfo.txt_tvg_chno.Text = tvg_chno
                Case 4
                    group_title = HtmlDecode(OldAnswer)
                    Dialog_AskInfo.txt_group.Text = group_title
                Case 5
                    tvg_shift = OldAnswer
                    Dialog_AskInfo.txt_tvg_shift.Text = tvg_shift
                Case 6
                    tvg_logo = OldAnswer
                    If OldAnswer = Nothing Or OldAnswer = "" Then
                        Dialog_AskInfo.PictureBox_tvg_logo.Image = Nothing
                        Dialog_AskInfo.PictureBox_tvg_logo.BackgroundImage = Nothing
                    Else
                        Dialog_AskInfo.PictureBox_tvg_logo.ImageLocation = tvg_logo
                    End If
                Case 7
                    Pays = HtmlDecode(OldAnswer)
                    Dialog_AskInfo.txt_Pays.Text = Pays
                Case 8
                    Desc = HtmlDecode(OldAnswer)
                    Dialog_AskInfo.txt_Desc.Text = Desc
                Case 9
                    Cat = HtmlDecode(OldAnswer)
                    Dialog_AskInfo.txt_categorie.Text = Cat
                Case Else
                    Exit Select
            End Select
        End If
    End Sub

    Public Delegate Sub UpdateInfoDelegate(ByVal NomChaine, VideoTrackID, VideoTrackName, VideoCodec, VideoV, VideoH, VideoFPS, VideoOriginalCodec, AudioTrackID, AudioTrackName, AudioCodec, AudioLang, AudioChannel, AudioRate, AudioOriginalCodec,
AudioTrackID2, AudioTrackName2, AudioCodec2, AudioLang2, AudioChannel2, AudioRate2, AudioOriginalCodec2, SubtitleTrackID, SubtitleTrackName, SubtitleCodec, SubtitleLang, SubtitleDesc, SubtitleOriginalCodec,
SubtitleTrackID2, SubtitleTrackName2, SubtitleCodec2, SubtitleLang2, SubtitleDesc2, SubtitleOriginalCodec2)
    Public Sub UpdateInfo(ByVal NomChaine, VideoTrackID, VideoTrackName, VideoCodec, VideoV, VideoH, VideoFPS, VideoOriginalCodec, AudioTrackID, AudioTrackName, AudioCodec, AudioLang, AudioChannel, AudioRate, AudioOriginalCodec,
AudioTrackID2, AudioTrackName2, AudioCodec2, AudioLang2, AudioChannel2, AudioRate2, AudioOriginalCodec2, SubtitleTrackID, SubtitleTrackName, SubtitleCodec, SubtitleLang, SubtitleDesc, SubtitleOriginalCodec,
SubtitleTrackID2, SubtitleTrackName2, SubtitleCodec2, SubtitleLang2, SubtitleDesc2, SubtitleOriginalCodec2)
        If InvokeRequired Then
            Invoke(New UpdateInfoDelegate(AddressOf UpdateInfo), NomChaine, VideoTrackID, VideoTrackName, VideoCodec, VideoV, VideoH, VideoFPS, VideoOriginalCodec, AudioTrackID, AudioTrackName, AudioCodec, AudioLang, AudioChannel, AudioRate, AudioOriginalCodec,
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
    Public Delegate Sub UpdateBDDTabDelegate(ByVal UpNoCanal As String, ByVal UpNomChaine As String, ByVal UpNoChaine As String, ByVal UpNomEPG As String, ByVal UpGroupChaine As String, ByVal UpTimeShift As String, ByVal UpPays As String, ByVal UpCatChaine As String, ByVal UpDesc As String, ByVal UpLinkLogo As String)
    Public Sub UpdateBDD(ByVal UpNoCanal As String, ByVal UpNomChaine As String, ByVal UpNoChaine As String, ByVal UpNomEPG As String, ByVal UpGroupChaine As String, ByVal UpTimeShift As String, ByVal UpPays As String, ByVal UpCatChaine As String, ByVal UpDesc As String, ByVal UpLinkLogo As String)
        If InvokeRequired Then
            Invoke(New UpdateBDDTabDelegate(AddressOf UpdateBDD), UpNoCanal, UpNomChaine, UpNoChaine, UpNomEPG, UpGroupChaine, UpTimeShift, UpPays, UpCatChaine, UpDesc, UpLinkLogo)
        Else
            lbl_RNoCanal.Text = UpNoCanal
            lbl_RNomChaine.Text = UpNomChaine
            lbl_RNoChaine.Text = UpNoChaine
            lbl_RNomEPG.Text = UpNomEPG
            lbl_RGroupChannel.Text = UpGroupChaine
            Lbl_RTimeShift.Text = UpTimeShift
            lbl_RPays.Text = UpPays
            lbl_RCategorie.Text = UpCatChaine
            txt_RDescription.Text = UpDesc
            PictureBox_RLinkImg.ImageLocation = UpLinkLogo
            TabBDD.Select()
        End If
    End Sub

    Private Sub VlcControl1_Click(sender As Object, e As EventArgs) Handles VlcControl1.Click

    End Sub

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
        Me.Text = $"IPTV DataBase - {My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor} Build {My.Application.Info.Version.Build}"
        Me.Width = 1500 / 15 * 10
        'verification si la base de donnée existe déjà
        ScanToolStripMenuItem.Enabled = False
        ExportStripMenuItem.Enabled = False
        If File.Exists(DBFile) = False Then CreationDB(DBConnect)

        StatutBar_InfoBGW.BackColor = Color.Black
        StatutBar_InfoBGW.ToolTipText = "Aucun fichier chargé"
        NumericUpDown1.ReadOnly = False

        If File.Exists(FileWebLogo) = False Or File.GetLastWriteTime(FileWebLogo) < Date.Today Then
            Dim Web As New HtmlAgilityPack.HtmlWeb, url As String = "http://informaweb.freeboxos.fr/iptv/logos_tv/"
            Dim PageWeb = Web.Load(url)
            PageWeb.Save(FileWebLogo)
        End If

    End Sub


    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        VlcControl1.Dispose()
        Dialog_AskInfo.Dispose()
        Dialog_WebLinkImg.Dispose()
        ImageView.Dispose()
        PictureBox_RLinkImg.Dispose()
        BGW.Dispose()
        Dispose()
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

    Private Sub StatutBar_NoCanal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VlcControl1_VlcLibDirectoryNeeded(sender As Object, e As VlcLibDirectoryNeededEventArgs) Handles VlcControl1.VlcLibDirectoryNeeded
        e.VlcLibDirectory = If(IntPtr.Size = 4,
            New DirectoryInfo(Application.StartupPath & "\libvlc\win-x86\"),
            New DirectoryInfo(Application.StartupPath & "\libvlc\win-x64\"))
    End Sub

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
                    Dim cmd As String = $"SELECT * FROM '{Adresse}';"
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
                    Dim cmd As String = $"SELECT * FROM '{Adresse}';"
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
                        cmd = $"SELECT * FROM '{Adresse}' WHERE NoCanal={i};"
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
        BGW.Dispose()
    End Sub


    Private Sub VlcControl1_EncounteredError(sender As Object, e As VlcMediaPlayerEncounteredErrorEventArgs) Handles VlcControl1.EncounteredError
        Threading.Thread.Sleep(500)

    End Sub

    Private Sub VlcControl1_Buffering(sender As Object, e As VlcMediaPlayerBufferingEventArgs) Handles VlcControl1.Buffering
        Dim BufferString As String = e.NewCache.ToString, Buffer As Single = e.NewCache
        UpdateProgressBar(BufferString)
        If Buffer < 100 Then
            Application.DoEvents()
            Threading.Thread.Sleep(100)
            BufferVlc = False
        Else
            BufferVlc = True
        End If
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        ListBox1.Items.Clear()
    End Sub

    Private Sub OnlyNoActiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlyNoActiveToolStripMenuItem.Click
        ExportM3U(3)
    End Sub

    Private Sub OnlyActiveStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlyActiveStripMenuItem.Click
        ExportM3U(2)
    End Sub

    Private Sub FullToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullToolStripMenuItem.Click
        ExportM3U(1)
    End Sub

    Public Function ScannerFull(ByVal i As Integer, ByVal ScanType As Integer, ByVal FichierM3U As String, ByVal FullAddress As String, ByVal AdresseHTTP As String) As Boolean
        'i = i + CInt(NumericUpDown1.Value)
        Dim AllFullAddress As String = FullAddress & i
        NoCanal = i
        VlcControl1.Play(New Uri(AllFullAddress))
        StatutBar_NoCanal.Text = CStr(i)
        Application.DoEvents()
        If VlcControl1.VlcMediaPlayer.CouldPlay = True Then
            Threading.Thread.Sleep(1000)
            If VlcControl1.IsPlaying = True Then
                UpdateList($"Adresse : {FullAddress}{i})") ' Adresse du lien 
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
                            AudioCodec1 = FourCCConverter.FromFourCC(MediaInfo.CodecFourcc)
                            AudioTrack1 = MediaInfo.TrackInfo
                            AudioChannel1 = AudioTrack1.Channels
                            AudioRate1 = AudioTrack1.Rate
                            AudioBitRate1 = MediaInfo.Bitrate
                            AudioDesc1 = MediaInfo.Description
                            AudioID1 = MediaInfo.Id
                            AudioLang1 = MediaInfo.Language
                            AudioLevel1 = MediaInfo.Level
                            AudioOriginalCodec1 = FourCCConverter.FromFourCC(MediaInfo.OriginalFourcc)
                            AudioProfile1 = MediaInfo.Profile
                        End If
                    Next
                    AudioTrackID1 = VlcControl1.Audio.Tracks.Current.ID
                    AudioTrackName1 = VlcControl1.Audio.Tracks.Current.Name
                    UpdateList("[AUDIO 1]")
                    UpdateList("Codec : " & AudioCodec1)
                    UpdateList("Canaux : " & CStr(AudioChannel1) & " | Rate : " & CStr(AudioRate1))
                    UpdateList("BitRate : " & CStr(AudioBitRate1) & " | Description : " & AudioDesc1)
                    UpdateList("ID : " & CStr(AudioID1) & " | Langue : " & AudioLang1 & " | Level : " & CStr(AudioLevel1))
                    UpdateList("Original Codec : " & AudioOriginalCodec1 & "| Profile : " & CStr(AudioProfile1))
                    UpdateList("ID Audio : " & CStr(AudioTrackID1) & " | Nom Audio : " & AudioTrackName1)
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
                            SubCodec1 = FourCCConverter.FromFourCC(MediaInfo.CodecFourcc)
                            SubTrack1 = MediaInfo.TrackInfo
                            SubTrackEnc1 = SubTrack1.Encoding
                            SubBitrate1 = MediaInfo.Bitrate
                            SubDesc1 = MediaInfo.Description
                            SubID1 = MediaInfo.Id
                            SubLang1 = MediaInfo.Language
                            SubLevel1 = MediaInfo.Level
                            SubOriginalCodec1 = FourCCConverter.FromFourCC(MediaInfo.OriginalFourcc)
                            SubProfile1 = MediaInfo.Profile
                        End If
                    Next
                    SubTrackID1 = VlcControl1.SubTitles.Current.ID
                    SubTrackName1 = VlcControl1.SubTitles.Current.Name
                    UpdateList("[SUBTITLE 1]")
                    UpdateList("Codec : " & SubCodec1)
                    UpdateList("Encodage : " & SubTrackEnc1)
                    UpdateList("BitRate : " & CStr(SubBitrate1) & " | Description : " & SubDesc1)
                    UpdateList("ID : " & CStr(SubID1) & " | Langue : " & SubLang1 & " | Level : " & CStr(SubLevel1))
                    UpdateList("Original Codec : " & SubOriginalCodec1 & "| Profile : " & CStr(SubProfile1))
                    UpdateList("ID Sub : " & CStr(SubTrackID1) & " | Nom Sub : " & SubTrackName1)
                    UpdateList("-------------------------------------------------------------------")
                End If
                If VlcControl1.SubTitles.Count >= 3 Then
                    Dim SubTracks As IEnumerable(Of TrackDescription) = VlcControl1.SubTitles.All
                    VlcControl1.SubTitles.Current = SubTracks(2)
                    MediaInfos = VlcControl1.GetCurrentMedia().Tracks
                    For Each MediaInfo In MediaInfos
                        If MediaInfo.Type = MediaTrackTypes.Text Then
                            SubCodec2 = FourCCConverter.FromFourCC(MediaInfo.CodecFourcc)
                            SubTrack2 = MediaInfo.TrackInfo
                            SubTrackEnc2 = SubTrack2.Encoding
                            SubBitrate2 = MediaInfo.Bitrate
                            SubDesc2 = MediaInfo.Description
                            SubID2 = MediaInfo.Id
                            SubLang2 = MediaInfo.Language
                            SubLevel2 = MediaInfo.Level
                            SubOriginalCodec2 = FourCCConverter.FromFourCC(MediaInfo.OriginalFourcc)
                            SubProfile2 = MediaInfo.Profile
                        End If
                    Next
                    SubTrackID2 = VlcControl1.SubTitles.Current.ID
                    SubTrackName2 = VlcControl1.SubTitles.Current.Name
                    UpdateList("[SUBTITLE 2]")
                    UpdateList("Codec : " & SubCodec2)
                    UpdateList("Encodage : " & SubTrackEnc2)
                    UpdateList("BitRate : " & CStr(SubBitrate2) & " | Description : " & SubDesc2)
                    UpdateList("ID : " & CStr(SubID2) & " | Langue : " & SubLang2 & " | Level : " & CStr(SubLevel2))
                    UpdateList("Original Codec : " & SubOriginalCodec2 & "| Profile : " & CStr(SubProfile2))
                    UpdateList("ID Sub : " & CStr(SubTrackID2) & " | Nom Sub : " & SubTrackName2)
                    UpdateList("-------------------------------------------------------------------")
                End If
                'Vider toutes les variables avant de les remplir
                NomChaine = Nothing
                tvg_chno = Nothing
                tvg_id = Nothing
                tvg_logo = Nothing
                tvg_shift = Nothing
                group_title = Nothing
                tvg_name = Nothing
                Pays = Nothing
                Cat = Nothing
                Desc = Nothing
                'ouverture de la sub qui va lire le fichier et récupérer les infos
                LectureFichierM3U(AllFullAddress)
                If NomChaine <> Nothing Then UpdateList(NomChaine)
                If tvg_chno <> Nothing Then UpdateList(tvg_chno)
                If tvg_name <> Nothing Then UpdateList(tvg_name)
                If tvg_id <> Nothing Then UpdateList(tvg_id)
                If tvg_logo <> Nothing Then UpdateList(tvg_logo)
                If tvg_shift <> Nothing Then UpdateList(tvg_shift)
                If group_title <> Nothing Then UpdateList(group_title)
                'On recupere bien les données du fichier mais ensuite, on ne sait pas si ca existe déjà dans la base de données. 
                'Il faut donc récuperer les données de la base de données si elles existent
                'Il faut le faire par son numéro . Moi je le faisais par son nom mais si le nom n'est pas correct, il ne va pas le trouver, alors que le numéro, lui il est unique.
                'Mais le but est de retrouver des infos sur une chaine portant le même nom, pour ne pas à avoir tout à retaper....
                'Du coup, on doit faire les deux recherches

                'Ouverture de la sub Lecture des données (recherche par NoCanal et Nomchaine)
                LectureBDD(i, NoCanal, NomChaine)

                'Mise a jour Info 
                UpdateInfo(NomChaine, VideoTrackID, VideoTrackName, VideoCodec, VideoV, VideoH, VideoFPS, VideoOriginalCodec, AudioTrackID1, AudioTrackName1, AudioCodec1, AudioLang1, AudioChannel1, AudioRate1, AudioOriginalCodec1,
AudioTrackID2, AudioTrackName2, AudioCodec2, AudioLang2, AudioChannel2, AudioRate2, AudioOriginalCodec2, SubTrackID1, SubTrackName1, SubCodec1, SubLang1, SubDesc1, SubOriginalCodec1,
SubTrackID2, SubTrackName2, SubCodec2, SubLang2, SubDesc2, SubOriginalCodec2)

                If RNoCanal = 0 Then
                    'Aucune entrée DBB, Creation 
                    'On envoie juste le Nom de Chaine qu'on a trouvé dans le fichier M3U
                    'On enleve les espaces de début et fin de chaine
                    NomChaine = Trim(NomChaine)

                    'Ouverture de la fenetre de dialogue avec les infos trouvées dans le fichier M3U
                    UpdateDialog(1, NomChaine)
                    UpdateDialog(2, tvg_id)
                    UpdateDialog(3, tvg_chno)
                    UpdateDialog(4, group_title)
                    UpdateDialog(5, tvg_shift)
                    'Lien du logo de la chaine 
                    UpdateDialog(6, tvg_logo)
                    'Appel de la sub 
                    AffichageDialogAsk()
                    Dialog_AskInfo.Dispose()

                Else
                    'L'entrée existe , on va afficher un récap avec des textbox grisé. Le bouton Modifier qui permet de modifier l'entrée, un bouton Passer qui permettra de continuer le scan
                    UpdateDialog(1, NomChaine)
                    UpdateDialog(2, tvg_id)
                    UpdateDialog(3, tvg_chno)
                    UpdateDialog(4, group_title)
                    UpdateDialog(5, tvg_shift)
                    'Lien du logo de la chaine 
                    UpdateDialog(6, tvg_logo)
                    UpdateDialog(7, Pays)
                    UpdateDialog(8, Desc)
                    UpdateDialog(9, Cat)
                    'On va afficher dans le tab BDD et le selectionner 
                    UpdateBDD(NoCanal, NomChaine, tvg_chno, tvg_id, group_title, tvg_shift, Pays, Cat, Desc, tvg_logo)
                    AffichageDialogAsk()
                    Dialog_AskInfo.Dispose()
                End If




                UpdateList("********************************************************")
                Threading.Thread.Sleep(5000)
            Else
                UpdateList("********************************************************")
                UpdateList("Aucune chaine trouvé sur " & CStr(NoCanal))
                UpdateList("********************************************************")
                Threading.Thread.Sleep(1000)
            End If
        End If


        Return ScannerFull
    End Function

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        VlcControl1.Dispose()
        Dialog_AskInfo.Dispose()
        Dialog_WebLinkImg.Dispose()
        ImageView.Dispose()
        PictureBox_RLinkImg.Dispose()
        Dispose()
        End
    End Sub

    Private Sub UpdateListeDesLogosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateListeDesLogosToolStripMenuItem.Click
        Dim Web As New HtmlAgilityPack.HtmlWeb, url As String = "http://informaweb.freeboxos.fr/iptv/logos_tv/"
        Dim PageWeb = Web.Load(url), DernierAcces As String = File.GetLastWriteTime(FileWebLogo).ToString
        PageWeb.Save(FileWebLogo)
        MsgBox($"La liste des logos TV a été mise à jour le : {File.GetLastWriteTime(FileWebLogo).ToString}{vbCrLf}Sa dernière mise à jour était : {DernierAcces}{vbCrLf}", vbApplicationModal + vbInformation + vbOKOnly, "Update")
    End Sub
End Class