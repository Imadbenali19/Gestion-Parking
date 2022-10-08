Imports System.Threading.Thread
Public Class Form1
    Public i As Integer
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim gp As New GestionParking 'gestionParking est comme un type comme Integer,string
        If (Id_username.Text = "admin" And Idpass.Text = "admin") Then
            MessageBox.Show("Connexion...")
            Sleep(500)
            gp.Show()
            Me.Hide()

        Else
            EspaceGestionVoitures.rechargerliste(DBU.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
            For Me.i = 0 To DBU.ListView1.Items.Count - 1
                If Id_username.Text = DBU.ListView1.Items(i).SubItems(0).Text And Idpass.Text = DBU.ListView1.Items(i).SubItems(6).Text Then
                    If DBU.ListView1.Items(i).SubItems(8).Text = "Oui" Then
                        MessageBox.Show("Connexion...")
                        Sleep(500)
                        gp.Show()
                        Me.Hide()
                        GoTo l
                    End If
                    GoTo l1
                End If
            Next
            If Me.i = DBU.ListView1.Items.Count Then
                MessageBox.Show("Login/Mot de passe ne sont pas correctes")
                GoTo l
            End If
l1:
            MessageBox.Show("Désolé, vous êtes bloqués pour le moment!")

l:
        End If

    End Sub

    Private Sub Show1A_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Show1A.CheckedChanged
        Idpass.UseSystemPasswordChar = False
        If Show1A.Checked = False Then
            Idpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class
