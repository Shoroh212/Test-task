using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private Output output;

    // DI для  Zenject
    public override void InstallBindings()
    {
        Container.Bind<IMassage>()
            .FromInstance(output)
            .AsSingle();
    }
}

public interface IMassage // интерфейс посредник 
{
    void Conclusion(string text);
}