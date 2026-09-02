<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim NomeCompletoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim NumeroDeTelefoneLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NavegaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormulárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogaçãoDeProblemasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FomEProblemasDataSet = New intertcnoOds17.fomEProblemasDataSet()
        Me.FormularioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FormularioTableAdapter = New intertcnoOds17.fomEProblemasDataSetTableAdapters.FormularioTableAdapter()
        Me.TableAdapterManager = New intertcnoOds17.fomEProblemasDataSetTableAdapters.TableAdapterManager()
        Me.FormularioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FormularioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.CEPTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroDeTelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        NomeCompletoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        NumeroDeTelefoneLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FomEProblemasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormularioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormularioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormularioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NavegaçãoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'FormularioBindingSource
        '
        Me.FormularioBindingSource.DataMember = "Formulario"
        Me.FormularioBindingSource.DataSource = Me.FomEProblemasDataSet
        '
        'FormularioTableAdapter
        '
        Me.FormularioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FormularioTableAdapter = Me.FormularioTableAdapter
        Me.TableAdapterManager.listaDeProblemasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = intertcnoOds17.fomEProblemasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormularioBindingNavigator
        '
        Me.FormularioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FormularioBindingNavigator.BindingSource = Me.FormularioBindingSource
        Me.FormularioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FormularioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FormularioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FormularioBindingNavigatorSaveItem})
        Me.FormularioBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.FormularioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FormularioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FormularioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FormularioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FormularioBindingNavigator.Name = "FormularioBindingNavigator"
        Me.FormularioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FormularioBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.FormularioBindingNavigator.TabIndex = 1
        Me.FormularioBindingNavigator.Text = "BindingNavigator1"
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
        'FormularioBindingNavigatorSaveItem
        '
        Me.FormularioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FormularioBindingNavigatorSaveItem.Image = CType(resources.GetObject("FormularioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FormularioBindingNavigatorSaveItem.Name = "FormularioBindingNavigatorSaveItem"
        Me.FormularioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FormularioBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.Location = New System.Drawing.Point(284, 140)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(85, 13)
        NomeCompletoLabel.TabIndex = 4
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormularioBindingSource, "NomeCompleto", True))
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(397, 137)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeCompletoTextBox.TabIndex = 5
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(284, 166)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormularioBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(397, 163)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Location = New System.Drawing.Point(284, 192)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(41, 13)
        SenhaLabel.TabIndex = 8
        SenhaLabel.Text = "Senha:"
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormularioBindingSource, "Senha", True))
        Me.SenhaTextBox.Location = New System.Drawing.Point(397, 189)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SenhaTextBox.TabIndex = 9
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Location = New System.Drawing.Point(284, 218)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(31, 13)
        CEPLabel.TabIndex = 10
        CEPLabel.Text = "CEP:"
        '
        'CEPTextBox
        '
        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormularioBindingSource, "CEP", True))
        Me.CEPTextBox.Location = New System.Drawing.Point(397, 215)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CEPTextBox.TabIndex = 11
        '
        'NumeroDeTelefoneLabel
        '
        NumeroDeTelefoneLabel.AutoSize = True
        NumeroDeTelefoneLabel.Location = New System.Drawing.Point(284, 244)
        NumeroDeTelefoneLabel.Name = "NumeroDeTelefoneLabel"
        NumeroDeTelefoneLabel.Size = New System.Drawing.Size(107, 13)
        NumeroDeTelefoneLabel.TabIndex = 12
        NumeroDeTelefoneLabel.Text = "numero De Telefone:"
        '
        'NumeroDeTelefoneTextBox
        '
        Me.NumeroDeTelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FormularioBindingSource, "numeroDeTelefone", True))
        Me.NumeroDeTelefoneTextBox.Location = New System.Drawing.Point(397, 241)
        Me.NumeroDeTelefoneTextBox.Name = "NumeroDeTelefoneTextBox"
        Me.NumeroDeTelefoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroDeTelefoneTextBox.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(343, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Formulário de entrada"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(NomeCompletoLabel)
        Me.Controls.Add(Me.NomeCompletoTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.CEPTextBox)
        Me.Controls.Add(NumeroDeTelefoneLabel)
        Me.Controls.Add(Me.NumeroDeTelefoneTextBox)
        Me.Controls.Add(Me.FormularioBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FomEProblemasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormularioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormularioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormularioBindingNavigator.ResumeLayout(False)
        Me.FormularioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NavegaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogaçãoDeProblemasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FomEProblemasDataSet As fomEProblemasDataSet
    Friend WithEvents FormularioBindingSource As BindingSource
    Friend WithEvents FormularioTableAdapter As fomEProblemasDataSetTableAdapters.FormularioTableAdapter
    Friend WithEvents TableAdapterManager As fomEProblemasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FormularioBindingNavigator As BindingNavigator
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
    Friend WithEvents FormularioBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NomeCompletoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents CEPTextBox As TextBox
    Friend WithEvents NumeroDeTelefoneTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
