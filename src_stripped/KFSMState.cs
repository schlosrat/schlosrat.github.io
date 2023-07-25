// Decompiled with JetBrains decompiler
// Type: KFSMState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class KFSMState
{
  public string name;
  public double TimeAtStateEnter;
  public int FrameCountAtStateEnter;
  public KFSMUpdateMode updateMode;
  public KFSMStateChange OnEnter;
  public KFSMCallback OnUpdate;
  public KFSMCallback OnFixedUpdate;
  public KFSMCallback OnLateUpdate;
  public KFSMStateChange OnLeave;
  protected List<KFSMEvent> stateEvents;

  public List<KFSMEvent> StateEvents
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsValid(KFSMEvent ev) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KFSMState(string name) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddEvent(KFSMEvent ev) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override string ToString() => throw null;
}
