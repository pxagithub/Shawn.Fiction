using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Shawn.Fiction
{
    [Dependency(ReplaceServices = true)]
    public class FictionBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Fiction";
    }
}
