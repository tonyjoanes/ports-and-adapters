namespace TonysPortsAndAdapters.Core
{
    using System.Collections.Generic;
    using TonysPortsAndAdapters.Core.Ports.Incoming;
    using TonysPortsAndAdapters.Core.Ports.Outgoing;
    using TonysPortsAndAdapters.Domain;

    /// <summary>
    /// Get Widget adapter class
    /// </summary>
    /// <remarks>This can use any database as long as it conforms to the IWidgetDatabase interface.
    /// It would just be a case of changing DI framework to replace with a different implementation.
    /// The IWidgetDatabase that is injected into this class is the outgoing port (outgoing data to a backend database from this API app)
    /// </remarks>
    public class GetWidgetAdapter : IGetWidget
    {
        /// <summary>
        /// The widget database is the outgoing port
        /// </summary>
        private readonly IWidgetDatabase widgetDatabase;

        public GetWidgetAdapter(IWidgetDatabase widgetDatabase)
        {
            this.widgetDatabase = widgetDatabase;
        }

        public Widget GetWidget(int id) => widgetDatabase.GetWidget(id);


        public IEnumerable<Widget> GetWidgets() => widgetDatabase.GetWidgets();
    }
}
