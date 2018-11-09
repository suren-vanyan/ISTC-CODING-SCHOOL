# This keyword
* Аpproach N:1 from the book Jeffrey Richter

```C#

        public Person()
        {
            Console.WriteLine("Default ctor");

            _firstName = "Jeffrey";
            _lastName = "Richter";
            _age = 50;
            _weight = 80;
            _gender = Gender.Unknown;
        }
        
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
 ```   
* Approach N:2(descending)
```C#
        public Person(Gender gender, string firstName, string lastName, int weight, int age)
                        : this(age: age, gender: gender, firstName: firstName, lastName: lastName)
        {
            _weight = weight;
        }

        public Person(Gender gender, string firstName, string lastName, int age) 
        : this(gender, lastName: lastName, firstName:firstName)
        {
            _age = age;
        }
       ......
        public Person(Gender gender) : this()
        {
            _gender = gender;
        }
```

*Аpproach N:3 from the book Тroelsen  (ascending)

```C#
        public Person(string firstName, int age, string lastName, int weight, Gender gender)
        {

            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _weight = weight;
            _gender = gender;
        }
        
         public Person(string firstName, int age, string lastName, int weight) : this(firstName, age, lastName, weight, default(Gender))
        {

            Console.WriteLine(" talking string,int,string,int");
            //_firstName = firstName;   
            //_lastName=lastName;
            //_age = age;

        }

        public Person(int age, string firstName, string lastName) : this(firstName, age, lastName, default(int))
        {
            Console.WriteLine(" talking int,string,string");
            //_firstName = firstName;       
            //_age = age;
            //_lastName=lastName;
        }
        
        .......
        
          public Person(string firstName) : this(firstName, default(int))
        {

            Console.WriteLine(" talking string");
            //  _firstName = firstName;
        }
 ```        

           
 

            
