<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim TituloDoProblemaLabel As System.Windows.Forms.Label
        Dim ExplicacaoDoProblemaLabel As System.Windows.Forms.Label
        Dim ODSReferenciaLabel As System.Windows.Forms.Label
        Dim RegiaoDoProblemaLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NavegaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogaçãoDeProblemasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FomEProblemasDataSet = New intertcnoOds17.fomEProblemasDataSet()
        Me.ListaDeProblemasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaDeProblemasTableAdapter = New intertcnoOds17.fomEProblemasDataSetTableAdapters.listaDeProblemasTableAdapter()
        Me.TableAdapterManager = New intertcnoOds17.fomEProblemasDataSetTableAdapters.TableAdapterManager()
        Me.ListaDeProblemasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ListaDeProblemasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TituloDoProblemaTextBox = New System.Windows.Forms.TextBox()
        Me.ExplicacaoDoProblemaTextBox = New System.Windows.Forms.TextBox()
        Me.ODSReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.RegiaoDoProblemaTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        TituloDoProblemaLabel = New System.Windows.Forms.Label()
        ExplicacaoDoProblemaLabel = New System.Windows.Forms.Label()
        ODSReferenciaLabel = New System.Windows.Forms.Label()
        RegiaoDoProblemaLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FomEProblemasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDeProblemasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDeProblemasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListaDeProblemasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NavegaçãoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NavegaçãoToolStripMenuItem
        '
        Me.NavegaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormulárioToolStripMenuItem, Me.CatalogaçãoDeProblemasToolStripMenuItem})
        Me.NavegaçãoToolStripMenuItem.Name = "NavegaçãoToolStripMenuItem"
        Me.NavegaçãoToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.NavegaçãoToolStripMenuItem.Text = "Navegação"
        '
        'FormulárioToolStripMenuItem
        '
        Me.FormulárioToolStripMenuItem.Name = "FormulárioToolStripMenuItem"
        Me.FormulárioToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.FormulárioToolStripMenuItem.Text = "Formulário"
        '
        'CatalogaçãoDeProblemasToolStripMenuItem
        '
        Me.CatalogaçãoDeProblemasToolStripMenuItem.Name = "CatalogaçãoDeProblemasToolStripMenuItem"
        Me.CatalogaçãoDeProblemasToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.CatalogaçãoDeProblemasToolStripMenuItem.Text = "Catalogação de problemas"
        '
        'FomEProblemasDataSet
        '
        Me.FomEProblemasDataSet.DataSetName = "fomEProblemasDataSet"
        Me.FomEProblemasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaDeProblemasBindingSource
        '
        Me.ListaDeProblemasBindingSource.DataMember = "listaDeProblemas"
        Me.ListaDeProblemasBindingSource.DataSource = Me.FomEProblemasDataSet
        '
        'ListaDeProblemasTableAdapter
        '
        Me.ListaDeProblemasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FormularioTableAdapter = Nothing
        Me.TableAdapterManager.listaDeProblemasTableAdapter = Me.ListaDeProblemasTableAdapter
        Me.TableAdapterManager.UpdateOrder = intertcnoOds17.fomEProblemasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListaDeProblemasBindingNavigator
        '
        Me.ListaDeProblemasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListaDeProblemasBindingNavigator.BindingSource = Me.ListaDeProblemasBindingSource
        Me.ListaDeProblemasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListaDeProblemasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListaDeProblemasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListaDeProblemasBindingNavigatorSaveItem})
        Me.ListaDeProblemasBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.ListaDeProblemasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListaDeProblemasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListaDeProblemasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListaDeProblemasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListaDeProblemasBindingNavigator.Name = "ListaDeProblemasBindingNavigator"
        Me.ListaDeProblemasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListaDeProblemasBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ListaDeProblemasBindingNavigator.TabIndex = 2
        Me.ListaDeProblemasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'ListaDeProblemasBindingNavigatorSaveItem
        '
        Me.ListaDeProblemasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListaDeProblemasBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListaDeProblemasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListaDeProblemasBindingNavigatorSaveItem.Name = "ListaDeProblemasBindingNavigatorSaveItem"
        Me.ListaDeProblemasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ListaDeProblemasBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'TituloDoProblemaLabel
        '
        TituloDoProblemaLabel.AutoSize = True
        TituloDoProblemaLabel.Location = New System.Drawing.Point(258, 123)
        TituloDoProblemaLabel.Name = "TituloDoProblemaLabel"
        TituloDoProblemaLabel.Size = New System.Drawing.Size(102, 13)
        TituloDoProblemaLabel.TabIndex = 4
        TituloDoProblemaLabel.Text = "Título Do Problema:"
        '
        'TituloDoProblemaTextBox
        '
        Me.TituloDoProblemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaDeProblemasBindingSource, "TituloDoProblema", True))
        Me.TituloDoProblemaTextBox.Location = New System.Drawing.Point(389, 120)
        Me.TituloDoProblemaTextBox.Name = "TituloDoProblemaTextBox"
        Me.TituloDoProblemaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TituloDoProblemaTextBox.TabIndex = 5
        '
        'ExplicacaoDoProblemaLabel
        '
        ExplicacaoDoProblemaLabel.AutoSize = True
        ExplicacaoDoProblemaLabel.Location = New System.Drawing.Point(258, 150)
        ExplicacaoDoProblemaLabel.Name = "ExplicacaoDoProblemaLabel"
        ExplicacaoDoProblemaLabel.Size = New System.Drawing.Size(125, 13)
        ExplicacaoDoProblemaLabel.TabIndex = 6
        ExplicacaoDoProblemaLabel.Text = "explicação Do Problema:"
        '
        'ExplicacaoDoProblemaTextBox
        '
        Me.ExplicacaoDoProblemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaDeProblemasBindingSource, "explicacaoDoProblema", True))
        Me.ExplicacaoDoProblemaTextBox.Location = New System.Drawing.Point(389, 147)
        Me.ExplicacaoDoProblemaTextBox.Multiline = True
        Me.ExplicacaoDoProblemaTextBox.Name = "ExplicacaoDoProblemaTextBox"
        Me.ExplicacaoDoProblemaTextBox.Size = New System.Drawing.Size(150, 62)
        Me.ExplicacaoDoProblemaTextBox.TabIndex = 7
        '
        'ODSReferenciaLabel
        '
        ODSReferenciaLabel.AutoSize = True
        ODSReferenciaLabel.Location = New System.Drawing.Point(258, 218)
        ODSReferenciaLabel.Name = "ODSReferenciaLabel"
        ODSReferenciaLabel.Size = New System.Drawing.Size(85, 13)
        ODSReferenciaLabel.TabIndex = 8
        ODSReferenciaLabel.Text = "ODSReferencia:"
        '
        'ODSReferenciaTextBox
        '
        Me.ODSReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaDeProblemasBindingSource, "ODSReferencia", True))
        Me.ODSReferenciaTextBox.Location = New System.Drawing.Point(389, 215)
        Me.ODSReferenciaTextBox.Name = "ODSReferenciaTextBox"
        Me.ODSReferenciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ODSReferenciaTextBox.TabIndex = 9
        '
        'RegiaoDoProblemaLabel
        '
        RegiaoDoProblemaLabel.AutoSize = True
        RegiaoDoProblemaLabel.Location = New System.Drawing.Point(258, 248)
        RegiaoDoProblemaLabel.Name = "RegiaoDoProblemaLabel"
        RegiaoDoProblemaLabel.Size = New System.Drawing.Size(108, 13)
        RegiaoDoProblemaLabel.TabIndex = 10
        RegiaoDoProblemaLabel.Text = "Região Do Problema:"
        '
        'RegiaoDoProblemaTextBox
        '
        Me.RegiaoDoProblemaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaDeProblemasBindingSource, "RegiaoDoProblema", True))
        Me.RegiaoDoProblemaTextBox.Location = New System.Drawing.Point(389, 245)
        Me.RegiaoDoProblemaTextBox.Name = "RegiaoDoProblemaTextBox"
        Me.RegiaoDoProblemaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RegiaoDoProblemaTextBox.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(265, 91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "Envie os problemas atuais aqui"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(TituloDoProblemaLabel)
        Me.Controls.Add(Me.TituloDoProblemaTextBox)
        Me.Controls.Add(ExplicacaoDoProblemaLabel)
        Me.Controls.Add(Me.ExplicacaoDoProblemaTextBox)
        Me.Controls.Add(ODSReferenciaLabel)
        Me.Controls.Add(Me.ODSReferenciaTextBox)
        Me.Controls.Add(RegiaoDoProblemaLabel)
        Me.Controls.Add(Me.RegiaoDoProblemaTextBox)
        Me.Controls.Add(Me.ListaDeProblemasBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FomEProblemasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDeProblemasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDeProblemasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListaDeProblemasBindingNavigator.ResumeLayout(False)
        Me.ListaDeProblemasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NavegaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogaçãoDeProblemasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FomEProblemasDataSet As fomEProblemasDataSet
    Friend WithEvents ListaDeProblemasBindingSource As BindingSource
    Friend WithEvents ListaDeProblemasTableAdapter As fomEProblemasDataSetTableAdapters.listaDeProblemasTableAdapter
    Friend WithEvents TableAdapterManager As fomEProblemasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListaDeProblemasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ListaDeProblemasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TituloDoProblemaTextBox As TextBox
    Friend WithEvents ExplicacaoDoProblemaTextBox As TextBox
    Friend WithEvents ODSReferenciaTextBox As TextBox
    Friend WithEvents RegiaoDoProblemaTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
