Imports System.Threading.Thread
Public Class Questionnaire2vb
    Public i As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Me.i = 0 To DB.ListView1.Items.Count - 1
            If TextBox1.Text = DB.ListView1.Items(i).SubItems(1).Text Then

                Try
                    DB.ListView1.Items.Remove(DB.ListView1.Items(i))
                Catch ex As Exception

                End Try
                EspaceGestionVoitures.souvegarder(DB.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoVoitures.txt")
                MessageBox.Show("La voiture a été Supprimée")

                Me.Hide()
                Sleep(250)
                DB.Show()
                TextBox1.Clear()
                GoTo l
            End If
        Next
        If i = DB.ListView1.Items.Count Then
            MessageBox.Show("Voiture introuvable!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Dim conf As DialogResult = MessageBox.Show("Essayez..?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If conf = DialogResult.No Then
                Me.Hide()
                Sleep(250)
                DB.Show()
                TextBox1.Clear()
            Else
                Me.Show()
            End If
        End If
l:
    End Sub

    Private Sub Questionnaire2vb_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Sleep(250)
        DB.Show()
        Me.Hide()
    End Sub
End Class