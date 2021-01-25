using System;
using System.Collections.Generic;
using System.Text;
using Shawn.Fiction.Localization;
using Volo.Abp.Application.Services;

namespace Shawn.Fiction
{
    /* Inherit your application services from this class.
     */
    public abstract class FictionAppService : ApplicationService
    {
        protected FictionAppService()
        {
            LocalizationResource = typeof(FictionResource);
        }
    }
}
