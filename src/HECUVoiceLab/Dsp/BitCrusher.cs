using HECUVoiceLab.Presets; namespace HECUVoiceLab.Dsp;
// Quantization provides baked-in crunchy low-fi GoldSrc-era texture while preserving words.
public sealed class BitCrusher { Preset p=new(); public void Configure(Preset preset)=>p=preset; public float Process(float x){ var levels=(1<<Math.Clamp((int)MathF.Round(p.BitDepth),6,16))-1; return MathF.Round(Math.Clamp(x,-1,1)*levels)/levels; } }
