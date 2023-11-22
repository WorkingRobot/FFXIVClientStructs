using System.Runtime.CompilerServices;
using FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;
using FFXIVClientStructs.FFXIV.Client.System.Resource.Handle;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Scene;

// Client::Graphics::Scene::Demihuman
//   Client::Graphics::Scene::CharacterBase
//     Client::Graphics::Scene::DrawObject
//       Client::Graphics::Scene::Object

// ctor 40 53 48 83 EC ?? 48 8B D9 E8 ?? ?? ?? ?? 48 8D 05 ?? ?? ?? ?? 45 33 C0 48 89 03 BA
[StructLayout(LayoutKind.Explicit, Size = 0x978)]
public unsafe partial struct Demihuman {
    [FieldOffset(0x0)] public CharacterBase CharacterBase;

    [FieldOffset(0x928)] private nint _slotDecalBase;
    [FieldOffset(0x928)] public TextureResourceHandle* HeadDecal;
    [FieldOffset(0x930)] public TextureResourceHandle* TopDecal;
    [FieldOffset(0x938)] public TextureResourceHandle* ArmsDecal;
    [FieldOffset(0x940)] public TextureResourceHandle* LegsDecal;
    [FieldOffset(0x948)] public TextureResourceHandle* FeetDecal;

    public ref TextureResourceHandle* SlotDecal(int slot) {
        if (slot < 0 || slot > 4)
            throw new ArgumentOutOfRangeException(nameof(slot));
        return ref ((TextureResourceHandle**)Unsafe.AsPointer(ref _slotDecalBase))[slot];
    }

    public Span<Pointer<TextureResourceHandle>> SlotDecalsSpan
        => new(Unsafe.AsPointer(ref _slotDecalBase), 5);

    [FieldOffset(0x958)] public Texture* FreeCompanyCrest;
    [FieldOffset(0x960)] public uint SlotFreeCompanyCrestBitfield; // Only relevant bit is & 0x1

    // Expects at least 24 bytes of data.
    [MemberFunction("E8 ?? ?? ?? ?? E9 ?? ?? ?? ?? 41 0F 10 07")]
    public partial bool SetupFromData(byte* data);
}
