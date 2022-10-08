Imports System.Threading.Thread
Public Class DB

    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    Dim open As New OpenFileDialog
    '    open.Filter = "nom du fichier|*.txt"
    '    If open.ShowDialog = 1 Then
    '        EspaceGestionVoitures.rechargerliste(ListView1, open.FileName)
    '    End If
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Sleep(250)
        Questionnaire2vb.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Sleep(250)
        Questionnaire3.Show()
        Me.Hide()
    End Sub

    Private Sub DB_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Sleep(350)
        EspaceGestionVoitures.Show()
    End Sub

    'Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
    '    If ListView1.SelectedItems.Count > 0 Then
    '        Try
    '            Dim el As ListViewItem = ListView1.SelectedItems(0)
    '            EspaceGestionVoitures.Idchauff.Text = el.SubItems(0).Text
    '            EspaceGestionVoitures.Idimm.Text = el.SubItems(1).Text
    '            EspaceGestionVoitures.Idnbplace.Text = el.SubItems(2).Text
    '            If el.SubItems(3).Text = EspaceGestionVoitures.RadioButton1.Text Then
    '                EspaceGestionVoitures.RadioButton1.Checked = True
    '            ElseIf el.SubItems(3).Text = EspaceGestionVoitures.RadioButton2.Text Then
    '                EspaceGestionVoitures.RadioButton1.Checked = True
    '            Else
    '                EspaceGestionVoitures.IdautreV.Checked = True
    '                EspaceGestionVoitures.Idautretext.Visible = True
    '                EspaceGestionVoitures.Idautretext.Text = el.SubItems(3).Text
    '            End If
    '            EspaceGestionVoitures.Idmarque.Text = el.SubItems(3).Text
    '            EspaceGestionVoitures.IddateE.Value = el.SubItems(4).Text
    '            IddateS.Value = el.SubItems(5).Text
    '            EspaceGestionVoitures.Iddv.Text = el.SubItems(6).Text
    '        Catch ex As Exception

    '        End Try

    '    Else
    '        EspaceGestionVoitures.Idchauff.Clear()
    '        EspaceGestionVoitures.Idimm.Clear()
    '        EspaceGestionVoitures.Iddv.Clear()
    '        EspaceGestionVoitures.Idnbplace.Text = ""
    '        EspaceGestionVoitures.Idmarque.Text = ""
    '        EspaceGestionVoitures.IddateE.Text = Date.Now
    '    End If

    'End Sub


    'Private Sub DB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'Dim open As New OpenFileDialog
    '    'open.Filter = "nom du fichier|*.txt"
    '    'If open.ShowDialog = 1 Then
    '    EspaceGestionVoitures.rechargerliste(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoVoitures.txt")
    '    'End If
    'End Sub

End Class