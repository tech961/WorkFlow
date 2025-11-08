// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Models.ProcessModel
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.Collections.Generic;

#nullable disable
namespace SimpleWorkflowEngine.Models
{
  internal class ProcessModel : \u0005.\u0001
  {
    public string Name { get; set; }

    public int VoucherKind { get; set; }

    public int Version { get; set; }

    public bool Active { get; set; }

    public \u0005.\u0002 StartEventNode { get; set; }

    public List<ProcessNodeModel> ProcessNodeModels { get; set; }
  }
}
