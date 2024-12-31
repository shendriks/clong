using Clong.Core.Domain.Enum;

namespace Clong.Core.Domain.Dto;

public struct Texture
{
    public required TextureId Id { get; init; }
    public required int Width { get; init; }
    public required int Height { get; init; }
}