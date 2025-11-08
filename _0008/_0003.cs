// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.Models;
using System;

#nullable disable
namespace \u0008
{
  internal static class \u0003
  {
    public static ProcessModel \u0001(this Process _param0)
    {
      ProcessModel processModel = new ProcessModel();
      processModel.ID = _param0.ID;
      processModel.Name = _param0.Name;
      processModel.VoucherKind = _param0.VoucherKindID;
      processModel.Version = _param0.Version;
      processModel.Active = _param0.Active;
      return processModel;
    }

    public static ProcessNodeModel \u0001(this ProcessNode _param0, ProcessModel _param1)
    {
      switch (_param0.NodeKindID)
      {
        case 1:
          if (true)
            return (ProcessNodeModel) _param0.\u0001<\u0005.\u0002>(_param1).\u0001(_param0.StartEventNode);
          goto default;
        case 2:
          if (true)
            return (ProcessNodeModel) _param0.\u0001<UserTaskNodeModel>(_param1).\u0001(_param0.UserTaskNode);
          goto case 7;
        case 3:
          if (true)
            return (ProcessNodeModel) _param0.\u0001<\u0004.\u0001>(_param1).\u0001(_param0.ServiceTaskNode);
          goto case 5;
        case 4:
          if (true)
            return (ProcessNodeModel) _param0.\u0001<\u0001.\u0003>(_param1).\u0001(_param0.ForkNode);
          goto case 1;
        case 5:
          return (ProcessNodeModel) _param0.\u0001<JoinNodeModel>(_param1).\u0001(_param0.JoinNode);
        case 6:
          return (ProcessNodeModel) _param0.\u0001<EndEventNodeModel>(_param1).\u0001(_param0.EndEventNode);
        case 7:
          return (ProcessNodeModel) _param0.\u0001<TimerNodeModel>(_param1).\u0001(_param0.TimerNode);
        default:
          if (true)
          {
            if (true)
              throw new ArgumentOutOfRangeException(\u000E.\u0003.\u0001(107396247));
            goto case 2;
          }
          else
            goto case 6;
      }
    }

    private static \u0001 \u0001<\u0001>(this ProcessNode _param0, ProcessModel _param1) where \u0001 : ProcessNodeModel, new()
    {
      \u0001 obj = new \u0001();
      obj.ID = _param0.ID;
      obj.Name = _param0.Name;
      obj.Process = _param1;
      obj.NodeKind = (ProcessNodeKind) _param0.NodeKindID;
      return obj;
    }

    private static \u0005.\u0002 \u0001(this \u0005.\u0002 _param0, StartEventNode _param1)
    {
      return _param0;
    }

    private static UserTaskNodeModel \u0001(this UserTaskNodeModel _param0, UserTaskNode _param1)
    {
      _param0.RegistrationType = (UserTaskRegistrationType) _param1.RegistrationTypeID;
      _param0.IsStartTask = _param1.IsStartTask;
      return _param0;
    }

    private static \u0004.\u0001 \u0001(this \u0004.\u0001 _param0, ServiceTaskNode _param1)
    {
      _param0.TypeId = _param1.TypeId;
      _param0.Metadata = _param1.Metadata;
      return _param0;
    }

    private static \u0001.\u0003 \u0001(this \u0001.\u0003 _param0, ForkNode _param1) => _param0;

    private static JoinNodeModel \u0001(this JoinNodeModel _param0, JoinNode _param1) => _param0;

    private static TimerNodeModel \u0001(this TimerNodeModel _param0, TimerNode _param1)
    {
      _param0.DelayDateTimeExpression = _param1.DelayDateTimeExpression;
      return _param0;
    }

    private static EndEventNodeModel \u0001(this EndEventNodeModel _param0, EndEventNode _param1)
    {
      return _param0;
    }
  }
}
