# CarRace
SImple car game test
The Speed Rush has been around for many years. The thrill of racing with insane speeds, and the risk of winning or losing a lot of money, is the main reason for the racers’ … Need For Speed.
Overview
You have a task to write a software program, which will create a virtual model of the cars, races and their development.
Task I : Structure
The main structure of the program should include the following elements:
Cars
A basic car has the following properties: a brand (string), a model (string), an yearOfProduction (int), horsepower (int), acceleration (int), suspension (int), and durability (int).
Each different type of car adds to those properties. Here are the types:

•	PerformanceCar – a car made for racing. Might be a little ugly, but it is a rocket inside.

o	Has addOns (Collection of strings). (by default – empty)

o	Increases its given horsepower by 50%.

o	Decreases its given suspension by 25%.

•	ShowCar – a car made for showing off. Looking cool out there, bro.

o	Has stars (int). (by default – 0)

Races
The basic race has the following properties: length (int), route (string), a prizePool (int), and participants (Collection of Cars),

•	CasualRace – just a normal race. Several beasts’ warfare, spreading their roars throughout the roads. 

•	DragRace – a drag race. An engine fray. The ideal gear shifting will be the winner in this. 

•	DriftRace – a drift race. Don’t you wish your girlfriend was drifty like me.
Garage

•	Garage – The Garage is that place where all the cars stay, when they are not racing. The Garage also provides the ability to modify parked car

o	Has parkedCars (Collection of Cars). 

Constructors
Implement all class constructors, with the parameters in the EXACT given order and the EXACT given types.
String Representation
Implement ToString() methods for every Car class. You can see the requirements in the Output Section below. 
 
Task II: Business Logic
The Controller Class
The business logic of the program should be concentrated around several commands. Implement a class called CarManager, which will hold the main functionality, represented by these methods:

•	void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)

•	string Check(int id)

•	void Open(int id, string type, int length, string route, int prizePool)

•	void Participate(int carId, int raceId)

•	string Start(int id)

•	void Park(int id)


•	void Unpark(int id)

•	void Tune(int tuneIndex, string addOn)

Commands
The commands in the CarManager class should represent the functionality to the input commands of the user. Here are the input commands you need to accept from the user input.

•	register {id} {type} {brand} {model} {year} {horsepower} {acceleration} {suspension} {durability}

o	REGISTERS a car of the given type, with the given id, and the given stats.

o	The car type will be either “Performance” or “Show”.
•	check {id}

o	CHECKS details about the car with the given id.

o	RETURNS a string representation of the car.


•	open {id} {type} {length} {route} {prizePool}
o	OPENS a race of the given type, with the given id, and stats.

o	The race type will be either “Casual”, “Drag” or “Drift”.
•	participate {carId} {raceId}

o	ADDS a car as a participant in the given race.
o	Once added, a car CANNOT turn down a race or be REMOVED from it.

•	start {raceId}
o	INITIATES the race with the given id. 
o	RETURNS detailed information about the race result.
•	park {carId}

o	PARKS a car by a given id in the garage.
•	unpark {carId}

o	UNPARKS the car with the given id from the garage.

•	tune {tuneIndex} {tuneAddOn}

o	Tunes the currently parked CARS with the given index and the given add-on.
o	You should increase a car’s horsepower by the given index, and the suspension, by HALF of the given index.

–	150 tuneIndex = 150 increase in the horsepower and 75 increase in suspension.


o	If the car is a ShowCar it should increase its stars by the given tuneIndex.

o	Upon tuning, a PerformanceCar adds the given add-on to its collection of add-ons.
Functionality
Cars and Races are the main entities in the program’s functionality. They have no suitable way to be ACCESSED, which is why, upon registration, they are given an Id. The Id will be a simple integer. There is NO need for Cars and Races to know their Ids. The CarManager is the one that controls the main logic, which is why it is the only class which needs to know of every car and race’s id.
When you register a car, you store it in such a way, so that you can access it by id. You can then make the car participate in a race, or select it in the garage. There are several RULES that you must follow:

