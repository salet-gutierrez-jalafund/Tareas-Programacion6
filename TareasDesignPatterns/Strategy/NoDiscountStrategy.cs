// Estrategia concreta: sin descuento
class NoDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal price)
    {
        return price;
    }
}