Public Class Form7
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Il vous faut au minimum 6Go d'espace disque pour télécharger ce fichier !", "Informations à propos du fichier 'Win10_21H1_French_x64.iso' !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        My.Computer.Network.DownloadFile("https://software-download.microsoft.com/db/Win10_21H1_French_x64.iso?t=83449ab8-4c99-4fd7-8f4f-61fdee61154a&e=1627476680&h=683253ff47d4915e0e642f291102e8b5", "C:\LUDJVStore\OS\Windows\10\Win10_21H1_French_x64.iso")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Il vous faut au minimum 6Go d'espace disque pour télécharger ce fichier !", "Informations à propos du fichier 'Win10_20H2_French_x64.iso' !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        My.Computer.Network.DownloadFile("https://software-download.microsoft.com/db/Win10_20H2_French_x64.iso?t=6a4fcf0e-756d-48fa-b20b-1fbc20f74128&e=1627473981&h=8f38e4b26bd4f65cbe51ff204c651d64", "C:\LUDJVStore\OS\Windows\10\Win10_20H2_French_x64.iso")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Il vous faut au minimum 5Go d'espace disque pour télécharger ce fichier !", "Informations à propos du fichier 'Win10_2004_French_x64.iso' !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        My.Computer.Network.DownloadFile("https://software-download.microsoft.com/db/Win10_2004_French_x64.iso?t=69cdc01f-58ed-4a9b-962d-404c6731d0e4&e=1627477163&h=e1f0bdb577bd68defcd6c88660c4851c", "C:\LUDJVStore\OS\Windows\10\Win10_2004_French_x64.iso")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("L'ISO de Windows 111 est en beta, cela veut dire que ceci n'est pas la dernière vrsion de Windows 11", "Informations", MessageBoxButtons.OK)
        MessageBox.Show("Le programme que vous allez téléchargez fait environ 2 Ko mais l'ISO en fait 5 Go ! . Faites attention à votre espace disque !", "Informations", MessageBoxButtons.OK)
        My.Computer.Network.DownloadFile("https://visualstudio2022.000webhostapp.com/Applications%20Exceptionnelles/creatingISO_22000.51_en-us_amd64_professional.cmd", "C:\LUDJVStore\OS\Windows\11\creatingISO_22000.51_en-us_amd64_professional.cmd")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Windows 10 version 21H2 arrivera fin 2021 (vers octobre)", "Informations à propos de Windows 10 21H2")
    End Sub
End Class