// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.Models;
using SimpleWorkflowEngine.RuntimeModel;
using SimpleWorkflowEngine.Service;
using System.Collections.Generic;

#nullable disable
namespace \u0008
{
  internal interface \u0001
  {
    void \u0001(IList<IProcessNodeModel> _param1);

    void \u0001(IExecutionContext _param1, IProcessNodeModel _param2);

    void \u0002(IExecutionContext _param1, IProcessNodeModel _param2);

    IExpressionEvaluator \u0001();

    bool \u0001(IExecutionContext _param1, string _param2);

    WorkflowSystemContext \u0001();

    void \u0001(TimerNodeModel.TimerInfo _param1);

    IWorkflowVoucherLoader \u0001();

    IWorkflowLogger \u0001();
  }
}
