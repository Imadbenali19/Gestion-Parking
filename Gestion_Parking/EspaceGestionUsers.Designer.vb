<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EspaceGestionUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EspaceGestionUsers))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Show2 = New System.Windows.Forms.CheckBox()
        Me.Show1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Idsexe = New System.Windows.Forms.ComboBox()
        Me.Iddate = New System.Windows.Forms.DateTimePicker()
        Me.Idcmp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Idmp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Idemail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Idname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Idsh = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Idcnss = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.idtel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(263, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 31)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Gestion Utilisateurs"
        '
        'Show2
        '
        Me.Show2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Show2.AutoSize = True
        Me.Show2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show2.Location = New System.Drawing.Point(474, 380)
        Me.Show2.Name = "Show2"
        Me.Show2.Size = New System.Drawing.Size(60, 20)
        Me.Show2.TabIndex = 51
        Me.Show2.Text = "Show"
        Me.Show2.UseVisualStyleBackColor = False
        '
        'Show1
        '
        Me.Show1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Show1.AutoSize = True
        Me.Show1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Show1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show1.Location = New System.Drawing.Point(474, 337)
        Me.Show1.Name = "Show1"
        Me.Show1.Size = New System.Drawing.Size(60, 20)
        Me.Show1.TabIndex = 50
        Me.Show1.Text = "Show"
        Me.Show1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(543, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(201, 35)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Initialiser"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(543, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 35)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Recruter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Idsexe
        '
        Me.Idsexe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idsexe.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Idsexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Idsexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idsexe.FormattingEnabled = True
        Me.Idsexe.Items.AddRange(New Object() {"Femme", "Homme"})
        Me.Idsexe.Location = New System.Drawing.Point(244, 258)
        Me.Idsexe.Name = "Idsexe"
        Me.Idsexe.Size = New System.Drawing.Size(225, 24)
        Me.Idsexe.TabIndex = 47
        '
        'Iddate
        '
        Me.Iddate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Iddate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Iddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Iddate.Location = New System.Drawing.Point(244, 299)
        Me.Iddate.Name = "Iddate"
        Me.Iddate.Size = New System.Drawing.Size(225, 22)
        Me.Iddate.TabIndex = 46
        '
        'Idcmp
        '
        Me.Idcmp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idcmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Idcmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idcmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idcmp.Location = New System.Drawing.Point(243, 380)
        Me.Idcmp.Name = "Idcmp"
        Me.Idcmp.Size = New System.Drawing.Size(225, 22)
        Me.Idcmp.TabIndex = 45
        Me.Idcmp.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 22)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Confirmation MP"
        '
        'Idmp
        '
        Me.Idmp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Idmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idmp.Location = New System.Drawing.Point(243, 337)
        Me.Idmp.Name = "Idmp"
        Me.Idmp.Size = New System.Drawing.Size(225, 22)
        Me.Idmp.TabIndex = 43
        Me.Idmp.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 22)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Mot de passe"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 22)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Date de naissance"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 22)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Sexe"
        '
        'Idemail
        '
        Me.Idemail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idemail.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Idemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idemail.Location = New System.Drawing.Point(244, 109)
        Me.Idemail.Name = "Idemail"
        Me.Idemail.Size = New System.Drawing.Size(225, 22)
        Me.Idemail.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 22)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Email"
        '
        'Idname
        '
        Me.Idname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Idname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idname.Location = New System.Drawing.Point(244, 77)
        Me.Idname.Name = "Idname"
        Me.Idname.Size = New System.Drawing.Size(225, 22)
        Me.Idname.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 22)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nom"
        '
        'Idsh
        '
        Me.Idsh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idsh.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Idsh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idsh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idsh.Location = New System.Drawing.Point(244, 219)
        Me.Idsh.Name = "Idsh"
        Me.Idsh.Size = New System.Drawing.Size(225, 22)
        Me.Idsh.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 22)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Salaire/heure"
        '
        'Idcnss
        '
        Me.Idcnss.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idcnss.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Idcnss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idcnss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idcnss.Location = New System.Drawing.Point(244, 182)
        Me.Idcnss.Name = "Idcnss"
        Me.Idcnss.Size = New System.Drawing.Size(225, 22)
        Me.Idcnss.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 22)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Code CNSS"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(210, 22)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Accès à la gestion Users"
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(543, 307)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(201, 35)
        Me.Button5.TabIndex = 64
        Me.Button5.Text = "C'est Modifier"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Non", "Oui"})
        Me.ComboBox1.Location = New System.Drawing.Point(243, 413)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 24)
        Me.ComboBox1.TabIndex = 66
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Non", "Oui"})
        Me.ComboBox2.Location = New System.Drawing.Point(244, 451)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 24)
        Me.ComboBox2.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 453)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(175, 22)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Accès à l'application"
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(543, 255)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(201, 35)
        Me.Button9.TabIndex = 71
        Me.Button9.Text = "Déconnexion"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'idtel
        '
        Me.idtel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.idtel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idtel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idtel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtel.Location = New System.Drawing.Point(244, 146)
        Me.idtel.Name = "idtel"
        Me.idtel.Size = New System.Drawing.Size(225, 22)
        Me.idtel.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 22)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "GSM"
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
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(602, 348)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 78
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(543, 205)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(201, 35)
        Me.Button6.TabIndex = 79
        Me.Button6.Text = "Voir liste"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'EspaceGestionUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(756, 495)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.idtel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Idsh)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Idcnss)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Show2)
        Me.Controls.Add(Me.Show1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Idsexe)
        Me.Controls.Add(Me.Iddate)
        Me.Controls.Add(Me.Idcmp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Idmp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Idemail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Idname)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EspaceGestionUsers"
        Me.Text = "EspaceGestionUsers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Show2 As System.Windows.Forms.CheckBox
    Friend WithEvents Show1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Idsexe As System.Windows.Forms.ComboBox
    Friend WithEvents Iddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Idcmp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Idmp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Idemail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Idname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Idsh As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Idcnss As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents idtel As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
