using HECUVoiceLab.Presets; namespace HECUVoiceLab.Dsp;
// Phase-accumulator sample-and-hold simulates old low-rate game voice assets.
public sealed class SampleRateReducer { float sr=48000, phase, held, smooth; Preset p=new(); public void Configure(float sampleRate, Preset preset){sr=sampleRate;p=preset;} public float Process(float x){ phase+=p.EffectiveSampleRate/sr; if(phase>=1){phase-=1; held=x;} smooth += (held-smooth)*(0.02f+p.AntiAliasSmoothness/100*.6f); return held*(1-p.AntiAliasSmoothness/100)+smooth*(p.AntiAliasSmoothness/100); } }
