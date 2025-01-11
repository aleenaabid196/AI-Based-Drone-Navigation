# AI-Based-Drone-Navigation

# Project Overview

Imagine a smart drone learning to navigate a virtual city! This project leverages Unity ML Agents to create a 2D city environment with roads, buildings, and even flying birds. The goal is to train a drone to navigate the city without collisions while adapting to increasingly complex challenges.

### Project Highlights
- **Initial Scenario**: The drone starts at a fixed point and navigates to a predetermined destination.
- **Randomized Scenarios**: Introduced randomness in starting points and targets to increase difficulty.
- **Dynamic Challenges**: Added moving obstacles like flying birds, pushing the drone to learn evasive maneuvers.

This project demonstrates the intersection of artificial intelligence and robotics, offering a journey into autonomous navigation in urban environments.

## Technology Stack

- **Unity Game Engine**: A platform for designing and testing the 2D city environment and drone interactions.
- **Unity ML-Agents Toolkit**: Empowers the drone to learn through reinforcement and imitation learning.
- **mlagents Python Package**: Trains the drone to navigate autonomously.
- **ONNX**: Converts trained PyTorch models into a format compatible across platforms.
- **TensorBoard**: Visualizes training metrics for performance monitoring.
- **TensorFlow**: Supports deep learning tasks in broader contexts.
- **PyTorch**: The primary framework for defining, training, and exporting neural network models.

## City Model Design and Constraints

### Constraints
1. **Obstacle Avoidance**:
   - Avoid buildings, trees, and city boundaries.
   - Dodge dynamic obstacles like flying birds.
2. **Safe Flight Paths**:
   - Maintain a safe distance from structures.
   - Navigate over houses and roads for efficient monitoring.

### Challenges
1. **Initial Designs**:
   - Large-scale city models led to extended training times and computational strain.
2. **Adaptations**:
   - Adjusted to smaller city designs for streamlined training.
   - Refined further to minimal environments for balance between complexity and resource efficiency.

This systematic progression highlights the iterative nature of designing intelligent systems.


## Scenarios and Attempts

- **Fixed Destination**: Initial stage with a static goal.
- **Randomized Start and Goal**: Introduced variability for advanced learning.
- **Dynamic Obstacles**: Flying birds added to test agility and decision-making.

The iterative approach ensured consistent improvements in the drone's navigation strategy, adapting to more complex environments with each stage.

 ## User Interface

**City Map**

![Citymap](https://raw.githubusercontent.com/aleenaabid196/AI-Based-Drone-Navigation/refs/heads/main/UI_Screenshots/Frame%201.png)

**T1**

![OnBoarding](https://raw.githubusercontent.com/aleenaabid196/AI-Based-Drone-Navigation/refs/heads/main/UI_Screenshots/T3.png)

**T2**

![OnBoarding](https://raw.githubusercontent.com/aleenaabid196/AI-Based-Drone-Navigation/refs/heads/main/UI_Screenshots/T2.png)

**T3**

![OnBoarding](https://raw.githubusercontent.com/aleenaabid196/AI-Based-Drone-Navigation/refs/heads/main/UI_Screenshots/T4.png)

**T4**

![OnBoarding](https://raw.githubusercontent.com/aleenaabid196/AI-Based-Drone-Navigation/refs/heads/main/UI_Screenshots/T1.png)

**T5**

![OnBoarding](https://raw.githubusercontent.com/aleenaabid196/AI-Based-Drone-Navigation/refs/heads/main/UI_Screenshots/city%20map.png)


