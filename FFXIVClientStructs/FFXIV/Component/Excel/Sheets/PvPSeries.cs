// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x204)]
public unsafe partial struct PvPSeries {
    [FieldOffset(0x00), FixedSizeArray] internal FixedSizeArray32<LevelRewardsStruct> _levelRewards;
    [FieldOffset(0x200)] public byte Unknown0;

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public partial struct LevelRewardsStruct {
        [FieldOffset(0x00), FixedSizeArray] internal FixedSizeArray2<int> _levelRewardItem;
        [FieldOffset(0x08)] public int Unknown0;
        [FieldOffset(0x0C), FixedSizeArray] internal FixedSizeArray2<ushort> _levelRewardCount;
    }
}
