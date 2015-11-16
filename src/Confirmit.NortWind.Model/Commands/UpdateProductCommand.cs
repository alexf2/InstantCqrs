using System.Runtime.Serialization;

namespace Confirmit.NortWind.Model.Commands
{
    [DataContract(Namespace = "http://www.confirmit.ru/NorthWind")]
    public class UpdateProductCommand : AddProductCommand
    {
        public UpdateProductCommand(int id, string name, bool discounted): base(name, discounted)
        {
            ProductID = id;
        }
    }
}
