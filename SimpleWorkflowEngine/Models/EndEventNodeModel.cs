// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Models.EndEventNodeModel
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.RuntimeModel;

#nullable disable
namespace SimpleWorkflowEngine.Models
{
  internal class EndEventNodeModel : 
    ProcessNodeModel,
    IProcessNodeModel,
    IWorkflowMetadataSupport,
    IEndEventNodeModel
  {
    public override ProcessExecutionStep \u0001(
      ProcessInstance _param1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4,
      ref bool _param5,
      params ProcessExecutionStep[] _param6)
    {
label_0:
      int num = _param5 ? 1 : 0;
      IExecutionContext executionContext = _param2;
      ProcessExecutionStep processExecutionStep = _param4;
      ProcessExecutionStep[] processExecutionStepArray = _param6;
      if (true)
        this.\u0001(executionContext, processExecutionStep, processExecutionStepArray);
      _param5 = true;
      _param1.Closed = !\u000F.\u0005.\u0001(_param1, this, _param3);
      if (true)
      {
        \u000F.\u0005.\u0001(_param2, _param4, (ProcessNodeModel) this);
        return _param4;
      }
      goto label_0;
    }
  }
}
