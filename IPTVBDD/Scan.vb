Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Data.Sqlite
Imports Vlc.DotNet.Core
Imports Vlc.DotNet.Forms
Imports Vlc.DotNet.Core.Interops
Imports Vlc.DotNet.Core.Interops.Signatures
Imports System.Web.HttpUtility


Module Scan
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


    Public Function ScanCanal(ByVal ScanType As Integer, Optional FichierM3U As String = Nothing, Optional AdresseHTTP As String = Nothing) As Boolean
        'Recupération des infos dans la base de données
        Form1.NumericUpDown1.ReadOnly = True
        Try
            Dim ID As Integer = 0, HTTP As String = Nothing, AdresseA As String = Nothing, Port As String = Nothing, Pseudo As String = Nothing, Pass As String = Nothing, FullAddress As String = Nothing
            'Charger le fichier dans une List String
            Dim Lignes As String() = File.ReadAllLines(FichierM3U)
            Dim SQLConnexion As SqliteConnection = New SqliteConnection(DBConnect)
            SQLConnexion.Open()
            SQLCommand = SQLConnexion.CreateCommand()
            Dim cmd As String = $"SELECT * FROM InfoIPTV WHERE AdresseHTTP='{AdresseHTTP}';"
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
            FullAddress = $"{HTTP}://{AdresseA}:{Port}/{Pseudo}/{Pass}/"
            Dim Arg As New List(Of String) From {
                CStr(ScanType),
                FichierM3U,
                AdresseHTTP,
                FullAddress
            }
            If Form1.BGW.IsBusy <> True Then
                Form1.StatutBar_InfoBGW.BackColor = Color.Orange
                Form1.StatutBar_InfoBGW.ToolTipText = "Scan en cours"
                Form1.BGW.RunWorkerAsync(Arg)
                Form1.Btn_StopScan.Enabled = True
            End If

        Catch ex As Exception
            MsgBox("L'erreur suivante a été rencontrée:" & ex.Message)
        End Try
        Return ScanCanal

    End Function



End Module
