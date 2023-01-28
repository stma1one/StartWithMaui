namespace StartWithMaui;

public partial class MainPage : ContentPage
{
	List<string> imagesUrl = new List<string>();
	int current = 0;

	public MainPage()
	{
		InitializeComponent();
		imagesUrl.Add("dotnet_bot.svg");
		imagesUrl.Add("https://img.freepik.com/free-photo/cupcakes-dark-chocolate-sugar-butter-sour-cream-condenced-milk-side-view-jpg_141793-3537.jpg");
		imagesUrl.Add("https://img.freepik.com/free-psd/3d-rendering-earth-icon-with-tree-isolated_47987-7658.jpg");
		imagesUrl.Add("https://img.freepik.com/free-psd/blue-cube-with-questionmark-sign-boxes_47987-7785.jpg");
	}


	private void Button_Clicked(object sender, EventArgs e)
	{
		Button btn = sender as Button;//נמיר את האובייקט לכפתור שהפעיל את האירוע
			

			//נבדוק מי הכפתור שהפעיל את האירוע
			if (btn == up_btn)//האם זה הכפתור למעלה?
				current = current + 1;

			if (btn == down_btn)
				current = current - 1;

			slide_img.Source = imagesUrl[current];
        

		if (current <= 0)
            down_btn.IsEnabled = false;
        if (current >= imagesUrl.Count-1)
        {
            up_btn.IsEnabled = false;
        }
        else
        {
            up_btn.IsEnabled = true;
            down_btn.IsEnabled = true;

        }



    }
	


    
}

