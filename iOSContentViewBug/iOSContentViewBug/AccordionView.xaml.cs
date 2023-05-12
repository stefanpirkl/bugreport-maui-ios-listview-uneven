namespace iOSContentViewBug;

public partial class AccordionView : ContentView
{
    public AccordionView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty AccordionContentProperty = BindableProperty.Create(nameof(AccordionContent), typeof(string), typeof(AccordionView), default(string));
    public string AccordionContent
    {
        get => (string)GetValue(AccordionContentProperty);
        set => SetValue(AccordionContentProperty, value);
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        frame.IsVisible = !frame.IsVisible;
        label.Text = frame.IsVisible ? "Show" : "Hide";
    }
}