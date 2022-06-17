# Minesweeper

A simple minesweeper implementation built with Unity 2021.3.4f1

Check out the live demo here: https://beccannlittle.github.io/Minesweeper/

Completed minimum requirements:
- Detectable win/loss condition
- Option to restart game at any time
- Include "flag" mechanic
- Built in Unity

Issues that make this borderline unplayable:
- Didn't implement recursively revealing adjacent cells with `mineCount = 0`
- mineCount logic for cells on the left and right edges is incorrectly wrapping
- winCheck logic is wrong

Also note that I used a 3rd party asset for icons, which are `.gitignore`d in order for the live demo to be hosted via Pages (must be a public repo). If you run this locally you'll see those as solid sprite colors, but this shouldn't impact gameplay.
