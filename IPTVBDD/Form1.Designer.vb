<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichiersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDeLectureM3UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlyActiveStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlyNoActiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiviserParToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoActiveScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateListeDesLogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.VlcControl1 = New Vlc.DotNet.Forms.VlcControl()
        Me.BGW = New System.ComponentModel.BackgroundWorker()
        Me.Btn_StopScan = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatutBar_InfoBGW = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatutBar_NoCanal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatutBarProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabGeneral = New System.Windows.Forms.TabPage()
        Me.GroupBox_Sub2 = New System.Windows.Forms.GroupBox()
        Me.lbl_SubDesc2Val = New System.Windows.Forms.Label()
        Me.lbl_SubDesc2 = New System.Windows.Forms.Label()
        Me.lbl_SubOriginalCodec2Val = New System.Windows.Forms.Label()
        Me.lbl_SubOriginalCodec2 = New System.Windows.Forms.Label()
        Me.lbl_SubName2Val = New System.Windows.Forms.Label()
        Me.lbl_SubName2 = New System.Windows.Forms.Label()
        Me.lbl_SubID2Val = New System.Windows.Forms.Label()
        Me.lbl_SubID2 = New System.Windows.Forms.Label()
        Me.lbl_SubLang2Val = New System.Windows.Forms.Label()
        Me.lbl_SubLang2 = New System.Windows.Forms.Label()
        Me.lbl_SubCodec2Val = New System.Windows.Forms.Label()
        Me.lbl_SubCodec2 = New System.Windows.Forms.Label()
        Me.GroupBox_Sub1 = New System.Windows.Forms.GroupBox()
        Me.lbl_SubOriginalCodec1Val = New System.Windows.Forms.Label()
        Me.lbl_SubOriginalCodec1 = New System.Windows.Forms.Label()
        Me.lbl_SubName1Val = New System.Windows.Forms.Label()
        Me.lbl_SubName1 = New System.Windows.Forms.Label()
        Me.lbl_SubID1Val = New System.Windows.Forms.Label()
        Me.lbl_SubID1 = New System.Windows.Forms.Label()
        Me.lbl_SubDesc1Val = New System.Windows.Forms.Label()
        Me.lbl_SubDesc1 = New System.Windows.Forms.Label()
        Me.lbl_SubLang1Val = New System.Windows.Forms.Label()
        Me.lbl_SubLang1 = New System.Windows.Forms.Label()
        Me.lbl_SubCodec1Val = New System.Windows.Forms.Label()
        Me.lbl_SubCodec1 = New System.Windows.Forms.Label()
        Me.GroupBox_Audio2 = New System.Windows.Forms.GroupBox()
        Me.lbl_AudioOriginalCodec2Val = New System.Windows.Forms.Label()
        Me.lbl_AudioOriginalCodec2 = New System.Windows.Forms.Label()
        Me.lbl_AudioName2Val = New System.Windows.Forms.Label()
        Me.lbl_AudioName2 = New System.Windows.Forms.Label()
        Me.lbl_AudioID2Val = New System.Windows.Forms.Label()
        Me.lbl_AudioID2 = New System.Windows.Forms.Label()
        Me.lbl_AudioChannel2Val = New System.Windows.Forms.Label()
        Me.lbl_AudioChannel2 = New System.Windows.Forms.Label()
        Me.lbl_AudioLang2Val = New System.Windows.Forms.Label()
        Me.lbl_AudioLang2 = New System.Windows.Forms.Label()
        Me.lbl_AudioRate2Val = New System.Windows.Forms.Label()
        Me.lbl_AudioRate2 = New System.Windows.Forms.Label()
        Me.lbl_AudioCodec2Val = New System.Windows.Forms.Label()
        Me.lbl_AudioCodec2 = New System.Windows.Forms.Label()
        Me.GroupBox_Audio1 = New System.Windows.Forms.GroupBox()
        Me.lbl_AudioOriginalCodec1Val = New System.Windows.Forms.Label()
        Me.lbl_AudioOrigionalCodec1 = New System.Windows.Forms.Label()
        Me.lbl_AudioName1Val = New System.Windows.Forms.Label()
        Me.lbl_AudioName1 = New System.Windows.Forms.Label()
        Me.lbl_AudioID1Val = New System.Windows.Forms.Label()
        Me.lbl_AudioID1 = New System.Windows.Forms.Label()
        Me.lbl_AudioChannel1Val = New System.Windows.Forms.Label()
        Me.lbl_AudioChannel1 = New System.Windows.Forms.Label()
        Me.lbl_AudioLang1Val = New System.Windows.Forms.Label()
        Me.lbl_AudioLang1 = New System.Windows.Forms.Label()
        Me.lbl_AudioRate1Val = New System.Windows.Forms.Label()
        Me.lbl_AudioRate1 = New System.Windows.Forms.Label()
        Me.lbl_AudioCodec1Val = New System.Windows.Forms.Label()
        Me.lbl_AudioCodec1 = New System.Windows.Forms.Label()
        Me.GroupBox_Video = New System.Windows.Forms.GroupBox()
        Me.lbl_VideoOriginalCodecVal = New System.Windows.Forms.Label()
        Me.Lbl_VideoOriginalCodec = New System.Windows.Forms.Label()
        Me.lbl_VideoNameVal = New System.Windows.Forms.Label()
        Me.lbl_VideoName = New System.Windows.Forms.Label()
        Me.lbl_VideoIDVal = New System.Windows.Forms.Label()
        Me.lbl_VideoID = New System.Windows.Forms.Label()
        Me.lbl_VideoResVal = New System.Windows.Forms.Label()
        Me.lbl_VideoRes = New System.Windows.Forms.Label()
        Me.lbl_VideoDefVal = New System.Windows.Forms.Label()
        Me.lbl_VideoDef = New System.Windows.Forms.Label()
        Me.lbl_VideoFPSVal = New System.Windows.Forms.Label()
        Me.lbl_VideoFPS = New System.Windows.Forms.Label()
        Me.lbl_VideoCodecVal = New System.Windows.Forms.Label()
        Me.lbl_VideoCodec = New System.Windows.Forms.Label()
        Me.lbl_NameChannel = New System.Windows.Forms.Label()
        Me.TabBDD = New System.Windows.Forms.TabPage()
        Me.txt_RDescription = New System.Windows.Forms.TextBox()
        Me.PictureBox_RLinkImg = New System.Windows.Forms.PictureBox()
        Me.lbl_RCategorie = New System.Windows.Forms.Label()
        Me.lbl_RPays = New System.Windows.Forms.Label()
        Me.lbl_RGroupChannel = New System.Windows.Forms.Label()
        Me.Lbl_RTimeShift = New System.Windows.Forms.Label()
        Me.lbl_RNomEPG = New System.Windows.Forms.Label()
        Me.lbl_RNoChaine = New System.Windows.Forms.Label()
        Me.lbl_RNoCanal = New System.Windows.Forms.Label()
        Me.lbl_RNomChaine = New System.Windows.Forms.Label()
        Me.CheckBox_ShowLogs = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.VlcControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.GroupBox_Sub2.SuspendLayout()
        Me.GroupBox_Sub1.SuspendLayout()
        Me.GroupBox_Audio2.SuspendLayout()
        Me.GroupBox_Audio1.SuspendLayout()
        Me.GroupBox_Video.SuspendLayout()
        Me.TabBDD.SuspendLayout()
        CType(Me.PictureBox_RLinkImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichiersToolStripMenuItem, Me.ScanToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(2079, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichiersToolStripMenuItem
        '
        Me.FichiersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExportStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.FichiersToolStripMenuItem.Name = "FichiersToolStripMenuItem"
        Me.FichiersToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.FichiersToolStripMenuItem.Text = "&Fichier"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.OuvrirToolStripMenuItem.Text = "&Ouvrir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(249, 6)
        '
        'ExportStripMenuItem
        '
        Me.ExportStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDeLectureM3UToolStripMenuItem})
        Me.ExportStripMenuItem.Name = "ExportStripMenuItem"
        Me.ExportStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ExportStripMenuItem.Text = "&Export"
        '
        'ListeDeLectureM3UToolStripMenuItem
        '
        Me.ListeDeLectureM3UToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullToolStripMenuItem, Me.OnlyActiveStripMenuItem, Me.OnlyNoActiveToolStripMenuItem, Me.DiviserParToolStripMenuItem})
        Me.ListeDeLectureM3UToolStripMenuItem.Name = "ListeDeLectureM3UToolStripMenuItem"
        Me.ListeDeLectureM3UToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.ListeDeLectureM3UToolStripMenuItem.Text = "Liste de lecture M3U"
        '
        'FullToolStripMenuItem
        '
        Me.FullToolStripMenuItem.Name = "FullToolStripMenuItem"
        Me.FullToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.FullToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.FullToolStripMenuItem.Text = "Full DataBase"
        '
        'OnlyActiveStripMenuItem
        '
        Me.OnlyActiveStripMenuItem.Name = "OnlyActiveStripMenuItem"
        Me.OnlyActiveStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.OnlyActiveStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.OnlyActiveStripMenuItem.Text = "By Num"
        '
        'OnlyNoActiveToolStripMenuItem
        '
        Me.OnlyNoActiveToolStripMenuItem.Name = "OnlyNoActiveToolStripMenuItem"
        Me.OnlyNoActiveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.OnlyNoActiveToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.OnlyNoActiveToolStripMenuItem.Text = "Only No Active"
        '
        'DiviserParToolStripMenuItem
        '
        Me.DiviserParToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.DiviserParToolStripMenuItem.Name = "DiviserParToolStripMenuItem"
        Me.DiviserParToolStripMenuItem.Size = New System.Drawing.Size(256, 30)
        Me.DiviserParToolStripMenuItem.Text = "Diviser par"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(136, 30)
        Me.ToolStripMenuItem4.Text = "100"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(136, 30)
        Me.ToolStripMenuItem5.Text = "500"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(136, 30)
        Me.ToolStripMenuItem6.Text = "1000"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(136, 30)
        Me.ToolStripMenuItem7.Text = "5000"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(249, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'ScanToolStripMenuItem
        '
        Me.ScanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullScanToolStripMenuItem, Me.ListeScanToolStripMenuItem, Me.ActiveScanToolStripMenuItem, Me.NoActiveScanToolStripMenuItem})
        Me.ScanToolStripMenuItem.Name = "ScanToolStripMenuItem"
        Me.ScanToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.ScanToolStripMenuItem.Text = "&Scan"
        '
        'FullScanToolStripMenuItem
        '
        Me.FullScanToolStripMenuItem.Name = "FullScanToolStripMenuItem"
        Me.FullScanToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.FullScanToolStripMenuItem.Size = New System.Drawing.Size(246, 30)
        Me.FullScanToolStripMenuItem.Text = "Full Scan"
        '
        'ListeScanToolStripMenuItem
        '
        Me.ListeScanToolStripMenuItem.Name = "ListeScanToolStripMenuItem"
        Me.ListeScanToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ListeScanToolStripMenuItem.Size = New System.Drawing.Size(246, 30)
        Me.ListeScanToolStripMenuItem.Text = "Liste Scan"
        '
        'ActiveScanToolStripMenuItem
        '
        Me.ActiveScanToolStripMenuItem.Name = "ActiveScanToolStripMenuItem"
        Me.ActiveScanToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.ActiveScanToolStripMenuItem.Size = New System.Drawing.Size(246, 30)
        Me.ActiveScanToolStripMenuItem.Text = "Active Scan"
        '
        'NoActiveScanToolStripMenuItem
        '
        Me.NoActiveScanToolStripMenuItem.Name = "NoActiveScanToolStripMenuItem"
        Me.NoActiveScanToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.NoActiveScanToolStripMenuItem.Size = New System.Drawing.Size(246, 30)
        Me.NoActiveScanToolStripMenuItem.Text = "No Active Scan"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateListeDesLogosToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.OptionsToolStripMenuItem.Text = "O&ptions"
        '
        'UpdateListeDesLogosToolStripMenuItem
        '
        Me.UpdateListeDesLogosToolStripMenuItem.Name = "UpdateListeDesLogosToolStripMenuItem"
        Me.UpdateListeDesLogosToolStripMenuItem.Size = New System.Drawing.Size(281, 30)
        Me.UpdateListeDesLogosToolStripMenuItem.Text = "Update Liste des Logos"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'VlcControl1
        '
        Me.VlcControl1.BackColor = System.Drawing.Color.Black
        Me.VlcControl1.Location = New System.Drawing.Point(12, 36)
        Me.VlcControl1.Name = "VlcControl1"
        Me.VlcControl1.Size = New System.Drawing.Size(1280, 720)
        Me.VlcControl1.Spu = -1
        Me.VlcControl1.TabIndex = 1
        Me.VlcControl1.Text = "VlcControl1"
        Me.VlcControl1.VlcLibDirectory = Nothing
        Me.VlcControl1.VlcMediaplayerOptions = Nothing
        '
        'BGW
        '
        Me.BGW.WorkerReportsProgress = True
        Me.BGW.WorkerSupportsCancellation = True
        '
        'Btn_StopScan
        '
        Me.Btn_StopScan.Enabled = False
        Me.Btn_StopScan.Location = New System.Drawing.Point(1298, 68)
        Me.Btn_StopScan.Name = "Btn_StopScan"
        Me.Btn_StopScan.Size = New System.Drawing.Size(151, 54)
        Me.Btn_StopScan.TabIndex = 2
        Me.Btn_StopScan.Text = "Stop Scan"
        Me.Btn_StopScan.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatutBar_InfoBGW, Me.StatutBar_NoCanal, Me.StatutBarProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1402)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(2079, 46)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatutBar_InfoBGW
        '
        Me.StatutBar_InfoBGW.AutoSize = False
        Me.StatutBar_InfoBGW.BackColor = System.Drawing.Color.Black
        Me.StatutBar_InfoBGW.Name = "StatutBar_InfoBGW"
        Me.StatutBar_InfoBGW.Size = New System.Drawing.Size(50, 41)
        '
        'StatutBar_NoCanal
        '
        Me.StatutBar_NoCanal.AutoSize = False
        Me.StatutBar_NoCanal.BackColor = System.Drawing.Color.Black
        Me.StatutBar_NoCanal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatutBar_NoCanal.Name = "StatutBar_NoCanal"
        Me.StatutBar_NoCanal.Size = New System.Drawing.Size(100, 41)
        Me.StatutBar_NoCanal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatutBarProgress
        '
        Me.StatutBarProgress.AutoSize = False
        Me.StatutBarProgress.BackColor = System.Drawing.SystemColors.Control
        Me.StatutBarProgress.Name = "StatutBarProgress"
        Me.StatutBarProgress.Size = New System.Drawing.Size(1000, 40)
        Me.StatutBarProgress.Step = 1
        Me.StatutBarProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(1510, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(562, 1304)
        Me.ListBox1.TabIndex = 4
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(1298, 36)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(151, 26)
        Me.NumericUpDown1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabGeneral)
        Me.TabControl1.Controls.Add(Me.TabBDD)
        Me.TabControl1.Location = New System.Drawing.Point(12, 777)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1280, 559)
        Me.TabControl1.TabIndex = 6
        '
        'TabGeneral
        '
        Me.TabGeneral.BackColor = System.Drawing.Color.Transparent
        Me.TabGeneral.Controls.Add(Me.GroupBox_Sub2)
        Me.TabGeneral.Controls.Add(Me.GroupBox_Sub1)
        Me.TabGeneral.Controls.Add(Me.GroupBox_Audio2)
        Me.TabGeneral.Controls.Add(Me.GroupBox_Audio1)
        Me.TabGeneral.Controls.Add(Me.GroupBox_Video)
        Me.TabGeneral.Controls.Add(Me.lbl_NameChannel)
        Me.TabGeneral.Location = New System.Drawing.Point(4, 29)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGeneral.Size = New System.Drawing.Size(1272, 526)
        Me.TabGeneral.TabIndex = 0
        Me.TabGeneral.Text = "Général"
        '
        'GroupBox_Sub2
        '
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubDesc2Val)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubDesc2)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubOriginalCodec2Val)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubOriginalCodec2)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubName2Val)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubName2)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubID2Val)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubID2)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubLang2Val)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubLang2)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubCodec2Val)
        Me.GroupBox_Sub2.Controls.Add(Me.lbl_SubCodec2)
        Me.GroupBox_Sub2.Location = New System.Drawing.Point(602, 260)
        Me.GroupBox_Sub2.Name = "GroupBox_Sub2"
        Me.GroupBox_Sub2.Size = New System.Drawing.Size(550, 166)
        Me.GroupBox_Sub2.TabIndex = 16
        Me.GroupBox_Sub2.TabStop = False
        Me.GroupBox_Sub2.Text = "Sous-Titre 2"
        '
        'lbl_SubDesc2Val
        '
        Me.lbl_SubDesc2Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubDesc2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubDesc2Val.Location = New System.Drawing.Point(110, 96)
        Me.lbl_SubDesc2Val.Name = "lbl_SubDesc2Val"
        Me.lbl_SubDesc2Val.Size = New System.Drawing.Size(400, 20)
        Me.lbl_SubDesc2Val.TabIndex = 15
        Me.lbl_SubDesc2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubDesc2
        '
        Me.lbl_SubDesc2.AutoSize = True
        Me.lbl_SubDesc2.Location = New System.Drawing.Point(6, 96)
        Me.lbl_SubDesc2.Name = "lbl_SubDesc2"
        Me.lbl_SubDesc2.Size = New System.Drawing.Size(101, 20)
        Me.lbl_SubDesc2.TabIndex = 14
        Me.lbl_SubDesc2.Text = "Description : "
        '
        'lbl_SubOriginalCodec2Val
        '
        Me.lbl_SubOriginalCodec2Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubOriginalCodec2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubOriginalCodec2Val.Location = New System.Drawing.Point(128, 130)
        Me.lbl_SubOriginalCodec2Val.Name = "lbl_SubOriginalCodec2Val"
        Me.lbl_SubOriginalCodec2Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_SubOriginalCodec2Val.TabIndex = 13
        Me.lbl_SubOriginalCodec2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubOriginalCodec2
        '
        Me.lbl_SubOriginalCodec2.AutoSize = True
        Me.lbl_SubOriginalCodec2.Location = New System.Drawing.Point(6, 130)
        Me.lbl_SubOriginalCodec2.Name = "lbl_SubOriginalCodec2"
        Me.lbl_SubOriginalCodec2.Size = New System.Drawing.Size(124, 20)
        Me.lbl_SubOriginalCodec2.TabIndex = 12
        Me.lbl_SubOriginalCodec2.Text = "Codec Original : "
        '
        'lbl_SubName2Val
        '
        Me.lbl_SubName2Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubName2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubName2Val.Location = New System.Drawing.Point(176, 22)
        Me.lbl_SubName2Val.Name = "lbl_SubName2Val"
        Me.lbl_SubName2Val.Size = New System.Drawing.Size(350, 20)
        Me.lbl_SubName2Val.TabIndex = 11
        Me.lbl_SubName2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubName2
        '
        Me.lbl_SubName2.AutoSize = True
        Me.lbl_SubName2.Location = New System.Drawing.Point(116, 22)
        Me.lbl_SubName2.Name = "lbl_SubName2"
        Me.lbl_SubName2.Size = New System.Drawing.Size(54, 20)
        Me.lbl_SubName2.TabIndex = 10
        Me.lbl_SubName2.Text = "Nom : "
        '
        'lbl_SubID2Val
        '
        Me.lbl_SubID2Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubID2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubID2Val.Location = New System.Drawing.Point(38, 22)
        Me.lbl_SubID2Val.Name = "lbl_SubID2Val"
        Me.lbl_SubID2Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_SubID2Val.TabIndex = 9
        Me.lbl_SubID2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubID2
        '
        Me.lbl_SubID2.AutoSize = True
        Me.lbl_SubID2.Location = New System.Drawing.Point(6, 22)
        Me.lbl_SubID2.Name = "lbl_SubID2"
        Me.lbl_SubID2.Size = New System.Drawing.Size(38, 20)
        Me.lbl_SubID2.TabIndex = 8
        Me.lbl_SubID2.Text = "ID : "
        '
        'lbl_SubLang2Val
        '
        Me.lbl_SubLang2Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubLang2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubLang2Val.Location = New System.Drawing.Point(219, 58)
        Me.lbl_SubLang2Val.Name = "lbl_SubLang2Val"
        Me.lbl_SubLang2Val.Size = New System.Drawing.Size(80, 20)
        Me.lbl_SubLang2Val.TabIndex = 5
        Me.lbl_SubLang2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubLang2
        '
        Me.lbl_SubLang2.AutoSize = True
        Me.lbl_SubLang2.Location = New System.Drawing.Point(136, 58)
        Me.lbl_SubLang2.Name = "lbl_SubLang2"
        Me.lbl_SubLang2.Size = New System.Drawing.Size(75, 20)
        Me.lbl_SubLang2.TabIndex = 4
        Me.lbl_SubLang2.Text = "Langue : "
        '
        'lbl_SubCodec2Val
        '
        Me.lbl_SubCodec2Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubCodec2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubCodec2Val.Location = New System.Drawing.Point(70, 58)
        Me.lbl_SubCodec2Val.Name = "lbl_SubCodec2Val"
        Me.lbl_SubCodec2Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_SubCodec2Val.TabIndex = 1
        Me.lbl_SubCodec2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubCodec2
        '
        Me.lbl_SubCodec2.AutoSize = True
        Me.lbl_SubCodec2.Location = New System.Drawing.Point(6, 58)
        Me.lbl_SubCodec2.Name = "lbl_SubCodec2"
        Me.lbl_SubCodec2.Size = New System.Drawing.Size(67, 20)
        Me.lbl_SubCodec2.TabIndex = 0
        Me.lbl_SubCodec2.Text = "Codec : "
        '
        'GroupBox_Sub1
        '
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubOriginalCodec1Val)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubOriginalCodec1)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubName1Val)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubName1)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubID1Val)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubID1)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubDesc1Val)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubDesc1)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubLang1Val)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubLang1)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubCodec1Val)
        Me.GroupBox_Sub1.Controls.Add(Me.lbl_SubCodec1)
        Me.GroupBox_Sub1.Location = New System.Drawing.Point(17, 260)
        Me.GroupBox_Sub1.Name = "GroupBox_Sub1"
        Me.GroupBox_Sub1.Size = New System.Drawing.Size(550, 166)
        Me.GroupBox_Sub1.TabIndex = 15
        Me.GroupBox_Sub1.TabStop = False
        Me.GroupBox_Sub1.Text = "Sous-Titre 1"
        '
        'lbl_SubOriginalCodec1Val
        '
        Me.lbl_SubOriginalCodec1Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubOriginalCodec1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubOriginalCodec1Val.Location = New System.Drawing.Point(128, 130)
        Me.lbl_SubOriginalCodec1Val.Name = "lbl_SubOriginalCodec1Val"
        Me.lbl_SubOriginalCodec1Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_SubOriginalCodec1Val.TabIndex = 13
        Me.lbl_SubOriginalCodec1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubOriginalCodec1
        '
        Me.lbl_SubOriginalCodec1.AutoSize = True
        Me.lbl_SubOriginalCodec1.Location = New System.Drawing.Point(6, 130)
        Me.lbl_SubOriginalCodec1.Name = "lbl_SubOriginalCodec1"
        Me.lbl_SubOriginalCodec1.Size = New System.Drawing.Size(124, 20)
        Me.lbl_SubOriginalCodec1.TabIndex = 12
        Me.lbl_SubOriginalCodec1.Text = "Codec Original : "
        '
        'lbl_SubName1Val
        '
        Me.lbl_SubName1Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubName1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubName1Val.Location = New System.Drawing.Point(170, 22)
        Me.lbl_SubName1Val.Name = "lbl_SubName1Val"
        Me.lbl_SubName1Val.Size = New System.Drawing.Size(350, 20)
        Me.lbl_SubName1Val.TabIndex = 11
        Me.lbl_SubName1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubName1
        '
        Me.lbl_SubName1.AutoSize = True
        Me.lbl_SubName1.Location = New System.Drawing.Point(110, 22)
        Me.lbl_SubName1.Name = "lbl_SubName1"
        Me.lbl_SubName1.Size = New System.Drawing.Size(54, 20)
        Me.lbl_SubName1.TabIndex = 10
        Me.lbl_SubName1.Text = "Nom : "
        '
        'lbl_SubID1Val
        '
        Me.lbl_SubID1Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubID1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubID1Val.Location = New System.Drawing.Point(38, 22)
        Me.lbl_SubID1Val.Name = "lbl_SubID1Val"
        Me.lbl_SubID1Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_SubID1Val.TabIndex = 9
        Me.lbl_SubID1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubID1
        '
        Me.lbl_SubID1.AutoSize = True
        Me.lbl_SubID1.Location = New System.Drawing.Point(6, 22)
        Me.lbl_SubID1.Name = "lbl_SubID1"
        Me.lbl_SubID1.Size = New System.Drawing.Size(38, 20)
        Me.lbl_SubID1.TabIndex = 8
        Me.lbl_SubID1.Text = "ID : "
        '
        'lbl_SubDesc1Val
        '
        Me.lbl_SubDesc1Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubDesc1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubDesc1Val.Location = New System.Drawing.Point(110, 96)
        Me.lbl_SubDesc1Val.Name = "lbl_SubDesc1Val"
        Me.lbl_SubDesc1Val.Size = New System.Drawing.Size(400, 20)
        Me.lbl_SubDesc1Val.TabIndex = 7
        Me.lbl_SubDesc1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubDesc1
        '
        Me.lbl_SubDesc1.AutoSize = True
        Me.lbl_SubDesc1.Location = New System.Drawing.Point(6, 96)
        Me.lbl_SubDesc1.Name = "lbl_SubDesc1"
        Me.lbl_SubDesc1.Size = New System.Drawing.Size(101, 20)
        Me.lbl_SubDesc1.TabIndex = 6
        Me.lbl_SubDesc1.Text = "Description : "
        '
        'lbl_SubLang1Val
        '
        Me.lbl_SubLang1Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubLang1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubLang1Val.Location = New System.Drawing.Point(219, 58)
        Me.lbl_SubLang1Val.Name = "lbl_SubLang1Val"
        Me.lbl_SubLang1Val.Size = New System.Drawing.Size(80, 20)
        Me.lbl_SubLang1Val.TabIndex = 5
        Me.lbl_SubLang1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubLang1
        '
        Me.lbl_SubLang1.AutoSize = True
        Me.lbl_SubLang1.Location = New System.Drawing.Point(136, 58)
        Me.lbl_SubLang1.Name = "lbl_SubLang1"
        Me.lbl_SubLang1.Size = New System.Drawing.Size(75, 20)
        Me.lbl_SubLang1.TabIndex = 4
        Me.lbl_SubLang1.Text = "Langue : "
        '
        'lbl_SubCodec1Val
        '
        Me.lbl_SubCodec1Val.BackColor = System.Drawing.Color.White
        Me.lbl_SubCodec1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubCodec1Val.Location = New System.Drawing.Point(70, 58)
        Me.lbl_SubCodec1Val.Name = "lbl_SubCodec1Val"
        Me.lbl_SubCodec1Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_SubCodec1Val.TabIndex = 1
        Me.lbl_SubCodec1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SubCodec1
        '
        Me.lbl_SubCodec1.AutoSize = True
        Me.lbl_SubCodec1.Location = New System.Drawing.Point(6, 58)
        Me.lbl_SubCodec1.Name = "lbl_SubCodec1"
        Me.lbl_SubCodec1.Size = New System.Drawing.Size(67, 20)
        Me.lbl_SubCodec1.TabIndex = 0
        Me.lbl_SubCodec1.Text = "Codec : "
        '
        'GroupBox_Audio2
        '
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioOriginalCodec2Val)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioOriginalCodec2)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioName2Val)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioName2)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioID2Val)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioID2)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioChannel2Val)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioChannel2)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioLang2Val)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioLang2)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioRate2Val)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioRate2)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioCodec2Val)
        Me.GroupBox_Audio2.Controls.Add(Me.lbl_AudioCodec2)
        Me.GroupBox_Audio2.Location = New System.Drawing.Point(839, 88)
        Me.GroupBox_Audio2.Name = "GroupBox_Audio2"
        Me.GroupBox_Audio2.Size = New System.Drawing.Size(387, 166)
        Me.GroupBox_Audio2.TabIndex = 15
        Me.GroupBox_Audio2.TabStop = False
        Me.GroupBox_Audio2.Text = "Audio 2"
        '
        'lbl_AudioOriginalCodec2Val
        '
        Me.lbl_AudioOriginalCodec2Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioOriginalCodec2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioOriginalCodec2Val.Location = New System.Drawing.Point(128, 130)
        Me.lbl_AudioOriginalCodec2Val.Name = "lbl_AudioOriginalCodec2Val"
        Me.lbl_AudioOriginalCodec2Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_AudioOriginalCodec2Val.TabIndex = 13
        Me.lbl_AudioOriginalCodec2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioOriginalCodec2
        '
        Me.lbl_AudioOriginalCodec2.AutoSize = True
        Me.lbl_AudioOriginalCodec2.Location = New System.Drawing.Point(6, 130)
        Me.lbl_AudioOriginalCodec2.Name = "lbl_AudioOriginalCodec2"
        Me.lbl_AudioOriginalCodec2.Size = New System.Drawing.Size(124, 20)
        Me.lbl_AudioOriginalCodec2.TabIndex = 12
        Me.lbl_AudioOriginalCodec2.Text = "Codec Original : "
        '
        'lbl_AudioName2Val
        '
        Me.lbl_AudioName2Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioName2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioName2Val.Location = New System.Drawing.Point(170, 22)
        Me.lbl_AudioName2Val.Name = "lbl_AudioName2Val"
        Me.lbl_AudioName2Val.Size = New System.Drawing.Size(200, 20)
        Me.lbl_AudioName2Val.TabIndex = 11
        Me.lbl_AudioName2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioName2
        '
        Me.lbl_AudioName2.AutoSize = True
        Me.lbl_AudioName2.Location = New System.Drawing.Point(110, 22)
        Me.lbl_AudioName2.Name = "lbl_AudioName2"
        Me.lbl_AudioName2.Size = New System.Drawing.Size(54, 20)
        Me.lbl_AudioName2.TabIndex = 10
        Me.lbl_AudioName2.Text = "Nom : "
        '
        'lbl_AudioID2Val
        '
        Me.lbl_AudioID2Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioID2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioID2Val.Location = New System.Drawing.Point(38, 22)
        Me.lbl_AudioID2Val.Name = "lbl_AudioID2Val"
        Me.lbl_AudioID2Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_AudioID2Val.TabIndex = 9
        Me.lbl_AudioID2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioID2
        '
        Me.lbl_AudioID2.AutoSize = True
        Me.lbl_AudioID2.Location = New System.Drawing.Point(6, 22)
        Me.lbl_AudioID2.Name = "lbl_AudioID2"
        Me.lbl_AudioID2.Size = New System.Drawing.Size(38, 20)
        Me.lbl_AudioID2.TabIndex = 8
        Me.lbl_AudioID2.Text = "ID : "
        '
        'lbl_AudioChannel2Val
        '
        Me.lbl_AudioChannel2Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioChannel2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioChannel2Val.Location = New System.Drawing.Point(99, 96)
        Me.lbl_AudioChannel2Val.Name = "lbl_AudioChannel2Val"
        Me.lbl_AudioChannel2Val.Size = New System.Drawing.Size(40, 20)
        Me.lbl_AudioChannel2Val.TabIndex = 7
        Me.lbl_AudioChannel2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioChannel2
        '
        Me.lbl_AudioChannel2.AutoSize = True
        Me.lbl_AudioChannel2.Location = New System.Drawing.Point(6, 96)
        Me.lbl_AudioChannel2.Name = "lbl_AudioChannel2"
        Me.lbl_AudioChannel2.Size = New System.Drawing.Size(75, 20)
        Me.lbl_AudioChannel2.TabIndex = 6
        Me.lbl_AudioChannel2.Text = "Canaux : "
        '
        'lbl_AudioLang2Val
        '
        Me.lbl_AudioLang2Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioLang2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioLang2Val.Location = New System.Drawing.Point(219, 58)
        Me.lbl_AudioLang2Val.Name = "lbl_AudioLang2Val"
        Me.lbl_AudioLang2Val.Size = New System.Drawing.Size(80, 20)
        Me.lbl_AudioLang2Val.TabIndex = 5
        Me.lbl_AudioLang2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioLang2
        '
        Me.lbl_AudioLang2.AutoSize = True
        Me.lbl_AudioLang2.Location = New System.Drawing.Point(136, 58)
        Me.lbl_AudioLang2.Name = "lbl_AudioLang2"
        Me.lbl_AudioLang2.Size = New System.Drawing.Size(75, 20)
        Me.lbl_AudioLang2.TabIndex = 4
        Me.lbl_AudioLang2.Text = "Langue : "
        '
        'lbl_AudioRate2Val
        '
        Me.lbl_AudioRate2Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioRate2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioRate2Val.Location = New System.Drawing.Point(199, 96)
        Me.lbl_AudioRate2Val.Name = "lbl_AudioRate2Val"
        Me.lbl_AudioRate2Val.Size = New System.Drawing.Size(100, 20)
        Me.lbl_AudioRate2Val.TabIndex = 3
        Me.lbl_AudioRate2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioRate2
        '
        Me.lbl_AudioRate2.AutoSize = True
        Me.lbl_AudioRate2.Location = New System.Drawing.Point(145, 96)
        Me.lbl_AudioRate2.Name = "lbl_AudioRate2"
        Me.lbl_AudioRate2.Size = New System.Drawing.Size(56, 20)
        Me.lbl_AudioRate2.TabIndex = 2
        Me.lbl_AudioRate2.Text = "Rate : "
        '
        'lbl_AudioCodec2Val
        '
        Me.lbl_AudioCodec2Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioCodec2Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioCodec2Val.Location = New System.Drawing.Point(70, 58)
        Me.lbl_AudioCodec2Val.Name = "lbl_AudioCodec2Val"
        Me.lbl_AudioCodec2Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_AudioCodec2Val.TabIndex = 1
        Me.lbl_AudioCodec2Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioCodec2
        '
        Me.lbl_AudioCodec2.AutoSize = True
        Me.lbl_AudioCodec2.Location = New System.Drawing.Point(6, 58)
        Me.lbl_AudioCodec2.Name = "lbl_AudioCodec2"
        Me.lbl_AudioCodec2.Size = New System.Drawing.Size(67, 20)
        Me.lbl_AudioCodec2.TabIndex = 0
        Me.lbl_AudioCodec2.Text = "Codec : "
        '
        'GroupBox_Audio1
        '
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioOriginalCodec1Val)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioOrigionalCodec1)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioName1Val)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioName1)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioID1Val)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioID1)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioChannel1Val)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioChannel1)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioLang1Val)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioLang1)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioRate1Val)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioRate1)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioCodec1Val)
        Me.GroupBox_Audio1.Controls.Add(Me.lbl_AudioCodec1)
        Me.GroupBox_Audio1.Location = New System.Drawing.Point(428, 88)
        Me.GroupBox_Audio1.Name = "GroupBox_Audio1"
        Me.GroupBox_Audio1.Size = New System.Drawing.Size(387, 166)
        Me.GroupBox_Audio1.TabIndex = 14
        Me.GroupBox_Audio1.TabStop = False
        Me.GroupBox_Audio1.Text = "Audio 1"
        '
        'lbl_AudioOriginalCodec1Val
        '
        Me.lbl_AudioOriginalCodec1Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioOriginalCodec1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioOriginalCodec1Val.Location = New System.Drawing.Point(128, 130)
        Me.lbl_AudioOriginalCodec1Val.Name = "lbl_AudioOriginalCodec1Val"
        Me.lbl_AudioOriginalCodec1Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_AudioOriginalCodec1Val.TabIndex = 13
        Me.lbl_AudioOriginalCodec1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioOrigionalCodec1
        '
        Me.lbl_AudioOrigionalCodec1.AutoSize = True
        Me.lbl_AudioOrigionalCodec1.Location = New System.Drawing.Point(6, 130)
        Me.lbl_AudioOrigionalCodec1.Name = "lbl_AudioOrigionalCodec1"
        Me.lbl_AudioOrigionalCodec1.Size = New System.Drawing.Size(124, 20)
        Me.lbl_AudioOrigionalCodec1.TabIndex = 12
        Me.lbl_AudioOrigionalCodec1.Text = "Codec Original : "
        '
        'lbl_AudioName1Val
        '
        Me.lbl_AudioName1Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioName1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioName1Val.Location = New System.Drawing.Point(170, 22)
        Me.lbl_AudioName1Val.Name = "lbl_AudioName1Val"
        Me.lbl_AudioName1Val.Size = New System.Drawing.Size(200, 20)
        Me.lbl_AudioName1Val.TabIndex = 11
        Me.lbl_AudioName1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioName1
        '
        Me.lbl_AudioName1.AutoSize = True
        Me.lbl_AudioName1.Location = New System.Drawing.Point(110, 22)
        Me.lbl_AudioName1.Name = "lbl_AudioName1"
        Me.lbl_AudioName1.Size = New System.Drawing.Size(54, 20)
        Me.lbl_AudioName1.TabIndex = 10
        Me.lbl_AudioName1.Text = "Nom : "
        '
        'lbl_AudioID1Val
        '
        Me.lbl_AudioID1Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioID1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioID1Val.Location = New System.Drawing.Point(38, 22)
        Me.lbl_AudioID1Val.Name = "lbl_AudioID1Val"
        Me.lbl_AudioID1Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_AudioID1Val.TabIndex = 9
        Me.lbl_AudioID1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioID1
        '
        Me.lbl_AudioID1.AutoSize = True
        Me.lbl_AudioID1.Location = New System.Drawing.Point(6, 22)
        Me.lbl_AudioID1.Name = "lbl_AudioID1"
        Me.lbl_AudioID1.Size = New System.Drawing.Size(38, 20)
        Me.lbl_AudioID1.TabIndex = 8
        Me.lbl_AudioID1.Text = "ID : "
        '
        'lbl_AudioChannel1Val
        '
        Me.lbl_AudioChannel1Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioChannel1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioChannel1Val.Location = New System.Drawing.Point(99, 96)
        Me.lbl_AudioChannel1Val.Name = "lbl_AudioChannel1Val"
        Me.lbl_AudioChannel1Val.Size = New System.Drawing.Size(40, 20)
        Me.lbl_AudioChannel1Val.TabIndex = 7
        Me.lbl_AudioChannel1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioChannel1
        '
        Me.lbl_AudioChannel1.AutoSize = True
        Me.lbl_AudioChannel1.Location = New System.Drawing.Point(6, 96)
        Me.lbl_AudioChannel1.Name = "lbl_AudioChannel1"
        Me.lbl_AudioChannel1.Size = New System.Drawing.Size(75, 20)
        Me.lbl_AudioChannel1.TabIndex = 6
        Me.lbl_AudioChannel1.Text = "Canaux : "
        '
        'lbl_AudioLang1Val
        '
        Me.lbl_AudioLang1Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioLang1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioLang1Val.Location = New System.Drawing.Point(219, 58)
        Me.lbl_AudioLang1Val.Name = "lbl_AudioLang1Val"
        Me.lbl_AudioLang1Val.Size = New System.Drawing.Size(80, 20)
        Me.lbl_AudioLang1Val.TabIndex = 5
        Me.lbl_AudioLang1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioLang1
        '
        Me.lbl_AudioLang1.AutoSize = True
        Me.lbl_AudioLang1.Location = New System.Drawing.Point(136, 58)
        Me.lbl_AudioLang1.Name = "lbl_AudioLang1"
        Me.lbl_AudioLang1.Size = New System.Drawing.Size(75, 20)
        Me.lbl_AudioLang1.TabIndex = 4
        Me.lbl_AudioLang1.Text = "Langue : "
        '
        'lbl_AudioRate1Val
        '
        Me.lbl_AudioRate1Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioRate1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioRate1Val.Location = New System.Drawing.Point(199, 96)
        Me.lbl_AudioRate1Val.Name = "lbl_AudioRate1Val"
        Me.lbl_AudioRate1Val.Size = New System.Drawing.Size(100, 20)
        Me.lbl_AudioRate1Val.TabIndex = 3
        Me.lbl_AudioRate1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioRate1
        '
        Me.lbl_AudioRate1.AutoSize = True
        Me.lbl_AudioRate1.Location = New System.Drawing.Point(145, 96)
        Me.lbl_AudioRate1.Name = "lbl_AudioRate1"
        Me.lbl_AudioRate1.Size = New System.Drawing.Size(56, 20)
        Me.lbl_AudioRate1.TabIndex = 2
        Me.lbl_AudioRate1.Text = "Rate : "
        '
        'lbl_AudioCodec1Val
        '
        Me.lbl_AudioCodec1Val.BackColor = System.Drawing.Color.White
        Me.lbl_AudioCodec1Val.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AudioCodec1Val.Location = New System.Drawing.Point(70, 58)
        Me.lbl_AudioCodec1Val.Name = "lbl_AudioCodec1Val"
        Me.lbl_AudioCodec1Val.Size = New System.Drawing.Size(60, 20)
        Me.lbl_AudioCodec1Val.TabIndex = 1
        Me.lbl_AudioCodec1Val.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_AudioCodec1
        '
        Me.lbl_AudioCodec1.AutoSize = True
        Me.lbl_AudioCodec1.Location = New System.Drawing.Point(6, 58)
        Me.lbl_AudioCodec1.Name = "lbl_AudioCodec1"
        Me.lbl_AudioCodec1.Size = New System.Drawing.Size(67, 20)
        Me.lbl_AudioCodec1.TabIndex = 0
        Me.lbl_AudioCodec1.Text = "Codec : "
        '
        'GroupBox_Video
        '
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoOriginalCodecVal)
        Me.GroupBox_Video.Controls.Add(Me.Lbl_VideoOriginalCodec)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoNameVal)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoName)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoIDVal)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoID)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoResVal)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoRes)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoDefVal)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoDef)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoFPSVal)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoFPS)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoCodecVal)
        Me.GroupBox_Video.Controls.Add(Me.lbl_VideoCodec)
        Me.GroupBox_Video.Location = New System.Drawing.Point(17, 88)
        Me.GroupBox_Video.Name = "GroupBox_Video"
        Me.GroupBox_Video.Size = New System.Drawing.Size(387, 166)
        Me.GroupBox_Video.TabIndex = 1
        Me.GroupBox_Video.TabStop = False
        Me.GroupBox_Video.Text = "Vidéo"
        '
        'lbl_VideoOriginalCodecVal
        '
        Me.lbl_VideoOriginalCodecVal.BackColor = System.Drawing.Color.White
        Me.lbl_VideoOriginalCodecVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VideoOriginalCodecVal.Location = New System.Drawing.Point(128, 130)
        Me.lbl_VideoOriginalCodecVal.Name = "lbl_VideoOriginalCodecVal"
        Me.lbl_VideoOriginalCodecVal.Size = New System.Drawing.Size(60, 20)
        Me.lbl_VideoOriginalCodecVal.TabIndex = 13
        Me.lbl_VideoOriginalCodecVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_VideoOriginalCodec
        '
        Me.Lbl_VideoOriginalCodec.AutoSize = True
        Me.Lbl_VideoOriginalCodec.Location = New System.Drawing.Point(6, 130)
        Me.Lbl_VideoOriginalCodec.Name = "Lbl_VideoOriginalCodec"
        Me.Lbl_VideoOriginalCodec.Size = New System.Drawing.Size(124, 20)
        Me.Lbl_VideoOriginalCodec.TabIndex = 12
        Me.Lbl_VideoOriginalCodec.Text = "Codec Original : "
        '
        'lbl_VideoNameVal
        '
        Me.lbl_VideoNameVal.BackColor = System.Drawing.Color.White
        Me.lbl_VideoNameVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VideoNameVal.Location = New System.Drawing.Point(170, 22)
        Me.lbl_VideoNameVal.Name = "lbl_VideoNameVal"
        Me.lbl_VideoNameVal.Size = New System.Drawing.Size(200, 20)
        Me.lbl_VideoNameVal.TabIndex = 11
        Me.lbl_VideoNameVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_VideoName
        '
        Me.lbl_VideoName.AutoSize = True
        Me.lbl_VideoName.Location = New System.Drawing.Point(110, 22)
        Me.lbl_VideoName.Name = "lbl_VideoName"
        Me.lbl_VideoName.Size = New System.Drawing.Size(54, 20)
        Me.lbl_VideoName.TabIndex = 10
        Me.lbl_VideoName.Text = "Nom : "
        '
        'lbl_VideoIDVal
        '
        Me.lbl_VideoIDVal.BackColor = System.Drawing.Color.White
        Me.lbl_VideoIDVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VideoIDVal.Location = New System.Drawing.Point(38, 22)
        Me.lbl_VideoIDVal.Name = "lbl_VideoIDVal"
        Me.lbl_VideoIDVal.Size = New System.Drawing.Size(60, 20)
        Me.lbl_VideoIDVal.TabIndex = 9
        Me.lbl_VideoIDVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_VideoID
        '
        Me.lbl_VideoID.AutoSize = True
        Me.lbl_VideoID.Location = New System.Drawing.Point(6, 22)
        Me.lbl_VideoID.Name = "lbl_VideoID"
        Me.lbl_VideoID.Size = New System.Drawing.Size(38, 20)
        Me.lbl_VideoID.TabIndex = 8
        Me.lbl_VideoID.Text = "ID : "
        '
        'lbl_VideoResVal
        '
        Me.lbl_VideoResVal.BackColor = System.Drawing.Color.White
        Me.lbl_VideoResVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VideoResVal.Location = New System.Drawing.Point(229, 58)
        Me.lbl_VideoResVal.Name = "lbl_VideoResVal"
        Me.lbl_VideoResVal.Size = New System.Drawing.Size(150, 20)
        Me.lbl_VideoResVal.TabIndex = 7
        Me.lbl_VideoResVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_VideoRes
        '
        Me.lbl_VideoRes.AutoSize = True
        Me.lbl_VideoRes.Location = New System.Drawing.Point(136, 58)
        Me.lbl_VideoRes.Name = "lbl_VideoRes"
        Me.lbl_VideoRes.Size = New System.Drawing.Size(97, 20)
        Me.lbl_VideoRes.TabIndex = 6
        Me.lbl_VideoRes.Text = "Resolution : "
        '
        'lbl_VideoDefVal
        '
        Me.lbl_VideoDefVal.BackColor = System.Drawing.Color.White
        Me.lbl_VideoDefVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VideoDefVal.Location = New System.Drawing.Point(242, 96)
        Me.lbl_VideoDefVal.Name = "lbl_VideoDefVal"
        Me.lbl_VideoDefVal.Size = New System.Drawing.Size(80, 20)
        Me.lbl_VideoDefVal.TabIndex = 5
        Me.lbl_VideoDefVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_VideoDef
        '
        Me.lbl_VideoDef.AutoSize = True
        Me.lbl_VideoDef.Location = New System.Drawing.Point(159, 96)
        Me.lbl_VideoDef.Name = "lbl_VideoDef"
        Me.lbl_VideoDef.Size = New System.Drawing.Size(88, 20)
        Me.lbl_VideoDef.TabIndex = 4
        Me.lbl_VideoDef.Text = "Definition : "
        '
        'lbl_VideoFPSVal
        '
        Me.lbl_VideoFPSVal.BackColor = System.Drawing.Color.White
        Me.lbl_VideoFPSVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VideoFPSVal.Location = New System.Drawing.Point(53, 96)
        Me.lbl_VideoFPSVal.Name = "lbl_VideoFPSVal"
        Me.lbl_VideoFPSVal.Size = New System.Drawing.Size(100, 20)
        Me.lbl_VideoFPSVal.TabIndex = 3
        Me.lbl_VideoFPSVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_VideoFPS
        '
        Me.lbl_VideoFPS.AutoSize = True
        Me.lbl_VideoFPS.Location = New System.Drawing.Point(6, 96)
        Me.lbl_VideoFPS.Name = "lbl_VideoFPS"
        Me.lbl_VideoFPS.Size = New System.Drawing.Size(52, 20)
        Me.lbl_VideoFPS.TabIndex = 2
        Me.lbl_VideoFPS.Text = "FPS : "
        '
        'lbl_VideoCodecVal
        '
        Me.lbl_VideoCodecVal.BackColor = System.Drawing.Color.White
        Me.lbl_VideoCodecVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VideoCodecVal.Location = New System.Drawing.Point(70, 58)
        Me.lbl_VideoCodecVal.Name = "lbl_VideoCodecVal"
        Me.lbl_VideoCodecVal.Size = New System.Drawing.Size(60, 20)
        Me.lbl_VideoCodecVal.TabIndex = 1
        Me.lbl_VideoCodecVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_VideoCodec
        '
        Me.lbl_VideoCodec.AutoSize = True
        Me.lbl_VideoCodec.Location = New System.Drawing.Point(6, 58)
        Me.lbl_VideoCodec.Name = "lbl_VideoCodec"
        Me.lbl_VideoCodec.Size = New System.Drawing.Size(67, 20)
        Me.lbl_VideoCodec.TabIndex = 0
        Me.lbl_VideoCodec.Text = "Codec : "
        '
        'lbl_NameChannel
        '
        Me.lbl_NameChannel.BackColor = System.Drawing.Color.Black
        Me.lbl_NameChannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_NameChannel.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NameChannel.ForeColor = System.Drawing.Color.Lime
        Me.lbl_NameChannel.Location = New System.Drawing.Point(6, 12)
        Me.lbl_NameChannel.Name = "lbl_NameChannel"
        Me.lbl_NameChannel.Size = New System.Drawing.Size(1249, 61)
        Me.lbl_NameChannel.TabIndex = 0
        Me.lbl_NameChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabBDD
        '
        Me.TabBDD.Controls.Add(Me.txt_RDescription)
        Me.TabBDD.Controls.Add(Me.PictureBox_RLinkImg)
        Me.TabBDD.Controls.Add(Me.lbl_RCategorie)
        Me.TabBDD.Controls.Add(Me.lbl_RPays)
        Me.TabBDD.Controls.Add(Me.lbl_RGroupChannel)
        Me.TabBDD.Controls.Add(Me.Lbl_RTimeShift)
        Me.TabBDD.Controls.Add(Me.lbl_RNomEPG)
        Me.TabBDD.Controls.Add(Me.lbl_RNoChaine)
        Me.TabBDD.Controls.Add(Me.lbl_RNoCanal)
        Me.TabBDD.Controls.Add(Me.lbl_RNomChaine)
        Me.TabBDD.Location = New System.Drawing.Point(4, 29)
        Me.TabBDD.Name = "TabBDD"
        Me.TabBDD.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBDD.Size = New System.Drawing.Size(1272, 526)
        Me.TabBDD.TabIndex = 1
        Me.TabBDD.Text = "Base de données"
        Me.TabBDD.UseVisualStyleBackColor = True
        '
        'txt_RDescription
        '
        Me.txt_RDescription.AcceptsReturn = True
        Me.txt_RDescription.AcceptsTab = True
        Me.txt_RDescription.BackColor = System.Drawing.Color.Black
        Me.txt_RDescription.ForeColor = System.Drawing.Color.Lime
        Me.txt_RDescription.Location = New System.Drawing.Point(6, 250)
        Me.txt_RDescription.Multiline = True
        Me.txt_RDescription.Name = "txt_RDescription"
        Me.txt_RDescription.ReadOnly = True
        Me.txt_RDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_RDescription.Size = New System.Drawing.Size(888, 270)
        Me.txt_RDescription.TabIndex = 11
        '
        'PictureBox_RLinkImg
        '
        Me.PictureBox_RLinkImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_RLinkImg.Location = New System.Drawing.Point(900, 250)
        Me.PictureBox_RLinkImg.Name = "PictureBox_RLinkImg"
        Me.PictureBox_RLinkImg.Size = New System.Drawing.Size(366, 273)
        Me.PictureBox_RLinkImg.TabIndex = 10
        Me.PictureBox_RLinkImg.TabStop = False
        '
        'lbl_RCategorie
        '
        Me.lbl_RCategorie.BackColor = System.Drawing.Color.Black
        Me.lbl_RCategorie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_RCategorie.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RCategorie.ForeColor = System.Drawing.Color.Lime
        Me.lbl_RCategorie.Location = New System.Drawing.Point(506, 186)
        Me.lbl_RCategorie.Name = "lbl_RCategorie"
        Me.lbl_RCategorie.Size = New System.Drawing.Size(760, 61)
        Me.lbl_RCategorie.TabIndex = 8
        Me.lbl_RCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_RPays
        '
        Me.lbl_RPays.BackColor = System.Drawing.Color.Black
        Me.lbl_RPays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_RPays.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RPays.ForeColor = System.Drawing.Color.Lime
        Me.lbl_RPays.Location = New System.Drawing.Point(6, 186)
        Me.lbl_RPays.Name = "lbl_RPays"
        Me.lbl_RPays.Size = New System.Drawing.Size(494, 61)
        Me.lbl_RPays.TabIndex = 7
        Me.lbl_RPays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_RGroupChannel
        '
        Me.lbl_RGroupChannel.BackColor = System.Drawing.Color.Black
        Me.lbl_RGroupChannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_RGroupChannel.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RGroupChannel.ForeColor = System.Drawing.Color.Lime
        Me.lbl_RGroupChannel.Location = New System.Drawing.Point(258, 125)
        Me.lbl_RGroupChannel.Name = "lbl_RGroupChannel"
        Me.lbl_RGroupChannel.Size = New System.Drawing.Size(1008, 61)
        Me.lbl_RGroupChannel.TabIndex = 6
        Me.lbl_RGroupChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_RTimeShift
        '
        Me.Lbl_RTimeShift.BackColor = System.Drawing.Color.Black
        Me.Lbl_RTimeShift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_RTimeShift.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RTimeShift.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_RTimeShift.Location = New System.Drawing.Point(6, 125)
        Me.Lbl_RTimeShift.Name = "Lbl_RTimeShift"
        Me.Lbl_RTimeShift.Size = New System.Drawing.Size(246, 61)
        Me.Lbl_RTimeShift.TabIndex = 5
        Me.Lbl_RTimeShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_RNomEPG
        '
        Me.lbl_RNomEPG.BackColor = System.Drawing.Color.Black
        Me.lbl_RNomEPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_RNomEPG.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RNomEPG.ForeColor = System.Drawing.Color.Lime
        Me.lbl_RNomEPG.Location = New System.Drawing.Point(258, 64)
        Me.lbl_RNomEPG.Name = "lbl_RNomEPG"
        Me.lbl_RNomEPG.Size = New System.Drawing.Size(1008, 61)
        Me.lbl_RNomEPG.TabIndex = 4
        Me.lbl_RNomEPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_RNoChaine
        '
        Me.lbl_RNoChaine.BackColor = System.Drawing.Color.Black
        Me.lbl_RNoChaine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_RNoChaine.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RNoChaine.ForeColor = System.Drawing.Color.Lime
        Me.lbl_RNoChaine.Location = New System.Drawing.Point(6, 64)
        Me.lbl_RNoChaine.Name = "lbl_RNoChaine"
        Me.lbl_RNoChaine.Size = New System.Drawing.Size(246, 61)
        Me.lbl_RNoChaine.TabIndex = 3
        Me.lbl_RNoChaine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_RNoCanal
        '
        Me.lbl_RNoCanal.BackColor = System.Drawing.Color.Black
        Me.lbl_RNoCanal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_RNoCanal.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RNoCanal.ForeColor = System.Drawing.Color.Lime
        Me.lbl_RNoCanal.Location = New System.Drawing.Point(6, 3)
        Me.lbl_RNoCanal.Name = "lbl_RNoCanal"
        Me.lbl_RNoCanal.Size = New System.Drawing.Size(246, 61)
        Me.lbl_RNoCanal.TabIndex = 2
        Me.lbl_RNoCanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_RNomChaine
        '
        Me.lbl_RNomChaine.BackColor = System.Drawing.Color.Black
        Me.lbl_RNomChaine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_RNomChaine.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RNomChaine.ForeColor = System.Drawing.Color.Lime
        Me.lbl_RNomChaine.Location = New System.Drawing.Point(258, 3)
        Me.lbl_RNomChaine.Name = "lbl_RNomChaine"
        Me.lbl_RNomChaine.Size = New System.Drawing.Size(1008, 61)
        Me.lbl_RNomChaine.TabIndex = 1
        Me.lbl_RNomChaine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox_ShowLogs
        '
        Me.CheckBox_ShowLogs.AutoSize = True
        Me.CheckBox_ShowLogs.Location = New System.Drawing.Point(1298, 128)
        Me.CheckBox_ShowLogs.Name = "CheckBox_ShowLogs"
        Me.CheckBox_ShowLogs.Size = New System.Drawing.Size(129, 24)
        Me.CheckBox_ShowLogs.TabIndex = 8
        Me.CheckBox_ShowLogs.Text = "Afficher Logs"
        Me.CheckBox_ShowLogs.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(2079, 1448)
        Me.Controls.Add(Me.CheckBox_ShowLogs)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Btn_StopScan)
        Me.Controls.Add(Me.VlcControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.VlcControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabGeneral.ResumeLayout(False)
        Me.GroupBox_Sub2.ResumeLayout(False)
        Me.GroupBox_Sub2.PerformLayout()
        Me.GroupBox_Sub1.ResumeLayout(False)
        Me.GroupBox_Sub1.PerformLayout()
        Me.GroupBox_Audio2.ResumeLayout(False)
        Me.GroupBox_Audio2.PerformLayout()
        Me.GroupBox_Audio1.ResumeLayout(False)
        Me.GroupBox_Audio1.PerformLayout()
        Me.GroupBox_Video.ResumeLayout(False)
        Me.GroupBox_Video.PerformLayout()
        Me.TabBDD.ResumeLayout(False)
        Me.TabBDD.PerformLayout()
        CType(Me.PictureBox_RLinkImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichiersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents VlcControl1 As Vlc.DotNet.Forms.VlcControl
    Friend WithEvents ScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FullScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDeLectureM3UToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnlyActiveStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnlyNoActiveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiviserParToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ListeScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActiveScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoActiveScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btn_StopScan As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatutBar_InfoBGW As ToolStripStatusLabel
    Friend WithEvents StatutBar_NoCanal As ToolStripStatusLabel
    Public WithEvents ListBox1 As ListBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents StatutBarProgress As ToolStripProgressBar
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabGeneral As TabPage
    Friend WithEvents TabBDD As TabPage
    Friend WithEvents lbl_NameChannel As Label
    Friend WithEvents GroupBox_Sub2 As GroupBox
    Friend WithEvents lbl_SubDesc2Val As Label
    Friend WithEvents lbl_SubDesc2 As Label
    Friend WithEvents lbl_SubOriginalCodec2Val As Label
    Friend WithEvents lbl_SubOriginalCodec2 As Label
    Friend WithEvents lbl_SubName2Val As Label
    Friend WithEvents lbl_SubName2 As Label
    Friend WithEvents lbl_SubID2Val As Label
    Friend WithEvents lbl_SubID2 As Label
    Friend WithEvents lbl_SubLang2Val As Label
    Friend WithEvents lbl_SubLang2 As Label
    Friend WithEvents lbl_SubCodec2Val As Label
    Friend WithEvents lbl_SubCodec2 As Label
    Friend WithEvents GroupBox_Sub1 As GroupBox
    Friend WithEvents lbl_SubOriginalCodec1Val As Label
    Friend WithEvents lbl_SubOriginalCodec1 As Label
    Friend WithEvents lbl_SubName1Val As Label
    Friend WithEvents lbl_SubName1 As Label
    Friend WithEvents lbl_SubID1Val As Label
    Friend WithEvents lbl_SubID1 As Label
    Friend WithEvents lbl_SubDesc1Val As Label
    Friend WithEvents lbl_SubDesc1 As Label
    Friend WithEvents lbl_SubLang1Val As Label
    Friend WithEvents lbl_SubLang1 As Label
    Friend WithEvents lbl_SubCodec1Val As Label
    Friend WithEvents lbl_SubCodec1 As Label
    Friend WithEvents GroupBox_Audio2 As GroupBox
    Friend WithEvents lbl_AudioOriginalCodec2Val As Label
    Friend WithEvents lbl_AudioOriginalCodec2 As Label
    Friend WithEvents lbl_AudioName2Val As Label
    Friend WithEvents lbl_AudioName2 As Label
    Friend WithEvents lbl_AudioID2Val As Label
    Friend WithEvents lbl_AudioID2 As Label
    Friend WithEvents lbl_AudioChannel2Val As Label
    Friend WithEvents lbl_AudioChannel2 As Label
    Friend WithEvents lbl_AudioLang2Val As Label
    Friend WithEvents lbl_AudioLang2 As Label
    Friend WithEvents lbl_AudioRate2Val As Label
    Friend WithEvents lbl_AudioRate2 As Label
    Friend WithEvents lbl_AudioCodec2Val As Label
    Friend WithEvents lbl_AudioCodec2 As Label
    Friend WithEvents GroupBox_Audio1 As GroupBox
    Friend WithEvents lbl_AudioOriginalCodec1Val As Label
    Friend WithEvents lbl_AudioOrigionalCodec1 As Label
    Friend WithEvents lbl_AudioName1Val As Label
    Friend WithEvents lbl_AudioName1 As Label
    Friend WithEvents lbl_AudioID1Val As Label
    Friend WithEvents lbl_AudioID1 As Label
    Friend WithEvents lbl_AudioChannel1Val As Label
    Friend WithEvents lbl_AudioChannel1 As Label
    Friend WithEvents lbl_AudioLang1Val As Label
    Friend WithEvents lbl_AudioLang1 As Label
    Friend WithEvents lbl_AudioRate1Val As Label
    Friend WithEvents lbl_AudioRate1 As Label
    Friend WithEvents lbl_AudioCodec1Val As Label
    Friend WithEvents lbl_AudioCodec1 As Label
    Friend WithEvents GroupBox_Video As GroupBox
    Friend WithEvents lbl_VideoOriginalCodecVal As Label
    Friend WithEvents Lbl_VideoOriginalCodec As Label
    Friend WithEvents lbl_VideoNameVal As Label
    Friend WithEvents lbl_VideoName As Label
    Friend WithEvents lbl_VideoIDVal As Label
    Friend WithEvents lbl_VideoID As Label
    Friend WithEvents lbl_VideoResVal As Label
    Friend WithEvents lbl_VideoRes As Label
    Friend WithEvents lbl_VideoDefVal As Label
    Friend WithEvents lbl_VideoDef As Label
    Friend WithEvents lbl_VideoFPSVal As Label
    Friend WithEvents lbl_VideoFPS As Label
    Friend WithEvents lbl_VideoCodecVal As Label
    Friend WithEvents lbl_VideoCodec As Label
    Friend WithEvents CheckBox_ShowLogs As CheckBox
    Friend WithEvents lbl_RPays As Label
    Friend WithEvents lbl_RGroupChannel As Label
    Friend WithEvents Lbl_RTimeShift As Label
    Friend WithEvents lbl_RNomEPG As Label
    Friend WithEvents lbl_RNoChaine As Label
    Friend WithEvents lbl_RNoCanal As Label
    Friend WithEvents lbl_RNomChaine As Label
    Friend WithEvents lbl_RCategorie As Label
    Friend WithEvents PictureBox_RLinkImg As PictureBox
    Friend WithEvents txt_RDescription As TextBox
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateListeDesLogosToolStripMenuItem As ToolStripMenuItem
End Class
