En este proyecto se utilizaron 3 tipos distintos de joints (o articulaciones) que tiene disponible Unity.
Estos componentes son como anclas que unen dos componentes Rigidbody de distintas formas.

Primero, el Fixed Joint
Este joint hace que dos rigidbodys se mantengan unidos sin que se roten o se muevan de ninguna forma (excepto al aplicar una fuerza)
Este joint fue utilizado en este proyecto para crear un puente "indestructible" que solo se rompe si se aplica una fuerza muy grande (como el dejar caer un objeto desde muy alto o mantener un objeto pesado)


Segundo, el Hinge Joint
Este joint hace que un rigidbody conectado a otro rote sobre un eje, ya sea el X, Y o Z, o incluso una combinación de varios.
En el proyecto se usó como una bisagra de una puerta conectada a una pared, y se puede mover sola con motor o al ser empujada por un objeto (en nuestro caso una esfera)

Y por último el Spring Joint
Este joint sirve como muelle o una cuerda elástica entre dos rigidbodys.
En el proyecto se usó como simulación de una cuerda de bungee, en la que uno de los extremos se une al techo y el otro a una esfera, y al caer la esfera la "cuerda" (el joint) se tensa y destensa como en la vida real
