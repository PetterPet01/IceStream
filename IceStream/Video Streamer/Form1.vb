Imports System.Collections.Specialized
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports Gecko
Imports Gecko.Events

Public Class Form1
    Dim LoggedIn As Boolean
    Dim userID As String
    Dim userEmail As String
    Dim userStrblePass As String
    Dim videoCodeList As New List(Of String)
    Dim videoPlayer1HWRatio As Double
    Dim videoPlayer2HWRatio As Double
    Dim videoPlayer3HWRatio As Double

    Dim searchedUserID As New List(Of String)
    'Dim core = New PasteBinCore("196c56d01d61437556a260f4ec63eede")
    'Dim user = New PasteBinCore.User("petterpet", "quanprogrammer01", core)
    Private Sub OpenPanel(ByRef openPanel, ByRef hidePanel)
        hidePanel.Hide()
        openPanel.Show()
        openPanel.Dock = DockStyle.Fill
        openPanel.BringToFront()
    End Sub
    Public Shared Function IsAllAscii(ByVal text As String) As Boolean
        Return text.All(Function(c) c >= " "c AndAlso c <= "~"c)
    End Function
    Private Function downloadData(ByVal url As String)

        Try
            Application.DoEvents()
            Dim req As WebRequest = WebRequest.Create(url)
            Dim response As WebResponse = req.GetResponse()
            Dim stream As Stream = response.GetResponseStream()
            Dim buffer As Byte() = New Byte(1023) {}
            Dim dataLength As Integer = CInt(response.ContentLength)
            Application.DoEvents()
            Dim memStream As MemoryStream = New MemoryStream()

            While True
                Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)

                If bytesRead = 0 Then
                    Application.DoEvents()
                    Exit While
                Else
                    memStream.Write(buffer, 0, bytesRead)
                    Application.DoEvents()
                End If
            End While

            Return memStream.ToArray()
            stream.Close()
            memStream.Close()
        Catch __unusedException1__ As Exception
            Return Nothing
            MessageBox.Show("There was an error accessing the URL.")
        End Try
    End Function

    Private Function GetImageByUrl(url As String)
        Dim imageData As Byte() = downloadData(url)
        Dim stream As MemoryStream = New MemoryStream(imageData)
        Dim img As Image = Image.FromStream(stream)
        Return img
        stream.Close()
    End Function

    Private Function GetBetweenString(str As String, left As String, right As String, i As Integer, Optional removeSpaces As Boolean = True) As String
        Dim curStr As String = str
        If removeSpaces Then
            curStr = curStr.Replace(" ", "")
        End If
        Dim cloneStr As String = curStr
        left = left.Replace(" ", "")
        right = right.Replace(" ", "")
        Dim del As Integer
        Dim lis As New List(Of Integer)
        While cloneStr.Contains(left)
            del += left.Length
            lis.Add(cloneStr.IndexOf(left) + del)
            cloneStr = cloneStr.Remove(cloneStr.IndexOf(left), left.Length)
            'MsgBox(lis(0) & "s")
        End While
        Dim lie As New List(Of Integer)
        cloneStr = curStr
        del = 0
        While cloneStr.Contains(right)
            lie.Add(cloneStr.IndexOf(right) + del)
            cloneStr = cloneStr.Remove(cloneStr.IndexOf(right), right.Length)
            'MsgBox(lie(0) & "e")
            del += right.Length
        End While
        Return curStr.Substring(lis(i), lie(i) - lis(i))
    End Function
    Private Function GetBetweenStringList(str As String, left As String, right As String, Optional removeSpaces As Boolean = True) As List(Of String)
        Dim curStr As String = str
        If removeSpaces Then
            curStr = curStr.Replace(" ", "")
        End If
        Dim cloneStr As String = curStr
        left = left.Replace(" ", "")
        right = right.Replace(" ", "")
        Dim del As Integer
        Dim lis As New List(Of Integer)
        While cloneStr.Contains(left)
            del += left.Length
            lis.Add(cloneStr.IndexOf(left) + del)
            cloneStr = cloneStr.Remove(cloneStr.IndexOf(left), left.Length)
            'MsgBox(lis(0) & "s")
        End While
        Dim lie As New List(Of Integer)
        cloneStr = curStr
        del = 0
        While cloneStr.Contains(right)
            lie.Add(cloneStr.IndexOf(right) + del)
            cloneStr = cloneStr.Remove(cloneStr.IndexOf(right), right.Length)
            'MsgBox(lie(0) & "e")
            del += right.Length
        End While
        Dim resultList As New List(Of String)
        For a = 0 To lis.Count - 1
            resultList.Add(curStr.Substring(lis(a), lie(a) - lis(a)))
        Next
        Return resultList
    End Function
    Private Function GetBetweenStringListNoCase(str As String, left As String, right As String, Optional removeSpaces As Boolean = True) As List(Of String)
        Dim curStr As String = str
        If removeSpaces Then
            curStr = curStr.Replace(" ", "")
        End If
        Dim cloneStr As String = curStr.ToLower
        left = left.Replace(" ", "").ToLower
        right = right.Replace(" ", "").ToLower
        Dim del As Integer
        Dim lis As New List(Of Integer)
        While cloneStr.Contains(left)
            del += left.Length
            lis.Add(cloneStr.IndexOf(left) + del)
            cloneStr = cloneStr.Remove(cloneStr.IndexOf(left), left.Length)
            'MsgBox(lis(0) & "s")
        End While
        Dim lie As New List(Of Integer)
        cloneStr = curStr.ToLower
        del = 0
        While cloneStr.Contains(right)
            lie.Add(cloneStr.IndexOf(right) + del)
            cloneStr = cloneStr.Remove(cloneStr.IndexOf(right), right.Length)
            'MsgBox(lie(0) & "e")
            del += right.Length
        End While
        Dim resultList As New List(Of String)
        For a = 0 To lis.Count - 1
            resultList.Add(curStr.Substring(lis(a), lie(a) - lis(a)))
        Next
        Return resultList
    End Function
    Private Function GetRealContainString(source As String, containStr As String, index As Integer) As String
        Dim del As Integer
        Dim cloneSource As String = source
        Dim lowCloneSource As String = cloneSource.ToLower
        Dim cloneContainStr As String = containStr
        Dim lowCloneContainStr As String = cloneContainStr.ToLower
        Dim lis As New List(Of Integer)
        While lowCloneSource.Contains(lowCloneContainStr)
            lis.Add(lowCloneSource.IndexOf(lowCloneContainStr) + del)
            lowCloneSource = lowCloneSource.Remove(lowCloneSource.IndexOf(lowCloneContainStr), lowCloneContainStr.Length)
            del += lowCloneContainStr.Length
            'MsgBox(lis(0) & "s")
        End While
        Return cloneSource.Substring(lis(index), lowCloneContainStr.Length)
    End Function

    Private Function GetRealContainStringList(source As String, containStr As String) As List(Of String)
        Dim del As Integer
        Dim cloneSource As String = source
        Dim lowCloneSource As String = cloneSource.ToLower
        Dim cloneContainStr As String = containStr
        Dim lowCloneContainStr As String = cloneContainStr.ToLower
        Dim lis As New List(Of Integer)
        While lowCloneSource.Contains(lowCloneContainStr)
            lis.Add(lowCloneSource.IndexOf(lowCloneContainStr) + del)
            lowCloneSource = lowCloneSource.Remove(lowCloneSource.IndexOf(lowCloneContainStr), lowCloneContainStr.Length)
            del += lowCloneContainStr.Length
            'MsgBox(lis(0) & "s")
        End While
        Dim returnStrList As New List(Of String)
        For i = 0 To lis.Count - 1
            returnStrList.Add(cloneSource.Substring(lis(i), lowCloneContainStr.Length))
        Next
        Return returnStrList
    End Function
    Private Sub CreateJson()
        Using httpClient = New HttpClient()

            Using request = New HttpRequestMessage(New HttpMethod("POST"), "https://jsonblob.com/api/jsonBlob")

                request.Headers.TryAddWithoutValidation("Accept", "application/json")

                request.Content = New StringContent("{""people"":[""fred"", ""mark"", ""andrew""]}")
                request.Content.Headers.ContentType = New MediaTypeHeaderValue("application/json")

                Dim response = httpClient.SendAsync(request).Result.ToString
                Dim newJsonID = GetBetweenString(response, "X-jsonblob:", "X-Hello-Human", 0).Replace(vbNewLine, "")
                'RichTextBox1.Text = response
            End Using
        End Using
    End Sub

    Private Async Sub EditJson(newJson As String)
        Using httpClient = New HttpClient()

            Using request = New HttpRequestMessage(New HttpMethod("PUT"), "https://jsonblob.com/api/jsonBlob/ce03a7d1-23ff-11ea-8ada-213a7c3fdb33")

                request.Headers.TryAddWithoutValidation("Accept", "application/json")

                request.Content = New StringContent(newJson)
                request.Content.Headers.ContentType = New MediaTypeHeaderValue("application/json")

                Dim result = Await httpClient.SendAsync(request).Result.Content.ReadAsStringAsync

            End Using
        End Using
    End Sub

    Private Async Sub GetLoggedUserVideos(ID As String, ByVal lv As ListView)
        Dim dat As String
        Using client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)")
            Using response1 As HttpResponseMessage = Await client.GetAsync("https://jsonblob.com/api/jsonBlob/" & ID)
                Using content As HttpContent = response1.Content
                    Dim myContent As String = Await content.ReadAsStringAsync()
                    dat = myContent
                    'Me.RichTextBox1.Text = myContent
                End Using
            End Using
        End Using
        Dim vidList As New List(Of String)
        vidList = GetBetweenStringList(dat, "[", "]")
        lv.Clear()
        ImageList1.Images.Clear()

        Dim lvList As New List(Of ListViewItem)
        For i = 0 To vidList.Count - 1
            Dim vidCode As String = GetBetweenString(dat, "<vc>", "</vc>", i)
            Dim vidTitle As String = GetBetweenString(dat, "<vt>", "</vt>", i, False)
            Dim lvi As New ListViewItem
            lvi.Text = vidTitle
            ImageList1.Images.Add(GetImageByUrl("https://thumbs-east.streamable.com/image/" & vidCode & ".jpg"))
            lvi.ImageIndex = i
            lvList.Add(lvi)
            lv.LargeImageList = ImageList1
            lv.Items.Add(lvList(i))
            videoCodeList.Add(vidCode)
        Next
    End Sub

    Private Async Sub SearchForUsers(username As String)
        Dim dat As String
        Using client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)")
            Using response1 As HttpResponseMessage = Await client.GetAsync("https://jsonblob.com/api/jsonBlob/ce03a7d1-23ff-11ea-8ada-213a7c3fdb33")
                Using content As HttpContent = response1.Content
                    Dim myContent As String = Await content.ReadAsStringAsync()
                    dat = myContent
                    'Me.RichTextBox1.Text = myContent
                End Using
            End Using
        End Using
        ListBox1.Items.Clear()
        searchedUserID.Clear()
