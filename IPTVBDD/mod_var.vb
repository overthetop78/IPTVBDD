Imports Vlc.DotNet.Core
Imports Vlc.DotNet.Core.Interops
Imports Vlc.DotNet.Core.Interops.Signatures
Imports Microsoft.Data.Sqlite
Imports System.Web.HttpUtility
Module mod_var

    'Enregistrement de variable 
    Public NomChaine As String = Nothing, tvg_id As String = Nothing, tvg_chno As String = Nothing, tvg_shift As String = Nothing, group_channel As String = Nothing, tvg_logo As String = Nothing
    Public Desc As String = Nothing, Pays As String = Nothing, Cat As String = Nothing, NoCanal As Integer
    'Public VideoID As Integer = 0, VideoName As String = Nothing, VideoCodec As String = Nothing, VideoV As Integer = 0, VideoH As Integer = 0, VideoFPS As Single = 0, VideoOriginalCodec As String = Nothing
    'Public AudioID1 As Integer = 0, AudioName1 As String = Nothing, AudioCodec1 As String = Nothing, AudioLang1 As String = Nothing, AudioChannel1 As Integer = 0, AudioRate1 As Integer = 0, AudioOriginalCodec1 As String = Nothing
    'Public AudioID2 As Integer = 0, AudioName2 As String = Nothing, AudioCodec2 As String = Nothing, AudioLang2 As String = Nothing, AudioChannel2 As Integer = 0, AudioRate2 As Integer = 0, AudioOriginalCodec2 As String = Nothing
    'Public SubID1 As Integer = 0, SubName1 As String = Nothing, SubCodec1 As String = Nothing, SubLang1 As String = Nothing, SubDesc1 As String = Nothing, SubOriginalCodec1 As String = Nothing
    'Public SubID2 As Integer = 0, SubName2 As String = Nothing, SubCodec2 As String = Nothing, SubLang2 As String = Nothing, SubDesc2 As String = Nothing, SubOriginalCodec2 As String = Nothing
    'Public VideoTrack As VideoTrack, AudioTrack As AudioTrack, SubTrack As SubtitleTrack


    Public Function RecData() As Boolean
        'Enregistrement et vérification de variable
        NoCanal = Form1.NoCanal
        With Dialog_AskInfo
            tvg_chno = .txt_tvg_chno.Text
            NomChaine = .txt_NomChaine.Text
            tvg_shift = .txt_tvg_shift.Text
            tvg_id = .txt_tvg_id.Text
            group_channel = .txt_group.Text
            tvg_logo = .PictureBox_tvg_logo.ImageLocation
            Pays = .txt_Pays.Text
            Cat = .txt_categorie.Text
            Desc = .txt_Desc.Text
        End With
        If NomChaine = Nothing Or NomChaine = "" Then
            MsgBox("Erreur: Aucun nom de chaine!", vbApplicationModal + vbOKOnly, "Erreur")
            Return False
            Exit Function
        End If
        Dim er As Integer = 0
        If tvg_chno = Nothing Or tvg_chno = "" Then er = 1
        If tvg_id = Nothing Or tvg_id = "" Then er = er + 2
        If tvg_shift = Nothing Or tvg_shift = "" Then er = er + 4
        If tvg_logo = Nothing Or tvg_logo = "" Then er = er + 8
        If group_channel = Nothing Or group_channel = "" Then er = er + 16
        If Desc = Nothing Or Desc = "" Then er = er + 32
        If Pays = Nothing Or Pays = "" Then er = er + 64
        If Cat = Nothing Or Cat = "" Then er = er + 128
        Dim erName As String = "Les cases : " & vbCrLf
        Dim erNum As Integer = er

        While erNum > 0
            If erNum >= 128 Then
                erName = erName & "- Catégorie" & vbCrLf
                erNum = erNum - 128
            End If
            If erNum >= 64 Then
                erName = erName & "- Pays" & vbCrLf
                erNum = erNum - 64
            End If
            If erNum >= 32 Then
                erName = erName & "- Description" & vbCrLf
                erNum = erNum - 32
            End If
            If erNum >= 16 Then
                erName = erName & "- Groupe" & vbCrLf
                erNum = erNum - 16
            End If
            If erNum >= 8 Then
                erName = erName & "- Logo" & vbCrLf
                erNum = erNum - 8
            End If
            If erNum >= 4 Then
                erName = erName & "- TimeShift" & vbCrLf
                erNum = erNum - 4
            End If
            If erNum >= 2 Then
                erName = erName & "- ID EPG" & vbCrLf
                erNum = erNum - 2
            End If
            If erNum >= 1 Then
                erName = erName & "- Numéro de chaine" & vbCrLf
                erNum = erNum - 1
            End If
        End While
        erName = erName & "sont vides. Enregistrer quand même?"
        Dim Confirm As MsgBoxResult
        If er <> 0 Then Confirm = MsgBox(erName, vbApplicationModal + vbYesNo + vbInformation, "Confirmation")
        If Confirm = MsgBoxResult.No Then
            Return False
            Exit Function
        End If
        tvg_id = HtmlEncode(tvg_id)
        group_channel = HtmlEncode(group_channel)
        NomChaine = HtmlEncode(NomChaine)
        Desc = HtmlEncode(Desc)
        Pays = HtmlEncode(Pays)
        Cat = HtmlEncode(Cat)

        'La vérification des variables de Dialog_AskInfo est terminée, on passe a celle de la form qui contient les données concernant le stream 
        'Le Shared fonctionne, il n'y a plus qu'a récuperer les variables, les tester etc... 
        Dim Adresse As String = Form1.Adresse, DBConnect As String = Form1.DBConnect
        Dim VideoCodec As String = Form1.VideoCodec, VideoH As String = Form1.VideoH, VideoV As String = Form1.VideoV, VideoBitRate As Integer = Form1.VideoBitRate, VideoDesc As String = Form1.VideoDesc, VideoID As Integer = Form1.VideoID,
            VideoLang As String = Form1.VideoLang, VideoLevel As Integer = Form1.VideoLevel, VideoOriginalCodec As String = Form1.VideoOriginalCodec, VideoProfile As Integer = Form1.VideoProfile,
            VideoTrackID As Integer = Form1.VideoTrackID, VideoTrackName As String = Form1.VideoTrackName, VideoFPS As Single = Form1.VideoFPS,
         AudioCodec1 As String = Form1.AudioCodec, AudioChannel1 As Integer = Form1.AudioChannel, AudioRate1 As String = Form1.AudioRate, AudioBitRate1 As Integer = Form1.AudioBitRate, AudioDesc1 As String = Form1.AudioDesc, AudioID1 As Integer = Form1.AudioID,
         AudioLang1 As String = Form1.AudioLang, AudioLevel1 As Integer = Form1.AudioLevel, AudioOriginalCodec1 As String = Form1.AudioOriginalCodec, AudioProfile1 As Integer = Form1.AudioProfile, AudioTrackID1 As Integer = Form1.AudioTrackID, AudioTrackName1 As String = Form1.AudioTrackName,
         AudioCodec2 As String = Form1.AudioCodec2, AudioChannel2 As Integer = Form1.AudioChannel2, AudioRate2 As String = Form1.AudioRate2, AudioBitRate2 As Integer = Form1.AudioBitRate2, AudioDesc2 As String = Form1.AudioDesc2, AudioID2 As Integer = Form1.AudioID2,
         AudioLang2 As String = Form1.AudioLang2, AudioLevel2 As Integer = Form1.AudioLevel2, AudioOriginalCodec2 As String = Form1.AudioOriginalCodec2, AudioProfile2 As Integer = Form1.AudioProfile2, AudioTrackID2 As Integer = Form1.AudioTrackID2, AudioTrackName2 As String = Form1.AudioTrackName2,
        SubCodec1 As String = Form1.SubtitleCodec, SubTrackEnc1 As String = Form1.SubtitleTrackEnc, SubBitrate1 As Integer = Form1.SubtitleBitrate, SubDesc1 As String = Form1.SubtitleDesc, SubID1 As Integer = Form1.SubtitleID, SubLang1 As String = Form1.SubtitleLang,
        SubLevel1 As Integer = Form1.SubtitleLevel, SubOriginalCodec1 As String = Form1.SubtitleOriginalCodec, SubProfile1 As Integer = Form1.SubtitleProfile, SubTrackID1 As Integer = Form1.SubtitleTrackID, SubTrackName1 As String = Form1.SubtitleTrackName,
        SubCodec2 As String = Form1.SubtitleCodec2, SubTrackEnc2 As String = Form1.SubtitleTrackEnc2, SubBitrate2 As Integer = Form1.SubtitleBitrate2, SubDesc2 As String = Form1.SubtitleDesc2, SubID2 As Integer = Form1.SubtitleID2, SubLang2 As String = Form1.SubtitleLang2,
        SubLevel2 As Integer = Form1.SubtitleLevel2, SubOriginalCodec2 As String = Form1.SubtitleOriginalCodec2, SubProfile2 As Integer = Form1.SubtitleProfile2, SubTrackID2 As Integer = Form1.SubtitleTrackID2, SubTrackName2 As String = Form1.SubtitleTrackName2

        VideoTrackName = HtmlEncode(VideoTrackName)
        AudioTrackName1 = HtmlEncode(AudioTrackName1)
        AudioTrackName2 = HtmlEncode(AudioTrackName2)
        AudioLang1 = HtmlEncode(AudioLang1)
        AudioLang2 = HtmlEncode(AudioLang2)
        SubTrackName1 = HtmlEncode(SubTrackName1)
        SubTrackName2 = HtmlEncode(SubTrackName2)
        SubLang1 = HtmlEncode(SubLang1)
        SubLang2 = HtmlEncode(SubLang2)
        SubDesc1 = HtmlEncode(SubDesc1)
        SubDesc2 = HtmlEncode(SubDesc2)

        If VideoBitRate = Nothing Then VideoBitRate = 0
        If VideoID = Nothing Then VideoID = 0
        If VideoTrackID = Nothing Then VideoTrackID = 0
        If VideoLevel = Nothing Then VideoLevel = 0
        If VideoProfile = Nothing Then VideoProfile = 0
        If AudioBitRate1 = Nothing Then AudioBitRate1 = 0
        If AudioID1 = Nothing Then AudioID1 = 0
        If AudioLevel1 = Nothing Then AudioLevel1 = 0
        If AudioProfile1 = Nothing Then AudioProfile1 = 0
        If AudioTrackID1 = Nothing Then AudioTrackID1 = 0
        If AudioBitRate2 = Nothing Then AudioBitRate2 = 0
        If AudioID2 = Nothing Then AudioID2 = 0
        If AudioLevel2 = Nothing Then AudioLevel2 = 0
        If AudioProfile2 = Nothing Then AudioProfile2 = 0
        If AudioTrackID2 = Nothing Then AudioTrackID2 = 0
        If SubBitrate1 = Nothing Then SubBitrate1 = 0
        If SubID1 = Nothing Then SubID1 = 0
        If SubLevel1 = Nothing Then SubLevel1 = 0
        If SubProfile1 = Nothing Then SubProfile1 = 0
        If SubTrackID1 = Nothing Then SubTrackID1 = 0
        If SubBitrate2 = Nothing Then SubBitrate2 = 0
        If SubID2 = Nothing Then SubID2 = 0
        If SubLevel2 = Nothing Then SubLevel2 = 0
        If SubProfile2 = Nothing Then SubProfile2 = 0
        If SubTrackID2 = Nothing Then SubTrackID2 = 0


        'Inscription dans la base de données

        Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect), SQLCommand As SqliteCommand
        SQLConnexion.Open()
        'recherche si le NoCanal existe déjà 
        SQLCommand = SQLConnexion.CreateCommand()
        Dim cmd As String = "SELECT * FROM " & Adresse & " WHERE NoCanal=" & NoCanal & ";"
        SQLCommand.CommandText = cmd
        Dim Result As SqliteDataReader = SQLCommand.ExecuteReader(), ResultID As String = Nothing
        While Result.Read
            ResultID = Result.GetString(0)
        End While
        If ResultID = CStr(NoCanal) Then
            SQLCommand = SQLConnexion.CreateCommand()
            cmd = "UPDATE '" & Adresse & "' SET NomChaine='" &
                NomChaine & "',NomEPG='" & tvg_id & "',NoChaine='" & tvg_chno & "',GroupeChaine='" & group_channel & "',LinkLogo='" & tvg_logo & "',Timeshift='" & tvg_shift & "',Description='" & Desc & "',CatChaine='" & Cat & "',Pays='" & Pays &
                "',VideoID='" & VideoTrackID & "',VideoName='" & VideoTrackName & "',VideoCodec='" & VideoCodec & "',VideoV='" & VideoV & "',VideoH='" & VideoH & "',VideoFPS='" & VideoFPS & "',VideoOriginalCodec='" & VideoOriginalCodec &
                "',AudioID1='" & AudioTrackID1 & "',AudioName1='" & AudioTrackName1 & "',AudioCodec1='" & AudioCodec1 & "',AudioLang1='" & AudioLang1 & "',AudioChannel1='" & AudioChannel1 & "',AudioRate1='" & AudioRate1 & "',AudioOriginalCodec1='" & AudioOriginalCodec1 &
                "',AudioID2='" & AudioTrackID2 & "',AudioName2='" & AudioTrackName2 & "',AudioCodec2='" & AudioCodec2 & "',AudioLang2='" & AudioLang2 & "',AudioChannel2='" & AudioChannel2 & "',AudioRate2='" & AudioRate2 & "',AudioOriginalCodec2='" & AudioOriginalCodec2 &
                "',SubID1='" & SubTrackID1 & "',SubName1='" & SubTrackName1 & "',SubCodec1='" & SubCodec1 & "',SubLang1='" & SubLang1 & "',SubDesc1='" & SubDesc1 & "',SubOriginalCodec1='" & SubOriginalCodec1 &
                "',SubID2='" & SubTrackID2 & "',SubName2='" & SubTrackName2 & "',SubCodec2='" & SubCodec2 & "',SubLang2='" & SubLang2 & "',SubDesc2='" & SubDesc2 & "',SubOriginalCodec2='" & SubOriginalCodec2 & "' WHERE NoCanal=" & NoCanal & ";"
            SQLCommand.CommandText = cmd
            SQLCommand.ExecuteNonQuery()
            Result.Close()

            Return True
        Else

            SQLCommand = SQLConnexion.CreateCommand()
            cmd = "INSERT INTO '" & Adresse & "' (
