namespace E_Commerce.Service.Specifications;

internal class ProductWithBrandTypeSpecification : BaseSpecification<Product>
{
    public ProductWithBrandTypeSpecification()
    {
        AddInclude(p => p.ProductsType);
        AddInclude(p => p.ProductBrand);
    }
}
