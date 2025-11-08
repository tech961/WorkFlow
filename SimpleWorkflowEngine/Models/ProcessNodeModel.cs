// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Models.ProcessNodeModel
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.RuntimeModel;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace SimpleWorkflowEngine.Models
{
  internal abstract class ProcessNodeModel : \u0005.\u0001, IProcessNodeModel, IWorkflowMetadataSupport
  {
    public string Name { get; set; }

    public ProcessModel Process { get; set; }

    public ProcessNodeKind NodeKind { get; set; }

    public ProcessNodeModel NextProcessNode { get; set; }

    public ICollection<ProcessNodeModel> PreviousProcessNodes { get; set; }

    public IWorkflowMetadata MetadataModel { get; set; }

    public ProcessNodeModel()
    {
      this.PreviousProcessNodes = (ICollection<ProcessNodeModel>) new List<ProcessNodeModel>();
    }

    public virtual void \u0001(ProcessNode _param1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ProcessNodeModel.\u0001 obj = new ProcessNodeModel.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = _param1;
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (!obj.\u0001.NextProcessNodeID.HasValue || this.NextProcessNode != null)
          return;
        // ISSUE: reference to a compiler-generated method
        this.NextProcessNode = this.Process.ProcessNodeModels.Single<ProcessNodeModel>(new Func<ProcessNodeModel, bool>(obj.\u0001));
        if (this.NextProcessNode == null)
          return;
        if (!this.NextProcessNode.PreviousProcessNodes.Contains(this))
          this.NextProcessNode.PreviousProcessNodes.Add(this);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        this.NextProcessNode.\u0001(obj.\u0001.Process.ProcessNodes.Single<ProcessNode>(new Func<ProcessNode, bool>(obj.\u0001)));
      }
      catch (Exception ex)
      {
        throw new Exception(\u000E.\u0003.\u0001(107396198), ex);
      }
    }

    public virtual ProcessExecutionStep \u0001(
      ProcessInstance _param1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4)
    {
      Guid guid1 = \u000F.\u0005.\u0001(_param1, _param4, _param3, this) == null ? (_param4 != null ? _param4.PathID : \u0013.\u001D()) : \u0013.\u001D();
      ProcessExecutionStep processExecutionStep1;
      do
      {
        processExecutionStep1 = _param3.ProcessExecutionSteps.Create();
        processExecutionStep1.RegCompanyID = _param2.CompanyId;
        processExecutionStep1.RegUserID = _param2.UserId;
        processExecutionStep1.RegDate = \u0014.\u001E().ToString(\u000E.\u0003.\u0001(107396133), (IFormatProvider) \u0015.\u001F(\u000E.\u0003.\u0001(107396104)));
        processExecutionStep1.ID = \u0013.\u001D();
      }
      while (false);
      processExecutionStep1.ProcessID = _param1.ID;
      processExecutionStep1.ProcessNodeID = this.ID;
      processExecutionStep1.PathID = guid1;
      processExecutionStep1.RegisterDateTime = \u0014.\u001E().Ticks;
      ProcessExecutionStep processExecutionStep2 = processExecutionStep1;
      Guid guid2 = _param4 != null ? _param4.ID : processExecutionStep1.ID;
      string str = global::\u0001.\u007E\u0005((object) guid2.ToString());
      processExecutionStep2.PreviousExecutionStepID = str;
      _param3.ProcessExecutionSteps.Add(processExecutionStep1);
      \u000F.\u0005.\u0001(processExecutionStep1, _param2, this);
      return processExecutionStep1;
    }

    public virtual ProcessExecutionStep \u0001(
      ProcessInstance _param1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4,
      ref bool _param5,
      params ProcessExecutionStep[] _param6)
    {
      this.\u0001(_param2, _param4, _param6);
      \u000F.\u0005.\u0001(_param2, _param4, this);
      ProcessExecutionStep processExecutionStep = this.NextProcessNode.\u0001(_param1, _param2, _param3, _param4);
      if (!_param5)
        processExecutionStep = this.NextProcessNode.\u0001(_param1, _param2, _param3, processExecutionStep, ref _param5, _param4);
      return processExecutionStep;
    }

    protected void \u0001(
      IExecutionContext _param1,
      ProcessExecutionStep _param2,
      params ProcessExecutionStep[] _param3)
    {
      ProcessExecutionStep processExecutionStep1 = _param2;
      DateTime dateTime = \u0014.\u001E();
      string str1 = dateTime.ToString(\u000E.\u0003.\u0001(107396133), (IFormatProvider) \u0015.\u001F(\u000E.\u0003.\u0001(107396104)));
      if (true)
        processExecutionStep1.ModifyDate = str1;
      _param2.ModifyUserID = new int?(_param1.UserId);
      _param2.Done = true;
      ProcessExecutionStep processExecutionStep2 = _param2;
      dateTime = \u0014.\u001E();
      long? nullable = new long?(dateTime.Ticks);
      processExecutionStep2.DoneDateTime = nullable;
      foreach (ProcessExecutionStep processExecutionStep3 in _param3)
      {
        if (\u0016.\u007F(processExecutionStep3.ID, _param2.ID))
        {
          global::\u0006 obj = global::\u0006.\u007E\u0014;
          string previousExecutionStepId1 = _param2.PreviousExecutionStepID;
          Guid id = processExecutionStep3.ID;
          string str2 = global::\u0001.\u007E\u0005((object) id.ToString());
          if (!obj((object) previousExecutionStepId1, str2))
          {
            ProcessExecutionStep processExecutionStep4 = _param2;
            string previousExecutionStepId2 = processExecutionStep4.PreviousExecutionStepID;
            string str3 = \u000E.\u0003.\u0001(107396127);
            id = processExecutionStep3.ID;
            string str4 = global::\u0001.\u007E\u0005((object) id.ToString());
            processExecutionStep4.PreviousExecutionStepID = previousExecutionStepId2 + str3 + str4;
          }
        }
      }
    }
  }
}
