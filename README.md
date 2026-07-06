# Flight-Off

A small Unity flying-game prototype: a plane flies forward automatically while the player tilts it up and down to dodge a row of obstacles. Built as a course/tutorial challenge ("Challenge 1") on top of Unity's default URP 3D template.

![Unity](https://img.shields.io/badge/Unity-6000.0.72f1-black?logo=unity)
![Render Pipeline](https://img.shields.io/badge/Pipeline-URP-blue)
![License](https://img.shields.io/badge/License-CC0%201.0-lightgrey)

## Overview

The player controls a small propeller plane that constantly moves forward. Pressing up/down (or W/S) pitches the nose to climb or dive, weaving between a line of obstacles placed down the runway. A chase camera trails behind the plane, and the propeller spins continuously for visual feedback.

A recorded outcome of the challenge is included at `Assets/Challenge 1/Instructions/Challenge 1 - Outcome.mov` for reference.

## Gameplay / Controls

| Input | Action |
|---|---|
| `W` / `Up Arrow` | Pitch nose up (climb) |
| `S` / `Down Arrow` | Pitch nose down (dive) |
| *(automatic)* | Plane always moves forward |

## Tech Stack

| | |
|---|---|
| Engine | Unity **6000.0.72f1** |
| Render Pipeline | Universal Render Pipeline (URP) |
| Input | Legacy `Input.GetAxis` (Input System package is present but not yet wired up) |
| Scripting | C# |

Key packages (see `Packages/manifest.json`): URP, Input System, AI Navigation, Timeline, Visual Scripting — most are default packages carried over from Unity's 3D URP template rather than actively used by the gameplay code.

## Project Structure

```
Assets/
├── Challenge 1/
│   ├── Challenge 1.unity          # Main gameplay scene
│   ├── Scripts/
│   │   ├── PlayerControllerX.cs   # Forward movement + pitch control
│   │   ├── FollowPlayerX.cs       # Offset chase camera
│   │   └── SpinPropellerX.cs      # Continuous propeller rotation
│   ├── Instructions/              # Reference outcome video
│   └── _Source_Files/             # Materials, lighting data
├── Course Library/
│   ├── Vehicles/Planes/           # Plane prefab (Small_Plane02)
│   └── Sky/                       # Skybox prefabs
├── Scenes/
│   └── SampleScene.unity          # Default template scene
└── TutorialInfo/                  # Unity's built-in "Readme" welcome asset
```

## Scripts

- **`PlayerControllerX`** — Moves the plane forward every physics frame (`speed`) and rotates it on the X-axis based on vertical input (`tiltSpeed`).
- **`FollowPlayerX`** — Keeps a camera (or object) positioned at a fixed offset behind/above the `plane` it's tracking, updated in `LateUpdate` for smooth follow.
- **`SpinPropellerX`** — Continuously rotates a transform (the propeller mesh) at `rotationSpeed` degrees/second.

## Getting Started

1. Install **Unity Hub** and **Unity 6000.0.72f1** (or a compatible 6000.x LTS version).
2. Clone the repo:
   ```bash
   git clone https://github.com/lavishtembhare/Flight-Off.git
   ```
3. Open Unity Hub → **Add** → select the cloned folder.
4. Once the project loads, open `Assets/Challenge 1/Challenge 1.unity`.
5. Press **Play** to try the challenge.

## License

Released under **CC0 1.0 Universal** — public domain, no rights reserved. See [LICENSE](LICENSE).

## Author

**Lavish Tembhare** — [@lavishtembhare](https://github.com/lavishtembhare)
