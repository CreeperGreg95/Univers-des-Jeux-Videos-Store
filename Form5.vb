Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form8.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Network.DownloadFile("https://setup.rbxcdn.com/version-8181e7a1039c4c81-Roblox.exe", "C:\LUDJVStore\Apps\RobloxPlayerLauncher.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form10.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("This is the 1.18.15.0 update of this game. Please purchase it on Steam for pick it.")
        My.Computer.Network.DownloadFile("https://github.com/CreeperGreg95/MicrosoftFlightSimulator/releases/download/1.18.15.0/MicrosoftFlightSimulator.rar", "C:\LUDJVStore\Games\MicrosoftFlightSimulator.rar")
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Computer.Network.DownloadFile("https://github.com/CreeperGreg95/MicrosoftFlightSimulator/releases/download/1.18.15.0/MicrosoftFlightSimulator.rar", "C:\LUDJVStore\Games\MicrosoftFlightSimulator.rar")
    End Sub
End Class