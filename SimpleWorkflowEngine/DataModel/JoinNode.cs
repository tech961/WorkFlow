// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.JoinNode
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.Collections.Generic;

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class JoinNode
  {
    public JoinNode()
    {
      this.PreviousProcessNodes = (ICollection<JoinPreviousProcessNode>) new HashSet<JoinPreviousProcessNode>();
    }

    public int ID { get; set; }

    internal virtual ProcessNode ProcessNode { get; set; }

    internal virtual ICollection<JoinPreviousProcessNode> PreviousProcessNodes { get; set; }
  }
}
