namespace MauiApp5;

public partial class ListaProdutoPage : ContentPage
{
	public ListaProdutoPage()
	{
		List<Produto> lista = Produto.Lista;
		InitializeComponent();
		lstProduto.ItemsSource = lista;
	}




    private void ViewCell_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProductPage() { BindingContext = ((ViewCell)sender).BindingContext });
    }
}