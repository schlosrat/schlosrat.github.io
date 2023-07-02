// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIVesselHudLocatorDataBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding.Core
{
  public abstract class UIVesselHudLocatorDataBinding : KerbalMonoBehaviour
  {
    [Tooltip("This is how we fade in/out our UI elements as well as change its position if necessary.\r\nShould Contain all UI elements bound in this Binder Object.")]
    [SerializeField]
    [Header("Group for showing/hiding bound UI")]
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
