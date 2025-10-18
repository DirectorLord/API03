namespace E_Commerce.Service.Specifications;

internal class ProductWithBrandTypeSpecification : BaseSpecification<Product>
{
    public ProductWithBrandTypeSpecification()
        : base(null!)
    {
        AddInclude(p => p.ProductsType);
        AddInclude(p => p.ProductBrand);
    }
    public ProductWithBrandTypeSpecification(int id)
        : base(p => p.Id == id)
    {
        AddInclude(p => p.ProductsType);
        AddInclude(p => p.ProductBrand);
    }
}
