// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.UserTaskNode
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class UserTaskNode
  {
    public int ID { get; set; }

    public int RegistrationTypeID { get; set; }

    public bool IsStartTask { get; set; }

    internal virtual ProcessNode ProcessNode { get; set; }
  }
}
