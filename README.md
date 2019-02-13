# ZoomAntartica
A Hololens app made to visualize Antarctic data for the Lamont-Doherty Earth Observatory. This demo application shows off how AR can be used to visualize 3D data collected in polar regions. Using ROSETTA (https://www.ldeo.columbia.edu/res/pi/rosetta/) RADAR and LiDAR data we can intuitively visualize 3D features.

![alt text](https://github.com/martinjpratt/ZoomAntarctica/blob/master/Repo/ZoomAnt4.png)

The initial view is of the entire Antarctica continent, using the Bedmap2 model (Fretwell et al. 2013) as a 3D basemap over which we can overlay geophysical data using standard polar stereographic coordinates. The user also has a tagalong menu with a slider bar to increase the vertical exaggeration, select the ROSETTA flight layer, and also select the Ross Ice Shelf sub-region for more detailed viewing.

![alt text](https://github.com/martinjpratt/ZoomAntarctica/blob/master/Repo/ZoomAnt1.png)

This image shows the Ross Ice Shelf sub-region, overlain with the ROSETTA flight paths (red = radar+lidar, blue = radar only). Vertical radargrams can also be visualized here.

![alt text](https://github.com/martinjpratt/ZoomAntarctica/blob/master/Repo/ZoomAnt2.png)

Tie-line T1060 contains a number of selectable boxes that allows the user to bring up localized LiDAR surfaces to show how the surface features affect the radar images.

![alt text](https://github.com/martinjpratt/ZoomAntarctica/blob/master/Repo/ZoomAnt3.png)

This example of a LiDAR surface can also be vertically exaggerated to highlight surface features such as narrow crevasses and wider rifts.

## Demo (previous version by LDEO intern, Peter Richards)

<a href="http://www.youtube.com/watch?feature=player_embedded&v=xx-eU0WwuZE
" target="_blank"><img src="http://img.youtube.com/vi/xx-eU0WwuZE/0.jpg" 
alt="IMAGE ALT TEXT HERE" width="240" height="180" border="10" /></a>

## Development Environment

Unity | Visual Studio 2017
--- | ---
`2017.4.2f2` | `15.8.9` |




