// Decompiled with JetBrains decompiler
// Type: KFSMEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
