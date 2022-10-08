Imports System.Threading.Thread
Public Class Comptabilité
    Dim rv(10), rvc(10) As Double
    Private Sub Comptabilité_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim conf As DialogResult = MessageBox.Show("Voulez vous vraiment fermer la fenêtre?", "Fermer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If conf = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            If ListView1.Items.Count > 0 Then
                EspaceGestionVoitures.souvegarder(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCompta.txt")
            End If
        End If
    End Sub

    Public Sub recharger(ByVal tab() As Double, ByVal fichier As String)
        Dim sep1 As String = " (|) "
        Dim sep2 As String = " \n "
        Dim j As Integer = 0
        Try
            If IO.File.Exists(fichier) Then
                Dim data As String = IO.File.ReadAllText(fichier)
                Dim chaine() As String = data.Split({sep2}, StringSplitOptions.RemoveEmptyEntries)
                For Each element As String In chaine
                    If element.Contains(sep1) Then
                        Dim val() As String = element.Split({sep1}, StringSplitOptions.None)
                        For i As Integer = 0 To val.Length - 1
                            If i = 5 Then
                                If IsDate(val(5)) Then
                                    tab(j) = val(i + 1)
                                    j += 1
                                End If
                            End If
                        Next
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListView1.Items.Count > 0 Then
            EspaceGestionVoitures.souvegarder(ListView1, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCompta.txt")
        End If
        Sleep(500)
        GestionParking.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr(10), drc(10), s, s1 As Double
        Dim i As Integer
        recharger(rv, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoVoitures.txt")
        recharger(rvc, "C:\Users\dell\Desktop\My proj vb.net\Projet-Parking\Gestion_Parking\InfoCamions.txt")

        For i = 0 To rv.Length - 1
            Select Case (rv(i))
                Case Is <= 60
                    dr(i) = 5
                Case Is <= 120
                    dr(i) = 8
                Case Is <= 180
                    dr(i) = 10
                Case Is <= 240
                    dr(i) = 12
                Case Is <= 300
                    dr(i) = 14
                Case Is <= 360
                    dr(i) = 16
                Case Is <= 720
                    dr(i) = 20
                Case Else
                    dr(i) = 30
            End Select
        Next
        For i = 0 To rvc.Length - 1
            Select Case (rvc(i))
                Case Is <= 60
                    drc(i) = 9
                Case Is <= 120
                    drc(i) = 12
                Case Is <= 180
                    drc(i) = 14
                Case Is <= 240
                    drc(i) = 16
                Case Is <= 300
                    drc(i) = 18
                Case Is <= 360
                    drc(i) = 20
                Case Is <= 720
                    drc(i) = 24
                Case Else
                    drc(i) = 35
            End Select
        Next
        s = 0
        s1 = 0
        For i = 0 To rv.Length - 1
            s = (dr(i) * rv(i)) + s
        Next
        For i = 0 To rvc.Length - 1
            s1 = (drc(i) * rvc(i)) + s1
        Next
        ListView1.Items.Add(New ListViewItem({s, s1, 0}))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListView1.Items.Count > 0 Then
            Dim calc As Double

            calc = CInt(ListView1.Items(0).SubItems(0).Text) + CInt(ListView1.Items(0).SubItems(1).Text)
            MessageBox.Show("Votre revenue total est : " & calc)
            Try
                ListView1.Items(0).SubItems(2).Text = calc

            Catch ex As Exception

            End Try

        Else
            MessageBox.Show("Cliquer d'abord sur le boutton CHARGER ")
        End If

    End Sub
End Class