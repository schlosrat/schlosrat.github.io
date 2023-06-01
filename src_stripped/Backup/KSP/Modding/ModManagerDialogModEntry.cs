// Decompiled with JetBrains decompiler
// Type: KSP.Modding.ModManagerDialogModEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.Modding
{
  public class ModManagerDialogModEntry : MonoBehaviour, IPooledUI
  {
    [SerializeField]
    private TextMeshProUGUI _labelModName;
    [SerializeField]
    private TextMeshProUGUI _labelModAuthor;
    [SerializeField]
    private TextMeshProUGUI _labelModVersion;
    private ModManagerDialog _parent;
    private KSP2Mod _targetMod;

    public GameObjectPool<ModManagerDialogModEntry> ObjectPool
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(KSP2Mod mod, ModManagerDialog parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnToPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMouseDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModManagerDialogModEntry() => throw null;
  }
}
