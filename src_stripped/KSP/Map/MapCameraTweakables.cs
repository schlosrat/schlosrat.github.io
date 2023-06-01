// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapCameraTweakables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Map
{
  [JsonObject(MemberSerialization.OptIn)]
  public class MapCameraTweakables : CameraTweakables
  {
    [JsonProperty]
    public ZoomResponseMethod ZoomResponsiveness;
    [JsonProperty]
    public FloatCurve ZoomCurve;
    [JsonProperty]
    public double TranslationSpeed;
    [JsonProperty]
    public double ExponentialZoomFactor;
    [JsonProperty]
    public float KeyBoardDragMultiplier;
    [JsonProperty]
    public float MouseDragMultiplier;
    [JsonProperty]
    public bool InvertMouseDrag;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void LoadConfigFromFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCameraTweakables() => throw null;
  }
}
