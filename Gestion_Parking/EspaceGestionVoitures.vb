Imports System.Drawing
Imports System.Windows.Forms.ListView
Imports System.Threading.Thread
Public Class EspaceGestionVoitures
    Public cmpd As Integer = 20 'qui compte le nbre des places dans Parking

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmpd = 0 Then
            MessageBox.Show("Pas de places disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Idchauff.Enabled = False
            Idimm.Enabled = False
            Idnbplace.Enabled = False
            Idmarque.Enabled = False
            IddateE.Enabled = False
            Idautretext.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            IdautreV.Enabled = False
        Else
            Dim i As Integer
            Dim element As New ListViewItem
            Dim chauff As String = Idchauff.Text
            Dim imm As String = Idimm.Text
            Dim nbplace As String = Idnbplace.Text
            Dim dateE As Date = IddateE.Value
            Dim marque As String
            If RadioButton1.Checked Then
                marque = "Dacia" '=RadioButton1.Text
            ElseIf RadioButton2.Checked Then
                marque = RadioButton2.Text
            Else
                marque = Idautretext.Text
            End If
            If chauff = "" Or imm = "" Or nbplace = "" Or marque = "" Or Iddv.Text = "" Then
                MessageBox.Show("Entrez toutes les informations")
            Else

                'DB.ListView1.Items.Add(New ListViewItem({chauff, imm, nbplace, marque, dateE}))

                element.Text = Idchauff.Text
                element.SubItems.Add(Idimm.Text)
                element.SubItems.Add(Idnbplace.Text)
                element.SubItems.Add(marque)
                element.SubItems.Add(IddateE.Value)
                element.SubItems.Add("")
                element.SubItems.Add(Iddv.Text)

                For i = 0 To DB.ListView1.Items.Count - 1
                    If element.SubItems(1).Text = DB.ListView1.Items(i).SubItems(1).Text Then
                        MessageBox.Show("Cette voiture est déjà ajoutée!")
                        element.Remove()
                        Exit For
                    End If
                Next
                If (i = DB.ListView1.Items.Count) Then
                    cmpd = cmpd - 1
                    DB.ListView1.Items.Add(element)
                    souvegarder(DB.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoVoitures.txt")
                    MessageBox.Show("La voiture a été ajoutée")
                    Idchauff.Clear()
                    Idimm.Clear()
                    IddateE.Value = Now
                    Idautretext.Clear()
                    Iddv.Clear()
                    Idautretext.Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    IdautreV.Checked = False
                End If


            End If

        End If
    End Sub

    Private Sub IdautreV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdautreV.CheckedChanged
        Idautretext.Visible = True
        If IdautreV.Checked = False Then
            Idautretext.Visible = False
        End If
    End Sub

    Private Sub Idchauff_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idchauff.TextChanged
        If Strings.Len(Idchauff.Text) < 2 Or Strings.Left(Idchauff.Text, 1) = " " Or Strings.Left(Idchauff.Text, 1) = "-" Or Strings.Right(Idchauff.Text, 1) = "-" Then
            Idchauff.BackColor = Color.Red
            Button1.Enabled = False
        Else
            Idchauff.BackColor = Color.Gainsboro

            If CheckBox1.Checked Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If

        End If
    End Sub

    Private Sub Idchauff_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Idchauff.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
        If Idchauff.Text.Contains("-") And e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Idimm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Idimm.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Idimm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idimm.TextChanged
        Try
            If Not ((Asc(Strings.Left(Idimm.Text, 1)) >= 65 And Asc(Strings.Left(Idimm.Text, 1)) <= 90) Or (Asc(Strings.Left(Idimm.Text, 1)) >= 97 And Asc(Strings.Left(Idimm.Text, 1)) <= 122) Or (Asc(Strings.Left(Idimm.Text, 1)) >= 48 And Asc(Strings.Left(Idimm.Text, 1)) <= 57)) Then
                Label8.Visible = True
                Button1.Enabled = False
            Else
                Label8.Visible = False
                If CheckBox1.Checked Then
                    Button1.Enabled = False
                Else
                    Button1.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IddateE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IddateE.ValueChanged
        If IddateE.Value > Date.Now Then
            Button1.Enabled = False
            MessageBox.Show("verifier la date d'entrée")
        Else
            If CheckBox1.Checked Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If

        End If
    End Sub

    Private Sub Idautretext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Idautretext.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            Idautretext.BackColor = Color.Red
        Else
            Idautretext.BackColor = Color.White
        End If

    End Sub

    Public Sub Enregistreliste(ByVal liste As ListView, ByVal fichier As String)
        Dim sep1 As String = " (|) "
        Dim sep2 As String = " \n "
        Dim build As New System.Text.StringBuilder()
        For Each element As ListViewItem In liste.Items
            For i As Integer = 0 To liste.Columns.Count - 1
                Try
                    build.Append(element.SubItems(i).Text)
                Catch ex As Exception

                End Try

                If i < liste.Columns.Count - 1 Then
                    build.Append(sep1)
                End If
            Next
            build.Append(sep2)
        Next
        Try
            IO.File.WriteAllText(fichier, build.ToString)
            MessageBox.Show("Souvegardé!")
        Catch ex As Exception
            MessageBox.Show("Erreur!")
        End Try
    End Sub
    
    Public Sub souvegarder(ByVal liste As ListView, ByVal fichier As String)
        'Dim sauvc As New SaveFileDialog
        'sauvc.Filter = "fichierText|*.txt"
        'If sauvc.ShowDialog = 1 Then
        Enregistreliste(liste, fichier)
        'End If
    End Sub

    Public Sub rechargerliste(ByVal liste As ListView, ByVal fichier As String)
        liste.Items.Clear()
        Dim sep1 As String = " (|) "
        Dim sep2 As String = " \n "
        Try
            If IO.File.Exists(fichier) Then
                Dim data As String = IO.File.ReadAllText(fichier)
                Dim chaine() As String = data.Split({sep2}, StringSplitOptions.RemoveEmptyEntries)
                For Each element As String In chaine
                    If element.Contains(sep1) Then
                        Dim val() As String = element.Split({sep1}, StringSplitOptions.None)
                        Dim elt As New ListViewItem
                        For i As Integer = 0 To val.Length - 1
                            If i = 0 Then
                                elt.Text = val(i)
                            Else
                                elt.SubItems.Add(val(i))
                            End If
                        Next
                        liste.Items.Add(elt)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Sleep(250)
        DB.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim i As Integer
        For i = 0 To DB.ListView1.Items.Count - 1
            If DB.ListView1.Items(i).SubItems(1).Text = Questionnaire1.element Then
                Continue For
            End If
            If Idimm.Text = DB.ListView1.Items(i).SubItems(1).Text Then
                MessageBox.Show("Voiture déjà existe !")
                Exit For
            End If
        Next

        If i = DB.ListView1.Items.Count Then


            If Idchauff.Text <> "" Then
                DB.ListView1.Items(Questionnaire1.i).SubItems(0).Text = Idchauff.Text
                DB.ListView1.Items(Questionnaire1.i).SubItems(1).Text = Idimm.Text
                DB.ListView1.Items(Questionnaire1.i).SubItems(2).Text = Idnbplace.Text
                If RadioButton1.Checked Then
                    DB.ListView1.Items(Questionnaire1.i).SubItems(3).Text = RadioButton1.Text
                ElseIf RadioButton2.Checked Then
                    DB.ListView1.Items(Questionnaire1.i).SubItems(3).Text = RadioButton2.Text
                ElseIf IdautreV.Checked Then
                    Idautretext.Visible = True
                    DB.ListView1.Items(Questionnaire1.i).SubItems(3).Text = Idautretext.Text
                End If
                DB.ListView1.Items(Questionnaire1.i).SubItems(4).Text = IddateE.Value
                DB.ListView1.Items(Questionnaire1.i).SubItems(6).Text = Iddv.Text

                If Idchauff.Text = "" Or Idimm.Text = "" Or Idnbplace.Text = "" Or Idmarque.Text = "" Or Iddv.Text = "" Then
                    MessageBox.Show("Entrez toutes les informations")
                Else
                    souvegarder(DB.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoVoitures.txt")
                    MessageBox.Show("La voiture a été modifiée")
                    CheckBox1.Checked = False
                    Idchauff.Clear()
                    Idimm.Clear()
                    IddateE.Value = Now
                    Idautretext.Clear()
                    Iddv.Clear()
                    Idautretext.Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    IdautreV.Checked = False
                End If

            Else
                Sleep(250)
                Questionnaire1.Show()
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub EspaceGestionVoitures_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Sleep(350)
        GestionParking.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment se déconnecter?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = DialogResult.Yes Then
            Form1.Show()
            Form1.Id_username.Clear()
            Form1.Idpass.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub Iddv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Iddv.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            Iddv.BackColor = Color.Red
        Else
            Iddv.BackColor = Color.Silver
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub EspaceGestionVoitures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rechargerliste(DB.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoVoitures.txt")

        If cmpd = 0 Then

            MessageBox.Show("Pas de places disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Idchauff.Enabled = False
            Idimm.Enabled = False
            Idnbplace.Enabled = False
            Idmarque.Enabled = False
            IddateE.Enabled = False
            Idautretext.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            IdautreV.Enabled = False
        Else
            Idchauff.Enabled = True
            Idimm.Enabled = True
            Idnbplace.Enabled = True
            Idmarque.Enabled = True
            IddateE.Enabled = True
            Idautretext.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            IdautreV.Enabled = True
        End If
    End Sub

End Class