// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapCameraTweakables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Map
{
  [JsonObject]
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
    public override void LoadConfigFromFile(string tweakablesName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCameraTweakables() => throw null;
  }
}
