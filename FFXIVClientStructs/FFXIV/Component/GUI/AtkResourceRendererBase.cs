namespace FFXIVClientStructs.FFXIV.Component.GUI;

[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe partial struct AtkResourceRendererBase {
    [FieldOffset(0x00)] public void* vtbl;
    // [FieldOffset(0x08)] public nint Unk;

    // 0 for true, -1 for false
    [VirtualFunction(1)]
    public partial int ShouldRender(AtkResNode* node);

    [VirtualFunction(2)]
    public partial void Draw(AtkResNode* node);
}
