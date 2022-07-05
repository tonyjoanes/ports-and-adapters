namespace TonysPortsAndAdapters.Data
{
    using TonysPortsAndAdapters.Core.Ports.Outgoing;
    using TonysPortsAndAdapters.Domain;

    public class WidgetDatabaseAdapter : IWidgetDatabase
    {
        private List<Widget> _widgets;

        public WidgetDatabaseAdapter()
        {
            _widgets = new List<Widget>();
            _widgets.Add(new Widget() { Id = 1, DisplayName = "Widget One", Width = 100 });
            _widgets.Add(new Widget() { Id = 2, DisplayName = "Widget Two", Width = 150 });
            _widgets.Add(new Widget() { Id = 3, DisplayName = "Widget Three", Width = 150 });
        }

        public Widget GetWidget(int id)
        {
            return _widgets.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Widget> GetWidgets()
        {
            return _widgets;
        }
    }
}
