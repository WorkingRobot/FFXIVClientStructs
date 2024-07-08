// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x0C)]
public unsafe partial struct BGM {
    [FieldOffset(0x00)] public int File_Offset;
    [FieldOffset(0x04)] public float DisableRestartResetTime;
    [FieldOffset(0x08)] public byte Priority;
    [FieldOffset(0x09)] public byte SpecialMode;
    [FieldOffset(0x0A)] public BitField0AFlags BitField0A;
    public bool DisableRestartTimeOut => BitField0A.HasFlag(BitField0AFlags.DisableRestartTimeOut);
    public bool DisableRestart => BitField0A.HasFlag(BitField0AFlags.DisableRestart);
    public bool PassEnd => BitField0A.HasFlag(BitField0AFlags.PassEnd);

    [Flags]
    public enum BitField0AFlags : byte {
    	DisableRestartTimeOut = 1 << 0,
    	DisableRestart = 1 << 1,
    	PassEnd = 1 << 2,
    }
}
