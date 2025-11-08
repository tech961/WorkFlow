// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using Microsoft.Practices.Unity;
using SimpleWorkflowEngine.RuntimeModel;
using SimpleWorkflowEngine.Service;
using System;
using System.Globalization;
using System.Reflection;

#nullable disable
namespace \u000E
{
  internal static class \u0001
  {
    internal static \u0001 \u0001<\u0001>(\u0001 _param0)
    {
      return \u000E.\u0001.\u0001<\u0001>(_param0, UnityContainerExtensions.Resolve<IExecutionContext>(DependencyResolver.Container, new ResolverOverride[0]).Initialize(1, 1, 1, (IWorkflowVoucher) new \u000F.\u0001(1)));
    }

    internal static \u0001 \u0001<\u0001>(\u0001 _param0, IExecutionContext _param1)
    {
      Type type = _param0.GetType();
      PropertyInfo property1 = type.GetProperty(\u0003.\u0001(107395813));
      if ((object) property1 != null)
        goto label_5;
label_1:
      PropertyInfo property2 = type.GetProperty(\u0003.\u0001(107395832));
      if ((object) property2 != null)
        goto label_6;
label_2:
      type.GetProperty(\u0003.\u0001(107395783))?.SetValue((object) _param0, (object) DateTime.Now.ToString(\u0003.\u0001(107396133), (IFormatProvider) CultureInfo.GetCultureInfo(\u0003.\u0001(107396104))));
      return _param0;
label_6:
      property2.SetValue((object) _param0, (object) _param1.CompanyId);
      goto label_2;
label_5:
      property1.SetValue((object) _param0, (object) _param1.UserId);
      goto label_1;
    }
  }
}
