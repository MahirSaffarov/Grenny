using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(string to, string subject, string html, string from = null);
    }
}
