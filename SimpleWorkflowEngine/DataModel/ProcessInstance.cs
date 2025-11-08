// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.ProcessInstance
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.Collections.Generic;

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class ProcessInstance
  {
    public ProcessInstance()
    {
      this.ProcessExecutionSteps = (ICollection<ProcessExecutionStep>) new HashSet<ProcessExecutionStep>();
    }

    public int ID { get; set; }

    public int ProcessMetaDataID { get; set; }

    public int VoucherRowID { get; set; }

    public bool Closed { get; set; }

    public int RegUserID { get; set; }

    public string RegDate { get; set; }

    public int? ModifyUserID { get; set; }

    public string ModifyDate { get; set; }

    public int RegCompanyID { get; set; }

    internal virtual Process Process { get; set; }

    internal virtual ICollection<ProcessExecutionStep> ProcessExecutionSteps { get; set; }
  }
}
