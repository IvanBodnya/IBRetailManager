using System.Threading.Tasks;
using IRMDesktopUI.Models;

namespace IRMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}