<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CountToAdd = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddInOrder = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Help = New System.Windows.Forms.Button()
        Me.DelFromOrder = New System.Windows.Forms.Button()
        Me.CountToDelete = New System.Windows.Forms.NumericUpDown()
        Me.CloseMe = New System.Windows.Forms.Button()
        Me.Reference = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CountToAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CountToDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CountToAdd
        '
        Me.CountToAdd.Location = New System.Drawing.Point(16, 41)
        Me.CountToAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CountToAdd.Name = "CountToAdd"
        Me.CountToAdd.Size = New System.Drawing.Size(153, 27)
        Me.CountToAdd.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddInOrder)
        Me.GroupBox1.Controls.Add(Me.CountToAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(516, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 123)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Заказать"
        '
        'AddInOrder
        '
        Me.AddInOrder.Location = New System.Drawing.Point(16, 75)
        Me.AddInOrder.Name = "AddInOrder"
        Me.AddInOrder.Size = New System.Drawing.Size(153, 28)
        Me.AddInOrder.TabIndex = 1
        Me.AddInOrder.Text = "Добавить в заказ"
        Me.AddInOrder.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 19
        Me.ListBox2.Location = New System.Drawing.Point(730, 52)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(342, 403)
        Me.ListBox2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Выберите товар, который хотите заказать:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(726, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Выбранные товары:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Help)
        Me.GroupBox2.Controls.Add(Me.DelFromOrder)
        Me.GroupBox2.Controls.Add(Me.CountToDelete)
        Me.GroupBox2.Location = New System.Drawing.Point(516, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 177)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Редактирование заказа"
        '
        'Help
        '
        Me.Help.Location = New System.Drawing.Point(16, 128)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(153, 25)
        Me.Help.TabIndex = 10
        Me.Help.Text = "Помощь"
        Me.Help.UseVisualStyleBackColor = True
        '
        'DelFromOrder
        '
        Me.DelFromOrder.Location = New System.Drawing.Point(16, 75)
        Me.DelFromOrder.Name = "DelFromOrder"
        Me.DelFromOrder.Size = New System.Drawing.Size(153, 47)
        Me.DelFromOrder.TabIndex = 1
        Me.DelFromOrder.Text = "Удалить заданное количество"
        Me.DelFromOrder.UseVisualStyleBackColor = True
        '
        'CountToDelete
        '
        Me.CountToDelete.Location = New System.Drawing.Point(16, 41)
        Me.CountToDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CountToDelete.Name = "CountToDelete"
        Me.CountToDelete.Size = New System.Drawing.Size(153, 27)
        Me.CountToDelete.TabIndex = 0
        '
        'CloseMe
        '
        Me.CloseMe.Location = New System.Drawing.Point(532, 421)
        Me.CloseMe.Name = "CloseMe"
        Me.CloseMe.Size = New System.Drawing.Size(163, 25)
        Me.CloseMe.TabIndex = 9
        Me.CloseMe.Text = "Закрыть"
        Me.CloseMe.UseVisualStyleBackColor = True
        '
        'Reference
        '
        Me.Reference.Location = New System.Drawing.Point(532, 390)
        Me.Reference.Name = "Reference"
        Me.Reference.Size = New System.Drawing.Size(163, 25)
        Me.Reference.TabIndex = 10
        Me.Reference.Text = "Справка"
        Me.Reference.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(479, 403)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Наименование"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 175
        '
        'Column2
        '
        Me.Column2.HeaderText = "Стоимость"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Оставшееся количество"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 477)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Reference)
        Me.Controls.Add(Me.CloseMe)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Окно"
        CType(Me.CountToAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CountToDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CountToAdd As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddInOrder As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Help As Button
    Friend WithEvents DelFromOrder As Button
    Friend WithEvents CountToDelete As NumericUpDown
    Friend WithEvents CloseMe As Button
    Friend WithEvents Reference As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
