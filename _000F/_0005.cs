// Decompiled with JetBrains decompiler
// Type: .
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using Microsoft.Practices.Unity;
using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.Engine;
using SimpleWorkflowEngine.Models;
using SimpleWorkflowEngine.RuntimeModel;
using SimpleWorkflowEngine.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Transactions;

#nullable disable
namespace \u000F
{
  internal class \u0005
  {
    static void \u0001(\u0005.\u0005.\u0002 _param0, [In] int obj1)
    {
label_0:
      _param0.\u0001 >>>= obj1 & 31;
label_1:
      if (true)
      {
        _param0.\u0003 -= obj1;
        if (false)
          goto label_1;
      }
      else
        goto label_0;
    }

    static \u0005.\u0005.\u0004 \u0001([In] \u0005.\u0005.\u0005 obj0)
    {
      byte[] destinationArray = new byte[obj0.\u0008];
      Array.Copy((Array) obj0.\u0002, 0, (Array) destinationArray, 0, obj0.\u0008);
      return new \u0005.\u0005.\u0004(destinationArray);
    }

    static bool \u0001(bool _param0, bool _param1, [In] \u0005.\u0005.\u0008 obj2)
    {
      bool flag;
      int num1;
      do
      {
        \u000F.\u0005.\u0001(obj2);
        int num2;
        if (!_param0)
        {
          if (true)
            num2 = 0;
          else
            continue;
        }
        else
          goto label_13;
label_5:
        if (true)
        {
          int num3 = num2 != 0 ? 1 : 0;
          if (false)
          {
            num1 = num3;
            goto label_11;
          }
          else
          {
            \u0005.\u0005.\u0008 obj = obj2;
            int num4 = _param1 ? 1 : 0;
            flag = \u000F.\u0005.\u0001(num3 != 0, obj, num4 != 0);
            num2 = obj2.\u0001.\u0002;
          }
        }
        else
          goto label_9;
label_7:
        int num5 = 0;
label_8:
        num2 = num2 == num5 ? 1 : 0;
label_9:
        if (true)
        {
          int num6 = flag ? 1 : 0;
          num1 = num2 & num6;
        }
        else
          goto label_7;
label_11:
        continue;
label_13:
        int num7 = obj2.\u0017;
        int num8 = obj2.\u0018;
        if (true)
        {
          num2 = num7 == num8 ? 1 : 0;
          goto label_5;
        }
        else
        {
          num5 = num8;
          num2 = num7;
          goto label_8;
        }
      }
      while (num1 != 0);
      return flag;
    }

    static void \u0001(\u0005.\u0005.\u000E _param0, int _param1, [In] int obj2)
    {
label_0:
      do
      {
        _param0.\u0001 |= (uint) (_param1 << _param0.\u0003);
        _param0.\u0003 += obj2;
        if (_param0.\u0003 >= 16)
          goto label_6;
label_5:
        continue;
label_6:
        byte[] numArray1 = _param0.\u0001;
        \u0005.\u0005.\u000E obj1 = _param0;
        int num1 = _param0.\u0002;
        int num2 = num1 + 1;
        obj1.\u0002 = num2;
        int index1 = num1;
        int num3 = (int) (byte) _param0.\u0001;
        numArray1[index1] = (byte) num3;
        do
        {
          if (true)
          {
            byte[] numArray2 = _param0.\u0001;
            \u0005.\u0005.\u000E obj3 = _param0;
            int num4 = _param0.\u0002;
            int num5 = num4 + 1;
            obj3.\u0002 = num5;
            int index2 = num4;
            int num6 = (int) (byte) (_param0.\u0001 >> 8);
            numArray2[index2] = (byte) num6;
            _param0.\u0001 >>= 16;
          }
          else
            goto label_0;
        }
        while (false);
        _param0.\u0003 -= 16;
        goto label_5;
      }
      while (false);
    }

    static string \u0001(int _param0)
    {
      int num1 = _param0;
      byte[] numArray1 = \u000E.\u0003.\u0001;
      int index1 = num1;
      int num2 = index1 + 1;
      if (true)
        goto label_25;
label_2:
      int num3 = (int) numArray1[index1];
      int num4;
      int num5;
      while (true)
      {
        num4 = num3;
        if ((num4 & 128) != 0)
        {
          num5 = num4;
          if (false)
            num3 = num5;
          else
            break;
        }
        else
          goto label_27;
      }
      int num6;
      if (true)
      {
        int num7;
        for (int index2 = num5 & 64; index2 != 0; index2 = num7)
        {
          int num8 = ((num4 & 31) << 24) + ((int) \u000E.\u0003.\u0001[num1++] << 16);
          int num9;
          while (true)
          {
            int num10 = (int) \u000E.\u0003.\u0001[num1++] << 8;
            num7 = num8 + num10;
            if (true)
            {
              int num11 = (int) \u000E.\u0003.\u0001[num1++];
              num9 = num7 + num11;
              if (false)
                num8 = num9;
              else
                break;
            }
            else
              break;
          }
          num6 = num9;
          goto label_17;
        }
        int num12 = num4 & 63;
        int num13 = 8;
        int num14;
        int num15;
        while (true)
        {
          num14 = num12 << num13;
          num15 = (int) \u000E.\u0003.\u0001[num1++];
          if (false)
          {
            num13 = num15;
            num12 = num14;
          }
          else
            break;
        }
        num5 = num14 + num15;
      }
      num6 = num5;
label_17:
      do
        ;
      while (false);
      string str1;
      try
      {
        byte[] numArray2 = \u0090.\u009E(\u008F.\u007E\u009D((object) \u008E.\u009C(), \u000E.\u0003.\u0001, num1, num6));
        string str2 = \u0091.\u009F(\u008F.\u007E\u009D((object) \u008E.\u009C(), numArray2, 0, numArray2.Length));
        if (\u000E.\u0003.\u0001)
          \u000F.\u0005.\u0001(str2, _param0);
        str1 = str2;
      }
      catch
      {
        do
        {
          str1 = (string) null;
        }
        while (false);
      }
      return str1;
label_27:
      num6 = num4;
      if (num6 == 0)
        return string.Empty;
      goto label_17;
label_25:
      num1 = num2;
      goto label_2;
    }

    static unsafe bool \u0001(int _param0, [In] \u0005.\u0005.\u0008 obj1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(22);
      int num1 = 128;
      *(int*) voidPtr = 128;
      short[] numArray = obj1.\u0002;
      int index = obj1.\u0014;
      *(int*) ((IntPtr) voidPtr + 4) = obj1.\u0014 + obj1.\u0012;
      *(int*) ((IntPtr) voidPtr + 8) = Math.Max(obj1.\u0012, 2);
      *(int*) ((IntPtr) voidPtr + 12) = Math.Max(obj1.\u0014 - 32506, 0);
      *(int*) ((IntPtr) voidPtr + 16) = obj1.\u0014 + 258 - 1;
      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 4) - 1];
      *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 4)];
      if (*(int*) ((IntPtr) voidPtr + 8) >= 8)
        num1 >>= 2;
      if (*(int*) voidPtr > obj1.\u0015)
        *(int*) voidPtr = obj1.\u0015;
      int num2;
      int num3;
      do
      {
        if ((int) obj1.\u0001[_param0 + *(int*) ((IntPtr) voidPtr + 8)] == (int) *(byte*) ((IntPtr) voidPtr + 21) && (int) obj1.\u0001[_param0 + *(int*) ((IntPtr) voidPtr + 8) - 1] == (int) *(byte*) ((IntPtr) voidPtr + 20) && (int) obj1.\u0001[_param0] == (int) obj1.\u0001[index] && (int) obj1.\u0001[_param0 + 1] == (int) obj1.\u0001[index + 1])
        {
          int num4 = _param0 + 2;
          int num5 = index + 2;
          int num6;
          int num7;
          int num8;
          int num9;
          int num10;
          int num11;
          int num12;
          do
            ;
          while ((int) obj1.\u0001[++num5] == (int) obj1.\u0001[num6 = num4 + 1] && (int) obj1.\u0001[++num5] == (int) obj1.\u0001[num7 = num6 + 1] && (int) obj1.\u0001[++num5] == (int) obj1.\u0001[num8 = num7 + 1] && (int) obj1.\u0001[++num5] == (int) obj1.\u0001[num9 = num8 + 1] && (int) obj1.\u0001[++num5] == (int) obj1.\u0001[num10 = num9 + 1] && (int) obj1.\u0001[++num5] == (int) obj1.\u0001[num11 = num10 + 1] && (int) obj1.\u0001[++num5] == (int) obj1.\u0001[num12 = num11 + 1] && (int) obj1.\u0001[++num5] == (int) obj1.\u0001[num4 = num12 + 1] && num5 < *(int*) ((IntPtr) voidPtr + 16));
          if (num5 > *(int*) ((IntPtr) voidPtr + 4))
          {
            obj1.\u0011 = _param0;
            *(int*) ((IntPtr) voidPtr + 4) = num5;
            *(int*) ((IntPtr) voidPtr + 8) = num5 - obj1.\u0014;
            if (*(int*) ((IntPtr) voidPtr + 8) < *(int*) voidPtr)
            {
              *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 4) - 1];
              *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 4)];
            }
            else
              break;
          }
          index = obj1.\u0014;
        }
        if ((_param0 = (int) numArray[_param0 & (int) short.MaxValue] & (int) ushort.MaxValue) > *(int*) ((IntPtr) voidPtr + 12))
        {
          num2 = num1;
          num3 = 1;
          if (num3 == 0)
            goto label_1;
        }
        else
          break;
      }
      while ((num1 = num2 - num3) != 0);
      obj1.\u0012 = Math.Min(*(int*) ((IntPtr) voidPtr + 8), obj1.\u0015);
      int num13 = obj1.\u0012;
      int num14 = 3;
label_16:
      return num13 >= num14;
label_1:
      num14 = num3;
      num13 = num2;
      goto label_16;
    }

    static void \u0001([In] ExecutionEngine.SchedulerEngine obj0)
    {
      obj0.\u0002 = true;
      global::\u0005.\u007E\u0011((object) obj0.\u0001);
    }

    static unsafe int \u0001(\u0005.\u0005.\u0004 _param0, [In] \u0005.\u0005.\u0002 obj1)
    {
      int num1;
      void* voidPtr;
      if (true)
      {
        int num2 = 16;
        int index;
        int num3;
        while (true)
        {
          // ISSUE: untyped stack allocation
          voidPtr = (void*) __untypedstackalloc(num2);
          if ((index = \u000F.\u0005.\u0001(obj1, 9)) >= 0)
          {
            if ((num1 = (int) _param0.\u0001[index]) >= 0)
            {
              if (true)
              {
                \u000F.\u0005.\u0001(obj1, num1 & 15);
                num3 = num1;
                if (false)
                  num2 = num3;
                else
                  break;
              }
              else
                goto label_8;
            }
            else
              goto label_5;
          }
          else
            goto label_13;
        }
        return num3 >> 4;
label_5:
        *(int*) voidPtr = -(num1 >> 4);
        *(int*) ((IntPtr) voidPtr + 4) = num1 & 15;
        int num4;
        if ((num4 = \u000F.\u0005.\u0001(obj1, *(int*) ((IntPtr) voidPtr + 4))) >= 0)
        {
          int num5 = (int) _param0.\u0001[*(int*) voidPtr | num4 >> 9];
          \u000F.\u0005.\u0001(obj1, num5 & 15);
          return num5 >> 4;
        }
        *(int*) ((IntPtr) voidPtr + 8) = obj1.\u0003;
        index = \u000F.\u0005.\u0001(obj1, *(int*) ((IntPtr) voidPtr + 8));
        num1 = (int) _param0.\u0001[*(int*) voidPtr | index >> 9];
label_8:
        if (true)
        {
          if ((num1 & 15) > *(int*) ((IntPtr) voidPtr + 8))
            return -1;
          \u000F.\u0005.\u0001(obj1, num1 & 15);
          if (true)
            return num1 >> 4;
          goto label_14;
        }
        else
          goto label_16;
label_13:
        *(int*) ((IntPtr) voidPtr + 12) = obj1.\u0003;
        index = \u000F.\u0005.\u0001(obj1, *(int*) ((IntPtr) voidPtr + 12));
label_14:
        num1 = (int) _param0.\u0001[index];
      }
      if (num1 < 0)
        goto label_18;
label_16:
      if ((num1 & 15) <= *(int*) ((IntPtr) voidPtr + 12))
      {
        \u000F.\u0005.\u0001(obj1, num1 & 15);
        return num1 >> 4;
      }
label_18:
      return -1;
    }

    static void \u0001(
      ProcessExecutionStep _param0,
      IExecutionContext _param1,
      [In] ProcessNodeModel obj2)
    {
      if (((IInternalExecutionContext) _param1).SimulationMode)
        return;
      _param1.StepId = _param0.ID;
      UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]).\u0001(_param1, (IProcessNodeModel) obj2);
    }

    static void \u0001(\u0005.\u0005.\u000F _param0, [In] int obj1)
    {
      _param0.WriteByte((byte) (obj1 & (int) byte.MaxValue));
      _param0.WriteByte((byte) (obj1 >> 8 & (int) byte.MaxValue));
    }

    static unsafe int \u0001(byte[] _param0, int _param1, int _param2, [In] \u0005.\u0005.\u0003 obj3)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
      int num1;
      int num2;
      do
      {
        *(int*) voidPtr = obj3.\u0003;
        num1 = _param1;
        num2 = obj3.\u0004;
        if (true)
        {
          if (true)
          {
            if (num1 <= num2)
              goto label_17;
            else
              goto label_16;
label_4:
            *(int*) ((IntPtr) voidPtr + 4) = _param1;
            continue;
label_16:
            _param1 = obj3.\u0004;
            goto label_4;
label_17:
            *(int*) voidPtr = obj3.\u0003 - obj3.\u0004 + _param1 & (int) short.MaxValue;
            goto label_4;
          }
          else
            goto label_10;
        }
        else
          goto label_12;
      }
      while (false);
      if (true)
      {
        *(int*) ((IntPtr) voidPtr + 8) = _param1 - *(int*) voidPtr;
        int num3 = *(int*) ((IntPtr) voidPtr + 8);
        int num4 = 0;
        if (num4 == 0)
        {
          if (num3 > num4)
            Array.Copy((Array) obj3.\u0001, 32768 - *(int*) ((IntPtr) voidPtr + 8), (Array) _param0, _param2, *(int*) ((IntPtr) voidPtr + 8));
          else
            goto label_11;
        }
        else
        {
          num2 = num4;
          num1 = num3;
          goto label_10;
        }
      }
      int num5 = _param2;
      num2 = *(int*) ((IntPtr) voidPtr + 8);
      num1 = num5;
label_10:
      _param2 = num1 + num2;
      _param1 = *(int*) voidPtr;
label_11:
      Array.Copy((Array) obj3.\u0001, *(int*) voidPtr - _param1, (Array) _param0, _param2, _param1);
      obj3.\u0004 -= *(int*) ((IntPtr) voidPtr + 4);
      int num6 = obj3.\u0004;
      num2 = 0;
      num1 = num6;
label_12:
      if (num1 < num2)
        throw new InvalidOperationException();
      return *(int*) ((IntPtr) voidPtr + 4);
    }

    static int \u0001([In] \u0005.\u0005.\u0008 obj0)
    {
      int index;
      short num1;
      int num2;
      int maxValue;
      do
      {
        num2 = obj0.\u0010 << 5;
        maxValue = (int) obj0.\u0001[obj0.\u0014 + 2];
        if (true)
        {
          index = (num2 ^ maxValue) & (int) short.MaxValue;
          obj0.\u0002[obj0.\u0014 & (int) short.MaxValue] = num1 = obj0.\u0001[index];
        }
        else
          goto label_3;
      }
      while (false);
      obj0.\u0001[index] = (short) obj0.\u0014;
      obj0.\u0010 = index;
      int num3 = (int) num1;
      maxValue = (int) ushort.MaxValue;
      num2 = num3;
label_3:
      return num2 & maxValue;
    }

    static void \u0001([In] \u0005.\u0005.\u0002 obj0)
    {
      do
      {
        if (true)
          goto label_3;
label_2:
        continue;
label_3:
        obj0.\u0001 = (uint) (obj0.\u0001 = obj0.\u0002 = obj0.\u0003 = 0);
        goto label_2;
      }
      while (false);
    }

    static unsafe int \u0001(\u0005.\u0005.\u0006 _param0, [In] byte[] obj1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(22);
      *(int*) voidPtr = 0;
      *(int*) ((IntPtr) voidPtr + 4) = obj1.Length;
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 4);
      int num1;
      while (true)
      {
        *(int*) ((IntPtr) voidPtr + 12) = \u000F.\u0005.\u0001(_param0.\u0001, obj1, *(int*) voidPtr, *(int*) ((IntPtr) voidPtr + 4));
        *(int*) voidPtr = *(int*) voidPtr + *(int*) ((IntPtr) voidPtr + 12);
label_1:
        if (true)
        {
          _param0.\u0001 += (long) *(int*) ((IntPtr) voidPtr + 12);
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) - *(int*) ((IntPtr) voidPtr + 12);
          if (*(int*) ((IntPtr) voidPtr + 4) != 0 && _param0.\u0007 != 30)
          {
            \u0005.\u0005.\u0008 obj = _param0.\u0001;
            *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) ((_param0.\u0007 & 4) != 0);
            *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) ((_param0.\u0007 & 8) != 0);
            if (!\u000F.\u0005.\u0001((bool) *(sbyte*) ((IntPtr) voidPtr + 20), (bool) *(sbyte*) ((IntPtr) voidPtr + 21), obj))
            {
              if (_param0.\u0007 != 16)
              {
                if (_param0.\u0007 == 20)
                  *(int*) ((IntPtr) voidPtr + 16) = 8 + (-_param0.\u0001.\u0003 & 7);
                else if (true)
                {
                  if (_param0.\u0007 != 28)
                    continue;
                  goto label_15;
                }
                else
                  break;
              }
              else
                break;
            }
            else
              continue;
          }
          else
            goto label_16;
        }
        else
          goto label_15;
label_10:
        num1 = *(int*) ((IntPtr) voidPtr + 16);
label_11:
        if (num1 > 0)
        {
          if (true)
          {
            \u000F.\u0005.\u0001(_param0.\u0001, 2, 10);
            *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) - 10;
            goto label_10;
          }
          else
            goto label_1;
        }
        else
        {
          _param0.\u0007 = 16;
          continue;
        }
label_15:
        \u000F.\u0005.\u0001(_param0.\u0001);
        _param0.\u0007 = 30;
        if (true)
          continue;
label_16:
        num1 = *(int*) ((IntPtr) voidPtr + 8);
        if (false)
          goto label_11;
        else
          goto label_17;
      }
      return *(int*) ((IntPtr) voidPtr + 8) - *(int*) ((IntPtr) voidPtr + 4);
