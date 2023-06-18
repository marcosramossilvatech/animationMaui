namespace BasicAnimationDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped_ForFadeAnimation(object sender, EventArgs e)
	{
		//Fade out
		await imgFade.FadeTo(0, 2000);

        //Fade In
        await imgFade.FadeTo(1, 2000);
    }

	private async void TapGestureRecognizer_Tapped_ForRotateAnimation(object sender, EventArgs e)
	{
		await imgRotation.RelRotateTo(360, 2000);
		//imgRotation.Rotation = 0;
	}

	private async void TapGestureRecognizer_Tapped_ForVRotateAnimation(object sender, EventArgs e)
	{
        await imgVRotation.RotateXTo(360, 2000);
    }
    private async void TapGestureRecognizer_Tapped_ForHRotateAnimation(object sender, EventArgs e)
	{
        await imgHRotation.RotateYTo(360, 2000);
    }

    private async void TapGestureRecognizer_Tapped_ForScaleAnimation(object sender, EventArgs e)
	{
        await imgScale.ScaleTo(2, 2000);

        await imgScale.ScaleTo(1, 2000);
    }

	private async void TapGestureRecognizer_Tapped_ForTranslateAnimation(object sender, EventArgs e)
	{
        await imgTranslate.TranslateTo(50,0,1000);

        await imgTranslate.TranslateTo(0, 0, 1000);

        await imgTranslate.TranslateTo(0, -50, 1000);

        await imgTranslate.TranslateTo(0, 0, 1000);

    }

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Task.WhenAny(imgHRotation.ScaleTo(2, 2000), imgTranslate.RotateXTo(360, 4000));
		await imgTranslate.ScaleTo(1, 2000);


    }
}

