// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.UIElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  public abstract class UIElement : KerbalMonoBehaviour
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void DestroyAllChildren(Transform root) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected T InstantiatePrefabToParent<T>(T prefab, Transform parent, string name = null) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIElement() => throw null;
  }
}
