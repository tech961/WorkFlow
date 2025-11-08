// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.RuntimeModel.IProcessNodeModel
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.Models;

#nullable disable
namespace SimpleWorkflowEngine.RuntimeModel
{
  public interface IProcessNodeModel : IWorkflowMetadataSupport
  {
    int ID { get; set; }

    string Name { get; set; }

    ProcessNodeKind NodeKind { get; set; }
  }
}
