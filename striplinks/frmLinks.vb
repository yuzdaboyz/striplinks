Imports System.Text.RegularExpressions

Public Class frmLinks
    Public Shared URL As New Regex("(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#()]*[\w\-\@?^=%&amp;/~\+#()])", RegexOptions.Compiled)
    Public FileTypes As Array = My.Settings.FileTypes.Split(" ")
    ' Public FileTypes As Array = {".rar", ".zip", ".7z", ".exe"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Clipboard.ContainsText = True Then
            rtxt1.Lines = ParseLinks(Clipboard.GetText()).ToArray
            If Not rtxt1.Text = "" Then Clipboard.SetText(rtxt1.Text)
        End If


    End Sub
    Public Function ParseLinks(ByVal clips As String) As List(Of String)
        Dim lnk As New List(Of String)
        Dim files As Array = FileTypes

        Try



            For Each ele In URL.Matches(clips)
                For Each item In files
                    If ele.ToString().ToLower.Contains("." & item.ToString.ToLower) And Not ele.ToString().Contains("...") Then
                        lnk.Add(ele.ToString())
                    End If
                Next
            Next

            'remove duplicates
            lnk = lnk.Distinct.ToList

        Catch ex As Exception
            Debug.Print(ex.Message.ToString())
        End Try

        Return lnk
    End Function

    Private Sub btnStrip_Click(sender As Object, e As EventArgs) Handles btnStrip.Click
        rtxt1.Lines = ParseLinks(rtxt1.Text).ToArray
        Clipboard.SetText(rtxt1.Text)
    End Sub

End Class
