// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.Engine.ExecutionEngine
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using Microsoft.Practices.Unity;
using SimpleWorkflowEngine.DataModel;
using SimpleWorkflowEngine.Models;
using SimpleWorkflowEngine.RuntimeModel;
using SimpleWorkflowEngine.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Transactions;

#nullable disable
namespace SimpleWorkflowEngine.Engine
{
  internal class ExecutionEngine
  {
    internal readonly ExecutionEngine.SchedulerEngine \u0001;
    internal ExecutionEngine.ProcessMetadataCollection \u0001;
    private bool \u0001;

    public ExecutionEngine()
    {
      this.\u0001 = new ExecutionEngine.SchedulerEngine(new Action<TimerNodeModel.TimerInfo>(this.\u0001), new Action<List<TimerNodeModel.TimerInfo>>(this.\u0001));
    }

    private ProcessModel \u0001(Process _param1_1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ExecutionEngine.\u0002 obj1 = new ExecutionEngine.\u0002();
      // ISSUE: variable of a compiler-generated type
      ExecutionEngine.\u0002 obj2;
      if (true)
        obj2 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = _param1_1.\u0001();
      List<ProcessNodeModel> processNodeModelList = new List<ProcessNodeModel>();
      List<ProcessNodeModel> source;
      if (true)
        source = processNodeModelList;
      IEnumerator<ProcessNode> enumerator = _param1_1.ProcessNodes.GetEnumerator();
      try
      {
        while (global::\u0004.\u007E\u0008((object) enumerator))
        {
          ProcessNode current = enumerator.Current;
          // ISSUE: reference to a compiler-generated field
          source.Add(current.\u0001(obj2.\u0001));
        }
      }
      finally
      {
        if (enumerator != null)
          global::\u0005.\u007E\u000E((object) enumerator);
      }
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001.ProcessNodeModels = source;
      try
      {
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001.StartEventNode = (\u0005.\u0002) source.Single<ProcessNodeModel>((Func<ProcessNodeModel, bool>) (_param1_2 => _param1_2.NodeKind == ProcessNodeKind.StartEventNode));
        // ISSUE: reference to a compiler-generated field
        ProcessModel processModel = obj2.\u0001;
        // ISSUE: reference to a compiler-generated method
        \u000F.\u0005.\u0001(_param1_1.ProcessNodes.Single<ProcessNode>(new Func<ProcessNode, bool>(obj2.\u0001)), processModel);
      }
      catch (Exception ex)
      {
        throw new Exception(\u000E.\u0003.\u0001(107396122), ex);
      }
      // ISSUE: reference to a compiler-generated field
      return obj2.\u0001;
    }

