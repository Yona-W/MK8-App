Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System.Net


Public Class Form1
    Private Sub sendRequestButton_Click(sender As Object, e As EventArgs) Handles sendRequestButton.Click
        Dim json As String
        Dim request As New WebClient()
        Dim ttData As JObject
        Try
            request.Encoding = Encoding.UTF8
            json = request.DownloadString("http://mariokart.tv/en_us/jsonapi/time_trials?category_id=" & CourseID.Text)
            ttData = JObject.Parse(json)
        Catch ex As Exception
            Return
        End Try

        Track.Text = ttData("course_name")


        Rank1Mii.ImageLocation = ttData("top_rankers")(0)("icon_url")
        Rank1Mii.LoadAsync()
        Rank1Name.Text = ttData("top_rankers")(0)("name")
        Rank1Time.Text = ttData("top_rankers")(0)("time")

        Rank2Mii.ImageLocation = ttData("top_rankers")(1)("icon_url")
        Rank2Mii.LoadAsync()
        Rank2Name.Text = ttData("top_rankers")(1)("name")
        Rank2Time.Text = ttData("top_rankers")(1)("time")

        Rank3Mii.ImageLocation = ttData("top_rankers")(2)("icon_url")
        Rank3Mii.LoadAsync()
        Rank3Name.Text = ttData("top_rankers")(2)("name")
        Rank3Time.Text = ttData("top_rankers")(2)("time")

        Rank4Mii.ImageLocation = ttData("top_rankers")(3)("icon_url")
        Rank4Mii.LoadAsync()
        Rank4Name.Text = ttData("top_rankers")(3)("name")
        Rank4Time.Text = ttData("top_rankers")(3)("time")

        Rank5Mii.ImageLocation = ttData("top_rankers")(4)("icon_url")
        Rank5Mii.LoadAsync()
        Rank5Name.Text = ttData("top_rankers")(4)("name")
        Rank5Time.Text = ttData("top_rankers")(4)("time")

        Rank6Mii.ImageLocation = ttData("top_rankers")(5)("icon_url")
        Rank6Mii.LoadAsync()
        Rank6Name.Text = ttData("top_rankers")(5)("name")
        Rank6Time.Text = ttData("top_rankers")(5)("time")
        Dim i As Integer = 0
        For Each score As Integer In ttData("histogram")("chartList")(0)("partList")
            i += 1
            ScoreChart.Series(0).Points.Add(score)
        Next

    End Sub

    Public Function StringAsUtf8Bytes(ByVal strData As String) As Byte()
        Dim bytes() As Byte
        ' get unicode string as bytes
        bytes = Encoding.UTF8.GetBytes(strData)


        ' return byte data
        Return bytes
        end
    End Function

End Class
