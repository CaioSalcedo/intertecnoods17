Public Class Form2
    Private Sub FormulárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulárioToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub CatalogaçãoDeProblemasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogaçãoDeProblemasToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ListaDeProblemasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ListaDeProblemasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ListaDeProblemasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FomEProblemasDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'FomEProblemasDataSet.listaDeProblemas'. Você pode movê-la ou removê-la conforme necessário.
        Me.ListaDeProblemasTableAdapter.Fill(Me.FomEProblemasDataSet.listaDeProblemas)

    End Sub
End Class