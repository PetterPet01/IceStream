Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml.Serialization

Public Class PasteBinCore
    Public APIKEY As String = ""

    Public Class User
        Public _username As String = ""
        Public _password As String = ""
        Public _userKey As String = ""
        Private _core As PasteBinCore

        Public Sub New(ByVal username As String, ByVal password As String, ByVal core As PasteBinCore)
            _username = username
            _password = password
            _core = core

            Try
                _userKey = getUserKey()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Sub

        Public Function getUserKey() As String
            Using client = New WebClient()
                Dim data = New NameValueCollection()
                data.Add("api_dev_key", _core.APIKEY)
                data.Add("api_user_name", _username)
                data.Add("api_user_password", _password)

                Try
                    Dim responce = client.UploadValues(New Uri("https://pastebin.com/api/api_login.php"), data)
                    Return Encoding.ASCII.GetString(responce)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return Nothing
                End Try
            End Using
        End Function

        Public Function getUserPosts(ByVal maxResults As Integer) As Pastes
            Using client = New WebClient()
                Dim data = New NameValueCollection()
                data.Add("api_dev_key", _core.APIKEY)
                data.Add("api_user_key", getUserKey())
                data.Add("api_option", "list")
                data.Add("api_results_limit", maxResults.ToString())

                Try
                    Parallel.Invoke(Sub()
                                        Dim responce = client.UploadValues(New Uri("https://pastebin.com/api/api_post.php"), data)
                                        Dim s = "<Pastes>" & vbLf & Encoding.ASCII.GetString(responce) & "</Pastes>"
                                        File.WriteAllText("Pastes.xml", s)
                                    End Sub)
                    Dim reader As TextReader = New StreamReader("Pastes.xml")
                    Dim deserializer As XmlSerializer = New XmlSerializer(GetType(Pastes))
                    Dim obj As Object = deserializer.Deserialize(reader)
                    Dim XmlData As Pastes = CType(obj, Pastes)
                    Return XmlData
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    Return Nothing
                End Try
            End Using
        End Function

        Public Sub DeleteUserPost(ByVal PasteKey As String, ByVal currentUser As User)
            Using client = New WebClient()
                Dim data = New NameValueCollection()
                data.Add("api_option", "delete")
                data.Add("api_paste_key", PasteKey)
                data.Add("api_dev_key", _core.APIKEY)
                data.Add("api_user_key", getUserKey())

                Try
                    client.UploadValuesAsync(New Uri("https://pastebin.com/api/api_post.php"), data)
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

                AddHandler client.UploadValuesCompleted, Sub(sender, args)
                                                             Console.WriteLine(Encoding.ASCII.GetString(args.Result))
                                                         End Sub
            End Using
        End Sub
    End Class

    Public Sub New(ByVal APIKey1 As String)
        APIKEY = APIKey1
    End Sub

    Public Sub PostAnnon(ByVal PostName As String, ByVal PostText As String)
        Using client = New WebClient()
            Dim data = New NameValueCollection()
            data.Add("api_option", "paste")
            data.Add("api_paste_name", PostName)
            data.Add("api_dev_key", APIKEY)
            data.Add("api_paste_code", PostText)

            Try
                client.UploadValuesAsync(New Uri("https://pastebin.com/api/api_post.php"), data)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            AddHandler client.UploadValuesCompleted, Sub(sender, args)
                                                         Console.WriteLine(Encoding.ASCII.GetString(args.Result))
                                                     End Sub
        End Using
    End Sub

    Public Sub PostAsUser(ByVal PostName As String, ByVal PostText As String, ByVal currentUser As User, ByVal mode As Integer)
        Using client = New WebClient()
            Dim data = New NameValueCollection()
            data.Add("api_option", "paste")
            data.Add("api_paste_name", PostName)
            data.Add("api_dev_key", APIKEY)
            data.Add("api_paste_code", PostText)
            data.Add("api_user_key", currentUser._userKey)
            data.Add("api_paste_private", mode.ToString)

            Try
                client.UploadValuesAsync(New Uri("https://pastebin.com/api/api_post.php"), data)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

            AddHandler client.UploadValuesCompleted, Sub(sender, args)
                                                         MsgBox(Encoding.ASCII.GetString(args.Result))
                                                     End Sub
        End Using
    End Sub
End Class
