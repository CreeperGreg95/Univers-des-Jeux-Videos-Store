Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        My.Computer.Network.DownloadFile("https://visualstudio2022.000webhostapp.com/Musique%20de%20fond/ubisoft-logo.wav", "C:\LUDJVStore\Musics\ubisoft_logo.wav")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        My.Computer.Network.DownloadFile("https://visualstudio2022.000webhostapp.com/Musique%20de%20fond/ubisoft-logo.mp3", "C:\LUDJVStore\Musics\ubisoft_logo.mp3")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Network.DownloadFile("https://visualstudio2022.000webhostapp.com/Musique%20de%20fond/ubisoft-logo.ogg", "C:\LUDJVStore\Musics\ubisoft_logo.ogg")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Network.DownloadFile("https://visualstudio2022.000webhostapp.com/Musique%20de%20fond/ubisoft-logo.mp4", "C:\LUDJVStore\Musics\ubisoft_logo.mp4")
    End Sub
End Class