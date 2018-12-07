## :point_right: LINQ TO Objects

<a href="https://www.youtube.com/watch?v=8YGGX1ZEgbg">:punch::muscle:Deontay Wilder Vs. Tyson Fury:punch::muscle:</a>

<img class="irc_mi" src="https://e3.365dm.com/18/12/1096x616/skynews-deontay-wilder-tyson-fury_4506269.jpg?20181202064233" onload="typeof google==='object'&amp;&amp;google.aft&amp;&amp;google.aft(this)"  style="margin-top: 91px;" alt="Картинки по запросу deontay wilder vs tyson fury">


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


