// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Service.IExpressionEvaluator
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SimpleWorkflowEngine.RuntimeModel;
using System;

#nullable disable
namespace SimpleWorkflowEngine.Service
{
  public interface IExpressionEvaluator
  {
    bool EvaluateCondition(IExecutionContext executionContext, string condition);

    DateTime EvaluateDateTime(IExecutionContext executionContext, string dateTimeExpression);
  }
}