    private unsafe void \u0001(TimerNodeModel.TimerInfo _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      TimerNodeModel timerNodeModel = (TimerNodeModel) null;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ExecutionEngine.\u0007 obj1 = new ExecutionEngine.\u0007();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = UnityContainerExtensions.Resolve<IExecutionContext>(DependencyResolver.Container, new ResolverOverride[0]);
        IWorkflowVoucher workflowVoucher = UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]).\u0001().GetWorkflowVoucher(_param1.WorkflowVoucherID, _param1.WorkflowVoucherKind);
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001.Initialize(_param1.UserId, _param1.CompanyId, _param1.FiscalYearId, workflowVoucher);
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001.WorkflowData = _param1.WorkflowData;
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001.StepId = _param1.StepId;
        TransactionScope transactionScope = new TransactionScope();
        try
        {
          WorkflowSystemContext workflowSystemContext = \u000F.\u0005.\u0001(this);
          try
          {
            try
            {
              // ISSUE: variable of a compiler-generated type
              ExecutionEngine.\u0007 obj2 = obj1;
              DbSet<ProcessExecutionStep> processExecutionSteps = workflowSystemContext.ProcessExecutionSteps;
              // ISSUE: type reference
              ParameterExpression parameterExpression = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessExecutionStep)), \u000E.\u0003.\u0001(107396549));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              // ISSUE: method reference
              Expression<Func<ProcessExecutionStep, bool>> predicate = Expression.Lambda<Func<ProcessExecutionStep, bool>>((Expression) \u001D.\u0088((Expression) \u0019.\u0083((Expression) parameterExpression, (MethodInfo) \u0018.\u0082(__methodref (ProcessExecutionStep.get_ID))), (Expression) \u0019.\u0083((Expression) \u001C.\u0087((Expression) \u001A.\u0084((object) obj1, global::\u000F.\u0019(__typeref (ExecutionEngine.\u0007))), \u001B.\u0086(__fieldref (ExecutionEngine.\u0007.\u0001))), (MethodInfo) \u0018.\u0082(__methodref (IExecutionContext.get_StepId))), false, (MethodInfo) \u0018.\u0082(__methodref (Guid.op_Equality))), parameterExpression);
              ProcessExecutionStep processExecutionStep = ((IQueryable<ProcessExecutionStep>) processExecutionSteps).Single<ProcessExecutionStep>(predicate);
              // ISSUE: reference to a compiler-generated field
              obj2.\u0001 = processExecutionStep;
            }
            catch (Exception ex)
            {
              throw new InvalidOperationException(\u000E.\u0003.\u0001(107396544), ex);
            }
            ProcessInstance processInstance;
            do
            {
              DbSet<ProcessInstance> processInstances = workflowSystemContext.ProcessInstances;
              // ISSUE: type reference
              ParameterExpression parameterExpression = \u0017.\u0081(global::\u000F.\u0019(__typeref (ProcessInstance)), \u000E.\u0003.\u0001(107396549));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              // ISSUE: method reference
              Expression<Func<ProcessInstance, bool>> predicate = Expression.Lambda<Func<ProcessInstance, bool>>((Expression) \u001E.\u0089((Expression) \u0019.\u0083((Expression) parameterExpression, (MethodInfo) \u0018.\u0082(__methodref (ProcessInstance.get_ID))), (Expression) \u0019.\u0083((Expression) \u001C.\u0087((Expression) \u001A.\u0084((object) obj1, global::\u000F.\u0019(__typeref (ExecutionEngine.\u0007))), \u001B.\u0086(__fieldref (ExecutionEngine.\u0007.\u0001))), (MethodInfo) \u0018.\u0082(__methodref (ProcessExecutionStep.get_ProcessID)))), parameterExpression);
              processInstance = ((IQueryable<ProcessInstance>) processInstances).Single<ProcessInstance>(predicate);
              *(int*) voidPtr = !processInstance.Closed ? processInstance.ProcessMetaDataID : throw new InvalidOperationException(\u000E.\u0003.\u0001(107396523));
              // ISSUE: reference to a compiler-generated field
              *(int*) ((IntPtr) voidPtr + 4) = obj1.\u0001.ProcessNodeID;
              try
              {
                timerNodeModel = (TimerNodeModel) this.\u0001.\u0001(*(int*) voidPtr, *(int*) ((IntPtr) voidPtr + 4));
              }
              catch (Exception ex)
              {
                throw new InvalidOperationException(\u000E.\u0003.\u0001(107396510), ex);
              }
            }
            while (false);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            timerNodeModel.\u0002(processInstance, obj1.\u0001, workflowSystemContext, obj1.\u0001);
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
      }
      catch (Exception ex1)
      {
        string str1 = global::\u0007.\u0016(\u000E.\u0003.\u0001(107396477), global::\u0008.\u0017());
        if (timerNodeModel != null)
        {
          string str2 = \u007F.\u008D(str1, \u000E.\u0003.\u0001(107396392), timerNodeModel.Process.Name, global::\u0008.\u0017());
          string str3 = global::\u0007.\u0016(str2, \u0080.\u008E(\u000E.\u0003.\u0001(107396403), (object) timerNodeModel.Process.Version, (object) global::\u0008.\u0017()));
          str1 = \u007F.\u008D(str3, \u000E.\u0003.\u0001(107396378), timerNodeModel.Name, global::\u0008.\u0017());
        }
        string message = global::\u0007.\u0016(str1, global::\u0001.\u007E\u0003((object) ex1));
        try
        {
          throw new Exception(message, ex1);
        }
        catch (Exception ex2)
        {
          UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]).\u0001().LogError(ex2);
          throw;
        }
      }
    }

    private void \u0001(List<TimerNodeModel.TimerInfo> _param1_1)
    {
      if (this.\u0001)
        return;
      this.\u0001 = true;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ExecutionEngine.\u0008 obj = new ExecutionEngine.\u0008();
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = _param1_1.Select<TimerNodeModel.TimerInfo, Guid>((Func<TimerNodeModel.TimerInfo, Guid>) (_param1_2 => _param1_2.StepId)).ToArray<Guid>();
        // ISSUE: reference to a compiler-generated field
        // ISSUE: object of a compiler-generated type is created
        Dictionary<Guid, bool> dictionary = ((IQueryable<ProcessExecutionStep>) \u000F.\u0005.\u0001(this).ProcessExecutionSteps).Where<ProcessExecutionStep>((Expression<Func<ProcessExecutionStep, bool>>) (processExecutionStep => obj.\u0001.Contains<Guid>(processExecutionStep.ID))).Select(processExecutionStep => new \u003C\u003Ef__AnonymousType0<Guid, bool>(processExecutionStep.ID, processExecutionStep.Done)).ToDictionary(_param1_3 => _param1_3.ID, _param1_4 => _param1_4.Done);
        while (_param1_1.Count > 0)
        {
          TimerNodeModel.TimerInfo timerInfo = _param1_1[0];
label_4:
          bool flag;
          while (dictionary.TryGetValue(timerInfo.StepId, out flag))
          {
            do
            {
              if (true)
              {
                if (flag)
                  goto label_9;
              }
              else
                goto label_4;
            }
            while (false);
            \u000F.\u0005.\u0001(this, timerInfo);
            break;
          }
label_9:
          _param1_1.RemoveAt(0);
        }
      }
      catch (Exception ex)
      {
      }
      finally
      {
        this.\u0001 = false;
      }
    }

    [CompilerGenerated]
    internal ProcessModel[] \u0001(Process[] _param1_1)
    {
      \u0008.\u0001 obj1;
      if (true)
      {
        \u0008.\u0001 obj2 = UnityContainerExtensions.Resolve<\u0008.\u0001>(DependencyResolver.Container, new ResolverOverride[0]);
        if (true)
          obj1 = obj2;
      }
      // ISSUE: method pointer
      ProcessModel[] array = ((IEnumerable<Process>) _param1_1).Select<Process, ProcessModel>(new Func<Process, ProcessModel>((object) this, __methodptr(\u0001))).ToArray<ProcessModel>();
      List<IProcessNodeModel> list = ((IEnumerable<ProcessModel>) array).SelectMany<ProcessModel, IProcessNodeModel>((Func<ProcessModel, IEnumerable<IProcessNodeModel>>) (_param1_2 => _param1_2.ProcessNodeModels.Cast<IProcessNodeModel>())).ToList<IProcessNodeModel>();
      obj1.\u0001((IList<IProcessNodeModel>) list);
      return array;
    }

    internal class ProcessMetadataCollection
    {
      private readonly Dictionary<int, IList<ProcessModel>> \u0001;

      public ProcessModel this[int _param1_1]
      {
        get
        {
          IList<ProcessModel> source;
          return !this.\u0001.TryGetValue(_param1_1, out source) ? (ProcessModel) null : source.SingleOrDefault<ProcessModel>((Func<ProcessModel, bool>) (_param1_2 => _param1_2.Active));
        }
      }

      public ProcessMetadataCollection(ProcessModel[] process)
      {
        this.\u0001 = new Dictionary<int, IList<ProcessModel>>((IDictionary<int, IList<ProcessModel>>) ((IEnumerable<ProcessModel>) process).GroupBy<ProcessModel, int>((Func<ProcessModel, int>) (_param1 => _param1.VoucherKind)).ToDictionary<IGrouping<int, ProcessModel>, int, IList<ProcessModel>>((Func<IGrouping<int, ProcessModel>, int>) (_param1 => _param1.Key), (Func<IGrouping<int, ProcessModel>, IList<ProcessModel>>) (_param1 => (IList<ProcessModel>) _param1.OrderBy<ProcessModel, int>((Func<ProcessModel, int>) (_param1 => _param1.Version)).ToList<ProcessModel>())));
      }

      public ProcessNodeModel \u0001(int _param1, int _param2)
      {
label_0:
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ExecutionEngine.ProcessMetadataCollection.\u0001 obj = new ExecutionEngine.ProcessMetadataCollection.\u0001();
        ProcessNodeModel processNodeModel;
        do
        {
          // ISSUE: reference to a compiler-generated field
          obj.\u0001 = _param1;
          // ISSUE: reference to a compiler-generated field
          obj.\u0002 = _param2;
          if (true)
          {
            using (Dictionary<int, IList<ProcessModel>>.ValueCollection.Enumerator enumerator = this.\u0001.Values.GetEnumerator())
            {
              do
              {
                ProcessModel processModel;
                do
                {
                  if (enumerator.MoveNext())
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    processModel = enumerator.Current.FirstOrDefault<ProcessModel>(obj.\u0001 ?? (obj.\u0001 = new Func<ProcessModel, bool>(obj.\u0001)));
                  }
                  else
                    goto label_6;
                }
                while (processModel == null);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                processNodeModel = processModel.ProcessNodeModels.Single<ProcessNodeModel>(obj.\u0001 ?? (obj.\u0001 = new Func<ProcessNodeModel, bool>(obj.\u0001)));
              }
              while (false);
              goto label_8;
            }
label_6:;
          }
          else
            goto label_0;
        }
        while (false);
        return (ProcessNodeModel) null;
label_8:
        return processNodeModel;
      }

      public IEnumerable<UserTaskNodeModel> \u0001(int _param1_1, IEnumerable<int> _param2)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ExecutionEngine.ProcessMetadataCollection.\u0002 obj = new ExecutionEngine.ProcessMetadataCollection.\u0002();
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = _param1_1;
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = _param2;
        foreach (IEnumerable<ProcessModel> source in this.\u0001.Values)
        {
          if (true)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            ProcessModel processModel = source.FirstOrDefault<ProcessModel>(obj.\u0001 ?? (obj.\u0001 = new Func<ProcessModel, bool>(obj.\u0001)));
            if (processModel != null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              return processModel.ProcessNodeModels.Where<ProcessNodeModel>(obj.\u0001 ?? (obj.\u0001 = new Func<ProcessNodeModel, bool>(obj.\u0001))).Where<ProcessNodeModel>((Func<ProcessNodeModel, bool>) (_param1_2 => _param1_2.NodeKind == ProcessNodeKind.UserTaskNode)).Select<ProcessNodeModel, UserTaskNodeModel>((Func<ProcessNodeModel, UserTaskNodeModel>) (_param1_3 => (UserTaskNodeModel) _param1_3));
            }
          }
        }
        return (IEnumerable<UserTaskNodeModel>) null;
      }

      public \u0001[] \u0001<\u0001>(ProcessNodeKind _param1) where \u0001 : ProcessNodeModel
      {
        List<\u0001> objList1;
        do
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          ExecutionEngine.ProcessMetadataCollection.\u0003<\u0001> obj = new ExecutionEngine.ProcessMetadataCollection.\u0003<\u0001>();
          // ISSUE: reference to a compiler-generated field
          obj.\u0001 = _param1;
          objList1 = new List<\u0001>();
          foreach (KeyValuePair<int, IList<ProcessModel>> keyValuePair in this.\u0001)
          {
            List<\u0001> objList2 = objList1;
            IList<ProcessModel> source = keyValuePair.Value;
            // ISSUE: reference to a compiler-generated field
            object selector = (object) (int) obj.\u0001;
            if (selector == 0)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              selector = (object) (Func<ProcessModel, IEnumerable<\u0001>>) (obj.\u0001 = (ProcessNodeKind) new Func<ProcessModel, IEnumerable<\u0001>>(obj.\u0001));
            }
            IEnumerable<\u0001> collection = source.SelectMany<ProcessModel, \u0001>((Func<ProcessModel, IEnumerable<\u0001>>) selector);
            objList2.AddRange(collection);
          }
        }
        while (false);
        return objList1.ToArray();
      }
    }

    internal class SchedulerEngine
    {
      internal readonly object \u0001;
      internal readonly Timer \u0001;
      internal readonly List<TimerNodeModel.TimerInfo> \u0001;
      internal readonly ExecutionEngine.\u0001 \u0001;
      private readonly Action<TimerNodeModel.TimerInfo> \u0001;
      internal readonly Action<List<TimerNodeModel.TimerInfo>> \u0001;
      internal bool \u0001;
      internal bool \u0002;
      internal int \u0001;

      public SchedulerEngine(
        Action<TimerNodeModel.TimerInfo> timerTickAction,
        Action<List<TimerNodeModel.TimerInfo>> exceptionalTimerTickAction)
      {
        this.\u0001 = timerTickAction;
        this.\u0001 = exceptionalTimerTickAction;
        this.\u0001 = new List<TimerNodeModel.TimerInfo>();
        this.\u0001 = new ExecutionEngine.\u0001();
        this.\u0001 = ((ICollection) this.\u0001).SyncRoot;
        this.\u0001 = new Timer()
        {
          AutoReset = true,
          Interval = 1000.0
        };
        this.\u0001.Elapsed += new ElapsedEventHandler(this.\u0001);
      }

      private unsafe void \u0001(object _param1, ElapsedEventArgs _param2)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(5);
        if (this.\u0001)
          return;
        this.\u0001 = true;
        try
        {
          object obj = this.\u0001;
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
          try
          {
            // ISSUE: cast to a reference type
            \u008A.\u0097(obj, (bool&) ((IntPtr) voidPtr + 4));
            *(int*) voidPtr = 0;
            while (*(int*) voidPtr < this.\u0001.Count)
            {
              TimerNodeModel.TimerInfo timerInfo = this.\u0001[*(int*) voidPtr];
              if (\u008B.\u0098(timerInfo.DelayDateTime, \u0014.\u001E()))
              {
                \u000F.\u0005.\u0001(timerInfo, this);
                this.\u0001.RemoveAt(*(int*) voidPtr);
              }
              else
                goto label_6;
label_5:
              *(int*) voidPtr = *(int*) voidPtr - 1;
label_6:
              if (this.\u0002)
                break;
              if (true)
                *(int*) voidPtr = *(int*) voidPtr + 1;
              else
                goto label_5;
            }
          }
          finally
          {
            if (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
              \u008C.\u0099(obj);
          }
        }
        finally
        {
          ++this.\u0001;
          if (!this.\u0002 && this.\u0001 >= 600)
          {
            this.\u0001 = 0;
            \u000F.\u0005.\u0001(this);
          }
          this.\u0001 = false;
        }
      }
    }

    internal class \u0001
    {
      internal readonly Dictionary<Guid, int> \u0001;
      internal readonly List<TimerNodeModel.TimerInfo> \u0001;

      public int Count => this.\u0001.Count;

      public \u0001()
      {
        this.\u0001 = new List<TimerNodeModel.TimerInfo>();
        this.\u0001 = new Dictionary<Guid, int>();
      }
    }
  }
}
