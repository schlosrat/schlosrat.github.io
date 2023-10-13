// Decompiled with JetBrains decompiler
// Type: WaitForAsyncHandlesFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Flow;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine.ResourceManagement.AsyncOperations;

public class WaitForAsyncHandlesFlowAction : FlowAction
{
  private Action _resolve;
  private Task[] _tasks;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public WaitForAsyncHandlesFlowAction(List<AsyncOperationHandle> handles) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void DoAction(Action resolve, Action<string> reject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AsyncWaitForHandlesCompletionAsync() => throw null;
}
