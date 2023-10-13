// Decompiled with JetBrains decompiler
// Type: KFSMEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

public class KFSMEvent
{
  public string name;
  public KFSMState GoToStateOnEvent;
  public KFSMUpdateMode updateMode;
  public KFSMCallback OnEvent;
  public KFSMEventCondition OnCheckCondition;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsValid(KFSMState state) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KFSMEvent(string name) => throw null;
}
