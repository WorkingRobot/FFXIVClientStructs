// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x24)]
public unsafe partial struct FishParameter {
    [FieldOffset(0x00)] public int Text_Offset;
    [FieldOffset(0x04)] public int Unknown_70_1_Offset;
    [FieldOffset(0x08)] public int Unknown_70_2_Offset;
    [FieldOffset(0x0C)] public int Unknown_70_3_Offset;
    [FieldOffset(0x10)] public uint AchievementCredit;
    /// <remarks>EventItem, Item</remarks>
    [FieldOffset(0x14)] public int Item;
    /// <remarks>GatheringItemLevelConvertTable</remarks>
    [FieldOffset(0x18)] public ushort GatheringItemLevel;
    [FieldOffset(0x1A)] public ushort Unknown1;
    /// <remarks>FishingSpot</remarks>
    [FieldOffset(0x1C)] public ushort FishingSpot;
    /// <remarks>GatheringSubCategory</remarks>
    [FieldOffset(0x1E)] public ushort GatheringSubCategory;
    [FieldOffset(0x20)] public byte OceanStars;
    /// <remarks>FishingRecordType</remarks>
    [FieldOffset(0x21)] public byte FishingRecordType;
    [FieldOffset(0x22)] public BitField22Flags BitField22;
    public bool IsHidden => BitField22.HasFlag(BitField22Flags.IsHidden);
    public bool IsInLog => BitField22.HasFlag(BitField22Flags.IsInLog);

    [Flags]
    public enum BitField22Flags : byte {
    	IsHidden = 1 << 0,
    	IsInLog = 1 << 1,
    }
}
