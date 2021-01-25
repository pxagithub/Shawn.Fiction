using System.Threading.Tasks;

namespace Shawn.Fiction.Data
{
    public interface IFictionDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