label_17:
      int num2 = *(int*) ((IntPtr) voidPtr + 4);
      return num1 - num2;
    }

    static bool \u0001(Assembly _param0, Assembly _param1) => true;

    static ServiceTaskNode \u0001(Process _param0, WorkflowSystemContext _param1, string _param2)
    {
      ServiceTaskNode serviceTaskNode;
      ProcessNode processNode;
      do
      {
        if (true)
          goto label_4;
label_2:
        continue;
label_4:
        processNode = \u000F.\u0005.\u0001(_param0, ProcessNodeKind.ServiceTaskNode, _param1, _param2);
        if (true)
          goto label_5;
label_1:
        processNode.ServiceTaskNode = serviceTaskNode;
        goto label_2;
label_5:
        serviceTaskNode = \u000E.\u0001.\u0001<ServiceTaskNode>(_param1.ServiceTaskNodes.Create());
        goto label_1;
      }
      while (false);
      serviceTaskNode.ProcessNode = processNode;
      return serviceTaskNode;
    }

    static void \u0001(object _param0)
    {
    }

    static unsafe bool \u0001([In] \u0005.\u0005.\u0001 obj0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
label_35:
      int num1 = \u000F.\u0005.\u0001(obj0.\u0001);
label_32:
      int num2 = num1;
      int num3;
      for (int index1 = 258; num2 >= index1; num2 = num3)
      {
        *(int*) voidPtr = obj0.\u0013;
        int index2;
        int num4;
        int num5;
        switch (*(int*) voidPtr)
        {
          case 7:
            while (((index2 = \u000F.\u0005.\u0001(obj0.\u0001, obj0.\u0001)) & -256) == 0)
            {
              if (true)
                goto label_37;
label_3:
              if (true)
                return true;
              goto label_25;
label_37:
              \u000F.\u0005.\u0001(obj0.\u0001, index2);
              if (--num1 < 258)
                goto label_3;
            }
            if (index2 < 257)
            {
              num3 = index2;
              int num6 = 0;
              if (num6 == 0)
              {
                if (num3 < num6)
                  return false;
                obj0.\u0002 = (\u0005.\u0005.\u0004) null;
                obj0.\u0001 = (\u0005.\u0005.\u0004) null;
                obj0.\u0013 = 2;
                return true;
              }
              index1 = num6;
              continue;
            }
            break;
          case 8:
label_12:
            if (obj0.\u0014 > 0)
            {
              obj0.\u0013 = 8;
              *(int*) ((IntPtr) voidPtr + 4) = \u000F.\u0005.\u0001(obj0.\u0001, obj0.\u0014);
              if (*(int*) ((IntPtr) voidPtr + 4) < 0)
                return false;
              if (true)
              {
                \u000F.\u0005.\u0001(obj0.\u0001, obj0.\u0014);
                obj0.\u0015 += *(int*) ((IntPtr) voidPtr + 4);
              }
              else
                break;
            }
            obj0.\u0013 = 9;
            goto case 9;
          case 9:
            if (true)
            {
              index2 = \u000F.\u0005.\u0001(obj0.\u0002, obj0.\u0001);
              if (index2 < 0)
                return false;
              obj0.\u0016 = \u0005.\u0005.\u0001.\u0003[index2];
              obj0.\u0014 = \u0005.\u0005.\u0001.\u0004[index2];
              goto case 10;
            }
            else
              goto label_35;
          case 10:
            int num7 = obj0.\u0014;
            num5 = 0;
            num4 = num7;
            goto label_23;
          default:
            goto label_32;
        }
        obj0.\u0015 = \u0005.\u0005.\u0001.\u0001[index2 - 257];
        obj0.\u0014 = \u0005.\u0005.\u0001.\u0002[index2 - 257];
        goto label_12;
label_23:
        if (num4 > num5)
        {
          obj0.\u0013 = 10;
          *(int*) ((IntPtr) voidPtr + 8) = \u000F.\u0005.\u0001(obj0.\u0001, obj0.\u0014);
        }
        else
          goto label_30;
label_25:
        num4 = *(int*) ((IntPtr) voidPtr + 8);
label_26:
        num5 = 0;
        if (num5 == 0)
        {
          if (num4 < num5)
            return false;
          \u000F.\u0005.\u0001(obj0.\u0001, obj0.\u0014);
          obj0.\u0016 += *(int*) ((IntPtr) voidPtr + 8);
        }
        else
          goto label_23;
label_30:
        \u000F.\u0005.\u0001(obj0.\u0001, obj0.\u0015, obj0.\u0016);
        int num8 = num1 - obj0.\u0015;
        if (false)
        {
          num4 = num8;
          goto label_26;
        }
        else
        {
          num1 = num8;
          obj0.\u0013 = 7;
          goto label_32;
        }
      }
      return true;
    }

    static unsafe bool \u0001(\u0005.\u0005.\u0005 _param0, [In] \u0005.\u0005.\u0002 obj1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      while (true)
      {
        *(int*) voidPtr = _param0.\u0007;
        switch (*(int*) voidPtr)
        {
          case 0:
            _param0.\u0008 = \u000F.\u0005.\u0001(obj1, 5);
            if (_param0.\u0008 >= 0)
            {
              _param0.\u0008 += 257;
              \u000F.\u0005.\u0001(obj1, 5);
              _param0.\u0007 = 1;
              goto case 1;
            }
            else
              goto label_1;
          case 1:
            _param0.\u000E = \u000F.\u0005.\u0001(obj1, 5);
            if (_param0.\u000E >= 0)
            {
              ++_param0.\u000E;
              \u000F.\u0005.\u0001(obj1, 5);
              _param0.\u0010 = _param0.\u0008 + _param0.\u000E;
              _param0.\u0002 = new byte[_param0.\u0010];
              _param0.\u0007 = 2;
              goto case 2;
            }
            else
              goto label_3;
          case 2:
            _param0.\u000F = \u000F.\u0005.\u0001(obj1, 4);
            if (_param0.\u000F >= 0)
            {
              _param0.\u000F += 4;
              \u000F.\u0005.\u0001(obj1, 4);
              _param0.\u0001 = new byte[19];
              _param0.\u0012 = 0;
              _param0.\u0007 = 3;
              goto case 3;
            }
            else
              goto label_6;
          case 3:
            for (; _param0.\u0012 < _param0.\u000F; ++_param0.\u0012)
            {
              *(int*) ((IntPtr) voidPtr + 4) = \u000F.\u0005.\u0001(obj1, 3);
              if (*(int*) ((IntPtr) voidPtr + 4) < 0)
                return false;
              \u000F.\u0005.\u0001(obj1, 3);
              _param0.\u0001[\u0005.\u0005.\u0005.\u0003[_param0.\u0012]] = (byte) *(int*) ((IntPtr) voidPtr + 4);
            }
            _param0.\u0001 = new \u0005.\u0005.\u0004(_param0.\u0001);
            _param0.\u0001 = (byte[]) null;
            _param0.\u0012 = 0;
            _param0.\u0007 = 4;
            goto case 4;
          case 4:
            int num1;
            while (((num1 = \u000F.\u0005.\u0001(_param0.\u0001, obj1)) & -16) == 0)
            {
              byte[] numArray = _param0.\u0002;
              \u0005.\u0005.\u0005 obj = _param0;
              *(int*) ((IntPtr) voidPtr + 8) = _param0.\u0012;
              int num2 = *(int*) ((IntPtr) voidPtr + 8) + 1;
              obj.\u0012 = num2;
              int index = *(int*) ((IntPtr) voidPtr + 8);
              int num3 = (int) (_param0.\u0001 = (byte) num1);
              numArray[index] = (byte) num3;
              if (_param0.\u0012 == _param0.\u0010)
                return true;
            }
            if (num1 >= 0)
            {
              if (num1 >= 17)
                _param0.\u0001 = (byte) 0;
              _param0.\u0011 = num1 - 16;
              _param0.\u0007 = 5;
              goto case 5;
            }
            else
              goto label_17;
          case 5:
            *(int*) ((IntPtr) voidPtr + 12) = \u0005.\u0005.\u0005.\u0002[_param0.\u0011];
            int num4 = \u000F.\u0005.\u0001(obj1, *(int*) ((IntPtr) voidPtr + 12));
            if (num4 >= 0)
            {
              \u000F.\u0005.\u0001(obj1, *(int*) ((IntPtr) voidPtr + 12));
              int num5 = num4 + \u0005.\u0005.\u0005.\u0001[_param0.\u0011];
              while (num5-- > 0)
              {
                byte[] numArray = _param0.\u0002;
                \u0005.\u0005.\u0005 obj = _param0;
                *(int*) ((IntPtr) voidPtr + 8) = _param0.\u0012;
                int num6 = *(int*) ((IntPtr) voidPtr + 8) + 1;
                obj.\u0012 = num6;
                int index = *(int*) ((IntPtr) voidPtr + 8);
                int num7 = (int) _param0.\u0001;
                numArray[index] = (byte) num7;
              }
              if (_param0.\u0012 != _param0.\u0010)
              {
                _param0.\u0007 = 4;
                continue;
              }
              goto label_27;
            }
            else
              goto label_22;
          default:
            continue;
        }
      }
label_1:
      return false;
label_3:
      return false;
label_6:
      return false;
label_17:
      return false;
label_22:
      return false;
label_27:
      return true;
    }

    static void \u0001([In] \u0005.\u0005.\u0007 obj0)
    {
      obj0.\u000E = 0;
      obj0.\u000F = 0;
    }

    static void \u0001([In] \u0005.\u0005.\u0006 obj0) => obj0.\u0007 |= 12;

    static unsafe IEnumerable<IUserTaskNodeModel> \u0001(
      IExecutionContext _param0,
      [In] ExecutionEngine obj1)
    {
      // ISSUE: untyped stack allocation
      IntPtr num = __untypedstackalloc(9);
      void* voidPtr;
      if (true)
        voidPtr = (void*) num;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ExecutionEngine.\u0005 obj2 = new ExecutionEngine.\u0005();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = _param0;
      // ISSUE: reference to a compiler-generated field
      Guid stepId = obj2.\u0001.StepId;
      // ISSUE: reference to a compiler-generated field
      *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) ((IInternalExecutionContext) obj2.\u0001).SimulationMode;
      // ISSUE: reference to a compiler-generated field
      ((IInternalExecutionContext) obj2.\u0001).SimulationMode = true;
      IEnumerable<UserTaskNodeModel> userTaskNodeModels;
      try
      {
        using (new TransactionScope())
        {
          using (WorkflowSystemContext workflowSystemContext = \u000F.\u0005.\u0001(obj1))
          {
            using (DbContextTransaction contextTransaction = workflowSystemContext.Database.BeginTransaction())
            {
              // ISSUE: object of a compiler-generated type is created
              // ISSUE: variable of a compiler-generated type
              ExecutionEngine.\u0006 obj3 = new ExecutionEngine.\u0006();
              try
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                obj3.\u0001 = ((IQueryable<ProcessExecutionStep>) workflowSystemContext.ProcessExecutionSteps).Single<ProcessExecutionStep>((Expression<Func<ProcessExecutionStep, bool>>) (processExecutionStep => processExecutionStep.ID == obj2.\u0001.StepId));
              }
              catch (Exception ex)
              {
                throw new InvalidOperationException(\u000E.\u0003.\u0001(107396544), ex);
              }
              // ISSUE: reference to a compiler-generated field
              ProcessInstance processInstance1 = ((IQueryable<ProcessInstance>) workflowSystemContext.ProcessInstances).Single<ProcessInstance>((Expression<Func<ProcessInstance, bool>>) (processInstance => processInstance.ID == obj3.\u0001.ProcessID));
              *(int*) voidPtr = processInstance1.ProcessMetaDataID;
              // ISSUE: reference to a compiler-generated field
              *(int*) ((IntPtr) voidPtr + 4) = obj3.\u0001.ProcessNodeID;
              UserTaskNodeModel userTaskNodeModel;
              try
              {
                userTaskNodeModel = (UserTaskNodeModel) obj1.\u0001.\u0001(*(int*) voidPtr, *(int*) ((IntPtr) voidPtr + 4));
              }
              catch (Exception ex)
              {
                throw new InvalidOperationException(\u000E.\u0003.\u0001(107395632), ex);
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              userTaskNodeModel.\u0002(processInstance1, obj2.\u0001, workflowSystemContext, obj3.\u0001);
              int[] array = workflowSystemContext.ChangeTracker.Entries<ProcessExecutionStep>().Where<DbEntityEntry<ProcessExecutionStep>>((Func<DbEntityEntry<ProcessExecutionStep>, bool>) (_param1 => _param1.State == 4)).Where<DbEntityEntry<ProcessExecutionStep>>((Func<DbEntityEntry<ProcessExecutionStep>, bool>) (_param1 => !_param1.Entity.Done)).Select<DbEntityEntry<ProcessExecutionStep>, int>((Func<DbEntityEntry<ProcessExecutionStep>, int>) (_param1 => _param1.Entity.ProcessNodeID)).ToArray<int>();
              userTaskNodeModels = obj1.\u0001.\u0001(*(int*) voidPtr, (IEnumerable<int>) array);
              contextTransaction.Rollback();
            }
          }
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001.StepId = stepId;
        // ISSUE: reference to a compiler-generated field
        ((IInternalExecutionContext) obj2.\u0001).SimulationMode = (bool) *(sbyte*) ((IntPtr) voidPtr + 8);
      }
      return (IEnumerable<IUserTaskNodeModel>) userTaskNodeModels;
    }

    static void \u0001(int _param0, [In] \u0005.\u0005.\u0007 obj1)
    {
      if (true)
        goto label_10;
label_6:
      int index;
      ++index;
label_7:
      if (index < _param0)
      {
        if (false)
          return;
        \u000F.\u0005.\u0001(obj1.\u0001, (int) obj1.\u0003.\u0001[\u0005.\u0005.\u0007.\u0001[index]], 3);
        goto label_6;
      }
      else
      {
        do
        {
          \u0005.\u0005.\u0007.\u0001 obj = obj1.\u0001;
          \u000F.\u0005.\u0001(obj1.\u0003, obj);
        }
        while (false);
        \u0005.\u0005.\u0007.\u0001 obj2 = obj1.\u0002;
        \u000F.\u0005.\u0001(obj1.\u0003, obj2);
        return;
      }
label_10:
      \u000F.\u0005.\u0001(obj1.\u0003);
      \u000F.\u0005.\u0001(obj1.\u0001);
      \u000F.\u0005.\u0001(obj1.\u0002);
      if (true)
      {
        \u0005.\u0005.\u000E obj = obj1.\u0001;
        int num = obj1.\u0001.\u0002 - 257;
        if (true)
          goto label_12;
label_1:
        \u000F.\u0005.\u0001(obj1.\u0001, obj1.\u0002.\u0002 - 1, 5);
        do
        {
          \u000F.\u0005.\u0001(obj1.\u0001, _param0 - 4, 4);
          index = 0;
        }
        while (false);
        goto label_7;
label_12:
        \u000F.\u0005.\u0001(obj, num, 5);
        goto label_1;
      }
      else
        goto label_7;
    }

    static void \u0001([In] ExecutionEngine obj0)
    {
      \u000F.\u0005.\u0001(obj0.\u0001);
      WorkflowSystemContext workflowSystemContext = \u000F.\u0005.\u0001(obj0);
      try
      {
        DbSet<Process> processes = workflowSystemContext.Processes;
        // ISSUE: type reference
        ParameterExpression parameterExpression1 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u001E obj1 = \u001E.\u008A;
        // ISSUE: method reference
        MemberExpression memberExpression = \u0019.\u0083((Expression) parameterExpression1, (MethodInfo) \u0018.\u0082(__methodref (Process.get_Active)));
        \u0093 obj2 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo1 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Any));
        // ISSUE: method reference
        Expression[] expressionArray1 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression1, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessInstances))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression2 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessInstance)), \u000E.\u0003.\u0001(107396075));
        // ISSUE: method reference
        expressionArray1[1] = (Expression) Expression.Lambda<Func<ProcessInstance, bool>>((Expression) \u0092.\u0001\u0002((Expression) \u0019.\u0083((Expression) parameterExpression2, (MethodInfo) \u0018.\u0082(__methodref (ProcessInstance.get_Closed)))), parameterExpression2);
        MethodCallExpression methodCallExpression = obj2((Expression) null, methodInfo1, expressionArray1);
        Expression<Func<Process, bool>> predicate = Expression.Lambda<Func<Process, bool>>((Expression) obj1((Expression) memberExpression, (Expression) methodCallExpression), parameterExpression1);
        IQueryable<Process> queryable1 = ((IQueryable<Process>) processes).Where<Process>(predicate);
        // ISSUE: type reference
        ParameterExpression parameterExpression3 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        // ISSUE: method reference
        Expression<Func<Process, ICollection<ProcessNode>>> expression1 = Expression.Lambda<Func<Process, ICollection<ProcessNode>>>((Expression) \u0019.\u0083((Expression) parameterExpression3, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))), parameterExpression3);
        IQueryable<Process> queryable2 = QueryableExtensions.Include<Process, ICollection<ProcessNode>>(queryable1, expression1);
        // ISSUE: type reference
        ParameterExpression parameterExpression4 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj3 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo2 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray2 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression4, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression5 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        expressionArray2[1] = (Expression) Expression.Lambda<Func<ProcessNode, StartEventNode>>((Expression) \u0019.\u0083((Expression) parameterExpression5, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_StartEventNode))), parameterExpression5);
        Expression<Func<Process, IEnumerable<StartEventNode>>> expression2 = Expression.Lambda<Func<Process, IEnumerable<StartEventNode>>>((Expression) obj3((Expression) null, methodInfo2, expressionArray2), parameterExpression4);
        IQueryable<Process> queryable3 = QueryableExtensions.Include<Process, IEnumerable<StartEventNode>>(queryable2, expression2);
        // ISSUE: type reference
        ParameterExpression parameterExpression6 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj4 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo3 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray3 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression6, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression7 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        expressionArray3[1] = (Expression) Expression.Lambda<Func<ProcessNode, EndEventNode>>((Expression) \u0019.\u0083((Expression) parameterExpression7, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_EndEventNode))), parameterExpression7);
        Expression<Func<Process, IEnumerable<EndEventNode>>> expression3 = Expression.Lambda<Func<Process, IEnumerable<EndEventNode>>>((Expression) obj4((Expression) null, methodInfo3, expressionArray3), parameterExpression6);
        IQueryable<Process> queryable4 = QueryableExtensions.Include<Process, IEnumerable<EndEventNode>>(queryable3, expression3);
        // ISSUE: type reference
        ParameterExpression parameterExpression8 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj5 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo4 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray4 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression8, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression9 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        expressionArray4[1] = (Expression) Expression.Lambda<Func<ProcessNode, UserTaskNode>>((Expression) \u0019.\u0083((Expression) parameterExpression9, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_UserTaskNode))), parameterExpression9);
        Expression<Func<Process, IEnumerable<UserTaskNode>>> expression4 = Expression.Lambda<Func<Process, IEnumerable<UserTaskNode>>>((Expression) obj5((Expression) null, methodInfo4, expressionArray4), parameterExpression8);
        IQueryable<Process> queryable5 = QueryableExtensions.Include<Process, IEnumerable<UserTaskNode>>(queryable4, expression4);
        // ISSUE: type reference
        ParameterExpression parameterExpression10 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj6 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo5 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray5 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression10, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression11 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        expressionArray5[1] = (Expression) Expression.Lambda<Func<ProcessNode, ServiceTaskNode>>((Expression) \u0019.\u0083((Expression) parameterExpression11, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_ServiceTaskNode))), parameterExpression11);
        Expression<Func<Process, IEnumerable<ServiceTaskNode>>> expression5 = Expression.Lambda<Func<Process, IEnumerable<ServiceTaskNode>>>((Expression) obj6((Expression) null, methodInfo5, expressionArray5), parameterExpression10);
        IQueryable<Process> queryable6 = QueryableExtensions.Include<Process, IEnumerable<ServiceTaskNode>>(queryable5, expression5);
        // ISSUE: type reference
        ParameterExpression parameterExpression12 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj7 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo6 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray6 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression12, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression13 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        expressionArray6[1] = (Expression) Expression.Lambda<Func<ProcessNode, JoinNode>>((Expression) \u0019.\u0083((Expression) parameterExpression13, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_JoinNode))), parameterExpression13);
        Expression<Func<Process, IEnumerable<JoinNode>>> expression6 = Expression.Lambda<Func<Process, IEnumerable<JoinNode>>>((Expression) obj7((Expression) null, methodInfo6, expressionArray6), parameterExpression12);
        IQueryable<Process> queryable7 = QueryableExtensions.Include<Process, IEnumerable<JoinNode>>(queryable6, expression6);
        // ISSUE: type reference
        ParameterExpression parameterExpression14 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj8 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo7 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray7 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression14, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression15 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        // ISSUE: method reference
        expressionArray7[1] = (Expression) Expression.Lambda<Func<ProcessNode, ICollection<JoinPreviousProcessNode>>>((Expression) \u0019.\u0083((Expression) \u0019.\u0083((Expression) parameterExpression15, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_JoinNode))), (MethodInfo) \u0018.\u0082(__methodref (JoinNode.get_PreviousProcessNodes))), parameterExpression15);
        Expression<Func<Process, IEnumerable<ICollection<JoinPreviousProcessNode>>>> expression7 = Expression.Lambda<Func<Process, IEnumerable<ICollection<JoinPreviousProcessNode>>>>((Expression) obj8((Expression) null, methodInfo7, expressionArray7), parameterExpression14);
        IQueryable<Process> queryable8 = QueryableExtensions.Include<Process, IEnumerable<ICollection<JoinPreviousProcessNode>>>(queryable7, expression7);
        // ISSUE: type reference
        ParameterExpression parameterExpression16 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj9 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo8 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray8 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression16, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression17 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        expressionArray8[1] = (Expression) Expression.Lambda<Func<ProcessNode, ForkNode>>((Expression) \u0019.\u0083((Expression) parameterExpression17, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_ForkNode))), parameterExpression17);
        Expression<Func<Process, IEnumerable<ForkNode>>> expression8 = Expression.Lambda<Func<Process, IEnumerable<ForkNode>>>((Expression) obj9((Expression) null, methodInfo8, expressionArray8), parameterExpression16);
        IQueryable<Process> queryable9 = QueryableExtensions.Include<Process, IEnumerable<ForkNode>>(queryable8, expression8);
        // ISSUE: type reference
        ParameterExpression parameterExpression18 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj10 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo9 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray9 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression18, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression19 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        // ISSUE: method reference
        expressionArray9[1] = (Expression) Expression.Lambda<Func<ProcessNode, ICollection<ForkNextProcessNode>>>((Expression) \u0019.\u0083((Expression) \u0019.\u0083((Expression) parameterExpression19, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_ForkNode))), (MethodInfo) \u0018.\u0082(__methodref (ForkNode.get_NextProcessNodes))), parameterExpression19);
        Expression<Func<Process, IEnumerable<ICollection<ForkNextProcessNode>>>> expression9 = Expression.Lambda<Func<Process, IEnumerable<ICollection<ForkNextProcessNode>>>>((Expression) obj10((Expression) null, methodInfo9, expressionArray9), parameterExpression18);
        IQueryable<Process> queryable10 = QueryableExtensions.Include<Process, IEnumerable<ICollection<ForkNextProcessNode>>>(queryable9, expression9);
        // ISSUE: type reference
        ParameterExpression parameterExpression20 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        \u0093 obj11 = \u0093.\u0002\u0002;
        // ISSUE: method reference
        MethodInfo methodInfo10 = (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Select));
        // ISSUE: method reference
        Expression[] expressionArray10 = new Expression[2]
        {
          (Expression) \u0019.\u0083((Expression) parameterExpression20, (MethodInfo) \u0018.\u0082(__methodref (Process.get_ProcessNodes))),
          null
        };
        // ISSUE: type reference
        ParameterExpression parameterExpression21 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessNode)), \u000E.\u0003.\u0001(107396070));
        // ISSUE: method reference
        expressionArray10[1] = (Expression) Expression.Lambda<Func<ProcessNode, TimerNode>>((Expression) \u0019.\u0083((Expression) parameterExpression21, (MethodInfo) \u0018.\u0082(__methodref (ProcessNode.get_TimerNode))), parameterExpression21);
        Expression<Func<Process, IEnumerable<TimerNode>>> expression10 = Expression.Lambda<Func<Process, IEnumerable<TimerNode>>>((Expression) obj11((Expression) null, methodInfo10, expressionArray10), parameterExpression20);
        IQueryable<Process> source1 = QueryableExtensions.Include<Process, IEnumerable<TimerNode>>(queryable10, expression10);
        // ISSUE: type reference
        ParameterExpression parameterExpression22 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        // ISSUE: method reference
        Expression<Func<Process, int>> keySelector1 = Expression.Lambda<Func<Process, int>>((Expression) \u0019.\u0083((Expression) parameterExpression22, (MethodInfo) \u0018.\u0082(__methodref (Process.get_VoucherKindID))), parameterExpression22);
        IOrderedQueryable<Process> source2 = source1.OrderBy<Process, int>(keySelector1);
        // ISSUE: type reference
        ParameterExpression parameterExpression23 = \u0017.\u0081(global::\u000F.\u0019(__typeref (Process)), \u000E.\u0003.\u0001(107396549));
        // ISSUE: method reference
        Expression<Func<Process, int>> keySelector2 = Expression.Lambda<Func<Process, int>>((Expression) \u0019.\u0083((Expression) parameterExpression23, (MethodInfo) \u0018.\u0082(__methodref (Process.get_Version))), parameterExpression23);
        Process[] array = QueryableExtensions.AsNoTracking<Process>((IQueryable<Process>) source2.ThenByDescending<Process, int>(keySelector2)).ToArray<Process>();
        obj0.\u0001 = new ExecutionEngine.ProcessMetadataCollection(obj0.\u0001(array));
      }
      finally
      {
        if (workflowSystemContext != null)
          global::\u0005.\u007E\u000E((object) workflowSystemContext);
      }
      \u000F.\u0005.\u0001(obj0);
    }

    static TimerNode \u0001(
      string _param0,
      string _param1,
      Process _param2,
      WorkflowSystemContext _param3)
    {
      ProcessNode processNode = \u000F.\u0005.\u0001(_param2, ProcessNodeKind.Timer, _param3, _param1);
      TimerNode timerNode = \u000E.\u0001.\u0001<TimerNode>(_param3.TimerNodes.Create());
      processNode.TimerNode = timerNode;
      timerNode.ProcessNode = processNode;
      timerNode.DelayDateTimeExpression = _param0;
      return timerNode;
    }

    static unsafe ProcessExecutionStep \u0001(ExecutionEngine _param0, [In] IExecutionContext obj1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ExecutionEngine.\u0004 obj2 = new ExecutionEngine.\u0004();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      TransactionScope transactionScope = new TransactionScope();
      try
      {
        WorkflowSystemContext workflowSystemContext = \u000F.\u0005.\u0001(_param0);
        try
        {
          try
          {
            // ISSUE: variable of a compiler-generated type
            ExecutionEngine.\u0004 obj3 = obj2;
            DbSet<ProcessExecutionStep> processExecutionSteps = workflowSystemContext.ProcessExecutionSteps;
            // ISSUE: type reference
            ParameterExpression parameterExpression = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessExecutionStep)), \u000E.\u0003.\u0001(107396549));
            // ISSUE: method reference
            // ISSUE: type reference
            // ISSUE: field reference
            // ISSUE: method reference
            // ISSUE: method reference
            Expression<Func<ProcessExecutionStep, bool>> predicate = Expression.Lambda<Func<ProcessExecutionStep, bool>>((Expression) \u001D.\u0088((Expression) \u0019.\u0083((Expression) parameterExpression, (MethodInfo) \u0018.\u0082(__methodref (ProcessExecutionStep.get_ID))), (Expression) \u0019.\u0083((Expression) \u001C.\u0087((Expression) \u001A.\u0084((object) obj2, global::\u000F.\u0019(__typeref (ExecutionEngine.\u0004))), \u001B.\u0086(__fieldref (ExecutionEngine.\u0004.\u0001))), (MethodInfo) \u0018.\u0082(__methodref (IExecutionContext.get_StepId))), false, (MethodInfo) \u0018.\u0082(__methodref (Guid.op_Equality))), parameterExpression);
            ProcessExecutionStep processExecutionStep = ((IQueryable<ProcessExecutionStep>) processExecutionSteps).Single<ProcessExecutionStep>(predicate);
            // ISSUE: reference to a compiler-generated field
            obj3.\u0001 = processExecutionStep;
          }
          catch (Exception ex)
          {
            throw new InvalidOperationException(\u000E.\u0003.\u0001(107396544), ex);
          }
          DbSet<ProcessInstance> processInstances = workflowSystemContext.ProcessInstances;
          // ISSUE: type reference
          ParameterExpression parameterExpression1 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessInstance)), \u000E.\u0003.\u0001(107396549));
          // ISSUE: method reference
          // ISSUE: type reference
          // ISSUE: field reference
          // ISSUE: method reference
          Expression<Func<ProcessInstance, bool>> predicate1 = Expression.Lambda<Func<ProcessInstance, bool>>((Expression) \u001E.\u0089((Expression) \u0019.\u0083((Expression) parameterExpression1, (MethodInfo) \u0018.\u0082(__methodref (ProcessInstance.get_ID))), (Expression) \u0019.\u0083((Expression) \u001C.\u0087((Expression) \u001A.\u0084((object) obj2, global::\u000F.\u0019(__typeref (ExecutionEngine.\u0004))), \u001B.\u0086(__fieldref (ExecutionEngine.\u0004.\u0001))), (MethodInfo) \u0018.\u0082(__methodref (ProcessExecutionStep.get_ProcessID)))), parameterExpression1);
          ProcessInstance processInstance = ((IQueryable<ProcessInstance>) processInstances).Single<ProcessInstance>(predicate1);
          if (!processInstance.Closed)
            goto label_6;
