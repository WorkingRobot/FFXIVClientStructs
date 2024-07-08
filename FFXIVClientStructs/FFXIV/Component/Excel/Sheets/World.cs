// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x0C)]
public unsafe partial struct World {
    [FieldOffset(0x00)] public int InternalName_Offset;
    [FieldOffset(0x04)] public int Name_Offset;
    [FieldOffset(0x08)] public byte Region;
    [FieldOffset(0x09)] public byte UserType;
    /// <remarks>WorldDCGroupType</remarks>
    [FieldOffset(0x0A)] public byte DataCenter;
    [FieldOffset(0x0B)] public bool IsPublic;
}
