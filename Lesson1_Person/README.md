# Shape3D
* Shape3D in have ellipsoidal , dimensional and parallelepiped

<p align="center">
<img src="https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRu1EuBdKrtRTT1YSqnPlqoTqRTotlUaiBUb_nWYMIfRuhdTgwh">
</p>
<p align="center">
<img src="https://i.gyazo.com/de98ec6468ce30475d73768ef314992c.png">
</p>


```C#
ellipsoidal elips = new ellipsoidal(5, 1.2f, 8, 1200); //parameters
Console.WriteLine(elips.areaGet());    // area ellipsoidal
Console.WriteLine(elips.massGet());    // mass ellipsoidal
Console.WriteLine(elips.volumeGet());  // volume ellipsoidal
elips.MoveBy(5f, 1.5f, 4.1f);//axis movement
elips.MoveTo(6.7f, 4f, 3f);  //axis movement

parallelepiped paral = new parallelepiped(1.5f, 5, 15, 800); //parameters
Console.WriteLine(paral.areaGet());     //area parallelogram
Console.WriteLine(paral.massGet());     //mass parallelogram
Console.WriteLine(paral.volumeGet());   //volume parallelogram
paral.MoveBy(4.1f, 4f, 2.9f);
paral.MoveTo(5.3f,1.1f,3.8f);
 ```        
            
 
#### Dimensional space
 
In three-dimensional space, a Platonic solid is a regular, convex polyhedron. It is constructed by congruent regular polygonal faces with the same number of faces meeting at each vertex. Five solids meet those criteria:

### For more [Platonic solid](https://en.wikipedia.org/wiki/Platonic_solid) <br>
            
