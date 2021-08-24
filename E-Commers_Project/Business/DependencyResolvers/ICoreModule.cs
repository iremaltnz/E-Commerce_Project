
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers
{
  public  interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);//Genel bağımlılıklarını yükleyecek
    }
}
