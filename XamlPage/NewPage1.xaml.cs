namespace PopupApp.XamlPage;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    public object pruebita;

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        pruebita = "funciono";
        MessagingCenter.Send<NewPage1>(this, "WORK");
        Navigation.PopModalAsync();

    }

}
