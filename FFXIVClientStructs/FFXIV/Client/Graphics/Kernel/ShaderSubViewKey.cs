namespace FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

[StructLayout(LayoutKind.Explicit, Size = Size)]
public struct ShaderSubViewKey {
    internal const int Size = 0x10;

    [FieldOffset(0x8)] public uint KeyCRC;
    [FieldOffset(0xC)] public uint ValueCRC;
}
