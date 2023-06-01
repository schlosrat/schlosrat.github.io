// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIVesselHudLocatorDataBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding.Core
{
  public abstract class UIVesselHudLocatorDataBinding : KerbalMonoBehaviour
  {
    [SerializeField]
    [Header("Group for showing/hiding bound UI")]
    [Tooltip("This is how we fade in/out our UI elements as well as change its position if necessary.\r\nShould Contain all UI elements bound in this Binder Object.")]
    private CanvasGroup locationGroup;
    [FormerlySerializedAs("OffsetWhenDisabled")]
    [SerializeField]
    private Vector3 offsetWhenDisabled;

    protected CanvasGroup LocationGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected RectTransform LocationGroupTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected ContextBindRoot instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindData(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ClearDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIVesselHudLocatorDataBinding() => throw null;
  }
}
