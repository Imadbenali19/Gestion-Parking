Imports System.Drawing
Imports System.Threading.Thread
Public Class EspaceGestionCamions
    Public cmpdc As Integer = 15
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmpdc = 0 Then

            MessageBox.Show("Pas de places disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IdchauffC.Enabled = False
            IdimmC.Enabled = False
            Idtonn.Enabled = False
            IdmarqueC.Enabled = False
            IddateEC.Enabled = False
            IdautretextC.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            IdautreC.Enabled = False
        Else
            Dim i As Integer
            Dim element As New ListViewItem
            Dim chauffC As String = IdchauffC.Text
            Dim immC As String = IdimmC.Text
            Dim tng As String = Idtonn.Text
            Dim dateEC As Date = IddateEC.Value
            Dim marqueC As String
            If RadioButton1.Checked Then
                marqueC = "MAN" '=RadioButton1.Text
            ElseIf RadioButton2.Checked Then
                marqueC = RadioButton2.Text
            Else
                marqueC = IdautretextC.Text
            End If
            If chauffC = "" Or immC = "" Or tng = "" Or marqueC = "" Or Iddc.Text = "" Then
                MessageBox.Show("Entrez toutes les informations")
            Else

                'DBC.ListView1.Items.Add(New ListViewItem({chauffC, immC, tng, marqueC, dateEC}))

                element.Text = IdchauffC.Text
                element.SubItems.Add(IdimmC.Text)
                element.SubItems.Add(Idtonn.Text)
                element.SubItems.Add(marqueC)
                element.SubItems.Add(IddateEC.Value)
                element.SubItems.Add("")
                element.SubItems.Add(Iddc.Text)

                For i = 0 To DBC.ListView1.Items.Count - 1
                    If element.SubItems(1).Text = DBC.ListView1.Items(i).SubItems(1).Text Then
                        MessageBox.Show("Ce camion est déjà ajouté!")
                        element.Remove()
                        Exit For
                    End If
                Next
                If (i = DBC.ListView1.Items.Count) Then
                    cmpdc = cmpdc - 1
                    DBC.ListView1.Items.Add(element)
                    EspaceGestionVoitures.souvegarder(DBC.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCamions.txt")
                    MessageBox.Show("Le camion a été ajouté")
                    IdchauffC.Clear()
                    IdimmC.Clear()
                    Idtonn.Clear()
                    IddateEC.Value = Now
                    IdautretextC.Clear()
                    Iddc.Clear()
                    IdautretextC.Visible = False
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    IdautreC.Checked = False
                End If

            End If

        End If

    End Sub

    Private Sub IdautreC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdautreC.CheckedChanged
        IdautretextC.Visible = True
        If IdautreC.Checked = False Then
            IdautretextC.Visible = False
        End If
    End Sub

    Private Sub IdchauffC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdchauffC.TextChanged
        If Strings.Len(IdchauffC.Text) < 2 Or Strings.Left(IdchauffC.Text, 1) = " " Or Strings.Left(IdchauffC.Text, 1) = "-" Or Strings.Right(IdchauffC.Text, 1) = "-" Then
            IdchauffC.BackColor = Color.Red
            Button1.Enabled = False
        Else
            IdchauffC.BackColor = Color.Silver
            If CheckBox1.Checked = False Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub IdchauffC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IdchauffC.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
        If IdchauffC.Text.Contains("-") And e.KeyChar = "-" Then
            e.Handled = True
        End If
        
    End Sub

    Private Sub IdimmC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IdimmC.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub IdimmC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdimmC.TextChanged
        Try
            If Not ((Asc(Strings.Left(IdimmC.Text, 1)) >= 65 And Asc(Strings.Left(IdimmC.Text, 1)) <= 90) Or (Asc(Strings.Left(IdimmC.Text, 1)) >= 97 And Asc(Strings.Left(IdimmC.Text, 1)) <= 122) Or (Asc(Strings.Left(IdimmC.Text, 1)) >= 48 And Asc(Strings.Left(IdimmC.Text, 1)) <= 57)) Then
                Label8.Visible = True
                Button1.Enabled = False
            Else
                Label8.Visible = False
                If CheckBox1.Checked = False Then
                    Button1.Enabled = True
                Else
                    Button1.Enabled = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IddateEC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IddateEC.ValueChanged
        If IddateEC.Value > Date.Now Then
            Button1.Enabled = False
            MessageBox.Show("verifier la date d'entrée")
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub IdautretextC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IdautretextC.KeyPress
        If Not ((Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            IdautretextC.BackColor = Color.Red
        Else
            IdautretextC.BackColor = Color.White
        End If
    End Sub

    Private Sub Idtonn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Idtonn.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 44) Then
            e.Handled = True
            Idtonn.BackColor = Color.Red
        Else
            Idtonn.BackColor = Color.Silver
        End If
        If Idtonn.Text.Contains(",") And e.KeyChar = "," Or Strings.Left(Idtonn.Text, "1") = "," Then
            Idtonn.BackColor = Color.Red
            e.Handled = True
        Else
            Idtonn.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Sleep(350)
        DBC.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim element As ListViewItem = DBC.ListView1.SelectedItems(0)
        Dim i As Integer
        For i = 0 To DBC.ListView1.Items.Count - 1
            If DBC.ListView1.Items(i).SubItems(1).Text = element.SubItems(1).Text Then
                Continue For
            End If
            If IdimmC.Text = DBC.ListView1.Items(i).SubItems(1).Text Then
                MessageBox.Show("Camion déjà existe !")
                Exit For
            End If
        Next
        If (i = DBC.ListView1.Items.Count) Then
            element.Text = IdchauffC.Text
            element.SubItems(1).Text = IdimmC.Text
            element.SubItems(2).Text = Idtonn.Text
            If RadioButton1.Checked Then
                element.SubItems(3).Text = RadioButton1.Text
            ElseIf RadioButton2.Checked Then
                element.SubItems(3).Text = RadioButton2.Text
            ElseIf IdautreC.Checked Then
                IdautretextC.Visible = True
                element.SubItems(3).Text = IdautretextC.Text
            End If
            element.SubItems(4).Text = IddateEC.Value
            element.SubItems(6).Text = Iddc.Text
            If IdchauffC.Text = "" Or IdimmC.Text = "" Or Idtonn.Text = "" Or IdmarqueC.Text = "" Or Iddc.Text = "" Then
                MessageBox.Show("Entrez toutes les informations")
            Else
                EspaceGestionVoitures.souvegarder(DBC.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCamions.txt")
                MessageBox.Show("Le camion a été modifié")
                IdchauffC.Clear()
                IdimmC.Clear()
                IddateEC.Value = Now
                IdautretextC.Clear()
                Iddc.Clear()
                IdautretextC.Visible = False
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                IdautreC.Checked = False

                Me.Hide()
                CheckBox1.Checked = False
                DBC.Show()
            End If

        End If
    End Sub

    Private Sub EspaceGestionCamions_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment se déconnecter?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = DialogResult.Yes Then
            Form1.Show()
            Form1.Id_username.Clear()
            Form1.Idpass.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub ButtonA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonA.Click
        Sleep(350)
        GestionParking.Show()
        Me.Hide()
    End Sub

    Private Sub Iddc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Iddc.KeyPress
        If Not ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            Iddc.BackColor = Color.Red
        Else
            Iddc.BackColor = Color.Silver
        End If
    End Sub

    Private Sub EspaceGestionCamions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EspaceGestionVoitures.rechargerliste(DBC.ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCamions.txt")
        If cmpdc = 0 Then

            MessageBox.Show("Pas de places disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IdchauffC.Enabled = False
            IdimmC.Enabled = False
            Idtonn.Enabled = False
            IdmarqueC.Enabled = False
            IddateEC.Enabled = False
            IdautretextC.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            IdautreC.Enabled = False
        Else
            IdchauffC.Enabled = True
            IdimmC.Enabled = True
            Idtonn.Enabled = True
            IdmarqueC.Enabled = True
            IddateEC.Enabled = True
            IdautretextC.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            IdautreC.Enabled = True
        End If

    End Sub

    
End Class