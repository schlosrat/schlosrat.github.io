// Decompiled with JetBrains decompiler
// Type: KSP.Game.FlagObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class FlagObject : KerbalMonoBehaviour
  {
    public const string PLANT_FLAG_PREFAB_NAME = "flag_portable";
    [Tooltip("Renderer for the cloth part of the flag.")]
    public SkinnedMeshRenderer ClothSkinnedMeshRenderer;
    [Space(10f)]
    [Tooltip("Name for the planted flag animation state.")]
    public string PlantedFlagAnimationStateName;
    [Tooltip("Name for the trigger parameter that starts the plant flag animation.")]
    public string FlagTriggerParamName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlagObject() => throw null;
  }
}
