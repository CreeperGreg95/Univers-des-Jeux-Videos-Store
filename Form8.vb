Public Class Form8
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Network.DownloadFile("https://visualstudio2022.000webhostapp.com/Documents/Défis_Minecraft_Dungeons_vacances.pdf", "C:\LUDJVStore\Docs\Défis Minecraft Dungeons v1.pdf")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Minecraft Dungeons arrivera dans quelques jours (vers le 08 août)", "Information")
    End Sub
End Class