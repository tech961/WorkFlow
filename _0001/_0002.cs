// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.RuntimeModel;
using System;
using System.Collections.Generic;

#nullable disable
namespace \u0001
{
  internal class \u0002 : IExecutionContext, IInternalExecutionContext
  {
    public int UserId { get; private set; }

    public int CompanyId { get; private set; }

    public int FiscalYearId { get; private set; }

    public IWorkflowVoucher Voucher { get; private set; }

    public IEnumerable<IWorkflowMetadata> WorkflowDataList { get; set; }

    public int WorkflowData { get; set; }

    public Guid StepId { get; set; }

    public bool SimulationMode { get; set; }

    public IExecutionContext Initialize(
      int _param1,
      int _param2,
      int _param3,
      IWorkflowVoucher _param4)
    {
      while (true)
      {
        this.UserId = _param1;
        if (true)
        {
          this.CompanyId = _param2;
          if (true)
            goto label_6;
label_1:
          if (true)
          {
            this.Voucher = _param4;
            break;
          }
          continue;
label_6:
          this.FiscalYearId = _param3;
          goto label_1;
        }
        else
          break;
      }
      return (IExecutionContext) this;
    }
  }
}
