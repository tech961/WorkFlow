// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace \u0008
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class \u0002
  {
    private static ResourceManager \u0001;
    private static CultureInfo \u0001;

    internal \u0002()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        do
        {
          if (\u0008.\u0002.\u0001 == null)
            \u0008.\u0002.\u0001 = new ResourceManager(\u000E.\u0003.\u0001(107396342), \u0010.\u007E\u001A((object) \u000F.\u0019(__typeref (\u0008.\u0002))));
        }
        while (false);
        return \u0008.\u0002.\u0001;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => \u0008.\u0002.\u0001;
      set => \u0008.\u0002.\u0001 = value;
    }

    internal static string This_Task_Already_has_been_Done
    {
      get
      {
        return \u0011.\u007E\u001B((object) \u0008.\u0002.ResourceManager, \u000E.\u0003.\u0001(107396337), \u0008.\u0002.\u0001);
      }
    }

    internal static string This_Timer_Already_has_been_Done
    {
      get
      {
        return \u0011.\u007E\u001B((object) \u0008.\u0002.ResourceManager, \u000E.\u0003.\u0001(107396260), \u0008.\u0002.\u0001);
      }
    }
  }
}
