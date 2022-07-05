namespace TonysPortsAndAdapters.Core.Ports.Incoming
{
    using TonysPortsAndAdapters.Domain;

    public interface IGetWidget
    {
        Widget GetWidget(int id);
        IEnumerable<Widget> GetWidgets();
    }
}
