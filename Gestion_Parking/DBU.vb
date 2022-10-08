Imports System.Threading.Thread
Public Class DBU

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Sleep(350)
        EspaceGestionUsers.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            Try
                Dim element As ListViewItem = ListView1.SelectedItems(0)
                If element.SubItems(8).Text = "Non" Then
                    MessageBox.Show("Cet employé est déjà blocké ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    element.SubItems(8).Text = "Non"
                    EspaceGestionVoitures.souvegarder(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
                    MessageBox.Show("User a été bloqué(e)")
                End If

            Catch ex As Exception

            End Try

        Else
            MessageBox.Show("Sélectionnez un user")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            EspaceGestionUsers.Button1.Visible = False
            EspaceGestionUsers.ComboBox2.Enabled = False
            Try
                Dim el As ListViewItem = ListView1.SelectedItems(0)
                EspaceGestionUsers.Idname.Text = el.SubItems(0).Text
                EspaceGestionUsers.Idemail.Text = el.SubItems(1).Text
                EspaceGestionUsers.Idcnss.Text = el.SubItems(2).Text
                EspaceGestionUsers.Idsh.Text = el.SubItems(3).Text
                EspaceGestionUsers.Idsexe.Text = el.SubItems(4).Text
                EspaceGestionUsers.Iddate.Value = el.SubItems(5).Text
                EspaceGestionUsers.Idmp.Text = el.SubItems(6).Text
                EspaceGestionUsers.ComboBox1.Text = el.SubItems(7).Text
                EspaceGestionUsers.ComboBox2.Text = el.SubItems(8).Text
                EspaceGestionUsers.idtel.Text = el.SubItems(9).Text
            Catch ex As Exception

            End Try

        Else
            EspaceGestionUsers.Button5.Visible = False
            EspaceGestionUsers.ComboBox2.Enabled = True
            EspaceGestionUsers.Idname.Clear()
            EspaceGestionUsers.Idemail.Clear()
            EspaceGestionUsers.Idcnss.Clear()
            EspaceGestionUsers.Idsh.Clear()
            EspaceGestionUsers.Iddate.Value = Date.Now
            EspaceGestionUsers.Idmp.Clear()
            EspaceGestionUsers.idtel.Clear()
            EspaceGestionUsers.Button1.Visible = True

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ListView1.SelectedItems.Count > 0 Then
            Try
                Dim element As ListViewItem = ListView1.SelectedItems(0)
                If element.SubItems(8).Text = "Non" Then
                    element.SubItems(8).Text = "Oui"
                    EspaceGestionVoitures.souvegarder(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
                    MessageBox.Show("User a été débloqué(e)")
                Else
                    MessageBox.Show("Cet employé n'est pas blocké ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Sélectionnez un user")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListView1.SelectedItems.Count > 0 Then
            Try
                Dim element As ListViewItem = ListView1.SelectedItems(0)
                ListView1.Items.Remove(element)
            Catch ex As Exception

            End Try
            EspaceGestionVoitures.souvegarder(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
            MessageBox.Show("User a été Supprimé(e)")
        Else
            MessageBox.Show("Sélectionner un user")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count > 0 Then
            EspaceGestionUsers.Button5.Visible = True
            EspaceGestionUsers.CheckBox1.Checked = True
            EspaceGestionUsers.Show()
            Me.Hide()
        Else
            MessageBox.Show("sélectionner un user")
            EspaceGestionUsers.Button5.Visible = False
        End If
    End Sub

    'Private Sub DBU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'Dim open As New OpenFileDialog
    '    'open.Filter = "nom du fichier|*.txt"
    '    'If open.ShowDialog = 1 Then
    '    EspaceGestionVoitures.rechargerliste(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
    '    'End If
    'End Sub

    Private Sub DBU_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class