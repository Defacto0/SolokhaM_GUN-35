namespace Zenject
{
    public interface IInstaller1
    {
        bool IsEnabled { get; }

        void InstallBindings();
    }
}