// Decompiled with JetBrains decompiler
// Type: KSP.Game.FlagObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [Tooltip("Name for the float parameter that sets the playback speed multiplayer for the plant animation.")]
    public string FlagPlaybackMulParamName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlagObject() => throw null;
  }
}
