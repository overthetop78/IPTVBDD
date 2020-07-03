Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Data.Sqlite
Imports Vlc.DotNet.Core
Imports Vlc.DotNet.Forms
Imports Vlc.DotNet.Core.Interops
Imports Vlc.DotNet.Core.Interops.Signatures
Imports System.Web.HttpUtility

Module Database
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
                        Dim cmd As String = $"SELECT * FROM InfoIPTV WHERE AdresseHTTP='{AdresseHTTP}';"
                        SQLCommand.CommandText = cmd
                        TestLigneDB = SQLCommand.ExecuteScalar

                        If TestLigneDB = False Then
                            'creation de la ligne
                            SQLCommand = SQLConnexion.CreateCommand()
                            cmd = $"INSERT INTO InfoIPTV (HTTPVer,AdresseHTTP,HTTPPort,Pseudo,Pass) VALUES ('{HTTPVer}','{AdresseHTTP}','{HTTPPort}','{Pseudo}','{Pass}');"
                            SQLCommand.CommandText = cmd
                            SQLCommand.ExecuteNonQuery()
                            'creation de la table . Il faut : le numéro du canal (du http), le Nom de la chaine, le nom EPG de la chaine, Le numéro de la chaine, le groupe de la chaine, le lien vers le logo de la chaine, le timeshift, 
                            ' description de la chaine, Type de chaines (Sports, Generalistes, Musicales, Radio, Cinema, Divertissements, Jeunesse, Decouvertes, Locales, Infos,etc..), Pays, 
                            ' Type video (AVC, HEVC, MPEG2), résolution video (1920*1080), définition video (1080P, 720P, 540P), FPS,  Nombre de langage, Langue 1 (Fra), Langue 1 Type (AAC, Dolby Digital), Langue 2 (Eng) Langue 2 Type (AAC, Dolby Digital)
                            ' Nombre de Sous-titre, Sous-titre 1 (Fra), Sous-Titre 2 (Eng) 
                            SQLCommand = SQLConnexion.CreateCommand()
                            cmd = $"CREATE TABLE '{Adresse}' (
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


    Public Function RecData() As Boolean
        'Enregistrement et vérification de variable
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
        Dim cmd As String = $"SELECT * FROM {Adresse} WHERE NoCanal={NoCanal};"
        SQLCommand.CommandText = cmd
        Dim Result As SqliteDataReader = SQLCommand.ExecuteReader(), ResultID As String = Nothing
        While Result.Read
            ResultID = Result.GetString(0)
        End While
        If ResultID = CStr(NoCanal) Then
            SQLCommand = SQLConnexion.CreateCommand()
            cmd = $"UPDATE '{Adresse}' SET NomChaine='{NomChaine}',NomEPG='{tvg_id}',NoChaine='{tvg_chno}',GroupeChaine='{group_channel}',LinkLogo='{tvg_logo}',Timeshift='{tvg_shift}',Description='{Desc}',CatChaine='{Cat}',Pays='{Pays}',
VideoID='{VideoTrackID}',VideoName='{VideoTrackName}',VideoCodec='{VideoCodec}',VideoV='{VideoV}',VideoH='{VideoH}',VideoFPS='{VideoFPS}',VideoOriginalCodec='{VideoOriginalCodec}',
AudioID1='{AudioTrackID1}',AudioName1='{AudioTrackName1}',AudioCodec1='{AudioCodec1}',AudioLang1='{AudioLang1}',AudioChannel1='{AudioChannel1}',AudioRate1='{AudioRate1}',AudioOriginalCodec1='{AudioOriginalCodec1}',
AudioID2='{AudioTrackID2}',AudioName2='{AudioTrackName2}',AudioCodec2='{AudioCodec2}',AudioLang2='{AudioLang2}',AudioChannel2='{AudioChannel2}',AudioRate2='{AudioRate2}',AudioOriginalCodec2='{AudioOriginalCodec2}',
SubID1='{SubTrackID1}',SubName1='{SubTrackName1}',SubCodec1='{SubCodec1}',SubLang1='{SubLang1}',SubDesc1='{SubDesc1}',SubOriginalCodec1='{SubOriginalCodec1}',
SubID2='{SubTrackID2}',SubName2='{SubTrackName2}',SubCodec2='{SubCodec2}',SubLang2='{SubLang2}',SubDesc2='{SubDesc2}',SubOriginalCodec2='{SubOriginalCodec2}' WHERE NoCanal={NoCanal};"
            SQLCommand.CommandText = cmd
            SQLCommand.ExecuteNonQuery()
            Result.Close()

            Return True
        Else

            SQLCommand = SQLConnexion.CreateCommand()
            cmd = $"INSERT INTO '{Adresse}' (
