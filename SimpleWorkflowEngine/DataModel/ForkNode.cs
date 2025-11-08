// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.ForkNode
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.Collections.Generic;

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class ForkNode
  {
    public ForkNode()
    {
      this.NextProcessNodes = (ICollection<ForkNextProcessNode>) new HashSet<ForkNextProcessNode>();
    }

    public int ID { get; set; }

    internal virtual ProcessNode ProcessNode { get; set; }

    internal virtual ICollection<ForkNextProcessNode> NextProcessNodes { get; set; }
  }
}