1.	Once a car has been ADDED as a participant in a race, it CANNOT be PARKED in the garage, UNTIL the race is OVER.
o	IGNORE any attempt to park a racer car. 

2.	A car, which has been PARKED in the garage, CANNOT participate in a race.

o	IGNORE any attempt to include a parked car in a race.

3.	IGNORE any attempt to TUNE cars, when there are NO PARKED cars in the garage.

4.	SINGLE car CAN participate in MANY races.

5.	A race CANNOT start without ANY participants.

6.	A race CAN start with LESS than three participants.
Performance points (PP) determine every race’s winners. PP are either Overall Performance, Engine Performance or Suspension Performance. Here are the different formulas:

•	A CasualRace determines its winners based on their Overall Performance (OP) (in DESCENDING order). Overall Performance, of EACH CAR, is calculated by the following formula:
(horsepower / acceleration) + (suspension + durability)

•	A DragRace determines its winners based on their Engine Performance (EP) (in DESCENDING order). Engine Performance, of EACH CAR, is calculated by the following formula:
(horsepower / acceleration) 

•	A DriftRace determines its winners based on their Suspension Performance (SP) (in DESCENDING order). Suspension Performance, of EACH CAR, is calculated by the following formula:
(suspension + durability)
Depending on the different TYPE of RACE, different type of POINTS are calculated for the racers. In the end all points are presented as Performance Points (in the OUTPUT).
When you OPEN a race, you register it – this provides the functionality to add participants to it. 
When you START a race, the winners are calculated immediately, PRINTED as output, and the race becomes CLOSED (you CANNOT add any more participants in it, and you CANNOT start it again). 

If TWO cars have the SAME result, participant registered before the other comes FIRST.
The 1st place winner takes 50 % of the race’s prize pool.
The 2nd place winner takes 30 % of the race’s prize pool.
The 3rd place winner takes 20 % of the race’s prize pool.

You need to take in account ONLY the FIRST 3 players, AFTER you’ve ordered them in descending order, by the corresponding criteria.
In case a race has LESS than 3 participants, you should print only them, as winners. The prizes remain the SAME.
In case a race has NO participants, you should print “Cannot start the race with zero participants.”, and IGNORE the command.
Task III: I / O (Input / Output)
Input
•	The input will come in the form of commands, in the format specified above.

•	The input sequence ends when you receive the command “Cops Are Here”.
Output

Two elements generate output in the program’s functionality:

•	The “check” command should RETURN a String representation of the CAR with the GIVEN ID:

o	“{brand} {model} {yearOfProduction}
o	 {horsepower} HP, 100 m/h in {acceleration} s
o	 {suspension} Suspension force, {durability} Durability”

o	If the car is a PerformanceCar, you must print “Add-ons: {add-ons}”, on the last line – each add-on separated by a comma and a space “, “. In case there are NO add-ons, print “None”.

o	If the car is a ShowCar, you must print “{stars} *”, on the last line.

•	The “start” command should RETURN a String representation the RACE with the GIVEN ID:

o	“{route} - {length}
o	 1. {brand} {model} {performancePoints}PP - ${moneyWon}
o	 2. {brand} {model} {performancePoints}PP - ${moneyWon}
o	 3. {brand} {model} {performancePoints}PP - ${moneyWon}”
o	1, 2 and 3 – being the 1st, 2nd and 3rd participants (the winners). 

o	If there are LESS than 3 participants, print as much as there are.
o	In case there are NO participants, print “Cannot start the race with zero participants.”, and IGNORE the command.
Constrains

•	All integers in the input will be in range [0, 100000].

•	All strings in the input may consist of any ASCII character, except SPACE

o	So that the input is easily processed.

•	There will be NO invalid input lines, or invalid (non-existent) Ids.

•	Note that throughout the program, you are working ONLY with INTEGERS.

o	Each mathematical or logical action performed on numeric data, should be performed between INTEGERS.

•	Note: 50% of X is EQUAL to (X * 50) / 100.

•	Note: Decrease means DECREASE… 100 decreased by 25% = 100 – (100 * 25) / 100 = 100 – 25 = 75.
