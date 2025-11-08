// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Models.JoinNodeModel
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using Microsoft.Practices.Unity;
using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.RuntimeModel;
using SimpleWorkflowEngine.Service;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace SimpleWorkflowEngine.Models
{
  internal class JoinNodeModel : 
    ProcessNodeModel,
    IProcessNodeModel,
    IWorkflowMetadataSupport,
    IJoinNodeModel
  {
    private bool \u0001;
    private \u0003.\u0002[] \u0001;

    public override void \u0001(ProcessNode _param1_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      JoinNodeModel.\u0001 obj1 = new JoinNodeModel.\u0001();
      // ISSUE: variable of a compiler-generated type
      JoinNodeModel.\u0001 obj2;
      if (true)
        obj2 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = this;
      if (this.\u0001)
        return;
      base.\u0001(_param1_1);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj2.\u0001 = _param1_1.Process.ProcessNodes.Where<ProcessNode>(new Func<ProcessNode, bool>(obj2.\u0001)).Select<ProcessNode, int>((Func<ProcessNode, int>) (_param1_2 => _param1_2.ID));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      obj2.\u0002 = _param1_1.Process.ProcessNodes.Where<ProcessNode>((Func<ProcessNode, bool>) (_param1_3 => _param1_3.NodeKindID == 4)).Where<ProcessNode>(new Func<ProcessNode, bool>(obj2.\u0002)).Select<ProcessNode, int>((Func<ProcessNode, int>) (_param1_4 => _param1_4.ID));
      // ISSUE: reference to a compiler-generated method
      IEnumerator<ProcessNodeModel> enumerator = this.Process.ProcessNodeModels.Where<ProcessNodeModel>(new Func<ProcessNodeModel, bool>(obj2.\u0001)).GetEnumerator();
      try
      {
        while (global::\u0004.\u007E\u0008((object) enumerator))
        {
          ProcessNodeModel current = enumerator.Current;
          if (!this.PreviousProcessNodes.Contains(current))
            this.PreviousProcessNodes.Add(current);
        }
      }
      finally
      {
        if (enumerator != null)
          global::\u0005.\u007E\u000E((object) enumerator);
      }
      // ISSUE: reference to a compiler-generated method
      this.\u0001 = _param1_1.JoinNode.PreviousProcessNodes.Where<JoinPreviousProcessNode>((Func<JoinPreviousProcessNode, bool>) (_param1_5 => _param1_5.IsOptional)).Select<JoinPreviousProcessNode, \u0003.\u0002>(new Func<JoinPreviousProcessNode, \u0003.\u0002>(obj2.\u0001)).ToArray<\u0003.\u0002>();
      this.\u0001 = true;
    }

    public override ProcessExecutionStep \u0001(
      ProcessInstance _param1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4)
    {
      return \u000F.\u0005.\u0001(_param1, _param4, _param3, (ProcessNodeModel) this) ?? base.\u0001(_param1, _param2, _param3, _param4);
    }

    public override ProcessExecutionStep \u0001(
      ProcessInstance _param1_1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4,
      ref bool _param5,
      params ProcessExecutionStep[] _param6)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      JoinNodeModel.\u0003 obj1 = new JoinNodeModel.\u0003();
      if (_param4.Done)
      {
        _param5 = true;
        return _param4;
      }
      ProcessExecutionStep[] source = \u000F.\u0005.\u0001(this, _param3, _param4);
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = ((IEnumerable<ProcessExecutionStep>) source).Where<ProcessExecutionStep>((Func<ProcessExecutionStep, bool>) (_param1_2 => _param1_2.Done)).Select<ProcessExecutionStep, int>((Func<ProcessExecutionStep, int>) (_param1_3 => _param1_3.ProcessNodeID)).ToArray<int>();
      // ISSUE: reference to a compiler-generated method
      List<ProcessNodeModel> list = this.PreviousProcessNodes.Where<ProcessNodeModel>(new Func<ProcessNodeModel, bool>(obj1.\u0001)).ToList<ProcessNodeModel>();
      if (this.\u0001.Length != 0)
      {
        \u0008.\u0001 obj2 = UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]);
        for (int index = 0; index < list.Count; index = index - 1 + 1)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          \u0003.\u0002 obj3 = ((IEnumerable<\u0003.\u0002>) this.\u0001).SingleOrDefault<\u0003.\u0002>(new Func<\u0003.\u0002, bool>(new JoinNodeModel.\u0004()
          {
            \u0001 = list[index]
          }.\u0001));
          if (obj3 != null && (\u0012.\u001C(obj3.OptionalCondition) || obj2.\u0001(_param2, obj3.OptionalCondition)))
            list.RemoveAt(index);
          else
            break;
        }
      }
      if (list.Count == 0)
        return base.\u0001(_param1_1, _param2, _param3, _param4, ref _param5, source);
      _param5 = true;
      return _param4;
    }
  }
}
