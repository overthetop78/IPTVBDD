<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog_AskInfo
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Button_Garder = New System.Windows.Forms.Button()
        Me.lbl_NomChaine = New System.Windows.Forms.Label()
        Me.txt_NomChaine = New System.Windows.Forms.TextBox()
        Me.txt_tvg_chno = New System.Windows.Forms.TextBox()
        Me.lbl_tvg_chno = New System.Windows.Forms.Label()
        Me.txt_tvg_id = New System.Windows.Forms.TextBox()
        Me.lbl_tvg_id = New System.Windows.Forms.Label()
        Me.txt_group = New System.Windows.Forms.TextBox()
        Me.lbl_group = New System.Windows.Forms.Label()
        Me.txt_tvg_shift = New System.Windows.Forms.TextBox()
        Me.lbl_tvg_shift = New System.Windows.Forms.Label()
        Me.txt_categorie = New System.Windows.Forms.TextBox()
        Me.lbl_categorie = New System.Windows.Forms.Label()
        Me.txt_Desc = New System.Windows.Forms.TextBox()
        Me.lbl_Desc = New System.Windows.Forms.Label()
        Me.txt_Pays = New System.Windows.Forms.TextBox()
        Me.lbl_Pays = New System.Windows.Forms.Label()
        Me.PictureBox_tvg_logo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_tvg_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(844, 700)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Modifier"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(584, 700)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Passer"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Button_Garder
        '
        Me.Button_Garder.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Garder.Location = New System.Drawing.Point(712, 700)
        Me.Button_Garder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Garder.Name = "Button_Garder"
        Me.Button_Garder.Size = New System.Drawing.Size(100, 35)
        Me.Button_Garder.TabIndex = 6
        Me.Button_Garder.Text = "Garder"
        Me.Button_Garder.UseVisualStyleBackColor = True
        '
        'lbl_NomChaine
        '
        Me.lbl_NomChaine.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NomChaine.Location = New System.Drawing.Point(283, 34)
        Me.lbl_NomChaine.Name = "lbl_NomChaine"
        Me.lbl_NomChaine.Size = New System.Drawing.Size(79, 32)
        Me.lbl_NomChaine.TabIndex = 7
        Me.lbl_NomChaine.Text = "Nom : "
        '
        'txt_NomChaine
        '
        Me.txt_NomChaine.BackColor = System.Drawing.Color.Black
        Me.txt_NomChaine.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NomChaine.ForeColor = System.Drawing.Color.Orchid
        Me.txt_NomChaine.Location = New System.Drawing.Point(359, 31)
        Me.txt_NomChaine.Name = "txt_NomChaine"
        Me.txt_NomChaine.Size = New System.Drawing.Size(631, 30)
        Me.txt_NomChaine.TabIndex = 8
        '
        'txt_tvg_chno
        '
        Me.txt_tvg_chno.BackColor = System.Drawing.Color.Black
        Me.txt_tvg_chno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tvg_chno.ForeColor = System.Drawing.Color.Orchid
        Me.txt_tvg_chno.Location = New System.Drawing.Point(125, 34)
        Me.txt_tvg_chno.Name = "txt_tvg_chno"
        Me.txt_tvg_chno.Size = New System.Drawing.Size(132, 30)
        Me.txt_tvg_chno.TabIndex = 10
        Me.txt_tvg_chno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_tvg_chno
        '
        Me.lbl_tvg_chno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tvg_chno.Location = New System.Drawing.Point(12, 34)
        Me.lbl_tvg_chno.Name = "lbl_tvg_chno"
        Me.lbl_tvg_chno.Size = New System.Drawing.Size(107, 32)
        Me.lbl_tvg_chno.TabIndex = 9
        Me.lbl_tvg_chno.Text = "Numéro :"
        '
        'txt_tvg_id
        '
        Me.txt_tvg_id.BackColor = System.Drawing.Color.Black
        Me.txt_tvg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tvg_id.ForeColor = System.Drawing.Color.Orchid
        Me.txt_tvg_id.Location = New System.Drawing.Point(396, 80)
        Me.txt_tvg_id.Name = "txt_tvg_id"
        Me.txt_tvg_id.Size = New System.Drawing.Size(594, 30)
        Me.txt_tvg_id.TabIndex = 12
        '
        'lbl_tvg_id
        '
        Me.lbl_tvg_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tvg_id.Location = New System.Drawing.Point(283, 83)
        Me.lbl_tvg_id.Name = "lbl_tvg_id"
        Me.lbl_tvg_id.Size = New System.Drawing.Size(107, 32)
        Me.lbl_tvg_id.TabIndex = 11
        Me.lbl_tvg_id.Text = "ID EPG : "
        '
        'txt_group
        '
        Me.txt_group.BackColor = System.Drawing.Color.Black
        Me.txt_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_group.ForeColor = System.Drawing.Color.Orchid
        Me.txt_group.Location = New System.Drawing.Point(125, 133)
        Me.txt_group.Name = "txt_group"
        Me.txt_group.Size = New System.Drawing.Size(631, 30)
        Me.txt_group.TabIndex = 14
        '
        'lbl_group
        '
        Me.lbl_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_group.Location = New System.Drawing.Point(12, 133)
        Me.lbl_group.Name = "lbl_group"
        Me.lbl_group.Size = New System.Drawing.Size(107, 32)
        Me.lbl_group.TabIndex = 13
        Me.lbl_group.Text = "Groupe : "
        '
        'txt_tvg_shift
        '
        Me.txt_tvg_shift.BackColor = System.Drawing.Color.Black
        Me.txt_tvg_shift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tvg_shift.ForeColor = System.Drawing.Color.Orchid
        Me.txt_tvg_shift.Location = New System.Drawing.Point(151, 86)
        Me.txt_tvg_shift.Name = "txt_tvg_shift"
        Me.txt_tvg_shift.Size = New System.Drawing.Size(94, 30)
        Me.txt_tvg_shift.TabIndex = 16
        '
        'lbl_tvg_shift
        '
        Me.lbl_tvg_shift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tvg_shift.Location = New System.Drawing.Point(13, 86)
        Me.lbl_tvg_shift.Name = "lbl_tvg_shift"
        Me.lbl_tvg_shift.Size = New System.Drawing.Size(132, 32)
        Me.lbl_tvg_shift.TabIndex = 15
        Me.lbl_tvg_shift.Text = "Timeshift :"
        '
        'txt_categorie
        '
        Me.txt_categorie.BackColor = System.Drawing.Color.Black
        Me.txt_categorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_categorie.ForeColor = System.Drawing.Color.Orchid
        Me.txt_categorie.Location = New System.Drawing.Point(151, 185)
        Me.txt_categorie.Name = "txt_categorie"
        Me.txt_categorie.Size = New System.Drawing.Size(315, 30)
        Me.txt_categorie.TabIndex = 18
        '
        'lbl_categorie
        '
        Me.lbl_categorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categorie.Location = New System.Drawing.Point(12, 185)
        Me.lbl_categorie.Name = "lbl_categorie"
        Me.lbl_categorie.Size = New System.Drawing.Size(133, 32)
        Me.lbl_categorie.TabIndex = 17
        Me.lbl_categorie.Text = "Catégorie :"
        '
        'txt_Desc
        '
        Me.txt_Desc.AcceptsReturn = True
        Me.txt_Desc.BackColor = System.Drawing.Color.Black
        Me.txt_Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Desc.ForeColor = System.Drawing.Color.Orchid
        Me.txt_Desc.Location = New System.Drawing.Point(166, 240)
        Me.txt_Desc.Multiline = True
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.Size = New System.Drawing.Size(824, 146)
        Me.txt_Desc.TabIndex = 20
        '
        'lbl_Desc
        '
        Me.lbl_Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Desc.Location = New System.Drawing.Point(12, 240)
        Me.lbl_Desc.Name = "lbl_Desc"
        Me.lbl_Desc.Size = New System.Drawing.Size(148, 32)
        Me.lbl_Desc.TabIndex = 19
        Me.lbl_Desc.Text = "Description :"
        '
        'txt_Pays
        '
        Me.txt_Pays.BackColor = System.Drawing.Color.Black
        Me.txt_Pays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pays.ForeColor = System.Drawing.Color.Orchid
        Me.txt_Pays.Location = New System.Drawing.Point(584, 185)
        Me.txt_Pays.Name = "txt_Pays"
        Me.txt_Pays.Size = New System.Drawing.Size(406, 30)
        Me.txt_Pays.TabIndex = 22
        '
        'lbl_Pays
        '
        Me.lbl_Pays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pays.Location = New System.Drawing.Point(500, 185)
        Me.lbl_Pays.Name = "lbl_Pays"
        Me.lbl_Pays.Size = New System.Drawing.Size(78, 32)
        Me.lbl_Pays.TabIndex = 21
        Me.lbl_Pays.Text = "Pays : "
        '
        'PictureBox_tvg_logo
        '
        Me.PictureBox_tvg_logo.BackColor = System.Drawing.Color.White
        Me.PictureBox_tvg_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox_tvg_logo.Location = New System.Drawing.Point(172, 416)
        Me.PictureBox_tvg_logo.Name = "PictureBox_tvg_logo"
        Me.PictureBox_tvg_logo.Size = New System.Drawing.Size(388, 319)
        Me.PictureBox_tvg_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_tvg_logo.TabIndex = 23
        Me.PictureBox_tvg_logo.TabStop = False
        Me.PictureBox_tvg_logo.WaitOnLoad = True
        '
        'Dialog_AskInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1043, 818)
        Me.Controls.Add(Me.PictureBox_tvg_logo)
        Me.Controls.Add(Me.txt_Pays)
        Me.Controls.Add(Me.lbl_Pays)
        Me.Controls.Add(Me.txt_Desc)
        Me.Controls.Add(Me.lbl_Desc)
        Me.Controls.Add(Me.txt_categorie)
        Me.Controls.Add(Me.lbl_categorie)
        Me.Controls.Add(Me.txt_tvg_shift)
        Me.Controls.Add(Me.lbl_tvg_shift)
        Me.Controls.Add(Me.txt_group)
        Me.Controls.Add(Me.lbl_group)
        Me.Controls.Add(Me.txt_tvg_id)
        Me.Controls.Add(Me.lbl_tvg_id)
        Me.Controls.Add(Me.txt_tvg_chno)
        Me.Controls.Add(Me.lbl_tvg_chno)
        Me.Controls.Add(Me.txt_NomChaine)
        Me.Controls.Add(Me.lbl_NomChaine)
        Me.Controls.Add(Me.Button_Garder)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Dialog_AskInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modification des Infos de la chaine "
        Me.TopMost = True
        CType(Me.PictureBox_tvg_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Button_Garder As Button
    Friend WithEvents lbl_NomChaine As Label
    Friend WithEvents txt_NomChaine As TextBox
    Friend WithEvents txt_tvg_chno As TextBox
    Friend WithEvents lbl_tvg_chno As Label
    Friend WithEvents txt_tvg_id As TextBox
    Friend WithEvents lbl_tvg_id As Label
    Friend WithEvents txt_group As TextBox
    Friend WithEvents lbl_group As Label
    Friend WithEvents txt_tvg_shift As TextBox
    Friend WithEvents lbl_tvg_shift As Label
    Friend WithEvents txt_categorie As TextBox
    Friend WithEvents lbl_categorie As Label
    Friend WithEvents txt_Desc As TextBox
    Friend WithEvents lbl_Desc As Label
    Friend WithEvents txt_Pays As TextBox
    Friend WithEvents lbl_Pays As Label
    Friend WithEvents PictureBox_tvg_logo As PictureBox
End Class
