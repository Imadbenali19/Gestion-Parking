Imports System.Threading.Thread
Public Class Questionnaire1
    Public i As Integer
    Public element As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        For Me.i = 0 To DB.ListView1.Items.Count - 1
            element = DB.ListView1.Items(i).SubItems(1).Text
            If TextBox1.Text = DB.ListView1.Items(i).SubItems(1).Text Then
                EspaceGestionVoitures.CheckBox1.Checked = True
                Try
                    EspaceGestionVoitures.Idchauff.Text = DB.ListView1.Items(i).SubItems(0).Text
                    EspaceGestionVoitures.Idimm.Text = DB.ListView1.Items(i).SubItems(1).Text
                    EspaceGestionVoitures.Idnbplace.Text = DB.ListView1.Items(i).SubItems(2).Text
                    If DB.ListView1.Items(i).SubItems(3).Text = EspaceGestionVoitures.RadioButton1.Text Then
                        EspaceGestionVoitures.RadioButton1.Checked = True
                    ElseIf DB.ListView1.Items(i).SubItems(3).Text = EspaceGestionVoitures.RadioButton2.Text Then
                        EspaceGestionVoitures.RadioButton1.Checked = True
                    Else
                        EspaceGestionVoitures.IdautreV.Checked = True
                        EspaceGestionVoitures.Idautretext.Visible = True
                        EspaceGestionVoitures.Idautretext.Text = DB.ListView1.Items(i).SubItems(3).Text
                    End If
                    EspaceGestionVoitures.Idmarque.Text = DB.ListView1.Items(i).SubItems(3).Text
                    EspaceGestionVoitures.IddateE.Value = DB.ListView1.Items(i).SubItems(4).Text
                    EspaceGestionVoitures.Iddv.Text = DB.ListView1.Items(i).SubItems(6).Text
                Catch ex As Exception

                End Try

                Me.Hide()
                Sleep(250)
                EspaceGestionVoitures.Show()
                Exit For
            End If
        Next
        If i = DB.ListView1.Items.Count Then
            MessageBox.Show("Voiture introuvable!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Dim conf As DialogResult = MessageBox.Show("Essayez..?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If conf = DialogResult.No Then
                Me.Hide()
                Sleep(250)
                EspaceGestionVoitures.Show()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub Questionnaire1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Sleep(250)
        EspaceGestionVoitures.Show()
        Me.Hide()
    End Sub
End Class