LockCameraY - Cinemachine Extension for Unity

A lightweight, efficient Unity script that constrains a Cinemachine Virtual Camera to a fixed vertical (Y) position. 

This extension is ideal for 2D platformers, side-scrollers, or top-down games where you want the camera to follow a player horizontally but stay at a consistent height, regardless of jumps or falls.

🚀 Features

Axis Locking: Locks the Y axis while allowing the Cinemachine Body (Transposer, Framing Transposer, etc.) to handle X and Z movement.

Pipeline Integrated: Operates within the `PostPipelineStageCallback` to ensure the lock happens after physics calculations, preventing camera jitter.

Inspector Friendly: Easily adjust the `Locked Y Position` directly in the Unity Editor.

Performance Optimized: Minimal overhead, utilizing the native Cinemachine extension system.

🛠 Installation

1.  Ensure you have the Cinemachine package installed via the Unity Package Manager.
2.  Download 'LockCameraY.cs' and drop it into your project's Assets folder.
3.  Ensure the file name matches the class name: 'LockCameraY.cs'.

📖 How to Use

1.  Select your Cinemachine Virtual Camera in the Hierarchy.
2.  In the Inspector, scroll down to the Extensions section.
3.  Click the Add Extension dropdown and select LockCameraY.
4.  Set your desired height in the Locked Y Position field.


📋 Requirements
Unity
Cinemachine: 3.0+ (Uses the `Unity.Cinemachine` namespace)
