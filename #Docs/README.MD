## (The adventures of) GLOO BOOM
### Neo Te Aika - 22011265 - 289.106 Game Dev (2024)
### PREMISE

Out in dead-end space, working ship demolition to pay off tax debts, Gloo is armed with just the right amount of boom. *Twice.*  
Tax-payer-hating forces of evil have taken residence in a derelict shipyard. It's Gloo's job to clear them out, and collect valuables from the ships he tears apart on his way.

# GAMEPLAY
## Basics
Player can run around, throw grenades and shoot glue.
Grenades will damage objects and environment in their explosion radius, while glue will coat surfaces, both protecting the environment from further destruction, causing grenades that land on glue to stick, and temporarily stunning enemies.  
Grenades explode immediately on impact with debris or enemies, bounce once against normal walls, or continue bouncing at full velocity if they hit speed walls.

Each stage playthrough, Gloo can survive one point of damage. A display of his helmet will show a cracked visor if the next hit will kill Gloo. If the environment is destroyed enough to vent atmosphere into space, Gloo will be sucked out in proximity, or immediately die if his helmet is cracked!  
Player must destroy all enemies and collect all items, then reach the exit to complete each level. Items collected, enemies destroyed, damage taken and time taken per-level contribute to player score.

## Structures
Normal walls have five states with changing visual feedback.  
<sup>(Undamaged - Scuffed - Dented - Cracked - Destroyed)</sup>  
Normal floors have five states with changing visual feedback.  
<sup>(Undamaged - Scuffed - Dented - Weak - Destroyed)</sup>  

A wall's state cannot be reversed (healed), and once destroyed, the wall is gone for the playthrough - however gluing a surface "shields" it for one hit from reaching a further damage state.  
Structural walls cannot be destroyed.  
Richochet walls will ricochet incoming grenades at full speed, regardless of whether they had already bounced or not. Throwing a grenade into a corridor of rebound wills might richochet it all the way to the other side!

Normal floors can be traversed by the player without issue.  
If enough grenade damage (or preplaced level design) occurs to a floor, the tile will be Weakened. Weakened floors collapse shortly after the player traverses them, trapping them on one side. This may lead to trap or risk situations where the player may be unable to return to previous areas, if the only way to get there was through a collapsed floor tile.