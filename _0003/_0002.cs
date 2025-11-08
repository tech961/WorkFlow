// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.Models;

#nullable disable
namespace \u0003
{
  internal class \u0002 : \u0005.\u0001
  {
    public string Title { get; set; }

    public bool IsOptional { get; set; }

    public string OptionalCondition { get; set; }

    public ProcessNodeModel PreviousProcessNode { get; set; }
  }
}
