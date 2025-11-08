// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.RuntimeModel.IExecutionContext
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace SimpleWorkflowEngine.RuntimeModel
{
  public interface IExecutionContext
  {
    int CompanyId { get; }

    int UserId { get; }

    int FiscalYearId { get; }

    IWorkflowVoucher Voucher { get; }

    IEnumerable<IWorkflowMetadata> WorkflowDataList { get; set; }

    int WorkflowData { get; set; }

    Guid StepId { get; set; }

    IExecutionContext Initialize(
      int userId,
      int companyId,
      int fiscalYearId,
      IWorkflowVoucher workflowVoucher);
  }
}
