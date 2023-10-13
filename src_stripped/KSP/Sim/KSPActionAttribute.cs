// Decompiled with JetBrains decompiler
// Type: KSP.Sim.KSPActionAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Obsolete("This is not being used in KSP2")]
  public class KSPActionAttribute : Attribute
  {
    public KSPActionGroup actionGroup;
    public KSPActionType actionType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPActionAttribute() => throw null;
  }
}
