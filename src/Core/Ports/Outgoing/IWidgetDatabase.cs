namespace TonysPortsAndAdapters.Core.Ports.Outgoing
{
    using TonysPortsAndAdapters.Domain;

    public interface IWidgetDatabase
    {
        Widget GetWidget(int id);
        IEnumerable<Widget> GetWidgets();
    }
}
