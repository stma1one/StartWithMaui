namespace StartWithMaui;

public partial class MainPage : ContentPage
{
	List<string> imageUrls;
	int pos;
	public MainPage()
	{
		InitializeComponent();
		imageUrls = new List<string>() { "https://media.tenor.com/Q2RZ9YrQ14oAAAAM/omg-wow.gif", "https://media4.giphy.com/media/5VKbvrjxpVJCM/giphy.gif", "https://i.pinimg.com/originals/e2/c0/8a/e2c08adfc309967679935d0dccb89cf9.gif" };
		pos = -1;
		down.IsEnabled = false;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;


		//      int i;
		//string no = img.Source.ToString()[7].ToString();
		//i = int.Parse(no.ToString());



		if (button == up)
		{
			pos = pos + 1;
			if (pos >= imageUrls.Count - 1)
			{
				up.IsEnabled = false;

			}

		}
		else
		{
			pos = pos - 1;
			if (pos <= 0)
			{
				down.IsEnabled = false;

			}
		}

			
		
		img.Source = imageUrls[pos];

        if (pos <= 0)
        {
            down.IsEnabled = false;
            up.IsEnabled = true;
        }
       else if (pos >= imageUrls.Count-1)
        {
            up.IsEnabled = false;
            down.IsEnabled = true;

        }
		else
		{
            down.IsEnabled = true;
            up.IsEnabled = true;
        }
    }
}

