https://github.com/SimplyRobotic/Assessment4

Use arrow keys to move. Collect all 8 collectibles within the allowed time to win, and avoid hazards such as spikes and pits. 

Changelog
22/07/21 - Started project. Built character controller using a tutorial. Started coding collectables and level layout.
22/07/21 - Found issue with 2D Player Controller ( sprite would never be grounded and therefore would bounce about and not be able to jump. ) Resolved in Unity by turning Auto Sync Transforms on. 
22/07/21 - Added Camera Following Player and Camera Bounds.
25/07/21 - Collectible issues - conflict with the PlayerController script's method for handling collisions. Trying to find a workaround.
29/07/21 - Changed Character Controller to both fix collision issues and add animation state machines.
4/08/21 - Animation state machines couldn't be added. 
4/08/21 - Changed Character Controller to a more simple one, which works perfectly. This also fixed all collision issues. Added death and respawn mechanic, but this made it so the camera doesn't follow the player anymore. This issue is being worked on.
5/08/21 - Changed the respawning mechanic from Destroy+Instantiate to teleport. This fixed the camera issue.
8/08/21 - Added Death for the player when out of lives. The game can now be lost.
8/08/21 - Added restart button. The game can now be restarted by the player.
10/08/21 - Added score UI. Started Building level.
11/08/21 - Added Lives UI. Cannot work out infinite jump issue with player controller.
12/08/21 - Fixed infinite jump with character controller. Added win text.
