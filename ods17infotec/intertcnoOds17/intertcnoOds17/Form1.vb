Public Class Form1
    Private Sub FormulárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulárioToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub CatalogaçãoDeProblemasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogaçãoDeProblemasToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub FormularioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FormularioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FormularioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FomEProblemasDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'FomEProblemasDataSet.Formulario'. Você pode movê-la ou removê-la conforme necessário.
        Me.FormularioTableAdapter.Fill(Me.FomEProblemasDataSet.Formulario)

    End Sub
End Class