NoCanal,NomChaine,NomEPG,NoChaine,GroupeChaine,LinkLogo,Timeshift,Description,CatChaine,Pays,VideoID,VideoName,VideoCodec,VideoV,VideoH,VideoFPS,VideoOriginalCodec,
AudioID1,AudioName1,AudioCodec1,AudioLang1,AudioChannel1,AudioRate1,AudioOriginalCodec1,AudioID2,AudioName2,AudioCodec2,AudioLang2,AudioChannel2,AudioRate2,AudioOriginalCodec2,
SubID1,SubName1,SubCodec1,SubLang1,SubDesc1,SubOriginalCodec1,SubID2,SubName2,SubCodec2,SubLang2,SubDesc2,SubOriginalCodec2) VALUES ('" &
    NoCanal & "','" & NomChaine & "','" & tvg_id & "','" & tvg_chno & "','" & group_channel & "','" & tvg_logo & "','" & tvg_shift & "','" & Desc & "','" & Cat & "','" & Pays & "','" & VideoTrackID & "','" & VideoTrackName & "','" & VideoCodec & "','" & VideoV & "','" & VideoH & "','" & VideoFPS & "','" & VideoOriginalCodec & "','" &
    AudioTrackID1 & "','" & AudioTrackName1 & "','" & AudioCodec1 & "','" & AudioLang1 & "','" & AudioChannel1 & "','" & AudioRate1 & "','" & AudioOriginalCodec1 & "','" &
    AudioTrackID2 & "','" & AudioTrackName2 & "','" & AudioCodec2 & "','" & AudioLang2 & "','" & AudioChannel2 & "','" & AudioRate2 & "','" & AudioOriginalCodec2 & "','" &
    SubTrackID1 & "','" & SubTrackName1 & "','" & SubCodec1 & "','" & SubLang1 & "','" & SubDesc1 & "','" & SubOriginalCodec1 & "','" &
    SubTrackID2 & "','" & SubTrackName2 & "','" & SubCodec2 & "','" & SubLang2 & "','" & SubDesc2 & "','" & SubOriginalCodec2 &
        "');"
            SQLCommand.CommandText = cmd
            SQLCommand.ExecuteNonQuery()

            'On affiche dans le tabBDD les info recuperée
            With Form1
                .lbl_RNoCanal.Text = CStr(NoCanal)
                .lbl_RNomChaine.Text = HtmlDecode(NomChaine)
                .lbl_RNoChaine.Text = tvg_chno
                .lbl_RNomEPG.Text = HtmlDecode(tvg_id)
                .Lbl_RTimeShift.Text = tvg_shift
                .lbl_RGroupChannel.Text = HtmlDecode(group_channel)
                .lbl_RCategorie.Text = HtmlDecode(Cat)
                .lbl_RPays.Text = HtmlDecode(Pays)
                .txt_RDescription.Text = HtmlDecode(Desc)
                .PictureBox_RLinkImg.ImageLocation = tvg_logo
            End With

            Return True
        End If
        SQLConnexion.Close()
    End Function

End Module
