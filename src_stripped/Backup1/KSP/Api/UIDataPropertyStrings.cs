// Decompiled with JetBrains decompiler
// Type: KSP.Api.UIDataPropertyStrings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Api
{
  public static class UIDataPropertyStrings
  {
    public static class Input
    {
      public const string KeyboardSubcontext = "Keyboard";
      public const string GamepadSubcontext = "Gamepad";
      public const string InputSubcontext = "Input";
    }

    public static class Universe
    {
      public const string TimeRateIndex = "TimeRateIndex";
      public const string MaxTimeRateIndex = "MaxTimeRateIndex";
      public const string IsTimePaused = "IsUniverseTimePaused";
      public const string CurrentWarpRate = "TimewarpRateDisplay";
      public const string TimeMode = "TimeMode";
      public const string TimeDisplay = "TimeDisplay";
      public const string UniversalTime = "UniversalTime";
      public const string HaveManeuvers = "HaveManeuvers";
      public const string ClosestManeuverVector = "ManeuverMarker";
      public const string PressPlayAction = "PressPlayAction";
    }

    public static class View
    {
      public const string TimeRateIndex = "TimeRateIndex";
      public const string IsTimePaused = "IsUniverseTimePaused";
      public const string CurrentWarpRate = "TimewarpRateDisplay";
      public const string TimeMode = "TimeMode";
      public const string TimeDisplay = "TimeDisplay";
      public const string IsMapEnabled = "MapIsEnabled";
      public const string IsTrackingStationEnabled = "ToggleTrackingStation";
      public const string HideBentoCanvasGroup = "HideBentoCanvasGroup";
      public const string HaveManeuvers = "HaveManeuvers";
      public const string ClosestManeuverVector = "ManeuverMarker";
      public const string IsPartsManagerVisible = "IsPartsManagerVisible";
      public const string IsNavballVisible = "IsNavballVisible";
      public const string IsActionGroupManagerVisible = "IsActionGroupManagerVisible";
      public const string IsMissionTrackerTooltipVisible = "IsMissionTrackerTooltipVisible";
      public const string IsTripPlannerVisible = "IsTripPlannerVisible";
      public const string IsFlightReportVisible = "IsFlightReportVisible";
      public const string IsFlagSiteVisible = "IsFlagSiteVisible";
      public const string IsResourceManagerVisible = "IsResourceManagerVisible";
      public const string IsNonStageableResourcesVisible = "IsNonStageableResourcesVisible";
      public const string IsKerbalManagerVisible = "IsKerbalManagerVisible";
      public const string CanSwitchActiveVessel = "CanSwitchActiveVessel";
      public const string VesselsInRange = "VesselsInRange";
      public const string IsOtherAppBarVisible = "IsOtherAppBarVisible";
      public const string TripPlannerEdgeEndNode = "Destination";
      public const string TripPlannerEdgeTotalCost = "Cost";
      public const string TripPlannerEdgeDVCost = "DeltaVCost";
      public const string TripPlannerEdgeInclinationCost = "InclinationCost";
      public const string TripPlannerEdgeAerobrakePossible = "AerobrakePossible";
      public const string PressPlayAction = "PressPlayAction";
      public const string TelemetrySubContext = "TelemetryApi";
      public const string VesselSubContext = "VesselApi";
      public const string StagingSubContext = "StagingApi";
      public const string UniverseSubContext = "Universe";

      public static class Vessel
      {
        public const string MainBody = "MainBody";
        public const string Throttle = "Throttle";
        public const string Staging = "";
        public const string Roll = "Roll";
        public const string Pitch = "Pitch";
        public const string Yaw = "Yaw";
        public const string TrimRoll = "TrimRoll";
        public const string TrimPitch = "TrimPitch";
        public const string TrimYaw = "TrimYaw";
        public const string InputRoll = "InputRoll";
        public const string InputPitch = "InputPitch";
        public const string InputYaw = "InputYaw";
        public const string TranslateX = "TranslateX";
        public const string TranslateY = "TranslateY";
        public const string TranslateZ = "TranslateZ";
        public const string MissionEllapsedTime = "MissionEllapsedTime";
        public const string LandedOrSplashed = "LandedOrSplashed";
        public const string Position = "Position";
        public const string CelestialToPrograde = "CelestialToPrograde";
        public const string LiveInternalCameras = "LiveInternalCameras";
        public const string TotalDeltaV = "TotalDeltaV";
        public const string PartActivated = "PartActivated";
        public const string CanContainCommandCrew = "CanContainCrew";
        public const string CanShowPortraitUI = "CanShowPortraitUI";
        public const string ActionGroupAbort = "ActionGroupAbort";
        public const string ActionGroupBrakes = "ActionGroupBrakes";
        public const string ActionGroupLights = "ActionGroupLights";
        public const string ActionGroupGear = "ActionGroupGear";
        public const string ActionGroupSolar = "ActionGroupSolar";
        public const string ActionGroupRadiator = "ActionGroupRadiator";
        public const string ActionBarVesselTypeVisible = "ActionBarVesselTypeVisible";
        public const string ActionBarVisibleVessel = "ActionBarVisibleVessel";
        public const string ActionBarVisibleKerbal = "ActionBarVisibleKerbal";
        public const string ActionBarVisibleColony = "ActionBarVisibleColony";
        public const string ActionBarVisibleVesselAndColony = "ActionBarVisibleVesselAndColony";
        public const string TriggerActionGroupAbort = "TriggerActionGroupAbort";
        public const string TriggerActionGroupBrakes = "TriggerActionGroupBrakes";
        public const string TriggerActionGroupLights = "TriggerActionGroupLights";
        public const string TriggerActionGroupGear = "TriggerActionGroupGear";
        public const string TriggerActionGroupSolar = "TriggerActionGroupSolar";
        public const string TriggerActionGroupRadiator = "TriggerActionGroupRadiator";

        public static class Resources
        {
          public const string PartName = "PartName";
          public const string PartFamily = "PartFamily";
          public const string Guid = "GUID";
          public const string ResourceName = "ResourceName";
          public const string ResourceAbbreviation = "ResourceAbbreviation";
          public const string ResourceIcon = "ResourceIcon";
          public const string CurAmount = "CurAmount";
          public const string TotalAmount = "TotalAmount";
          public const string Units = "Units";
          public const string AmountNormalized = "AmountNormalized";
          public const string NonStageableResourcesVisible = "NonStageableResourcesVisible";
          public const string CloseNonStageableResourceWindow = "CloseNonStageableResourceWindow";
          public const string NonStageableResources = "NonStageableResources";
          public const string NonStageableResourceListElement = "NonStageableResourceListElement";
          public const string ResourcesManagerVisible = "ResourceManagerVisible";
          public const string CloseResourceManagerWindow = "CloseResourceManagerWindow";
          public const string PartContainers = "PartContainers";
          public const string PartContainerListElement = "PartContainerListElement";
          public const string ResourceContainers = "ResourceContainers";
        }

        public static class Telemetry
        {
          public const string AltimeterDisplayMode = "AltimeterMode";
          public const string AltimeterDisplay = "AltimeterDisplay";
          public const string VelocityDisplayMode = "VelocityMode";
          public const string VelocityDisplay = "VelocityDisplay";
          public const string VerticalSpeed = "VerticalSpeedIndicator";
          public const string Heading = "Heading";
          public const string Latitude = "Latitude";
          public const string Longitude = "Longitude";
          public const string AtmosphereStaticPressurekPa = "AtmosphereStaticPressurekPa";
          public const string AtmosphereTemperature = "AtmosphereTemperature";
          public const string AtmosphereDensity = "AtmosphereDensity";
          public const string AtmosphereNormalized = "AtmosphereNormalized";
          public const string AtmosphereGaugeNormalized = "AtmosphereGaugeNormalized";
          public const string VesselOrbitalProgradeRotation = "ShipOrientationGroup";
          public const string SASToggle = "SasToggle";
          public const string RCSToggle = "RcsToggle";
          public const string ToggleSASAction = "SasToggleAction";
          public const string ToggleRCSAction = "RcsToggleAction";
          public const string SASPrograde = "SasPrograde";
          public const string SASRetrograde = "SasRetrograde";
          public const string SASNormal = "SasNormal";
          public const string SASAntiNormal = "SasAntiNormal";
          public const string SASRadialIn = "SasRadialIn";
          public const string SASRadialOut = "SasRadialOut";
          public const string SASTarget = "SasTarget";
          public const string SASAntiTarget = "SasAntiTarget";
          public const string SASManeuver = "SasManeuver";
          public const string SASStabilityAssist = "SasStabilityAssist";
          public const string NAVBallRotation = "NavballRotation";
          public const string NormalMarkerVector = "NormalMarker";
          public const string AntiNormalMarkerVector = "AntiNormalMarker";
          public const string ProgradeMarkerVector = "ProgradeMarkerVector";
          public const string RetrogradeMarkerVector = "RetrogradeMarker";
          public const string RadialInMarkerVector = "RadialInMarker";
          public const string RadialOutMarkerVector = "RadialOutMarker";
          public const string ManeuverMarkerVector = "ManeuverMarkerVector";
          public const string HighlightMarkerVector = "HighlightMarker";
          public const string TargetMarkerVector = "TargetMarker";
          public const string AntiTargetMarkerVector = "AntiTargetMarker";
          public const string VesselControlStatus = "VesselControlStatus";
          public const string GForce = "GForce";
          public const string ProgradeMarkerBelowThreshold = "ProgradeMarkerBelowThreshold";
          public const string RetrogradeMarkerBelowThreshold = "RetrogradeMarkerBelowThreshold";
          public const string HasTargetObject = "HasTargetObject";
          public const string HasManeuver = "HasManeuver";
          public const string CanSetSASOrientationModes = "CanSetSASOrientationModes";
          public const string CanSetSASTargetMode = "CanSetSASTargetMode";
          public const string CanSetSASManeuverMode = "CanSetSASManeuverMode";
        }

        public static class Stages
        {
          public const string StagingStack = "stagingStack";
          public const string StagingBin = "stagingBin";
          public const string CanStage = "canStage";
          public const string StageCount = "stageCount";
          public const string HasReadyStage = "hasReadyStage";
          public const string SelectedStageIndex = "selectedStageIndex";
          public const string SelectedFolderIndex = "selectedFolderIndex";
          public const string SelectedPartType = "selectedPartType";
          public const string AddStage = "addStage";
          public const string RemoveStage = "removeStage";
          public const string MoveStage = "moveStage";
          public const string MoveStagePartGroup = "moveStagePartGroup";
          public const string MoveFromSourceListToTargetListAtIndex = "MoveFromSourceListToTargetListAtIndex";
          public const string MoveFromSourceFolderToTargetStageAtIndex = "MoveFromSourceFolderToTargetStageAtIndex";
          public const string MoveSourceFolderElementsToTargetStageAtIndex = "MoveSourceFolderElementsToTargetStageAtIndex";
          public const string SetSelectedPartType = "SetSelectedPartType";
          public const string HighlightStage = "HighlightStage";
          public const string HighlightPart = "HighlightPart";
          public const string HighlightPartGroup = "HighlightPartGroup";
          public const string RemovePart = "removePart";
          public const string PartsBinVisible = "partsBinVisible";
          public const string IsStagingExpanded = "IsStagingExpanded";
          public const string ExpandAllStages = "ExpandAllStages";
          public const string ExpandPartGroup = "expandPartGroup";
          public const string IsToggleExpandVisible = "IsToggleExpandVisible";
          public const string PartGroups = "partGroups";
          public const string PartGroupCount = "partGroupCount";
          public const string DeltaV = "deltaV";
          public const string HasThrust = "hasThrust";
          public const string StageID = "stageID";
          public const string IsHighlighted = "isHighlighted";
          public const string IsDragging = "IsDragging";
          public const string IsEmpty = "IsEmpty";
          public const string IsExpanded = "IsExpanded";
          public const string IsElementAFolder = "IsElementAFolder";
          public const string HighlightIndex = "HighlightIndex";
          public const string DraggingStageIndex = "DraggingStageIndex";
          public const string HighlightStageDropIndex = "HighlightStageDropIndex";
          public const string SetTargetStageDropIndex = "SetTargetStageDropIndex";
          public const string PartWithSymHighlighted = "partWithSymHighlighted";
          public const string PartHighlightedSymmetrySetOAB = "partHighlightedSymmetrySet";
          public const string PartHighlightedSymmetrySetFlight = "partHighlightedSymmetrySetFlight";
          public const string IsActiveStageFlight = "isActiveStageFlight";

          public static class Parts
          {
            public const string StageType = "stageType";
            public const string Guid = "guid";
            public const string FuelOneActive = "fuelOne.active";
            public const string FuelOneType = "fuelOne.type";
            public const string FuelOneCurAmount = "fuelOne.curAmount";
            public const string FuelOneTotalAmount = "fuelOne.totalAmount";
            public const string FuelOneUnits = "fuelOne.units";
            public const string FuelOneNormalized = "fuelOne.normalized";
            public const string FuelTwoActive = "fuelTwo.active";
            public const string FuelTwoType = "fuelTwo.type";
            public const string FuelTwoCurAmount = "fuelTwo.curAmount";
            public const string FuelTwoTotalAmount = "fuelTwo.totalAmount";
            public const string FuelTwoUnits = "fuelTwo.units";
            public const string FuelTwoNormalized = "fuelTwo.normalized";
            public const string IsHighlighted = "IsHighlighted";
            public const string IsDragging = "IsDragging";
            public const string StageIcon = "stageIcon";
            public const string ListViewElement = "listViewElement";
            public const string PartName = "partName";
            public const string PartSymmetrySetID = "partSymmetrySetID";
            public const string HasBackground = "hasBackground";
            public const string ChuteDeployState = "chuteDeployState";
            public const string ChuteSafetyState = "chuteSafetyState";
          }

          public static class Groups
          {
            public const string GroupIcon = "groupIcon";
            public const string IsGroupActive = "isGroupActive";
            public const string IsGroupExpanded = "isGroupExpanded";
            public const string GroupItemCount = "groupItemCount";
            public const string IsGoupIconHighlighted = "isHighlightedGroupIcon";
            public const string IsGroupEmpty = "isGroupEmpty";
            public const string GroupItems = "partGroupItems";
            public const string GroupDisplayName = "groupDisplayName";
            public const string GroupAndStageExpanded = "groupAndStageExpanded";
          }
        }
      }
    }
  }
}
