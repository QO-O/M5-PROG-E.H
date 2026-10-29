# M5-PROG-E.H

## Lesson 6: Encapsulation - Dependency List 

## WaveData (read by WaveManager)
### Duration   float | read-only
### EasySpawnInterval | float | read-only
### HardSpawnInterval | float | read-only
### EasyEnemies | int | read-only
### HardEnemies | int | read-only

## SpawnRoute (read by WaveManager)
### SpawnPoint | Transform | read-only
### Waypoints | Transform[] | read-only

## Enemy (written by WaveManager)
### Waypoints | Transform[] | write-only (set via SetRoute method)

## CurrencyManager (read by Enemy, UI)
### Instance   CurrencyManager | read-only (static)
### Gold | int | read-only

## WaveManager (read by WinChecker / debug UI)
### CurrentWaveIndex | int | read-only
### TotalWaves | int | read-only
### WaveRunning | bool | read-only

## TowerSelectionUI (read & written by TowerPlacer)
### SelectedTowerPrefab | GameObject | read-write

## HomeBase (read by UI / written by Enemy)
### Instance   HomeBase | read-only (static)
### Health | float | read-only
### MaxHealth | float | read-only

## TowerPlacer (called by Tower)
### Instance | TowerPlacer | read-only (static)

## Scripts with no variable dependencies
### Tower, Projectile, and GhostTower expose no variables to other scripts. Cross-script communication happens exclusively through public methods.

## Lesson 5:
### Code is in this repository under "05 - 05 - InheritanceAssignment"
![5Showcase](/GIFs/5.Inheritance.gif)

## Lesson 4:
### Code is in this repository under "04 - SRP"
![4Showcase](/GIFs/4.DRYSRP.gif)

## Lesson 3:

## 3a:
## Helaas is het debuggen niet mogelijk. Jesse kan dit bevestigen; het lukt gewoon niet.
## 3b:
[TowerDefenseRepo-Issues](https://github.com/QO-O/M5BO-TowerDefense/issues)


## Lesson 2: 
## Ging best prima, en ik wou even de bonus opdracht doen omdat dit te laat is. Ik heb gebruik van Prefab Variants gemaakt omdat er iets niet helemaal goed ging met simpel ctrl+D op de Prefabs

## GIF:
![2Showcase](/GIFs/2.ActionEventShowcase.gif)

## Lesson 1: 
## Ging niet zo snel als ik wou, had veel problemen, maar was niet uitzonderlijk moeilijk. Ik was het wel vergeten om allemaal online te zetten op tijd.. Whoops

## 1.1:
![1.1Showcase](/GIFs/1.1Showcase.gif)

## 1.2:
![1.2Showcase](/GIFs/1.2Showcase.gif)

## 1.3:
![1.3Showcase](/GIFs/1.3Showcase.gif)

## 1.4:
![1.4Showcase](/GIFs/1.4Showcase.gif)

## 1.5:
![1.5Showcase](/GIFs/1.5Showcase.gif)

## 1.6:
![1.6Showcase](/GIFs/1.6Showcase.gif)

## 1.7:
![1.7Showcase](/GIFs/1.7Showcase.gif)

## 1.8:
![1.8Showcase](/GIFs/1.8Showcase.gif)


## 1.9:
![1.9Showcase](/GIFs/1.9Showcase.gif)


## 1.10:
![1.10Showcase](/GIFs/1.10Showcase.gif)

## 1.11:
![1.11Showcase](/GIFs/1.11Showcase.gif)

## 1.12:
![1.12Showcase](/GIFs/1.12Showcase.gif)