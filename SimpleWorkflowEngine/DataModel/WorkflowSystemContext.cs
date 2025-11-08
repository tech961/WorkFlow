// Decompiled with JetBrains decompiler
// Type: SimpleWorkflowEngine.DataModel.WorkflowSystemContext
// Assembly: SimpleWorkflowEngine, Version=1.0.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 0364C0C9-DE78-4B86-B425-B5292D214CFD
// Assembly location: C:\Users\E.jadidi\Desktop\New folder (6)\my.dll

using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Z.BulkOperations;

#nullable disable
namespace SimpleWorkflowEngine.DataModel
{
  internal class WorkflowSystemContext : DbContext
  {
    public WorkflowSystemContext(string connectionString)
      : base(connectionString)
    {
      this.Configuration.LazyLoadingEnabled = false;
      this.EndEventNodes = this.Set<EndEventNode>();
      this.ForkNodes = this.Set<ForkNode>();
      this.JoinNodes = this.Set<JoinNode>();
      this.Processes = this.Set<Process>();
      this.ProcessNodes = this.Set<ProcessNode>();
      this.ServiceTaskNodes = this.Set<ServiceTaskNode>();
      this.StartEventNodes = this.Set<StartEventNode>();
      this.UserTaskNodes = this.Set<UserTaskNode>();
      this.ProcessInstances = this.Set<ProcessInstance>();
      this.ProcessExecutionSteps = this.Set<ProcessExecutionStep>();
      this.ForkNextProcessNodes = this.Set<ForkNextProcessNode>();
      this.JoinPreviousProcessNode = this.Set<SimpleWorkflowEngine.DataModel.JoinPreviousProcessNode>();
      this.TimerNodes = this.Set<TimerNode>();
    }

    protected virtual void OnModelCreating(DbModelBuilder modelBuilder)
    {
      throw new UnintentionalCodeFirstException();
    }

    internal virtual DbSet<EndEventNode> EndEventNodes { get; set; }

    internal virtual DbSet<ForkNode> ForkNodes { get; set; }

    internal virtual DbSet<JoinNode> JoinNodes { get; set; }

    internal virtual DbSet<Process> Processes { get; set; }

    internal virtual DbSet<ProcessNode> ProcessNodes { get; set; }

    internal virtual DbSet<ServiceTaskNode> ServiceTaskNodes { get; set; }

    internal virtual DbSet<StartEventNode> StartEventNodes { get; set; }

    internal virtual DbSet<UserTaskNode> UserTaskNodes { get; set; }

    internal virtual DbSet<ProcessInstance> ProcessInstances { get; set; }

    internal virtual DbSet<ProcessExecutionStep> ProcessExecutionSteps { get; set; }

    internal virtual DbSet<ForkNextProcessNode> ForkNextProcessNodes { get; set; }

    internal virtual DbSet<SimpleWorkflowEngine.DataModel.JoinPreviousProcessNode> JoinPreviousProcessNode { get; set; }

    internal virtual DbSet<TimerNode> TimerNodes { get; set; }

    public virtual int SaveChanges()
    {
      do
      {
        DbContextTransaction contextTransaction = \u0082.\u007E\u0090((object) \u0081.\u008F((object) this));
        try
        {
          if (true)
            goto label_3;
label_2:
          \u0005.\u007E\u0010((object) contextTransaction);
          goto label_9;
label_3:
          DbTransaction underlyingTransaction = \u0083.\u007E\u0091((object) contextTransaction);
          \u0084.\u0092((DbContext) this, (Action<BulkOperation>) (operation =>
          {
            operation.UseInternalTransaction = false;
            \u008D.\u007E\u009B((object) operation, underlyingTransaction);
          }));
          goto label_2;
        }
        finally
        {
          if (contextTransaction == null)
            goto label_7;
label_5:
          if (true)
            \u0005.\u007E\u000E((object) contextTransaction);
label_7:
          if (false)
            goto label_5;
        }
label_9:;
      }
      while (false);
      return 0;
    }
  }
}
