# Flight-Off ✈️

[![Unity Version](https://img.shields.io/badge/Unity-2022.3%2B-blue.svg?style=flat&logo=unity)](https://unity.com/)
[![Platform](https://img.shields.io/badge/Platform-PC%20%7C%20WebGL-orange.svg)]()
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

**Flight-Off** is an action-packed, physics-based arcade flight game built using the Unity 3D engine. Take control of high-speed aircraft, navigate complex aerial terrains, evade obstacles, and complete high-stakes challenges. 

---

## 🚀 Features

- **Physics-Driven Flight Mechanics:** Realistically balanced arcade flight behavior handling pitch, roll, yaw, and throttle.
- **Dynamic Camera System:** Smooth Cinemachine-powered camera transitions tracking speed and orientation.
- **Obstacle & Boundary Systems:** Immersive boundary constraints and procedural/static hazards to test your pilot skills.
- **Modern UI/HUD:** Interactive dashboards displaying Real-time Altitude, Speed, Fuel/Energy metrics, and Minimaps.
- **Cross-Platform Input Support:** Built using Unity's modern Input System supporting Keyboard/Mouse and Gamepad controllers.

---

## 🛠️ Tech Stack & Requirements

- **Game Engine:** Unity (Recommended version: `2022.3 LTS` or higher)
- **Language:** C# (.NET Standard 2.1)
- **Render Pipeline:** Universal Render Pipeline (URP) for optimized lighting and post-processing.
- **Input System:** Unity New Input System Package.

---

## 📂 Project Structure

The project follows a standard Unity modular architecture:

```text
Flight-Off/
├── Assets/
│   ├── _Project/               # Main game development directory
│   │   ├── Audio/              # Sound effects (SFX) and background music
│   │   ├── Materials/          # Skyboxes, shaders, and surface materials
│   │   ├── Prefabs/            # Reusable GameObjects (Aircrafts, Obstacles, UI)
│   │   ├── Scenes/             # MainMenu, Level_01, Level_02, Sandbox
│   │   ├── Scripts/            # Core C# Logic
│   │   │   ├── Camera/         # Camera tracking and shaking scripts
│   │   │   ├── Controllers/    # FlightController, InputManager
│   │   │   ├── Managers/       # GameManager, UIManager, AudioManager
│   │   │   └── Environment/    # Obstacle generation and triggers
│   │   ├── Settings/           # URP Assets and Input Action Configurations
│   │   └── Textures/           # HUD Sprites and 3D Asset textures
│   └── Packages/               # Unity Manifest dependencies
└── ProjectSettings/            # Engine-specific physics, input, and tag allocations
