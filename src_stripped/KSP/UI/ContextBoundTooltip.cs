// Decompiled with JetBrains decompiler
// Type: KSP.UI.ContextBoundTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [RequireComponent(typeof (ContextBindRoot))]
  public class ContextBoundTooltip : StandardTooltip
  {
    private ContextBindRoot _bindRoot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateData(DataContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextBoundTooltip() => throw null;
  }
}