label_5:
          throw new InvalidOperationException(\u000E.\u0003.\u0001(107396523));
label_6:
          *(int*) voidPtr = processInstance.ProcessMetaDataID;
          // ISSUE: reference to a compiler-generated field
          *(int*) ((IntPtr) voidPtr + 4) = obj2.\u0001.ProcessNodeID;
          UserTaskNodeModel userTaskNodeModel;
          try
          {
            userTaskNodeModel = (UserTaskNodeModel) _param0.\u0001.\u0001(*(int*) voidPtr, *(int*) ((IntPtr) voidPtr + 4));
          }
          catch (Exception ex)
          {
            throw new InvalidOperationException(\u000E.\u0003.\u0001(107395632), ex);
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          userTaskNodeModel.\u0002(processInstance, obj2.\u0001, workflowSystemContext, obj2.\u0001);
          int num = \u001F.\u007E\u008B((object) workflowSystemContext);
          if (false)
            goto label_5;
        }
        finally
        {
          if (workflowSystemContext != null)
            global::\u0005.\u007E\u000E((object) workflowSystemContext);
        }
        global::\u0005.\u007E\u000F((object) transactionScope);
      }
      finally
      {
        if (transactionScope != null)
          global::\u0005.\u007E\u000E((object) transactionScope);
      }
      // ISSUE: reference to a compiler-generated field
      return obj2.\u0001;
    }

    static int \u0001(\u0005.\u0005.\u0002 _param0, [In] int obj1)
    {
      while (_param0.\u0003 < obj1)
      {
        if (_param0.\u0001 == _param0.\u0002)
        {
          if (true)
          {
            if (true)
              return -1;
          }
          else
            break;
        }
        else if (true)
        {
          \u0005.\u0005.\u0002 obj2 = _param0;
          int num1 = (int) _param0.\u0001;
          byte[] numArray1 = _param0.\u0001;
          \u0005.\u0005.\u0002 obj3 = _param0;
          int num2 = _param0.\u0001;
          int num3 = num2 + 1;
          obj3.\u0001 = num3;
          int index1 = num2;
          int num4 = (int) numArray1[index1] & (int) byte.MaxValue;
          byte[] numArray2 = _param0.\u0001;
          \u0005.\u0005.\u0002 obj4 = _param0;
          int num5 = _param0.\u0001;
          int num6 = num5 + 1;
          obj4.\u0001 = num6;
          int index2 = num5;
          int num7 = ((int) numArray2[index2] & (int) byte.MaxValue) << 8;
          int num8 = (num4 | num7) << _param0.\u0003;
          int num9 = num1 | num8;
          obj2.\u0001 = (uint) num9;
        }
        else
          continue;
        _param0.\u0003 += 16;
        break;
      }
      long num10 = (long) _param0.\u0001;
      int num11 = 1;
      int num12 = obj1;
      int num13;
      do
      {
        if (true)
        {
          int num14 = num12 & 31;
          num13 = num11 << num14;
          if (true)
          {
            num12 = 1;
            num11 = num13;
          }
          else
            goto label_5;
        }
      }
      while (num12 == 0);
      int num15 = num11 - num12;
      goto label_13;
label_5:
      num15 = num13;
label_13:
      long num16 = (long) num15;
      return (int) (num10 & num16);
    }

    static unsafe byte[] \u0001(byte[] _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(46);
      Assembly callingAssembly = Assembly.GetCallingAssembly();
      Assembly executingAssembly = Assembly.GetExecutingAssembly();
      if ((object) callingAssembly != (object) executingAssembly && !\u000F.\u0005.\u0001(callingAssembly, executingAssembly))
        return (byte[]) null;
      \u0005.\u0005.\u000F obj1 = new \u0005.\u0005.\u000F(_param0);
      byte[] numArray1 = new byte[0];
      *(int*) voidPtr = \u000F.\u0005.\u0001(obj1);
      int num1 = *(int*) voidPtr;
      if (true)
      {
        if (num1 == 67324752)
        {
          *(short*) ((IntPtr) voidPtr + 44) = (short) \u000F.\u0005.\u0001(obj1);
          *(int*) ((IntPtr) voidPtr + 4) = \u000F.\u0005.\u0001(obj1);
          *(int*) ((IntPtr) voidPtr + 8) = \u000F.\u0005.\u0001(obj1);
          if (*(int*) voidPtr != 67324752 || *(short*) ((IntPtr) voidPtr + 44) != (short) 20 || *(int*) ((IntPtr) voidPtr + 4) != 0 || *(int*) ((IntPtr) voidPtr + 8) != 8)
            throw new FormatException("Wrong Header Signature");
          int num2 = \u000F.\u0005.\u0001(obj1);
          if (true)
          {
            \u000F.\u0005.\u0001(obj1);
            \u000F.\u0005.\u0001(obj1);
            *(int*) ((IntPtr) voidPtr + 12) = \u000F.\u0005.\u0001(obj1);
            *(int*) ((IntPtr) voidPtr + 16) = \u000F.\u0005.\u0001(obj1);
            *(int*) ((IntPtr) voidPtr + 20) = \u000F.\u0005.\u0001(obj1);
            if (*(int*) ((IntPtr) voidPtr + 16) > 0)
            {
              byte[] buffer = new byte[*(int*) ((IntPtr) voidPtr + 16)];
              obj1.Read(buffer, 0, *(int*) ((IntPtr) voidPtr + 16));
            }
            if (*(int*) ((IntPtr) voidPtr + 20) > 0)
            {
              byte[] buffer = new byte[*(int*) ((IntPtr) voidPtr + 20)];
              if (true)
                obj1.Read(buffer, 0, *(int*) ((IntPtr) voidPtr + 20));
              else
                goto label_28;
            }
          }
          else
          {
            num1 = num2;
            goto label_18;
          }
        }
        else
          goto label_13;
label_12:
        byte[] buffer1 = new byte[obj1.Length - obj1.Position];
        obj1.Read(buffer1, 0, buffer1.Length);
        \u0005.\u0005.\u0001 obj2 = new \u0005.\u0005.\u0001(buffer1);
        numArray1 = new byte[*(int*) ((IntPtr) voidPtr + 12)];
        \u0005.\u0005.\u0001 obj3 = obj2;
        byte[] numArray2 = numArray1;
        *(int*) ((IntPtr) voidPtr + 40) = numArray1.Length;
        \u000F.\u0005.\u0001(*(int*) ((IntPtr) voidPtr + 40), numArray2, 0, obj3);
        goto label_34;
label_13:
        *(int*) ((IntPtr) voidPtr + 24) = *(int*) voidPtr >> 24;
        *(int*) voidPtr = *(int*) voidPtr - (*(int*) ((IntPtr) voidPtr + 24) << 24);
        if (*(int*) voidPtr != 8223355)
          throw new FormatException("Unknown Header");
        if (*(int*) ((IntPtr) voidPtr + 24) == 1)
        {
          if (true)
          {
            *(int*) ((IntPtr) voidPtr + 28) = \u000F.\u0005.\u0001(obj1);
            numArray1 = new byte[*(int*) ((IntPtr) voidPtr + 28)];
            *(int*) ((IntPtr) voidPtr + 32) = 0;
            goto label_19;
          }
          else
            goto label_12;
        }
        else
          goto label_20;
      }
label_18:
      *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) + *(int*) ((IntPtr) voidPtr + 36);
label_19:
      if (*(int*) ((IntPtr) voidPtr + 32) < *(int*) ((IntPtr) voidPtr + 28))
      {
        int length = \u000F.\u0005.\u0001(obj1);
        *(int*) ((IntPtr) voidPtr + 36) = \u000F.\u0005.\u0001(obj1);
        byte[] buffer = new byte[length];
        obj1.Read(buffer, 0, buffer.Length);
        num1 = \u000F.\u0005.\u0001(*(int*) ((IntPtr) voidPtr + 36), numArray1, *(int*) ((IntPtr) voidPtr + 32), new \u0005.\u0005.\u0001(buffer));
        goto label_18;
      }
label_20:
      if (*(int*) ((IntPtr) voidPtr + 24) == 2)
      {
        using (ICryptoTransform cryptoTransform = \u000F.\u0005.\u0001(true, new byte[8]
        {
          (byte) 78,
          (byte) 171,
          (byte) 47,
          (byte) 30,
          (byte) 213,
          (byte) 211,
          (byte) 142,
          (byte) 236
        }, new byte[8]
        {
          (byte) 233,
          (byte) 124,
          (byte) 64,
          (byte) 172,
          (byte) 117,
          (byte) 90,
          (byte) 15,
          (byte) 19
        }))
          numArray1 = \u000F.\u0005.\u0001(cryptoTransform.TransformFinalBlock(_param0, 4, _param0.Length - 4));
      }
      byte[] numArray3;
      if (*(int*) ((IntPtr) voidPtr + 24) == 3)
        numArray3 = new byte[16]
        {
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1
        };
      else
        goto label_34;
label_28:
      using (ICryptoTransform cryptoTransform = \u000F.\u0005.\u0001(true, new byte[16]
      {
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 2
      }, numArray3))
        numArray1 = \u000F.\u0005.\u0001(cryptoTransform.TransformFinalBlock(_param0, 4, _param0.Length - 4));
