using System.Threading.Tasks;

namespace PhoneNumberLookup.InteractiveOptions.interfaces
{
    public interface IOption
    {
        public string message { get; }
        public Task Action();
    }
}
