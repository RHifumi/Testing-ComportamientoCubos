![Unity](https://img.shields.io/badge/Engine-Unity2019.4-blue?logo=unity)
![CSharp](https://img.shields.io/badge/Language-C%23-brightgreen)
# Testing-ComportamientoCubos
Pequeño proyecto desarrollado en Unity 2019.4.41f2 a forma de test para practicar, la implementación de clases abstractas, herencia y polimorfismo para objetos en unity. Practica de cámara en primera persona con movimiento del cursor.
---
## Script principales
`Cubo.cs` Clase base abstracta.


`CuboSeguidor.cs` Subclase que hereda de `Cubo.cs` sobreescribe los metodos abstractos de la clase, y aprovecha la implementación de varibales y metodos como Start() y Update() de su clase base para organizar su codigo y comportamiento de forma limpia.


`CuboEscapador.cs` Subclase que hereda de `CuboSeguidor.cs` polimorfismo para realizar un comportamiento personalizado, aprovecha la implementación de gracias a un base.Start() y con un ajuste pequeño en una variable consigue generar un comportamiento nuevo.


`RiniCamera.cs` Scrpit encargado de la detección del cursor, aplica un Lerp, para ajustar la sensibilidad detectada y realiar un movimiento de cámara en el simulador, bloquea la rotación y esconde el cursor para un efecto más logrado.


---
## Objetivos
Crear 3 comportamientos distintos en base a una clase abstracta que determina su color, tamañao y como se mueven en el entorno, 2 de ellos en relación a un jugador, uno lo busca mientras otro se aleja, el tercero simplmente se desplaza, pero en cada inicio su color es aleatorio. Para ello utilizo:


-`public abstract class Cubo : MonoBehaviour` -> Para declarar una clase abstracta.


-`public abstract void Mover();` -> Para establecer metodos abstractos, como Color, Tamaño y Movmiento.


-`public override void Mover()` -> Para sobreescribir en las subclases los metodos.


-`transform.Translate(rapidez * Vector3.forward * Time.deltaTime);` -> Desplazamiento hacía un objetivo establecido, y una velocidad negativa para crear un efecto de alejarse del objetivo.


-`Cuerpo.GetComponent<Renderer>().material.color = color;` -> Para acceder a la propiedad de color de un objeto y determinarla en base al scrpit.


-`Color color = new Color(r: UnityEngine.Random.Range(0f, 1f), g: UnityEngine.Random.Range(0f, 1f), b: UnityEngine.Random.Range(0f, 1f));` -> Determinar un componente de color aleatorio en cada ejecusión del proyecto.


-`var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));` -> Variable que guarda la posición del cursor, en un Update() puede establecer en tiempo de ejecución el movimiento que se realiza.


-`transform.localRotation = Quaternion.AngleAxis(-mouseMirar.y, Vector3.right);` -> Calcula la rotación de la cámara en relación al movimiento realizado por el cursor.


-`cuerpoJugador.transform.localRotation = Quaternion.AngleAxis(mouseMirar.x, cuerpoJugador.transform.up);` -> Realiza una rotación del objeto para simular un movimiento en primera persona, y generar una sensación de movilidad más inmersiva.


---
## Escenas de simulación
(Screenshots/CuboHerencia1.png)
(Screenshots/CuboHerencia2.png)

