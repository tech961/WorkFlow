// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.ForkNextProcessNode
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class ForkNextProcessNode
  {
    public int ID { get; set; }

    public int ForkNodeID { get; set; }

    public int NextProcessNodeID { get; set; }

    public string Condition { get; set; }

    public string DesignerLinkPath { get; set; }

    public string Title { get; set; }

    internal virtual ForkNode ForkNode { get; set; }

    internal virtual ProcessNode NextProcessNode { get; set; }
  }
}
