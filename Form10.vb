Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("https://otherprojects.000webhostapp.com/MinecraftStable/1.17.1.zip", "C:\LUDJVStore\Games\Minecraft\Stable_Version\1.17.1.zip")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Network.DownloadFile("https://otherprojects.000webhostapp.com/MinecraftDev/1.17.1.zip", "C:\LUDJVStore\Games\Minecraft\Development_Version\1.17.1.zip")
    End Sub
End Class