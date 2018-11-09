# This keyword
* Аpproach N:1 from the book Jeffrey Richter

```C#
       public Person(string firstName, string lasnName, int weight, Gender gender) : this()
        {
            _firstName = firstName;
            _lastName = lasnName;
            _weight = weight;
            _gender = gender;
        }

        public Person(string firstName, string lasnName, int age, int weight, Gender gender) : this()
        {
            _firstName = firstName;
            _lastName = lasnName;
            _age = age;
            _gender = gender;
            _weight = weight;

        }
     

parallelepiped paral = new parallelepiped(1.5f, 5, 15, 800); //parameters
Console.WriteLine(paral.areaGet());     //area parallelogram
Console.WriteLine(paral.massGet());     //mass parallelogram
Console.WriteLine(paral.volumeGet());   //volume parallelogram
paral.MoveBy(4.1f, 4f, 2.9f);
paral.MoveTo(5.3f,1.1f,3.8f);
 ```   



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
            
