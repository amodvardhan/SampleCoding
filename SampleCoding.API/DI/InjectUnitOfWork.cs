

using SampleCoding.DAL.Repositories;
using Unity;

namespace SampleCoding.API.DI
{
    public static class InjectUnityOfWork
    {
        public static void InjectRepositories(ref UnityContainer container)
        {
            container.RegisterType<IUserRepository, UserRepository>();
        }
    }
}
