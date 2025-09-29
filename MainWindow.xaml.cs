using System.Windows;

namespace MyWpfApp;

public partial class MainWindow : Window
{
    private bool running = false;

    public MainWindow()
    {
        InitializeComponent();

    }

    private void btnToggleRun_Click(object sender, RoutedEventArgs e)
    {

        string inputText = tbInput.Text;
        char c1 = tbInput.Text[0];
        char c2 = tbInput.Text[1];
        char c3 = tbInput.Text[2];
        char c4 = tbInput.Text[3];
        char c5 = tbInput.Text[4];
        char c6 = tbInput.Text[5];
        char c7 = tbInput.Text[6];
        
        string final = ToString(c1, c4, c3, c2, c5, c6, c7);
        
        running = !running;
        if (running)
        {
            tbStatus.Text = final;
            btnToggleRun.Content = "Refresh";
        }
        else
        {
            tbStatus.Text = final;
            btnToggleRun.Content = "Refresh";
        }
    }

    private string ToString(char c1, char c4, char c3, char c2, char c5, char c6, char c7)
    {
        return $"{c1}{c4}{c3}{c2}{c5}{c6}{c7}";
    }

}