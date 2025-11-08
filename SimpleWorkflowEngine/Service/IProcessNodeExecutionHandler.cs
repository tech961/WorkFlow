// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Service.IProcessNodeExecutionHandler
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.RuntimeModel;

#nullable disable
namespace SimpleWorkflowEngine.Service
{
  public interface IProcessNodeExecutionHandler
  {
    void Register(IExecutionContext executionContext, IProcessNodeModel processNode);

    void Execute(IExecutionContext executionContext, IProcessNodeModel processNode);
  }
}
