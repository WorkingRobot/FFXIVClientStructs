// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x20)]
public unsafe partial struct CollectablesShop {
    [FieldOffset(0x00)] public int Name_Offset;
    /// <remarks>Quest</remarks>
    [FieldOffset(0x04)] public uint Quest;
    [FieldOffset(0x08), FixedSizeArray] internal FixedSizeArray11<ushort> _shopItems;
    [FieldOffset(0x1E)] public byte RewardType;
}
