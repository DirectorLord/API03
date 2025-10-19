namespace E_Commerce.Shared.DataTransferObjects.Products;

public class ProductQueryParameters
{
    public int? BrandId { get; set; }
    public int? TypeId { get; set; }
    public string? Search { get; set; }
    public ProductSortingOptions Sort { get; set; }

}
public enum ProductSortingOptions
{
    NameAsc = 1,
    NameDesc = 2,
    PriceAsc = 3,
    PriceDesc = 4,
}
 