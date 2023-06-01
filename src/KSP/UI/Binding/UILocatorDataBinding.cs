// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UILocatorDataBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  [RequireComponent(typeof (DebugDrawRectTransform))]
  [DisallowMultipleComponent]
  public class UILocatorDataBinding : MonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _groupPrefab;
    [SerializeField]
    private RectTransform _locationParent;
    private ContextBindRoot _instance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDataContext(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UILocatorDataBinding() => throw null;
  }
}
