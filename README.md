# CSharp-Interfaces-Demo

C# OOP tutorial demonstrating interfaces, polymorphism, interface inheritance, and explicit implementation.

## Structure
- **Interfaces/**
  - `IAnimal`: Basic interface contract (`Speak()`).
  - `ICharacter`: Base character interface (`Name`, `Health`, `TakeDamage(int)`).
  - `ICombatant`: Inherits from `ICharacter` (`AttackPower`, `Attack()`, `Defend()`).
  - `IHealer`: Interface for healing capabilities (`Heal(int)`).
  - `IAttack` & `IDefend`: Interfaces with colliding method names (`Attack()`).
- **Classes/**
  - `Dog` & `Cat`: Implement `IAnimal`.
  - `Warrior`: Implements `ICombatant`.
  - `Mage`: Implements `ICombatant` and `IHealer`.
  - `Knight`: Explicitly implements `IAttack` and `IDefend`.
- `Program.cs`: Demonstrates polymorphism, type casting (`as`), and explicit interface calls.

## Run
```bash
dotnet run
```
