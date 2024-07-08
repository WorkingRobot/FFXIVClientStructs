// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x2C)]
public unsafe partial struct Adventure {
    [FieldOffset(0x00)] public int Name_Offset;
    [FieldOffset(0x04)] public int Impression_Offset;
    [FieldOffset(0x08)] public int Description_Offset;
    /// <remarks>Level</remarks>
    [FieldOffset(0x0C)] public int Level;
    [FieldOffset(0x10)] public int MinLevel;
    /// <remarks>PlaceName</remarks>
    [FieldOffset(0x14)] public int PlaceName;
    [FieldOffset(0x18)] public int IconList;
    [FieldOffset(0x1C)] public int IconDiscovered;
    [FieldOffset(0x20)] public int IconUndiscovered;
    /// <remarks>Emote</remarks>
    [FieldOffset(0x24)] public ushort Emote;
    [FieldOffset(0x26)] public ushort MinTime;
    [FieldOffset(0x28)] public ushort MaxTime;
    [FieldOffset(0x2A)] public byte MaxLevel;
    [FieldOffset(0x2B)] public bool IsInitial;
}
