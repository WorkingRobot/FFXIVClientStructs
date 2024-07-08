// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x10C)]
public unsafe partial struct QuestRedo {
    [FieldOffset(0x00), FixedSizeArray] internal FixedSizeArray32<QuestRedoParamStruct> _questRedoParam;
    /// <remarks>Quest</remarks>
    [FieldOffset(0x100)] public uint FinalQuest;
    [FieldOffset(0x104)] public uint Unknown0;
    /// <remarks>QuestRedoChapter</remarks>
    [FieldOffset(0x108)] public ushort Chapter;
    [FieldOffset(0x10A)] public byte Unknown1;

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public partial struct QuestRedoParamStruct {
        /// <remarks>Quest</remarks>
        [FieldOffset(0x00)] public uint Quest;
        [FieldOffset(0x04)] public byte UnknownParam;
    }
}