#Region "GettingPresentationName"
        Dim stopListLeft As New List(Of String)
        'stopListLeft.Add("<")
        'stopListLeft.Add(">")

        stopListLeft.Add("</")
        stopListLeft.Add("[")
        'stopListLeft.Add("<pre>")
        stopListLeft.Add("</pre>")
        stopListLeft.Add("<e>")
        stopListLeft.Add("<p>")
        stopListLeft.Add("<sp>")
        Dim stopListRight As New List(Of String)
        'stopListLeft.Add("<")
        'stopListLeft.Add(">")

        stopListRight.Add(">")
        stopListRight.Add("]")
        'stopListLeft.Add("<epre>")
        stopListRight.Add("</pre>")
        stopListRight.Add("</e>")
        stopListRight.Add("</p>")
        stopListRight.Add("</sp>")
        Dim preList As New List(Of String)
        preList = lol(dat.ToLower, username.ToLower, "<pre>", "<epre>", stopListLeft, stopListRight)
#End Region

#Region "GetUserName"
        Dim stopListLeft1 As New List(Of String)
        stopListLeft1.Add("<")
        stopListLeft1.Add(">")

        stopListLeft1.Add("</")
        'stopListLeft.Add("[")
        stopListLeft1.Add("<pre>")
        stopListLeft1.Add("</pre>")
        stopListLeft1.Add("<e>")
        stopListLeft1.Add("<p>")
        stopListLeft1.Add("<sp>")
        Dim stopListRight1 As New List(Of String)
        stopListRight1.Add("<")
        'stopListLeft.Add(">")

        stopListRight1.Add(">")
        'stopListRight.Add("]")
        stopListRight1.Add("<epre>")
        stopListRight1.Add("</pre>")
        stopListRight1.Add("</e>")
        stopListRight1.Add("</p>")
        stopListRight1.Add("</sp>")
        Dim userList As New List(Of String)
        userList = lol(dat.ToLower, username.ToLower, "[", "]", stopListLeft, stopListRight)
