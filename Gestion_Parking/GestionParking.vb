Imports System.Threading.Thread
Public Class GestionParking

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim egv As New EspaceGestionVoitures
        Sleep(500)
        egv.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim egc As New EspaceGestionCamions
        Sleep(500)
        egc.Show()
        Me.Hide()
    End Sub

    Private Sub GestionParking_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim egu As New EspaceGestionUsers 'gestionParking est comme un type comme Integer,string
        If (Form1.Id_username.Text = "admin" And Form1.Idpass.Text = "admin") Then
            Sleep(500)
            egu.Show()
            Me.Hide()

        Else
            EspaceGestionVoitures.rechargerliste(DBU.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoUsers.txt")
            If DBU.ListView1.Items(Form1.i).SubItems(7).Text = "Oui" Then
                Sleep(500)
                egu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Désolé, vous n'avez pas l'accès à ce champs!")
            End If


        End If


    End Sub

    Private Sub GestionParking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form1.Id_username.Text = "admin" And Form1.Idpass.Text = "admin" Then
            Button4.Visible = True
        Else
            Button4.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim gc As New Comptabilité
        Sleep(500)
        gc.Show()
        Me.Hide()
    End Sub
End Class