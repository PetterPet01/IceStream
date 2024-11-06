<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BTN_UploadVideo = New System.Windows.Forms.Button()
        Me.BTN_Register = New System.Windows.Forms.Button()
        Me.TB_RegUsername = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TB_RegEmail = New System.Windows.Forms.TextBox()
        Me.TB_RegPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PN_Register = New System.Windows.Forms.Panel()
        Me.BTN_OpenMainScreen4 = New System.Windows.Forms.Button()
        Me.BTN_OpenLogin3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_HadStrble = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_OpenStrble = New System.Windows.Forms.Button()
        Me.TB_RegPreName = New System.Windows.Forms.TextBox()
        Me.TB_RegStrblePass = New System.Windows.Forms.TextBox()
        Me.PN_Login = New System.Windows.Forms.Panel()
        Me.TB_LogPassword = New TextBox_with_Placeholder_2020.TBwPH()
        Me.TB_LogEmail = New TextBox_with_Placeholder_2020.TBwPH()
        Me.BTN_OpenMainScreen3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTN_OpenRegister3 = New System.Windows.Forms.Button()
        Me.BTN_Login = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PN_VideoUpload = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GeckoWebBrowser3 = New Gecko.GeckoWebBrowser()
        Me.BTN_OpenMyChannel2 = New System.Windows.Forms.Button()
        Me.TB_VideoTitle = New System.Windows.Forms.TextBox()
        Me.TB_VideoPath = New System.Windows.Forms.TextBox()
        Me.BTN_SelectVideo = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BTN_GetChannelVids = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_UserSearch = New System.Windows.Forms.TextBox()
        Me.BTN_SearchUsername = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PN_ChannelScreen = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.BTN_OpenUploadVid = New System.Windows.Forms.Button()
        Me.BTN_OpenMainScreen2 = New System.Windows.Forms.Button()
        Me.PN_MainScreen = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GeckoWebBrowser2 = New Gecko.GeckoWebBrowser()
        Me.BTN_LogOut = New System.Windows.Forms.Button()
        Me.BTN_OpenMyChannel = New System.Windows.Forms.Button()
        Me.BTN_OpenLogin2 = New System.Windows.Forms.Button()
        Me.BTN_OpenRegister2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.PN_StartupScreen = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BTN_OpenMainScreen = New System.Windows.Forms.Button()
        Me.BTN_OpenRegister = New System.Windows.Forms.Button()
        Me.BTN_OpenLogin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PN_Register.SuspendLayout()
        Me.PN_Login.SuspendLayout()
        Me.PN_VideoUpload.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PN_ChannelScreen.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PN_MainScreen.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PN_StartupScreen.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_UploadVideo
        '
        Me.BTN_UploadVideo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_UploadVideo.Enabled = False
        Me.BTN_UploadVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_UploadVideo.Location = New System.Drawing.Point(142, 85)
        Me.BTN_UploadVideo.Name = "BTN_UploadVideo"
        Me.BTN_UploadVideo.Size = New System.Drawing.Size(84, 69)
        Me.BTN_UploadVideo.TabIndex = 2
        Me.BTN_UploadVideo.Text = "Upload video"
        Me.BTN_UploadVideo.UseVisualStyleBackColor = True
        '
        'BTN_Register
        '
        Me.BTN_Register.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Register.Enabled = False
        Me.BTN_Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_Register.Location = New System.Drawing.Point(18, 216)
        Me.BTN_Register.Name = "BTN_Register"
        Me.BTN_Register.Size = New System.Drawing.Size(212, 30)
        Me.BTN_Register.TabIndex = 5
        Me.BTN_Register.Text = "Create Channel"
        Me.BTN_Register.UseVisualStyleBackColor = True
        '
        'TB_RegUsername
        '
        Me.TB_RegUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_RegUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_RegUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_RegUsername.Location = New System.Drawing.Point(10, -9)
        Me.TB_RegUsername.Multiline = True
        Me.TB_RegUsername.Name = "TB_RegUsername"
        Me.TB_RegUsername.Size = New System.Drawing.Size(237, 20)
        Me.TB_RegUsername.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "8_b}]it.png")
        Me.ImageList1.Images.SetKeyName(1, "477.jpg")
        Me.ImageList1.Images.SetKeyName(2, "3487f9cafdf8227203e9000c330fdef5_original.png")
        Me.ImageList1.Images.SetKeyName(3, "8091-blue-eyed-girl-listening-to-music-1920x1200-anime-wallpaper.jpg")
        '
        'TB_RegEmail
        '
        Me.TB_RegEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_RegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_RegEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_RegEmail.Location = New System.Drawing.Point(10, 17)
        Me.TB_RegEmail.Multiline = True
        Me.TB_RegEmail.Name = "TB_RegEmail"
        Me.TB_RegEmail.Size = New System.Drawing.Size(237, 20)
        Me.TB_RegEmail.TabIndex = 1
        '
        'TB_RegPassword
        '
        Me.TB_RegPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_RegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_RegPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_RegPassword.Location = New System.Drawing.Point(10, 43)
        Me.TB_RegPassword.Multiline = True
        Me.TB_RegPassword.Name = "TB_RegPassword"
        Me.TB_RegPassword.Size = New System.Drawing.Size(237, 20)
        Me.TB_RegPassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(-95, -12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(-60, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(-90, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password:"
        '
        'PN_Register
        '
        Me.PN_Register.Controls.Add(Me.BTN_OpenMainScreen4)
        Me.PN_Register.Controls.Add(Me.BTN_OpenLogin3)
        Me.PN_Register.Controls.Add(Me.Label11)
        Me.PN_Register.Controls.Add(Me.Label8)
        Me.PN_Register.Controls.Add(Me.CB_HadStrble)
        Me.PN_Register.Controls.Add(Me.TB_RegUsername)
        Me.PN_Register.Controls.Add(Me.Label4)
        Me.PN_Register.Controls.Add(Me.BTN_OpenStrble)
        Me.PN_Register.Controls.Add(Me.Label3)
        Me.PN_Register.Controls.Add(Me.BTN_Register)
        Me.PN_Register.Controls.Add(Me.TB_RegEmail)
        Me.PN_Register.Controls.Add(Me.Label2)
        Me.PN_Register.Controls.Add(Me.TB_RegPreName)
        Me.PN_Register.Controls.Add(Me.TB_RegStrblePass)
        Me.PN_Register.Controls.Add(Me.TB_RegPassword)
        Me.PN_Register.Controls.Add(Me.Label1)
        Me.PN_Register.Location = New System.Drawing.Point(489, 17)
        Me.PN_Register.Name = "PN_Register"
        Me.PN_Register.Size = New System.Drawing.Size(241, 260)
        Me.PN_Register.TabIndex = 10
        '
        'BTN_OpenMainScreen4
        '
        Me.BTN_OpenMainScreen4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_OpenMainScreen4.Location = New System.Drawing.Point(0, 237)
        Me.BTN_OpenMainScreen4.Name = "BTN_OpenMainScreen4"
        Me.BTN_OpenMainScreen4.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OpenMainScreen4.TabIndex = 18
        Me.BTN_OpenMainScreen4.Text = "Main Screen"
        Me.BTN_OpenMainScreen4.UseVisualStyleBackColor = True
        '
        'BTN_OpenLogin3
        '
        Me.BTN_OpenLogin3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OpenLogin3.Location = New System.Drawing.Point(167, 264)
        Me.BTN_OpenLogin3.Name = "BTN_OpenLogin3"
        Me.BTN_OpenLogin3.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OpenLogin3.TabIndex = 17
        Me.BTN_OpenLogin3.Text = "Login"
        Me.BTN_OpenLogin3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Already had an account?"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.Location = New System.Drawing.Point(-122, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Present Name:"
        '
        'CB_HadStrble
        '
        Me.CB_HadStrble.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CB_HadStrble.AutoSize = True
        Me.CB_HadStrble.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.CB_HadStrble.Location = New System.Drawing.Point(10, 126)
        Me.CB_HadStrble.Name = "CB_HadStrble"
        Me.CB_HadStrble.Size = New System.Drawing.Size(246, 20)
        Me.CB_HadStrble.TabIndex = 6
        Me.CB_HadStrble.Text = "Already Have A Streamable Account"
        Me.CB_HadStrble.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(-176, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Streamable Password:"
        '
        'BTN_OpenStrble
        '
        Me.BTN_OpenStrble.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OpenStrble.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_OpenStrble.Location = New System.Drawing.Point(18, 163)
        Me.BTN_OpenStrble.Name = "BTN_OpenStrble"
        Me.BTN_OpenStrble.Size = New System.Drawing.Size(212, 30)
        Me.BTN_OpenStrble.TabIndex = 7
        Me.BTN_OpenStrble.Text = "Create A Streamable Account"
        Me.BTN_OpenStrble.UseVisualStyleBackColor = True
        '
        'TB_RegPreName
        '
        Me.TB_RegPreName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_RegPreName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_RegPreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_RegPreName.Location = New System.Drawing.Point(10, 94)
        Me.TB_RegPreName.Multiline = True
        Me.TB_RegPreName.Name = "TB_RegPreName"
        Me.TB_RegPreName.Size = New System.Drawing.Size(237, 20)
        Me.TB_RegPreName.TabIndex = 4
        '
        'TB_RegStrblePass
        '
        Me.TB_RegStrblePass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_RegStrblePass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_RegStrblePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_RegStrblePass.Location = New System.Drawing.Point(10, 69)
        Me.TB_RegStrblePass.Multiline = True
        Me.TB_RegStrblePass.Name = "TB_RegStrblePass"
        Me.TB_RegStrblePass.Size = New System.Drawing.Size(237, 20)
        Me.TB_RegStrblePass.TabIndex = 3
        '
        'PN_Login
        '
        Me.PN_Login.Controls.Add(Me.TB_LogPassword)
        Me.PN_Login.Controls.Add(Me.TB_LogEmail)
        Me.PN_Login.Controls.Add(Me.BTN_OpenMainScreen3)
        Me.PN_Login.Controls.Add(Me.Label10)
        Me.PN_Login.Controls.Add(Me.BTN_OpenRegister3)
        Me.PN_Login.Controls.Add(Me.BTN_Login)
        Me.PN_Login.Controls.Add(Me.Label6)
        Me.PN_Login.Controls.Add(Me.Label5)
        Me.PN_Login.Location = New System.Drawing.Point(247, 111)
        Me.PN_Login.Name = "PN_Login"
        Me.PN_Login.Size = New System.Drawing.Size(236, 166)
        Me.PN_Login.TabIndex = 11
        '
        'TB_LogPassword
        '
        Me.TB_LogPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_LogPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_LogPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_LogPassword.ForeColor = System.Drawing.Color.DimGray
        Me.TB_LogPassword.Location = New System.Drawing.Point(35, 20)
        Me.TB_LogPassword.Name = "TB_LogPassword"
        Me.TB_LogPassword.PasswordProtected = False
        Me.TB_LogPassword.PlaceHolderForeColor = System.Drawing.Color.DimGray
        Me.TB_LogPassword.PlaceHolderText = "Password"
        Me.TB_LogPassword.selectAllonClick = False
        Me.TB_LogPassword.Size = New System.Drawing.Size(185, 22)
        Me.TB_LogPassword.TabIndex = 14
        Me.TB_LogPassword.Text = "Password"
        Me.TB_LogPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_LogPassword.TextColor = System.Drawing.Color.Black
        '
        'TB_LogEmail
        '
        Me.TB_LogEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TB_LogEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TB_LogEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_LogEmail.ForeColor = System.Drawing.Color.DimGray
        Me.TB_LogEmail.Location = New System.Drawing.Point(35, -35)
        Me.TB_LogEmail.Name = "TB_LogEmail"
        Me.TB_LogEmail.PasswordProtected = False
        Me.TB_LogEmail.PlaceHolderForeColor = System.Drawing.Color.DimGray
        Me.TB_LogEmail.PlaceHolderText = "Email"
        Me.TB_LogEmail.selectAllonClick = False
        Me.TB_LogEmail.Size = New System.Drawing.Size(185, 22)
        Me.TB_LogEmail.TabIndex = 14
        Me.TB_LogEmail.Text = "Email"
        Me.TB_LogEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_LogEmail.TextColor = System.Drawing.Color.Black
        '
        'BTN_OpenMainScreen3
        '
        Me.BTN_OpenMainScreen3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTN_OpenMainScreen3.Location = New System.Drawing.Point(0, 143)
        Me.BTN_OpenMainScreen3.Name = "BTN_OpenMainScreen3"
        Me.BTN_OpenMainScreen3.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OpenMainScreen3.TabIndex = 13
        Me.BTN_OpenMainScreen3.Text = "Main Screen"
        Me.BTN_OpenMainScreen3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Don't have an account?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BTN_OpenRegister3
        '
        Me.BTN_OpenRegister3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OpenRegister3.Location = New System.Drawing.Point(162, 162)
        Me.BTN_OpenRegister3.Name = "BTN_OpenRegister3"
        Me.BTN_OpenRegister3.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OpenRegister3.TabIndex = 11
        Me.BTN_OpenRegister3.Text = "Register"
        Me.BTN_OpenRegister3.UseVisualStyleBackColor = True
        '
        'BTN_Login
        '
        Me.BTN_Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_Login.Location = New System.Drawing.Point(23, 68)
        Me.BTN_Login.Name = "BTN_Login"
        Me.BTN_Login.Size = New System.Drawing.Size(214, 30)
        Me.BTN_Login.TabIndex = 10
        Me.BTN_Login.Text = "Login"
        Me.BTN_Login.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, -3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, -60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email"
        '
        'PN_VideoUpload
        '
        Me.PN_VideoUpload.Controls.Add(Me.PictureBox2)
        Me.PN_VideoUpload.Controls.Add(Me.Panel2)
        Me.PN_VideoUpload.Controls.Add(Me.BTN_OpenMyChannel2)
        Me.PN_VideoUpload.Controls.Add(Me.TB_VideoTitle)
        Me.PN_VideoUpload.Controls.Add(Me.TB_VideoPath)
        Me.PN_VideoUpload.Controls.Add(Me.BTN_SelectVideo)
        Me.PN_VideoUpload.Controls.Add(Me.BTN_UploadVideo)
        Me.PN_VideoUpload.Location = New System.Drawing.Point(3, 111)
        Me.PN_VideoUpload.Name = "PN_VideoUpload"
        Me.PN_VideoUpload.Size = New System.Drawing.Size(238, 166)
        Me.PN_VideoUpload.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Location = New System.Drawing.Point(232, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 76)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GeckoWebBrowser3)
        Me.Panel2.Location = New System.Drawing.Point(3, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 76)
        Me.Panel2.TabIndex = 25
        '
        'GeckoWebBrowser3
        '
        Me.GeckoWebBrowser3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeckoWebBrowser3.FrameEventsPropagateToMainWindow = False
        Me.GeckoWebBrowser3.Location = New System.Drawing.Point(-160, -16)
        Me.GeckoWebBrowser3.Name = "GeckoWebBrowser3"
        Me.GeckoWebBrowser3.NoDefaultContextMenu = True
        Me.GeckoWebBrowser3.Size = New System.Drawing.Size(550, 292)
        Me.GeckoWebBrowser3.TabIndex = 19
        Me.GeckoWebBrowser3.UseHttpActivityObserver = False
        '
        'BTN_OpenMyChannel2
        '
        Me.BTN_OpenMyChannel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_OpenMyChannel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_OpenMyChannel2.Location = New System.Drawing.Point(-98, 85)
        Me.BTN_OpenMyChannel2.Name = "BTN_OpenMyChannel2"
        Me.BTN_OpenMyChannel2.Size = New System.Drawing.Size(126, 23)
        Me.BTN_OpenMyChannel2.TabIndex = 15
        Me.BTN_OpenMyChannel2.Text = "Go to my channel"
        Me.BTN_OpenMyChannel2.UseVisualStyleBackColor = True
        '
        'TB_VideoTitle
        '
        Me.TB_VideoTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_VideoTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_VideoTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_VideoTitle.Location = New System.Drawing.Point(12, 109)
        Me.TB_VideoTitle.Multiline = True
        Me.TB_VideoTitle.Name = "TB_VideoTitle"
        Me.TB_VideoTitle.Size = New System.Drawing.Size(124, 20)
        Me.TB_VideoTitle.TabIndex = 13
        '
        'TB_VideoPath
        '
        Me.TB_VideoPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_VideoPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_VideoPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TB_VideoPath.ForeColor = System.Drawing.SystemColors.Control
        Me.TB_VideoPath.Location = New System.Drawing.Point(12, 134)
        Me.TB_VideoPath.Multiline = True
        Me.TB_VideoPath.Name = "TB_VideoPath"
        Me.TB_VideoPath.Size = New System.Drawing.Size(124, 20)
        Me.TB_VideoPath.TabIndex = 13
        Me.TB_VideoPath.Text = "Video Path"
        '
        'BTN_SelectVideo
        '
        Me.BTN_SelectVideo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_SelectVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_SelectVideo.Location = New System.Drawing.Point(34, 85)
        Me.BTN_SelectVideo.Name = "BTN_SelectVideo"
        Me.BTN_SelectVideo.Size = New System.Drawing.Size(102, 23)
        Me.BTN_SelectVideo.TabIndex = 13
        Me.BTN_SelectVideo.Text = "Select video"
        Me.BTN_SelectVideo.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BTN_GetChannelVids
        '
        Me.BTN_GetChannelVids.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_GetChannelVids.Location = New System.Drawing.Point(157, 2)
        Me.BTN_GetChannelVids.Name = "BTN_GetChannelVids"
        Me.BTN_GetChannelVids.Size = New System.Drawing.Size(146, 28)
        Me.BTN_GetChannelVids.TabIndex = 13
        Me.BTN_GetChannelVids.Text = "Refresh Channel"
        Me.BTN_GetChannelVids.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(309, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 15
        '
        'TB_UserSearch
        '
        Me.TB_UserSearch.Location = New System.Drawing.Point(3, 5)
        Me.TB_UserSearch.Name = "TB_UserSearch"
        Me.TB_UserSearch.Size = New System.Drawing.Size(187, 20)
        Me.TB_UserSearch.TabIndex = 16
        '
        'BTN_SearchUsername
        '
        Me.BTN_SearchUsername.Location = New System.Drawing.Point(196, 3)
        Me.BTN_SearchUsername.Name = "BTN_SearchUsername"
        Me.BTN_SearchUsername.Size = New System.Drawing.Size(75, 23)
        Me.BTN_SearchUsername.TabIndex = 17
        Me.BTN_SearchUsername.Text = "Search"
        Me.BTN_SearchUsername.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(4, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(152, 121)
        Me.ListBox1.TabIndex = 18
        '
        'PN_ChannelScreen
        '
        Me.PN_ChannelScreen.Controls.Add(Me.PictureBox3)
        Me.PN_ChannelScreen.Controls.Add(Me.ListView1)
        Me.PN_ChannelScreen.Controls.Add(Me.Panel3)
        Me.PN_ChannelScreen.Controls.Add(Me.BTN_OpenUploadVid)
        Me.PN_ChannelScreen.Controls.Add(Me.BTN_OpenMainScreen2)
        Me.PN_ChannelScreen.Controls.Add(Me.BTN_GetChannelVids)
        Me.PN_ChannelScreen.Controls.Add(Me.Label7)
        Me.PN_ChannelScreen.Location = New System.Drawing.Point(247, 284)
        Me.PN_ChannelScreen.Name = "PN_ChannelScreen"
        Me.PN_ChannelScreen.Size = New System.Drawing.Size(483, 99)
        Me.PN_ChannelScreen.TabIndex = 19
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Location = New System.Drawing.Point(477, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 65)
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Location = New System.Drawing.Point(4, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(147, 93)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.GeckoWebBrowser1)
        Me.Panel3.Location = New System.Drawing.Point(157, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 63)
        Me.Panel3.TabIndex = 25
        '
        'GeckoWebBrowser1
        '
        Me.GeckoWebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeckoWebBrowser1.FrameEventsPropagateToMainWindow = False
        Me.GeckoWebBrowser1.Location = New System.Drawing.Point(-160, -16)
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.NoDefaultContextMenu = True
        Me.GeckoWebBrowser1.Size = New System.Drawing.Size(641, 279)
        Me.GeckoWebBrowser1.TabIndex = 19
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'BTN_OpenUploadVid
        '
        Me.BTN_OpenUploadVid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_OpenUploadVid.Location = New System.Drawing.Point(445, 3)
        Me.BTN_OpenUploadVid.Name = "BTN_OpenUploadVid"
        Me.BTN_OpenUploadVid.Size = New System.Drawing.Size(140, 27)
        Me.BTN_OpenUploadVid.TabIndex = 16
        Me.BTN_OpenUploadVid.Text = "Upload Video"
        Me.BTN_OpenUploadVid.UseVisualStyleBackColor = True
        '
        'BTN_OpenMainScreen2
        '
        Me.BTN_OpenMainScreen2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BTN_OpenMainScreen2.Location = New System.Drawing.Point(596, 3)
        Me.BTN_OpenMainScreen2.Name = "BTN_OpenMainScreen2"
        Me.BTN_OpenMainScreen2.Size = New System.Drawing.Size(140, 27)
        Me.BTN_OpenMainScreen2.TabIndex = 16
        Me.BTN_OpenMainScreen2.Text = "Main Screen"
        Me.BTN_OpenMainScreen2.UseVisualStyleBackColor = True
        '
        'PN_MainScreen
        '
        Me.PN_MainScreen.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PN_MainScreen.Controls.Add(Me.PictureBox1)
        Me.PN_MainScreen.Controls.Add(Me.Panel1)
        Me.PN_MainScreen.Controls.Add(Me.BTN_LogOut)
        Me.PN_MainScreen.Controls.Add(Me.BTN_OpenMyChannel)
        Me.PN_MainScreen.Controls.Add(Me.BTN_OpenLogin2)
        Me.PN_MainScreen.Controls.Add(Me.BTN_OpenRegister2)
        Me.PN_MainScreen.Controls.Add(Me.Label9)
        Me.PN_MainScreen.Controls.Add(Me.ListView2)
        Me.PN_MainScreen.Controls.Add(Me.BTN_SearchUsername)
        Me.PN_MainScreen.Controls.Add(Me.TB_UserSearch)
        Me.PN_MainScreen.Controls.Add(Me.ListBox1)
        Me.PN_MainScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PN_MainScreen.Location = New System.Drawing.Point(0, 0)
        Me.PN_MainScreen.Name = "PN_MainScreen"
        Me.PN_MainScreen.Size = New System.Drawing.Size(742, 395)
        Me.PN_MainScreen.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Location = New System.Drawing.Point(735, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 355)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GeckoWebBrowser2)
        Me.Panel1.Location = New System.Drawing.Point(161, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(575, 355)
        Me.Panel1.TabIndex = 25
        '
        'GeckoWebBrowser2
        '
        Me.GeckoWebBrowser2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeckoWebBrowser2.FrameEventsPropagateToMainWindow = False
        Me.GeckoWebBrowser2.Location = New System.Drawing.Point(-160, -16)
        Me.GeckoWebBrowser2.Name = "GeckoWebBrowser2"
        Me.GeckoWebBrowser2.NoDefaultContextMenu = True
        Me.GeckoWebBrowser2.Size = New System.Drawing.Size(896, 571)
        Me.GeckoWebBrowser2.TabIndex = 19
        Me.GeckoWebBrowser2.UseHttpActivityObserver = False
        '
        'BTN_LogOut
        '
        Me.BTN_LogOut.Location = New System.Drawing.Point(398, 3)
        Me.BTN_LogOut.Name = "BTN_LogOut"
        Me.BTN_LogOut.Size = New System.Drawing.Size(75, 23)
        Me.BTN_LogOut.TabIndex = 24
        Me.BTN_LogOut.Text = "Log Out"
        Me.BTN_LogOut.UseVisualStyleBackColor = True
        '
        'BTN_OpenMyChannel
        '
        Me.BTN_OpenMyChannel.Location = New System.Drawing.Point(479, 3)
        Me.BTN_OpenMyChannel.Name = "BTN_OpenMyChannel"
        Me.BTN_OpenMyChannel.Size = New System.Drawing.Size(103, 23)
        Me.BTN_OpenMyChannel.TabIndex = 23
        Me.BTN_OpenMyChannel.Text = "Go to my channel"
        Me.BTN_OpenMyChannel.UseVisualStyleBackColor = True
        '
        'BTN_OpenLogin2
        '
        Me.BTN_OpenLogin2.Location = New System.Drawing.Point(586, 3)
        Me.BTN_OpenLogin2.Name = "BTN_OpenLogin2"
        Me.BTN_OpenLogin2.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OpenLogin2.TabIndex = 22
        Me.BTN_OpenLogin2.Text = "Login"
        Me.BTN_OpenLogin2.UseVisualStyleBackColor = True
        '
        'BTN_OpenRegister2
        '
        Me.BTN_OpenRegister2.Location = New System.Drawing.Point(664, 3)
        Me.BTN_OpenRegister2.Name = "BTN_OpenRegister2"
        Me.BTN_OpenRegister2.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OpenRegister2.TabIndex = 22
        Me.BTN_OpenRegister2.Text = "Register"
        Me.BTN_OpenRegister2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(277, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 21
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Location = New System.Drawing.Point(5, 160)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(151, 229)
        Me.ListView2.TabIndex = 20
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'PN_StartupScreen
        '
        Me.PN_StartupScreen.Controls.Add(Me.Label13)
        Me.PN_StartupScreen.Controls.Add(Me.Label12)
        Me.PN_StartupScreen.Controls.Add(Me.BTN_OpenMainScreen)
        Me.PN_StartupScreen.Controls.Add(Me.BTN_OpenRegister)
        Me.PN_StartupScreen.Controls.Add(Me.BTN_OpenLogin)
        Me.PN_StartupScreen.Location = New System.Drawing.Point(0, 0)
        Me.PN_StartupScreen.Name = "PN_StartupScreen"
        Me.PN_StartupScreen.Size = New System.Drawing.Size(160, 106)
        Me.PN_StartupScreen.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label13.Location = New System.Drawing.Point(260, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(243, 55)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "IceStream"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(347, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "By PetterPet"
        '
        'BTN_OpenMainScreen
        '
        Me.BTN_OpenMainScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OpenMainScreen.Location = New System.Drawing.Point(30, 63)
        Me.BTN_OpenMainScreen.Name = "BTN_OpenMainScreen"
        Me.BTN_OpenMainScreen.Size = New System.Drawing.Size(114, 23)
        Me.BTN_OpenMainScreen.TabIndex = 23
        Me.BTN_OpenMainScreen.Text = "Skip"
        Me.BTN_OpenMainScreen.UseVisualStyleBackColor = True
        '
        'BTN_OpenRegister
        '
        Me.BTN_OpenRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OpenRegister.Location = New System.Drawing.Point(30, 121)
        Me.BTN_OpenRegister.Name = "BTN_OpenRegister"
        Me.BTN_OpenRegister.Size = New System.Drawing.Size(114, 23)
        Me.BTN_OpenRegister.TabIndex = 22
        Me.BTN_OpenRegister.Text = "Register"
        Me.BTN_OpenRegister.UseVisualStyleBackColor = True
        '
        'BTN_OpenLogin
        '
        Me.BTN_OpenLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_OpenLogin.Location = New System.Drawing.Point(30, 92)
        Me.BTN_OpenLogin.Name = "BTN_OpenLogin"
        Me.BTN_OpenLogin.Size = New System.Drawing.Size(114, 23)
        Me.BTN_OpenLogin.TabIndex = 22
        Me.BTN_OpenLogin.Text = "Login"
        Me.BTN_OpenLogin.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 395)
        Me.Controls.Add(Me.PN_MainScreen)
        Me.Controls.Add(Me.PN_StartupScreen)
        Me.Controls.Add(Me.PN_ChannelScreen)
        Me.Controls.Add(Me.PN_VideoUpload)
        Me.Controls.Add(Me.PN_Register)
        Me.Controls.Add(Me.PN_Login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PN_Register.ResumeLayout(False)
        Me.PN_Register.PerformLayout()
        Me.PN_Login.ResumeLayout(False)
        Me.PN_Login.PerformLayout()
        Me.PN_VideoUpload.ResumeLayout(False)
        Me.PN_VideoUpload.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PN_ChannelScreen.ResumeLayout(False)
        Me.PN_ChannelScreen.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PN_MainScreen.ResumeLayout(False)
        Me.PN_MainScreen.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PN_StartupScreen.ResumeLayout(False)
        Me.PN_StartupScreen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_UploadVideo As Button
    Friend WithEvents BTN_Register As Button
    Friend WithEvents TB_RegUsername As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TB_RegEmail As TextBox
    Friend WithEvents TB_RegPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PN_Register As Panel
    Friend WithEvents PN_Login As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTN_Login As Button
    Friend WithEvents PN_VideoUpload As Panel
    Friend WithEvents TB_VideoPath As TextBox
    Friend WithEvents BTN_SelectVideo As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_RegStrblePass As TextBox
    Friend WithEvents BTN_OpenStrble As Button
    Friend WithEvents CB_HadStrble As CheckBox
    Friend WithEvents TB_VideoTitle As TextBox
    Friend WithEvents BTN_GetChannelVids As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_UserSearch As TextBox
    Friend WithEvents BTN_SearchUsername As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_RegPreName As TextBox
    Friend WithEvents PN_ChannelScreen As Panel
    Friend WithEvents PN_MainScreen As Panel
    Friend WithEvents PN_StartupScreen As Panel
    Friend WithEvents BTN_OpenLogin As Button
    Friend WithEvents BTN_OpenRegister As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents GeckoWebBrowser2 As Gecko.GeckoWebBrowser
    Friend WithEvents Label9 As Label
    Friend WithEvents BTN_OpenLogin2 As Button
    Friend WithEvents BTN_OpenRegister2 As Button
    Friend WithEvents BTN_OpenMainScreen As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents BTN_OpenRegister3 As Button
    Friend WithEvents BTN_OpenMainScreen2 As Button
    Friend WithEvents BTN_OpenMyChannel As Button
    Friend WithEvents BTN_OpenMyChannel2 As Button
    Friend WithEvents BTN_OpenLogin3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BTN_OpenMainScreen3 As Button
    Friend WithEvents BTN_OpenMainScreen4 As Button
    Friend WithEvents BTN_OpenUploadVid As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BTN_LogOut As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TB_LogEmail As TextBox_with_Placeholder_2020.TBwPH
    Friend WithEvents TB_LogPassword As TextBox_with_Placeholder_2020.TBwPH
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GeckoWebBrowser3 As Gecko.GeckoWebBrowser
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
