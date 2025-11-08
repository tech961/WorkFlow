// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Service.DependencyResolver
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using Microsoft.Practices.Unity;
using SimpleWorkflowEngine.RuntimeModel;

#nullable disable
namespace SimpleWorkflowEngine.Service
{
  public static class DependencyResolver
  {
    public static IUnityContainer Container { get; }

    static DependencyResolver()
    {
      \u0007.\u0001 obj;
      while (true)
      {
        DependencyResolver.Container = (IUnityContainer) new UnityContainer();
        if (true)
        {
          obj = new \u0007.\u0001();
          goto label_5;
        }
      }
label_2:
      if (true)
        return;
label_5:
      UnityContainerExtensions.RegisterInstance<IWorkflowService>(DependencyResolver.Container, (IWorkflowService) obj);
      UnityContainerExtensions.RegisterInstance<\u0008.\u0001>(DependencyResolver.Container, (\u0008.\u0001) obj);
      UnityContainerExtensions.RegisterType<IExecutionContext, \u0001.\u0002>(DependencyResolver.Container, new InjectionMember[0]);
      goto label_2;
    }
  }
}
