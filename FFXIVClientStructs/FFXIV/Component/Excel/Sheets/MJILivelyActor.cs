// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe partial struct MJILivelyActor {
    [FieldOffset(0x00)] public float X;
    [FieldOffset(0x04)] public float Y;
    [FieldOffset(0x08)] public float Z;
    [FieldOffset(0x0C)] public float Rot;
    /// <remarks>ENpcResident</remarks>
    [FieldOffset(0x10)] public uint ENPC;
    /// <remarks>Behavior</remarks>
    [FieldOffset(0x14)] public ushort Behavior;
}