label_34:
      obj1.Close();
      return numArray1;
    }

    static byte[] \u0001(byte[] _param0) => \u000F.\u0005.\u0001((byte[]) null, (byte[]) null, 1, _param0);

    static short \u0001(int _param0)
    {
      return (short) ((int) \u0005.\u0005.\u0007.\u0001[_param0 & 15] << 12 | (int) \u0005.\u0005.\u0007.\u0001[_param0 >> 4 & 15] << 8 | (int) \u0005.\u0005.\u0007.\u0001[_param0 >> 8 & 15] << 4 | (int) \u0005.\u0005.\u0007.\u0001[_param0 >> 12]);
    }

    static ProcessExecutionStep[] \u0001(
      JoinNodeModel _param0,
      WorkflowSystemContext _param1_1,
      [In] ProcessExecutionStep obj2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      JoinNodeModel.\u0005 obj = new JoinNodeModel.\u0005();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = obj2;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = _param0.PreviousProcessNodes.Select<ProcessNodeModel, int>((Func<ProcessNodeModel, int>) (_param1_2 => _param1_2.ID)).ToArray<int>();
      List<ProcessExecutionStep> source = \u000F.\u0005.\u0001(obj, \u0094.\u007E\u0003\u0002((object) _param1_1).Entries<ProcessExecutionStep>().Select<DbEntityEntry<ProcessExecutionStep>, ProcessExecutionStep>((Func<DbEntityEntry<ProcessExecutionStep>, ProcessExecutionStep>) (_param1_3 => _param1_3.Entity)).AsQueryable<ProcessExecutionStep>(), new Guid[0]);
      source.AddRange((IEnumerable<ProcessExecutionStep>) \u000F.\u0005.\u0001(obj, (IQueryable<ProcessExecutionStep>) _param1_1.ProcessExecutionSteps, source.Select<ProcessExecutionStep, Guid>((Func<ProcessExecutionStep, Guid>) (_param1_4 => _param1_4.ID)).ToArray<Guid>()));
      return source.ToArray();
    }

    static ProcessExecutionStep \u0001(
      ProcessNodeModel.\u0002 _param0,
      [In] IQueryable<ProcessExecutionStep> obj1)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return obj1.SingleOrDefault<ProcessExecutionStep>((Expression<Func<ProcessExecutionStep, bool>>) (processExecutionStep => processExecutionStep.ProcessID == _param0.\u0001.ID && processExecutionStep.ProcessNodeID == _param0.\u0001.ID && (_param0.\u0001 == new Guid?() || _param0.\u0001.HasValue && (Guid?) processExecutionStep.PathID == _param0.\u0001)));
    }

    static void \u0001(
      int _param0,
      bool _param1,
      int _param2,
      \u0005.\u0005.\u0007 _param3,
      [In] byte[] obj4)
    {
      \u000F.\u0005.\u0001(_param3.\u0001, _param1 ? 1 : 0, 3);
      \u000F.\u0005.\u0001(_param3.\u0001);
      \u000F.\u0005.\u0001(_param3.\u0001, _param2);
      \u000F.\u0005.\u0001(_param3.\u0001, ~_param2);
      \u000F.\u0005.\u0001(_param2, _param3.\u0001, _param0, obj4);
      \u000F.\u0005.\u0001(_param3);
    }

    static void \u0001([In] \u0005.\u0005.\u0008 obj0)
    {
label_0:
      int num1 = obj0.\u0014;
      int num2 = 65274;
      if (num2 != 0)
      {
        if (num1 >= num2)
        {
          \u000F.\u0005.\u0001(obj0);
          goto label_11;
        }
        else
          goto label_11;
      }
      else
        goto label_14;
label_10:
      int length;
      obj0.\u0016 += length;
      obj0.\u0015 += length;
label_11:
      if (obj0.\u0015 >= 262)
        goto label_15;
label_12:
      int num3 = obj0.\u0017;
      if (true)
      {
        num2 = obj0.\u0018;
        num1 = num3;
      }
      else
        goto label_19;
label_14:
      if (num1 < num2)
      {
        if (true)
        {
          num3 = 65536 - obj0.\u0015 - obj0.\u0014;
          goto label_19;
        }
        else
          goto label_10;
      }
label_15:
      if (true)
      {
        if (obj0.\u0015 < 3)
          return;
        \u000F.\u0005.\u0001(obj0);
        return;
      }
      goto label_12;
label_19:
      length = num3;
      if (length > obj0.\u0018 - obj0.\u0017)
      {
        int num4 = obj0.\u0018;
        int num5 = obj0.\u0017;
        if (true)
        {
          length = num4 - num5;
        }
        else
        {
          num2 = num5;
          num1 = num4;
          goto label_14;
        }
      }
      Array.Copy((Array) obj0.\u0002, obj0.\u0017, (Array) obj0.\u0001, obj0.\u0014 + obj0.\u0015, length);
      if (true)
      {
        obj0.\u0017 += length;
        goto label_10;
      }
      else
        goto label_0;
    }

    static int \u0001(\u0005.\u0005.\u000E _param0, byte[] _param1, int _param2, [In] int obj3)
    {
      int num1 = _param0.\u0003;
      int num2 = 8;
      int num3;
      int num4;
      while (true)
      {
        if (num1 >= num2)
          goto label_8;
label_3:
        if (obj3 > _param0.\u0002 - _param0.\u0001)
        {
          num3 = _param0.\u0002;
          num4 = _param0.\u0001;
          if (false)
          {
            num2 = num4;
            num1 = num3;
            continue;
          }
          break;
        }
        goto label_6;
label_8:
        byte[] numArray = _param0.\u0001;
        \u0005.\u0005.\u000E obj = _param0;
        int num5 = _param0.\u0002;
        int num6 = num5 + 1;
        obj.\u0002 = num6;
        int index = num5;
        int num7 = (int) (byte) _param0.\u0001;
        numArray[index] = (byte) num7;
        if (true)
        {
          _param0.\u0001 >>= 8;
          _param0.\u0003 -= 8;
          goto label_3;
        }
        else
          goto label_7;
      }
      obj3 = num3 - num4;
      Array.Copy((Array) _param0.\u0001, _param0.\u0001, (Array) _param1, _param2, obj3);
      _param0.\u0001 = 0;
      _param0.\u0002 = 0;
      goto label_7;
label_6:
      Array.Copy((Array) _param0.\u0001, _param0.\u0001, (Array) _param1, _param2, obj3);
      _param0.\u0001 += obj3;
label_7:
      return obj3;
    }

    static void \u0001([In] ExecutionEngine.SchedulerEngine obj0)
    {
      while (true)
      {
        obj0.\u0001 = 0;
        if (false)
          break;
        obj0.\u0001 = false;
        if (true)
          goto label_7;
label_3:
        if (true)
        {
          global::\u0005.\u007E\u0012((object) obj0.\u0001);
          break;
        }
        continue;
label_7:
        obj0.\u0002 = false;
        goto label_3;
      }
    }

    static JoinNode \u0001(Process _param0, WorkflowSystemContext _param1, string _param2)
    {
      JoinNode joinNode;
      ProcessNode processNode;
      do
      {
        if (true)
          goto label_4;
label_2:
        continue;
label_4:
        processNode = \u000F.\u0005.\u0001(_param0, ProcessNodeKind.JoinNode, _param1, _param2);
        if (true)
          goto label_5;
label_1:
        processNode.JoinNode = joinNode;
        goto label_2;
label_5:
        joinNode = \u000E.\u0001.\u0001<JoinNode>(_param1.JoinNodes.Create());
        goto label_1;
      }
      while (false);
      joinNode.ProcessNode = processNode;
      return joinNode;
    }

    static \u0005.\u0005.\u0004 \u0001([In] \u0005.\u0005.\u0005 obj0)
    {
      byte[] destinationArray = new byte[obj0.\u000E];
      Array.Copy((Array) obj0.\u0002, obj0.\u0008, (Array) destinationArray, 0, obj0.\u000E);
      return new \u0005.\u0005.\u0004(destinationArray);
    }

    static byte[] \u0001(byte[] _param0, byte[] _param1, byte[] _param2)
    {
      return \u000F.\u0005.\u0001(_param0, _param1, 3, _param2);
    }

    static int \u0001([In] \u0005.\u0005.\u000F obj0)
    {
      return \u000F.\u0005.\u0001(obj0) | \u000F.\u0005.\u0001(obj0) << 16;
    }

    static void \u0001(\u0005.\u0005.\u000F _param0, [In] int obj1)
    {
      \u000F.\u0005.\u0001(_param0, obj1);
      \u000F.\u0005.\u0001(_param0, obj1 >> 16);
    }

    static StartEventNode \u0001(Process _param0, string _param1, WorkflowSystemContext _param2)
    {
      StartEventNode startEventNode;
      ProcessNode processNode;
      do
      {
        if (true)
          goto label_4;
label_2:
        continue;
label_4:
        processNode = \u000F.\u0005.\u0001(_param0, ProcessNodeKind.StartEventNode, _param2, _param1);
        if (true)
          goto label_5;
label_1:
        processNode.StartEventNode = startEventNode;
        goto label_2;
label_5:
        startEventNode = \u000E.\u0001.\u0001<StartEventNode>(_param2.StartEventNodes.Create());
        goto label_1;
      }
      while (false);
      startEventNode.ProcessNode = processNode;
      return startEventNode;
    }

    static void \u0001([In] ExecutionEngine.SchedulerEngine obj0)
    {
      if (obj0.\u0001.Count <= 0)
        return;
      obj0.\u0001?.BeginInvoke(obj0.\u0001.\u0001, (AsyncCallback) (_param1 => { }), (object) null);
    }

    static void \u0001(\u0005.\u0005.\u0007.\u0001 _param0, [In] int obj1)
    {
      \u000F.\u0005.\u0001(_param0.\u0001.\u0001, (int) _param0.\u0002[obj1] & (int) ushort.MaxValue, (int) _param0.\u0001[obj1]);
    }

    static void \u0001(\u0005.\u0005.\u000E _param0, [In] int obj1)
    {
      byte[] numArray1 = _param0.\u0001;
      \u0005.\u0005.\u000E obj2 = _param0;
      int num1 = _param0.\u0002;
      int num2 = num1 + 1;
      obj2.\u0002 = num2;
      int index1 = num1;
      int num3 = (int) (byte) obj1;
      numArray1[index1] = (byte) num3;
      byte[] numArray2 = _param0.\u0001;
      \u0005.\u0005.\u000E obj3 = _param0;
      int num4 = _param0.\u0002;
      int num5 = num4 + 1;
      obj3.\u0002 = num5;
      int index2 = num4;
      int num6 = (int) (byte) (obj1 >> 8);
      numArray2[index2] = (byte) num6;
    }

    static int \u0001(\u0005.\u0005.\u0007 _param0, [In] int obj1)
    {
      int num1;
      do
      {
        if (true)
          goto label_10;
label_1:
        continue;
label_10:
        num1 = 0;
        goto label_1;
      }
      while (false);
      int num2;
      while (true)
      {
        int num3 = obj1;
        int num4 = 4;
        int num5;
        int num6;
        while (true)
        {
          if (num3 >= num4)
            goto label_11;
          else
            goto label_13;
label_4:
          num6 = 1;
          int num7;
          num5 = num7;
label_5:
          if (num6 == 0)
          {
            num4 = num6;
            num3 = num5;
            continue;
          }
          break;
label_11:
          num5 = num1;
          num6 = 2;
          if (num6 != 0)
          {
            num1 = num5 + num6;
            num7 = obj1;
            goto label_4;
          }
          else
            goto label_5;
label_13:
          num2 = num1 + obj1;
          if (false)
          {
            num7 = num2;
            goto label_4;
          }
          else
            goto label_9;
        }
        obj1 = num5 >> num6;
      }
label_9:
      return num2;
    }

    static unsafe bool \u0001([In] \u0005.\u0005.\u0001 obj0)
    {
      int num1 = 12;
      int num2;
      if (num1 != 0)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(num1);
        *(int*) ((IntPtr) voidPtr + 4) = obj0.\u0013;
        int num3;
        int num4;
        do
        {
          switch (*(int*) ((IntPtr) voidPtr + 4))
          {
            case 2:
              num3 = obj0.\u0001 ? 1 : 0;
              if (true)
              {
                if (num3 == 0)
                {
                  *(int*) voidPtr = \u000F.\u0005.\u0001(obj0.\u0001, 3);
                  if (*(int*) voidPtr >= 0)
                  {
                    \u000F.\u0005.\u0001(obj0.\u0001, 3);
                    num4 = *(int*) voidPtr;
                    if (true)
                    {
                      if ((num4 & 1) != 0)
                        continue;
                      goto label_9;
                    }
                    else
                      goto label_27;
                  }
                  else
                    goto label_4;
                }
                else
                  goto label_39;
              }
              else
                goto label_15;
            case 3:
              goto label_18;
            case 4:
              goto label_22;
            case 5:
              goto label_26;
            case 6:
              goto label_30;
            case 7:
            case 8:
            case 9:
            case 10:
              goto label_33;
            case 12:
              goto label_34;
            default:
              goto label_36;
          }
        }
        while (false);
        goto label_8;
label_15:
        return num3 != 0;
label_4:
        return false;
label_8:
        obj0.\u0001 = true;
label_9:
        num2 = *(int*) voidPtr >> 1;
        goto label_10;
label_18:
        int num5 = obj0.\u0017 = \u000F.\u0005.\u0001(obj0.\u0001, 16);
label_19:
        if (num5 < 0)
          return false;
        \u000F.\u0005.\u0001(obj0.\u0001, 16);
        obj0.\u0013 = 4;
label_22:
        int num6 = \u000F.\u0005.\u0001(obj0.\u0001, 16);
        if (false)
        {
          num5 = num6;
          goto label_19;
        }
        else
        {
          if (num6 < 0)
            return false;
          \u000F.\u0005.\u0001(obj0.\u0001, 16);
          obj0.\u0013 = 5;
        }
label_26:
        *(int*) ((IntPtr) voidPtr + 8) = \u000F.\u0005.\u0001(obj0.\u0001, obj0.\u0001, obj0.\u0017);
        obj0.\u0017 -= *(int*) ((IntPtr) voidPtr + 8);
        num4 = obj0.\u0017;
label_27:
        if (num4 != 0)
          return !obj0.\u0001.IsNeedingInput;
        obj0.\u0013 = 2;
        return true;
label_30:
        if (!\u000F.\u0005.\u0001(obj0.\u0001, obj0.\u0001))
          return false;
        obj0.\u0001 = \u000F.\u0005.\u0001(obj0.\u0001);
        obj0.\u0002 = \u000F.\u0005.\u0001(obj0.\u0001);
        obj0.\u0013 = 7;
label_33:
        return \u000F.\u0005.\u0001(obj0);
label_34:
        if (true)
          return false;
        goto label_17;
label_36:
        return false;
label_39:
        obj0.\u0013 = 12;
        return false;
      }
      goto label_11;
label_10:
      num1 = num2;
label_11:
      switch (num1)
      {
        case 0:
          \u000F.\u0005.\u0001(obj0.\u0001);
          if (true)
          {
            obj0.\u0013 = 3;
            break;
          }
          goto label_10;
        case 1:
          obj0.\u0001 = \u0005.\u0005.\u0004.\u0001;
          obj0.\u0002 = \u0005.\u0005.\u0004.\u0002;
          obj0.\u0013 = 7;
          break;
        case 2:
          obj0.\u0001 = new \u0005.\u0005.\u0005();
          obj0.\u0013 = 6;
          break;
      }
label_17:
      return true;
    }

    static unsafe TimerNodeModel.TimerInfo \u0001(string _param0)
    {
      int num1 = 8;
      TimerNodeModel.TimerInfo timerInfo;
      while (true)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(num1);
        if (!\u0012.\u001C(_param0))
        {
          if (true)
            goto label_37;
label_17:
          string str1;
          string str2;
          if (*(uint*) ((IntPtr) voidPtr + 4) == 2605144048U && \u0096.\u0005\u0002(str1, \u000E.\u0003.\u0001(107395671)))
            timerInfo.WorkflowData = \u0098.\u0007\u0002(str2);
label_34:
          *(int*) voidPtr = *(int*) voidPtr + 1;
label_35:
          string[] strArray1;
          if (*(int*) voidPtr < strArray1.Length)
          {
            string[] strArray2 = \u0095.\u007E\u0004\u0002((object) strArray1[*(int*) voidPtr], new char[1]
            {
              '='
            });
            str1 = strArray2[0];
            str2 = strArray2[1];
            if (str1 != null)
            {
              *(int*) ((IntPtr) voidPtr + 4) = (int) \u000F.\u0005.\u0001(str1);
              if (true)
              {
                if (*(uint*) ((IntPtr) voidPtr + 4) <= 1416640973U)
                {
                  if (*(uint*) ((IntPtr) voidPtr + 4) <= 481804913U)
                  {
                    if (*(uint*) ((IntPtr) voidPtr + 4) != 426148930U)
                    {
                      if (*(uint*) ((IntPtr) voidPtr + 4) == 481804913U && \u0096.\u0005\u0002(str1, \u000E.\u0003.\u0001(107395764)))
                      {
                        timerInfo.CompanyId = \u0098.\u0007\u0002(str2);
                        goto label_34;
                      }
                      else
                        goto label_34;
                    }
                    else if (\u0096.\u0005\u0002(str1, \u000E.\u0003.\u0001(107395641)))
                    {
                      timerInfo.StepId = \u0099.\u000E\u0002(str2);
                      goto label_34;
                    }
                    else
                      goto label_34;
                  }
                  else
                  {
                    int num2 = (int) *(uint*) ((IntPtr) voidPtr + 4);
                    int num3;
                    for (int index = 1084015935; num2 != index; num2 = num3)
                    {
                      num3 = (int) *(uint*) ((IntPtr) voidPtr + 4);
                      int num4 = 1416640973;
                      if (num4 == 0)
                        index = num4;
                      else if (num3 == num4 && \u0096.\u0005\u0002(str1, \u000E.\u0003.\u0001(107395753)))
                      {
                        timerInfo.DelayDateTime = \u0097.\u0006\u0002(str2, (IFormatProvider) \u0086.\u0093());
                        goto label_34;
                      }
                      else
                        goto label_34;
                    }
                    int num5 = \u0096.\u0005\u0002(str1, \u000E.\u0003.\u0001(107395719)) ? 1 : 0;
                    if (false)
                    {
                      num1 = num5;
                      continue;
                    }
                    if (num5 != 0)
                    {
                      timerInfo.UserId = \u0098.\u0007\u0002(str2);
                      goto label_34;
                    }
                    else
                      goto label_34;
                  }
                }
                else if (*(uint*) ((IntPtr) voidPtr + 4) <= 2605144048U)
                {
                  if (*(uint*) ((IntPtr) voidPtr + 4) == 1865422512U)
                  {
                    if (\u0096.\u0005\u0002(str1, \u000E.\u0003.\u0001(107395700)))
                    {
                      timerInfo.WorkflowVoucherKind = \u0098.\u0007\u0002(str2);
                      goto label_34;
                    }
                    else
                      goto label_34;
                  }
                  else
                    goto label_17;
                }
                else if (*(uint*) ((IntPtr) voidPtr + 4) != 2655737563U)
                {
                  if (*(uint*) ((IntPtr) voidPtr + 4) == 3770499619U && \u0096.\u0005\u0002(str1, \u000E.\u0003.\u0001(107395693)))
                  {
                    timerInfo.WorkflowVoucherID = \u0098.\u0007\u0002(str2);
                    goto label_34;
                  }
                  else
                    goto label_34;
                }
                else if (\u0096.\u0005\u0002(str1, \u000E.\u0003.\u0001(107395742)))
                {
                  timerInfo.FiscalYearId = \u0098.\u0007\u0002(str2);
                  goto label_34;
                }
                else
                  goto label_34;
              }
              else
                goto label_34;
            }
            else
              goto label_34;
          }
          else
            goto label_36;
label_37:
          timerInfo = new TimerNodeModel.TimerInfo();
          strArray1 = \u0095.\u007E\u0004\u0002((object) _param0, new char[1]
          {
            ','
          });
          *(int*) voidPtr = 0;
          goto label_35;
        }
        else
          break;
      }
      return (TimerNodeModel.TimerInfo) null;
