Public Class Form1
    Dim a() As Integer          '评委数组


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeCombobox()      '初始化Combobox

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("请选择演讲者！！！", vbOKOnly, "警告")     '保证选择演讲者
        Else
            Clean()
            GetRandomNumber()
            ShowName()
            CheckOut()
        End If


    End Sub
    Function ProduceRandomNumber()
        Randomize()                     '产生随机数
        Dim x As Integer
        x = Int(35 * Rnd() + 1)
        Return x
    End Function
    Sub GetRandomNumber()               '将随机数填进评委数组a()
        For i = 1 To 9
            ReDim Preserve a(i)
            Dim temp As Integer
            temp = ProduceRandomNumber()
            For j = 1 To UBound(a)
                If temp <> a(j - 1) Then
                    a(i) = temp
                Else
                    temp = ProduceRandomNumber()
                    j = 0
                End If
            Next
        Next
    End Sub
    Sub Clean()
        ListBox1.Items.Clear()
        ReDim a(0)
    End Sub
    Sub ShowName()                      '显示评委
        Dim b(9) As JudgeName
        For i = 1 To UBound(b)
            b(i) = a(i)
            ListBox1.Items.Add(b(i).ToString)
        Next
    End Sub
    Enum JudgeName              '枚举评委
        曹睿冲 = 1
        冯文杰
        冯晓宽
        黄键航
        黄亚琴
        黄子虚
        赖家欣
        李秋灵
        李伟琦
        李耀辉
        林培鑫
        林译峰
        林越
        刘昊鑫
        马检
        欧阳臻
        任杰
        石蕴莹
        谭海威
        王哲轩
        韦湖
        吴彦辰
        夏弋松
        严菁菁
        曾理
        周诗琪
        周毅镕
        朱琳聪
        祝旭乾
        张艺
        邓丽
        刘清雅
        吴桂颖
        杨一辰
        余锦琛
    End Enum
    Sub InitializeCombobox()            '初始化Combobox
        Dim allName(35) As JudgeName
        For i = 1 To 35
            allName(i) = i
            ComboBox1.Items.Add(allName(i).ToString)
        Next
    End Sub
    Sub CheckOut()                      '检验是否演讲者处于评委名单
        Dim check As Integer
        Dim b(35) As JudgeName
        For j = 1 To 35
            b(j) = j
            If ComboBox1.Text = b(j).ToString Then
                check = j
            End If
        Next
        For i = 1 To UBound(a)
            If a(i) = check Then
                Clean()
                GetRandomNumber()
                ShowName()
                CheckOut()
            End If
        Next
    End Sub

    Private Sub 退出EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出EToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub 帮助HToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 帮助HToolStripMenuItem.Click
        MsgBox("你可能按了一个假按钮！", vbOKOnly, "提示信息")
    End Sub

    Private Sub 重启RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重启RToolStripMenuItem.Click
        Application.Restart()

    End Sub
End Class
