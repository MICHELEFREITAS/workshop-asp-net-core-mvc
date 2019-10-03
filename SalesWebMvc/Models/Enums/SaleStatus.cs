namespace SalesWebMvc.Models.Enums
{
    //Status das vendas
    public enum SaleStatus : int
    {
        //pendente, faturado e cancelado
        Pending=0,
        Billed=1,
        Canceled = 2    
    }
}
