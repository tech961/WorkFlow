// Decompiled with JetBrains decompiler
// Type: SmartAssembly.HouseOfCards.Strings
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using SmartAssembly.Delegates;
using System;
using System.Reflection;
using System.Reflection.Emit;

#nullable disable
namespace SmartAssembly.HouseOfCards
{
  public static class Strings
  {
    [\u0001.\u0001]
    public static unsafe void CreateGetStringDelegate(Type ownerType)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      FieldInfo[] fields = ownerType.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
      *(int*) voidPtr = 0;
      while (*(int*) voidPtr < fields.Length)
      {
        FieldInfo fieldInfo = fields[*(int*) voidPtr];
        try
        {
          if ((object) fieldInfo.FieldType == (object) typeof (GetString))
          {
            DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof (string), new Type[1]
            {
              typeof (int)
            }, ownerType.Module, true);
            ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
            ilGenerator.Emit(OpCodes.Ldarg_0);
            MethodInfo[] methods = typeof (\u000E.\u0003).GetMethods(BindingFlags.Static | BindingFlags.Public);
            *(int*) ((IntPtr) voidPtr + 4) = 0;
            while (*(int*) ((IntPtr) voidPtr + 4) < methods.Length)
            {
              MethodInfo meth = methods[*(int*) ((IntPtr) voidPtr + 4)];
              if ((object) meth.ReturnType == (object) typeof (string))
              {
                ilGenerator.Emit(OpCodes.Ldc_I4, fieldInfo.MetadataToken & 16777215);
                ilGenerator.Emit(OpCodes.Sub);
                ilGenerator.Emit(OpCodes.Call, meth);
                break;
              }
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
            }
            if (true)
              ilGenerator.Emit(OpCodes.Ret);
            fieldInfo.SetValue((object) null, (object) dynamicMethod.CreateDelegate(typeof (GetString)));
            break;
          }
        }
        catch
        {
        }
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
    }
  }
}
