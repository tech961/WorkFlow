// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.RuntimeModel;

#nullable disable
namespace \u000F
{
  internal class \u0001 : IWorkflowVoucher
  {
    public int ID { get; set; }

    public string Number { get; set; }

    public string Date { get; set; }

    public \u0001(int _param1 = 0, string _param2 = null, string _param3 = null)
    {
      this.ID = _param1;
      this.Number = _param2;
      this.Date = _param3;
    }
  }
}
