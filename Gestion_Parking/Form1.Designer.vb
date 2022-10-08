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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Id_username = New System.Windows.Forms.TextBox()
        Me.Idpass = New System.Windows.Forms.TextBox()
        Me.Show1A = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Id_username
        '
        Me.Id_username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Id_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Id_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_username.Location = New System.Drawing.Point(148, 110)
        Me.Id_username.Name = "Id_username"
        Me.Id_username.Size = New System.Drawing.Size(232, 20)
        Me.Id_username.TabIndex = 3
        '
        'Idpass
        '
        Me.Idpass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Idpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Idpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Idpass.Location = New System.Drawing.Point(148, 161)
        Me.Idpass.Name = "Idpass"
        Me.Idpass.Size = New System.Drawing.Size(232, 20)
        Me.Idpass.TabIndex = 4
        Me.Idpass.UseSystemPasswordChar = True
        '
        'Show1A
        '
        Me.Show1A.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Show1A.AutoSize = True
        Me.Show1A.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Show1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show1A.Location = New System.Drawing.Point(386, 160)
        Me.Show1A.Name = "Show1A"
        Me.Show1A.Size = New System.Drawing.Size(60, 20)
        Me.Show1A.TabIndex = 5
        Me.Show1A.Text = "Show"
        Me.Show1A.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(173, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Connexion"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(115, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "  "
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(113, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "  "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(479, 274)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Show1A)
        Me.Controls.Add(Me.Idpass)
        Me.Controls.Add(Me.Id_username)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Id_username As System.Windows.Forms.TextBox
    Friend WithEvents Idpass As System.Windows.Forms.TextBox
    Friend WithEvents Show1A As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
