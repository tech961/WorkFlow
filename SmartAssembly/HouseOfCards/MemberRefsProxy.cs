// Decompiled with JetBrains decompiler
// Type: SmartAssembly.HouseOfCards.MemberRefsProxy
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System;
using System.Reflection;
using System.Reflection.Emit;

#nullable disable
namespace SmartAssembly.HouseOfCards
{
  public static class MemberRefsProxy
  {
    private static ModuleHandle \u0001;
    private static char[] \u0001;

    [\u0001.\u0001]
    public static unsafe void CreateMemberRefsDelegates(int typeID)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(29);
      Type typeFromHandle;
      try
      {
        typeFromHandle = Type.GetTypeFromHandle(MemberRefsProxy.\u0001.ResolveTypeHandle(33554433 + typeID));
      }
      catch
      {
        return;
      }
      if (true)
        goto label_47;
label_28:
      ILGenerator ilGenerator;
      ilGenerator.Emit(OpCodes.Ldarg_0);
      if (*(int*) ((IntPtr) voidPtr + 16) > 1)
        ilGenerator.Emit(OpCodes.Ldarg_1);
      if (*(int*) ((IntPtr) voidPtr + 16) > 2)
        ilGenerator.Emit(OpCodes.Ldarg_2);
      if (*(int*) ((IntPtr) voidPtr + 16) > 3)
        ilGenerator.Emit(OpCodes.Ldarg_3);
      if (*(int*) ((IntPtr) voidPtr + 16) > 4)
      {
        *(int*) ((IntPtr) voidPtr + 24) = 4;
        while (*(int*) ((IntPtr) voidPtr + 24) < *(int*) ((IntPtr) voidPtr + 16))
        {
          ilGenerator.Emit(OpCodes.Ldarg_S, *(int*) ((IntPtr) voidPtr + 24));
          *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 24) + 1;
        }
      }
      ilGenerator.Emit(OpCodes.Tailcall);
      MethodInfo methodFromHandle;
      ilGenerator.Emit(*(sbyte*) ((IntPtr) voidPtr + 28) != (sbyte) 0 ? OpCodes.Callvirt : OpCodes.Call, methodFromHandle);
      ilGenerator.Emit(OpCodes.Ret);
      Delegate @delegate;
      DynamicMethod dynamicMethod;
      try
      {
        @delegate = dynamicMethod.CreateDelegate(typeFromHandle);
      }
      catch
      {
        goto label_44;
      }
label_41:
      FieldInfo fieldInfo;
      try
      {
        fieldInfo.SetValue((object) null, (object) @delegate);
      }
      catch
      {
      }
label_44:
      if (false)
        return;
      *(int*) voidPtr = *(int*) voidPtr + 1;
label_46:
      FieldInfo[] fields;
      while (*(int*) voidPtr < fields.Length)
      {
        fieldInfo = fields[*(int*) voidPtr];
        string name = fieldInfo.Name;
        *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) 0;
        *(int*) ((IntPtr) voidPtr + 4) = 0;
        *(int*) ((IntPtr) voidPtr + 8) = name.Length - 1;
        while (true)
        {
          if (true)
          {
            if (*(int*) ((IntPtr) voidPtr + 8) >= 0)
            {
              char ch = name[*(int*) ((IntPtr) voidPtr + 8)];
              if (ch != '~')
              {
                *(int*) ((IntPtr) voidPtr + 12) = 0;
                if (true)
                {
                  while (*(int*) ((IntPtr) voidPtr + 12) < 58)
                  {
                    if ((int) MemberRefsProxy.\u0001[*(int*) ((IntPtr) voidPtr + 12)] == (int) ch)
                    {
                      *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) * 58 + *(int*) ((IntPtr) voidPtr + 12);
                      break;
                    }
                    *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
                  }
                  *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - 1;
                }
                else
                  goto label_17;
              }
              else
                break;
            }
            else
              goto label_17;
          }
          else
            goto label_46;
        }
        *(sbyte*) ((IntPtr) voidPtr + 28) = (sbyte) 1;
label_17:
        try
        {
          methodFromHandle = (MethodInfo) MethodBase.GetMethodFromHandle(MemberRefsProxy.\u0001.ResolveMethodHandle(*(int*) ((IntPtr) voidPtr + 4) + 167772161));
        }
        catch
        {
          goto label_44;
        }
        if (methodFromHandle.IsStatic)
        {
          try
          {
            @delegate = Delegate.CreateDelegate(fieldInfo.FieldType, methodFromHandle);
            goto label_41;
          }
          catch (Exception ex)
          {
            goto label_44;
          }
        }
        else
        {
          ParameterInfo[] parameters = methodFromHandle.GetParameters();
          *(int*) ((IntPtr) voidPtr + 16) = parameters.Length + 1;
          Type[] parameterTypes = new Type[*(int*) ((IntPtr) voidPtr + 16)];
          parameterTypes[0] = typeof (object);
          *(int*) ((IntPtr) voidPtr + 20) = 1;
          while (*(int*) ((IntPtr) voidPtr + 20) < *(int*) ((IntPtr) voidPtr + 16))
          {
            parameterTypes[*(int*) ((IntPtr) voidPtr + 20)] = parameters[*(int*) ((IntPtr) voidPtr + 20) - 1].ParameterType;
            if (true)
              *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
            else
              goto label_17;
          }
          dynamicMethod = new DynamicMethod(string.Empty, methodFromHandle.ReturnType, parameterTypes, typeFromHandle, true);
          ilGenerator = dynamicMethod.GetILGenerator();
          goto label_28;
        }
      }
      return;
label_47:
      fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
      *(int*) voidPtr = 0;
      goto label_46;
    }

    static MemberRefsProxy()
    {
label_0:
      if (true)
      {
        MemberRefsProxy.\u0001 = new char[58]
        {
          '\u0001',
          '\u0002',
          '\u0003',
          '\u0004',
          '\u0005',
          '\u0006',
          '\a',
          '\b',
          '\u000E',
          '\u000F',
          '\u0010',
          '\u0011',
          '\u0012',
          '\u0013',
          '\u0014',
          '\u0015',
          '\u0016',
          '\u0017',
          '\u0018',
          '\u0019',
          '\u001A',
          '\u001B',
          '\u001C',
          '\u001D',
          '\u001E',
          '\u001F',
          '\u007F',
          '\u0080',
          '\u0081',
          '\u0082',
          '\u0083',
          '\u0084',
          '\u0086',
          '\u0087',
          '\u0088',
          '\u0089',
          '\u008A',
          '\u008B',
          '\u008C',
          '\u008D',
          '\u008E',
          '\u008F',
          '\u0090',
          '\u0091',
          '\u0092',
          '\u0093',
          '\u0094',
          '\u0095',
          '\u0096',
          '\u0097',
          '\u0098',
          '\u0099',
          '\u009A',
          '\u009B',
          '\u009C',
          '\u009D',
          '\u009E',
          '\u009F'
        };
        if ((object) typeof (MulticastDelegate) != null)
          goto label_6;
      }
      else
        goto label_6;
label_3:
      if (true)
      {
        if (true)
        {
          if (true)
            return;
        }
        else
          goto label_0;
      }
label_6:
      MemberRefsProxy.\u0001 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
      goto label_3;
    }
  }
}
