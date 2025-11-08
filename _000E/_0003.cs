// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System.Collections.Generic;
using System.IO;

#nullable disable
namespace \u000E
{
  internal class \u0003
  {
    private static readonly string \u0001 = "1";
    private static readonly string \u0002 = "64";
    internal static readonly byte[] \u0001;
    internal static readonly Dictionary<int, string> \u0001;
    internal static readonly object \u0001;
    internal static readonly bool \u0001;
    private static readonly int \u0001;

    public static string \u0001(int _param0)
    {
      int num1 = _param0;
      if (true)
      {
        int num2 = 107396847;
        do
        {
          if (num2 != 0)
          {
            _param0 = num1 ^ num2;
            int num3 = _param0;
            num2 = \u0003.\u0001;
            num1 = num3;
          }
        }
        while (false);
        _param0 = num1 - num2;
        num1 = \u0003.\u0001 ? 1 : 0;
      }
      return num1 == 0 ? \u000F.\u0005.\u0001(_param0) : \u000F.\u0005.\u0001(_param0);
    }

    static \u0003()
    {
      if (true)
      {
        \u0003.\u0001 = (byte[]) null;
        \u0003.\u0001 = new object();
        \u0003.\u0001 = false;
      }
      int num1 = 0;
      int num2;
      while (true)
      {
        if (num1 == 0)
        {
          \u0003.\u0001 = num1;
          num1 = \u0096.\u0005\u0002(\u0003.\u0001, "1") ? 1 : 0;
        }
        if (num1 != 0)
        {
          if (true)
          {
            \u0003.\u0001 = true;
            \u0003.\u0001 = new Dictionary<int, string>();
          }
          else
            break;
        }
        num2 = \u0098.\u0008\u0002(\u0003.\u0002);
        if (false)
          num1 = num2;
        else
          goto label_9;
      }
      return;
label_9:
      \u0003.\u0001 = num2;
      Stream stream = \u009D.\u007E\u0012\u0002((object) \u009C.\u0011\u0002(), "{e2da663e-cf69-48ab-964d-bca9bedd22e1}");
      try
      {
        int length = \u009F.\u0014\u0002(\u009E.\u007E\u0013\u0002((object) stream));
        byte[] numArray = new byte[length];
label_12:
        int num3 = \u0001\u0002.\u007E\u0015\u0002((object) stream, numArray, 0, length);
        do
        {
          if (true)
          {
            \u0003.\u0001 = \u000F.\u0005.\u0001(numArray);
            numArray = (byte[]) null;
          }
          else
            goto label_12;
        }
        while (false);
      }
      finally
      {
        if (stream != null)
          \u0005.\u007E\u000E((object) stream);
      }
    }
  }
}
