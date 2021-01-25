using Shawn.Fiction.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Shawn.Fiction.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FictionController : AbpController
    {
        protected FictionController()
        {
            LocalizationResource = typeof(FictionResource);
        }
    }
}