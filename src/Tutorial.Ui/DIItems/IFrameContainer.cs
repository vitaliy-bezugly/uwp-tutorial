using Windows.UI.Xaml.Controls;

namespace Tutorial.Ui.DIItems
{
    public interface IFrameContainer
    {
        Frame MainFrame { get; }

        void InstallFrame(Frame frame);
    }
}
