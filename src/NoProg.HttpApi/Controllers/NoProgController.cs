using NoProg.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NoProg.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NoProgController : AbpControllerBase
{
    protected NoProgController()
    {
        LocalizationResource = typeof(NoProgResource);
    }
}
