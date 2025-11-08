// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Models.UserTaskRegistrationType
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.ComponentModel;

#nullable disable
namespace SimpleWorkflowEngine.Models
{
  public enum UserTaskRegistrationType
  {
    None,
    [Description("توسط سیستم")] BySystem,
    [Description("توسط سیستم با پیش نمایش")] BySystemWithPreview,
    [Description("توسط کاربر")] ByUser,
    [Description("توسط کاربر با مقادیر پیش فرض")] ByUserWithDefaultValues,
  }
}
