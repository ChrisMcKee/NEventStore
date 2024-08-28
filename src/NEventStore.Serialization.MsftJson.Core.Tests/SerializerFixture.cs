// ReSharper disable CheckNamespace

namespace NEventStore.Serialization.AcceptanceTests
// ReSharper restore CheckNamespace
{
    using NEventStore.Serialization.System.Text.Json;

    public partial class SerializerFixture
    {
        public SerializerFixture()
        {
            _createSerializer = () =>
                new MsftJsonSerializer(null);
        }
    }
}