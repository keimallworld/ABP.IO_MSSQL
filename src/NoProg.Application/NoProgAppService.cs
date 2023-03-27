using System;
using System.Collections.Generic;
using System.Text;
using NoProg.Localization;
using Volo.Abp.Application.Services;

namespace NoProg;

/* Inherit your application services from this class.
 */
public abstract class NoProgAppService : ApplicationService
{
    protected NoProgAppService()
    {
        LocalizationResource = typeof(NoProgResource);
    }
}
