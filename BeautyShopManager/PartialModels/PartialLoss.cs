namespace BeautyShopManager.Models;

public partial class Loss
{
    public decimal TotalLoss => Inventoryloss + Shortage + Disposal;
}