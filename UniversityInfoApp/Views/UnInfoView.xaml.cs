namespace UniversityInfoApp.Views;

public partial class UnInfoView : ContentView
{
	public UnInfoView(string uniName, string uniWebsite)
	{
		InitializeComponent();

		UniName.Text = uniName;
		UniWebsite.Text = uniWebsite;
	}
}