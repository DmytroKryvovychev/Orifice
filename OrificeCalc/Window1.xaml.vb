Public Class About

    Private Sub ButtonC_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles ButtonC.Click
        Me.Hide()
    End Sub

    Private Sub About_Initialized(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Initialized
        Me.Height = 100
        Me.Width = 400
        Label1.Content = "Программа предназначена для расчета диаметра жиклера " & vbCr & "(отверстия) по заданному массовому расходу (обратная " & vbCr & "задача позволяет найти величину массового расхода)"
    End Sub

    Private Sub grid0_MouseLeftButtonDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles grid0.MouseLeftButtonDown
        Me.DragMove()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class
