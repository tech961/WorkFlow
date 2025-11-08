// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Models.TimerNodeModel
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using Microsoft.Practices.Unity;
using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.RuntimeModel;
using SimpleWorkflowEngine.Service;
using System;

#nullable disable
namespace SimpleWorkflowEngine.Models
{
  internal class TimerNodeModel : 
    ProcessNodeModel,
    ITimerNodeModel,
    IProcessNodeModel,
    IWorkflowMetadataSupport
  {
    public string DelayDateTimeExpression { get; set; }

    public override ProcessExecutionStep \u0001(
      ProcessInstance _param1,
      IExecutionContext _param2,
      WorkflowSystemContext _param3,
      ProcessExecutionStep _param4)
    {
      ProcessExecutionStep processExecutionStep;
      if (true)
        processExecutionStep = base.\u0001(_param1, _param2, _param3, _param4);
      if (((IInternalExecutionContext) _param2).SimulationMode)
        return processExecutionStep;
      \u0008.\u0001 obj = UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]);
      TimerNodeModel.TimerInfo timerInfo = new TimerNodeModel.TimerInfo(obj.\u0001().EvaluateDateTime(_param2, this.DelayDateTimeExpression), _param2.CompanyId, _param2.UserId, _param2.FiscalYearId, _param2.Voucher.ID, this.Process.VoucherKind, _param2.WorkflowData, processExecutionStep.ID);
      processExecutionStep.Data = \u000F.\u0005.\u0001(timerInfo);
      obj.\u0001(timerInfo);
      return processExecutionStep;
    }

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
      throw new InvalidOperationException(\u0008.\u0002.This_Timer_Already_has_been_Done);
label_7:
      return base.\u0001(_param1, _param2, _param3, _param4, ref flag, _param4);
    }

    internal class TimerInfo
    {
      private const char \u0001 = ',';
      private const char \u0002 = '=';

      public DateTime DelayDateTime { get; set; }

      public int CompanyId { get; set; }

      public int UserId { get; set; }

      public int FiscalYearId { get; set; }

      public int WorkflowVoucherID { get; set; }

      public int WorkflowVoucherKind { get; set; }

      public int WorkflowData { get; set; }

      public Guid StepId { get; set; }

      public TimerInfo()
      {
      }

      public TimerInfo(
        DateTime delayDateTime,
        int companyId,
        int userId,
        int fiscalYearId,
        int workflowVoucherID,
        int workflowVoucherKind,
        int workflowData,
        Guid stepId)
      {
        this.DelayDateTime = delayDateTime;
        this.CompanyId = companyId;
        this.UserId = userId;
        this.FiscalYearId = fiscalYearId;
        this.WorkflowVoucherID = workflowVoucherID;
        this.WorkflowVoucherKind = workflowVoucherKind;
        this.WorkflowData = workflowData;
        this.StepId = stepId;
      }

      virtual string object.\u0001()
      {
        return \u0089.\u0096(new string[8]
        {
          \u0087.\u0094(\u000E.\u0003.\u0001(107395802), new object[4]
          {
            (object) \u000E.\u0003.\u0001(107395753),
            (object) '=',
            (object) this.DelayDateTime.ToString((IFormatProvider) \u0086.\u0093()),
            (object) ','
          }),
          \u0087.\u0094(\u000E.\u0003.\u0001(107395802), new object[4]
          {
            (object) \u000E.\u0003.\u0001(107395764),
            (object) '=',
            (object) this.CompanyId,
            (object) ','
          }),
          \u0087.\u0094(\u000E.\u0003.\u0001(107395802), new object[4]
          {
            (object) \u000E.\u0003.\u0001(107395719),
            (object) '=',
            (object) this.UserId,
            (object) ','
          }),
          \u0087.\u0094(\u000E.\u0003.\u0001(107395802), new object[4]
          {
            (object) \u000E.\u0003.\u0001(107395742),
            (object) '=',
            (object) this.FiscalYearId,
            (object) ','
          }),
          \u0087.\u0094(\u000E.\u0003.\u0001(107395802), new object[4]
          {
            (object) \u000E.\u0003.\u0001(107395693),
            (object) '=',
            (object) this.WorkflowVoucherID,
            (object) ','
          }),
          \u0087.\u0094(\u000E.\u0003.\u0001(107395802), new object[4]
          {
            (object) \u000E.\u0003.\u0001(107395700),
            (object) '=',
            (object) this.WorkflowVoucherKind,
            (object) ','
          }),
          \u0087.\u0094(\u000E.\u0003.\u0001(107395802), new object[4]
          {
            (object) \u000E.\u0003.\u0001(107395671),
            (object) '=',
            (object) this.WorkflowData,
            (object) ','
          }),
          \u0088.\u0095(\u000E.\u0003.\u0001(107395622), (object) \u000E.\u0003.\u0001(107395641), (object) '=', (object) this.StepId)
        });
      }
    }
  }
}
