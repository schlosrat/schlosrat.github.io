// Decompiled with JetBrains decompiler
// Type: KSP.Map.InfoPanelDeliveryResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.Map
{
  public class InfoPanelDeliveryResource : KerbalMonoBehaviour
  {
    [SerializeField]
    private TextMeshProUGUI _deliveryResourceName;
    [SerializeField]
    private TextMeshProUGUI _deliveryResourceValue;
    [SerializeField]
    private Color _positiveValueColor;
    [SerializeField]
    private Color _negativeValueColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(string deliveryResourceName, double deliveryResourceValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InfoPanelDeliveryResource() => throw null;
  }
}
