using HECUVoiceLab.Presets; namespace HECUVoiceLab.Dsp;
// Tanh drive adds gritty harmonic dirt baked into the voice rather than a static overlay.
public sealed class Saturator { Preset p=new(); public void Configure(Preset preset)=>p=preset; public float Process(float x){ var drive=1+p.GritDrive/100*5; return MathF.Tanh(x*drive)/MathF.Tanh(drive); } }
