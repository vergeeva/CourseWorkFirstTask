
Public Class Form1
    Dim ListOfProduct As List(Of Product) = New List(Of Product)
    Dim OrderProduct As List(Of Product) = New List(Of Product)
    Private Function ReadFromFile() As Boolean
        Dim sr As IO.StreamReader = New IO.StreamReader(My.Application.Info.DirectoryPath & "\Асортимент.txt")
        Dim st As String
        While sr.Peek <> -1
            Dim i As Integer = 0
            st = sr.ReadLine()
            If st <> "" Then
                Dim Name As String = st.Split("!")(0)
                Dim Price As Double = st.Split("!")(1)
                Dim Count As Integer = st.Split("!")(2)
                ListOfProduct.Add(New Product(Name, Price, Count))
            End If
        End While
        sr.Close()
        Return 1
    End Function

    Private Function WriteOrderInFile() As Boolean
        Dim sw As IO.StreamWriter = New IO.StreamWriter(My.Application.Info.DirectoryPath & "\Заказ.txt")
        Dim line As String
        For index = 0 To OrderProduct.Count - 1
            line = OrderProduct.Item(index).Get_Name() + "!" + Convert.ToString(OrderProduct.Item(index).Get_Price()) + Convert.ToString(OrderProduct.Item(index).Get_Count())
            sw.WriteLine(line)
        Next
        sw.Close()
        Return 1
    End Function

    Private Function WriteInListBox(ByRef LB As ListBox) As Boolean
        LB.Items.Clear()
        For index = 0 To OrderProduct.Count - 1
            LB.Items.Add(OrderProduct.Item(index).ToString())
        Next
        Return 1
    End Function
    Private Function WriteInDataGridView(ByRef DGV As DataGridView) As Boolean
        DGV.Rows.Clear()
        For index = 0 To ListOfProduct.Count - 1
            DGV.Rows.Add(ListOfProduct.Item(index).Get_Name, ListOfProduct.Item(index).Get_Price, ListOfProduct.Item(index).Get_Count)
        Next
        Return 1
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadFromFile()
        WriteInDataGridView(DataGridView1)
    End Sub

    Private Sub AddInOrder_Click(sender As Object, e As EventArgs) Handles AddInOrder.Click

        Dim Index As Integer
        Dim SameCounter As Boolean = 0
        If CountToAdd.Value <> 0 And DataGridView1.SelectedRows.Count <> 0 Then 'Проверяем, указал ли пользователь число для добавления и выделил ли то, что хочет добавить
            Index = DataGridView1.SelectedRows.Item(0).Index() 'Берем индекс выделенной строки
            Dim Pred As MyPredicate = New MyPredicate(ListOfProduct.Item(Index)) 'Создаем предикат для поиска по массиву не типичной структуры данных
            For i = 0 To OrderProduct.Count - 1 'Проходимся по списку заказа
                Dim TempIndex As Integer = OrderProduct.FindIndex(New Predicate(Of Product)(Function() Pred.IsProduct(OrderProduct.Item(i)))) 'Ищем выделенный пользователем элемент
                If TempIndex <> -1 Then 'Если нашли
                    If ListOfProduct.Item(Index).Get_Count >= CountToAdd.Value Then 'Если количество для добавления не превышает колиечество в наличии
                        OrderProduct.Item(i).Get_Count += CountToAdd.Value 'То добавляем количество товара
                        ListOfProduct.Item(Index).Get_Count -= CountToAdd.Value 'вычитаем это количество из ассортимента
                        WriteInListBox(ListBox2) 'обновляем заказ
                        WriteInDataGridView(DataGridView1) 'обновляем ассортимент
                        SameCounter = 1 'Указывает на то, что товар нашелся
                    Else
                        SameCounter = 1 'товар нашелся
                        MessageBox.Show("Такого количества нет в наличии", "Предупреждение") 'но пользователь много хочет
                    End If
                    Exit For
                End If
            Next
            If Not SameCounter Then 'если товар не нашелся
                If ListOfProduct.Item(Index).Get_Count >= CountToAdd.Value Then 'если количество для добавления не превышает колиечство в наличии
                    OrderProduct.Add(New Product(ListOfProduct.Item(Index).Get_Name, ListOfProduct.Item(Index).Get_Price, CountToAdd.Value)) 'добавляем новый элемент
                    ListOfProduct.Item(Index).Get_Count -= CountToAdd.Value 'Вычитаем количество товара из ассортимента
                    WriteInListBox(ListBox2) 'обновляем заказ
                    WriteInDataGridView(DataGridView1) 'обновляем ассортимент
                Else
                    MessageBox.Show("Такого количества нет в наличии", "Предупреждение")
                End If 'предупреждение о том, что пользователь ошибся
            End If
            WriteOrderInFile()
        Else
            MessageBox.Show("Выберите количество или строку в таблице!", "Напоминание")
        End If 'Предупрреждение о том, что пользователь что-то недоделал
    End Sub

    Private Sub CloseMe_Click(sender As Object, e As EventArgs) Handles CloseMe.Click
        Close()
    End Sub

    Private Sub Reference_Click(sender As Object, e As EventArgs) Handles Reference.Click
        MessageBox.Show("Чтобы использовать NumericUpDown, нужно нажать на стрелочки 'вверх' и 'вниз' для изменения значения в окошке
Также вы можете вписать число в окно самостоятельно", "Справка")
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        MessageBox.Show("Чтобы удалить товар из списка - дважды щелкните по нему;
Чтобы удалить выбранное количество товара, выберите товар в списке, нажмите кнопку удалить", "Помощь")
    End Sub

    Private Sub DelFromOrder_Click(sender As Object, e As EventArgs) Handles DelFromOrder.Click
        If CountToDelete.Value <> 0 And ListBox2.SelectedIndex <> -1 Then
            Dim Index As Integer = ListBox2.SelectedIndex
            Dim IndexList As Integer

            Dim Pred As MyPredicate = New MyPredicate(OrderProduct.Item(Index))
            For i = 0 To ListOfProduct.Count - 1
                Dim TempIndex As Integer = ListOfProduct.FindIndex(New Predicate(Of Product)(Function() Pred.IsProduct(ListOfProduct.Item(i))))
                If TempIndex <> -1 Then
                    IndexList = i
                    Exit For
                End If
            Next

            If OrderProduct.Item(Index).Get_Count() > CountToDelete.Value Then
                OrderProduct.Item(Index).Get_Count() -= CountToDelete.Value
                ListOfProduct.Item(IndexList).Get_Count += CountToDelete.Value
                WriteInListBox(ListBox2)
                WriteInDataGridView(DataGridView1)
            ElseIf OrderProduct.Item(Index).Get_Count() < CountToDelete.Value Then
                MessageBox.Show("Выбрано слишком большое число для удаления", "Предупреждение")
            ElseIf OrderProduct.Item(Index).Get_Count() = CountToDelete.Value Then
                OrderProduct.RemoveAt(Index)
                ListOfProduct.Item(IndexList).Get_Count += CountToDelete.Value
                MessageBox.Show("Товар удален из списка", "Сообщение")
                WriteInListBox(ListBox2)
                WriteInDataGridView(DataGridView1)
            End If
        Else
            MessageBox.Show("Выберите количество или строку в списке!", "Напоминание")
        End If
    End Sub

    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        Dim Index As Integer = ListBox2.SelectedIndex
        OrderProduct.RemoveAt(Index)
        MessageBox.Show("Товар удален из списка", "Сообщение")
        WriteInListBox(ListBox2)
    End Sub
End Class