label_36:
      return timerInfo;
    }

    static unsafe uint \u0001(string _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      if (_param0 != null)
        goto label_3;
label_2:
      return *(uint*) voidPtr;
label_3:
      *(int*) voidPtr = -2128831035;
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (*(int*) ((IntPtr) voidPtr + 4) < \u001F.\u007E\u008C((object) _param0))
      {
        *(int*) voidPtr = ((int) \u009A.\u007E\u000F\u0002((object) _param0, *(int*) ((IntPtr) voidPtr + 4)) ^ (int) *(uint*) voidPtr) * 16777619;
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
      }
      goto label_2;
    }

    static void \u0001(ProcessNode _param0, [In] ProcessModel obj1)
    {
      obj1.StartEventNode.\u0001(_param0);
    }

    static UserTaskNode \u0001(
      bool _param0,
      Process _param1,
      UserTaskRegistrationType _param2,
      WorkflowSystemContext _param3,
      string _param4)
    {
      ProcessNode processNode = \u000F.\u0005.\u0001(_param1, ProcessNodeKind.UserTaskNode, _param3, _param4);
      if (true)
        goto label_2;
label_1:
      UserTaskNode userTaskNode;
      return userTaskNode;
label_2:
      userTaskNode = \u000E.\u0001.\u0001<UserTaskNode>(_param3.UserTaskNodes.Create());
      processNode.UserTaskNode = userTaskNode;
      userTaskNode.ProcessNode = processNode;
      userTaskNode.RegistrationTypeID = (int) _param2;
      userTaskNode.IsStartTask = _param0;
      goto label_1;
    }

    static unsafe int \u0001(\u0005.\u0005.\u0002 _param0, byte[] _param1, int _param2, [In] int obj3)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
      *(int*) voidPtr = 0;
      while (_param0.\u0003 > 0 && obj3 > 0)
      {
        _param1[_param2++] = (byte) _param0.\u0001;
        _param0.\u0001 >>= 8;
        _param0.\u0003 -= 8;
        --obj3;
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
      if (obj3 == 0)
        return *(int*) voidPtr;
      *(int*) ((IntPtr) voidPtr + 4) = _param0.\u0002 - _param0.\u0001;
      if (obj3 > *(int*) ((IntPtr) voidPtr + 4))
        obj3 = *(int*) ((IntPtr) voidPtr + 4);
      Array.Copy((Array) _param0.\u0001, _param0.\u0001, (Array) _param1, _param2, obj3);
      _param0.\u0001 += obj3;
      if ((_param0.\u0001 - _param0.\u0002 & 1) != 0)
      {
        \u0005.\u0005.\u0002 obj1 = _param0;
        byte[] numArray = _param0.\u0001;
        \u0005.\u0005.\u0002 obj2 = _param0;
        *(int*) ((IntPtr) voidPtr + 8) = _param0.\u0001;
        int num1 = *(int*) ((IntPtr) voidPtr + 8) + 1;
        obj2.\u0001 = num1;
        int index = *(int*) ((IntPtr) voidPtr + 8);
        int num2 = (int) numArray[index] & (int) byte.MaxValue;
        obj1.\u0001 = (uint) num2;
        _param0.\u0003 = 8;
      }
      return *(int*) voidPtr + obj3;
    }

    static EndEventNode \u0001(string _param0, WorkflowSystemContext _param1, Process _param2)
    {
      EndEventNode endEventNode;
      ProcessNode processNode;
      do
      {
        if (true)
          goto label_4;
label_2:
        continue;
label_4:
        processNode = \u000F.\u0005.\u0001(_param2, ProcessNodeKind.EndEventNode, _param1, _param0);
        if (true)
          goto label_5;
label_1:
        processNode.EndEventNode = endEventNode;
        goto label_2;
label_5:
        endEventNode = \u000E.\u0001.\u0001<EndEventNode>(_param1.EndEventNodes.Create());
        goto label_1;
      }
      while (false);
      endEventNode.ProcessNode = processNode;
      return endEventNode;
    }

    static unsafe void \u0001(byte[] _param0, [In] \u0005.\u0005.\u0004 obj1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(64);
      int[] numArray1 = new int[16];
      int[] numArray2 = new int[16];
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      while (*(int*) ((IntPtr) voidPtr + 12) < _param0.Length)
      {
        *(int*) ((IntPtr) voidPtr + 16) = (int) _param0[*(int*) ((IntPtr) voidPtr + 12)];
        if (*(int*) ((IntPtr) voidPtr + 16) > 0)
          goto label_27;
label_1:
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
        continue;
label_27:
        ++numArray1[*(int*) ((IntPtr) voidPtr + 16)];
        goto label_1;
      }
      *(int*) voidPtr = 0;
      *(int*) ((IntPtr) voidPtr + 4) = 512;
      *(int*) ((IntPtr) voidPtr + 20) = 1;
      while (*(int*) ((IntPtr) voidPtr + 20) <= 15)
      {
        numArray2[*(int*) ((IntPtr) voidPtr + 20)] = *(int*) voidPtr;
        *(int*) voidPtr = *(int*) voidPtr + (numArray1[*(int*) ((IntPtr) voidPtr + 20)] << 16 - *(int*) ((IntPtr) voidPtr + 20));
        if (*(int*) ((IntPtr) voidPtr + 20) >= 10)
        {
          *(int*) ((IntPtr) voidPtr + 24) = numArray2[*(int*) ((IntPtr) voidPtr + 20)] & 130944;
          *(int*) ((IntPtr) voidPtr + 28) = *(int*) voidPtr & 130944;
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + (*(int*) ((IntPtr) voidPtr + 28) - *(int*) ((IntPtr) voidPtr + 24) >> 16 - *(int*) ((IntPtr) voidPtr + 20));
        }
        *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
      }
      obj1.\u0001 = new short[*(int*) ((IntPtr) voidPtr + 4)];
      *(int*) ((IntPtr) voidPtr + 8) = 512;
      *(int*) ((IntPtr) voidPtr + 32) = 15;
      while (*(int*) ((IntPtr) voidPtr + 32) >= 10)
      {
        *(int*) ((IntPtr) voidPtr + 36) = *(int*) voidPtr & 130944;
        *(int*) voidPtr = *(int*) voidPtr - (numArray1[*(int*) ((IntPtr) voidPtr + 32)] << 16 - *(int*) ((IntPtr) voidPtr + 32));
        *(int*) ((IntPtr) voidPtr + 40) = *(int*) voidPtr & 130944;
        while (*(int*) ((IntPtr) voidPtr + 40) < *(int*) ((IntPtr) voidPtr + 36))
        {
          obj1.\u0001[(int) \u000F.\u0005.\u0001(*(int*) ((IntPtr) voidPtr + 40))] = (short) (-*(int*) ((IntPtr) voidPtr + 8) << 4 | *(int*) ((IntPtr) voidPtr + 32));
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + (1 << *(int*) ((IntPtr) voidPtr + 32) - 9);
          *(int*) ((IntPtr) voidPtr + 40) = *(int*) ((IntPtr) voidPtr + 40) + 128;
        }
        *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) - 1;
      }
      *(int*) ((IntPtr) voidPtr + 44) = 0;
      while (*(int*) ((IntPtr) voidPtr + 44) < _param0.Length)
      {
        *(int*) ((IntPtr) voidPtr + 48) = (int) _param0[*(int*) ((IntPtr) voidPtr + 44)];
        if (*(int*) ((IntPtr) voidPtr + 48) != 0)
        {
          *(int*) voidPtr = numArray2[*(int*) ((IntPtr) voidPtr + 48)];
          do
          {
            *(int*) ((IntPtr) voidPtr + 52) = (int) \u000F.\u0005.\u0001(*(int*) voidPtr);
            if (*(int*) ((IntPtr) voidPtr + 48) <= 9)
            {
              do
              {
                obj1.\u0001[*(int*) ((IntPtr) voidPtr + 52)] = (short) (*(int*) ((IntPtr) voidPtr + 44) << 4 | *(int*) ((IntPtr) voidPtr + 48));
                *(int*) ((IntPtr) voidPtr + 52) = *(int*) ((IntPtr) voidPtr + 52) + (1 << *(int*) ((IntPtr) voidPtr + 48));
              }
              while (*(int*) ((IntPtr) voidPtr + 52) < 512);
            }
            else
            {
              *(int*) ((IntPtr) voidPtr + 56) = (int) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 52) & 511];
              *(int*) ((IntPtr) voidPtr + 60) = 1 << (*(int*) ((IntPtr) voidPtr + 56) & 15);
              *(int*) ((IntPtr) voidPtr + 56) = -(*(int*) ((IntPtr) voidPtr + 56) >> 4);
              do
              {
                obj1.\u0001[*(int*) ((IntPtr) voidPtr + 56) | *(int*) ((IntPtr) voidPtr + 52) >> 9] = (short) (*(int*) ((IntPtr) voidPtr + 44) << 4 | *(int*) ((IntPtr) voidPtr + 48));
                *(int*) ((IntPtr) voidPtr + 52) = *(int*) ((IntPtr) voidPtr + 52) + (1 << *(int*) ((IntPtr) voidPtr + 48));
              }
              while (*(int*) ((IntPtr) voidPtr + 52) < *(int*) ((IntPtr) voidPtr + 60));
            }
          }
          while (false);
          numArray2[*(int*) ((IntPtr) voidPtr + 48)] = *(int*) voidPtr + (1 << 16 - *(int*) ((IntPtr) voidPtr + 48));
        }
        *(int*) ((IntPtr) voidPtr + 44) = *(int*) ((IntPtr) voidPtr + 44) + 1;
      }
    }

    static unsafe bool \u0001(bool _param0, \u0005.\u0005.\u0008 _param1, [In] bool obj2)
    {
      void* voidPtr;
      if (true)
      {
        // ISSUE: untyped stack allocation
        IntPtr num = __untypedstackalloc(24);
        if (true)
          voidPtr = (void*) num;
        if (_param1.\u0015 < 262 && !_param0)
          return false;
        goto label_29;
      }
      else
        goto label_13;
label_10:
      if (\u000F.\u0005.\u0001(*(int*) ((IntPtr) voidPtr + 4), _param1) && _param1.\u0012 <= 5 && _param1.\u0012 == 3 && _param1.\u0014 - _param1.\u0011 > 4096)
        _param1.\u0012 = 2;
label_12:
      int num1;
      if (num1 < 3)
        goto label_20;
label_13:
      if (_param1.\u0012 <= num1)
      {
        \u0005.\u0005.\u0007 obj = _param1.\u0001;
        if (true)
        {
          *(int*) ((IntPtr) voidPtr + 16) = _param1.\u0014 - 1 - *(int*) voidPtr;
          \u000F.\u0005.\u0001(num1, *(int*) ((IntPtr) voidPtr + 16), obj);
          int num2 = num1 - 2;
          do
          {
            ++_param1.\u0014;
            --_param1.\u0015;
            if (_param1.\u0015 >= 3)
              \u000F.\u0005.\u0001(_param1);
          }
          while (--num2 > 0);
          ++_param1.\u0014;
          --_param1.\u0015;
          _param1.\u0001 = false;
          _param1.\u0012 = 2;
          goto label_23;
        }
        else
          goto label_10;
      }
label_20:
      if (_param1.\u0001)
        \u000F.\u0005.\u0001(_param1.\u0001, (int) _param1.\u0001[_param1.\u0014 - 1] & (int) byte.MaxValue);
      _param1.\u0001 = true;
      ++_param1.\u0014;
      --_param1.\u0015;
label_23:
      int num3;
      if (_param1.\u0001.\u000E >= 16384)
      {
        *(int*) ((IntPtr) voidPtr + 8) = _param1.\u0014 - _param1.\u0013;
        if (_param1.\u0001)
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - 1;
        num3 = !obj2 || _param1.\u0015 != 0 ? 0 : (!_param1.\u0001 ? 1 : 0);
      }
      else
        goto label_29;
label_27:
      bool flag = num3 != 0;
      \u0005.\u0005.\u0007 obj1 = _param1.\u0001;
      byte[] numArray1 = _param1.\u0001;
      *(int*) ((IntPtr) voidPtr + 12) = _param1.\u0013;
      \u000F.\u0005.\u0001(*(int*) ((IntPtr) voidPtr + 8), flag, *(int*) ((IntPtr) voidPtr + 12), numArray1, obj1);
      _param1.\u0013 += *(int*) ((IntPtr) voidPtr + 8);
      int num4 = flag ? 1 : 0;
      int num5 = 0;
      int num6 = num4;
label_28:
      return num6 == num5;
label_29:
      if (!(_param1.\u0015 >= 262 | _param0))
        return true;
      if (_param1.\u0015 != 0)
      {
        num6 = _param1.\u0014;
        num5 = 65274;
        if (num5 != 0)
        {
          if (num6 >= num5)
            \u000F.\u0005.\u0001(_param1);
          *(int*) voidPtr = _param1.\u0011;
          num1 = _param1.\u0012;
          if (_param1.\u0015 >= 3)
          {
            *(int*) ((IntPtr) voidPtr + 4) = \u000F.\u0005.\u0001(_param1);
            if (*(int*) ((IntPtr) voidPtr + 4) == 0 || _param1.\u0014 - *(int*) ((IntPtr) voidPtr + 4) > 32506)
              goto label_12;
            else
              goto label_10;
          }
          else
            goto label_12;
        }
        else
          goto label_28;
      }
      else
      {
        if (_param1.\u0001)
          goto label_35;
label_4:
        _param1.\u0001 = false;
        \u0005.\u0005.\u0007 obj3 = _param1.\u0001;
        byte[] numArray2 = _param1.\u0001;
        *(int*) ((IntPtr) voidPtr + 12) = _param1.\u0013;
        *(int*) ((IntPtr) voidPtr + 20) = _param1.\u0014 - _param1.\u0013;
        \u000F.\u0005.\u0001(*(int*) ((IntPtr) voidPtr + 20), obj2, *(int*) ((IntPtr) voidPtr + 12), numArray2, obj3);
        _param1.\u0013 = _param1.\u0014;
        num3 = 0;
        if (num3 == 0)
          return num3 != 0;
        goto label_27;
label_35:
        \u000F.\u0005.\u0001(_param1.\u0001, (int) _param1.\u0001[_param1.\u0014 - 1] & (int) byte.MaxValue);
        goto label_4;
      }
    }

    static WorkflowSystemContext \u0001([In] ExecutionEngine obj0)
    {
      return UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]).\u0001();
    }

    static void \u0001(string _param0, int _param1)
    {
      try
      {
        object obj;
        do
        {
          obj = \u000E.\u0003.\u0001;
        }
        while (false);
        \u008C.\u009A(obj);
        try
        {
          do
          {
            if (true)
              \u000E.\u0003.\u0001.Add(_param1, _param0);
          }
          while (false);
        }
        finally
        {
          if (true)
            \u008C.\u0099(obj);
        }
      }
      catch
      {
      }
    }

    static unsafe void \u0001([In] \u0005.\u0005.\u0008 obj0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(16);
      Array.Copy((Array) obj0.\u0001, 32768, (Array) obj0.\u0001, 0, 32768);
      obj0.\u0011 -= 32768;
      obj0.\u0014 -= 32768;
      obj0.\u0013 -= 32768;
      *(int*) voidPtr = 0;
      while (*(int*) voidPtr < 32768)
      {
        *(int*) ((IntPtr) voidPtr + 4) = (int) obj0.\u0001[*(int*) voidPtr] & (int) ushort.MaxValue;
        obj0.\u0001[*(int*) voidPtr] = *(int*) ((IntPtr) voidPtr + 4) >= 32768 ? (short) (*(int*) ((IntPtr) voidPtr + 4) - 32768) : (short) 0;
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
      *(int*) ((IntPtr) voidPtr + 8) = 0;
      while (*(int*) ((IntPtr) voidPtr + 8) < 32768)
      {
        *(int*) ((IntPtr) voidPtr + 12) = (int) obj0.\u0002[*(int*) ((IntPtr) voidPtr + 8)] & (int) ushort.MaxValue;
        obj0.\u0002[*(int*) ((IntPtr) voidPtr + 8)] = *(int*) ((IntPtr) voidPtr + 12) >= 32768 ? (short) (*(int*) ((IntPtr) voidPtr + 12) - 32768) : (short) 0;
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
      }
    }

    static void \u0001(int _param0, \u0005.\u0005.\u000E _param1, int _param2, [In] byte[] obj3)
    {
label_0:
      Array.Copy((Array) obj3, _param2, (Array) _param1.\u0001, _param1.\u0002, _param0);
label_1:
      if (true)
      {
        _param1.\u0002 += _param0;
        if (false)
          goto label_1;
      }
      else
        goto label_0;
    }

    static void \u0001(\u0005.\u0005.\u0003 _param0, int _param1, [In] int obj2)
    {
      if ((_param0.\u0004 += _param1) > 32768)
        throw new InvalidOperationException();
      int sourceIndex = _param0.\u0003 - obj2 & (int) short.MaxValue;
      int num1 = 32768 - _param1;
      if (sourceIndex <= num1 && _param0.\u0003 < num1)
      {
        if (_param1 <= obj2)
        {
          Array.Copy((Array) _param0.\u0001, sourceIndex, (Array) _param0.\u0001, _param0.\u0003, _param1);
          _param0.\u0003 += _param1;
        }
        else
        {
          while (_param1-- > 0)
          {
            byte[] numArray = _param0.\u0001;
            \u0005.\u0005.\u0003 obj = _param0;
            int num2 = _param0.\u0003;
            int num3 = num2 + 1;
            obj.\u0003 = num3;
            int index = num2;
            int num4 = (int) _param0.\u0001[sourceIndex++];
            numArray[index] = (byte) num4;
          }
        }
      }
      else
        \u000F.\u0005.\u0001(_param0, sourceIndex, _param1, obj2);
    }

    static bool \u0001(\u0005.\u0005.\u0007 _param0, [In] int obj1)
    {
      _param0.\u0001[_param0.\u000E] = (short) 0;
      byte[] numArray = _param0.\u0002;
      \u0005.\u0005.\u0007 obj = _param0;
      int num1 = _param0.\u000E;
      int num2 = num1 + 1;
      obj.\u000E = num2;
      int index = num1;
      int num3 = (int) (byte) obj1;
      numArray[index] = (byte) num3;
      ++_param0.\u0001.\u0001[obj1];
      int num4 = _param0.\u000E;
      int num5 = 16384;
      int num6;
      int num7;
      while (true)
      {
        num6 = num4 < num5 ? 1 : 0;
        if (true)
        {
          num7 = 0;
          if (num7 != 0)
          {
            num5 = num7;
            num4 = num6;
          }
          else
            goto label_4;
        }
        else
          break;
      }
      return num6 != 0;
label_4:
      return num6 == num7;
    }

    static unsafe void \u0001(\u0005.\u0005.\u0007.\u0001 _param0, [In] \u0005.\u0005.\u0007.\u0001 obj1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(20);
      *(int*) ((IntPtr) voidPtr + 8) = -1;
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      while (*(int*) ((IntPtr) voidPtr + 12) < obj1.\u0002)
      {
        int num = 1;
        *(int*) ((IntPtr) voidPtr + 16) = (int) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 12)];
        if (*(int*) ((IntPtr) voidPtr + 16) != 0)
        {
          *(int*) voidPtr = 6;
          *(int*) ((IntPtr) voidPtr + 4) = 3;
          if (*(int*) ((IntPtr) voidPtr + 8) != *(int*) ((IntPtr) voidPtr + 16))
          {
            \u000F.\u0005.\u0001(_param0, *(int*) ((IntPtr) voidPtr + 16));
            num = 0;
          }
        }
        else
          goto label_17;
label_4:
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 16);
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
        while (*(int*) ((IntPtr) voidPtr + 12) < obj1.\u0002 && *(int*) ((IntPtr) voidPtr + 8) == (int) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 12)])
        {
          *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
          if (++num >= *(int*) voidPtr)
            break;
        }
        if (num < *(int*) ((IntPtr) voidPtr + 4))
        {
          while (num-- > 0)
            \u000F.\u0005.\u0001(_param0, *(int*) ((IntPtr) voidPtr + 8));
          continue;
        }
        if (*(int*) ((IntPtr) voidPtr + 8) != 0)
        {
          \u000F.\u0005.\u0001(_param0, 16);
          \u000F.\u0005.\u0001(obj1.\u0001.\u0001, num - 3, 2);
          continue;
        }
        if (num <= 10)
        {
          \u000F.\u0005.\u0001(_param0, 17);
          \u000F.\u0005.\u0001(obj1.\u0001.\u0001, num - 3, 3);
          continue;
        }
        \u000F.\u0005.\u0001(_param0, 18);
        \u000F.\u0005.\u0001(obj1.\u0001.\u0001, num - 11, 7);
        continue;
