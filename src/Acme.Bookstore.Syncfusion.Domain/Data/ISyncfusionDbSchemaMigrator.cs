using System.Threading.Tasks;

namespace Acme.Bookstore.Syncfusion.Data
{
    public interface ISyncfusionDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
