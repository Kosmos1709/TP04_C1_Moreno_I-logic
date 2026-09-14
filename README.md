# Pong — Practical Assignment 04

A two-player Pong game developed in Unity as part of **Practical Assignment N°04**.

## Game Description

A classic **2-player Pong** game with customized player and ball characteristics. The goal is to score points by getting the ball past the opponent's paddle.

The game includes physics-based movement, configurable settings, and a first-to-3 scoring system.

## Features

* Two-player local multiplayer.
* Physics-based movement using **Rigidbody** and **AddForce**.
* Ball speed increases over time and when it collides with objects.
* Paddle color changes randomly when it hits the ball.
* Players are restricted to their respective sides of the court.
* The ball cannot leave the playable area.
* Power-ups can be grabbed when the ball collides with them.
* **Best of 5** scoring system — the first player to reach 3 points wins.
* Configurable **20-second goal timer**.
* The goal timer can be configured through a `GameSettings` ScriptableObject.
* Initialization variables are managed using **Scriptable Objects**.
* Clean and organized code using variables, declarations, functions, and classes.

## Technologies

* **Unity**
* **C#**
* Unity Physics System
* Rigidbody
* Scriptable Objects

## Objective

Score **3 points before your opponent** and win the match.

If neither player scores within the configured **20-second limit**, the player whose side the ball is on receives the point.

## Players

Each player controls a paddle on their respective side of the court.

The paddles can move vertically but cannot cross the boundaries of their side of the arena.

## Assignment Topics

This project applies the following concepts:

* Input
* Delta Time
* Physics
* Rigidbody
* AddForce
* Scriptable Objects
* Classes and functions
* Collision detection
* Configurable game settings



&#x20;Development



* Developed by \*\*Kosmos\*\*.
* 
* 🎮 \*\*Play on itch.io:\*\* \[Play Pong on itch.io](https://kosmopolis.itch.io/ping-pong-malia)

