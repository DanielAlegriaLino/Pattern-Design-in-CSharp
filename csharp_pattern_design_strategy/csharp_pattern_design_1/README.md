# STRATEGY 
This patter allow us to create something like the next workflow: <br>

![alt text](http://lh3.ggpht.com/_FOkvp7M3tJA/TAo5U4jFsyI/AAAAAAAAAPI/VxGuRhmOH-o/StrategyPattern.JPG)

In the image, we can see how in this scenario, Context = Pato.cs, this is an abstract class, that means that it can declare Methods without implement them; also, **Pato.cs** has an attributed named **public INadar comportamiento_nadar** and **public IQuack comportamiento_quack** these are two differen examples of **Strategies**. <br>

Later, **Pato_Madera.cs** and **Pato_Vioento** inherit **Pato.cs**(Context).

And Finally, **Inadar** and **IQuack** have their own (*concrete strategies*) like **Nadar_SoloFlotar, Nadar_Veloz** and **Quack_Muteado, Quack_Squeak, Quack_Feroz, Quack_Cansado**. 
