// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.Process
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.Collections.Generic;

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class Process
  {
    public Process()
    {
      this.ProcessNodes = (ICollection<ProcessNode>) new HashSet<ProcessNode>();
      this.ProcessInstances = (ICollection<ProcessInstance>) new HashSet<ProcessInstance>();
    }

    public int ID { get; set; }

    public string Name { get; set; }

    public int VoucherKindID { get; set; }

    public int Version { get; set; }

    public bool Active { get; set; }

    public int RegUserID { get; set; }

    public string RegDate { get; set; }

    public int? ModifyUserID { get; set; }

    public string ModifyDate { get; set; }

    public int RegCompanyID { get; set; }

    internal virtual ICollection<ProcessNode> ProcessNodes { get; set; }

    internal virtual ICollection<ProcessInstance> ProcessInstances { get; set; }
  }
}
