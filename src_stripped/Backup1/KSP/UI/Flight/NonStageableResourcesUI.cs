// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.NonStageableResourcesUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  public class NonStageableResourcesUI : UIFlightHUDInstrument
  {
    [SerializeField]
    private ContextBindRoot _resourceListElementPrefab;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NonStageableResourcesUI() => throw null;
  }
}
