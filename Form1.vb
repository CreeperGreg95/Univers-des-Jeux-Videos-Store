Public Class Form1
    Public Property Play As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MessageBox.Show("Version : ?!$ùù^*              Type de version : $ù?!$ù/:.", "Précision des Versions")
    End Sub

    Private Sub VérifierLesMisesÀJourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VérifierLesMisesÀJourToolStripMenuItem.Click
        MessageBox.Show("Aucune mise à jour disponible sur les serveurs de l'application car le support est 'peut-être' terminé !", "Informations mises à jour")
    End Sub

    Private Sub AProposDeLapplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposDeLapplicationToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub MusiquesDeLapplicationToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Ubisoft Logo Intro - 2009", "Musique", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form3.Show()

    End Sub

    Private Sub PatchNotesDeLaVersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatchNotesDeLaVersionToolStripMenuItem.Click
        MessageBox.Show("Fin du support du logiciel 'officiellement' (enfin, peut-être)", "Patch Notes de la version ù^$^ù$?!l;l;ù")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Pas disponible")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = 1000000 Then
            Timer1.Stop()
            MsgBox("Le chargement du programme a bien été effectué ! Vous pouvez fermer cette fenêtre avec le bouton 'OK' ")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Start()
        MessageBox.Show("Pas disponible")
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        MessageBox.Show("Si vous avez des problèmes avec l'application, des bugs, des crashs ou des problème de téléchargements ? Contactez 1?3m/$ù/$", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub LicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem.Click
        Form11.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("?;!;,!;.:§$ù$^$518", "SyStEm ErRor, PlEaSe UpDaTe-It")
    End Sub
End Class