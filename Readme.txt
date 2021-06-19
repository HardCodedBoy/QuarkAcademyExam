Por favor, especifica tu nombre completo: ___Bruno Riba______________
¿C# permite herencia múltiple?
---No, no lo permite. Solo permite la herencia de una sola clase. De todos modos, sí es posible que una clase implemente todas las interfaces que quiera.

¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
---Elegiría la Clase Abstracta cuando tenga dos clases o más que compartan mismos métodos y, a su vez, la implementación de estos.
Un ejemplo sería implementar una interfaz IInteractable en todos los objetos con los que un usuario en un juego podría interactuar. Acá vemos que todos los objetos comparten el método Interactuar(), pero ninguno de ellos ejecuta las mismas sentencias de código.
La clase abstracta la podemos ejemplificar con clase abstracta Humano, en donde ésta tenga métodos (CON UNA IMPLEMENTACIÓN) común a todos los seres humanos.

¿Qué implica una relación de Generalización entre dos clases?
---Se refiere a una relación en donde las clases que interactúan entre sí establecen un vínculo tipo "Padre" e "Hijo". Básicamente sería una Herencia.

¿Qué implica una relación de Implementación entre una clase y una interfaz?
---Implica la obligación, de la clase, de implementar las propiedades y métodos declarados en la interfaz


¿Qué diferencia hay entre la relación de Composición y la Agregación?

La agregación trata de una ralación en donde una parte puede seguir existiendo en ausencia de un "todo". En cambio, la composición, define una relación en donde la parte depende de la existencia de un "todo".

Indique V o F según corresponda. Diferencia entre Asociación y Agregación:
Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
---Verdadero


Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. 
---Falso


Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 
---Falso




Fe de erratas: No logré hacer el ejercicio de la impresión, me faltó tiempo.