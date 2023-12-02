namespace GoblinsAndMauis
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public int Count 
        {
            get  => count;
            set { count = value; OnPropertyChanged(); }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
            clickCountLabel.Text = count.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}