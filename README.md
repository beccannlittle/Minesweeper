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

Also note that I used a 3rd party asset for icons, if you run this locally you'll see those as solid sprite colors. This shouldn't impact gameplay.
