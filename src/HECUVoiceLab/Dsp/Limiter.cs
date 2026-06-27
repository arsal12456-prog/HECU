using HECUVoiceLab.Presets; namespace HECUVoiceLab.Dsp;
// Final safety ceiling prevents hard clipping; frequent engagement lights the clip warning.
public sealed class Limiter { float ceil=.35f; public bool Engaged{get;private set;} public void Configure(Preset p)=>ceil=MathF.Pow(10,p.LimiterCeilingDb/20); public float Process(float x){Engaged=MathF.Abs(x)>ceil; return Math.Clamp(x,-ceil,ceil);} }
