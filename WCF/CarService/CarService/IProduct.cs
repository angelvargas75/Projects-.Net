using System.ServiceModel;

namespace CarService
{
    [ServiceContract]
    interface IProduct
    {
        [OperationContract]
        string GetProductName();

        [OperationContract]
        string GetProductQty();

        [OperationContract]
        string GetCategoryName();
    }
}
