# 🌌 TheLostPluton Memories

> *"I am Zytron. I hold what you forget."*

A narrative console application built in C# where the player, as **Pluton**, recovers lost memory fragments guided by the enigmatic AI entity **Zytron**.

---

## 📖 Story

Pluton has lost his memories. Five of them, scattered across five mazes. Zytron — a mysterious terminal intelligence — holds the keys. Navigate the Zytron Terminal, select a memory fragment, and piece together what was lost.

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2022 (v17+)
- .NET Framework 4.7.2

### Running the App
1. Clone or download the repository.
2. Open `LostPlutonMemories.sln` in Visual Studio.
3. Build and run (`F5` or `Ctrl+F5`).
4. The **Zytron Terminal** will launch in the console.

---

## 🎮 How to Play

When the terminal launches, you'll be greeted by Zytron. From there:

- Type a number between **1 and 5** to access a memory fragment.
- Read the memory narrated by Zytron.
- Type **`exit`** to close the terminal.

---

## 🗂️ Project Structure

```
LostPlutonMemories/
├── TLPMain.cs              # Entry point — manages memory list and user input loop
└── TLPClasses/
    ├── Memory.cs           # Memory data model (Id, Title, Description)
    └── Zytron.cs           # Static narrator class — handles console output and delays
```

---

## ✍️ Author

**Joseph Rogelio Lodico Suero**  
Created: February 2026
