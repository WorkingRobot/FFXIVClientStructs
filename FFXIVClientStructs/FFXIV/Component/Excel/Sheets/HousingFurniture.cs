// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe partial struct HousingFurniture {
    [FieldOffset(0x00)] public uint UsageParameter;
    /// <remarks>CustomTalk</remarks>
    [FieldOffset(0x04)] public uint CustomTalk;
    /// <remarks>Item</remarks>
    [FieldOffset(0x08)] public uint Item;
    [FieldOffset(0x0C)] public ushort ModelKey;
    [FieldOffset(0x0E)] public byte HousingItemCategory;
    [FieldOffset(0x0F)] public byte UsageType;
    [FieldOffset(0x10)] public byte Unknown0;
    [FieldOffset(0x11)] public byte AquariumTier;
    [FieldOffset(0x12)] public byte Unknown1;
    [FieldOffset(0x13)] public byte Unknown2;
    [FieldOffset(0x14)] public byte Unknown3;
    [FieldOffset(0x15)] public BitField15Flags BitField15;
    public bool DestroyOnRemoval => BitField15.HasFlag(BitField15Flags.DestroyOnRemoval);
    public bool Unknown4 => BitField15.HasFlag(BitField15Flags.Unknown4);
    public bool Unknown5 => BitField15.HasFlag(BitField15Flags.Unknown5);
    public bool Unknown6 => BitField15.HasFlag(BitField15Flags.Unknown6);

    [Flags]
    public enum BitField15Flags : byte {
    	DestroyOnRemoval = 1 << 0,
    	Unknown4 = 1 << 1,
    	Unknown5 = 1 << 2,
    	Unknown6 = 1 << 3,
    }
}
