// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x28)]
public unsafe partial struct Perform {
    /// <remarks>ActionTimeline</remarks>
    [FieldOffset(0x00)] public ushort AnimationPlay01;
    /// <remarks>ActionTimeline</remarks>
    [FieldOffset(0x02)] public ushort AnimationPlay02;
    [FieldOffset(0x04)] public int Instrument_Offset;
    [FieldOffset(0x08)] public ulong ModelKey;
    [FieldOffset(0x10)] public int Name_Offset;
    /// <remarks>ActionTimeline</remarks>
    [FieldOffset(0x14)] public int StopAnimation;
    [FieldOffset(0x18)] public int Order;
    /// <remarks>ActionTimeline</remarks>
    [FieldOffset(0x1C)] public ushort AnimationStart;
    /// <remarks>ActionTimeline</remarks>
    [FieldOffset(0x1E)] public ushort AnimationEnd;
    /// <remarks>ActionTimeline</remarks>
    [FieldOffset(0x20)] public ushort AnimationIdle;
    /// <remarks>PerformTransient</remarks>
    [FieldOffset(0x22)] public byte Transient;
    [FieldOffset(0x23)] public byte Unknown0;
    [FieldOffset(0x24)] public bool Unknown1;
}
