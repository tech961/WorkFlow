// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using Microsoft.Practices.Unity;
using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.Models;
using SimpleWorkflowEngine.RuntimeModel;
using SimpleWorkflowEngine.Service;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace \u0001
{
  internal class \u0003 : 
    ProcessNodeModel,
    IProcessNodeModel,
    IWorkflowMetadataSupport,
    IForkNodeModel
  {
    private bool \u0001;

    public ICollection<\u000F.\u0002> NextProcessNodes { get; set; }

    public override void \u0001(ProcessNode _param1)
    {
      if (this.\u0001)
        return;
      try
      {
        if (true)
          goto label_17;
label_16:
        this.\u0001 = true;
        return;
label_17:
        this.NextProcessNodes = (ICollection<\u000F.\u0002>) new List<\u000F.\u0002>();
        IEnumerator<ForkNextProcessNode> enumerator = _param1.ForkNode.NextProcessNodes.GetEnumerator();
        try
        {
label_10:
          while (global::\u0004.\u007E\u0008((object) enumerator))
          {
            // ISSUE: variable of a compiler-generated type
            \u0003.\u0001 obj1;
            if (true)
            {
              // ISSUE: object of a compiler-generated type is created
              obj1 = new \u0003.\u0001();
            }
            \u000F.\u0002 obj2;
            do
            {
              // ISSUE: reference to a compiler-generated field
              obj1.\u0001 = enumerator.Current;
              \u000F.\u0002 obj3 = new \u000F.\u0002();
              // ISSUE: reference to a compiler-generated field
              obj3.ID = obj1.\u0001.ID;
              // ISSUE: reference to a compiler-generated field
              obj3.Condition = obj1.\u0001.Condition;
              // ISSUE: reference to a compiler-generated method
              obj3.NextProcessNode = base.Process.ProcessNodeModels.Single<ProcessNodeModel>(new Func<ProcessNodeModel, bool>(obj1.\u0001));
              obj2 = obj3;
              this.NextProcessNodes.Add(obj2);
              if (!obj2.NextProcessNode.PreviousProcessNodes.Contains((ProcessNodeModel) this))
              {
                if (true)
                  obj2.NextProcessNode.PreviousProcessNodes.Add((ProcessNodeModel) this);
                else
                  goto label_10;
              }
            }
            while (false);
            // ISSUE: reference to a compiler-generated method
            obj2.NextProcessNode.\u0001(_param1.Process.ProcessNodes.Single<ProcessNode>(new Func<ProcessNode, bool>(obj1.\u0001)));
          }
          goto label_16;
        }
        finally
        {
          if (enumerator == null)
            goto label_14;
label_13:
          \u0005.\u007E\u000E((object) enumerator);
label_14:
          if (false)
            goto label_13;
        }
      }
      catch (Exception ex)
      {
        throw new Exception(\u000E.\u0003.\u0001(107396198), ex);
      }
    }

    public override ProcessExecutionStep \u0001(
      ProcessInstance _param1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4,
      ref bool _param5,
      params ProcessExecutionStep[] _param6)
    {
      IExecutionContext executionContext = _param2;
      ProcessExecutionStep processExecutionStep1 = _param4;
      ProcessExecutionStep[] processExecutionStepArray = _param6;
      if (true)
        this.\u0001(executionContext, processExecutionStep1, processExecutionStepArray);
      \u000F.\u0005.\u0001(_param2, _param4, (ProcessNodeModel) this);
      ProcessExecutionStep processExecutionStep2 = (ProcessExecutionStep) null;
      \u0008.\u0001 obj = UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]);
      IEnumerator<\u000F.\u0002> enumerator = this.NextProcessNodes.GetEnumerator();
      try
      {
        while (global::\u0004.\u007E\u0008((object) enumerator))
        {
          \u000F.\u0002 current = enumerator.Current;
          if (obj.\u0001(_param2, current.Condition))
          {
            processExecutionStep2 = current.NextProcessNode.\u0001(_param1, _param2, _param3, _param4);
            processExecutionStep2 = current.NextProcessNode.\u0001(_param1, _param2, _param3, processExecutionStep2, ref _param5, _param4);
          }
        }
      }
      finally
      {
        if (enumerator != null)
          \u0005.\u007E\u000E((object) enumerator);
      }
      return processExecutionStep2;
    }
  }
}
