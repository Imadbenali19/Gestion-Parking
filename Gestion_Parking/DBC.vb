Imports System.Threading.Thread
Public Class DBC

    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    Dim open As New OpenFileDialog
    '    open.Filter = "nom du fichier|*.txt"
    '    If open.ShowDialog = 1 Then
    '        EspaceGestionVoitures.rechargerliste(ListView1, open.FileName)
    '    End If
    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListView1.SelectedItems.Count > 0 Then
            EspaceGestionCamions.Button2.Visible = True
            EspaceGestionCamions.CheckBox1.Checked = True
            EspaceGestionCamions.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sélectionner un camion")
            EspaceGestionCamions.Button2.Visible = False
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            Try
                Dim element As ListViewItem = ListView1.SelectedItems(0)
                ListView1.Items.Remove(element)
            Catch ex As Exception

            End Try
            EspaceGestionVoitures.souvegarder(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCamions.txt")
            MessageBox.Show("Le camion a été Supprimé")
        Else
            MessageBox.Show("Sélectionner un camion")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListView1.SelectedItems.Count > 0 Then

            Try
                Dim element As ListViewItem = ListView1.SelectedItems(0)
                If Not IsDate(element.SubItems(5).Text) Then
                    element.SubItems(5).Text = IddateSC.Value
                    EspaceGestionCamions.cmpdc += 1
                    EspaceGestionVoitures.souvegarder(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCamions.txt")
                    MessageBox.Show("Le camion est sorti")
                    Button1.Enabled = True
                    Button2.Enabled = True
                    Button3.Enabled = True
                    Button4.Enabled = True

                    EspaceGestionCamions.IdchauffC.Enabled = True
                    EspaceGestionCamions.IdimmC.Enabled = True
                    EspaceGestionCamions.Idtonn.Enabled = True
                    EspaceGestionCamions.IdmarqueC.Enabled = True
                    EspaceGestionCamions.IddateEC.Enabled = True
                    EspaceGestionCamions.IdautretextC.Enabled = True
                    EspaceGestionCamions.RadioButton1.Enabled = True
                    EspaceGestionCamions.RadioButton2.Enabled = True
                    EspaceGestionCamions.IdautreC.Enabled = True
                Else
                    MessageBox.Show("Ce camion est déjà sorti!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception

            End Try

        Else
            MessageBox.Show("Sélectionnez un camion")
        End If
    End Sub

    Private Sub DB_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Sleep(350)
        EspaceGestionCamions.Show()
        Me.Hide()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            EspaceGestionCamions.Button1.Visible = False
            Try
                Dim el As ListViewItem = ListView1.SelectedItems(0)
                EspaceGestionCamions.IdchauffC.Text = el.SubItems(0).Text
                EspaceGestionCamions.IdimmC.Text = el.SubItems(1).Text
                EspaceGestionCamions.Idtonn.Text = el.SubItems(2).Text
                If el.SubItems(3).Text = EspaceGestionCamions.RadioButton1.Text Then
                    EspaceGestionCamions.RadioButton1.Checked = True
                ElseIf el.SubItems(3).Text = EspaceGestionCamions.RadioButton2.Text Then
                    EspaceGestionCamions.RadioButton1.Checked = True
                Else
                    EspaceGestionCamions.IdautreC.Checked = True
                    EspaceGestionCamions.IdautretextC.Visible = True
                    EspaceGestionCamions.IdautretextC.Text = el.SubItems(3).Text
                End If
                EspaceGestionCamions.IdmarqueC.Text = el.SubItems(3).Text
                EspaceGestionCamions.IddateEC.Value = el.SubItems(4).Text
                IddateSC.Value = el.SubItems(5).Text
                EspaceGestionCamions.Iddc.Text = el.SubItems(6).Text
            Catch ex As Exception

            End Try

        Else
            EspaceGestionCamions.Button2.Visible = False
            EspaceGestionCamions.Button1.Visible = True
            EspaceGestionCamions.IdchauffC.Clear()
            EspaceGestionCamions.IdimmC.Clear()
            EspaceGestionCamions.Idtonn.Text = ""
            EspaceGestionCamions.IdmarqueC.Text = ""
            EspaceGestionCamions.IddateEC.Text = Date.Now
            EspaceGestionCamions.Iddc.Clear()
        End If

    End Sub

    Private Sub IddateSC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IddateSC.ValueChanged
        If ListView1.SelectedItems.Count > 0 Then
            If IddateSC.Value < ListView1.SelectedItems(0).SubItems(4).Text Then
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                MessageBox.Show("verifier la date de sortie")
            Else
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = True
            End If
        End If

    End Sub

    'Private Sub DBC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'Dim open As New OpenFileDialog
    '    'open.Filter = "nom du fichier|*.txt"
    '    'If open.ShowDialog = 1 Then
    '    EspaceGestionVoitures.rechargerliste(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCamions.txt")
    '    'End If
    'End Sub


End Class