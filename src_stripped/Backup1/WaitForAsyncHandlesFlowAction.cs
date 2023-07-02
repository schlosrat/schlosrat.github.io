// Decompiled with JetBrains decompiler
// Type: WaitForAsyncHandlesFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