label_17:
        *(int*) voidPtr = 138;
        *(int*) ((IntPtr) voidPtr + 4) = 3;
        goto label_4;
      }
    }

    static void \u0001([In] \u0005.\u0005.\u0008 obj0)
    {
      obj0.\u0010 = (int) obj0.\u0001[obj0.\u0014] << 5 ^ (int) obj0.\u0001[obj0.\u0014 + 1];
    }

    static unsafe void \u0001([In] \u0005.\u0005.\u0007.\u0001 obj0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(32);
      *(int*) voidPtr = obj0.\u0001.Length;
      int[] numArray1 = new int[*(int*) voidPtr];
      int num1 = 0;
      int num2 = 0;
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (*(int*) ((IntPtr) voidPtr + 4) < *(int*) voidPtr)
      {
        *(int*) ((IntPtr) voidPtr + 8) = (int) obj0.\u0001[*(int*) ((IntPtr) voidPtr + 4)];
        if (*(int*) ((IntPtr) voidPtr + 8) != 0)
        {
          int index1;
          int index2;
          for (index1 = num1++; index1 > 0 && (int) obj0.\u0001[numArray1[index2 = (index1 - 1) / 2]] > *(int*) ((IntPtr) voidPtr + 8); index1 = index2)
            numArray1[index1] = numArray1[index2];
          numArray1[index1] = *(int*) ((IntPtr) voidPtr + 4);
          num2 = *(int*) ((IntPtr) voidPtr + 4);
        }
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
      }
      int num3;
      for (; num1 < 2; numArray1[num1++] = num3)
      {
        int num4;
        if (num2 >= 2)
          num4 = 0;
        else
          num2 = num4 = num2 + 1;
        num3 = num4;
      }
      obj0.\u0002 = Math.Max(num2 + 1, obj0.\u0001);
      int num5 = num1;
      int[] numArray2 = new int[4 * num1 - 2];
      int[] numArray3 = new int[2 * num1 - 1];
      int num6 = num5;
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      while (*(int*) ((IntPtr) voidPtr + 12) < num1)
      {
        *(int*) ((IntPtr) voidPtr + 16) = numArray1[*(int*) ((IntPtr) voidPtr + 12)];
        numArray2[2 * *(int*) ((IntPtr) voidPtr + 12)] = *(int*) ((IntPtr) voidPtr + 16);
        numArray2[2 * *(int*) ((IntPtr) voidPtr + 12) + 1] = -1;
        numArray3[*(int*) ((IntPtr) voidPtr + 12)] = (int) obj0.\u0001[*(int*) ((IntPtr) voidPtr + 16)] << 8;
        numArray1[*(int*) ((IntPtr) voidPtr + 12)] = *(int*) ((IntPtr) voidPtr + 12);
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
      }
      do
      {
        *(int*) ((IntPtr) voidPtr + 20) = numArray1[0];
        int index3 = numArray1[--num1];
        int index4 = 0;
        for (int index5 = 1; index5 < num1; index5 = index5 * 2 + 1)
        {
          if (index5 + 1 < num1 && numArray3[numArray1[index5]] > numArray3[numArray1[index5 + 1]])
            ++index5;
          numArray1[index4] = numArray1[index5];
          index4 = index5;
        }
        int num7 = numArray3[index3];
        int index6;
        while ((index6 = index4) > 0 && numArray3[numArray1[index4 = (index6 - 1) / 2]] > num7)
          numArray1[index6] = numArray1[index4];
        numArray1[index6] = index3;
        *(int*) ((IntPtr) voidPtr + 24) = numArray1[0];
        int index7 = num6++;
        numArray2[2 * index7] = *(int*) ((IntPtr) voidPtr + 20);
        numArray2[2 * index7 + 1] = *(int*) ((IntPtr) voidPtr + 24);
        *(int*) ((IntPtr) voidPtr + 28) = Math.Min(numArray3[*(int*) ((IntPtr) voidPtr + 20)] & (int) byte.MaxValue, numArray3[*(int*) ((IntPtr) voidPtr + 24)] & (int) byte.MaxValue);
        int num8;
        numArray3[index7] = num8 = numArray3[*(int*) ((IntPtr) voidPtr + 20)] + numArray3[*(int*) ((IntPtr) voidPtr + 24)] - *(int*) ((IntPtr) voidPtr + 28) + 1;
        int index8 = 0;
        for (int index9 = 1; index9 < num1; index9 = index8 * 2 + 1)
        {
          if (index9 + 1 < num1 && numArray3[numArray1[index9]] > numArray3[numArray1[index9 + 1]])
            ++index9;
          numArray1[index8] = numArray1[index9];
          index8 = index9;
        }
        int index10;
        while ((index10 = index8) > 0 && numArray3[numArray1[index8 = (index10 - 1) / 2]] > num8)
          numArray1[index10] = numArray1[index8];
        numArray1[index10] = index7;
      }
      while (num1 > 1);
      \u000F.\u0005.\u0001(obj0, numArray2);
    }

    static unsafe int \u0001([In] \u0005.\u0005.\u0007.\u0001 obj0)
    {
      int num1 = 8;
      if (num1 == 0)
        return num1;
      // ISSUE: untyped stack allocation
      IntPtr num2 = __untypedstackalloc(num1);
      void* voidPtr;
      if (true)
        voidPtr = (void*) num2;
      do
      {
        *(int*) voidPtr = 0;
        *(int*) ((IntPtr) voidPtr + 4) = 0;
        while (*(int*) ((IntPtr) voidPtr + 4) < obj0.\u0001.Length)
        {
          *(int*) voidPtr = *(int*) voidPtr + (int) obj0.\u0001[*(int*) ((IntPtr) voidPtr + 4)] * (int) obj0.\u0001[*(int*) ((IntPtr) voidPtr + 4)];
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
        }
      }
      while (false);
      return *(int*) voidPtr;
    }

    static void \u0001([In] \u0005.\u0005.\u0002 obj0)
    {
      obj0.\u0001 >>>= obj0.\u0003 & 7 & 31;
      obj0.\u0003 &= -8;
    }

    static void \u0001([In] \u0005.\u0005.\u000E obj0)
    {
      if (obj0.\u0003 > 0)
        goto label_3;
label_2:
      obj0.\u0001 = 0U;
      obj0.\u0003 = 0;
      return;
label_3:
      byte[] numArray1 = obj0.\u0001;
      \u0005.\u0005.\u000E obj1 = obj0;
      int num1 = obj0.\u0002;
      int num2 = num1 + 1;
      obj1.\u0002 = num2;
      int index1 = num1;
      int num3 = (int) (byte) obj0.\u0001;
      numArray1[index1] = (byte) num3;
      if (obj0.\u0003 > 8)
      {
        byte[] numArray2 = obj0.\u0001;
        \u0005.\u0005.\u000E obj2 = obj0;
        int num4 = obj0.\u0002;
        int num5 = num4 + 1;
        obj2.\u0002 = num5;
        int index2 = num4;
        int num6 = (int) (byte) (obj0.\u0001 >> 8);
        numArray2[index2] = (byte) num6;
        goto label_2;
      }
      else
        goto label_2;
    }

    static int \u0001(int _param0, [In] \u0005.\u0005.\u0007 obj1)
    {
      int num1 = _param0;
      int num2;
      if (true)
      {
        if (num1 == (int) byte.MaxValue)
          return 285;
        if (true)
        {
          num2 = 257;
          goto label_14;
        }
        else
          goto label_14;
      }
      else
        goto label_13;
label_5:
      int num3;
      if (true)
        num3 >>= 1;
      _param0 = num3;
      goto label_14;
label_13:
      num2 = num1;
      num3 = _param0;
      goto label_5;
label_14:
      int num4 = _param0;
      if (false)
      {
        num3 = num4;
        goto label_5;
      }
      else
      {
        int num5 = 8;
        if (num5 != 0)
        {
          if (num4 >= num5)
          {
            num1 = num2 + 4;
            goto label_13;
          }
          else
          {
            int num6 = num2;
            num5 = _param0;
            num4 = num6;
          }
        }
        return num4 + num5;
      }
    }

    static bool \u0001(
      EndEventNodeModel.\u0001 _param0,
      IQueryable<ProcessExecutionStep> _param1,
      [In] Guid[] obj2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EndEventNodeModel.\u0002 obj = new EndEventNodeModel.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = obj2;
      IQueryable<ProcessExecutionStep> source = _param1;
      ParameterExpression parameterExpression1 = Expression.Parameter(typeof (ProcessExecutionStep), \u000E.\u0003.\u0001(107396065));
      if (true)
        goto label_2;
label_1:
      // ISSUE: reference to a compiler-generated field
      Expression<Func<ProcessExecutionStep, bool>> predicate = (Expression<Func<ProcessExecutionStep, bool>>) (parameterExpression => parameterExpression.ProcessID == _param0.\u0001.ID);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return source.Where<ProcessExecutionStep>(predicate).Where<ProcessExecutionStep>((Expression<Func<ProcessExecutionStep, bool>>) (processExecutionStep => !processExecutionStep.Done)).Where<ProcessExecutionStep>((Expression<Func<ProcessExecutionStep, bool>>) (processExecutionStep => obj.\u0001.Count<Guid>() == 0 || obj.\u0001.Count<Guid>() > 0 && !obj.\u0001.Contains<Guid>(processExecutionStep.ID))).Any<ProcessExecutionStep>();
label_2:
      ParameterExpression parameterExpression2 = parameterExpression1;
      goto label_1;
    }

    static void \u0001(\u0005.\u0005.\u0006 _param0, [In] byte[] obj1)
    {
      \u000F.\u0005.\u0001(_param0.\u0001, obj1);
    }

    static unsafe void \u0001(
      int _param0,
      bool _param1,
      int _param2,
      byte[] _param3,
      [In] \u0005.\u0005.\u0007 obj4)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(24);
      ++obj4.\u0001.\u0001[256];
      \u000F.\u0005.\u0001(obj4.\u0001);
      \u0005.\u0005.\u0007.\u0001 obj1 = obj4.\u0002;
      if (true)
        \u000F.\u0005.\u0001(obj1);
      \u0005.\u0005.\u0007.\u0001 obj2 = obj4.\u0001;
      \u000F.\u0005.\u0001(obj4.\u0003, obj2);
      \u0005.\u0005.\u0007.\u0001 obj3 = obj4.\u0002;
      \u000F.\u0005.\u0001(obj4.\u0003, obj3);
      \u000F.\u0005.\u0001(obj4.\u0003);
      *(int*) voidPtr = 4;
      *(int*) ((IntPtr) voidPtr + 12) = 18;
      while (*(int*) ((IntPtr) voidPtr + 12) > *(int*) voidPtr)
      {
        if (obj4.\u0003.\u0001[\u0005.\u0005.\u0007.\u0001[*(int*) ((IntPtr) voidPtr + 12)]] > (byte) 0)
          *(int*) voidPtr = *(int*) ((IntPtr) voidPtr + 12) + 1;
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) - 1;
      }
      *(int*) ((IntPtr) voidPtr + 4) = 14 + *(int*) voidPtr * 3 + \u000F.\u0005.\u0001(obj4.\u0003) + \u000F.\u0005.\u0001(obj4.\u0001) + \u000F.\u0005.\u0001(obj4.\u0002) + obj4.\u000F;
      *(int*) ((IntPtr) voidPtr + 8) = obj4.\u000F;
      *(int*) ((IntPtr) voidPtr + 16) = 0;
      while (*(int*) ((IntPtr) voidPtr + 16) < 286)
      {
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + (int) obj4.\u0001.\u0001[*(int*) ((IntPtr) voidPtr + 16)] * (int) \u0005.\u0005.\u0007.\u0003[*(int*) ((IntPtr) voidPtr + 16)];
        *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) + 1;
      }
      *(int*) ((IntPtr) voidPtr + 20) = 0;
      while (*(int*) ((IntPtr) voidPtr + 20) < 30)
      {
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + (int) obj4.\u0002.\u0001[*(int*) ((IntPtr) voidPtr + 20)] * (int) \u0005.\u0005.\u0007.\u0004[*(int*) ((IntPtr) voidPtr + 20)];
        *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
      }
      if (*(int*) ((IntPtr) voidPtr + 4) >= *(int*) ((IntPtr) voidPtr + 8))
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 8);
      if (_param2 >= 0 && _param0 + 4 < *(int*) ((IntPtr) voidPtr + 4) >> 3)
        \u000F.\u0005.\u0001(_param2, _param1, _param0, obj4, _param3);
      else if (*(int*) ((IntPtr) voidPtr + 4) == *(int*) ((IntPtr) voidPtr + 8))
      {
        \u000F.\u0005.\u0001(obj4.\u0001, 2 + (_param1 ? 1 : 0), 3);
        \u0005.\u0005.\u0007.\u0001 obj5 = obj4.\u0001;
        short[] numArray1 = \u0005.\u0005.\u0007.\u0002;
        \u000F.\u0005.\u0001(\u0005.\u0005.\u0007.\u0003, obj5, numArray1);
        \u0005.\u0005.\u0007.\u0001 obj6 = obj4.\u0002;
        short[] numArray2 = \u0005.\u0005.\u0007.\u0003;
        \u000F.\u0005.\u0001(\u0005.\u0005.\u0007.\u0004, obj6, numArray2);
        \u000F.\u0005.\u0001(obj4);
        \u000F.\u0005.\u0001(obj4);
      }
      else
      {
        \u000F.\u0005.\u0001(obj4.\u0001, 4 + (_param1 ? 1 : 0), 3);
        \u000F.\u0005.\u0001(*(int*) voidPtr, obj4);
        \u000F.\u0005.\u0001(obj4);
        \u000F.\u0005.\u0001(obj4);
      }
    }

    static bool \u0001([In] \u0005.\u0005.\u0007 obj0) => obj0.\u000E >= 16384;

    static void \u0001(bool _param0)
    {
      int num = _param0 ? 1 : 0;
    }

    static byte[] \u0001(byte[] _param0, byte[] _param1, byte[] _param2)
    {
      return \u000F.\u0005.\u0001(_param0, _param2, 2, _param1);
    }

    static ForkNode \u0001(
      string _param0,
      WorkflowSystemContext _param1,
      Process _param2,
      params KeyValuePair<ProcessNode, string>[] _param3)
    {
      ProcessNode processNode = \u000F.\u0005.\u0001(_param2, ProcessNodeKind.ForkNode, _param1, _param0);
      ForkNode forkNode = \u000E.\u0001.\u0001<ForkNode>(_param1.ForkNodes.Create());
      processNode.ForkNode = forkNode;
      forkNode.ProcessNode = processNode;
      foreach (KeyValuePair<ProcessNode, string> keyValuePair in _param3)
      {
        ForkNextProcessNode forkNextProcessNode = \u000E.\u0001.\u0001<ForkNextProcessNode>(_param1.ForkNextProcessNodes.Create());
        forkNextProcessNode.ForkNode = forkNode;
        if (true)
          forkNextProcessNode.NextProcessNode = keyValuePair.Key;
        forkNextProcessNode.Condition = keyValuePair.Value;
        forkNode.NextProcessNodes.Add(forkNextProcessNode);
      }
      return forkNode;
    }

    static List<TimerNodeModel.TimerInfo> \u0001(ExecutionEngine.\u0001 _param0) => _param0.\u0001;

    static unsafe int \u0001(\u0005.\u0005.\u0003 _param0, \u0005.\u0005.\u0002 _param1, [In] int obj2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      int val1 = obj2;
      int val2 = 32768;
      if (val2 != 0)
        val2 -= _param0.\u0004;
      obj2 = Math.Min(Math.Min(val1, val2), _param1.AvailableBytes);
      *(int*) ((IntPtr) voidPtr + 4) = 32768 - _param0.\u0003;
      if (obj2 > *(int*) ((IntPtr) voidPtr + 4))
      {
        *(int*) voidPtr = \u000F.\u0005.\u0001(_param1, _param0.\u0001, _param0.\u0003, *(int*) ((IntPtr) voidPtr + 4));
        if (*(int*) voidPtr == *(int*) ((IntPtr) voidPtr + 4))
          *(int*) voidPtr = *(int*) voidPtr + \u000F.\u0005.\u0001(_param1, _param0.\u0001, 0, obj2 - *(int*) ((IntPtr) voidPtr + 4));
      }
      else
        *(int*) voidPtr = \u000F.\u0005.\u0001(_param1, _param0.\u0001, _param0.\u0003, obj2);
      _param0.\u0003 = _param0.\u0003 + *(int*) voidPtr & (int) short.MaxValue;
      _param0.\u0004 += *(int*) voidPtr;
      return *(int*) voidPtr;
    }

    static void \u0001(ExecutionEngine _param0, [In] TimerNodeModel.TimerInfo obj1)
    {
      \u000F.\u0005.\u0001(obj1, _param0.\u0001);
    }

    static int \u0001([In] \u0005.\u0005.\u0003 obj0) => obj0.\u0004;

    static string \u0001(int _param0)
    {
      object obj = \u000E.\u0003.\u0001;
      \u008C.\u009A(obj);
      string str1;
      try
      {
        string str2;
        \u000E.\u0003.\u0001.TryGetValue(_param0, out str2);
        do
        {
          if (str2 == null)
            goto label_10;
        }
        while (false);
        if (true)
        {
          if (true)
            str1 = str2;
        }
      }
      finally
      {
        do
        {
          \u008C.\u0099(obj);
        }
        while (false);
      }
      return str1;
label_10:
      return \u000F.\u0005.\u0001(_param0);
    }

    static void \u0001(
      IExecutionContext _param0,
      ProcessExecutionStep _param1,
      [In] ProcessNodeModel obj2)
    {
      if (((IInternalExecutionContext) _param0).SimulationMode)
        return;
      _param0.StepId = _param1.ID;
      UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]).\u0002(_param0, (IProcessNodeModel) obj2);
    }

    static void \u0001(byte[] _param0, \u0005.\u0005.\u0003 _param1, int _param2, [In] int obj3)
    {
      if (_param1.\u0004 > 0)
        throw new InvalidOperationException();
      int num1 = _param2;
label_1:
      int num2;
      for (int index = 32768; num1 > index; num1 = num2)
      {
        num2 = obj3;
        if (false)
        {
          num1 = num2;
          goto label_1;
        }
        else
        {
          int num3 = _param2;
          if (false)
          {
            index = num3;
          }
          else
          {
            if (true)
              num3 -= 32768;
            int num4 = num2 + num3;
            if (true)
            {
              obj3 = num4;
              num4 = 32768;
            }
            _param2 = num4;
            break;
          }
        }
      }
      do
      {
        Array.Copy((Array) _param0, obj3, (Array) _param1.\u0001, 0, _param2);
        _param1.\u0003 = _param2 & (int) short.MaxValue;
      }
      while (false);
    }

    static List<ProcessExecutionStep> \u0001(
      JoinNodeModel.\u0005 _param0,
      IQueryable<ProcessExecutionStep> _param1,
      [In] Guid[] obj2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      JoinNodeModel.\u0006 obj = new JoinNodeModel.\u0006();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = obj2;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return QueryableExtensions.AsNoTracking<ProcessExecutionStep>(_param1).Where<ProcessExecutionStep>((Expression<Func<ProcessExecutionStep, bool>>) (processExecutionStep => _param0.\u0001.Contains<int>(processExecutionStep.ProcessNodeID))).Where<ProcessExecutionStep>((Expression<Func<ProcessExecutionStep, bool>>) (processExecutionStep => processExecutionStep.PathID == _param0.\u0001.PathID)).Where<ProcessExecutionStep>((Expression<Func<ProcessExecutionStep, bool>>) (processExecutionStep => !obj.\u0001.Any<Guid>() || obj.\u0001.Any<Guid>() && !obj.\u0001.Contains<Guid>(processExecutionStep.ID))).ToList<ProcessExecutionStep>();
    }

    static void \u0001([In] ExecutionEngine.\u0001 obj0) => obj0.\u0001.Clear();

    static void \u0001(int _param0, \u0005.\u0005.\u0002 _param1, int _param2, [In] byte[] obj3)
    {
      if (true)
        goto label_6;
label_4:
      _param1.\u0003 += 8;
label_5:
      _param1.\u0001 = obj3;
      _param1.\u0001 = _param0;
      int num;
      _param1.\u0002 = num;
      return;
label_6:
      if (_param1.\u0001 < _param1.\u0002)
        throw new InvalidOperationException();
      num = _param0 + _param2;
      if (0 > _param0 || _param0 > num || num > obj3.Length)
        throw new ArgumentOutOfRangeException();
      if ((_param2 & 1) != 0)
      {
        _param1.\u0001 |= (uint) (((int) obj3[_param0++] & (int) byte.MaxValue) << _param1.\u0003);
        goto label_4;
      }
      else
        goto label_5;
    }

    static void \u0001([In] ExecutionEngine.SchedulerEngine obj0)
    {
      object obj = obj0.\u0001;
      bool flag = false;
      try
      {
        \u008A.\u0097(obj, ref flag);
        obj0.\u0001.Clear();
        \u000F.\u0005.\u0001(obj0.\u0001);
      }
      finally
      {
        if (flag)
          \u008C.\u0099(obj);
      }
    }

    static void \u0001([In] \u0005.\u0005.\u0003 obj0) => obj0.\u0004 = obj0.\u0003 = 0;

    static void \u0001(TimerNodeModel.TimerInfo _param0, [In] ExecutionEngine.SchedulerEngine obj1)
    {
      if (false)
        return;
      object obj = obj1.\u0001;
      bool flag = false;
      try
      {
        \u008A.\u0097(obj, ref flag);
        List<TimerNodeModel.TimerInfo> timerInfoList = obj1.\u0001;
        TimerNodeModel.TimerInfo timerInfo = _param0;
        if (false)
          return;
        timerInfoList.Add(timerInfo);
      }
      finally
      {
        if (flag)
          \u008C.\u0099(obj);
      }
    }

    static void \u0001(\u0005.\u0005.\u0003 _param0, [In] int obj1)
    {
label_0:
      do
      {
        \u0005.\u0005.\u0003 obj2 = _param0;
        int num1 = _param0.\u0004;
        int num2 = num1 + 1;
        obj2.\u0004 = num2;
        do
        {
          if (true)
          {
            if (num1 != 32768)
              goto label_3;
label_2:
            goto label_0;
label_3:
            if (true)
            {
              byte[] numArray = _param0.\u0001;
              \u0005.\u0005.\u0003 obj3 = _param0;
              num1 = _param0.\u0003;
              int num3 = num1 + 1;
              obj3.\u0003 = num3;
              int index = num1;
              int num4 = (int) (byte) obj1;
              numArray[index] = (byte) num4;
              if (false)
                goto label_2;
            }
            else
              goto label_0;
          }
          else
            goto label_0;
        }
        while (false);
        goto label_5;
      }
      while (false);
      goto label_7;
label_5:
      _param0.\u0003 &= (int) short.MaxValue;
      return;
label_7:
      throw new InvalidOperationException();
    }

    static void \u0001(ProcessNode _param0, ProcessNode _param1)
    {
      _param0.NextProcessNode = _param1;
    }

    static ICryptoTransform \u0001(bool _param0, byte[] _param1, byte[] _param2)
    {
      ICryptoTransform cryptoTransform1;
      using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
      {
        ICryptoTransform cryptoTransform2;
        while (!_param0)
        {
          if (true)
          {
            cryptoTransform2 = cryptoServiceProvider.CreateEncryptor(_param1, _param2);
            goto label_3;
          }
        }
        goto label_5;
label_3:
        cryptoTransform1 = cryptoTransform2;
        if (true)
          goto label_9;
label_5:
        cryptoTransform2 = cryptoServiceProvider.CreateDecryptor(_param1, _param2);
        goto label_3;
      }
label_9:
      return cryptoTransform1;
    }

    static unsafe void \u0001(\u0005.\u0005.\u0007.\u0001 _param0, [In] \u0005.\u0005.\u0007.\u0001 obj1)
    {
      void* voidPtr;
      if (true)
      {
        // ISSUE: untyped stack allocation
        voidPtr = (void*) __untypedstackalloc(20);
        *(int*) ((IntPtr) voidPtr + 8) = -1;
        goto label_19;
      }
label_3:
      *(int*) voidPtr = 6;
      *(int*) ((IntPtr) voidPtr + 4) = 3;
      int num;
      if (*(int*) ((IntPtr) voidPtr + 8) != *(int*) ((IntPtr) voidPtr + 16))
      {
        ++_param0.\u0001[*(int*) ((IntPtr) voidPtr + 16)];
        num = 0;
      }
label_5:
      if (true)
      {
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 16);
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
        if (true)
        {
          while (*(int*) ((IntPtr) voidPtr + 12) < obj1.\u0002 && *(int*) ((IntPtr) voidPtr + 8) == (int) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 12)])
          {
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
            if (++num >= *(int*) voidPtr)
              break;
          }
          if (true)
          {
            if (num < *(int*) ((IntPtr) voidPtr + 4))
            {
              _param0.\u0001[*(int*) ((IntPtr) voidPtr + 8)] += (short) num;
              goto label_18;
            }
            else if (*(int*) ((IntPtr) voidPtr + 8) != 0)
            {
              ++_param0.\u0001[16];
              goto label_18;
            }
            else if (num > 10)
            {
              ++_param0.\u0001[18];
              goto label_18;
            }
          }
          else
            goto label_18;
        }
        else
          goto label_19;
      }
      else
        goto label_19;
