// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x1C)]
public unsafe partial struct AOZContentBriefingBNpc {
    /// <remarks>BNpcName</remarks>
    [FieldOffset(0x00)] public uint BNpcName;
    [FieldOffset(0x04)] public uint TargetSmall;
    [FieldOffset(0x08)] public uint TargetLarge;
    [FieldOffset(0x0C)] public byte Endurance;
    [FieldOffset(0x0D)] public byte Fire;
    [FieldOffset(0x0E)] public byte Ice;
    [FieldOffset(0x0F)] public byte Wind;
    [FieldOffset(0x10)] public byte Earth;
    [FieldOffset(0x11)] public byte Thunder;
    [FieldOffset(0x12)] public byte Water;
    [FieldOffset(0x13)] public byte Slashing;
    [FieldOffset(0x14)] public byte Piercing;
    [FieldOffset(0x15)] public byte Blunt;
    [FieldOffset(0x16)] public byte Magic;
    [FieldOffset(0x17)] public BitField17Flags BitField17;
    public bool HideStats => BitField17.HasFlag(BitField17Flags.HideStats);
    public bool SlowVuln => BitField17.HasFlag(BitField17Flags.SlowVuln);
    public bool PetrificationVuln => BitField17.HasFlag(BitField17Flags.PetrificationVuln);
    public bool ParalysisVuln => BitField17.HasFlag(BitField17Flags.ParalysisVuln);
    public bool InterruptionVuln => BitField17.HasFlag(BitField17Flags.InterruptionVuln);
    public bool BlindVuln => BitField17.HasFlag(BitField17Flags.BlindVuln);
    public bool StunVuln => BitField17.HasFlag(BitField17Flags.StunVuln);
    public bool SleepVuln => BitField17.HasFlag(BitField17Flags.SleepVuln);
    [FieldOffset(0x18)] public BitField18Flags BitField18;
    public bool BindVuln => BitField18.HasFlag(BitField18Flags.BindVuln);
    public bool HeavyVuln => BitField18.HasFlag(BitField18Flags.HeavyVuln);
    public bool FlatOrDeathVuln => BitField18.HasFlag(BitField18Flags.FlatOrDeathVuln);

    [Flags]
    public enum BitField17Flags : byte {
    	HideStats = 1 << 0,
    	SlowVuln = 1 << 1,
    	PetrificationVuln = 1 << 2,
    	ParalysisVuln = 1 << 3,
    	InterruptionVuln = 1 << 4,
    	BlindVuln = 1 << 5,
    	StunVuln = 1 << 6,
    	SleepVuln = 1 << 7,
    }
    [Flags]
    public enum BitField18Flags : byte {
    	BindVuln = 1 << 0,
    	HeavyVuln = 1 << 1,
    	FlatOrDeathVuln = 1 << 2,
    }
}
