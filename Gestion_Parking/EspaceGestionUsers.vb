Imports System.Net.Mail.MailAddress
Imports System.Threading.Thread
Public Class EspaceGestionUsers

    Private Sub EspaceGestionUsers_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim age As Integer = Date.Now.Year - Iddate.Value.Year
        Dim element As New ListViewItem
        Dim nom As String = Idname.Text
        Dim email As String = Idemail.Text
        Dim sexe As String = Idsexe.Text
        Dim sal As String = Idsh.Text
        Dim ddn As Date = Iddate.Value.ToShortDateString
        Dim mdp As String = Idmp.Text
        Dim cmdp As String = Idcmp.Text

        If nom = "" Or email = "" Or sexe = "" Or mdp = "" Or cmdp = "" Or sal = "" Or Idcnss.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or idtel.Text = "" Then
            MessageBox.Show("Donnez les élements")
        ElseIf mdp <> cmdp Then
            MessageBox.Show("Les mots de passe ne sont pas identiques")
        ElseIf Iddate.Value > Date.Now Or age <= 18 Then
            MessageBox.Show("Verifiez la date de naissance ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'ListView1.Items.Add(New ListViewItem({nom, email, Idcnss.Text, sal, sexe, ddn, mdp, ComboBox1.Text, ComboBox2.Text}))
            element.Text = Idname.Text
            element.SubItems.Add(Idemail.Text)
            element.SubItems.Add(Idcnss.Text)
            element.SubItems.Add(Idsh.Text)
            element.SubItems.Add(Idsexe.Text)
            element.SubItems.Add(Iddate.Value.ToShortDateString)
            element.SubItems.Add(Idmp.Text)
            element.SubItems.Add(ComboBox1.Text)
            element.SubItems.Add(ComboBox2.Text)
            element.SubItems.Add(idtel.Text)
            For i = 0 To DBU.ListView1.Items.Count - 1
                If element.SubItems(6).Text = DBU.ListView1.Items(i).SubItems(6).Text Or element.SubItems(9).Text = DBU.ListView1.Items(i).SubItems(9).Text Then
                    MessageBox.Show("User déjà récruté!")
                    element.Remove()
                    Exit For
                End If
            Next
            If (i = DBU.ListView1.Items.Count) Then
                DBU.ListView1.Items.Add(element)
                EspaceGestionVoitures.souvegarder(DBU.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
                If sexe = "Homme" Then
                    MessageBox.Show("M. " & nom & " est récruté")
                Else
                    MessageBox.Show("Mme. " & nom & " est récrutée")
                End If

                Idname.Clear()
                Idemail.Clear()
                Idcnss.Clear()
                Idsh.Clear()
                Iddate.Value = Date.Now
                Idmp.Clear()
                idtel.Clear()
                Idcmp.Clear()
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Idname.Clear()
        Idemail.Clear()
        Idcnss.Clear()
        Idsh.Clear()
        Iddate.Value = Now
        Idmp.Clear()
        Idcmp.Clear()
        idtel.Clear()
    End Sub

    Private Sub Show1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Show1.CheckedChanged
        Idmp.UseSystemPasswordChar = False
        If Show1.Checked = False Then
            Idmp.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Show2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Show2.CheckedChanged
        Idcmp.UseSystemPasswordChar = False
        If Show2.Checked = False Then
            Idcmp.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Idname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Idname.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
        If (Idname.Text.Contains("-") And e.KeyChar = "-") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Idname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idname.TextChanged
        If Strings.Len(Idname.Text) < 2 Or Strings.Left(Idname.Text, 1) = " " Or Strings.Left(Idname.Text, 1) = "-" Or Strings.Right(Idname.Text, 1) = "-" Then
            Idname.BackColor = Color.Red
            Button1.Enabled = False
            Button5.Enabled = False
        Else
            Idname.BackColor = Color.CornflowerBlue
            If CheckBox1.Checked = False Then
                Button1.Enabled = True
                Button5.Enabled = False
            Else
                Button1.Enabled = False
                Button5.Enabled = True
            End If
        End If
    End Sub

    Private Sub Idcnss_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Idcnss.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45) Then
            e.Handled = True
            Idcnss.BackColor = Color.Red
        Else
            Idcnss.BackColor = Color.CornflowerBlue
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
            Dim age As Integer = Date.Now.Year - Iddate.Value.Year
            Dim element As ListViewItem = DBU.ListView1.SelectedItems(0)
            Dim i As Integer
            For i = 0 To DBU.ListView1.Items.Count - 1
                If DBU.ListView1.Items(i).SubItems(2).Text = element.SubItems(2).Text Or DBU.ListView1.Items(i).SubItems(9).Text = element.SubItems(9).Text Then
                    Continue For
                End If
                If Idmp.Text = DBU.ListView1.Items(i).SubItems(6).Text Or idtel.Text = DBU.ListView1.Items(i).SubItems(9).Text Then
                    MessageBox.Show("User déjà récruté !")
                    Exit For
                End If
            Next
            If (i = DBU.ListView1.Items.Count) Then
                element.Text = Idname.Text
                element.SubItems(1).Text = Idemail.Text
                element.SubItems(2).Text = Idcnss.Text
                element.SubItems(3).Text = Idsh.Text
                element.SubItems(4).Text = Idsexe.Text
                element.SubItems(5).Text = Iddate.Value.ToShortDateString
                element.SubItems(6).Text = Idmp.Text
                element.SubItems(7).Text = ComboBox1.Text
                element.SubItems(9).Text = idtel.Text
                If Idname.Text = "" Or Idemail.Text = "" Or Idsexe.Text = "" Or Idmp.Text = "" Or Idcmp.Text = "" Or Iddate.Value.Year = Date.Now.Year Or ComboBox1.Text = "" Or idtel.Text = "" Then
                    MessageBox.Show("Entrez toutes les informations")
                ElseIf Idmp.Text <> Idcmp.Text Then
                    MessageBox.Show("Mot de passe et sa confirmaation sont différents!")
                ElseIf Iddate.Value > Date.Now Or age <= 18 Then
                    MessageBox.Show("Verifiez la date de naissance ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                EspaceGestionVoitures.souvegarder(DBU.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
                MessageBox.Show("User a été modifié(e)")
                Idname.Clear()
                Idemail.Clear()
                Idcnss.Clear()
                Idsh.Clear()
                idtel.Clear()
                Iddate.Value = Date.Now
                Idmp.Clear()
                Me.Hide()
                CheckBox1.Checked = False
                DBU.Show()

                End If

            End If

    End Sub

    Private Sub Idsh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Idsh.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 44) Then
            e.Handled = True
            Idsh.BackColor = Color.Red
        Else
            Idsh.BackColor = Color.CornflowerBlue
        End If
        If Idsh.Text.Contains(",") And e.KeyChar = "," Or Strings.Left(Idsh.Text, "1") = "," Then
            Idsh.BackColor = Color.Red
            e.Handled = True
        Else
            Idsh.BackColor = Color.CornflowerBlue
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment se déconnecter?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = DialogResult.Yes Then
            Form1.Show()
            Form1.Id_username.Clear()
            Form1.Idpass.Clear()
            Me.Hide()

        End If
    End Sub

    Private Function valid(ByVal email As String) As Boolean
        Try
            Dim em = New System.Net.Mail.MailAddress(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function validnum(ByVal num As String) As Boolean
        If (Strings.Left(num, 2) = "06" Or Strings.Left(num, 2) = "07") And Strings.Len(num) = 12 Then
            Return True
        End If
        Return False
    End Function

    Private Sub Idemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Idemail.TextChanged
        If valid(Idemail.Text) Then
            Idemail.BackColor = Color.CornflowerBlue
            If CheckBox1.Checked = False Then
                Button1.Enabled = True
                Button5.Enabled = True
            Else
                Button1.Enabled = False
                Button5.Enabled = True
            End If
        Else
            Idemail.BackColor = Color.Red
            Button1.Enabled = False
            Button5.Enabled = False
        End If
    End Sub

    Private Sub idtel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idtel.TextChanged
        If validnum(idtel.Text) Then
            idtel.BackColor = Color.CornflowerBlue
            If CheckBox1.Checked = False Then
                Button1.Enabled = True
                Button5.Enabled = True
            Else
                Button1.Enabled = False
                Button5.Enabled = True
            End If
        Else
            idtel.BackColor = Color.Red
            Button1.Enabled = False
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Sleep(350)
        GestionParking.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button1.Enabled = False
            Button6.Enabled = False
        Else
            Button1.Enabled = True
            Button6.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Sleep(350)
        DBU.Show()
        Me.Hide()
    End Sub


    Private Sub idtel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idtel.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            idtel.BackColor = Color.Red
        Else
            idtel.BackColor = Color.CornflowerBlue
        End If
    End Sub

    Private Sub EspaceGestionUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EspaceGestionVoitures.rechargerliste(DBU.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
    End Sub

End Class