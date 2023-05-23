# Solar System
Simple solar system simulation tool for students starting to learn about astronomy, earth science, or physics.

# Motive
 When discussing about topics for team project in Visualization course, solar system simulator seemed interesting to our team. For me, I 

# Features
Scene1 - Rotation of planets (Formula not applied yet)
Scene2 - Overview of physical data of the planets. User can compare this data with each other. Used a continuous color gradient to encode the rotation period and mass. (Color lerp) Each planet's gravitational force is represented with the length of 3D arrows. (Scale/Length lerp)
* Sun is excluded when lerping because of its enormous data values.
Scene3 - Gravity simulation. Comparison of mass and radius of planets.
Scene4 - Relationship between mass, radius, and gravity.

# Load/Execute
The editor version is 2021.3.4f1
Works done in different OS (Windows, Mac) were combined, so you may need to adjust the screen.

# Summary
The goal of our project is to help students new to astronomy learn planets' properties in the solar system, and to demonstrate how the properties are related through gravity. As intended, our simulator can be helpful for educational purpose. While working, we found out that this was a slight deviation from the purpose of the visualization. The dataset of planets was more like a rule of space, so it was hard to extract a new insight from that.