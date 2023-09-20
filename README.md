# Jm_GP03
게임 프로그래밍 수업 HW3 레포지토리입니다.
• Scene
 –The environment of the HW1 project was used.
• Main Character 
– Movement is implemented through keyboard inputs using WASD/Arrow keys.
- The rotation on the mouse's x-axis through Vector2 allows the view to change when the mouse is moved left or right.
– Shooting is implemented through a left mouse click.
– Meteors, which act as bullets, are automatically destroyed after 3 seconds.

• Enemies 
– Enemies are generated at random locations using the spawn() and RandomSpawnPosition() methods in WaveSpawner.cs.
– By default, enemies move forward by 2*Time.deltaTime on the z-axis using the ForwardMovement.cs. Random enemy movements are implemented by assigning random rotations.
– Enemies are generated at a spawn rate of 0.5 for the first 1-30 seconds of the game and are destroyed 2 seconds later.

-The main character must be different from the one in the textbook 
– Enemies are represented as skeleton soldiers, while the main character is a magician.
– Although there are animations included in the assets, they haven't been specifically configured.
– As a new feature, the speed triples when the right mouse button is clicked. Jumping is possible through the spacebar. A canvas has been created.
– Record gameplay lasting less than one minute 
https://assetstore.unity.com/packages/vfx/particles/fire-explosions/fire-spell-effects-36825
https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/lowpoly-medieval-skeleton-free-medieval-fantasy-series-181883
https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/battle-wizard-poly-art-128097
