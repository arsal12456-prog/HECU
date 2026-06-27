namespace HECUVoiceLab.Presets;
public sealed class Preset
{
    public string Name { get; set; } = "HECU Reference"; public float InputGainDb { get; set; }=0, OutputGainDb { get; set; }=0, DryWet { get; set; }=100; public bool SafetyLimiter { get; set; }=true, Bypass { get; set; }
    public float GateThresholdDb { get; set; }=-45, GateHardness { get; set; }=35, GateHoldMs { get; set; }=40, GateReleaseMs { get; set; }=110;
    public float HighPassHz { get; set; }=120, LowPassHz { get; set; }=5200, HelmetLowMidDb { get; set; }=3.5f, RadioPresenceDb { get; set; }=3, HarshEdgeDb { get; set; }=1.5f;
    public float EffectiveSampleRate { get; set; }=11025, BitDepth { get; set; }=8, CrunchMix { get; set; }=70, AntiAliasSmoothness { get; set; }=20;
    public float CompressorThresholdDb { get; set; }=-28, CompressorRatio { get; set; }=5, CompressorAttackMs { get; set; }=3, CompressorReleaseMs { get; set; }=100, MakeupGainDb { get; set; }=4, GritDrive { get; set; }=35, LimiterCeilingDb { get; set; }=-9;
    public float ChopAmount { get; set; }=20, TransientBite { get; set; }=25, EndCutTightness { get; set; }=25, RadioClickAmount { get; set; }=5, RadioNoiseAmount { get; set; }=0;
    public Preset Clone() => (Preset)MemberwiseClone();
}
