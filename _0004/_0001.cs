// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.Models;
using SimpleWorkflowEngine.RuntimeModel;

#nullable disable
namespace \u0004
{
  internal class \u0001 : 
    ProcessNodeModel,
    IProcessNodeModel,
    IWorkflowMetadataSupport,
    IServiceTaskNodeModel
  {
    public int TypeId { get; set; }

    public string Metadata { get; set; }
  }
}
