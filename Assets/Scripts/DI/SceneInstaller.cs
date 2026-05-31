using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private Output output;

    public override void InstallBindings()
    {
        Container.Bind<IMassage>()
            .FromInstance(output)
            .AsSingle();
    }
}