# HECU Voice Lab

HECU Voice Lab is a Windows/.NET 8 WPF desktop app that processes your own live microphone through local DSP to approximate an old 1998 PC-game tactical HECU-style radio marine tone: mono, dry, mid-heavy, narrow-band, compressed, gritty, and subtly chopped.

It does **not** include Valve, Half-Life, or other copyrighted game audio. No reference MP3 is required. The default **HECU Reference** preset is based on the embedded measured target profile in this repository. It is not Valve's exact proprietary pipeline, and it does not perform AI voice cloning or identity impersonation.

## Requirements
- Windows 10/11
- For source builds: .NET 8 SDK
- Optional: VB-Audio Virtual Cable for Discord/OBS/game routing

## Run portable release
1. Download or build the portable `win-x64` publish folder.
2. Run `HECU Voice Lab.exe`.
3. Pick your physical microphone as **Input**.
4. Pick `CABLE Input (VB-Audio Virtual Cable)` as **Output**.
5. Press **START**.

## Build from source
```powershell
dotnet restore
dotnet build -c Release
dotnet publish -c Release -r win-x64 --self-contained true
```
Or run:
```powershell
./build-release.ps1
```

## Correct VB-Audio Cable routing
- Physical microphone → HECU Voice Lab input.
- HECU Voice Lab output → `CABLE Input (VB-Audio Virtual Cable)` playback device.
- Discord/OBS/game microphone source → `CABLE Output (VB-Audio Virtual Cable)` recording device.

The app does not create an audio driver; it only uses normal Windows input/output devices.

## Presets
- **HECU Reference**: default measured target profile.
- **Cleaner HECU**: less bitcrush, saturation, chop; wider bandwidth.
- **Dirtier HECU**: more crunch, saturation, chop; narrower bandwidth.
- **Radio Only**: EQ/compression without heavy old-game crunch.
- **Bypass / Clean Monitor**: clean routing and metering.

## Reference Match tab
Use **Embedded Target Profile** to view the built-in target and score analysis output. Use **Load Local MP3/WAV Reference** only if you later provide your own local file. WAV is supported through NAudio; MP3 depends on Windows Media Foundation availability.

## Tuning guide
- Too clean: increase Crunch Mix, lower Bit Depth, increase Grit Drive.
- Too dirty: reduce Crunch Mix, increase Bit Depth, reduce Grit Drive.
- Too muffled: raise Low-Pass Frequency or Presence Boost.
- Too thin: increase Helmet Low-Mid Boost or reduce High-Pass Frequency.
- Too loud: lower Output Gain or Makeup Gain.
- Too quiet: raise Makeup Gain or Output Gain.
- Too robotic: reduce Chop Amount and Crunch Mix.
- Too noisy: reduce Radio Noise Amount and Grit Drive.

## Troubleshooting
- No audio input: confirm the selected input is a physical mic, not `CABLE Output`.
- No output heard: select speakers for monitoring, or `CABLE Input` for virtual routing.
- Discord not receiving processed voice: set Discord input to `CABLE Output (VB-Audio Virtual Cable)`.
- Feedback/echo: do not monitor the cable into speakers while your mic can hear them.
- High latency: close other audio apps and use default/shared-mode sample rates.
- Device in exclusive mode: disable exclusive mode in Windows Sound device properties.
- App crashes on device change: press Stop, Refresh Devices, reselect devices, then Start.
