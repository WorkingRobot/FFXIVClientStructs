// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x1C)]
public unsafe partial struct CSBonusContentIdentifier {
    [FieldOffset(0x00)] public uint Content;
    /// <remarks>Quest</remarks>
    [FieldOffset(0x04)] public uint UnlockQuest0;
    /// <remarks>Quest</remarks>
    [FieldOffset(0x08)] public uint UnlockQuest1;
    /// <remarks>Quest</remarks>
    [FieldOffset(0x0C)] public uint UnlockQuest2;
    [FieldOffset(0x10)] public uint Unknown6;
    [FieldOffset(0x14)] public uint Map;
    [FieldOffset(0x18)] public byte ContentLinkType;
    [FieldOffset(0x19)] public bool Unknown2;
}
