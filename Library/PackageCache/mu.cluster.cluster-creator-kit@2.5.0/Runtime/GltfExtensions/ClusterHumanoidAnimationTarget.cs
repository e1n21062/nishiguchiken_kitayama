using VJson;
using VJson.Schema;

namespace ClusterVR.CreatorKit.GltfExtensions
{
    [JsonSchema(Title = "cluster-humanoid-animation-target", Id = "cluster-humanoid-animation-target.schema.json")]
    public sealed class ClusterHumanoidAnimationTarget
    {
        public const string ExtensionName = "ClusterHumanoidAnimationTarget";

        [JsonField(Name = "humanoidAnimationTargetType", Order = 0), JsonSchemaRequired]
        public HumanoidAnimationTargetType HumanoidAnimationTargetType;
    }

    [Json(EnumConversion = EnumConversionType.AsString)]
    public enum HumanoidAnimationTargetType
    {
        CenterPosition,
        CenterRotation,
        SpineFrontBack,
        SpineLeftRight,
        SpineTwistLeftRight,
        ChestFrontBack,
        ChestLeftRight,
        ChestTwistLeftRight,
        UpperChestFrontBack,
        UpperChestLeftRight,
        UpperChestTwistLeftRight,
        NeckNodDownUp,
        NeckTiltLeftRight,
        NeckTurnLeftRight,
        HeadNodDownUp,
        HeadTiltLeftRight,
        HeadTurnLeftRight,
        LeftEyeDownUp,
        LeftEyeInOut,
        RightEyeDownUp,
        RightEyeInOut,
        JawClose,
        JawLeftRight,
        LeftUpperLegFrontBack,
        LeftUpperLegInOut,
        LeftUpperLegTwistInOut,
        LeftLowerLegStretch,
        LeftLowerLegTwistInOut,
        LeftFootUpDown,
        LeftFootTwistInOut,
        LeftToesUpDown,
        RightUpperLegFrontBack,
        RightUpperLegInOut,
        RightUpperLegTwistInOut,
        RightLowerLegStretch,
        RightLowerLegTwistInOut,
        RightFootUpDown,
        RightFootTwistInOut,
        RightToesUpDown,
        LeftShoulderDownUp,
        LeftShoulderFrontBack,
        LeftArmDownUp,
        LeftArmFrontBack,
        LeftArmTwistInOut,
        LeftForearmStretch,
        LeftForearmTwistInOut,
        LeftHandDownUp,
        LeftHandInOut,
        RightShoulderDownUp,
        RightShoulderFrontBack,
        RightArmDownUp,
        RightArmFrontBack,
        RightArmTwistInOut,
        RightForearmStretch,
        RightForearmTwistInOut,
        RightHandDownUp,
        RightHandInOut,
        LeftThumb1Stretched,
        LeftThumbSpread,
        LeftThumb2Stretched,
        LeftThumb3Stretched,
        LeftIndex1Stretched,
        LeftIndexSpread,
        LeftIndex2Stretched,
        LeftIndex3Stretched,
        LeftMiddle1Stretched,
        LeftMiddleSpread,
        LeftMiddle2Stretched,
        LeftMiddle3Stretched,
        LeftRing1Stretched,
        LeftRingSpread,
        LeftRing2Stretched,
        LeftRing3Stretched,
        LeftLittle1Stretched,
        LeftLittleSpread,
        LeftLittle2Stretched,
        LeftLittle3Stretched,
        RightThumb1Stretched,
        RightThumbSpread,
        RightThumb2Stretched,
        RightThumb3Stretched,
        RightIndex1Stretched,
        RightIndexSpread,
        RightIndex2Stretched,
        RightIndex3Stretched,
        RightMiddle1Stretched,
        RightMiddleSpread,
        RightMiddle2Stretched,
        RightMiddle3Stretched,
        RightRing1Stretched,
        RightRingSpread,
        RightRing2Stretched,
        RightRing3Stretched,
        RightLittle1Stretched,
        RightLittleSpread,
        RightLittle2Stretched,
        RightLittle3Stretched,
    }
}
