// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.ProcessNode
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.Collections.Generic;

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class ProcessNode
  {
    public ProcessNode()
    {
      this.PreviousProcessNodes = (ICollection<ProcessNode>) new HashSet<ProcessNode>();
      this.ProcessExecutionSteps = (ICollection<ProcessExecutionStep>) new HashSet<ProcessExecutionStep>();
    }

    public int ID { get; set; }

    public string Name { get; set; }

    public int ProcessID { get; set; }

    public int NodeKindID { get; set; }

    public int? NextProcessNodeID { get; set; }

    public string DesignerLocation { get; set; }

    public string DesignerLinkPath { get; set; }

    public int RegUserID { get; set; }

    public string RegDate { get; set; }

    public int? ModifyUserID { get; set; }

    public string ModifyDate { get; set; }

    public int RegCompanyID { get; set; }

    internal virtual Process Process { get; set; }

    internal virtual StartEventNode StartEventNode { get; set; }

    internal virtual EndEventNode EndEventNode { get; set; }

    internal virtual UserTaskNode UserTaskNode { get; set; }

    internal virtual ServiceTaskNode ServiceTaskNode { get; set; }

    internal virtual JoinNode JoinNode { get; set; }

    internal virtual ForkNode ForkNode { get; set; }

    internal virtual TimerNode TimerNode { get; set; }

    internal virtual ProcessNode NextProcessNode { get; set; }

    internal virtual ICollection<ProcessNode> PreviousProcessNodes { get; set; }

    internal virtual ICollection<ProcessExecutionStep> ProcessExecutionSteps { get; set; }
  }
}
