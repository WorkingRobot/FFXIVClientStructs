// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x04)]
public unsafe partial struct BuddyItem {
    /// <remarks>Item</remarks>
    [FieldOffset(0x00)] public ushort Item;
    [FieldOffset(0x02)] public byte Status;
    [FieldOffset(0x03)] public BitField03Flags BitField03;
    public bool UseField => BitField03.HasFlag(BitField03Flags.UseField);
    public bool UseTraining => BitField03.HasFlag(BitField03Flags.UseTraining);
    public bool Unknown0 => BitField03.HasFlag(BitField03Flags.Unknown0);

    [Flags]
    public enum BitField03Flags : byte {
    	UseField = 1 << 0,
    	UseTraining = 1 << 1,
    	Unknown0 = 1 << 2,
    }
}
