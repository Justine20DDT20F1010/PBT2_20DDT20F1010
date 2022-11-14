' Name : Justine Nanggai
'Class : DDT5A
'PBT : 2

Public Class Form1
    'declare test1 - 3 is data type is integer
    Dim Test1, Test2, Test3 As Integer
    Private Sub Btn_Calculate_Click(sender As Object, e As EventArgs) Handles Btn_Calculate.Click
        Dim Test1, Test2, Test3 As Integer
        Dim avg As Double
        'call the getMark
        GetMarks(Test1, Test2, Test3)
        avg = CalcAverage(Test1, Test2, Test3)
        DisplayAverage(avg)
    End Sub


    'note that : ByRef is the alternative
    'This means that you are not handing over a copy of the original variable but pointing to the original variable.
    Private Sub GetMarks(ByRef Test1 As Integer, ByRef Test2 As Integer, ByRef Test3 As Integer)
        Test1 = Val(Tb_Test1.Text)
        Test2 = Val(Tb_Test2.Text)
        Test3 = Val(Tb_Test3.Text)
    End Sub


    Private Sub DisplayAverage(ByVal Average As Double)
        'display in txt average
        Tb_Avg.Text = Average
    End Sub

    ' note that :  ByVal is the default when you're passing variables over to a function or Sub.
    Private Function CalcAverage(ByVal Test1 As Integer, ByVal Test2 As Integer, ByVal Test3 As Integer)
        Dim Average As Double
        ' formula
        Average = (Test1 + Test2 + Test3) / 3
        ' return t
        Return Format(Average, "0.00")
    End Function
End Class
