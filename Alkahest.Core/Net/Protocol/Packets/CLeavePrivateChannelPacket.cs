namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class CLeavePrivateChannelPacket : Packet
    {
        const string Name = "C_LEAVE_PRIVATE_CHANNEL";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new CLeavePrivateChannelPacket();
        }

        [PacketField]
        public ushort Index { get; set; }
    }
}
