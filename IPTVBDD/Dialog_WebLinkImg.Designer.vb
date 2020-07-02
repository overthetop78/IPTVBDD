<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog_WebLinkImg
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
        Me.PictureBox_TestIMG = New System.Windows.Forms.PictureBox()
        Me.txt_TestIMG = New System.Windows.Forms.TextBox()
        Me.Btn_TestIMG = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Btn_Accept = New System.Windows.Forms.Button()
        Me.ProgressBar_IMGLoad = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox_TestIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_TestIMG
        '
        Me.PictureBox_TestIMG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_TestIMG.Location = New System.Drawing.Point(17, 8)
        Me.PictureBox_TestIMG.Name = "PictureBox_TestIMG"
        Me.PictureBox_TestIMG.Size = New System.Drawing.Size(640, 480)
        Me.PictureBox_TestIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_TestIMG.TabIndex = 1
        Me.PictureBox_TestIMG.TabStop = False
        '
        'txt_TestIMG
        '
        Me.txt_TestIMG.Location = New System.Drawing.Point(12, 494)
        Me.txt_TestIMG.Name = "txt_TestIMG"
        Me.txt_TestIMG.Size = New System.Drawing.Size(512, 26)
        Me.txt_TestIMG.TabIndex = 2
        '
        'Btn_TestIMG
        '
        Me.Btn_TestIMG.Location = New System.Drawing.Point(543, 493)
        Me.Btn_TestIMG.Name = "Btn_TestIMG"
        Me.Btn_TestIMG.Size = New System.Drawing.Size(113, 40)
        Me.Btn_TestIMG.TabIndex = 3
        Me.Btn_TestIMG.Text = "Tester"
        Me.Btn_TestIMG.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancel.Location = New System.Drawing.Point(26, 628)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(119, 48)
        Me.Btn_Cancel.TabIndex = 4
        Me.Btn_Cancel.Text = "Annuler"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'Btn_Accept
        '
        Me.Btn_Accept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Btn_Accept.Enabled = False
        Me.Btn_Accept.Location = New System.Drawing.Point(543, 628)
        Me.Btn_Accept.Name = "Btn_Accept"
        Me.Btn_Accept.Size = New System.Drawing.Size(119, 48)
        Me.Btn_Accept.TabIndex = 5
        Me.Btn_Accept.Text = "Ajouter"
        Me.Btn_Accept.UseVisualStyleBackColor = True
        '
        'ProgressBar_IMGLoad
        '
        Me.ProgressBar_IMGLoad.Location = New System.Drawing.Point(12, 538)
        Me.ProgressBar_IMGLoad.Maximum = 75
        Me.ProgressBar_IMGLoad.Name = "ProgressBar_IMGLoad"
        Me.ProgressBar_IMGLoad.Size = New System.Drawing.Size(511, 41)
        Me.ProgressBar_IMGLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar_IMGLoad.TabIndex = 6
        '
        'Dialog_WebLinkImg
        '
        Me.AcceptButton = Me.Btn_Accept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Cancel
        Me.ClientSize = New System.Drawing.Size(796, 858)
        Me.Controls.Add(Me.ProgressBar_IMGLoad)
        Me.Controls.Add(Me.Btn_Accept)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_TestIMG)
        Me.Controls.Add(Me.txt_TestIMG)
        Me.Controls.Add(Me.PictureBox_TestIMG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Dialog_WebLinkImg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ajout du logo"
        Me.TopMost = True
        CType(Me.PictureBox_TestIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox_TestIMG As PictureBox
    Friend WithEvents txt_TestIMG As TextBox
    Friend WithEvents Btn_TestIMG As Button
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents Btn_Accept As Button
    Friend WithEvents ProgressBar_IMGLoad As ProgressBar
End Class
