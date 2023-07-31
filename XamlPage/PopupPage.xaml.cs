using CommunityToolkit.Maui.Views;

namespace PopupApp.XamlPage;

public partial class PopupPage : Popup
{
	public PopupPage()
	{
		InitializeComponent();
		this.VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		this.HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
		
		//this.Color = Color.FromRgb(255, 255, 255);
		//this.Content.MaximumHeightRequest = 1500;
		//this.Content.MinimumHeightRequest = 1500;
		//      this.Content.HeightRequest = 1500;
		//this.Content.VerticalOptions = LayoutOptions.FillAndExpand;
		//      this.Content.WidthRequest = 1200;
		//this.Content.Margin = 0;
		this.Size = new Size(1200,1200);
		this.Window = new Window() { Width = 1200, Height = 1200, MaximumHeight = 1200, MinimumHeight = 1200, MaximumWidth = 1200, MinimumWidth = 1200 };
		var treeData = this.GetVisualTreeDescendants();
    }
}
