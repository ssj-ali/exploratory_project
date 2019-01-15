# exploratory_project
This is my exploratory project offered in my third semester.
INTRODUCTION
Mining Simulation Softwares:-
Mining simulation is the computer-based modeling of a real open-pit or underground mining. Mining simulation (Mine Modelling) offers a way
forward, providing mining output statistics and dynamic views of operations for analysis, optimization, and experimentation, all without operational interruption. These softwares provides the mining industry with the most advanced 3D geological modelling, mine design and production planning solutions.
Examples of softwares are:
1. Surpac
2. Surfer
3. Vulcan
4. Visual Land pro 2000
5. Simio

TITLE
Plugin Development for AutoCAD
In this project , we will be working with the AutoCAD.NET Application Programming Interface (API) and the C# programming language to create a ‘plug-in’ – a module that loads into AutoCAD to extend its functionality.

OBJECTIVE
“TO MAKE A PLUGIN FOR AUTOCAD AND GENERATING COAL SEAM MODEL FOR THE GIVEN BORE HOLE LOG DATA ”

THEORY
Definition of coal seam: a bed of coal usually thick enough to be profitably mined. A coal seam is a dark brown or black banded deposit of coalthat is visible within layers of rock. These seams are located underground and can be mined using either deep mining or strip mining techniques depending on their proximity to the surface. These seams undergo normal coal formation and serve as a conventional coal resource. The reserves of coal are immense, and are the
largest of all of the fossil fuels

Borehole: Borehole logging is the practice of making a detailed record (a well log) of the geologic formations penetrated by a borehole. The log may be based either on visual inspection of samples brought to the surface (geological logs) or on physical measurements made by instruments lowered into the hole (geophysical logs). Some types of geophysical well logs can be done during any phase of a well's history: drilling, completing, producing, or abandoning.

Borehole data: The interpretations stored in the Borehole Geology database are made from borehole logs that show the geology encountered at depth within each borehole. In many cases, these logs were created by the geotechnical companies responsible for drilling the holes, and supplied to the BGS In other cases, the logs may have been made by our own geologists, either at the time of drilling, or subsequently from core samples

PROCEDURE
1. Getting familiar with AutoCAD and to draw simple geometries like lines, circles.
2. In Visual Basic, Creation of Plug-in by adding refrence files of AutoCAD. Creation of AutoCAD plugin command.
3. Code to open a window form which ask user to give Bore hole data.mThe window form must also print data so that user must verify it.
4. The provided borehole data must be in .csv format.
5. Window form application is made.
6. Two buttons are placed on the window form. One for showing the Bore holes and other to give 3D coal seam model.
7. To draw the boreholes lines, line are drawn from the ground point (R.L) to the bottom point of the borehole.
8. To draw the coal seam model:-
   a). The points on upper layer of the coal seam are located.
   b). Contouring is done by joining all the points by Triangulation method.
   c). Upper layer is created and same is done with the lower layer of coal seam.
9. Additional features are added like giving labels to the boreholes, contouring the ground surface etc.
10. Finally, the plugin is run in AutoCAD and the result are seen in 'Realistic' mode

RESULT
The Plugin for the AutoCAD is completed which allows all to assemble and view borehole data and accurtely model coal seam and deposits.

ISSUES AND FUTURE CONCERNS
1. The space between the upper and lower surface ofthe coal seam couldn't be properly filled/surfaced. Therefore proper meshing between the layers are required.
2. It is still to be tested on original borehole data that contains data of other ores also.
3. The model is to be made more informative by showing depths and widths of the seam.

REFRENCES
https://knowledge.autodesk.com
Triangulation
https://through-the-interface.typepad.com/through_the_interface/2009/04/triangulating-an-autocad-polyface-mesh-from-a-set-of-points-using-net.html
