// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe partial struct Treasure {
    [FieldOffset(0x00)] public int Unknown0_Offset;
    [FieldOffset(0x04)] public int Unknown1_Offset;
    [FieldOffset(0x08)] public sbyte Unknown2;
    [FieldOffset(0x09)] public sbyte Unknown3;
    [FieldOffset(0x0A)] public sbyte Unknown4;
    [FieldOffset(0x0B)] public sbyte Unknown5;
    [FieldOffset(0x0C)] public sbyte Unknown6;
    [FieldOffset(0x0D)] public sbyte Unknown7;
    /// <remarks>ExportedSG</remarks>
    [FieldOffset(0x10)] public uint SGB;
    [FieldOffset(0x14)] public byte Unknown_70;
    [FieldOffset(0x15)] public BitField15Flags BitField15;
    public bool Unknown8 => BitField15.HasFlag(BitField15Flags.Unknown8);
    public bool Unknown9 => BitField15.HasFlag(BitField15Flags.Unknown9);

    [Flags]
    public enum BitField15Flags : byte {
    	Unknown8 = 1 << 0,
    	Unknown9 = 1 << 1,
    }
}
