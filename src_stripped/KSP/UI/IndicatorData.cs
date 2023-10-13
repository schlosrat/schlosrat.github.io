// Decompiled with JetBrains decompiler
// Type: KSP.UI.IndicatorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using KSP.OAB;
using KSP.Sim.impl;
using KSP.Video;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [Serializable]
  public class IndicatorData
  {
    [Header("Localization")]
    public string titleKey;
    public string bodyTextKey;
    [Header("Positioning")]
    [Tooltip("Normalized position within canvas delta size, 0,0 as center 1 and -1 for corners.")]
    public Vector2 normalizedPos;
    public float xOffset;
    public float yOffset;
    public IndicatorCanvasType parentCanvasType;
    [Header("Visuals")]
    public Sprite mainSprite;
    public Texture rawImageTexture;
    public Vector2 imageSize;
    [Header("Settings")]
    [Tooltip("True: Keep animating any animated content in the Image components even if off-screen")]
    public bool animateOffScreen;
    [Tooltip("True: Disables the body text component")]
    public bool showTitleOnly;
    [Tooltip("if greater than 0, it will autoclose within that time in seconds")]
    public float closeTime;
    [Tooltip("The registration id of the object or prefab being tracked in 3D., usually set on Mission Editor or other similar")]
    public string trackingObjectID;
    [Tooltip("The part name for searching available parts in the OAB or any part by it's common name.")]
    public string partName;
    [Tooltip("IG GUID of the object we want to track from World Space")]
    public IGGuid trackingGUID;
    public bool hasValidGameObjectTracking;
    public GameObject gameObjectTracking;
    public bool hasValidSimObjectTracking;
    public SimulationObjectModel simObjectTracking;
    public LoopVideoData loopVideoData;
    public ObjectAssemblyPart objectAssemblyPart;
    public string prefabKey;
    public string tagName;
    [Header("Audio")]
    public Event OnIndicatorAppearAudioEvent;
    public Event OnIndicatorDisappearAudioEvent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndicatorData() => throw null;
  }
}