label_15:
      ++_param0.\u0001[17];
label_18:
      if (*(int*) ((IntPtr) voidPtr + 12) >= obj1.\u0002)
        return;
      if (true)
        num = 1;
      *(int*) ((IntPtr) voidPtr + 16) = (int) obj1.\u0001[*(int*) ((IntPtr) voidPtr + 12)];
      if (*(int*) ((IntPtr) voidPtr + 16) == 0)
      {
        *(int*) voidPtr = 138;
        *(int*) ((IntPtr) voidPtr + 4) = 3;
        if (false)
          goto label_15;
        else
          goto label_5;
      }
      else
        goto label_3;
label_19:
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      goto label_18;
    }

    static ProcessInstance \u0001(int _param0, ExecutionEngine _param1, [In] IExecutionContext obj2)
    {
      ProcessModel processModel = _param1.\u0001[_param0];
      if (processModel == null)
        throw new Exception(\u000E.\u0003.\u0001(107396088));
      TransactionScope transactionScope = new TransactionScope();
      ProcessInstance processInstance;
      try
      {
        WorkflowSystemContext workflowSystemContext = \u000F.\u0005.\u0001(_param1);
        try
        {
          processInstance = \u000E.\u0001.\u0001<ProcessInstance>(workflowSystemContext.ProcessInstances.Create(), obj2);
          processInstance.ProcessMetaDataID = processModel.ID;
          processInstance.VoucherRowID = obj2.Voucher.ID;
          workflowSystemContext.ProcessInstances.Add(processInstance);
          \u000F.\u0005.\u0001(workflowSystemContext, processModel, obj2, processInstance);
          int num = \u001F.\u007E\u008B((object) workflowSystemContext);
        }
        finally
        {
          if (workflowSystemContext != null)
            global::\u0005.\u007E\u000E((object) workflowSystemContext);
        }
        global::\u0005.\u007E\u000F((object) transactionScope);
      }
      finally
      {
        if (transactionScope != null)
          global::\u0005.\u007E\u000E((object) transactionScope);
      }
      return processInstance;
    }

    static ProcessNode \u0001(
      Process _param0,
      ProcessNodeKind _param1,
      WorkflowSystemContext _param2,
      string _param3)
    {
      if (true)
        goto label_4;
label_1:
      ProcessNode processNode1;
      if (true)
        _param2.ProcessNodes.Add(processNode1);
      return processNode1;
label_4:
      ProcessNode processNode2 = \u000E.\u0001.\u0001<ProcessNode>(_param2.ProcessNodes.Create());
      if (true)
        processNode1 = processNode2;
      processNode1.Process = _param0;
      if (true)
      {
        processNode1.Name = _param3;
        processNode1.NodeKindID = (int) _param1;
        goto label_1;
      }
      else
        goto label_1;
    }

    static void \u0001(TimerNodeModel.TimerInfo _param0, [In] ExecutionEngine.SchedulerEngine obj1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      global::\u0005.\u007E\u0013((object) new Thread(new ThreadStart(new ExecutionEngine.SchedulerEngine.\u0001()
      {
        \u0001 = obj1,
        \u0001 = _param0
      }.\u0001))
      {
        Name = \u000E.\u0003.\u0001(107396023)
      });
    }

    static void \u0001(\u0005.\u0005.\u0008 _param0, [In] byte[] obj1)
    {
      if (true)
        _param0.\u0002 = obj1;
      do
      {
        _param0.\u0017 = 0;
        _param0.\u0018 = obj1.Length;
      }
      while (false);
    }

    static unsafe bool \u0001(int _param0, int _param1, [In] \u0005.\u0005.\u0007 obj2)
    {
      // ISSUE: untyped stack allocation
      IntPtr num1 = __untypedstackalloc(12);
      void* voidPtr;
      if (true)
        voidPtr = (void*) num1;
      obj2.\u0001[obj2.\u000E] = (short) _param1;
      byte[] numArray = obj2.\u0002;
      \u0005.\u0005.\u0007 obj = obj2;
      *(int*) ((IntPtr) voidPtr + 8) = obj2.\u000E;
      int num2 = *(int*) ((IntPtr) voidPtr + 8) + 1;
      obj.\u000E = num2;
      int index = *(int*) ((IntPtr) voidPtr + 8);
      int num3 = (int) (byte) (_param0 - 3);
      numArray[index] = (byte) num3;
      *(int*) voidPtr = \u000F.\u0005.\u0001(_param0 - 3, obj2);
      ++obj2.\u0001.\u0001[*(int*) voidPtr];
      if (*(int*) voidPtr >= 265 && *(int*) voidPtr < 285)
        obj2.\u000F += (*(int*) voidPtr - 261) / 4;
      *(int*) ((IntPtr) voidPtr + 4) = \u000F.\u0005.\u0001(obj2, _param1 - 1);
      ++obj2.\u0002.\u0001[*(int*) ((IntPtr) voidPtr + 4)];
      if (*(int*) ((IntPtr) voidPtr + 4) >= 4)
        obj2.\u000F += *(int*) ((IntPtr) voidPtr + 4) / 2 - 1;
      int num4 = obj2.\u000E;
      int num5 = 16384;
      int num6;
      int num7;
      while (true)
      {
        num6 = num4 < num5 ? 1 : 0;
        num7 = 0;
        if (num7 != 0)
        {
          num5 = num7;
          num4 = num6;
        }
        else
          break;
      }
      return num6 == num7;
    }

    static int \u0001([In] \u0005.\u0005.\u0003 obj0) => 32768 - obj0.\u0004;

    static void \u0001(byte[] _param0, \u0005.\u0005.\u0007.\u0001 _param1, [In] short[] obj2)
    {
      _param1.\u0002 = obj2;
      _param1.\u0001 = _param0;
    }

    static ProcessExecutionStep \u0001(
      ProcessInstance _param0,
      ProcessExecutionStep _param1_1,
      WorkflowSystemContext _param2,
      [In] ProcessNodeModel obj3)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ProcessNodeModel.\u0002 obj = new ProcessNodeModel.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = _param0;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = obj3;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = _param1_1?.PathID;
      return \u000F.\u0005.\u0001(obj, \u0094.\u007E\u0003\u0002((object) _param2).Entries<ProcessExecutionStep>().Select<DbEntityEntry<ProcessExecutionStep>, ProcessExecutionStep>((Func<DbEntityEntry<ProcessExecutionStep>, ProcessExecutionStep>) (_param1_2 => _param1_2.Entity)).AsQueryable<ProcessExecutionStep>()) ?? \u000F.\u0005.\u0001(obj, (IQueryable<ProcessExecutionStep>) _param2.ProcessExecutionSteps);
    }

    static bool \u0001([In] \u0005.\u0005.\u0008 obj0) => obj0.\u0018 == obj0.\u0017;

    static ICryptoTransform \u0001(bool _param0, byte[] _param1, byte[] _param2)
    {
      ICryptoTransform cryptoTransform1;
      using (SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm) new RijndaelManaged())
      {
        ICryptoTransform cryptoTransform2;
        while (!_param0)
        {
          if (true)
          {
            cryptoTransform2 = symmetricAlgorithm.CreateEncryptor(_param2, _param1);
            goto label_3;
          }
        }
        goto label_5;
label_3:
        cryptoTransform1 = cryptoTransform2;
        if (true)
          goto label_9;
label_5:
        cryptoTransform2 = symmetricAlgorithm.CreateDecryptor(_param2, _param1);
        goto label_3;
      }
label_9:
      return cryptoTransform1;
    }

    static void \u0001(ExecutionEngine.\u0001 _param0, [In] TimerNodeModel.TimerInfo obj1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ExecutionEngine.\u0001.\u0001 obj = new ExecutionEngine.\u0001.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = obj1;
      int num;
      // ISSUE: reference to a compiler-generated field
      if (!_param0.\u0001.TryGetValue(obj.\u0001.StepId, out num))
      {
        // ISSUE: reference to a compiler-generated field
        _param0.\u0001.Add(obj.\u0001.StepId, 1);
      }
      else
        goto label_7;
label_5:
      // ISSUE: reference to a compiler-generated method
      if (!_param0.\u0001.All<TimerNodeModel.TimerInfo>(new Func<TimerNodeModel.TimerInfo, bool>(obj.\u0001)))
        return;
      // ISSUE: reference to a compiler-generated field
      _param0.\u0001.Add(obj.\u0001);
      return;
label_7:
      if (num >= 6)
        return;
      // ISSUE: reference to a compiler-generated field
      _param0.\u0001[obj.\u0001.StepId] = num + 1;
      goto label_5;
    }

    static unsafe void \u0001([In] \u0005.\u0005.\u0007.\u0001 obj0)
    {
      void* voidPtr;
      int[] numArray;
      if (true)
      {
        // ISSUE: untyped stack allocation
        voidPtr = (void*) __untypedstackalloc(16);
        if (true)
        {
          int length = obj0.\u0001.Length;
        }
        numArray = new int[obj0.\u0003];
        *(int*) voidPtr = 0;
        obj0.\u0002 = new short[obj0.\u0001.Length];
        *(int*) ((IntPtr) voidPtr + 4) = 0;
        goto label_4;
      }
label_3:
      *(int*) voidPtr = *(int*) voidPtr + (obj0.\u0001[*(int*) ((IntPtr) voidPtr + 4)] << 15 - *(int*) ((IntPtr) voidPtr + 4));
      *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
label_4:
      if (*(int*) ((IntPtr) voidPtr + 4) >= obj0.\u0003)
      {
        *(int*) ((IntPtr) voidPtr + 8) = 0;
        while (*(int*) ((IntPtr) voidPtr + 8) < obj0.\u0002)
        {
          *(int*) ((IntPtr) voidPtr + 12) = (int) obj0.\u0001[*(int*) ((IntPtr) voidPtr + 8)];
          if (*(int*) ((IntPtr) voidPtr + 12) > 0)
          {
            obj0.\u0002[*(int*) ((IntPtr) voidPtr + 8)] = \u000F.\u0005.\u0001(numArray[*(int*) ((IntPtr) voidPtr + 12) - 1]);
            numArray[*(int*) ((IntPtr) voidPtr + 12) - 1] += 1 << 16 - *(int*) ((IntPtr) voidPtr + 12);
          }
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
        }
      }
      else
      {
        numArray[*(int*) ((IntPtr) voidPtr + 4)] = *(int*) voidPtr;
        goto label_3;
      }
    }

    static void \u0001(\u0005.\u0005.\u0003 _param0, int _param1, int _param2, [In] int obj3)
    {
      if (false)
        return;
      while (true)
      {
        int num1 = _param2;
        int num2;
        while (true)
        {
          num2 = num1 - 1;
          if (false)
            num1 = num2;
          else
            break;
        }
        _param2 = num2;
        if (num1 > 0)
        {
          byte[] numArray = _param0.\u0001;
          \u0005.\u0005.\u0003 obj = _param0;
          int num3 = _param0.\u0003;
          int num4 = num3 + 1;
          obj.\u0003 = num4;
          int index = num3;
          int num5 = (int) _param0.\u0001[_param1++];
          numArray[index] = (byte) num5;
          _param0.\u0003 &= (int) short.MaxValue;
          int num6 = _param1;
          if (true)
            num6 &= (int) short.MaxValue;
          _param1 = num6;
        }
        else
          break;
      }
    }

    static ProcessExecutionStep \u0001(
      WorkflowSystemContext _param0,
      ProcessModel _param1,
      IExecutionContext _param2,
      [In] ProcessInstance obj3)
    {
      ProcessExecutionStep processExecutionStep = _param1.StartEventNode.\u0001(obj3, _param2, _param0, (ProcessExecutionStep) null);
      bool flag = false;
      return _param1.StartEventNode.\u0001(obj3, _param2, _param0, processExecutionStep, ref flag, processExecutionStep);
    }

    static int \u0001([In] \u0005.\u0005.\u000F obj0) => obj0.ReadByte() | obj0.ReadByte() << 8;

    static void \u0001([In] ExecutionEngine obj0)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ExecutionEngine.\u0003 obj = new ExecutionEngine.\u0003();
      \u000F.\u0005.\u0001(obj0.\u0001);
      \u000F.\u0005.\u0001(obj0.\u0001);
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = ((IEnumerable<TimerNodeModel>) obj0.\u0001.\u0001<TimerNodeModel>(ProcessNodeKind.Timer)).Select<TimerNodeModel, int>((Func<TimerNodeModel, int>) (_param1 => _param1.ID));
      WorkflowSystemContext workflowSystemContext = \u000F.\u0005.\u0001(obj0);
      TimerNodeModel.TimerInfo[] array;
      try
      {
        DbSet<ProcessExecutionStep> processExecutionSteps = workflowSystemContext.ProcessExecutionSteps;
        // ISSUE: type reference
        ParameterExpression parameterExpression1 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessExecutionStep)), \u000E.\u0003.\u0001(107396065));
        // ISSUE: method reference
        Expression<Func<ProcessExecutionStep, bool>> predicate1 = Expression.Lambda<Func<ProcessExecutionStep, bool>>((Expression) \u0092.\u0001\u0002((Expression) \u0019.\u0083((Expression) parameterExpression1, (MethodInfo) \u0018.\u0082(__methodref (ProcessExecutionStep.get_Done)))), parameterExpression1);
        IQueryable<ProcessExecutionStep> source1 = ((IQueryable<ProcessExecutionStep>) processExecutionSteps).Where<ProcessExecutionStep>(predicate1);
        // ISSUE: type reference
        ParameterExpression parameterExpression2 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessExecutionStep)), \u000E.\u0003.\u0001(107396065));
        // ISSUE: method reference
        // ISSUE: method reference
        Expression<Func<ProcessExecutionStep, bool>> predicate2 = Expression.Lambda<Func<ProcessExecutionStep, bool>>((Expression) \u0092.\u0001\u0002((Expression) \u0019.\u0083((Expression) \u0019.\u0083((Expression) parameterExpression2, (MethodInfo) \u0018.\u0082(__methodref (ProcessExecutionStep.get_ProcessInstance))), (MethodInfo) \u0018.\u0082(__methodref (ProcessInstance.get_Closed)))), parameterExpression2);
        IQueryable<ProcessExecutionStep> source2 = source1.Where<ProcessExecutionStep>(predicate2);
        // ISSUE: type reference
        ParameterExpression parameterExpression3 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessExecutionStep)), \u000E.\u0003.\u0001(107396065));
        // ISSUE: method reference
        // ISSUE: type reference
        // ISSUE: field reference
        // ISSUE: method reference
        Expression<Func<ProcessExecutionStep, bool>> predicate3 = Expression.Lambda<Func<ProcessExecutionStep, bool>>((Expression) \u0093.\u0002\u0002((Expression) null, (MethodInfo) \u0018.\u0082(__methodref (Enumerable.Contains)), new Expression[2]
        {
          (Expression) \u001C.\u0087((Expression) \u001A.\u0084((object) obj, global::\u000F.\u0019(__typeref (ExecutionEngine.\u0003))), \u001B.\u0086(__fieldref (ExecutionEngine.\u0003.\u0001))),
          (Expression) \u0019.\u0083((Expression) parameterExpression3, (MethodInfo) \u0018.\u0082(__methodref (ProcessExecutionStep.get_ProcessNodeID)))
        }), parameterExpression3);
        IQueryable<ProcessExecutionStep> source3 = source2.Where<ProcessExecutionStep>(predicate3);
        // ISSUE: type reference
        ParameterExpression parameterExpression4 = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessExecutionStep)), \u000E.\u0003.\u0001(107396065));
        // ISSUE: method reference
        Expression<Func<ProcessExecutionStep, string>> selector = Expression.Lambda<Func<ProcessExecutionStep, string>>((Expression) \u0019.\u0083((Expression) parameterExpression4, (MethodInfo) \u0018.\u0082(__methodref (ProcessExecutionStep.get_Data))), parameterExpression4);
        array = source3.Select<ProcessExecutionStep, string>(selector).AsEnumerable<string>().Select<string, TimerNodeModel.TimerInfo>((Func<string, TimerNodeModel.TimerInfo>) (_param1 => \u000F.\u0005.\u0001(_param1))).ToArray<TimerNodeModel.TimerInfo>();
      }
      finally
      {
        while (workflowSystemContext != null)
        {
          if (true)
          {
            global::\u0005.\u007E\u000E((object) workflowSystemContext);
            break;
          }
        }
      }
      TimerNodeModel.TimerInfo[] timerInfoArray = array;
      int num1 = 0;
label_9:
      int index1;
      if (num1 == 0)
        index1 = num1;
      else
        goto label_16;
label_14:
      if (true)
        num1 = index1;
      else
        goto label_18;
label_16:
      int num2;
      for (int index2 = timerInfoArray.Length; num1 < index2; num1 = num2)
      {
        \u000F.\u0005.\u0001(timerInfoArray[index1], obj0.\u0001);
        num2 = index1;
        int num3 = 1;
        if (num3 != 0)
        {
          int num4 = num2 + num3;
          if (false)
          {
            num1 = num4;
            goto label_9;
          }
          else
          {
            index1 = num4;
            goto label_14;
          }
        }
        else
          index2 = num3;
      }
label_18:
      \u000F.\u0005.\u0001(obj0.\u0001);
    }

    static bool \u0001(
      ProcessInstance _param0,
      EndEventNodeModel _param1_1,
      [In] WorkflowSystemContext obj2)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      EndEventNodeModel.\u0001 obj = new EndEventNodeModel.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = _param0;
      ProcessExecutionStep[] array;
      do
      {
        array = \u0094.\u007E\u0003\u0002((object) obj2).Entries<ProcessExecutionStep>().Select<DbEntityEntry<ProcessExecutionStep>, ProcessExecutionStep>((Func<DbEntityEntry<ProcessExecutionStep>, ProcessExecutionStep>) (_param1_2 => _param1_2.Entity)).ToArray<ProcessExecutionStep>();
      }
      while (false);
      // ISSUE: reference to a compiler-generated method
      return \u000F.\u0005.\u0001(obj, ((IEnumerable<ProcessExecutionStep>) array).AsQueryable<ProcessExecutionStep>(), new Guid[0]) || \u000F.\u0005.\u0001(obj, (IQueryable<ProcessExecutionStep>) obj2.ProcessExecutionSteps, ((IEnumerable<ProcessExecutionStep>) array).Where<ProcessExecutionStep>(new Func<ProcessExecutionStep, bool>(obj.\u0001)).Select<ProcessExecutionStep, Guid>((Func<ProcessExecutionStep, Guid>) (_param1_3 => _param1_3.ID)).ToArray<Guid>());
    }

    static unsafe int \u0001(int _param0, byte[] _param1, int _param2, [In] \u0005.\u0005.\u0001 obj3)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      *(int*) voidPtr = 0;
      int num1;
      int num2;
      do
      {
        num1 = obj3.\u0013;
        num2 = 11;
        if (num2 != 0)
        {
          if (num1 != num2)
            goto label_8;
label_3:
          if (!\u000F.\u0005.\u0001(obj3))
          {
            int num3 = obj3.\u0001.\u0004;
            num2 = 0;
            num1 = num3;
            goto label_5;
          }
          else
            continue;
label_8:
          *(int*) ((IntPtr) voidPtr + 4) = \u000F.\u0005.\u0001(_param1, _param0, _param2, obj3.\u0001);
          _param2 += *(int*) ((IntPtr) voidPtr + 4);
          *(int*) voidPtr = *(int*) voidPtr + *(int*) ((IntPtr) voidPtr + 4);
          _param0 -= *(int*) ((IntPtr) voidPtr + 4);
          if (_param0 != 0)
            goto label_3;
          else
            goto label_2;
        }
label_5:;
      }
      while (num1 > num2 && obj3.\u0013 != 11);
      goto label_6;
