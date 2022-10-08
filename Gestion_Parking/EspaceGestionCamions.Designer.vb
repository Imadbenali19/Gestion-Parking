<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EspaceGestionCamions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EspaceGestionCamions))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdmarqueC = New System.Windows.Forms.GroupBox()
        Me.IdautreC = New System.Windows.Forms.RadioButton()
        Me.IdautretextC = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IddateEC = New System.Windows.Forms.DateTimePicker()
        Me.IdimmC = New System.Windows.Forms.TextBox()
        Me.IdchauffC = New System.Windows.Forms.TextBox()
        Me.Idtonn = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Iddc = New System.Windows.Forms.TextBox()
        Me.IdmarqueC.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(14, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 42)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(409, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 16)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Pas de caractères spéciaux"
        Me.Label8.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Immatriculation"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Date d'entrée"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Tonnage"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Chauffeur"
        '
        'IdmarqueC
        '
        Me.IdmarqueC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IdmarqueC.BackColor = System.Drawing.Color.Gray
        Me.IdmarqueC.Controls.Add(Me.IdautreC)
        Me.IdmarqueC.Controls.Add(Me.IdautretextC)
        Me.IdmarqueC.Controls.Add(Me.RadioButton2)
        Me.IdmarqueC.Controls.Add(Me.RadioButton1)
        Me.IdmarqueC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdmarqueC.Location = New System.Drawing.Point(13, 170)
        Me.IdmarqueC.Name = "IdmarqueC"
        Me.IdmarqueC.Size = New System.Drawing.Size(410, 151)
        Me.IdmarqueC.TabIndex = 38
        Me.IdmarqueC.TabStop = False
        Me.IdmarqueC.Text = "Marque"
        '
        'IdautreC
        '
        Me.IdautreC.AutoSize = True
        Me.IdautreC.Location = New System.Drawing.Point(253, 85)
        Me.IdautreC.Name = "IdautreC"
        Me.IdautreC.Size = New System.Drawing.Size(71, 24)
        Me.IdautreC.TabIndex = 19
        Me.IdautreC.TabStop = True
        Me.IdautreC.Text = "Autre"
        Me.IdautreC.UseVisualStyleBackColor = True
        '
        'IdautretextC
        '
        Me.IdautretextC.BackColor = System.Drawing.Color.Silver
        Me.IdautretextC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdautretextC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.IdautretextC.Location = New System.Drawing.Point(253, 115)
        Me.IdautretextC.Name = "IdautretextC"
        Me.IdautretextC.Size = New System.Drawing.Size(137, 26)
        Me.IdautretextC.TabIndex = 18
        Me.IdautretextC.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(253, 55)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 24)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Volvo"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(253, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 24)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "MAN"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(212, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Gestion Camions"
        '
        'IddateEC
        '
        Me.IddateEC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IddateEC.CalendarForeColor = System.Drawing.Color.Black
        Me.IddateEC.CalendarMonthBackground = System.Drawing.Color.Gray
        Me.IddateEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IddateEC.Location = New System.Drawing.Point(203, 337)
        Me.IddateEC.Name = "IddateEC"
        Me.IddateEC.Size = New System.Drawing.Size(220, 22)
        Me.IddateEC.TabIndex = 36
        '
        'IdimmC
        '
        Me.IdimmC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IdimmC.BackColor = System.Drawing.Color.Silver
        Me.IdimmC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdimmC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdimmC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.IdimmC.Location = New System.Drawing.Point(203, 92)
        Me.IdimmC.Name = "IdimmC"
        Me.IdimmC.Size = New System.Drawing.Size(200, 22)
        Me.IdimmC.TabIndex = 33
        '
        'IdchauffC
        '
        Me.IdchauffC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IdchauffC.BackColor = System.Drawing.Color.Silver
        Me.IdchauffC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdchauffC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdchauffC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.IdchauffC.Location = New System.Drawing.Point(203, 54)
        Me.IdchauffC.Name = "IdchauffC"
        Me.IdchauffC.Size = New System.Drawing.Size(200, 22)
        Me.IdchauffC.TabIndex = 32
        '
        'Idtonn
        '
        Me.Idtonn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idtonn.BackColor = System.Drawing.Color.Silver
        Me.Idtonn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idtonn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Idtonn.Location = New System.Drawing.Point(203, 133)
        Me.Idtonn.Name = "Idtonn"
        Me.Idtonn.Size = New System.Drawing.Size(200, 20)
        Me.Idtonn.TabIndex = 53
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(472, 403)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 63
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(419, 427)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 42)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "C'est modifié!"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(220, 426)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(193, 43)
        Me.Button6.TabIndex = 61
        Me.Button6.Text = "Voir liste"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(220, 477)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(193, 42)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "Déconnexion"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonA
        '
        Me.ButtonA.BackColor = System.Drawing.Color.Transparent
        Me.ButtonA.BackgroundImage = CType(resources.GetObject("ButtonA.BackgroundImage"), System.Drawing.Image)
        Me.ButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonA.Location = New System.Drawing.Point(12, 9)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(97, 39)
        Me.ButtonA.TabIndex = 77
        Me.ButtonA.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Durée"
        '
        'Iddc
        '
        Me.Iddc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Iddc.BackColor = System.Drawing.Color.Silver
        Me.Iddc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Iddc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iddc.Location = New System.Drawing.Point(203, 365)
        Me.Iddc.Name = "Iddc"
        Me.Iddc.Size = New System.Drawing.Size(199, 22)
        Me.Iddc.TabIndex = 80
        '
        'EspaceGestionCamions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(627, 522)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Iddc)
        Me.Controls.Add(Me.ButtonA)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Idtonn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IdmarqueC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IddateEC)
        Me.Controls.Add(Me.IdimmC)
        Me.Controls.Add(Me.IdchauffC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EspaceGestionCamions"
        Me.Text = "EspaceGestionCamions"
        Me.IdmarqueC.ResumeLayout(False)
        Me.IdmarqueC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdmarqueC As System.Windows.Forms.GroupBox
    Friend WithEvents IdautreC As System.Windows.Forms.RadioButton
    Friend WithEvents IdautretextC As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IddateEC As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdimmC As System.Windows.Forms.TextBox
    Friend WithEvents IdchauffC As System.Windows.Forms.TextBox
    Friend WithEvents Idtonn As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonA As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Iddc As System.Windows.Forms.TextBox
End Class
