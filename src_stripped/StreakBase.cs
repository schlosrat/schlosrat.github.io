// Decompiled with JetBrains decompiler
// Type: StreakBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class StreakBase
{
  private static StreakBase m_Instance;
  internal List<StreakObject> streakRenderers;

  public static StreakBase instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnAddStreakObject(StreakObject r) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnRemoveStreakObject(StreakObject r) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public StreakBase() => throw null;
}
