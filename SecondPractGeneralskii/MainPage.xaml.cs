namespace SecondPractGeneralskii;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
    private void TaskOne(object sender, EventArgs e)
    {
        int V = 0;
        int S = 0;
        if(int.TryParse(zn1.Text, out int a) && int.TryParse(zn2.Text, out int b) && int.TryParse(zn3.Text, out int c))
        {
            V = a * b * c;
            S = 2 * (a * b) + (b * c) + (a * c);
        }
        entRez1.Text = V.ToString();
        entRez2.Text = S.ToString();
    }
    private void TaskTwo(object sender, EventArgs e)
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int sum = 0;
        int proizvedenie = 1;
        if(int.TryParse(zn4.Text, out int twoDigits))
        {
            firstNumber = twoDigits / 10;
            secondNumber = twoDigits % 10;
            sum = firstNumber + secondNumber;
            proizvedenie = firstNumber * secondNumber;
        }
        entRez3.Text = sum.ToString();
        entRez4.Text = proizvedenie.ToString();
    }
}

