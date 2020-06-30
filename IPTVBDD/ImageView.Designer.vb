<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageView
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
        Me.PictureView = New System.Windows.Forms.PictureBox()
        Me.ScrollPic = New System.Windows.Forms.HScrollBar()
        Me.lbl_ImageName = New System.Windows.Forms.Label()
        CType(Me.PictureView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(12, 487)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(158, 35)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Selectionner"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(450, 487)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(100, 35)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Annuler"
        '
        'PictureView
        '
        Me.PictureView.BackColor = System.Drawing.Color.White
        Me.PictureView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureView.Location = New System.Drawing.Point(12, 12)
        Me.PictureView.Name = "PictureView"
        Me.PictureView.Size = New System.Drawing.Size(538, 391)
        Me.PictureView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureView.TabIndex = 2
        Me.PictureView.TabStop = False
        Me.PictureView.WaitOnLoad = True
        '
        'ScrollPic
        '
        Me.ScrollPic.LargeChange = 1
        Me.ScrollPic.Location = New System.Drawing.Point(12, 444)
        Me.ScrollPic.Name = "ScrollPic"
        Me.ScrollPic.Size = New System.Drawing.Size(538, 25)
        Me.ScrollPic.TabIndex = 3
        '
        'lbl_ImageName
        '
        Me.lbl_ImageName.BackColor = System.Drawing.Color.Black
        Me.lbl_ImageName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ImageName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ImageName.ForeColor = System.Drawing.Color.Lime
        Me.lbl_ImageName.Location = New System.Drawing.Point(12, 406)
        Me.lbl_ImageName.Name = "lbl_ImageName"
        Me.lbl_ImageName.Size = New System.Drawing.Size(538, 38)
        Me.lbl_ImageName.TabIndex = 4
        Me.lbl_ImageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageView
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(565, 541)
        Me.Controls.Add(Me.lbl_ImageName)
        Me.Controls.Add(Me.ScrollPic)
        Me.Controls.Add(Me.PictureView)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImageView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ImageView"
        Me.TopMost = True
        CType(Me.PictureView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureView As PictureBox
    Friend WithEvents ScrollPic As HScrollBar
    Friend WithEvents lbl_ImageName As Label
End Class
