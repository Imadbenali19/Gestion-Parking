<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EspaceGestionVoitures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EspaceGestionVoitures))
        Me.Idchauff = New System.Windows.Forms.TextBox()
        Me.Idimm = New System.Windows.Forms.TextBox()
        Me.Idnbplace = New System.Windows.Forms.ComboBox()
        Me.IddateE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Idmarque = New System.Windows.Forms.GroupBox()
        Me.IdautreV = New System.Windows.Forms.RadioButton()
        Me.Idautretext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Iddv = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Idmarque.SuspendLayout()
        Me.SuspendLayout()
        '
        'Idchauff
        '
        Me.Idchauff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idchauff.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Idchauff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idchauff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idchauff.Location = New System.Drawing.Point(223, 69)
        Me.Idchauff.Name = "Idchauff"
        Me.Idchauff.Size = New System.Drawing.Size(200, 22)
        Me.Idchauff.TabIndex = 1
        '
        'Idimm
        '
        Me.Idimm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idimm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Idimm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idimm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idimm.Location = New System.Drawing.Point(223, 107)
        Me.Idimm.Name = "Idimm"
        Me.Idimm.Size = New System.Drawing.Size(200, 22)
        Me.Idimm.TabIndex = 3
        '
        'Idnbplace
        '
        Me.Idnbplace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idnbplace.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Idnbplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Idnbplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idnbplace.FormattingEnabled = True
        Me.Idnbplace.Items.AddRange(New Object() {"2", "4", "5", "6"})
        Me.Idnbplace.Location = New System.Drawing.Point(223, 150)
        Me.Idnbplace.Name = "Idnbplace"
        Me.Idnbplace.Size = New System.Drawing.Size(200, 24)
        Me.Idnbplace.TabIndex = 10
        '
        'IddateE
        '
        Me.IddateE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IddateE.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IddateE.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IddateE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IddateE.Location = New System.Drawing.Point(223, 362)
        Me.IddateE.Name = "IddateE"
        Me.IddateE.Size = New System.Drawing.Size(220, 22)
        Me.IddateE.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(224, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Gestion Voitures"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(253, 25)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 24)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Dacia"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(253, 55)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 24)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Renault"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Idmarque
        '
        Me.Idmarque.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idmarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Idmarque.Controls.Add(Me.IdautreV)
        Me.Idmarque.Controls.Add(Me.Idautretext)
        Me.Idmarque.Controls.Add(Me.RadioButton2)
        Me.Idmarque.Controls.Add(Me.RadioButton1)
        Me.Idmarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Idmarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idmarque.Location = New System.Drawing.Point(34, 194)
        Me.Idmarque.Name = "Idmarque"
        Me.Idmarque.Size = New System.Drawing.Size(410, 151)
        Me.Idmarque.TabIndex = 17
        Me.Idmarque.TabStop = False
        Me.Idmarque.Text = "Marque"
        '
        'IdautreV
        '
        Me.IdautreV.AutoSize = True
        Me.IdautreV.Location = New System.Drawing.Point(253, 85)
        Me.IdautreV.Name = "IdautreV"
        Me.IdautreV.Size = New System.Drawing.Size(71, 24)
        Me.IdautreV.TabIndex = 19
        Me.IdautreV.TabStop = True
        Me.IdautreV.Text = "Autre"
        Me.IdautreV.UseVisualStyleBackColor = True
        '
        'Idautretext
        '
        Me.Idautretext.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Idautretext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idautretext.Location = New System.Drawing.Point(253, 115)
        Me.Idautretext.Name = "Idautretext"
        Me.Idautretext.Size = New System.Drawing.Size(137, 26)
        Me.Idautretext.TabIndex = 18
        Me.Idautretext.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Chauffeur"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nombre de places"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Date d'entrée"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Immatriculation"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(429, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Pas de caractères spéciaux"
        Me.Label8.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(22, 434)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 40)
        Me.Button1.TabIndex = 28
        Me.Button1.Tag = ""
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(252, 434)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(195, 40)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Voir liste"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(478, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 40)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(252, 480)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 40)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "Déconnexion"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 39)
        Me.Button3.TabIndex = 77
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Durée(mn)"
        '
        'Iddv
        '
        Me.Iddv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Iddv.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Iddv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Iddv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iddv.Location = New System.Drawing.Point(224, 390)
        Me.Iddv.Name = "Iddv"
        Me.Iddv.Size = New System.Drawing.Size(199, 22)
        Me.Iddv.TabIndex = 78
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(526, 411)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 80
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'EspaceGestionVoitures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(695, 526)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Iddv)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Idmarque)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IddateE)
        Me.Controls.Add(Me.Idnbplace)
        Me.Controls.Add(Me.Idimm)
        Me.Controls.Add(Me.Idchauff)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EspaceGestionVoitures"
        Me.Text = "EspaceGestionVoitures"
        Me.Idmarque.ResumeLayout(False)
        Me.Idmarque.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Idchauff As System.Windows.Forms.TextBox
    Friend WithEvents Idimm As System.Windows.Forms.TextBox
    Friend WithEvents Idnbplace As System.Windows.Forms.ComboBox
    Friend WithEvents IddateE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Idmarque As System.Windows.Forms.GroupBox
    Friend WithEvents IdautreV As System.Windows.Forms.RadioButton
    Friend WithEvents Idautretext As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Iddv As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
