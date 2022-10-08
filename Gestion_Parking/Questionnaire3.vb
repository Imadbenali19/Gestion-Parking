Imports System.Threading.Thread
Public Class Questionnaire3
    Public i As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        For Me.i = 0 To DB.ListView1.Items.Count - 1
            If TextBox1.Text = DB.ListView1.Items(i).SubItems(1).Text Then

                Button1.Enabled = True

                    Try
                    If Not IsDate(DB.ListView1.Items(i).SubItems(5).Text) Then

                        DB.ListView1.Items(i).SubItems(5).Text = Date.Now
                        EspaceGestionVoitures.cmpd += 1
                        EspaceGestionVoitures.souvegarder(DB.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoVoitures.txt")
                        MessageBox.Show("La voiture est sortie")

                        EspaceGestionVoitures.Idchauff.Enabled = True
                        EspaceGestionVoitures.Idimm.Enabled = True
                        EspaceGestionVoitures.Idnbplace.Enabled = True
                        EspaceGestionVoitures.Idmarque.Enabled = True
                        EspaceGestionVoitures.IddateE.Enabled = True
                        EspaceGestionVoitures.Idautretext.Enabled = True
                        EspaceGestionVoitures.RadioButton1.Enabled = True
                        EspaceGestionVoitures.RadioButton2.Enabled = True
                        EspaceGestionVoitures.IdautreV.Enabled = True
                    Else
                        MessageBox.Show("Cette est déjà sortie!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If

                    Catch ex As Exception

                    End Try

                    Me.Hide()
                    Sleep(250)
                    DB.Show()
                    Exit For


            End If
        Next
        If i = DB.ListView1.Items.Count Then
            MessageBox.Show("Voiture introuvable!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Dim conf As DialogResult = MessageBox.Show("Essayez..?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If conf = DialogResult.No Then
                Me.Hide()
                Sleep(250)
                DB.Show()
            Else
                Me.Show()
            End If
        End If
    End Sub

    Private Sub Questionnaire3_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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