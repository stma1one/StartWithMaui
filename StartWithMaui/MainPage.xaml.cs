namespace StartWithMaui;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
        int i;
		string no = img.Source.ToString()[7].ToString();
		i = int.Parse(no.ToString());
        if (button==up)
		{ i = i + 1; }
		else
		{
			i = i - 1;
		}
		
		img.Source = $"a{i%5}a.jpg";
	}
}

