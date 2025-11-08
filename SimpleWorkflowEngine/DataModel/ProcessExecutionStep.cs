// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.ProcessExecutionStep
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System;

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class ProcessExecutionStep
  {
    public Guid ID { get; set; }

    public int ProcessID { get; set; }

    public int ProcessNodeID { get; set; }

    public Guid PathID { get; set; }

    public bool Done { get; set; }

    public long RegisterDateTime { get; set; }

    public long? DoneDateTime { get; set; }

    public string PreviousExecutionStepID { get; set; }

    public string Data { get; set; }

    public int RegUserID { get; set; }

    public string RegDate { get; set; }

    public int? ModifyUserID { get; set; }

    public string ModifyDate { get; set; }

    public int RegCompanyID { get; set; }

    internal virtual ProcessInstance ProcessInstance { get; set; }

    internal virtual ProcessNode ProcessNode { get; set; }
  }
}
