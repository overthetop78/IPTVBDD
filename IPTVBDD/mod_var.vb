Imports Vlc.DotNet.Core
Imports Vlc.DotNet.Core.Interops
Imports Vlc.DotNet.Core.Interops.Signatures
Imports Microsoft.Data.Sqlite
Imports System.Web.HttpUtility
Imports Renci.SshNet
Imports System.IO

Module mod_var

    'Enregistrement de variable 
    Public NomChaine As String = Nothing, tvg_name As String = Nothing, tvg_id As String = Nothing, tvg_chno As String = Nothing, tvg_shift As String = Nothing, group_title As String = Nothing, group_channel As String = Nothing, tvg_logo As String = Nothing
    Public Desc As String = Nothing, Pays As String = Nothing, Cat As String = Nothing, NoCanal As Integer = 0
    Public FichierM3U As String, Adresse As String = Nothing, AdresseHTTP As String, Pseudo As String, Pass As String, HTTPVer As String, DBLink As String, HTTPPort As String
    Public DBConnect As String = $"Data Source={Application.StartupPath}\IPTVDatabase.sqlite", DBFile As String = $"{Application.StartupPath}\IPTVDatabase.sqlite"
    Public RepNomChaine As String = Nothing, Reptvg_id As String = Nothing, FileWebLogo As String = $"{Application.StartupPath}\listelogo.txt"
    Public VideoCodec As String = Nothing, VideoTrack As VideoTrack, VideoH As Integer = 0, VideoV As Integer = 0, VideoBitRate As Integer = 0, VideoDesc As String = Nothing, VideoID As Integer = 0, VideoLang As String = Nothing
    Public VideoLevel As Integer = 0, VideoOriginalCodec As String = Nothing, VideoProfile As Integer = 0, VideoTrackID As Integer = 0, VideoTrackName As String = Nothing, VideoFPS As Single
    Public AudioCodec1 As String = Nothing, AudioTrack1 As AudioTrack, AudioChannel1 As Integer = 0, AudioRate1 As Integer = 0, AudioBitRate1 As Integer = 0, AudioDesc1 As String = Nothing, AudioID1 As Integer = 0, AudioLang1 As String = Nothing
    Public AudioLevel1 As Integer = 0, AudioOriginalCodec1 As String = Nothing, AudioProfile1 As Integer = 0
    Public AudioCodec2 As String = Nothing, AudioTrack2 As AudioTrack, AudioChannel2 As Integer = 0, AudioRate2 As Integer = 0, AudioBitRate2 As Integer = 0, AudioDesc2 As String = Nothing, AudioID2 As Integer = 0, AudioLang2 As String = Nothing
    Public AudioLevel2 As Integer = 0, AudioOriginalCodec2 As String = Nothing, AudioProfile2 As Integer = 0
    Public AudioTrackID1 As Integer = 0, AudioTrackName1 As String = Nothing, AudioTrackID2 As Integer = 0, AudioTrackName2 As String = Nothing
    Public SubCodec1 As String = Nothing, SubTrack1 As SubtitleTrack, SubTrackEnc1 As String = Nothing, SubBitrate1 As Integer = 0, SubDesc1 As String = Nothing, SubID1 As Integer = 0, SubLang1 As String = Nothing
    Public SubLevel1 As Integer = 0, SubOriginalCodec1 As String = Nothing, SubProfile1 As Integer = 0
    Public SubCodec2 As String = Nothing, SubTrack2 As SubtitleTrack, SubTrackEnc2 As String = Nothing, SubBitrate2 As Integer = 0, SubDesc2 As String = Nothing, SubID2 As Integer = 0, SubLang2 As String = Nothing
    Public SubLevel2 As Integer = 0, SubOriginalCodec2 As String = Nothing, SubProfile2 As Integer = 0
    Public SubTrackID1 As Integer = 0, SubTrackName1 As String = Nothing, SubTrackID2 As Integer = 0, SubTrackName2 As String = Nothing
    Public SQLConnexion As SqliteConnection, SQLCommand As SqliteCommand
    Public TestLink As String = Nothing
    Public IMGH As Integer, IMGHR As Integer, IMGV As Integer, IMGVR As Integer, IMGPixel As Imaging.PixelFormat, IMGPalette As Imaging.ColorPalette, IMGRawFormat As Imaging.ImageFormat
    Public cmd As SshCommand, DossierLogos As String = "/var/www/html/iptv/logos_tv/", LinkLogos As String = "http://informaweb.freeboxos.free/iptv/logos_tv/"
    Public RNoCanal As Integer = 0, RNomChaine As String = Nothing, RNomEPG As String = Nothing, RNoChaine As String = Nothing, RGroupChaine As String = Nothing, RLinkLogo As String = Nothing, RTimeshift As String = Nothing,
            RDescription As String = Nothing, RCatChaine As String = Nothing, RPays As String = Nothing, RVideoID As Integer = 0, RVideoName As String = Nothing, RVideoCodec As String = Nothing, RVideoV As Integer = 0,
            RVideoH As Integer, RVideoFPS As Single, RVideoOriginalCodec As String = Nothing, RAudioID1 As Integer, RAudioName1 As String = Nothing, RAudioCodec1 As String = Nothing, RAudioLang1 As String = Nothing,
            RAudioChannel1 As Integer = 0, RAudioRate1 As Integer = 0, RAudioOriginalCodec1 As String = Nothing, RAudioID2 As Integer = 0, RAudioName2 As String = Nothing, RAudioCodec2 As String = Nothing, RAudioLang2 As String = Nothing,
            RAudioChannel2 As Integer = 0, RAudioRate2 As Integer = 0, RAudioOriginalCodec2 As String = Nothing, RSubID1 As Integer = 0, RSubName1 As String = Nothing, RSubCodec1 As String = Nothing, RSubLang1 As String = Nothing,
            RSubDesc1 As String = Nothing, RSubOriginalCodec1 As String = Nothing, RSubID2 As Integer = 0, RSubName2 As String = Nothing, RSubCodec2 As String = Nothing, RSubLang2 As String = Nothing,
            RSubDesc2 As String = Nothing, RSubOriginalCodec2 As String = Nothing
    Public Const LinkImg As String = "http://informaweb.freeboxos.fr/iptv/logos_tv/"
    Public ImageCount As Integer, ImageListURL As New List(Of String), ImageListName As New List(Of String)
    Public NomChaineRech As String

    Public Sub LectureFichierM3U(ByVal AllFullAddress As String)
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
    End Sub


End Module
