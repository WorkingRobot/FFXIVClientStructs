// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x48)]
public unsafe partial struct GoldSaucerTalk {
    [FieldOffset(0x00)] public int Unknown0_Offset;
    [FieldOffset(0x04)] public int Unknown1_Offset;
    [FieldOffset(0x08)] public int Unknown2_Offset;
    [FieldOffset(0x0C)] public int Unknown3_Offset;
    [FieldOffset(0x10)] public int Unknown4_Offset;
    [FieldOffset(0x14)] public int Unknown5_Offset;
    [FieldOffset(0x18)] public int Unknown6_Offset;
    [FieldOffset(0x1C)] public int Unknown7_Offset;
    [FieldOffset(0x20)] public int Unknown8_Offset;
    [FieldOffset(0x24)] public int Unknown9_Offset;
    [FieldOffset(0x28)] public int Unknown10_Offset;
    [FieldOffset(0x2C)] public ushort Unknown11;
    [FieldOffset(0x2E)] public ushort Unknown12;
    [FieldOffset(0x30)] public ushort Unknown13;
    [FieldOffset(0x32)] public ushort Unknown14;
    [FieldOffset(0x34)] public ushort Unknown15;
    [FieldOffset(0x36)] public ushort Unknown16;
    [FieldOffset(0x38)] public ushort Unknown17;
    [FieldOffset(0x3A)] public ushort Unknown18;
    [FieldOffset(0x3C)] public ushort Unknown19;
    [FieldOffset(0x3E)] public ushort Unknown20;
    [FieldOffset(0x40)] public ushort Unknown21;
    [FieldOffset(0x42)] public ushort Unknown22;
    [FieldOffset(0x44)] public byte Unknown23;
    [FieldOffset(0x45)] public byte Unknown24;
    [FieldOffset(0x46)] public byte Unknown25;
    [FieldOffset(0x47)] public BitField47Flags BitField47;
    public bool Unknown26 => BitField47.HasFlag(BitField47Flags.Unknown26);
    public bool Unknown27 => BitField47.HasFlag(BitField47Flags.Unknown27);

    [Flags]
    public enum BitField47Flags : byte {
    	Unknown26 = 1 << 0,
    	Unknown27 = 1 << 1,
    }
}
