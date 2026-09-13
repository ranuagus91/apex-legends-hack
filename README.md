# apex-legends-hack

> Apex Legends · cheat · esp · aimbot · wallhack · triggerbot

[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4)](https://dot.net)
[![Cheat](https://img.shields.io/badge/type-cheat-red)]()
[![Game](https://img.shields.io/badge/game-Apex%20Legends-orange)]()
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

**apex-legends-hack** is an external Apex Legends cheat: ESP, aim assist, triggerbot, recoil, bhop, radar and misc.

tested on latest patch. for research and educational purposes only.

## features

- **ESP** — box, health bar, distance, name tags, skeleton, snaplines
- **Aim Assist** — configurable FOV circle, smooth factor, bone select, recoil compensation
- **TriggerBot** — reaction delay with jitter, burst mode, team check
- **Bunny Hop** — auto-jump on ground flag detect
- **Radar** — force enemy spotted on minimap
- **No Flash** — override flash duration to zero
- **Config** — JSON profiles under %APPDATA%, import/export, hotkeys

## build

requires .NET 10 SDK.

```
dotnet build
```

run:

```
.\build\bin\apex-legends-hack.Loader\net10.0\apexhack.exe
```

Apex Legends must be running before you start the loader.

## config

profiles auto-save to `%APPDATA%\apex-legends-hack\profiles\default.json`.

```json
{
  "aim": {
    "enabled": true,
    "fov": 5.0,
    "smooth": 3.5,
    "bone": "Head",
    "rcs": true
  },
  "esp": {
    "enabled": true,
    "box": true,
    "health": true,
    "skeleton": false,
    "distance": true
  },
  "trigger": {
    "enabled": false,
    "delayMs": 50,
    "jitter": 15,
    "burstCount": 1
  },
  "misc": {
    "bhop": false,
    "noFlash": false,
    "radar": false
  }
}
```

## keybinds

| key | action |
|---|---|
| INSERT | toggle menu |
| F1 | aim assist |
| F2 | esp |
| F3 | triggerbot |
| F4 | bhop |
| MOUSE5 | aim key (hold) |
| HOME | reload config |
| END | panic — clean exit |

## anti-cheat

targets **EAC**. no bypass included.
detection is expected without additional evasion layers.

## disclaimer

educational / research project for game hacking concepts.
not affiliated with the developers of Apex Legends.
don't use in online matchmaking — you **will** get banned.


---

## Topics

![apex-legends](https://img.shields.io/badge/apex%20legends-111827?style=flat-square) ![apex](https://img.shields.io/badge/apex-111827?style=flat-square) ![cheat](https://img.shields.io/badge/cheat-111827?style=flat-square) ![hack](https://img.shields.io/badge/hack-111827?style=flat-square) ![esp](https://img.shields.io/badge/esp-111827?style=flat-square) ![aimbot](https://img.shields.io/badge/aimbot-111827?style=flat-square) ![no-recoil](https://img.shields.io/badge/no%20recoil-111827?style=flat-square) ![eac](https://img.shields.io/badge/eac-111827?style=flat-square)

`apex-legends` `apex` `cheat` `hack` `esp` `aimbot` `no-recoil` `eac` `easy-anti-cheat` `game-hacking` `csharp`

Search: apex-legends-hack · esp · aim · eac · Apex Legends hack — aim assist, loot ESP, no recoil, EAC bypass notes

---

<sub>Apex Legends hack — aim assist, loot ESP, no recoil, EAC bypass notes</sub>