label_2:
      return *(int*) voidPtr;
label_6:
      return *(int*) voidPtr;
    }

    static unsafe byte[] \u0001(byte[] _param0, byte[] _param1, int _param2, byte[] _param3)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(64);
      try
      {
        \u0005.\u0005.\u000F obj1 = new \u0005.\u0005.\u000F();
        uint num1;
        byte[] bytes;
        \u0005.\u0005.\u0006 obj2;
        switch (_param2)
        {
          case 0:
            obj2 = new \u0005.\u0005.\u0006();
            DateTime now = DateTime.Now;
            *(long*) voidPtr = (long) (uint) ((now.Year - 1980 & (int) sbyte.MaxValue) << 25 | now.Month << 21 | now.Day << 16 | now.Hour << 11 | now.Minute << 5 | now.Second >>> 1);
            uint[] numArray = new uint[256]
            {
              0U,
              1996959894U,
              3993919788U,
              2567524794U,
              124634137U,
              1886057615U,
              3915621685U,
              2657392035U,
              249268274U,
              2044508324U,
              3772115230U,
              2547177864U,
              162941995U,
              2125561021U,
              3887607047U,
              2428444049U,
              498536548U,
              1789927666U,
              4089016648U,
              2227061214U,
              450548861U,
              1843258603U,
              4107580753U,
              2211677639U,
              325883990U,
              1684777152U,
              4251122042U,
              2321926636U,
              335633487U,
              1661365465U,
              4195302755U,
              2366115317U,
              997073096U,
              1281953886U,
              3579855332U,
              2724688242U,
              1006888145U,
              1258607687U,
              3524101629U,
              2768942443U,
              901097722U,
              1119000684U,
              3686517206U,
              2898065728U,
              853044451U,
              1172266101U,
              3705015759U,
              2882616665U,
              651767980U,
              1373503546U,
              3369554304U,
              3218104598U,
              565507253U,
              1454621731U,
              3485111705U,
              3099436303U,
              671266974U,
              1594198024U,
              3322730930U,
              2970347812U,
              795835527U,
              1483230225U,
              3244367275U,
              3060149565U,
              1994146192U,
              31158534U,
              2563907772U,
              4023717930U,
              1907459465U,
              112637215U,
              2680153253U,
              3904427059U,
              2013776290U,
              251722036U,
              2517215374U,
              3775830040U,
              2137656763U,
              141376813U,
              2439277719U,
              3865271297U,
              1802195444U,
              476864866U,
              2238001368U,
              4066508878U,
              1812370925U,
              453092731U,
              2181625025U,
              4111451223U,
              1706088902U,
              314042704U,
              2344532202U,
              4240017532U,
              1658658271U,
              366619977U,
              2362670323U,
              4224994405U,
              1303535960U,
              984961486U,
              2747007092U,
              3569037538U,
              1256170817U,
              1037604311U,
              2765210733U,
              3554079995U,
              1131014506U,
              879679996U,
              2909243462U,
              3663771856U,
              1141124467U,
              855842277U,
              2852801631U,
              3708648649U,
              1342533948U,
              654459306U,
              3188396048U,
              3373015174U,
              1466479909U,
              544179635U,
              3110523913U,
              3462522015U,
              1591671054U,
              702138776U,
              2966460450U,
              3352799412U,
              1504918807U,
              783551873U,
              3082640443U,
              3233442989U,
              3988292384U,
              2596254646U,
              62317068U,
              1957810842U,
              3939845945U,
              2647816111U,
              81470997U,
              1943803523U,
              3814918930U,
              2489596804U,
              225274430U,
              2053790376U,
              3826175755U,
              2466906013U,
              167816743U,
              2097651377U,
              4027552580U,
              2265490386U,
              503444072U,
              1762050814U,
              4150417245U,
              2154129355U,
              426522225U,
              1852507879U,
              4275313526U,
              2312317920U,
              282753626U,
              1742555852U,
              4189708143U,
              2394877945U,
              397917763U,
              1622183637U,
              3604390888U,
              2714866558U,
              953729732U,
              1340076626U,
              3518719985U,
              2797360999U,
              1068828381U,
              1219638859U,
              3624741850U,
              2936675148U,
              906185462U,
              1090812512U,
              3747672003U,
              2825379669U,
              829329135U,
              1181335161U,
              3412177804U,
              3160834842U,
              628085408U,
              1382605366U,
              3423369109U,
              3138078467U,
              570562233U,
              1426400815U,
              3317316542U,
              2998733608U,
              733239954U,
              1555261956U,
              3268935591U,
              3050360625U,
              752459403U,
              1541320221U,
              2607071920U,
              3965973030U,
              1969922972U,
              40735498U,
              2617837225U,
              3943577151U,
              1913087877U,
              83908371U,
              2512341634U,
              3803740692U,
              2075208622U,
              213261112U,
              2463272603U,
              3855990285U,
              2094854071U,
              198958881U,
              2262029012U,
              4057260610U,
              1759359992U,
              534414190U,
              2176718541U,
              4139329115U,
              1873836001U,
              414664567U,
              2282248934U,
              4279200368U,
              1711684554U,
              285281116U,
              2405801727U,
              4167216745U,
              1634467795U,
              376229701U,
              2685067896U,
              3608007406U,
              1308918612U,
              956543938U,
              2808555105U,
              3495958263U,
              1231636301U,
              1047427035U,
              2932959818U,
              3654703836U,
              1088359270U,
              936918000U,
              2847714899U,
              3736837829U,
              1202900863U,
              817233897U,
              3183342108U,
              3401237130U,
              1404277552U,
              615818150U,
              3134207493U,
              3453421203U,
              1423857449U,
              601450431U,
              3009837614U,
              3294710456U,
              1567103746U,
              711928724U,
              3020668471U,
              3272380065U,
              1510334235U,
              755167117U
            };
            *(int*) ((IntPtr) voidPtr + 40) = -1;
            uint num2 = *(uint*) ((IntPtr) voidPtr + 40);
            int num3 = 0;
            int length1 = _param3.Length;
            while (--length1 >= 0)
              num2 = numArray[((int) num2 ^ (int) _param3[num3++]) & (int) byte.MaxValue] ^ num2 >> 8;
            num1 = num2 ^ *(uint*) ((IntPtr) voidPtr + 40);
            \u000F.\u0005.\u0001(obj1, 67324752);
            \u000F.\u0005.\u0001(obj1, 20);
            \u000F.\u0005.\u0001(obj1, 0);
            \u000F.\u0005.\u0001(obj1, 8);
            \u000F.\u0005.\u0001(obj1, (int) *(long*) voidPtr);
            \u000F.\u0005.\u0001(obj1, (int) num1);
            *(long*) ((IntPtr) voidPtr + 8) = obj1.Position;
            \u000F.\u0005.\u0001(obj1, 0);
            \u000F.\u0005.\u0001(obj1, _param3.Length);
            bytes = Encoding.UTF8.GetBytes("{data}");
            \u000F.\u0005.\u0001(obj1, bytes.Length);
            \u000F.\u0005.\u0001(obj1, 0);
            obj1.Write(bytes, 0, bytes.Length);
            \u000F.\u0005.\u0001(obj2, _param3);
            goto label_8;
          case 1:
            \u000F.\u0005.\u0001(obj1, 25000571);
            \u000F.\u0005.\u0001(obj1, _param3.Length);
            if (true)
            {
              *(int*) ((IntPtr) voidPtr + 52) = 0;
              goto label_28;
            }
            else
              goto label_15;
          case 2:
            \u000F.\u0005.\u0001(obj1, 41777787);
            byte[] inputBuffer1 = \u000F.\u0005.\u0001((byte[]) null, (byte[]) null, 1, _param3);
            if (true)
            {
              using (ICryptoTransform cryptoTransform = \u000F.\u0005.\u0001(false, _param0, _param1))
              {
                byte[] buffer = cryptoTransform.TransformFinalBlock(inputBuffer1, 0, inputBuffer1.Length);
                obj1.Write(buffer, 0, buffer.Length);
                goto default;
              }
            }
            else
              goto label_27;
          case 3:
            \u000F.\u0005.\u0001(obj1, 58555003);
            byte[] inputBuffer2 = \u000F.\u0005.\u0001((byte[]) null, (byte[]) null, 1, _param3);
            using (ICryptoTransform cryptoTransform = \u000F.\u0005.\u0001(false, _param1, _param0))
            {
              byte[] buffer = cryptoTransform.TransformFinalBlock(inputBuffer2, 0, inputBuffer2.Length);
              obj1.Write(buffer, 0, buffer.Length);
              goto default;
            }
          default:
label_41:
            obj1.Flush();
            obj1.Close();
            return obj1.ToArray();
        }
label_6:
        int length2;
        byte[] buffer1 = new byte[length2];
        *(int*) ((IntPtr) voidPtr + 44) = \u000F.\u0005.\u0001(obj2, buffer1);
        if (*(int*) ((IntPtr) voidPtr + 44) > 0)
          obj1.Write(buffer1, 0, *(int*) ((IntPtr) voidPtr + 44));
        else
          goto label_9;
label_8:
        if (!obj2.IsNeedingInput)
        {
          length2 = 512;
          goto label_6;
        }
label_9:
        if (true)
        {
          \u000F.\u0005.\u0001(obj2);
          while (!obj2.IsFinished)
          {
            byte[] buffer2 = new byte[512];
            *(int*) ((IntPtr) voidPtr + 48) = \u000F.\u0005.\u0001(obj2, buffer2);
            if (*(int*) ((IntPtr) voidPtr + 48) > 0)
              obj1.Write(buffer2, 0, *(int*) ((IntPtr) voidPtr + 48));
            else
              break;
          }
          *(long*) ((IntPtr) voidPtr + 16) = obj2.\u0001;
          \u000F.\u0005.\u0001(obj1, 33639248);
          \u000F.\u0005.\u0001(obj1, 20);
          \u000F.\u0005.\u0001(obj1, 20);
          \u000F.\u0005.\u0001(obj1, 0);
          \u000F.\u0005.\u0001(obj1, 8);
          \u000F.\u0005.\u0001(obj1, (int) *(long*) voidPtr);
          \u000F.\u0005.\u0001(obj1, (int) num1);
          \u000F.\u0005.\u0001(obj1, (int) *(long*) ((IntPtr) voidPtr + 16));
        }
        else
          goto label_41;
label_15:
        \u000F.\u0005.\u0001(obj1, _param3.Length);
        \u000F.\u0005.\u0001(obj1, bytes.Length);
        \u000F.\u0005.\u0001(obj1, 0);
        \u000F.\u0005.\u0001(obj1, 0);
        \u000F.\u0005.\u0001(obj1, 0);
        \u000F.\u0005.\u0001(obj1, 0);
        \u000F.\u0005.\u0001(obj1, 0);
        \u000F.\u0005.\u0001(obj1, 0);
        obj1.Write(bytes, 0, bytes.Length);
        \u000F.\u0005.\u0001(obj1, 101010256);
        \u000F.\u0005.\u0001(obj1, 0);
        \u000F.\u0005.\u0001(obj1, 0);
        \u000F.\u0005.\u0001(obj1, 1);
        \u000F.\u0005.\u0001(obj1, 1);
        \u000F.\u0005.\u0001(obj1, 46 + bytes.Length);
        \u000F.\u0005.\u0001(obj1, (int) ((long) (30 + bytes.Length) + *(long*) ((IntPtr) voidPtr + 16)));
        \u000F.\u0005.\u0001(obj1, 0);
        obj1.Seek(*(long*) ((IntPtr) voidPtr + 8), SeekOrigin.Begin);
        \u000F.\u0005.\u0001(obj1, (int) *(long*) ((IntPtr) voidPtr + 16));
        goto label_41;
label_27:
        obj1.Position = *(long*) ((IntPtr) voidPtr + 32);
        byte[] dst;
        *(int*) ((IntPtr) voidPtr + 52) = *(int*) ((IntPtr) voidPtr + 52) + dst.Length;
label_28:
        length2 = *(int*) ((IntPtr) voidPtr + 52);
        if (true)
        {
          int length3 = _param3.Length;
          if (length2 < length3)
          {
            dst = new byte[Math.Min(2097151, _param3.Length - *(int*) ((IntPtr) voidPtr + 52))];
            Buffer.BlockCopy((Array) _param3, *(int*) ((IntPtr) voidPtr + 52), (Array) dst, 0, dst.Length);
            *(long*) ((IntPtr) voidPtr + 24) = obj1.Position;
            \u000F.\u0005.\u0001(obj1, 0);
            \u000F.\u0005.\u0001(obj1, dst.Length);
            \u0005.\u0005.\u0006 obj3 = new \u0005.\u0005.\u0006();
            \u000F.\u0005.\u0001(obj3, dst);
            while (!obj3.IsNeedingInput)
            {
              byte[] buffer3 = new byte[512];
              *(int*) ((IntPtr) voidPtr + 56) = \u000F.\u0005.\u0001(obj3, buffer3);
              if (*(int*) ((IntPtr) voidPtr + 56) > 0)
                obj1.Write(buffer3, 0, *(int*) ((IntPtr) voidPtr + 56));
              else
                break;
            }
            \u000F.\u0005.\u0001(obj3);
            while (!obj3.IsFinished)
            {
              byte[] buffer4 = new byte[512];
              *(int*) ((IntPtr) voidPtr + 60) = \u000F.\u0005.\u0001(obj3, buffer4);
              if (*(int*) ((IntPtr) voidPtr + 60) > 0)
                obj1.Write(buffer4, 0, *(int*) ((IntPtr) voidPtr + 60));
              else
                break;
            }
            *(long*) ((IntPtr) voidPtr + 32) = obj1.Position;
            obj1.Position = *(long*) ((IntPtr) voidPtr + 24);
            \u000F.\u0005.\u0001(obj1, (int) obj3.\u0001);
            goto label_27;
          }
          else
            goto label_41;
        }
        else
          goto label_6;
      }
      catch (Exception ex)
      {
        if (true)
          \u0005.\u0005.\u0001 = "ERR 2003: " + ex.Message;
        throw;
      }
    }

    static string \u0001(TimerNodeModel.TimerInfo _param0) => global::\u0001.\u007E\u0001((object) _param0);

    static unsafe void \u0001(\u0005.\u0005.\u0007.\u0001 _param0, [In] int[] obj1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(36);
      _param0.\u0001 = new byte[_param0.\u0001.Length];
      *(int*) voidPtr = obj1.Length / 2;
      *(int*) ((IntPtr) voidPtr + 4) = (*(int*) voidPtr + 1) / 2;
      *(int*) ((IntPtr) voidPtr + 8) = 0;
      *(int*) ((IntPtr) voidPtr + 12) = 0;
      while (*(int*) ((IntPtr) voidPtr + 12) < _param0.\u0003)
      {
        _param0.\u0001[*(int*) ((IntPtr) voidPtr + 12)] = 0;
        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
      }
      int[] numArray = new int[*(int*) voidPtr];
      numArray[*(int*) voidPtr - 1] = 0;
      *(int*) ((IntPtr) voidPtr + 16) = *(int*) voidPtr - 1;
      while (*(int*) ((IntPtr) voidPtr + 16) >= 0)
      {
        if (obj1[2 * *(int*) ((IntPtr) voidPtr + 16) + 1] != -1)
        {
          *(int*) ((IntPtr) voidPtr + 20) = numArray[*(int*) ((IntPtr) voidPtr + 16)] + 1;
          if (*(int*) ((IntPtr) voidPtr + 20) > _param0.\u0003)
          {
            *(int*) ((IntPtr) voidPtr + 20) = _param0.\u0003;
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
          }
          numArray[obj1[2 * *(int*) ((IntPtr) voidPtr + 16)]] = numArray[obj1[2 * *(int*) ((IntPtr) voidPtr + 16) + 1]] = *(int*) ((IntPtr) voidPtr + 20);
        }
        else
        {
          *(int*) ((IntPtr) voidPtr + 24) = numArray[*(int*) ((IntPtr) voidPtr + 16)];
          ++_param0.\u0001[*(int*) ((IntPtr) voidPtr + 24) - 1];
          _param0.\u0001[obj1[2 * *(int*) ((IntPtr) voidPtr + 16)]] = (byte) numArray[*(int*) ((IntPtr) voidPtr + 16)];
        }
        *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) - 1;
      }
      if (*(int*) ((IntPtr) voidPtr + 8) == 0)
        return;
      int index1 = _param0.\u0003 - 1;
label_15:
      do
        ;
      while (_param0.\u0001[--index1] == 0);
label_16:
      --_param0.\u0001[index1];
      ++_param0.\u0001[++index1];
      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - (1 << _param0.\u0003 - 1 - index1);
      int num1 = *(int*) ((IntPtr) voidPtr + 8);
label_17:
      if (num1 <= 0 || index1 >= _param0.\u0003 - 1)
      {
        if (*(int*) ((IntPtr) voidPtr + 8) <= 0)
        {
          _param0.\u0001[_param0.\u0003 - 1] += *(int*) ((IntPtr) voidPtr + 8);
          _param0.\u0001[_param0.\u0003 - 2] -= *(int*) ((IntPtr) voidPtr + 8);
          int num2 = 2 * *(int*) ((IntPtr) voidPtr + 4);
          *(int*) ((IntPtr) voidPtr + 28) = _param0.\u0003;
          while (*(int*) ((IntPtr) voidPtr + 28) != 0)
          {
            *(int*) ((IntPtr) voidPtr + 32) = _param0.\u0001[*(int*) ((IntPtr) voidPtr + 28) - 1];
            while (*(int*) ((IntPtr) voidPtr + 32) > 0)
            {
              int num3 = 2 * obj1[num2++];
              if (false)
              {
                num1 = num3;
                goto label_17;
              }
              else
              {
                int index2 = num3;
                if (obj1[index2 + 1] == -1)
                {
                  _param0.\u0001[obj1[index2]] = (byte) *(int*) ((IntPtr) voidPtr + 28);
                  *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) - 1;
                }
              }
            }
            *(int*) ((IntPtr) voidPtr + 28) = *(int*) ((IntPtr) voidPtr + 28) - 1;
          }
        }
        else
          goto label_15;
      }
      else
        goto label_16;
    }

    static unsafe void \u0001([In] \u0005.\u0005.\u0007 obj0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(20);
      *(int*) voidPtr = 0;
      while (*(int*) voidPtr < obj0.\u000E)
      {
        *(int*) ((IntPtr) voidPtr + 4) = (int) obj0.\u0002[*(int*) voidPtr] & (int) byte.MaxValue;
        int num1 = (int) obj0.\u0001[*(int*) voidPtr];
        int num2 = num1 - 1;
        if (num1 != 0)
        {
          *(int*) ((IntPtr) voidPtr + 8) = \u000F.\u0005.\u0001(*(int*) ((IntPtr) voidPtr + 4), obj0);
          \u000F.\u0005.\u0001(obj0.\u0001, *(int*) ((IntPtr) voidPtr + 8));
          *(int*) ((IntPtr) voidPtr + 12) = (*(int*) ((IntPtr) voidPtr + 8) - 261) / 4;
          if (*(int*) ((IntPtr) voidPtr + 12) > 0 && *(int*) ((IntPtr) voidPtr + 12) <= 5)
            \u000F.\u0005.\u0001(obj0.\u0001, *(int*) ((IntPtr) voidPtr + 4) & (1 << *(int*) ((IntPtr) voidPtr + 12)) - 1, *(int*) ((IntPtr) voidPtr + 12));
          *(int*) ((IntPtr) voidPtr + 16) = \u000F.\u0005.\u0001(obj0, num2);
          \u000F.\u0005.\u0001(obj0.\u0002, *(int*) ((IntPtr) voidPtr + 16));
          *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 16) / 2 - 1;
          if (*(int*) ((IntPtr) voidPtr + 12) > 0)
            \u000F.\u0005.\u0001(obj0.\u0001, num2 & (1 << *(int*) ((IntPtr) voidPtr + 12)) - 1, *(int*) ((IntPtr) voidPtr + 12));
        }
        else
          \u000F.\u0005.\u0001(obj0.\u0001, *(int*) ((IntPtr) voidPtr + 4));
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
      \u000F.\u0005.\u0001(obj0.\u0001, 256);
    }
  }
}