#End Region

        For i = 0 To userList.Count - 1
            Dim userInfoList1 As New List(Of String)
            userInfoList1 = GetBetweenStringList(dat.ToLower, "[" & userList(i).ToLower & "]", "</" & userList(i).ToLower.ToLower & ">")
            For a = 0 To userInfoList1.Count - 1
                searchedUserID.Add(GetBetweenString(userInfoList1(a), "<cid>", "</cid>", 0))
            Next
        Next


        For i = 0 To preList.Count - 1
            Dim userInfoList2 As New List(Of String)
            userInfoList2 = GetBetweenStringList(dat.ToLower, "<pre>" & preList(i).ToLower & "<epre>", "</pre>" & preList(i).ToLower & "</pre>")
            For a = 0 To userInfoList2.Count - 1
                searchedUserID.Add(GetBetweenString(userInfoList2(a), "<cid>", "</cid>", 0))
            Next
        Next

        Dim userNameList As New List(Of String)

        'UNL1->UNL2Pre; UNL2<-UNL1Pre
        Dim UNL1 As New List(Of String) 'Take username from data
        For i = 0 To userList.Count - 1
            userNameList = GetRealContainStringList(dat, "[" & userList(i) & "]")
            For a = 0 To userNameList.Count - 1
                UNL1.Add(userNameList(a).Replace("[", "").Replace("]", ""))
            Next
        Next

        Dim userPreNameList As New List(Of String)
        Dim UNL1Pre As New List(Of String) 'Take presentation username from data
        For i = 0 To preList.Count - 1
            userPreNameList = GetRealContainStringList(dat, "<pre>" & preList(i) & "<epre>")
            For a = 0 To userPreNameList.Count - 1
                UNL1Pre.Add(userPreNameList(a).Replace("<pre>", "").Replace("<epre>", ""))
            Next
        Next


        Dim UNL2 As New List(Of String)
        'Take username inside  userInfoList2, not quite(by presentation username)
        For i = 0 To preList.Count - 1
            Dim str As String = dat.ToLower
            Dim value As String = "<pre>" & preList(i).ToLower & "<epre>"
            Dim del As Integer
            Dim finstr As String = ""
            Dim cloneStr As String = str
            Dim lis As New List(Of String)
            While cloneStr.Contains(value)
                lis.Add(cloneStr.IndexOf(value) + del)
                cloneStr = cloneStr.Remove(cloneStr.IndexOf(value), value.Length)
                del += value.Length
            End While

            For a = 0 To lis.Count - 1
                str = dat.ToLower.Substring(0, lis(a))
                Dim startStr As Integer = str.Length - 1
                Dim length As Integer = str.Length - startStr
                finstr = str.Substring(startStr, length)
                While True
                    If Not finstr.Contains("[") Or Not finstr.Contains("]") Then
                        finstr = str.Substring(startStr, length)
                        startStr -= 1
                        length = str.Length - startStr
                    Else
                        Exit While
                    End If
                End While
                finstr = finstr.Substring(finstr.IndexOf("["), finstr.IndexOf("]"))
                finstr = finstr.Replace("[", "").Replace("]", "")
                UNL2.Add(finstr)
            Next
        Next
        Dim UNL2Pre As New List(Of String) 'Take presentation username inside userInfoList1, not quite(by username)
        For i = 0 To userList.Count - 1
            Dim userInfoList1NoCase As New List(Of String)
            userInfoList1NoCase = GetBetweenStringListNoCase(dat, "[" & userList(i) & "]", "</" & userList(i) & ">", False)
            For a = 0 To userInfoList1NoCase.Count - 1
                UNL2Pre.Add(GetBetweenString(userInfoList1NoCase(a), "<pre>", "<epre>", 0, False))
            Next
        Next

        Try
            For i = 0 To UNL1.Count - 1
                For a = 0 To UNL1Pre.Count - 1
                    If UNL1(i) = UNL2(a) Then
                        'UNL1.RemoveAt(i)
                        'UNL2Pre.RemoveAt(i)
                        UNL2.RemoveAt(a)
                        UNL1Pre.RemoveAt(a)
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

        For i = 0 To UNL1.Count - 1
            ListBox1.Items.Add(UNL2Pre(i) & " (@" & UNL1(i) & ")")
        Next
        For i = 0 To UNL2.Count - 1
            ListBox1.Items.Add(UNL1Pre(i) & " (@" & UNL2(i) & ")")
        Next
        searchedUserID = searchedUserID.Distinct.ToList
    End Sub

    Private Async Sub UploadVideoAnon(fileName As String)
        Dim response As String
        Dim videoCode As String
        Using httpClient = New HttpClient()
            Using request = New HttpRequestMessage(New HttpMethod("POST"), "https://api.streamable.com/upload")

                Dim base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes("minecraftquan0@gmail.com:Quantretrau01"))
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}")

                Dim MultipartContent = New MultipartFormDataContent()
                MultipartContent.Add(New ByteArrayContent(File.ReadAllBytes(fileName)), "file", Path.GetFileName("D:\testvid.mp4"))
                request.Content = MultipartContent

                response = Await httpClient.SendAsync(request).Result.Content.ReadAsStringAsync
                videoCode = GetBetweenString(response, ": """, """,", 0)
            End Using
        End Using
    End Sub

    Private Async Sub UploadVideo(fileName As String)
        Dim response As String
        Dim videoCode As String
        Using httpClient = New HttpClient()
            Using request = New HttpRequestMessage(New HttpMethod("POST"), "https://api.streamable.com/upload")

                Dim base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(userEmail & ":" & userStrblePass))
                request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}")

                Dim MultipartContent = New MultipartFormDataContent()
                MultipartContent.Add(New ByteArrayContent(File.ReadAllBytes(fileName)), "file", Path.GetFileName(fileName))
                request.Content = MultipartContent

                response = Await httpClient.SendAsync(request).Result.Content.ReadAsStringAsync
                videoCode = GetBetweenString(response, ": """, """,", 0)
                GetHWRatio(videoCode, 3)
                GeckoWebBrowser3.Navigate("https://streamable.com/" & videoCode)
            End Using
        End Using
        Dim dat As String
        Using client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)")
            Using response1 As HttpResponseMessage = Await client.GetAsync("https://jsonblob.com/api/jsonBlob/" & userID)
                Using content As HttpContent = response1.Content
                    Dim myContent As String = Await content.ReadAsStringAsync()
                    dat = myContent
                    'Me.RichTextBox1.Text = myContent
                End Using
            End Using
        End Using
        Using httpClient = New HttpClient()

            Using request = New HttpRequestMessage(New HttpMethod("PUT"), "https://jsonblob.com/api/jsonBlob/" & userID)

                request.Headers.TryAddWithoutValidation("Accept", "application/json")

                request.Content = New StringContent(dat & "[" & "<vc>" & videoCode & "</vc>" & "<vt>" & TB_VideoTitle.Text & "</vt>" & "]")
                request.Content.Headers.ContentType = New MediaTypeHeaderValue("application/json")

                smth = Await httpClient.SendAsync(request).Result.Content.ReadAsStringAsync

            End Using
        End Using
    End Sub
    Private Async Sub GetRequest(ByVal url As String)
        Using client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)")
            Using response As HttpResponseMessage = Await client.GetAsync(url)
                Using content As HttpContent = response.Content
                    Dim myContent As String = Await content.ReadAsStringAsync()
                    'Me.RichTextBox1.Text = myContent
                End Using
            End Using
        End Using

    End Sub
    Private Function lol(str As String, contain As String, left As String, right As String, stopLeft As List(Of String), stopRight As List(Of String))
        Dim lis As New List(Of String)
        Dim realStr As String = str
        Dim realContain As String = contain
        Dim realLeft As String = left
        Dim realRight As String = right
        Dim realStopLeft As List(Of String) = stopLeft
        Dim realStopRight As List(Of String) = stopRight
        While realStr.Contains(realContain)
            Dim getout As Boolean
            Dim l1 As Integer = realStr.IndexOf(realContain)
            Dim l2 As Integer = l1 + realContain.Length - 1
            If l1 + realLeft.Length > realStr.Length Then Exit While
            Dim l1str As String = realStr.Substring(l1, realLeft.Length)
            If l2 + realRight.Length > realStr.Length Then Exit While
            Dim l2str As String = realStr.Substring(l2, realRight.Length)
            Dim exWhile As Boolean = False
            While Not l1str = realLeft And getout = False
                l1 -= 1
                If l1 < 0 Then
                    Exit While
                    exWhile = True
                End If
                l1str = realStr.Substring(l1, realLeft.Length)
                For i = 0 To realStopLeft.Count - 1
                    If realStopLeft(i) <> "" Then
                        If l1str.Contains(realStopLeft(i)) And l1str <> realLeft Then
                            getout = True
                            realStr = realStr.Remove(realStr.IndexOf(realContain), realContain.Length)
                            Exit While
                            Exit For
                        End If
                    End If
                Next
            End While
            If exWhile Then Exit While
            While Not l2str = realRight And getout = False
                l2 += 1
                l2str = realStr.Substring(l2, realRight.Length)

                For i = 0 To realStopRight.Count - 1
                    If realStopRight(i) <> "" Then
                        If l2str.Contains(realStopRight(i)) And l2str <> realRight Then
                            getout = True
                            realStr = realStr.Remove(realStr.IndexOf(realContain), realContain.Length)
                            Exit While
                            Exit For
                        End If
                    End If
                Next
            End While
            If getout = False Then
                Dim result As String = realStr.Substring(l1 + realLeft.Length, l2 - (l1 + realLeft.Length))
                Dim result2 As String = realStr.Substring(l1, l2 - l1)
                Dim addable As Boolean = True
                For i = 0 To lis.Count - 1
                    If lis(i) = result Then
                        addable = False
                    End If
                Next
                If addable Then lis.Add(result)

                realStr = realStr.Remove(realStr.IndexOf(realContain), realContain.Length)
            End If

            getout = False
            'MsgBox(lis(0))
        End While
        Return lis
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GetRequest("https://streamable.com/yw09u")
        'EditJson("<petterpet><e>minecraftquan0@gmail.com</e><p>something</p></petterpet><somethingelse><e>somethingelse@gmail.com</e><p>different</p></somethingelse>")
        'EditJson("")
        'ServicePointManager.Expect100Continue = True
        'ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        'ImageList1.Images.Add(My.Resources.thumbn)
        'lol("<petterpet></petterpet034>", "petterpet", "</", ">", "<", "rewfdwgtr", 0)
        Dim stopListLeft As New List(Of String)
        'stopListLeft.Add("<")
        'stopListLeft.Add(">")

        stopListLeft.Add("</")
        stopListLeft.Add("[")
        'stopListLeft.Add("<pre>")
        stopListLeft.Add("</pre>")
        stopListLeft.Add("<e>")
        stopListLeft.Add("<p>")
        stopListLeft.Add("<sp>")
        Dim stopListRight As New List(Of String)
        'stopListLeft.Add("<")
        'stopListLeft.Add(">")

        stopListLeft.Add(">")
        stopListLeft.Add("]")
        'stopListLeft.Add("<epre>")
        stopListLeft.Add("</pre>")
        stopListLeft.Add("</e>")
        stopListLeft.Add("</p>")
        stopListLeft.Add("</sp>")
        'Dim l As New List(Of String)
        'l = lol("[petterpet]<pre>petterpet453543<epre><cid>337f8df2-2722-11ea-bbf0-3d1c6ca69f90</cid><e>minecraftquan0@gmail.com</e><p>quanprogrammer01</p><sp>Quantretrau01</sp></pre>Ice Bear</pre></petterpet>[petterpet01]<pre>motherfker<epre><cid>8857474a-278b-11ea-bc7c-2be4c8fbc50e</cid><e>minecraftquan01@gmail.com</e><p>quantretrau01</p><sp>quanprogrammer01</sp></pre>motherfker</pre></petterpet01>", "petterpet", "<pre>", "<epre>", stopListLeft, stopListRight)
        'MsgBox(l.Count)
        Dim realStr As String = "[petterpet]<pre>petterpet453543<epre><cid>337f8df2-2722-11ea-bbf0-3d1c6ca69f90</cid><e>minecraftquan0@gmail.com</e><p>quanprogrammer01</p><sp>Quantretrau01</sp></pre>Ice Bear</pre></petterpet>[petterpet01]<pre>motherfker<epre><cid>8857474a-278b-11ea-bc7c-2be4c8fbc50e</cid><e>minecraftquan01@gmail.com</e><p>quantretrau01</p><sp>quanprogrammer01</sp></pre>motherfker</pre></petterpet01>"
        Dim realContain As String = "petterpet"
        Dim realLeft As String = "<pre>"
        Dim realRight As String = "<epre>"
        'MsgBox(IsAllAscii("fwrrgerwerewfrew"))
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) 
    '    'core.PostAsUser("test2", "hi", user, 1)
    '    'Dim postes = user.getUserPosts(10)
    '    'RichTextBox1.Text += postes.Paste.Count.ToString

    '    'Dim client As New HttpClient()
    '    'Dim request As New HttpRequestMessage()
    '    'request.RequestUri = New Uri("https://text.cinwell.xyz")
    '    'request.Method = HttpMethod.Post
    '    'request.Headers.Add("text", "something")

    '    'Dim result = client.SendAsync(request).Result
    '    'MsgBox(result.ToString)
    '    Dim data = New NameValueCollection()
    '    'data.Add("email:password", "minecraftquan0@gmail.com:Quantretrau01")
    '    data.Add("file", "D:\testvid.mp4")
    '    'Using c = New WebClient()
    '    '    c.UploadValuesAsync(New Uri("https://text.cinwell.xyz"), data)

    '    '    AddHandler c.UploadValuesCompleted, Sub(senders, args)
    '    '                                            MsgBox(Encoding.ASCII.GetString(args.Result))
    '    '                                        End Sub
    '    'End Using
    '    'Using c = New WebClient()
    '    '    c.Credentials = New NetworkCredential("minecraftquan0@gmail.com", "Quantretrau01")

    '    '    Try
    '    '        c.UploadValuesAsync(New Uri("https://api.streamable.com/upload"), data)
    '    '    Catch ex As Exception
    '    '        MsgBox(ex.Message)
    '    '    End Try


    '    '    AddHandler c.UploadValuesCompleted, Sub(senders, args)
    '    '                                            MsgBox(Encoding.ASCII.GetString(args.Result))
    '    '                                        End Sub
    '    'End Using

    '    'Dim smth = client.Upload("D:\testvid.mp4")
    '    'MsgBox(smth.shortcode)
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_UploadVideo.Click
        'Me.Text = user.getUserKey()
        If LoggedIn Then
            If TB_VideoPath.Text <> "" And TB_VideoTitle.Text <> "" Then
                UploadVideo(TB_VideoPath.Text)
            Else
                MsgBox("You didn't fill some information!")
            End If
        Else
            MsgBox("You have to login before uploading!")
        End If

    End Sub

    Dim smth As String
    Private Async Sub FinishAdding(cur As String, addvalue As String)
        Using httpClient = New HttpClient()

            Using request = New HttpRequestMessage(New HttpMethod("PUT"), "https://jsonblob.com/api/jsonBlob/ce03a7d1-23ff-11ea-8ada-213a7c3fdb33")

                request.Headers.TryAddWithoutValidation("Accept", "application/json")

                request.Content = New StringContent(cur & addvalue)
                request.Content.Headers.ContentType = New MediaTypeHeaderValue("application/json")

                smth = Await httpClient.SendAsync(request).Result.Content.ReadAsStringAsync

                PN_Register.Hide()
                PN_Login.Show()
                PN_Login.Dock = DockStyle.Fill
                PN_Login.BringToFront()
                BTN_OpenLogin2.Enabled = False
                BTN_OpenRegister2.Enabled = False
                BTN_OpenMyChannel.Enabled = True
                BTN_LogOut.Enabled = True
                TB_RegEmail.Text = ""
                TB_RegPassword.Text = ""
                TB_RegPreName.Text = ""
                TB_RegStrblePass.Text = ""
                TB_RegUsername.Text = ""
            End Using
        End Using
    End Sub

    Private Async Sub AddChannelToServer(value As String)
        Dim dat As String
        Using client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)")
            Using response As HttpResponseMessage = Await client.GetAsync("https://jsonblob.com/api/jsonBlob/ce03a7d1-23ff-11ea-8ada-213a7c3fdb33")
                Using content As HttpContent = response.Content
                    Dim myContent As String = Await content.ReadAsStringAsync()
                    dat = myContent
                    'Me.RichTextBox1.Text = myContent
                End Using
            End Using
        End Using
        'If Data <> "" Then
        FinishAdding(dat, value)
        'End If
    End Sub
    Dim newChannelID As String
    Private Async Sub CreateChannel()
        Using httpClient = New HttpClient()

            Using request = New HttpRequestMessage(New HttpMethod("POST"), "https://jsonblob.com/api/jsonBlob")

                request.Headers.TryAddWithoutValidation("Accept", "application/json")

                request.Content = New StringContent("")
                request.Content.Headers.ContentType = New MediaTypeHeaderValue("application/json")
                Dim first = httpClient.SendAsync(request).Result
                Dim smth = Await first.Content.ReadAsStringAsync
                Dim response = first.ToString
                newChannelID = GetBetweenString(response, "X-jsonblob:", "X-Hello-Human", 0).Replace(vbNewLine, "")
                AddChannelToServer("[" & TB_RegUsername.Text & "]" & "<pre>" & TB_RegPreName.Text & "<epre>" & "<cid>" & newChannelID & "</cid>" & "<e>" & TB_RegEmail.Text & "</e>" & "<p>" & TB_RegPassword.Text & "</p>" & "<sp>" & TB_RegStrblePass.Text & "</sp>" & "</pre>" & TB_RegPreName.Text & "</pre>" & "</" & TB_RegUsername.Text & ">")
                'RichTextBox1.Text = response
            End Using
        End Using
    End Sub
    Private Async Sub VerifyNewChannelDetails(email As String, username As String)
        Dim dat As String
        Using client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)")
            Using response As HttpResponseMessage = Await client.GetAsync("https://jsonblob.com/api/jsonBlob/ce03a7d1-23ff-11ea-8ada-213a7c3fdb33")
                Using content As HttpContent = response.Content
                    Dim myContent As String = Await content.ReadAsStringAsync()
                    dat = myContent
                    'Me.RichTextBox1.Text = myContent
                End Using
            End Using
        End Using
        If dat.Contains("<e>" & email & "</e>") Then
            MsgBox("Email already exists!")
        End If
        If dat.ToLower.Contains("[" & username.ToLower & "]") Then
            MsgBox("Username already exists!")
        End If
        If Not dat.Contains("<e>" & email & "</e>") And Not dat.Contains("[" & username & "]") Then
            CreateChannel()
        End If
    End Sub

    Private Async Sub VerifyLogin(email As String, pass As String)
        Dim dat As String
        Using client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)")
            Using response As HttpResponseMessage = Await client.GetAsync("https://jsonblob.com/api/jsonBlob/ce03a7d1-23ff-11ea-8ada-213a7c3fdb33")
                Using content As HttpContent = response.Content
                    Dim myContent As String = Await content.ReadAsStringAsync()
                    dat = myContent
                    'Me.RichTextBox1.Text = myContent
                End Using
            End Using
        End Using
        Dim sysPass As String = GetBetweenString(dat.Remove(0, dat.IndexOf("<e>" & email & "</e>") + email.Length + 7), "<p>", "</p>", 0)
        If dat.Contains("<e>" & email & "</e>") And sysPass = pass Then
            LoggedIn = True
            'Dim user As String = GetBetweenString(dat.Remove(0, dat.IndexOf("<e>" & email & "</e>") + email.Length + 7 + sysPass.Count + 7), "</", ">", 0)
            Dim user As String = dat.Remove(0, dat.IndexOf("<e>" & email & "</e>") + email.Length + 7 + sysPass.Count + 7)
            user = user.Remove(0, user.IndexOf("</sp>") + 5)
            user = user.Substring(6, user.Length - 6)
            user = user.Substring(user.IndexOf("</pre>") + 6, user.Length - (user.IndexOf("</pre>") + 6))

            user = GetBetweenString(user, "</", ">", 0)
            Dim count As Integer
            count = GetBetweenStringList(dat, "[" & user & "]", "</" & user & ">").Count
            For i = 0 To count - 1
                Dim istr As String = GetBetweenString(dat, "[" & user & "]", "</" & user & ">", i)

                'userEmail = istr.Remove(0, istr.IndexOf("<e>" & email & "</e>") + 3)
                'userEmail = userEmail.Substring(0, userEmail.IndexOf("</e>"))
                userEmail = istr.Substring(istr.IndexOf("<e>") + 3, istr.IndexOf("</e>") - (istr.IndexOf("<e>") + 3))
                If userEmail = email Then
                    userStrblePass = GetBetweenString(istr, "<sp>", "</sp>", 0)
                    Dim cid As String = GetBetweenString(istr, "<cid>", "</cid>", 0)
                    userID = cid
                    Exit For
                End If
            Next
            MsgBox("Logged in")
            PN_Login.Hide()
            PN_MainScreen.Show()
            PN_MainScreen.Dock = DockStyle.Fill
            PN_MainScreen.BringToFront()
            BTN_OpenLogin2.Enabled = False
            BTN_OpenRegister2.Enabled = False
            BTN_OpenMyChannel.Enabled = True
            BTN_LogOut.Enabled = True
            TB_LogEmail.Text = ""
            TB_LogPassword.Text = ""
        Else
            MsgBox("You typed the wrong email/password")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTN_Register.Click
        If Not TB_RegEmail.Text = "" And Not TB_RegPassword.Text = "" And
             Not TB_RegPreName.Text = "" And Not TB_RegStrblePass.Text = "" And
             Not TB_RegUsername.Text = "" Then
            VerifyNewChannelDetails(TB_RegEmail.Text, TB_RegUsername.Text)
        Else
            MsgBox("You Didn't Fill Some Information!")
        End If
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
        If e.IsSelected Then e.Item.Selected = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
        If TB_LogEmail.Text <> "" And TB_LogPassword.Text <> "" Then
            Dim tbemail As String = TB_LogEmail.Text
            Dim tbpass As String = TB_LogPassword.Text
            VerifyLogin(tbemail, tbpass)

        Else
            MsgBox("You didn't fill some information")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_SelectVideo.Click
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.Filter = "All Video Files|*.WEBM;*.MPG;*.MP2;*.MPEG;*.MPE;*.MPV;*.OGG;*.MP4;*.M4P;*.M4V;*.AVI;*.WMV;*.MOV;*.QT;*.FLV;*.SWF;*.AVCHD;"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = OpenFileDialog1.FileName
            TB_VideoPath.Text = filePath
            BTN_UploadVideo.Enabled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTN_OpenStrble.Click
        Process.Start("https://streamable.com/signup")
    End Sub

    Private Sub CB_HadStrble_CheckedChanged(sender As Object, e As EventArgs) Handles CB_HadStrble.CheckedChanged
        If CB_HadStrble.Checked Then
            BTN_OpenStrble.Enabled = False
            BTN_Register.Enabled = True
        Else
            BTN_OpenStrble.Enabled = True
            BTN_Register.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BTN_GetChannelVids.Click
        GetLoggedUserVideos(userID, ListView1)
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        GetHWRatio(videoCodeList(ListView1.FocusedItem.Index), 1)
        GeckoWebBrowser1.Navigate("https://streamable.com/" & videoCodeList(ListView1.FocusedItem.Index))
        MsgBox(ListView1.FocusedItem.Index)
        Label7.Text = ListView1.Items(ListView1.FocusedItem.Index).Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BTN_SearchUsername.Click
        SearchForUsers(TB_UserSearch.Text)
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        Dim index As Integer = Me.ListBox1.IndexFromPoint(e.Location)

        If index <> System.Windows.Forms.ListBox.NoMatches Then
            GetLoggedUserVideos(searchedUserID(index), ListView2)
        End If
    End Sub

    Private Sub BTN_OpenLogin_Click(sender As Object, e As EventArgs) Handles BTN_OpenLogin.Click
        OpenPanel(PN_Login, PN_StartupScreen)
    End Sub

    Private Sub BTN_OpenRegister_Click(sender As Object, e As EventArgs) Handles BTN_OpenRegister.Click
        OpenPanel(PN_Register, PN_StartupScreen)
    End Sub
    Private Async Sub GetHWRatio(videoCode As String, i As Integer)
        Dim dat As String
        Using client As HttpClient = New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)")
            Using response As HttpResponseMessage = Await client.GetAsync("https://api.streamable.com/oembed.json?url=https://streamable.com/" & videoCode)
                Using content As HttpContent = response.Content
                    Dim myContent As String = Await content.ReadAsStringAsync()
                    dat = myContent
                    'Me.RichTextBox1.Text = myContent
                End Using
            End Using
        End Using
        Dim w As String = GetBetweenString(dat, "width=\""", "\"" height=\""", 0)
        Dim h As String = GetBetweenString(dat, "height=\""", "\"" allowfullscreen", 0)
        Select Case i
            Case 1
                videoPlayer1HWRatio = h / w
            Case 2
                videoPlayer2HWRatio = h / w
            Case 3
                videoPlayer3HWRatio = h / w
        End Select

    End Sub

    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        GetHWRatio(videoCodeList(ListView2.FocusedItem.Index), 2)
        GeckoWebBrowser2.Navigate("https://streamable.com/" & videoCodeList(ListView2.FocusedItem.Index))
        Label9.Text = ListView2.Items(ListView2.FocusedItem.Index).Text

    End Sub

    Private Sub BTN_OpenLogin2_Click(sender As Object, e As EventArgs) Handles BTN_OpenLogin2.Click
        OpenPanel(PN_Login, PN_MainScreen)
    End Sub

    Private Sub BTN_OpenRegister2_Click(sender As Object, e As EventArgs) Handles BTN_OpenRegister2.Click
        OpenPanel(PN_Register, PN_MainScreen)
    End Sub

    Private Sub BTN_OpenMainScreen_Click(sender As Object, e As EventArgs) Handles BTN_OpenMainScreen.Click
        OpenPanel(PN_MainScreen, PN_StartupScreen)
        BTN_OpenMyChannel.Enabled = False
        BTN_LogOut.Enabled = False
    End Sub

    Private Sub BTN_OpenRegister3_Click(sender As Object, e As EventArgs) Handles BTN_OpenRegister3.Click
        OpenPanel(PN_Register, PN_Login)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BTN_OpenMainScreen2.Click
        OpenPanel(PN_MainScreen, PN_ChannelScreen)
    End Sub

    Private Sub BTN_OpenMyChannel_Click(sender As Object, e As EventArgs) Handles BTN_OpenMyChannel.Click
        OpenPanel(PN_ChannelScreen, PN_MainScreen)
    End Sub

    Private Sub BTN_OpenMyChannel2_Click(sender As Object, e As EventArgs) Handles BTN_OpenMyChannel2.Click
        OpenPanel(PN_ChannelScreen, PN_VideoUpload)
    End Sub

    Private Sub BTN_OpenLogin3_Click(sender As Object, e As EventArgs) Handles BTN_OpenLogin3.Click
        OpenPanel(PN_Login, PN_Register)
    End Sub

    Private Sub BTN_OpenMainScreen3_Click(sender As Object, e As EventArgs) Handles BTN_OpenMainScreen3.Click
        OpenPanel(PN_MainScreen, PN_Login)
        BTN_OpenLogin2.Enabled = True
        BTN_OpenRegister2.Enabled = True
        BTN_OpenMyChannel.Enabled = False
        BTN_LogOut.Enabled = False
    End Sub

    Private Sub BTN_OpenMainScreen4_Click(sender As Object, e As EventArgs) Handles BTN_OpenMainScreen4.Click
        OpenPanel(PN_MainScreen, PN_Register)
        BTN_OpenLogin2.Enabled = True
        BTN_OpenRegister2.Enabled = True
        BTN_OpenMyChannel.Enabled = False
    End Sub

    Private Sub BTN_OpenUploadVid_Click(sender As Object, e As EventArgs) Handles BTN_OpenUploadVid.Click
        OpenPanel(PN_VideoUpload, PN_ChannelScreen)
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BTN_LogOut.Click
        LoggedIn = False
        userID = ""
        userEmail = ""
        userStrblePass = ""
        videoCodeList = New List(Of String)

        searchedUserID = New List(Of String)
        TB_UserSearch.Text = ""
        ListBox1.Items.Clear()
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        GeckoWebBrowser1.Navigate("about:blank")
        GeckoWebBrowser2.Navigate("about:blank")
        GeckoWebBrowser3.Navigate("about:blank")
        CB_HadStrble.Checked = False
        OpenPanel(PN_Login, PN_MainScreen)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim l3 As New List(Of String)
        Dim stopListLeft As New List(Of String)
        stopListLeft.Add("<")
        stopListLeft.Add(">")
        'stopListLeft.Add("<pre>")
        'stopListLeft.Add("</pre>")
        'stopListLeft.Add("<e>")
        'stopListLeft.Add("<p>")
        'stopListLeft.Add("<sp>")
        Dim stopListRight As New List(Of String)
        stopListLeft.Add("<")
        stopListLeft.Add(">")
        'stopListLeft.Add("<epre>")
        'stopListLeft.Add("</pre>")
        'stopListLeft.Add("</e>")
        'stopListLeft.Add("</p>")
        'stopListLeft.Add("</sp>")
        'l3 = lol("<petterpet><pre>petterpet0343<epre><cid>337f8df2-2722-11ea-bbf0-3d1c6ca69f90</cid><e>minecraftquan0@gmail.com</e><p>quanprogrammer01</p><sp>Quantretrau01</sp></pre>Ice Bear</pre></petterpet><petterpet01><pre>motherfker<epre><cid>8857474a-278b-11ea-bc7c-2be4c8fbc50e</cid><e>minecraftquan01@gmail.com</e><p>quantretrau01</p><sp>quanprogrammer01</sp></pre>motherfker</pre></petterpet01>", "petterpet", "<pre>", "<epre>", stopListLeft, stopListRight)

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)
        Dim stopListLeft As New List(Of String)
        'stopListLeft.Add("<")
        'stopListLeft.Add(">")

        stopListLeft.Add("</")
        stopListLeft.Add("[")
        'stopListLeft.Add("<pre>")
        stopListLeft.Add("</pre>")
        stopListLeft.Add("<e>")
        stopListLeft.Add("<p>")
        stopListLeft.Add("<sp>")
        Dim stopListRight As New List(Of String)
        'stopListLeft.Add("<")
        'stopListLeft.Add(">")

        stopListRight.Add(">")
        stopListRight.Add("]")
        'stopListLeft.Add("<epre>")
        stopListRight.Add("</pre>")
        stopListRight.Add("</e>")
        stopListRight.Add("</p>")
        stopListRight.Add("</sp>")
        Dim l As New List(Of String)
        l = lol("[petterpet]<pre>petterpet453543<epre><cid>337f8df2-2722-11ea-bbf0-3d1c6ca69f90</cid><e>minecraftquan0@gmail.com</e><p>quanprogrammer01</p><sp>Quantretrau01</sp></pre>petterpet453543</pre></petterpet>[petterpet01]<pre>awwpetterpetaww<epre><cid>8857474a-278b-11ea-bc7c-2be4c8fbc50e</cid><e>minecraftquan01@gmail.com</e><p>quantretrau01</p><sp>quanprogrammer01</sp></pre>awwpetterpetaww</pre></petterpet01>", "petterpet", "<pre>", "<epre>", stopListLeft, stopListRight)
        Dim realStr As String = "[petterpet]<pre>petterpet453543<epre><cid>337f8df2-2722-11ea-bbf0-3d1c6ca69f90</cid><e>minecraftquan0@gmail.com</e><p>quanprogrammer01</p><sp>Quantretrau01</sp></pre>Ice Bear</pre></petterpet>[petterpet01]<pre>motherfker<epre><cid>8857474a-278b-11ea-bc7c-2be4c8fbc50e</cid><e>minecraftquan01@gmail.com</e><p>quantretrau01</p><sp>quanprogrammer01</sp></pre>motherfker</pre></petterpet01>"
        Dim realContain As String = "petterpet"
        Dim realLeft As String = "<pre>"
        Dim realRight As String = "<epre>"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim stopListLeft As New List(Of String)
        stopListLeft.Add("<")
        stopListLeft.Add(">")

        stopListLeft.Add("</")
        'stopListLeft.Add("[")
        stopListLeft.Add("<pre>")
        stopListLeft.Add("</pre>")
        stopListLeft.Add("<e>")
        stopListLeft.Add("<p>")
        stopListLeft.Add("<sp>")
        Dim stopListRight As New List(Of String)
        stopListRight.Add("<")
        'stopListLeft.Add(">")

        stopListRight.Add(">")
        'stopListRight.Add("]")
        stopListRight.Add("<epre>")
        stopListRight.Add("</pre>")
        stopListRight.Add("</e>")
        stopListRight.Add("</p>")
        stopListRight.Add("</sp>")
        Dim l As New List(Of String)
        l = lol("[petterpet]<pre>petterpet453543<epre><cid>337f8df2-2722-11ea-bbf0-3d1c6ca69f90</cid><e>minecraftquan0@gmail.com</e><p>quanprogrammer01</p><sp>Quantretrau01</sp></pre>petterpet453543</pre></petterpet>[petterpet01]<pre>awwpetterpetaww<epre><cid>8857474a-278b-11ea-bc7c-2be4c8fbc50e</cid><e>minecraftquan01@gmail.com</e><p>quantretrau01</p><sp>quanprogrammer01</sp></pre>awwpetterpetaww</pre></petterpet01>", "petterpet", "[", "]", stopListLeft, stopListRight)
        Dim realStr As String = "[petterpet]<pre>petterpet453543<epre><cid>337f8df2-2722-11ea-bbf0-3d1c6ca69f90</cid><e>minecraftquan0@gmail.com</e><p>quanprogrammer01</p><sp>Quantretrau01</sp></pre>Ice Bear</pre></petterpet>[petterpet01]<pre>motherfker<epre><cid>8857474a-278b-11ea-bc7c-2be4c8fbc50e</cid><e>minecraftquan01@gmail.com</e><p>quantretrau01</p><sp>quanprogrammer01</sp></pre>motherfker</pre></petterpet01>"
        Dim realContain As String = "petterpet"
        Dim realLeft As String = "["
        Dim realRight As String = "]"
        MsgBox(l(1))
    End Sub

    Private Sub GeckoWebBrowser1_DocumentCompleted(sender As Object, e As GeckoDocumentCompletedEventArgs) Handles GeckoWebBrowser1.DocumentCompleted
        'Dim element = GeckoWebBrowser1.Document.GetElementById("player-content").DOMElement
        'GeckoWebBrowser1.Document.TextContent = GeckoWebBrowser1.Document.GetHtmlElementById("dex1").OuterHtml
        'Dim eles = GeckoWebBrowser1.Document.GetElementsByTagName("stickypush")
        ''For Each ele In eles
        ''    If ele.GetAttribute("className") = "stickyfooter" Then ele.InnerHtml = ""
        ''Next
        'For Each ele In eles
        '    ele.ParentElement.RemoveChild(ele)
        'Next
        GeckoWebBrowser1.Document.GetHtmlElementById("everything-but-video").InnerHtml = ""
    End Sub

    Private Sub GeckoWebBrowser2_DocumentCompleted(sender As Object, e As GeckoDocumentCompletedEventArgs) Handles GeckoWebBrowser2.DocumentCompleted
        'Dim element = GeckoWebBrowser2.Document.GetElementById("player-content").DOMElement
        'Dim element1 = GeckoWebBrowser2.Document.GetElementById("everything-but-video").DOMElement
        'element.RemoveChild(element1)
        'GeckoWebBrowser2.Document.GetHtmlElementById("player").InnerHtml = GeckoWebBrowser2.Document.GetHtmlElementById("player-content").InnerHtml
        'Dim eles = GeckoWebBrowser2.Document.GetElementsByClassName("stickypush")

        'For Each ele In eles
        '    ele.ParentElement.RemoveChild(ele)
        'Next

        'GeckoWebBrowser2.Document.Body.InnerHtml = GeckoWebBrowser2.Document.GetHtmlElementById("player-content").InnerHtml
        'GeckoWebBrowser2.Document.GetHtmlElementById("everything-but-video").InnerHtml = ""
        'MsgBox(GeckoWebBrowser2.Document.GetHtmlElementById("media-container").InnerHtml)
        'GeckoWebBrowser2.do
        'Dim eles = GeckoWebBrowser2.Document.GetElementsByTagName("div")
        'MsgBox(eles.Count)
        ''For Each ele In eles
        ''    If ele.GetAttribute("className") = "stickyfooter" Then ele.InnerHtml = ""
        ''Next
        'For Each ele In eles
        '    If ele IsNot Nothing Then
        '        Try
        '            'MsgBox(ele.GetAttribute("class"))
        '            'If ele.GetAttribute("class") = "stickypush" Then
        '            '    MsgBox("EYYYYYYYYYYYYY")
        '            'End If

        '            If ele.GetAttribute("class") = "stickyfooter" Then
        '                ele.InnerHtml = ""
        '            End If
        '        Catch ex As Exception

        '        End Try

        '    End If
        'Next
        'Dim olds = GeckoWebBrowser2.Document.GetHtmlElementById("player-content").InnerHtml
        'GeckoWebBrowser2.Document.GetHtmlElementById("player-content").InnerHtml = GeckoWebBrowser2.Document.GetHtmlElementById("player-content").InnerHtml
        'Dim news = GeckoWebBrowser2.Document.GetHtmlElementById("player-content").InnerHtml
        'If GeckoWebBrowser2.Document.GetHtmlElementById("player-controls-footer").InnerHtml <> "" Then
        '    MsgBox("hi")
        'End If
        GeckoWebBrowser2.Document.GetHtmlElementById("everything-but-video").InnerHtml = ""
    End Sub

    Private Sub GeckoWebBrowser3_DocumentCompleted(sender As Object, e As GeckoDocumentCompletedEventArgs) Handles GeckoWebBrowser3.DocumentCompleted
        'Dim element = GeckoWebBrowser3.Document.GetElementById("player-content").DOMElement
        'Dim element1 = GeckoWebBrowser3.Document.GetElementById("everything-but-video").DOMElement
        'element.RemoveChild(element1)
        'GeckoWebBrowser3.Document.GetHtmlElementById("player").InnerHtml = GeckoWebBrowser3.Document.GetHtmlElementById("player-content").InnerHtml
        'Dim eles = GeckoWebBrowser3.Document.GetElementsByTagName("stickypush")

        ''For Each ele In eles
        ''    If ele.GetAttribute("className") = "stickyfooter" Then ele.InnerHtml = ""
        ''Next
        'For Each ele In eles
        '    ele.ParentElement.RemoveChild(ele)
        'Next
        GeckoWebBrowser3.Document.GetHtmlElementById("everything-but-video").InnerHtml = ""
    End Sub
    <DllImport("user32.dll", EntryPoint:="GetAsyncKeyState")> Public Shared Function GetAsyncKeyState(ByVal vKey As Integer) As Short
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Text = Panel1.Size.ToString & GeckoWebBrowser2.Location.ToString
        'If PictureBox1.Height * 1.776 < Panel1.Width Then
        '    Panel1.Width = Math.Round(Panel1.Height * 1.776)
        'End If
        If Panel1.Width * videoPlayer2HWRatio < PictureBox1.Height Then
            Panel1.Height = Math.Round(Panel1.Width * videoPlayer2HWRatio)
        End If

        If Panel2.Width * videoPlayer3HWRatio < PictureBox2.Height Then
            Panel2.Height = Math.Round(Panel2.Width * videoPlayer3HWRatio)
        End If

        If Panel3.Width * videoPlayer1HWRatio < PictureBox3.Height Then
            Panel3.Height = Math.Round(Panel3.Width * videoPlayer1HWRatio)
        End If

        'If GetAsyncKeyState(Keys.A) <> 0 Then
        '    Panel1.Width -= 1
        'End If
        'If GetAsyncKeyState(Keys.D) <> 0 Then
        '    Panel1.Width += 1
        'End If
        'If GetAsyncKeyState(Keys.W) <> 0 Then
        '    Panel1.Height += 1
        'End If
        'If GetAsyncKeyState(Keys.S) <> 0 Then
        '    Panel1.Height -= 1
        'End If
        'If GetAsyncKeyState(Keys.Left) <> 0 Then
        '    GeckoWebBrowser2.Left -= 1
        'End If
        'If GetAsyncKeyState(Keys.Right) <> 0 Then
        '    GeckoWebBrowser2.Left += 1
        'End If
        'If GetAsyncKeyState(Keys.Up) <> 0 Then
        '    GeckoWebBrowser2.Top -= 1
        'End If
        'If GetAsyncKeyState(Keys.Down) <> 0 Then
        '    GeckoWebBrowser2.Top += 1
        'End If
    End Sub
End Class
