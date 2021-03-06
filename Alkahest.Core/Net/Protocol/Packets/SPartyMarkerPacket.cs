using System.Collections.Generic;
using Alkahest.Core.Game;

namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class SPartyMarkerPacket : Packet
    {
        const string Name = "S_PARTY_MARKER";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new SPartyMarkerPacket();
        }

        public sealed class PartyMarkerInfo
        {
            [PacketField]
            public PartyMarkerColor Color { get; set; }

            [PacketField]
            public GameId Target { get; set; }
        }

        [PacketField]
        public List<PartyMarkerInfo> PartyMarkers { get; } =
            new List<PartyMarkerInfo>();
    }
}
