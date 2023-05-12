namespace iOSContentViewBug;

public partial class MainPage : ContentPage
{
    private List<string> _accordionValues = new List<string>
    {
        "Content",
        "Content",
        "Content",
        "Content",
        "Content",
        "Content",
        "Content",
        "Content",
        "Content",
        "Content",
        "Content"
    };


    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }


    public List<string> AccordionValues
    {
        get { return _accordionValues; }
        set { _accordionValues = value; OnPropertyChanged(nameof(AccordionValues)); }
    }
}
