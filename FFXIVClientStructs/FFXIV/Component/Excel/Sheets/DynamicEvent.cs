// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x24)]
public unsafe partial struct DynamicEvent {
    [FieldOffset(0x00)] public int Name_Offset;
    [FieldOffset(0x04)] public int Description_Offset;
    [FieldOffset(0x08)] public uint LGBEventObject;
    [FieldOffset(0x0C)] public uint LGBMapRange;
    /// <remarks>Quest</remarks>
    [FieldOffset(0x10)] public uint Quest;
    /// <remarks>LogMessage</remarks>
    [FieldOffset(0x14)] public uint Announce;
    [FieldOffset(0x18)] public short Unknown0;
    [FieldOffset(0x1A)] public short Unknown1;
    [FieldOffset(0x1C)] public short Unknown2;
    /// <remarks>DynamicEventType</remarks>
    [FieldOffset(0x1E)] public byte EventType;
    /// <remarks>DynamicEventEnemyType</remarks>
    [FieldOffset(0x1F)] public byte EnemyType;
    [FieldOffset(0x20)] public byte Unknown3;
    [FieldOffset(0x21)] public byte Unknown4;
    [FieldOffset(0x22)] public byte Unknown5;
    /// <remarks>DynamicEventSingleBattle</remarks>
    [FieldOffset(0x23)] public byte SingleBattle;
}
