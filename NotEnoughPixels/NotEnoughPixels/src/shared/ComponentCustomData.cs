namespace NotEnoughPixels.Shared.ComponentCustomData
{
    public interface IPixelDisplayData
    {
        int SizeX { get; set; }
        int SizeZ { get; set; }
        byte[] Memdata { get; set; }
    }
}
