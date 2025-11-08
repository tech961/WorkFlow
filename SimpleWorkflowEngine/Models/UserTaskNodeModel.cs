// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Models.UserTaskNodeModel
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.RuntimeModel;
using System;

#nullable disable
namespace SimpleWorkflowEngine.Models
{
  internal class UserTaskNodeModel : 
    ProcessNodeModel,
    IProcessNodeModel,
    IWorkflowMetadataSupport,
    IUserTaskNodeModel
  {
    public UserTaskRegistrationType RegistrationType { get; set; }

    public bool IsStartTask { get; set; }

    public override ProcessExecutionStep \u0001(
      ProcessInstance _param1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4,
      ref bool _param5,
      params ProcessExecutionStep[] _param6)
    {
      int num = _param5 ? 1 : 0;
      _param5 = true;
      return _param4;
    }

    public ProcessExecutionStep \u0002(
      ProcessInstance _param1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4)
    {
      bool flag;
      do
      {
        if (!_param4.Done)
          goto label_2;
label_1:
        continue;
label_2:
        do
        {
          if (true)
            flag = false;
          if (false)
            goto label_1;
        }
        while (false);
        goto label_7;
      }
      while (false);
      throw new InvalidOperationException(\u0008.\u0002.This_Task_Already_has_been_Done);
label_7:
      return base.\u0001(_param1, _param2, _param3, _param4, ref flag, _param4);
    }
  }
}