NoCanal,NomChaine,NomEPG,NoChaine,GroupeChaine,LinkLogo,Timeshift,Description,CatChaine,Pays,VideoID,VideoName,VideoCodec,VideoV,VideoH,VideoFPS,VideoOriginalCodec,
AudioID1,AudioName1,AudioCodec1,AudioLang1,AudioChannel1,AudioRate1,AudioOriginalCodec1,AudioID2,AudioName2,AudioCodec2,AudioLang2,AudioChannel2,AudioRate2,AudioOriginalCodec2,
SubID1,SubName1,SubCodec1,SubLang1,SubDesc1,SubOriginalCodec1,SubID2,SubName2,SubCodec2,SubLang2,SubDesc2,SubOriginalCodec2) VALUES ('{NoCanal}','{NomChaine}','{tvg_id}','{tvg_chno}','{group_channel}','{tvg_logo}','{tvg_shift}','{Desc}','{Cat}','{Pays}',
'{VideoTrackID}','{VideoTrackName}','{VideoCodec}','{VideoV}','{VideoH}','{VideoFPS}','{VideoOriginalCodec}',
'{AudioTrackID1}','{AudioTrackName1}','{AudioCodec1}','{AudioLang1}','{AudioChannel1}','{AudioRate1}','{AudioOriginalCodec1}',
'{AudioTrackID2}','{AudioTrackName2}','{AudioCodec2}','{AudioLang2}','{AudioChannel2}','{AudioRate2}','{AudioOriginalCodec2}',
'{SubTrackID1}','{SubTrackName1}','{SubCodec1}','{SubLang1}','{SubDesc1}','{SubOriginalCodec1}',
'{SubTrackID2}','{SubTrackName2}','{SubCodec2}','{SubLang2}','{SubDesc2}','{SubOriginalCodec2}');"
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

    Public Sub LectureBDD(ByVal i As Integer)
        'Maintenant qu'on a toutes les infos dans des variables on peut rechercher une correspondance dans la base de données
        'on efface les variables (On mettra tout dans un tableau, ce sera plus simple)
        RNoCanal = Nothing
        RNomChaine = Nothing
        RNomEPG = Nothing
        RNoChaine = Nothing
        RGroupChaine = Nothing
        RLinkLogo = Nothing
        RTimeshift = Nothing
        RDescription = Nothing
        RCatChaine = Nothing
        RPays = Nothing
        RVideoID = Nothing
        RVideoName = Nothing
        RVideoCodec = Nothing
        RVideoV = Nothing
        RVideoH = Nothing
        RVideoFPS = Nothing
        RVideoOriginalCodec = Nothing
        RAudioID1 = Nothing
        RAudioName1 = Nothing
        RAudioCodec1 = Nothing
        RAudioLang1 = Nothing
        RAudioChannel1 = Nothing
        RAudioRate1 = Nothing
        RAudioOriginalCodec1 = Nothing
        RAudioID2 = Nothing
        RAudioName2 = Nothing
        RAudioCodec2 = Nothing
        RAudioLang2 = Nothing
        RAudioChannel2 = Nothing
        RAudioRate2 = Nothing
        RAudioOriginalCodec2 = Nothing
        RSubID1 = Nothing
        RSubName1 = Nothing
        RSubCodec1 = Nothing
        RSubLang1 = Nothing
        RSubDesc1 = Nothing
        RSubOriginalCodec1 = Nothing
        RSubID2 = Nothing
        RSubName2 = Nothing
        RSubCodec2 = Nothing
        RSubLang2 = Nothing
        RSubDesc2 = Nothing
        RSubOriginalCodec2 = Nothing
        'On recherche dans la table AdresseHTTP si une des variable existe 
        Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect)
        SQLConnexion.Open()
        SQLCommand = SQLConnexion.CreateCommand()
        'recherche dans la base de données AdresseHTTP la ligne ou ID est egal a l'ID qui represente le canal IPTV
        SQLCommand.CommandText = $"SELECT * FROM '{Adresse}' WHERE NoCanal ={i};"
        Dim ResultReq As SqliteDataReader = SQLCommand.ExecuteReader()
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
                RSubOriginalCodec2 = ResultReq(42)
            Loop

            'Si on a une entrée , on va chercher
            If ResultReq.HasRows <> False Then
                'On met a jour 
                NomChaine = RNomChaine
                tvg_id = RNomEPG
                tvg_chno = RNoChaine
                group_title = RGroupChaine
                tvg_logo = RLinkLogo
                tvg_shift = RTimeshift
                Desc = RDescription
                Cat = RCatChaine
                Pays = RPays
            End If
        Catch ex As Exception
            Dim Erreur As String = ex.Message + vbCrLf + ex.HelpLink & vbCrLf & CStr(ex.HResult) & vbCrLf & ex.Source & vbCrLf & ex.StackTrace
            MsgBox(Erreur, vbApplicationModal)
        End Try
        ResultReq.Close()
        SQLConnexion.Close()
    End Sub
End Module
