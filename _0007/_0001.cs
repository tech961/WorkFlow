// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using Microsoft.Practices.Unity;
using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.Engine;
using SimpleWorkflowEngine.Models;
using SimpleWorkflowEngine.RuntimeModel;
using SimpleWorkflowEngine.Service;
using System;
using System.Collections.Generic;

#nullable disable
namespace \u0007
{
  internal class \u0001 : \u0008.\u0001, IWorkflowService, IWorkflowLogger
  {
    private readonly ExecutionEngine \u0001;
    private readonly IList<IProcessNodeExecutionHandler> \u0001;
    private readonly IList<IWorkflowMetadataLoader> \u0001;
    private IExpressionEvaluator \u0001;
    private IWorkflowVoucherLoader \u0001;
    private string \u0001;

    public \u0001()
    {
      this.\u0001 = new ExecutionEngine();
      this.\u0001 = (IList<IWorkflowMetadataLoader>) new List<IWorkflowMetadataLoader>();
      this.\u0001 = (IList<IProcessNodeExecutionHandler>) new List<IProcessNodeExecutionHandler>();
    }

    public void \u0001(IList<IProcessNodeModel> _param1)
    {
      do
      {
        IEnumerator<IWorkflowMetadataLoader> enumerator = this.\u0001.GetEnumerator();
        try
        {
          while (true)
          {
            if (!enumerator.MoveNext())
              goto label_3;
label_2:
            if (true)
            {
              enumerator.Current.LoadMetadata((IEnumerable<IProcessNodeModel>) _param1);
              continue;
            }
label_3:
            if (false)
              goto label_2;
            else
              break;
          }
        }
        finally
        {
          if (enumerator == null)
            goto label_9;
label_8:
          enumerator.Dispose();
label_9:
          if (false)
            goto label_8;
        }
      }
      while (false);
    }

    public WorkflowSystemContext \u0001()
    {
      return new WorkflowSystemContext(\u0003.\u0007(\u000E.\u0003.\u0001(107396746), this.\u0001, \u000E.\u0003.\u0001(107397016)));
    }

    public void \u0001(TimerNodeModel.TimerInfo _param1) => \u000F.\u0005.\u0001(this.\u0001, _param1);

    public void \u0001(IExecutionContext _param1, IProcessNodeModel _param2)
    {
      IEnumerator<IProcessNodeExecutionHandler> enumerator = this.\u0001.GetEnumerator();
      try
      {
        if (false)
          goto label_4;
label_2:
        if (!\u0004.\u007E\u0008((object) enumerator))
          return;
label_4:
        enumerator.Current.Register(_param1, _param2);
        goto label_2;
      }
      finally
      {
        if (enumerator != null)
          \u0005.\u007E\u000E((object) enumerator);
      }
    }

    public void \u0002(IExecutionContext _param1, IProcessNodeModel _param2)
    {
      IEnumerator<IProcessNodeExecutionHandler> enumerator = this.\u0001.GetEnumerator();
      try
      {
        if (false)
          goto label_4;
label_2:
        if (!\u0004.\u007E\u0008((object) enumerator))
          return;
label_4:
        enumerator.Current.Execute(_param1, _param2);
        goto label_2;
      }
      finally
      {
        if (enumerator != null)
          \u0005.\u007E\u000E((object) enumerator);
      }
    }

    public void InitializeService(string _param1)
    {
      this.\u0001 = _param1;
      if (\u0006.\u007E\u0014((object) global::\u0001.\u007E\u0002((object) this.\u0001), global::\u0001.\u0002((object) \u000E.\u0003.\u0001(107397011))))
        return;
      this.\u0001 += \u0006.\u007E\u0015((object) this.\u0001, \u000E.\u0003.\u0001(107396938)) ? \u000E.\u0003.\u0001(107396920) : \u000E.\u0003.\u0001(107396933);
    }

    public void RegisterLoader(IWorkflowMetadataLoader _param1) => this.\u0001.Add(_param1);

    public void RegisterProcessNodeExecutionHandler(IProcessNodeExecutionHandler _param1)
    {
      this.\u0001.Add(_param1);
    }

    public void RegisterExpressionEvaluator(IExpressionEvaluator _param1) => this.\u0001 = _param1;

    public void RegisterWorkflowVoucherLoader(IWorkflowVoucherLoader _param1)
    {
      this.\u0001 = _param1;
    }

    public IExpressionEvaluator \u0001() => this.\u0001;

    public bool \u0001(IExecutionContext _param1, string _param2)
    {
      return this.\u0001().EvaluateCondition(_param1, _param2);
    }

    public IWorkflowVoucherLoader \u0001() => this.\u0001;

    public IWorkflowLogger \u0001()
    {
      IWorkflowLogger workflowLogger;
      try
      {
        workflowLogger = UnityContainerExtensions.Resolve<IWorkflowLogger>(DependencyResolver.Container, new ResolverOverride[0]) ?? (IWorkflowLogger) this;
      }
      catch
      {
        workflowLogger = (IWorkflowLogger) this;
      }
      return workflowLogger;
    }

    public void InitializeEngine() => \u000F.\u0005.\u0001(this.\u0001);

    public void StartProcessInstance(int _param1, IExecutionContext _param2)
    {
      \u000F.\u0005.\u0001(_param1, this.\u0001, _param2);
    }

    public void ExecuteUserTask(IExecutionContext _param1) => \u000F.\u0005.\u0001(this.\u0001, _param1);

    public IEnumerable<IUserTaskNodeModel> GetNextUserTasks(IExecutionContext _param1)
    {
      return \u000F.\u0005.\u0001(_param1, this.\u0001);
    }

    public void LogError(Exception _param1)
    {
      global::\u000E obj = global::\u000E.\u0018;
      string str = \u000E.\u0003.\u0001(107396335);
      object[] objArray = new object[3]
      {
        (object) global::\u0001.\u007E\u0003((object) _param1),
        (object) global::\u0008.\u0017(),
        (object) global::\u0001.\u007E\u0004((object) _param1)
      };
      if (false)
        return;
      obj(str, objArray);
    }
  }
}
