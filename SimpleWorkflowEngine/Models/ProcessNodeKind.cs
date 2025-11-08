// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Models.ProcessNodeKind
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.ComponentModel;

#nullable disable
namespace SimpleWorkflowEngine.Models
{
  public enum ProcessNodeKind
  {
    None,
    [Description("شروع")] StartEventNode,
    [Description("تسک کاربر")] UserTaskNode,
    [Description("تسک سیستم")] ServiceTaskNode,
    [Description("Fork")] ForkNode,
    [Description("Join")] JoinNode,
    [Description("پایان")] EndEventNode,
    [Description("زمانبندی")] Timer,
  }
}
