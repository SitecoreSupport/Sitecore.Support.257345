using Sitecore.Abstractions;
using Sitecore.ContentSearch;
using Sitecore.DependencyInjection;
using Sitecore.Pipelines;

namespace Sitecore.Support.Pipelines.Loader
{
  public class RegisterServices
  {
    public void Process(PipelineArgs args)
    {
      ContentSearchManager.Locator.Register(c => ServiceLocator.ServiceProvider.GetService(typeof(BaseCorePipelineManager)) as BaseCorePipelineManager);
    }
  }
}