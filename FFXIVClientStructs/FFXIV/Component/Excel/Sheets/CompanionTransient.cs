// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x1C)]
public unsafe partial struct CompanionTransient {
    [FieldOffset(0x00)] public int Description_Offset;
    [FieldOffset(0x04)] public int DescriptionEnhanced_Offset;
    [FieldOffset(0x08)] public int Tooltip_Offset;
    [FieldOffset(0x0C)] public int SpecialActionName_Offset;
    [FieldOffset(0x10)] public int SpecialActionDescription_Offset;
    [FieldOffset(0x14)] public byte Attack;
    [FieldOffset(0x15)] public byte Defense;
    [FieldOffset(0x16)] public byte Speed;
    /// <remarks>MinionSkillType</remarks>
    [FieldOffset(0x17)] public byte MinionSkillType;
    [FieldOffset(0x18)] public BitField18Flags BitField18;
    public bool HasAreaAttack => BitField18.HasFlag(BitField18Flags.HasAreaAttack);
    public bool StrengthGate => BitField18.HasFlag(BitField18Flags.StrengthGate);
    public bool StrengthEye => BitField18.HasFlag(BitField18Flags.StrengthEye);
    public bool StrengthShield => BitField18.HasFlag(BitField18Flags.StrengthShield);
    public bool StrengthArcana => BitField18.HasFlag(BitField18Flags.StrengthArcana);

    [Flags]
    public enum BitField18Flags : byte {
    	HasAreaAttack = 1 << 0,
    	StrengthGate = 1 << 1,
    	StrengthEye = 1 << 2,
    	StrengthShield = 1 << 3,
    	StrengthArcana = 1 << 4,
    }
}
