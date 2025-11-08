// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.JoinPreviousProcessNode
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class JoinPreviousProcessNode
  {
    public int ID { get; set; }

    public int JoinNodeID { get; set; }

    public int PreviousProcessNodeID { get; set; }

    public string Title { get; set; }

    public bool IsOptional { get; set; }

    public string OptionalCondition { get; set; }

    internal virtual JoinNode JoinNode { get; set; }

    internal virtual ProcessNode PreviousProcessNode { get; set; }
  }
}
