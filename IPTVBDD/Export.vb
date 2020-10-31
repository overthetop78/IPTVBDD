Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Data.Sqlite
Imports Vlc.DotNet.Core
Imports Vlc.DotNet.Forms
Imports Vlc.DotNet.Core.Interops
Imports Vlc.DotNet.Core.Interops.Signatures
Imports System.Web.HttpUtility

Module Export

    Public Sub ExportM3U(ByVal Exp As Integer)
        Select Case Exp
            Case 1
                ' Création du fichier M3U en prenant toutes les chaines de la base de données non triée
                Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect), SQLConnexion2 As SqliteConnection = New SqliteConnection(DBConnect)
                Dim ID As String = Nothing, HTTP As String = Nothing, AdresseA As String = Nothing, Port As String = Nothing, Pseudo As String = Nothing, Pass As String = Nothing, FullAddress As String = Nothing
                SQLConnexion.Open()
                SQLCommand = SQLConnexion.CreateCommand()
                Dim cmd As String = $"SELECT * FROM InfoIPTV WHERE AdresseHTTP='{AdresseHTTP}';"
                SQLCommand.CommandText = cmd
                Dim Resultat As SqliteDataReader = SQLCommand.ExecuteReader()
                Do While Resultat.Read
                    ID = Resultat.GetString(0)
                    HTTP = Resultat.GetString(1)
                    AdresseA = Resultat.GetString(2)
                    Port = Resultat.GetString(3)
                    Pseudo = Resultat.GetString(4)
                    Pass = Resultat.GetString(5)
                Loop
                Resultat.Close()
                SQLConnexion.Close()
                FullAddress = $"{HTTP}://{AdresseA}:{Port}/{Pseudo}/{Pass}/"
                SQLConnexion.Open()
                SQLCommand = SQLConnexion.CreateCommand()
                'recherche dans la base de données AdresseHTTP la ligne ou ID est egal a l'ID qui represente le canal IPTV et classer d'abord par numéro de chaine. 

                SQLCommand.CommandText = $"SELECT * FROM '{Adresse}' ORDER BY NoCanal ASC;"
                Dim Result As SqliteDataReader = SQLCommand.ExecuteReader(), i As Integer = 0, Item As String = Nothing, Item2 As String = Nothing
                'Variable pour les lignes du fichier M3U
                Dim NoCanal As String = Nothing, NomChaine As String = Nothing, NoChaine As String = Nothing, NomEPG As String = Nothing, Timeshift As String = Nothing, Groupe As String = Nothing, Logo As String = Nothing, URL As String = Nothing
                'Ajout en fin de ligne d'info comme VideoV (qui donnera par exemple 720P , 480P, 1080P) le format Video H264, H265. La langue audio principale , le codec Audio et le nombre de canaux. Ainsi que les sous-titres (juste s'ils existent)
                Dim Resolution As String = Nothing, VideoCodec As String = Nothing, AudioLang As String = Nothing, AudioCodec As String = Nothing, AudioChannel As String = Nothing, SubExist As String = Nothing
                If Result.HasRows = False Then Exit Sub
                Dim WriteFichier As String = $"{Application.StartupPath}\{Adresse}.m3u"
                If File.Exists(WriteFichier) = True Then File.Delete(WriteFichier)
                Dim Strm As StreamWriter = New StreamWriter(WriteFichier)
                Item = $"#EXTM3U{vbCrLf}"
                Strm.Write(Item)
                While Result.Read
                    'On récupere les infos 
                    NoCanal = Result.GetString(0)
                    NomChaine = HtmlDecode(Result.GetString(1))
                    NomEPG = HtmlDecode(Result.GetString(2))
                    NoChaine = Result.GetString(3)
                    Groupe = HtmlDecode(Result.GetString(4))
                    Logo = Result.GetString(5)
                    Timeshift = Result.GetString(6)
                    URL = FullAddress & NoCanal
                    VideoCodec = Result.GetString(12).ToUpper
                    Resolution = Result.GetString(13) & "P"
                    AudioCodec = Result.GetString(19).ToUpper
                    AudioLang = Result.GetString(20).ToUpper
                    AudioChannel = $"{Result.GetString(21)} Channels"
                    If Result.GetString(31) > 0 Then
                        SubExist = "- Sous-Titres"
                    End If
                    Item = $"#EXTINF:-1, tvg-chno={Chr(34)}{NoChaine}{Chr(34)} tvg-name={Chr(34)}{NomChaine}{Chr(34)} tvg-id={Chr(34)}{NomEPG}{Chr(34)} tvg-shift={Chr(34)}{Timeshift}{Chr(34)} group-title={Chr(34)}{Groupe}{Chr(34)} tvg-logo={Chr(34)}{Logo}{Chr(34)},{NomChaine} [{Resolution} - {VideoCodec} - {AudioLang} - {AudioCodec} {SubExist}]{vbCrLf}"
                    Item2 = $"{FullAddress}{NoCanal}{vbCrLf}"
                    'On peut ajouter directement dans un fichier 
                    Strm.Write(Item)
                    Strm.Write(Item2)
                End While
                'Après avoir fait la liste, on va pouvoir creer le fichier M3U 
                Strm.Close()
                Result.Close()
                SQLConnexion.Close()
            Case 2
                'Création du fichier M3U avec les chaines de la base de données par ordre de numéro des chaines. Si les chaines n'ont pas de numéro, elles ne sont pas ajoutées
                'd'abord vérifier que la table existe et n'est pas vide 
                Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect), SQLConnexion2 As SqliteConnection = New SqliteConnection(DBConnect)
                Dim ID As String = Nothing, HTTP As String = Nothing, AdresseA As String = Nothing, Port As String = Nothing, Pseudo As String = Nothing, Pass As String = Nothing, FullAddress As String = Nothing
                SQLConnexion.Open()
                SQLCommand = SQLConnexion.CreateCommand()
                Dim cmd As String = $"SELECT * FROM InfoIPTV WHERE AdresseHTTP='{AdresseHTTP}';"
                SQLCommand.CommandText = cmd
                Dim Resultat As SqliteDataReader = SQLCommand.ExecuteReader()
                Do While Resultat.Read
                    ID = Resultat.GetString(0)
                    HTTP = Resultat.GetString(1)
                    AdresseA = Resultat.GetString(2)
                    Port = Resultat.GetString(3)
                    Pseudo = Resultat.GetString(4)
                    Pass = Resultat.GetString(5)
                Loop
                Resultat.Close()
                SQLConnexion.Close()
                FullAddress = $"{HTTP}://{AdresseA}:{Port}/{Pseudo}/{Pass}/"
                SQLConnexion.Open()
                SQLCommand = SQLConnexion.CreateCommand()
                'recherche dans la base de données AdresseHTTP la ligne ou ID est egal a l'ID qui represente le canal IPTV et classer d'abord par numéro de chaine. 

                SQLCommand.CommandText = $"SELECT * FROM ChannelList  WHERE NoChaine != '' ORDER BY CAST(NoChaine AS INTEGER);"
                Dim Result As SqliteDataReader = SQLCommand.ExecuteReader(), i As Integer = 0, Item As String = Nothing, Item2 As String = Nothing
                'Variable pour les lignes du fichier M3U
                Dim Ident As Integer, NoCanal As String = Nothing, NomChaine As String = Nothing, NomChaine2 As String = Nothing, NoChaine As String = Nothing, NomEPG As String = Nothing, Timeshift As String = Nothing, Groupe As String = Nothing, Logo As String = Nothing, URL As String = Nothing
                'Ajout en fin de ligne d'info comme VideoV (qui donnera par exemple 720P , 480P, 1080P) le format Video H264, H265. La langue audio principale , le codec Audio et le nombre de canaux. Ainsi que les sous-titres (juste s'ils existent)
                Dim Resolution As String = Nothing, VideoCodec As String = Nothing, AudioLang As String = Nothing, AudioCodec As String = Nothing, AudioChannel As String = Nothing, SubExist As String = Nothing
                If Result.HasRows = False Then Exit Sub
                Dim WriteFichier As String = $"{Application.StartupPath}\{Adresse}.m3u"
                If File.Exists(WriteFichier) = True Then File.Delete(WriteFichier)
                Dim Strm As StreamWriter = New StreamWriter(WriteFichier)
                Item = $"#EXTM3U{vbCrLf}"
                Strm.Write(Item)
                While Result.Read
                    'On récupere les infos 
                    Ident = Result.GetString(0)
                    NomChaine = Result.GetString(1)
                    NomEPG = HtmlDecode(Result.GetString(2))
                    NoChaine = Result.GetString(3)
                    Groupe = HtmlDecode(Result.GetString(4))
                    Logo = Result.GetString(5)
                    Timeshift = Result.GetString(6)
                    Desc = Result.GetString(7)
                    RCatChaine = Result.GetString(8)
                    Pays = Result.GetString(9)
                    'Maintenant il faut récupérer la ligne trouvée dans la table contenant le num de canal
                    SQLConnexion2.Open()
                    SQLCommand2 = SQLConnexion.CreateCommand()
                    SQLCommand2.CommandText = $"SELECT * FROM '{Adresse}' WHERE NomChaine='{NomChaine}';"
                    Result2 = SQLCommand2.ExecuteReader()
                    While Result2.Read
                        NoCanal = Result2.GetString(0)
                        NomChaine2 = HtmlDecode(Result2.GetString(1))
                        'On peut ajouter directement dans un fichier 
                        Item = $"#EXTINF:-1, tvg-chno={Chr(34)}{NoChaine}{Chr(34)} tvg-name={Chr(34)}{NomChaine2}{Chr(34)} tvg-id={Chr(34)}{NomEPG}{Chr(34)} tvg-shift={Chr(34)}{Timeshift}{Chr(34)} group-title={Chr(34)}{Groupe}{Chr(34)} tvg-logo={Chr(34)}{Logo}{Chr(34)},{NomChaine2}{vbCrLf}"
                        Item2 = $"{FullAddress}{NoCanal}{vbCrLf}"
                        Strm.Write(Item)
                        Strm.Write(Item2)
                    End While
                    Result2.Close()
                    SQLConnexion2.Close()
                End While
                'Après avoir fait la liste, on va pouvoir creer le fichier M3U 
                Strm.Close()
                Result.Close()
                SQLConnexion.Close()

            Case 3

            Case 4

            Case Else

        End Select
    End Sub
End Module
