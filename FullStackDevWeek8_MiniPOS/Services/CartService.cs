using FullStackDevWeek8_MiniPOS.Models;

namespace FullStackDevWeek8_MiniPOS.Services;

public class CartService
{
    public List<Product> Products { get; set; } = new();
    public event Action? OnChange;
    public void Add(Product product) { Products.Add(product); NotifyStateChanged(); }
    public void Remove(Product product) { Products.Remove(product); NotifyStateChanged(); }
    public void Clear() { Products.Clear(); NotifyStateChanged(); }
    public decimal GetTotal() { return Products.Sum(x => x.Price); }
    private void NotifyStateChanged() { OnChange?.Invoke(); }
}
