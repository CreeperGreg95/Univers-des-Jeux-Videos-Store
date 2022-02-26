Public Class Form11
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("https://visualstudio2022.000webhostapp.com/License%20GNU%20General%20Public%20License%20%28GNU%20GPL%29%20LUDJVStore.txt", "C:\LUDJVStore\Copyrights\License%20GNU%20General%20Public%20License%20%28GNU%20GPL%29%20LUDJVStore.txt")
    End Sub
End Class